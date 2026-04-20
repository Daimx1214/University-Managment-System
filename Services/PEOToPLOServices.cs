using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class PEOToPLOServices
    {
        private readonly IPEOToPLORepository _peoToPloRepository;
        public PEOToPLOServices(IPEOToPLORepository peoToPloRepository)
        {
            _peoToPloRepository = peoToPloRepository;
        }
        public async Task<PEOToPLO> AddPEOToPLO(PEOToPLORequestDTO request)
        {
            PEOToPLO peoToPlo = PEOToPLODTOMapper.PEOToPLODTOToEntityMapper(request);
            peoToPlo.CreatedAt = DateTime.Now;
            await _peoToPloRepository.Add(peoToPlo);
            _peoToPloRepository.Save();
            return peoToPlo;
        }
        public List<PEOToPLOResponseDTO> GetAll()
        {
            List<PEOToPLO> peoToPlos = _peoToPloRepository.GetAll().ToList();
            return PEOToPLODTOMapper.EntitiesToPEOToPLODTOs(peoToPlos);
        }
        public bool RemovePEOToPLO(int? id)
        {
            PEOToPLO peoToPlo = _peoToPloRepository.Get(ans => ans.Id == id);
            if (peoToPlo == null)
            {
                return false;
            }
            _peoToPloRepository.Remove(peoToPlo);
            _peoToPloRepository.Save();
            return true;
        }
    }
}
