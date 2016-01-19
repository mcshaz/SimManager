namespace SM.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructorCourseParticipant")]
    public partial class InstructorCourseParticipant
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParticipantId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        public bool WaitListed { get; set; }

        public virtual Participant Participant { get; set; }

        public virtual InstructorCourse InstructorCourse { get; set; }
    }
}
