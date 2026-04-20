using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagmentSystem.Services
{
    public class RoomFeatureServices
    {
        private readonly IRoomFeatureRepository _roomFeatureRepository;

        public RoomFeatureServices(IRoomFeatureRepository roomFeatureRepository)
        {
            _roomFeatureRepository = roomFeatureRepository;
        }

        public async Task<RoomFeature> AddRoomFeature(RoomFeatureRequestDTO request)
        {
            RoomFeature roomFeature = RoomFeatureDTOMapper.RoomFeatureDTOToEntityMapper(request);
            roomFeature.CreatedAt = DateTime.Now;
            await _roomFeatureRepository.Add(roomFeature);
            _roomFeatureRepository.Save();
            return roomFeature;
        }
        public List<RoomFeatureResponseDTO> GetAll()
        {
            List<RoomFeature> roomFeatures = _roomFeatureRepository.GetAll().ToList();
            return RoomFeatureDTOMapper.RoomFeatureEntityToDTOMapper(roomFeatures);
        }
        public bool RemoveRoomFeature(int? id)
        {
            RoomFeature roomFeature = _roomFeatureRepository.Get(roomFeature => roomFeature.Id == id);
            if (roomFeature == null)
            {
                return false; // Room feature not found
            }
            _roomFeatureRepository.Remove(roomFeature);
            _roomFeatureRepository.Save();
            return true;
        }
    }
}
