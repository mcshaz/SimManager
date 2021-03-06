using SP.DataAccess;

namespace SP.Dto.Maps
{
    internal class CourseActivityMaps: DomainDtoMap<CourseActivity, CourseActivityDto>
    {
        public CourseActivityMaps() : base(
        m => new CourseActivity
        {
            Id = m.Id,
            Name = m.Name,
            CourseTypeId = m.CourseTypeId
        },
        m => new CourseActivityDto
        {
            Id = m.Id,
            Name = m.Name,
            CourseTypeId = m.CourseTypeId
        })
        { }
    }
}
