﻿using SM.Metadata;
using System;
using System.ComponentModel.DataAnnotations;

namespace SM.DataAccess
{
    [MetadataType(typeof(CourseSlotScenarioMetadata))]
    public class CourseSlotScenario
    {
        public Guid CourseId { get; set; }

        public Guid CourseSlotId { get; set; }

        public Guid ScenarioId { get; set; }

        public virtual Course Course { get; set; }

        public virtual CourseSlot CourseSlot { get; set; }

        public virtual Scenario Scenario{ get; set; }
    }

    /*
    [MetadataType(typeof(ActivityFacultyRoleMetadata))]
    public class ActivityFacultyRole
    {
        public Guid CourseId { get; set; }

        public Guid ActivityId { get; set; }

        public Guid FacultyMemberId { get; set; }

        public Guid RoleId { get; set; }

        public virtual Course Course { get; set; }
        public virtual CourseActivity Activity { get; set; }
        public virtual Activi Role { get; set; }
        public virtual Participant FacultyMember { get; set; }
    }
    */
}
