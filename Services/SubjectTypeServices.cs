using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class SubjectTypeServices
    {
        private readonly ISubjectTypeRepository _subjectTypeRepository;
        public SubjectTypeServices(ISubjectTypeRepository subjectTypeRepository)
        {
            _subjectTypeRepository = subjectTypeRepository;
        }
        public async Task<SubjectType> AddSubjectType(SubjectTypeRequestDTO request)
        {
            SubjectType subjectType = SubjectTypeDTOMapper.SubjectTypeDTOToEntityMapper(request);
            subjectType.CreatedAt = DateTime.Now;
            await _subjectTypeRepository.Add(subjectType);
            _subjectTypeRepository.Save();
            return subjectType;
        }
        public List<SubjectTypeResponseDTO> GetAll()
        {
            List<SubjectType> subjectTypes = _subjectTypeRepository.GetAll().ToList();
            return SubjectTypeDTOMapper.SubjectTypeEntityToDTOMapper(subjectTypes);
        }

        public bool RemoveSubjectType(int? id)
        {
            SubjectType subjectType = _subjectTypeRepository.Get(subjectType => subjectType.Id == id);
            if (subjectType == null)
            {
                return false; // Subject type not found
            }
            _subjectTypeRepository.Remove(subjectType);
            _subjectTypeRepository.Save();
            return true;
        }
    }
}
