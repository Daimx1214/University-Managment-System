using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTP;

namespace UniversityManagmentSystem.DTOMappers
{
    public class UniversityDTOMapper
    {
        public static University UniversityDTOToEntityMapper(UniversityRequestDTO universityDTO)
        {
            University university = new University();
            university.UniversityName = universityDTO.UniversityName;
            university.Description = universityDTO.Description;
            university.EstablishedIn = universityDTO.EstablisedIn;
            university.Address = universityDTO.Address;
            university.IsActive = true;
            return university;
        }
        public static University UniversityDTOToEntityMapper(University university, UniversityRequestDTO universityDTO)
        {
            university.UniversityName = universityDTO.UniversityName;
            university.Description = universityDTO.Description;
            university.EstablishedIn = universityDTO.EstablisedIn;
            university.UpdatedAt = DateTime.Now;
            return university;
        }
        public static UniversityResponseDTO EntityToUniversityDTO(University university)
        {
            UniversityResponseDTO universityResponseDTO = new UniversityResponseDTO();
            universityResponseDTO.Id = university.Id;
            universityResponseDTO.UniversityName = university.UniversityName;
            universityResponseDTO.EstablishedIn = university.EstablishedIn;
            universityResponseDTO.IsActive = university.IsActive;
            universityResponseDTO.CreatedAt = DateTime.Now;
            universityResponseDTO.UpdatedAt = DateTime.Now;
            universityResponseDTO.GlobalId = university.GlobalId;
            return universityResponseDTO;
        }
        public static List<UniversityResponseDTO> EntitiesToUniversityDTOs(List<University> universities)
        {
            List<UniversityResponseDTO> universityResponseDTOs = new List<UniversityResponseDTO>();
            foreach (University university in  universities)
            {
                UniversityResponseDTO universityResponseDTO = EntityToUniversityDTO(university);
                universityResponseDTOs.Add(universityResponseDTO);
            }
            return universityResponseDTOs;
        }
    }
}
