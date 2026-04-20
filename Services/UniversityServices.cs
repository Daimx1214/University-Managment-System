using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTP;
using UniversityManagmentSystem.Interfaces;

public class UniversityServices
{
    private readonly IUniversityRespository _universityRepository;

    public UniversityServices(IUniversityRespository universityRepository)
    {
        _universityRepository = universityRepository;
    }

    public University AddUniversity(UniversityRequestDTO request)
    {
        University university = UniversityDTOMapper.UniversityDTOToEntityMapper(request);
        university.CreatedAt = DateTime.Now;
        _universityRepository.Add(university);
        _universityRepository.Save();
        return university;
    }

    public List<UniversityResponseDTO> GetAll()
    {
        List<University> universities = _universityRepository.GetAll().ToList();
        return UniversityDTOMapper.EntitiesToUniversityDTOs(universities);
    }

    public bool RemoveUniversity(int? id)
    {
        University university = _universityRepository.Get(ans => ans.Id == id);
        _universityRepository.Remove(university);
        _universityRepository.Save();
        return true;
    }
}