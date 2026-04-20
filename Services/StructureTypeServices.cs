using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class StructureTypeServices
    {
        private readonly IStructureTypeRepository _structureTypeRepository;
        public StructureTypeServices(IStructureTypeRepository structureTypeRepository)
        {
            _structureTypeRepository = structureTypeRepository;
        }
        public async Task<StructureType> AddStructureType(StructureTypeRequestDTO request)
        {
            StructureType structureType = StructureTypeDTOMapper.StructureTypeDTOToEntityMapper(request);
            structureType.CreatedAt = DateTime.Now;
            await _structureTypeRepository.Add(structureType);
            _structureTypeRepository.Save();
            return structureType;
        }
        public List<StructureTypeResponseDTO> GetAll()
        {
            List<StructureType> structureTypes = _structureTypeRepository.GetAll().ToList();
            return StructureTypeDTOMapper.StructureTypeEntityToDTOMapper(structureTypes);
        }
        public bool RemoveStructureType(int? id)
        {
            StructureType structureType = _structureTypeRepository.Get(structureType => structureType.Id == id);
            if (structureType == null)
            {
                return false; // Structure type not found
            }
            _structureTypeRepository.Remove(structureType);
            _structureTypeRepository.Save();
            return true;
        }
    }
}
