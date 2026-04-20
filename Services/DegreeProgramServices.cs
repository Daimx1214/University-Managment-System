using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class DegreeProgramServices
    {
        private readonly IDegreeProgramRepository _degreeProgramRepository;
        public DegreeProgramServices(IDegreeProgramRepository degreeProgramRepository)
        {
            _degreeProgramRepository = degreeProgramRepository;
        }
        public async Task<DegreeProgram> AddDegreeProgram(DegreeProgramRequestDTO request)
        {
            DegreeProgram degreeProgram = DegreeProgramDTOMapper.DegreeProgramDTOToEntityMapper(request);
            degreeProgram.CreatedAt = DateTime.Now;
            await _degreeProgramRepository.Add(degreeProgram);
            _degreeProgramRepository.Save();
            return degreeProgram;
        }
        public List<DegreeProgramResponseDTO> GetAll()
        {
            List<DegreeProgram> degreePrograms = _degreeProgramRepository.GetAll().ToList();
            return DegreeProgramDTOMapper.EntitiesToDegreeProgramDTOs(degreePrograms);
        }
        public bool RemoveDegreeProgram(int? id)
        {
            DegreeProgram degreeProgram = _degreeProgramRepository.Get(ans => ans.Id == id);
            if (degreeProgram == null)
            {
                return false;
            }
            _degreeProgramRepository.Remove(degreeProgram);
            _degreeProgramRepository.Save();
            return true;
        }
    }
}
