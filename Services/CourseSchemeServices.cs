using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class CourseSchemeServices
    {
        private readonly ICourseSchemeRepository _courseSchemeRepository;
        public CourseSchemeServices(ICourseSchemeRepository courseSchemeRepository)
        {
            _courseSchemeRepository = courseSchemeRepository;
        }
        public async Task<CourseScheme> AddCourseScheme(CourseSchemeRequestDTO request)
        {
            CourseScheme courseScheme = CourseSchemeDTOMapper.CourseSchemeDTOToEntityMapper(request);
            courseScheme.CreatedAt = DateTime.Now;
            await _courseSchemeRepository.Add(courseScheme);
            _courseSchemeRepository.Save();
            return courseScheme;
        }
        public List<CourseSchemeResponseDTO> GetAll()
        {
            List<CourseScheme> courseSchemes = _courseSchemeRepository.GetAll().ToList();
            return CourseSchemeDTOMapper.EntitiesToCourseSchemeDTOs(courseSchemes);
        }
        public bool RemoveCourseScheme(int? id)
        {
            CourseScheme courseScheme = _courseSchemeRepository.Get(ans => ans.Id == id);
            if (courseScheme == null)
            {
                return false;
            }
            _courseSchemeRepository.Remove(courseScheme);
            _courseSchemeRepository.Save();
            return true;
        }
    }
}
