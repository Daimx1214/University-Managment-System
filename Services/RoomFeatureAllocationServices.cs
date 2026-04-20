using UniversityManagementSystem.DTOMappers;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class RoomFeatureAllocationServices
    {
        private readonly IRoomFeatureAllocationRepository _roomFeatureAllocationRepository;
        public RoomFeatureAllocationServices(IRoomFeatureAllocationRepository roomFeatureAllocationRepository)
        {
            _roomFeatureAllocationRepository = roomFeatureAllocationRepository;
        }
        public async Task<RoomFeatureAllocation> AddRoomFeatureAllocation(RoomFeatureAllocationRequestDTO request)
        {
            RoomFeatureAllocation roomFeatureAllocation = RoomFeatureAllocationDTOMapper.RoomFeatureAllocationDTOToEntityMapper(request);
            roomFeatureAllocation.CreatedAt = DateTime.Now;
            await _roomFeatureAllocationRepository.Add(roomFeatureAllocation);
            _roomFeatureAllocationRepository.Save();
            return roomFeatureAllocation;
        }
        public List<RoomFeatureAllocationResponseDTO> GetAll()
        {
            List<RoomFeatureAllocation> roomFeatureAllocations = _roomFeatureAllocationRepository.GetAll().ToList();
            return RoomFeatureAllocationDTOMapper.EntitiesToRoomFeatureAllocationDTOs(roomFeatureAllocations);
        }
        public bool RemoveRoomFeatureAllocation(int? id)
        {
            RoomFeatureAllocation roomFeatureAllocation = _roomFeatureAllocationRepository.Get(ans => ans.Id == id);
            if (roomFeatureAllocation == null)
            {
                return false;
            }
            _roomFeatureAllocationRepository.Remove(roomFeatureAllocation);
            _roomFeatureAllocationRepository.Save();
            return true;
        }
    }
}
