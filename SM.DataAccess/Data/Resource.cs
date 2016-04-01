using SM.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SM.DataAccess
{
    public abstract class Resource
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ResourceFilename { get; set; }
    }
    [MetadataType(typeof(ResourceMetadata))]
    public class ActivityTeachingResource : Resource
    {
        public Guid CourseActivityId { get; set; }
        public virtual CourseActivity CourseActivity { get; set; }

        ICollection<ChosenTeachingResource> _chosenTeachingResources;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChosenTeachingResource> ChosenTeachingResources
        {
            get
            {
                return _chosenTeachingResources ?? (_chosenTeachingResources = new List<ChosenTeachingResource>());
            }
            set
            {
                _chosenTeachingResources = value;
            }
        }
    }

    [MetadataType(typeof(ResourceMetadata))]
    public class ScenarioResource : Resource
    {
        public Guid ScenarioId { get; set; }
        public virtual Scenario Scenario { get; set; }
    }
}
