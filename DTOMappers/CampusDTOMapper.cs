using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagementSystem.DTOMappers
{
    public class CampusDTOMapper
    {
        public static Campus CampusDTOToEntityMapper(CampusRequestDTO campusDTO)
        {
            Campus campus = new Campus();
            campus.Name = campusDTO.Name;
            campus.Code = campusDTO.Code;
            campus.Description = campusDTO.Description;
            campus.EstablishedIn = campusDTO.EstablishedIn;
            campus.Address = campusDTO.Address;
            campus.UniversityId = campusDTO.UniversityId;
            return campus;
        }

        public static Campus CampusDTOToEntityMapper(Campus campus, CampusRequestDTO campusDTO)
        {
            campus.Name = campusDTO.Name;
            campus.Code = campusDTO.Code;
            campus.Description = campusDTO.Description;
            campus.EstablishedIn = campusDTO.EstablishedIn;
            campus.Address = campusDTO.Address;
            campus.UniversityId = campusDTO.UniversityId;
            campus.UpdatedAt = DateTime.Now;
            return campus;
        }

        public static CampusResponseDTO EntityToCampusDTO(Campus campus)
        {
            CampusResponseDTO campusResponseDTO = new CampusResponseDTO();
            campusResponseDTO.Id = campus.Id;
            campusResponseDTO.Name = campus.Name;
            campusResponseDTO.Code = campus.Code;
            campusResponseDTO.Description = campus.Description;
            campusResponseDTO.EstablishedIn = campus.EstablishedIn;
            campusResponseDTO.Address = campus.Address;
            campusResponseDTO.UniversityId = campus.UniversityId;
            campusResponseDTO.CreatedAt = DateTime.Now;
            campusResponseDTO.DeletedAt = DateTime.Now;
            campusResponseDTO.UpdatedAt = DateTime.Now;
            campusResponseDTO.GlobalId = campus.GlobalId;
            return campusResponseDTO;
        }

        public static List<CampusResponseDTO> EntitiesToCampusDTOs(List<Campus> campuses)
        {
            List<CampusResponseDTO> campusResponseDTOs = new List<CampusResponseDTO>();
            foreach (Campus campus in campuses)
            {
                CampusResponseDTO campusResponseDTO = EntityToCampusDTO(campus);
                campusResponseDTOs.Add(campusResponseDTO);
            }
            return campusResponseDTOs;
        }
    }
}
