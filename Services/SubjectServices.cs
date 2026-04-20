using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class SubjectServices
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectServices(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public async Task<Subject> AddSubject(SubjectRequestDTO request)
        {
            Subject subject = SubjectDTOMapper.SubjectDTOToEntityMapper(request);
            subject.CreatedAt = DateTime.Now;
            await _subjectRepository.Add(subject);
            _subjectRepository.Save();
            return subject;
        }
        public List<SubjectResponseDTO> GetAll()
        {
            List<Subject> subjects = _subjectRepository.GetAll().ToList();
            return SubjectDTOMapper.SubjectEntityToDTOMapper(subjects);
        }
        public bool RemoveSubject(int? id)
        {
            Subject subject = _subjectRepository.Get(subject => subject.Id == id);
            if (subject == null)
            {
                return false; // Subject not found
            }
            _subjectRepository.Remove(subject);
            _subjectRepository.Save();
            return true;
        }
    }
}
