using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class LearningLevelDTOMapper
    {
        public static LearningLevel LearningLevelDTOToEntityMapper(LearningLevelRequestDTO dto)
        {
            LearningLevel entity = new LearningLevel();
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            return entity;
        }

        public static LearningLevel LearningLevelDTOToEntityMapper(LearningLevel entity, LearningLevelRequestDTO dto)
        {
            entity.Description = dto.Description;
            entity.Code = dto.Code;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static LearningLevelResponseDTO EntityToLearningLevelDTO(LearningLevel entity)
        {
            LearningLevelResponseDTO response = new LearningLevelResponseDTO();
            response.Id = entity.Id;
            response.Description = entity.Description;
            response.Code = entity.Code;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<LearningLevelResponseDTO> EntitiesToLearningLevelDTOs(List<LearningLevel> entities)
        {
            List<LearningLevelResponseDTO> responseList = new List<LearningLevelResponseDTO>();
            foreach (LearningLevel entity in entities)
            {
                responseList.Add(EntityToLearningLevelDTO(entity));
            }
            return responseList;
        }
    }
}
