using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class StructureUnitDTOMapper
    {
        public static StructureUnit StructureUnitDTOToEntityMapper(StructureUnitRequestDTO dto)
        {
            StructureUnit entity = new StructureUnit();
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            return entity;
        }

        public static StructureUnit StructureUnitDTOToEntityMapper(StructureUnit entity, StructureUnitRequestDTO dto)
        {
            entity.StructureUnitName = dto.StructureUnitName;
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.StructureTypeId = dto.StructureTypeId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static StructureUnitResponseDTO EntityToStructureUnitDTO(StructureUnit entity)
        {
            StructureUnitResponseDTO response = new StructureUnitResponseDTO();
            response.Id = entity.Id;
            response.StructureUnitName = entity.StructureUnitName;
            response.Description = entity.Description;
            response.Code = entity.Code;
            response.StructureTypeId = entity.StructureTypeId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<StructureUnitResponseDTO> EntitiesToStructureUnitDTOs(List<StructureUnit> entities)
        {
            List<StructureUnitResponseDTO> responseList = new List<StructureUnitResponseDTO>();
            foreach (StructureUnit entity in entities)
            {
                responseList.Add(EntityToStructureUnitDTO(entity));
            }
            return responseList;
        }
    }
}
