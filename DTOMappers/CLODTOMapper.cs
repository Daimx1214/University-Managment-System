using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class CLODTOMapper
    {
        public static CLO CLODTOToEntityMapper(CLORequestDTO cloDTO)
        {
            CLO clo = new CLO();
            clo.Description = cloDTO.Description;
            clo.Code = cloDTO.Code;
            clo.LearningTypeId = cloDTO.LearningTypeId;
            clo.LearningLevelId = cloDTO.LearningLevelId;
            return clo;
        }

        public static CLO CLODTOToEntityMapper(CLO clo, CLORequestDTO cloDTO)
        {
            clo.Description = cloDTO.Description;
            clo.Code = cloDTO.Code;
            clo.LearningTypeId = cloDTO.LearningTypeId;
            clo.LearningLevelId = cloDTO.LearningLevelId;
            clo.UpdatedAt = DateTime.Now;
            return clo;
        }

        public static CLOResponseDTO EntityToCLODTO(CLO clo)
        {
            CLOResponseDTO cloResponseDTO = new CLOResponseDTO();
            cloResponseDTO.Id = clo.Id;
            cloResponseDTO.Description = clo.Description;
            cloResponseDTO.Code = clo.Code;
            cloResponseDTO.LearningTypeId = clo.LearningTypeId;
            cloResponseDTO.LearningLevelId = clo.LearningLevelId;
            cloResponseDTO.CreatedAt = DateTime.Now;
            cloResponseDTO.UpdatedAt = DateTime.Now;
            cloResponseDTO.IsActive = clo.IsActive;
            cloResponseDTO.GlobalId = clo.GlobalId;
            return cloResponseDTO;
        }

        public static List<CLOResponseDTO> EntitiesToCLODTOs(List<CLO> clos)
        {
            List<CLOResponseDTO> cloResponseDTOs = new List<CLOResponseDTO>();
            foreach (CLO clo in clos)
            {
                CLOResponseDTO cloResponseDTO = EntityToCLODTO(clo);
                cloResponseDTOs.Add(cloResponseDTO);
            }
            return cloResponseDTOs;
        }
    }
}
