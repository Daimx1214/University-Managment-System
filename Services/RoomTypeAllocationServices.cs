using UniversityManagementSystem.DTOMappers;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class RoomTypeAllocationServices
    {
        private readonly IRoomTypeAllocationRepository _roomTypeAllocationRepository;
        public RoomTypeAllocationServices(IRoomTypeAllocationRepository roomTypeAllocationRepository)
        {
            _roomTypeAllocationRepository = roomTypeAllocationRepository;
        }
        public async Task<RoomTypeAllocation> AddRoomTypeAllocation(RoomTypeAllocationRequestDTO request)
        {
            RoomTypeAllocation roomTypeAllocation = RoomTypeAllocationDTOMapper.RoomTypeAllocationDTOToEntityMapper(request);
            roomTypeAllocation.CreatedAt = DateTime.Now;
            await _roomTypeAllocationRepository.Add(roomTypeAllocation);
            _roomTypeAllocationRepository.Save();
            return roomTypeAllocation;
        }
        public List<RoomTypeAllocationResponseDTO> GetAll()
        {
            List<RoomTypeAllocation> roomTypeAllocations = _roomTypeAllocationRepository.GetAll().ToList();
            return RoomTypeAllocationDTOMapper.EntitiesToRoomTypeAllocationDTOs(roomTypeAllocations);
        }
        public bool RemoveRoomTypeAllocation(int? id)
        {
            RoomTypeAllocation roomTypeAllocation = _roomTypeAllocationRepository.Get(ans => ans.Id == id);
            if (roomTypeAllocation == null)
            {
                return false;
            }
            _roomTypeAllocationRepository.Remove(roomTypeAllocation);
            _roomTypeAllocationRepository.Save();
            return true;
        }
    }
}
