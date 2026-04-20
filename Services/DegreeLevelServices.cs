using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.DTOs.ResponseDTO;

public class DegreeLevelServices
{
    private readonly IDegreeLevelRepository _degreeLevelRepository;

    public DegreeLevelServices(IDegreeLevelRepository degreeLevelRepository)
    {
        _degreeLevelRepository = degreeLevelRepository;
    }

    public async Task<DegreeLevel> AddDegreeLevel(DegreeLevelRequestDTO request)
    {
        DegreeLevel degreeLevel = DegreeLevelDTOMapper.DegreeLevelDTOToEntityMapper(request);
        degreeLevel.CreatedAt = DateTime.Now;
        await _degreeLevelRepository.Add(degreeLevel);
        _degreeLevelRepository.Save();
        return degreeLevel;
    }

    public List<DegreeLevelResponseDTO> GetAll()
    {
        List<DegreeLevel> degreeLevels = _degreeLevelRepository.GetAll().ToList();
        return DegreeLevelDTOMapper.EntitiesToDegreeLevelDTOs(degreeLevels);

    }
    public bool RemoveDegreeLevel(int? id)
    {
        DegreeLevel degreeLevel = _degreeLevelRepository.Get(ans => ans.Id == id);
        if (degreeLevel == null)
        {
            return false; // Degree level not found
        }
        _degreeLevelRepository.Remove(degreeLevel);
        _degreeLevelRepository.Save();
        return true;
    }

}
