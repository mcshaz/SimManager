using SP.DataAccess;

namespace SP.Dto.Maps
{
    internal class CourseFormatMaps: DomainDtoMap<CourseFormat, CourseFormatDto>
    {
        public CourseFormatMaps() : base(m => new CourseFormat
            {
                Id = m.Id,
                DaysDuration = m.DaysDuration,
                Description = m.Description,
                CourseTypeId = m.CourseTypeId,
                Obsolete = m.Obsolete,
                HotDrinkProvided = m.HotDrinkProvided,
                MealProvided = m.MealProvided,
                DefaultStartTime = m.DefaultStartTime
            },
            m => new CourseFormatDto
            {
                Id = m.Id,
                DaysDuration = m.DaysDuration,
                Description = m.Description,
                CourseTypeId = m.CourseTypeId,
                Obsolete = m.Obsolete,
                HotDrinkProvided = m.HotDrinkProvided,
                MealProvided = m.MealProvided,
                DefaultStartTime = m.DefaultStartTime
            })
        { }
    }
}
