using Azure;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class RoomTypeAllocationDTOMapper
    {
        public static RoomTypeAllocation RoomTypeAllocationDTOToEntityMapper(RoomTypeAllocationRequestDTO dto)
        {
            RoomTypeAllocation entity = new RoomTypeAllocation();
            entity.RoomId = dto.RoomId;
            entity.RoomTypeId = dto.RoomTypeId;
            return entity;
        }

        public static RoomTypeAllocation RoomTypeAllocationDTOToEntityMapper(RoomTypeAllocation entity, RoomTypeAllocationRequestDTO dto)
        {
            entity.RoomId = dto.RoomId;
            entity.RoomTypeId = dto.RoomTypeId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static RoomTypeAllocationResponseDTO EntityToRoomTypeAllocationDTO(RoomTypeAllocation entity)
        {
            RoomTypeAllocationResponseDTO response = new RoomTypeAllocationResponseDTO();
            response.Id = entity.Id;
            response.RoomId = entity.RoomId;
            response.RoomTypeId = entity.RoomTypeId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<RoomTypeAllocationResponseDTO> EntitiesToRoomTypeAllocationDTOs(List<RoomTypeAllocation> entities)
        {
            List<RoomTypeAllocationResponseDTO> responseList = new List<RoomTypeAllocationResponseDTO>();
            foreach (RoomTypeAllocation entity in entities)
            {
                responseList.Add(EntityToRoomTypeAllocationDTO(entity));
            }
            return responseList;
        }
    }
}
