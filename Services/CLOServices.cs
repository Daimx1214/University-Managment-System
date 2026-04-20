using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class CLOServices
    {
        private readonly ICLORepository _cloRepository;
        public CLOServices(ICLORepository cloRepository)
        {
            _cloRepository = cloRepository;
        }
        public async Task<CLO> AddCLO(CLORequestDTO request)
        {
            CLO clo = CLODTOMapper.CLODTOToEntityMapper(request);
            clo.CreatedAt = DateTime.Now;
            await _cloRepository.Add(clo);
            _cloRepository.Save();
            return clo;
        }
        public List<CLOResponseDTO> GetAll()
        {
            List<CLO> clos = _cloRepository.GetAll().ToList();
            return CLODTOMapper.EntitiesToCLODTOs(clos);
        }
        public bool RemoveCLO(int? id)
        {
            CLO clo = _cloRepository.Get(ans => ans.Id == id);
            if (clo == null)
            {
                return false;
            }
            _cloRepository.Remove(clo);
            _cloRepository.Save();
            return true;
        }
    }
}
