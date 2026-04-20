using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class PEODTOMapper
    {
        public static PEO PEODTOToEntityMapper(PEORequestDTO dto)
        {
            PEO entity = new PEO();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            return entity;
        }

        public static PEO PEODTOToEntityMapper(PEO entity, PEORequestDTO dto)
        {
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.DegreeProgramId = dto.DegreeProgramId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static PEOResponseDTO EntityToPEODTO(PEO entity)
        {
            PEOResponseDTO response = new PEOResponseDTO();
            response.Id = entity.Id;
            response.Description = entity.Description;
            response.Code = entity.Code;
            response.DegreeProgramId = entity.DegreeProgramId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<PEOResponseDTO> EntitiesToPEODTOs(List<PEO> entities)
        {
            List<PEOResponseDTO> responseList = new List<PEOResponseDTO>();
            foreach (PEO entity in entities)
            {
                responseList.Add(EntityToPEODTO(entity));
            }
            return responseList;
        }
    }
}
