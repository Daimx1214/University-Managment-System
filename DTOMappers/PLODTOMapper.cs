using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class PLODTOMapper
    {
        public static PLO PLODTOToEntityMapper(PLORequestDTO dto)
        {
            PLO entity = new PLO();
            entity.Description = dto.Description;
            entity.code = dto.code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            return entity;
        }

        public static PLO PLODTOToEntityMapper(PLO entity, PLORequestDTO dto)
        {
            entity.Description = dto.Description;
            entity.code = dto.code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static PLOResponseDTO EntityToPLODTO(PLO entity)
        {
            PLOResponseDTO response = new PLOResponseDTO();
            response.Id = entity.Id;
            response.Description = entity.Description;
            response.code = entity.code;
            response.DegreeProgramId = entity.DegreeProgramId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<PLOResponseDTO> EntitiesToPLODTOs(List<PLO> entities)
        {
            List<PLOResponseDTO> responseList = new List<PLOResponseDTO>();
            foreach (PLO entity in entities)
            {
                responseList.Add(EntityToPLODTO(entity));
            }
            return responseList;
        }
    }
}
