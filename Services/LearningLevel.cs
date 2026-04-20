using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class LearningLevelServices
    {
        private readonly ILearningLevelRepository _learningLevelRepository;
        public LearningLevelServices(ILearningLevelRepository learningLevelRepository)
        {
            _learningLevelRepository = learningLevelRepository;
        }
        public async Task<LearningLevel> AddLearningLevel(LearningLevelRequestDTO request)
        {
            LearningLevel learningLevel = LearningLevelDTOMapper.LearningLevelDTOToEntityMapper(request);
            learningLevel.CreatedAt = DateTime.Now;
            await _learningLevelRepository.Add(learningLevel);
            _learningLevelRepository.Save();
            return learningLevel;
        }
        public List<LearningLevelResponseDTO> GetAll()
        {
            List<LearningLevel> learningLevels = _learningLevelRepository.GetAll().ToList();
            return LearningLevelDTOMapper.EntitiesToLearningLevelDTOs(learningLevels);
        }
        public bool RemoveLearningLevel(int? id)
        {
            LearningLevel learningLevel = _learningLevelRepository.Get(ans => ans.Id == id);
            if (learningLevel == null)
            {
                return false;
            }
            _learningLevelRepository.Remove(learningLevel);
            _learningLevelRepository.Save();
            return true;
        }
    }
}
