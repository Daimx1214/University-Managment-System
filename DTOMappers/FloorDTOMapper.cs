using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class FloorDTOMapper
    {
        public static Floor FloorDTOToEntityMapper(FloorRequestDTO dto)
        {
            Floor floor = new Floor();
            floor.Name = dto.Name;
            floor.Code = dto.Code;
            floor.Description = dto.Description;
            floor.EstablishedIn = dto.EstablishedIn;
            floor.Address = dto.Address;
            floor.BuildingId = dto.BuildingId;
            return floor;
        }

        public static Floor FloorDTOToEntityMapper(Floor entity, FloorRequestDTO dto)
        {
            entity.Name = dto.Name;
            entity.Code = dto.Code;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Address = dto.Address;
            entity.BuildingId = dto.BuildingId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static FloorResponseDTO EntityToFloorDTO(Floor entity)
        {
            FloorResponseDTO response = new FloorResponseDTO();
            response.Id = entity.Id;
            response.Name = entity.Name;
            response.Code = entity.Code;
            response.Description = entity.Description;
            response.EstablishedIn = entity.EstablishedIn;
            response.Address = entity.Address;
            response.BuildingId = entity.BuildingId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<FloorResponseDTO> EntitiesToFloorDTOs(List<Floor> entities)
        {
            List<FloorResponseDTO> responseList = new List<FloorResponseDTO>();
            foreach (Floor entity in entities)
            {
                responseList.Add(EntityToFloorDTO(entity));
            }
            return responseList;
        }
    }
}
