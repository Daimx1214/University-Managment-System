using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class DepartmentServices
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<Department> AddDepartment(DepartmentRequestDTO request)
        {
            Department department = DepartmentDTOMapper.DepartmentDTOToEntityMapper(request);
            department.CreatedAt = DateTime.Now;
            await _departmentRepository.Add(department);
            _departmentRepository.Save();
            return department;
        }
        public List<DepartmentResponseDTO> GetAll()
        {
            List<Department> departments = _departmentRepository.GetAll().ToList();
            return DepartmentDTOMapper.EntitiesToDepartmentDTOs(departments);
        }
        public bool RemoveDepartment(int? id)
        {
            Department department = _departmentRepository.Get(ans => ans.Id == id);
            if (department == null)
            {
                return false;
            }
            _departmentRepository.Remove(department);
            _departmentRepository.Save();
            return true;
        }
    }
}
