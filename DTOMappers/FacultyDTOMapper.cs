using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class FacultyDTOMapper
    {
        public static Faculty FacultyDTOToEntityMapper(FacultyRequestDTO facultyRequestDTO)
        {
            Faculty faculty = new Faculty();
            faculty.FacultyName = facultyRequestDTO.FacultyName;
            faculty.Occupation = facultyRequestDTO.Occupation;
            faculty.Code = facultyRequestDTO.Code;
            faculty.EstablishedIn = facultyRequestDTO.EstablishedIn;
            return faculty;
        }
        public static Faculty FacultyEntityToDTOMapper(Faculty faculty, FacultyRequestDTO facultyRequestDTO)
        {
            faculty.Id = facultyRequestDTO.Id;
            faculty.FacultyName = facultyRequestDTO.FacultyName;
            faculty.Occupation = facultyRequestDTO.Occupation;
            faculty.Code = facultyRequestDTO.Code;
            faculty.EstablishedIn = facultyRequestDTO.EstablishedIn;
            return faculty;
        }
        public static FacultyResponseDTO EntityToFacultyDTO(Faculty faculty)
        {
            FacultyResponseDTO facultyResponseDTO = new FacultyResponseDTO();
            facultyResponseDTO.Id = faculty.Id;
            facultyResponseDTO.FacultyName = faculty.FacultyName;
            facultyResponseDTO.Occupation = faculty.Occupation;
            facultyResponseDTO.Code = faculty.Code;
            facultyResponseDTO.EstablishedIn = faculty.EstablishedIn;
            facultyResponseDTO.CreatedAt = faculty.CreatedAt;
            facultyResponseDTO.UpdatedAt = faculty.UpdatedAt;
            facultyResponseDTO.GlobalId = faculty.GlobalId;
            return facultyResponseDTO;
        }
        public static List<FacultyResponseDTO> FacultyEntityToDTOMapper(List<Faculty> faculty)
        {
            List<FacultyResponseDTO> facultyResponseDTOs = new List<FacultyResponseDTO>();
            foreach (Faculty facultyItem in faculty)
            {
                FacultyResponseDTO facultyResponseDTO = EntityToFacultyDTO(facultyItem);
                facultyResponseDTOs.Add(facultyResponseDTO);
            }
            return facultyResponseDTOs;
        }
    }
}
