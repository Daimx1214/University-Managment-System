using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class StructureDesignationServices
    {
        private readonly IStructureDesignationRepository _structureDesignationRepository;
        public StructureDesignationServices(IStructureDesignationRepository structureDesignationRepository)
        {
            _structureDesignationRepository = structureDesignationRepository;
        }
        public async Task<StructureDesignation> AddStructureDesignation(StructureDesignationRequestDTO request)
        {
            StructureDesignation structureDesignation = StructureDesignationDTOMapper.StructureDesignationDTOToEntityMapper(request);
            structureDesignation.CreatedAt = DateTime.Now;
            await _structureDesignationRepository.Add(structureDesignation);
            _structureDesignationRepository.Save();
            return structureDesignation;
        }
        public List<StructureDesignationResponseDTO> GetAll()
        {
            List<StructureDesignation> structureDesignations = _structureDesignationRepository.GetAll().ToList();
            return StructureDesignationDTOMapper.EntitiesToStructureDesignationDTOs(structureDesignations);
        }
        public bool RemoveStructureDesignation(int? id)
        {
            StructureDesignation structureDesignation = _structureDesignationRepository.Get(ans => ans.Id == id);
            if (structureDesignation == null)
            {
                return false;
            }
            _structureDesignationRepository.Remove(structureDesignation);
            _structureDesignationRepository.Save();
            return true;
        }
    }
}
