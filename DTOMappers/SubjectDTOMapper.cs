using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SubjectDTOMapper
    {
        public static Subject SubjectDTOToEntityMapper(SubjectRequestDTO requestDTO)
        {
            Subject subject = new Subject();
            subject.SubjectName = requestDTO.SubjectName;
            subject.Description = requestDTO.Description;
            subject.Code = requestDTO.Code;
            return subject;
        }

        public static Subject SubjectDTOToEntityMappers(Subject subject, SubjectRequestDTO subjectRequestDTO)
        {
            subject.SubjectName = subjectRequestDTO.SubjectName;
            subject.Description = subjectRequestDTO.Description;
            subject.Code = subjectRequestDTO.Code;
            return subject;
        }

        public static SubjectResponseDTO EntityToSubjectDTO(Subject subject)
        {
            SubjectResponseDTO subjectResponseDTO = new SubjectResponseDTO();
            subjectResponseDTO.Id = subject.Id;
            subjectResponseDTO.SubjectName = subject.SubjectName;
            subjectResponseDTO.Description = subject.Description;
            subjectResponseDTO.Code = subject.Code;
            subjectResponseDTO.CreatedAt = subject.CreatedAt;
            subjectResponseDTO.UpdatedAt = subject.UpdatedAt;
            subjectResponseDTO.IsActive = subject.IsActive;
            return subjectResponseDTO;
        }

        public static List<SubjectResponseDTO> SubjectEntityToDTOMapper(List<Subject> subject)
        {
            List<SubjectResponseDTO> subjectResponseDTOs = new List<SubjectResponseDTO>();
            foreach (Subject subjectItem in subject)
            {
                SubjectResponseDTO subjectResponseDTO = EntityToSubjectDTO(subjectItem);
                subjectResponseDTOs.Add(subjectResponseDTO);
            }
            return subjectResponseDTOs;
        }
    }
}
