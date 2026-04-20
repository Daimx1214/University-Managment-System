using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class DepartmentDTOMapper
    {
        public static Department DepartmentDTOToEntityMapper(DepartmentRequestDTO dto)
        {
            Department department = new Department();
            department.DepartmentName = dto.DepartmentName;
            department.Description = dto.Description;
            department.EstablishedIn = dto.EstablishedIn;
            department.Code = dto.Code;
            department.InstituteId = dto.InstituteId;
            return department;
        }

        public static Department DepartmentDTOToEntityMapper(Department entity, DepartmentRequestDTO dto)
        {
            entity.DepartmentName = dto.DepartmentName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.InstituteId = dto.InstituteId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static DepartmentResponseDTO EntityToDepartmentDTO(Department entity)
        {
            DepartmentResponseDTO response = new DepartmentResponseDTO();
            response.Id = entity.Id;
            response.DepartmentName = entity.DepartmentName;
            response.Description = entity.Description;
            response.EstablishedIn = entity.EstablishedIn;
            response.Code = entity.Code;
            response.InstituteId = entity.InstituteId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<DepartmentResponseDTO> EntitiesToDepartmentDTOs(List<Department> entities)
        {
            List<DepartmentResponseDTO> responseList = new List<DepartmentResponseDTO>();
            foreach (Department entity in entities)
            {
                responseList.Add(EntityToDepartmentDTO(entity));
            }
            return responseList;
        }
    }
}
