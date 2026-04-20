using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Services
{
    public class FacultyServices
    {
        private readonly IFacultyRepository _facultyRepository;

        public FacultyServices(IFacultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        public async Task<Faculty> AddFaculty(FacultyRequestDTO request)
        {
            Faculty faculty = FacultyDTOMapper.FacultyDTOToEntityMapper(request);
            faculty.CreatedAt = DateTime.Now;
            await _facultyRepository.Add(faculty);
            _facultyRepository.Save();
            return faculty;
        }

        public List<FacultyResponseDTO> GetAll()
        {
            List<Faculty> faculties = _facultyRepository.GetAll().ToList();
            return FacultyDTOMapper.FacultyEntityToDTOMapper(faculties);
        }
        public bool RemoveFaculty(int? id)
        {
            Faculty faculty = _facultyRepository.Get(faculty => faculty.Id == id);
            if (faculty == null)
            {
                return false; // Faculty not found
            }
            _facultyRepository.Remove(faculty);
            _facultyRepository.Save();
            return true;
        }
    }
}
