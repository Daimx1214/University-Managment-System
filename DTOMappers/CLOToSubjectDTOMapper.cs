using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class CLOToSubjectDTOMapper
    {
        public static CLOToSubject CLOToSubjectDTOToEntityMapper(CLOToSubjectRequestDTO dto)
        {
            CLOToSubject cloToSubject = new CLOToSubject();
            cloToSubject.CLOId = dto.CLOId;
            cloToSubject.CourseSchemeId = dto.CourseSchemeId;
            cloToSubject.ProgramSessionId = dto.ProgramSessionId;
            return cloToSubject;
        }

        public static CLOToSubject CLOToSubjectDTOToEntityMapper(CLOToSubject entity, CLOToSubjectRequestDTO dto)
        {
            entity.CLOId = dto.CLOId;
            entity.CourseSchemeId = dto.CourseSchemeId;
            entity.ProgramSessionId = dto.ProgramSessionId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static CLOToSubjectResponseDTO EntityToCLOToSubjectDTO(CLOToSubject entity)
        {
            CLOToSubjectResponseDTO response = new CLOToSubjectResponseDTO();
            response.Id = entity.Id;
            response.CLOId = entity.CLOId;
            response.CourseSchemeId = entity.CourseSchemeId;
            response.ProgramSessionId = entity.ProgramSessionId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<CLOToSubjectResponseDTO> EntitiesToCLOToSubjectDTOs(List<CLOToSubject> entities)
        {
            List<CLOToSubjectResponseDTO> responseList = new List<CLOToSubjectResponseDTO>();
            foreach (CLOToSubject entity in entities)
            {
                responseList.Add(EntityToCLOToSubjectDTO(entity));
            }
            return responseList;
        }
    }
}
