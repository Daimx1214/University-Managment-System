using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SemesterDTOMapper
    {
        public static Semester SemesterDTOToEntityMappers(SemesterRequestDTO requestDTO)
        {
            Semester semester = new Semester();
            semester.SemesterName = requestDTO.SemesterName;
            semester.Code = requestDTO.Code;
            semester.Description = requestDTO.Description;
            return semester;
        }

        public static Semester SemesterDTOToEntityMappers(Semester semester, SemesterRequestDTO semesterRequestDTO)
        {
            semester.SemesterName = semesterRequestDTO.SemesterName;
            semester.Code = semesterRequestDTO.Code;
            semester.Description = semesterRequestDTO.Description;
            return semester;
        }
        public static SemesterResponseDTO EntityToSemesterDTO(Semester semester)
        {
            SemesterResponseDTO semesterResponseDTO = new SemesterResponseDTO();
            semesterResponseDTO.Id = semester.Id;
            semesterResponseDTO.SemesterName = semester.SemesterName;
            semesterResponseDTO.Code = semester.Code;
            semesterResponseDTO.Description = semester.Description;
            semesterResponseDTO.CreatedAt = semester.CreatedAt;
            semesterResponseDTO.UpdatedAt = semester.UpdatedAt;
            semesterResponseDTO.GlobalId= semester.GlobalId;
            return semesterResponseDTO;
        }
        public static List<SemesterResponseDTO> SemesterEntityToDTOMapper(List<Semester> semester)
        {
            List<SemesterResponseDTO> semesterResponseDTOs = new List<SemesterResponseDTO>();
            foreach (Semester semesterItem in semester)
            {
                SemesterResponseDTO semesterResponseDTO = EntityToSemesterDTO(semesterItem);
                semesterResponseDTOs.Add(semesterResponseDTO);
            }
            return semesterResponseDTOs;
        }
    }
}
