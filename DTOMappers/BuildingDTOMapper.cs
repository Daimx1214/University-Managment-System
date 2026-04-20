using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class BuildingDTOMapper
    {
        public static Building BuildingDTOToEntityMapper(BuildingRequestDTO buildingDTO)
        {
            Building building = new Building();
            building.Name = buildingDTO.Name;
            building.Description = buildingDTO.Description;
            building.EstablishedIn = buildingDTO.EstablishedIn;
            building.Address = buildingDTO.Address;
            building.CampusId = buildingDTO.CampusId;
            return building;
        }

        public static Building BuildingDTOToEntityMapper(Building building, BuildingRequestDTO buildingDTO)
        {
            building.Name = buildingDTO.Name;
            building.Description = buildingDTO.Description;
            building.EstablishedIn = buildingDTO.EstablishedIn;
            building.Address = buildingDTO.Address;
            building.CampusId = buildingDTO.CampusId;
            building.UpdatedAt = DateTime.Now;
            return building;
        }

        public static BuildingResponseDTO EntityToBuildingDTO(Building building)
        {
            BuildingResponseDTO buildingResponseDTO = new BuildingResponseDTO();
            buildingResponseDTO.Id = building.Id;
            buildingResponseDTO.Name = building.Name;
            buildingResponseDTO.Description = building.Description;
            buildingResponseDTO.EstablishedIn = building.EstablishedIn;
            buildingResponseDTO.Address = building.Address;
            buildingResponseDTO.CampusId = building.CampusId;
            buildingResponseDTO.CreatedAt = building.CreatedAt;
            buildingResponseDTO.UpdatedAt = building.UpdatedAt;
            buildingResponseDTO.GlobalId = building.GlobalId;
            return buildingResponseDTO;
        }

        public static List<BuildingResponseDTO> EntitiesToBuildingDTOs(List<Building> buildings)
        {
            List<BuildingResponseDTO> buildingResponseDTOs = new List<BuildingResponseDTO>();
            foreach (Building building in buildings)
            {
                BuildingResponseDTO buildingResponseDTO = EntityToBuildingDTO(building);
                buildingResponseDTOs.Add(buildingResponseDTO);
            }
            return buildingResponseDTOs;
        }
    }
}
