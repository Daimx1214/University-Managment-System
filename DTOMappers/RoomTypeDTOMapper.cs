using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomTypeDTOMapper
    {
        public static RoomType RoomTypeDTOToEntityMapper(RoomTypeRequestDTO roomTypeRequestDTO)
        {
            RoomType roomType = new RoomType();
            roomType.Name = roomTypeRequestDTO.Name;
            roomType.Code = roomTypeRequestDTO.Code;
            roomType.Description = roomTypeRequestDTO.Description;
            return roomType;
        }

        public static RoomType RoomTypeDTOToEntityMappers(RoomType roomType, RoomTypeRequestDTO roomTypeRequestDTO)
        {
            roomType.Name = roomTypeRequestDTO.Name;
            roomType.Code = roomTypeRequestDTO.Code;
            roomType.Description = roomTypeRequestDTO.Description;
            return roomType;
        }
        public static RoomTypeResponseDTO EntityToRoomTypeDTO(RoomType roomType)
        {
            RoomTypeResponseDTO roomTypeResponseDTO = new RoomTypeResponseDTO();
            roomTypeResponseDTO.Id = roomType.Id;
            roomTypeResponseDTO.Name = roomType.Name;
            roomTypeResponseDTO.Code = roomType.Code;
            roomTypeResponseDTO.Description = roomType.Description;
            return roomTypeResponseDTO;
        }



        public static List<RoomTypeResponseDTO> RoomTypeEntityToDTOMapper(List<RoomType> roomTypes)
        {
            List<RoomTypeResponseDTO> roomTypeResponseDTOs = new List<RoomTypeResponseDTO>();
            foreach (RoomType roomTypeItem in roomTypes)
            {
                RoomTypeResponseDTO roomTypeResponseDTO = EntityToRoomTypeDTO(roomTypeItem);
                roomTypeResponseDTOs.Add(roomTypeResponseDTO);
            }
            return roomTypeResponseDTOs;
        }
    }
}
