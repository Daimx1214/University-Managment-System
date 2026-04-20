using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class FacultyCampusServices
    {
        private readonly IFacultyCampusRepository _facultyCampusRepository;
        public FacultyCampusServices(IFacultyCampusRepository facultyCampusRepository)
        {
            _facultyCampusRepository = facultyCampusRepository;
        }
        public async Task<FacultyCampus> AddFacultyCampus(FacultyCampusRequestDTO request)
        {
            FacultyCampus facultyCampus = FacultyCampusDTOMapper.FacultyCampusDTOToEntityMapper(request);
            facultyCampus.CreatedAt = DateTime.Now;
            await _facultyCampusRepository.Add(facultyCampus);
            _facultyCampusRepository.Save();
            return facultyCampus;
        }
        public List<FacultyCampusResponseDTO> GetAll()
        {
            List<FacultyCampus> facultyCampuses = _facultyCampusRepository.GetAll().ToList();
            return FacultyCampusDTOMapper.EntitiesToFacultyCampusDTOs(facultyCampuses);
        }
        public bool RemoveFacultyCampus(int? id)
        {
            FacultyCampus facultyCampus = _facultyCampusRepository.Get(ans => ans.Id == id);
            if (facultyCampus == null)
            {
                return false;
            }
            _facultyCampusRepository.Remove(facultyCampus);
            _facultyCampusRepository.Save();
            return true;
        }
    }
}
