using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class SemesterServices
    {
        private readonly ISemesterRepository _semesterRepository;

        public SemesterServices(ISemesterRepository semesterRepository)
        {
            _semesterRepository = semesterRepository;
        }

        public async Task<Semester> AddSemester(SemesterRequestDTO request)
        {
            Semester semester = SemesterDTOMapper.SemesterDTOToEntityMappers(request);
            semester.CreatedAt = DateTime.Now;
            await _semesterRepository.Add(semester);
            _semesterRepository.Save();
            return semester;
        }
        public List<SemesterResponseDTO> GetAll()
        {
            List<Semester> semesters = _semesterRepository.GetAll().ToList();
            return SemesterDTOMapper.SemesterEntityToDTOMapper(semesters);
        }
        public bool RemoveSemester(int? id)
        {
            Semester semester = _semesterRepository.Get(semester => semester.Id == id);
            if (semester == null)
            {
                return false; // Semester not found
            }
            _semesterRepository.Remove(semester);
            _semesterRepository.Save();
            return true;

        }
    }
}
