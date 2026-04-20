using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class DegreeProgramDTOMapper
    {
        public static DegreeProgram DegreeProgramDTOToEntityMapper(DegreeProgramRequestDTO dto)
        {
            DegreeProgram program = new DegreeProgram();
            program.DegreeProgramName = dto.DegreeProgramName;
            program.Description = dto.Description;
            program.Code = dto.Code;
            program.DegreeLevelId = dto.DegreeLevelId;
            program.DepartmentId = dto.DepartmentId;
            return program;
        }

        public static DegreeProgram DegreeProgramDTOToEntityMapper(DegreeProgram entity, DegreeProgramRequestDTO dto)
        {
            entity.DegreeProgramName = dto.DegreeProgramName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeLevelId = dto.DegreeLevelId;
            entity.DepartmentId = dto.DepartmentId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static DegreeProgramResponseDTO EntityToDegreeProgramDTO(DegreeProgram entity)
        {
            DegreeProgramResponseDTO response = new DegreeProgramResponseDTO();
            response.Id = entity.Id;
            response.DegreeProgramName = entity.DegreeProgramName;
            response.Description = entity.Description;
            response.Code = entity.Code;
            response.DegreeLevelId = entity.DegreeLevelId;
            response.DepartmentId = entity.DepartmentId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<DegreeProgramResponseDTO> EntitiesToDegreeProgramDTOs(List<DegreeProgram> entities)
        {
            List<DegreeProgramResponseDTO> responseList = new List<DegreeProgramResponseDTO>();
            foreach (DegreeProgram entity in entities)
            {
                responseList.Add(EntityToDegreeProgramDTO(entity));
            }
            return responseList;
        }
    }
}
