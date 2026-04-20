using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagementSystem.DTOMappers
{
    public class RoomFeatureAllocationDTOMapper
    {
        public static RoomFeatureAllocation RoomFeatureAllocationDTOToEntityMapper(RoomFeatureAllocationRequestDTO dto)
        {
            RoomFeatureAllocation entity = new RoomFeatureAllocation();
            entity.RoomId = dto.RoomId;
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.Quantity = dto.Quantity;
            return entity;
        }

        public static RoomFeatureAllocation RoomFeatureAllocationDTOToEntityMapper(RoomFeatureAllocation entity, RoomFeatureAllocationRequestDTO dto)
        {
            entity.RoomId = dto.RoomId;
            entity.RoomFeatureId = dto.RoomFeatureId;
            entity.Quantity = dto.Quantity;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static RoomFeatureAllocationResponseDTO EntityToRoomFeatureAllocationDTO(RoomFeatureAllocation entity)
        {
            RoomFeatureAllocationResponseDTO response = new RoomFeatureAllocationResponseDTO();
            response.Id = entity.Id;
            response.RoomId = entity.RoomId;
            response.RoomFeatureId = entity.RoomFeatureId;
            response.Quantity = entity.Quantity;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<RoomFeatureAllocationResponseDTO> EntitiesToRoomFeatureAllocationDTOs(List<RoomFeatureAllocation> entities)
        {
            List<RoomFeatureAllocationResponseDTO> responseList = new List<RoomFeatureAllocationResponseDTO>();
            foreach (RoomFeatureAllocation entity in entities)
            {
                responseList.Add(EntityToRoomFeatureAllocationDTO(entity));
            }
            return responseList;
        }
    }
}
