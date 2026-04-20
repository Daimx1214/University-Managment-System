using Microsoft.AspNetCore.Http.Features;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class RoomFeatureDTOMapper
    {
        public static RoomFeature RoomFeatureDTOToEntityMapper(RoomFeatureRequestDTO roomFeatureRequestDTO)
        {
            RoomFeature roomFeature = new RoomFeature();
            roomFeature.Name = roomFeatureRequestDTO.Name;
            roomFeature.Code = roomFeatureRequestDTO.Code;
            roomFeature.Description = roomFeatureRequestDTO.Description;
            return roomFeature;
        }
        public static RoomFeature RoomFeatureDTOToEntityMappers(RoomFeature roomFeature, RoomFeatureRequestDTO roomFeatureRequestDTO)
        {
            roomFeature.Name = roomFeatureRequestDTO.Name;
            roomFeature.Code = roomFeatureRequestDTO.Code;
            roomFeature.Description = roomFeatureRequestDTO.Description;
            return roomFeature;
        }
        public static RoomFeatureResponseDTO EntityToRoomFeatureDTO(RoomFeature roomFeature)
        {
            RoomFeatureResponseDTO roomFeatureResponseDTO = new RoomFeatureResponseDTO();
            roomFeatureResponseDTO.Id = roomFeature.Id;
            roomFeatureResponseDTO.Name = roomFeature.Name;
            roomFeatureResponseDTO.Code = roomFeature.Code;
            roomFeatureResponseDTO.Description = roomFeature.Description;
            roomFeatureResponseDTO.CreatedAt = roomFeature.CreatedAt;
            roomFeatureResponseDTO.UpdatedAt = roomFeature.UpdatedAt;
            roomFeatureResponseDTO.GlobalId = roomFeature.GlobalId;
            return roomFeatureResponseDTO;
        }

        public static List<RoomFeatureResponseDTO> RoomFeatureEntityToDTOMapper(List<RoomFeature> roomFeatures)
        {
            List<RoomFeatureResponseDTO> roomFeatureResponseDTOs = new List<RoomFeatureResponseDTO>();
            foreach (RoomFeature roomFeatureItem in roomFeatures)
            {
                RoomFeatureResponseDTO roomFeatureResponseDTO = EntityToRoomFeatureDTO(roomFeatureItem);
                roomFeatureResponseDTOs.Add(roomFeatureResponseDTO);
            }
            return roomFeatureResponseDTOs;
        }
    }
}
