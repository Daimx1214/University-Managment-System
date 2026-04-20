using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class PLOToCLOServices
    {
        private readonly IPLOToCLORepository _ploToCloRepository;
        public PLOToCLOServices(IPLOToCLORepository ploToCloRepository)
        {
            _ploToCloRepository = ploToCloRepository;
        }
        public async Task<PLOToCLO> AddPLOToCLO(PLOToCLORequestDTO request)
        {
            PLOToCLO ploToClo = PLOToCLODTOMapper.PLOToCLODTOToEntityMapper(request);
            ploToClo.CreatedAt = DateTime.Now;
            await _ploToCloRepository.Add(ploToClo);
            _ploToCloRepository.Save();
            return ploToClo;
        }
        public List<PLOToCLOResponseDTO> GetAll()
        {
            List<PLOToCLO> ploToClos = _ploToCloRepository.GetAll().ToList();
            return PLOToCLODTOMapper.EntitiesToPLOToCLODTOs(ploToClos);
        }
        public bool RemovePLOToCLO(int? id)
        {
            PLOToCLO ploToClo = _ploToCloRepository.Get(ans => ans.Id == id);
            if (ploToClo == null)
            {
                return false;
            }
            _ploToCloRepository.Remove(ploToClo);
            _ploToCloRepository.Save();
            return true;
        }
    }
}
