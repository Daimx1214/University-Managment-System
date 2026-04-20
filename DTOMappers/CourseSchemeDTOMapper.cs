using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class CourseSchemeDTOMapper
    {
        public static CourseScheme CourseSchemeDTOToEntityMapper(CourseSchemeRequestDTO dto)
        {
            CourseScheme scheme = new CourseScheme();
            scheme.SubjectId = dto.SubjectId;
            scheme.SubjectTypeId = dto.SubjectTypeId;
            scheme.CreditHours = dto.CreditHours;
            scheme.DegreeProgramId = dto.DegreeProgramId;
            scheme.ProgramSessionId = dto.ProgramSessionId;
            scheme.SemesterId = dto.SemesterId;
            return scheme;
        }

        public static CourseScheme CourseSchemeDTOToEntityMapper(CourseScheme entity, CourseSchemeRequestDTO dto)
        {
            entity.SubjectId = dto.SubjectId;
            entity.SubjectTypeId = dto.SubjectTypeId;
            entity.CreditHours = dto.CreditHours;
            entity.DegreeProgramId = dto.DegreeProgramId;
            entity.ProgramSessionId = dto.ProgramSessionId;
            entity.SemesterId = dto.SemesterId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static CourseSchemeResponseDTO EntityToCourseSchemeDTO(CourseScheme entity)
        {
            CourseSchemeResponseDTO response = new CourseSchemeResponseDTO();
            response.Id = entity.Id;
            response.SubjectId = entity.SubjectId;
            response.SubjectTypeId = entity.SubjectTypeId;
            response.CreditHours = entity.CreditHours;
            response.DegreeProgramId = entity.DegreeProgramId;
            response.ProgramSessionId = entity.ProgramSessionId;
            response.SemesterId = entity.SemesterId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<CourseSchemeResponseDTO> EntitiesToCourseSchemeDTOs(List<CourseScheme> entities)
        {
            List<CourseSchemeResponseDTO> responseList = new List<CourseSchemeResponseDTO>();
            foreach (CourseScheme entity in entities)
            {
                responseList.Add(EntityToCourseSchemeDTO(entity));
            }
            return responseList;
        }
    }
}
