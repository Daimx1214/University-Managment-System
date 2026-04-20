using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class StructureDesignationDTOMapper
    {
        public static StructureDesignation StructureDesignationDTOToEntityMapper(StructureDesignationRequestDTO dto)
        {
            StructureDesignation entity = new StructureDesignation();
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            return entity;
        }

        public static StructureDesignation StructureDesignationDTOToEntityMapper(StructureDesignation entity, StructureDesignationRequestDTO dto)
        {
            entity.StructureUnitId = dto.StructureUnitId;
            entity.DesignationId = dto.DesignationId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static StructureDesignationResponseDTO EntityToStructureDesignationDTO(StructureDesignation entity)
        {
            StructureDesignationResponseDTO response = new StructureDesignationResponseDTO();
            response.Id = entity.Id;
            response.StructureUnitId = entity.StructureUnitId;
            response.DesignationId = entity.DesignationId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<StructureDesignationResponseDTO> EntitiesToStructureDesignationDTOs(List<StructureDesignation> entities)
        {
            List<StructureDesignationResponseDTO> responseList = new List<StructureDesignationResponseDTO>();
            foreach (StructureDesignation entity in entities)
            {
                responseList.Add(EntityToStructureDesignationDTO(entity));
            }
            return responseList;
        }
    }
}
