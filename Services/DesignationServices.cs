using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagmentSystem.Services
{
    public class DesignationServices
    {
        private readonly IDesignationRepository _designationRepository;
        public DesignationServices(IDesignationRepository designationRepository)
        {
            _designationRepository = designationRepository;
        }
        public async Task<Designation> AddDesignation(DesignationRequestDTO request)
        {
            Designation designation = DesignationDTOMapper.DesignationDTOToEntityMapper(request);
            designation.CreatedAt = DateTime.Now;
            await _designationRepository.Add(designation);
            _designationRepository.Save();
            return designation;
        }
        public List<DesignationResponseDTO> GetAll()
        {
            List<Designation> designations = _designationRepository.GetAll().ToList();
            return DesignationDTOMapper.DesignationEntityToDTOMapper(designations);
        }
        public bool RemoveDesignation(int? id)
        {
            Designation designation = _designationRepository.Get(designation => designation.Id == id);
            if (designation == null)
            {
                return false; // Designation not found
            }
            _designationRepository.Remove(designation);
            _designationRepository.Save();
            return true;

        }

    }
}
