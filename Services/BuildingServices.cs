using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class BuildingServices
    {
        private readonly IBuildingRepository _buildingRepository;
        public BuildingServices(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }
        public async Task<Building> AddBuilding(BuildingRequestDTO request)
        {
            Building building = BuildingDTOMapper.BuildingDTOToEntityMapper(request);
            building.CreatedAt = DateTime.Now;
            await _buildingRepository.Add(building);
            _buildingRepository.Save();
            return building;
        }
        public List<BuildingResponseDTO> GetAll()
        {
            List<Building> buildings = _buildingRepository.GetAll().ToList();
            return BuildingDTOMapper.EntitiesToBuildingDTOs(buildings);
        }
        public bool RemoveBuilding(int? id)
        {
            Building building = _buildingRepository.Get(ans => ans.Id == id);
            if (building == null)
            {
                return false;
            }
            _buildingRepository.Remove(building);
            _buildingRepository.Save();
            return true;
        }
    }
}
