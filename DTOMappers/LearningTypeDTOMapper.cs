using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class LearningTypeDTOMapper
    {
        public static LearningType LearningTypeDTOToEntityMapper(LearningTypeRequestDTO dto)
        {
            LearningType entity = new LearningType();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningType LearningTypeDTOToEntityMapper(LearningType entity, LearningTypeRequestDTO dto)
        {
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static LearningTypeResponseDTO EntityToLearningTypeDTO(LearningType entity)
        {
            LearningTypeResponseDTO response = new LearningTypeResponseDTO();
            response.Id = entity.Id;
            response.Description = entity.Description;
            response.Code = entity.Code;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<LearningTypeResponseDTO> EntitiesToLearningTypeDTOs(List<LearningType> entities)
        {
            List<LearningTypeResponseDTO> responseList = new List<LearningTypeResponseDTO>();
            foreach (LearningType entity in entities)
            {
                responseList.Add(EntityToLearningTypeDTO(entity));
            }
            return responseList;
        }
    }
}
