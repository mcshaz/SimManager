﻿(function () {
    'use strict';
    var controllerId = 'course';
    angular
        .module('app')
        .controller(controllerId, controller);

    controller.$inject = ['controller.abstract', '$routeParams', 'common', 'datacontext', '$modal', 'breeze', '$scope'];

    function controller(abstractController, $routeParams, common, datacontext,  $modal, breeze, $scope) {
        /* jshint validthis:true */
        var vm = this;
        abstractController.constructor.call(this, {
            controllerId: controllerId,
            watchedEntityName: 'course',
            $scope: $scope
        })
        var id = $routeParams.id;
        var isNew = id == 'new';

        vm.course = {};
        vm.courseTypes = [];
        vm.dateFormat = '';
        vm.deleteCourseParticipant = deleteCourseParticipant;
        vm.dpPopup = { isOpen: false };
        vm.departments = [];
        
        vm.hasChanges = false;
        vm.maxDate = new Date();
        vm.maxDate.setFullYear(vm.maxDate.getFullYear() + 1);
        vm.minDate = new Date(2007, 0);
        vm.openDp = openDp;
        vm.openCourseParticipant = openCourseParticipant;
        vm.rooms = [];
        vm.save = save;
        vm.title = 'course';

        activate();

        function activate() {
            datacontext.ready().then(function () {
                var promises =[ datacontext.courseTypes.all().then(function (data) {
                    vm.courseTypes = data;
                }),datacontext.departments.all().then(function (data) {
                    vm.departments = data;
                }), datacontext.rooms.all().then(function (data) {
                    vm.rooms = data;
                })];
                if (isNew) {
                    vm.course = datacontext.courses.create();
                }else{
                    promises.push(datacontext.courses.fetchByKey(id, {expand:'courseParticipants.participant'}).then(function (data) {
                        if (!data) {
                            vm.log.warning('Could not find course id = ' +id);
                            return;
                            //gotoCourses();
                        }
                        vm.course = data;
                    }));
                }
                common.activateController(promises, controllerId)
                    .then(function () {
                        vm.log('Activated Course View');
                    });
            });
        }

        function openDp() {
            this.dpPopup.isOpen = true;
        }

        function save($event) {
            //vm.log.debug($event);
            datacontext.save();
        }//;

        function openCourseParticipant(participantId) {
            var isNew = participantId.startsWith('new');
            var courseParticipant = isNew
                ? null
                : getCourseParticipant(participantId);
            var isFaculty = isNew
                ? participantId.endsWith('Faculty')
                : courseParticipant.participant.isFaculty;
            var modalInstance = $modal({
                templateUrl: 'app/courseParticipant/courseParticipant.html',
                controller: 'courseParticipant',
                controllerAs: 'cp',
                show:true,
                $scope:{}, //?
                //size: 'lg',
                resolve: {
                    currentCourse: function () {
                        return {
                            courseParticipant: courseParticipant,
                            course:vm.course, //possibly should pass the id here and use datacontext to fetch from cache - would make it more usable outside of a modal window
                            isFaculty: isFaculty
                        };
                    }
                }
            });
        }

        function deleteCourseParticipant(participantId) {
            var cp = getCourseParticipant(participantId);
            cp.entityAspect.setDeleted();
            datacontext.save(cp).then(function (data) { vm.log('removed ' + cp.participant.fullName + ' from course');},
                function (error) { log.error({ msg: 'failed to remove ' + cp.participant.fullName + ' from course' }) })
        }

        function getCourseParticipant(participantId) {
            return vm.course.courseParticipants.find(function (cp) {
                return cp.participantId === participantId;
            })
        }
    }
})();
