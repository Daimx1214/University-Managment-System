using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class PEOToPLODTOMapper
    {
        public static PEOToPLO PEOToPLODTOToEntityMapper(PEOToPLORequestDTO dto)
        {
            PEOToPLO entity = new PEOToPLO();
            entity.Id = dto.Id;
            entity.Weightage = dto.Weightage;
            entity.PEOId = dto.PEOId;
            entity.PLOId = dto.PLOId;
            return entity;
        }

        public static PEOToPLO PEOToPLODTOToEntityMapper(PEOToPLO entity, PEOToPLORequestDTO dto)
        {
            entity.Id = dto.Id;
            entity.Weightage = dto.Weightage;
            entity.PEOId = dto.PEOId;
            entity.PLOId = dto.PLOId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static PEOToPLOResponseDTO EntityToPEOToPLODTO(PEOToPLO entity)
        {
            PEOToPLOResponseDTO response = new PEOToPLOResponseDTO();
            response.Id = entity.Id;
            response.Weightage = entity.Weightage;
            response.PEOId = entity.PEOId;
            response.PLOId = entity.PLOId;
            response.CreatedAt = entity.CreatedAt;
            response.UpdatedAt = entity.UpdatedAt;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<PEOToPLOResponseDTO> EntitiesToPEOToPLODTOs(List<PEOToPLO> entities)
        {
            List<PEOToPLOResponseDTO> responseList = new List<PEOToPLOResponseDTO>();
            foreach (PEOToPLO entity in entities)
            {
                responseList.Add(EntityToPEOToPLODTO(entity));
            }
            return responseList;
        }
    }
}
