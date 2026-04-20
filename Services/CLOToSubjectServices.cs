using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class CLOToSubjectServices
    {
        private readonly ICLOToSubjectRepository _cloToSubjectRepository;
        public CLOToSubjectServices(ICLOToSubjectRepository cloToSubjectRepository)
        {
            _cloToSubjectRepository = cloToSubjectRepository;
        }
        public async Task<CLOToSubject> AddCLOToSubject(CLOToSubjectRequestDTO request)
        {
            CLOToSubject cloToSubject = CLOToSubjectDTOMapper.CLOToSubjectDTOToEntityMapper(request);
            cloToSubject.CreatedAt = DateTime.Now;
            await _cloToSubjectRepository.Add(cloToSubject);
            _cloToSubjectRepository.Save();
            return cloToSubject;
        }
        public List<CLOToSubjectResponseDTO> GetAll()
        {
            List<CLOToSubject> cloToSubjects = _cloToSubjectRepository.GetAll().ToList();
            return CLOToSubjectDTOMapper.EntitiesToCLOToSubjectDTOs(cloToSubjects);
        }
        public bool RemoveCLOToSubject(int? id)
        {
            CLOToSubject cloToSubject = _cloToSubjectRepository.Get(ans => ans.Id == id);
            if (cloToSubject == null)
            {
                return false;
            }
            _cloToSubjectRepository.Remove(cloToSubject);
            _cloToSubjectRepository.Save();
            return true;
        }
    }
}
