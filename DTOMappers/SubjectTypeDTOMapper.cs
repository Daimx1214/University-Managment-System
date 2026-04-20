using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class SubjectTypeDTOMapper
    {
        public static SubjectType SubjectTypeDTOToEntityMapper(SubjectTypeRequestDTO requestDTO)
        {
            SubjectType subjectType = new SubjectType();
            subjectType.SubjectTypeName = requestDTO.SubjectTypeName;
            subjectType.Description = requestDTO.Description;
            subjectType.Code = requestDTO.Code;
            return subjectType;
        }


        public static SubjectType SubjectTypeDTOToEntityMappers(SubjectType subjectType, SubjectTypeRequestDTO subjectTypeRequestDTO)
        {
            subjectType.SubjectTypeName = subjectTypeRequestDTO.SubjectTypeName;
            subjectType.Description = subjectTypeRequestDTO.Description;
            subjectType.Code = subjectTypeRequestDTO.Code;
            return subjectType;
        }

        public static SubjectTypeResponseDTO EntityToSubjectTypeDTO(SubjectType subjectType)
        {
            SubjectTypeResponseDTO subjectTypeResponseDTO = new SubjectTypeResponseDTO();
            subjectTypeResponseDTO.Id = subjectType.Id;
            subjectTypeResponseDTO.SubjectTypeName = subjectType.SubjectTypeName;
            subjectTypeResponseDTO.Description = subjectType.Description;
            subjectTypeResponseDTO.Code = subjectType.Code;
            subjectTypeResponseDTO.CreatedAt = subjectType.CreatedAt;
            subjectTypeResponseDTO.UpdatedAt = subjectType.UpdatedAt;
            subjectTypeResponseDTO.GlobalId = subjectType.GlobalId;
            return subjectTypeResponseDTO;
        }

        public static List<SubjectTypeResponseDTO> SubjectTypeEntityToDTOMapper(List<SubjectType> subjectType)
        {
            List<SubjectTypeResponseDTO> subjectTypeResponseDTOs = new List<SubjectTypeResponseDTO>();
            foreach (SubjectType subjectTypeItem in subjectType)
            {
                SubjectTypeResponseDTO subjectTypeResponseDTO = EntityToSubjectTypeDTO(subjectTypeItem);
                subjectTypeResponseDTOs.Add(subjectTypeResponseDTO);
            }
            return subjectTypeResponseDTOs;
        }
    }
}
