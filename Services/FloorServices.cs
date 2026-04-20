using UniversityManagementSystem.DTOMappers;
using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Services
{
    public class FloorServices
    {
        private readonly IFloorRepository _floorRepository;
        public FloorServices(IFloorRepository floorRepository)
        {
            _floorRepository = floorRepository;
        }
        public async Task<Floor> AddFloor(FloorRequestDTO request)
        {
            Floor floor = FloorDTOMapper.FloorDTOToEntityMapper(request);
            floor.CreatedAt = DateTime.Now;
            await _floorRepository.Add(floor);
            _floorRepository.Save();
            return floor;
        }
        public List<FloorResponseDTO> GetAll()
        {
            List<Floor> floors = _floorRepository.GetAll().ToList();
            return FloorDTOMapper.EntitiesToFloorDTOs(floors);
        }
        public bool RemoveFloor(int? id)
        {
            Floor floor = _floorRepository.Get(ans => ans.Id == id);
            if (floor == null)
            {
                return false;
            }
            _floorRepository.Remove(floor);
            _floorRepository.Save();
            return true;
        }
    }
}
