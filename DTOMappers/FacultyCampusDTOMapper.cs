using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class FacultyCampusDTOMapper
    {
        public static FacultyCampus FacultyCampusDTOToEntityMapper(FacultyCampusRequestDTO dto)
        {
            FacultyCampus entity = new FacultyCampus();
            entity.FacultyId = dto.FacultyId;
            entity.CampusId = dto.CampusId;
            return entity;
        }

        public static FacultyCampus FacultyCampusDTOToEntityMapper(FacultyCampus entity, FacultyCampusRequestDTO dto)
        {
            entity.FacultyId = dto.FacultyId;
            entity.CampusId = dto.CampusId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static FacultyCampusResponseDTO EntityToFacultyCampusDTO(FacultyCampus entity)
        {
            FacultyCampusResponseDTO response = new FacultyCampusResponseDTO();
            response.Id = entity.Id;
            response.FacultyId = entity.FacultyId;
            response.CampusId = entity.CampusId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<FacultyCampusResponseDTO> EntitiesToFacultyCampusDTOs(List<FacultyCampus> entities)
        {
            List<FacultyCampusResponseDTO> responseList = new List<FacultyCampusResponseDTO>();
            foreach (FacultyCampus entity in entities)
            {
                responseList.Add(EntityToFacultyCampusDTO(entity));
            }
            return responseList;
        }
    }
}
