using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class PEOServices
    {
        private readonly IPEORepository _peoRepository;
        public PEOServices(IPEORepository peoRepository)
        {
            _peoRepository = peoRepository;
        }
        public async Task<PEO> AddPEO(PEORequestDTO request)
        {
            PEO peo = PEODTOMapper.PEODTOToEntityMapper(request);
            peo.CreatedAt = DateTime.Now;
            await _peoRepository.Add(peo);
            _peoRepository.Save();
            return peo;
        }
        public List<PEOResponseDTO> GetAll()
        {
            List<PEO> peos = _peoRepository.GetAll().ToList();
            return PEODTOMapper.EntitiesToPEODTOs(peos);
        }
        public bool RemovePEO(int? id)
        {
            PEO peo = _peoRepository.Get(ans => ans.Id == id);
            if (peo == null)
            {
                return false;
            }
            _peoRepository.Remove(peo);
            _peoRepository.Save();
            return true;
        }
    }
}
