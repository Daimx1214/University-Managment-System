using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class StructureUnitServices
    {
        private readonly IStructureUnitRepository _structureUnitRepository;
        public StructureUnitServices(IStructureUnitRepository structureUnitRepository)
        {
            _structureUnitRepository = structureUnitRepository;
        }
        public async Task<StructureUnit> AddStructureUnit(StructureUnitRequestDTO request)
        {
            StructureUnit structureUnit = StructureUnitDTOMapper.StructureUnitDTOToEntityMapper(request);
            structureUnit.CreatedAt = DateTime.Now;
            await _structureUnitRepository.Add(structureUnit);
            _structureUnitRepository.Save();
            return structureUnit;
        }
        public List<StructureUnitResponseDTO> GetAll()
        {
            List<StructureUnit> structureUnits = _structureUnitRepository.GetAll().ToList();
            return StructureUnitDTOMapper.EntitiesToStructureUnitDTOs(structureUnits);
        }
        public bool RemoveStructureUnit(int? id)
        {
            StructureUnit structureUnit = _structureUnitRepository.Get(ans => ans.Id == id);
            if (structureUnit == null)
            {
                return false;
            }
            _structureUnitRepository.Remove(structureUnit);
            _structureUnitRepository.Save();
            return true;
        }
    }
}
