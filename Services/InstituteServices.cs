using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class InstituteServices
    {
        private readonly IInstituteRepository _instituteRepository;
        public InstituteServices(IInstituteRepository instituteRepository)
        {
            _instituteRepository = instituteRepository;
        }
        public async Task<Institute> AddInstitute(InstituteRequestDTO request)
        {
            Institute institute = InstituteDTOMapper.InstituteDTOToEntityMapper(request);
            institute.CreatedAt = DateTime.Now;
            await _instituteRepository.Add(institute);
            _instituteRepository.Save();
            return institute;
        }
        public List<InstituteResponseDTO> GetAll()
        {
            List<Institute> institutes = _instituteRepository.GetAll().ToList();
            return InstituteDTOMapper.EntitiesToInstituteDTOs(institutes);
        }
        public bool RemoveInstitute(int? id)
        {
            Institute institute = _instituteRepository.Get(ans => ans.Id == id);
            if (institute == null)
            {
                return false;
            }
            _instituteRepository.Remove(institute);
            _instituteRepository.Save();
            return true;
        }
    }
}
