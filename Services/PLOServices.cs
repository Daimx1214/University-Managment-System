using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class PLOServices
    {
        private readonly IPLORepository _ploRepository;
        public PLOServices(IPLORepository ploRepository)
        {
            _ploRepository = ploRepository;
        }
        public async Task<PLO> AddPLO(PLORequestDTO request)
        {
            PLO plo = PLODTOMapper.PLODTOToEntityMapper(request);
            plo.CreatedAt = DateTime.Now;
            await _ploRepository.Add(plo);
            _ploRepository.Save();
            return plo;
        }
        public List<PLOResponseDTO> GetAll()
        {
            List<PLO> plos = _ploRepository.GetAll().ToList();
            return PLODTOMapper.EntitiesToPLODTOs(plos);
        }
        public bool RemovePLO(int? id)
        {
            PLO plo = _ploRepository.Get(ans => ans.Id == id);
            if (plo == null)
            {
                return false;
            }
            _ploRepository.Remove(plo);
            _ploRepository.Save();
            return true;
        }
    }
}
