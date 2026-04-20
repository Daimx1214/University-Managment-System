using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagmentSystem.Services
{
    public class RoomTypeServices
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeServices(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<RoomType> AddRoomType(RoomTypeRequestDTO request)
        {
            RoomType roomType = RoomTypeDTOMapper.RoomTypeDTOToEntityMapper(request);
            roomType.CreatedAt = DateTime.Now;
            var result = await _roomTypeRepository.Add(roomType);
            _roomTypeRepository.Save();
            return result;
        }
        public List<RoomTypeResponseDTO> GetAll()
        {
            List<RoomType> roomTypes = _roomTypeRepository.GetAll().ToList();
            return RoomTypeDTOMapper.RoomTypeEntityToDTOMapper(roomTypes);
        }
        public bool RemoveRoomType(int? id)
        {
            RoomType roomType = _roomTypeRepository.Get(roomType => roomType.Id == id);
            if (roomType == null)
            {
                return false; // Room type not found
            }
            _roomTypeRepository.Remove(roomType);
            _roomTypeRepository.Save();
            return true;
        }
    }
}
