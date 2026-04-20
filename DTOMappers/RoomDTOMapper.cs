using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class RoomDTOMapper
    {
        public static Room RoomDTOToEntityMapper(RoomRequestDTO dto)
        {
            Room entity = new Room();
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.FloorId = dto.FloorId;
            return entity;
        }

        public static Room RoomDTOToEntityMapper(Room entity, RoomRequestDTO dto)
        {
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.FloorId = dto.FloorId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static RoomResponseDTO EntityToRoomDTO(Room entity)
        {
            RoomResponseDTO response = new RoomResponseDTO();
            response.Id = entity.Id;
            response.Name = entity.Name;
            response.Code = entity.Code;
            response.Description = entity.Description;
            response.EstablishedIn = entity.EstablishedIn;
            response.Address = entity.Address;
            response.FloorId = entity.FloorId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<RoomResponseDTO> EntitiesToRoomDTOs(List<Room> entities)
        {
            List<RoomResponseDTO> responseList = new List<RoomResponseDTO>();
            foreach (Room entity in entities)
            {
                responseList.Add(EntityToRoomDTO(entity));
            }
            return responseList;
        }
    }
}
