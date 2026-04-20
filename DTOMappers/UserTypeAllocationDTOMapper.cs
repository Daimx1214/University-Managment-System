using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class UserTypeAllocationDTOMapper
    {
        public static UserTypeAllocation UserTypeAllocationDTOToEntityMapper(UserTypeAllocationRequestDTO dto)
        {
            UserTypeAllocation entity = new UserTypeAllocation();
            entity.UserTypeId = dto.UserTypeId;
            entity.UserInfoId = dto.UserInfoId;
            entity.DepartmentId = dto.DepartmentId;
            entity.ProgramId = dto.ProgramId;
            return entity;
        }

        public static UserTypeAllocation UserTypeAllocationDTOToEntityMapper(UserTypeAllocation entity, UserTypeAllocationRequestDTO dto)
        {
            entity.UserTypeId = dto.UserTypeId;
            entity.UserInfoId = dto.UserInfoId;
            entity.DepartmentId = dto.DepartmentId;
            entity.ProgramId = dto.ProgramId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static UserTypeAllocationResponseDTO EntityToUserTypeAllocationDTO(UserTypeAllocation entity)
        {
            UserTypeAllocationResponseDTO response = new UserTypeAllocationResponseDTO();
            response.Id = entity.Id;
            response.UserTypeId = entity.UserTypeId;
            response.UserInfoId = entity.UserInfoId;
            response.DepartmentId = entity.DepartmentId;
            response.ProgramId = entity.ProgramId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<UserTypeAllocationResponseDTO> EntitiesToUserTypeAllocationDTOs(List<UserTypeAllocation> entities)
        {
            List<UserTypeAllocationResponseDTO> responseList = new List<UserTypeAllocationResponseDTO>();
            foreach (UserTypeAllocation entity in entities)
            {
                responseList.Add(EntityToUserTypeAllocationDTO(entity));
            }
            return responseList;
        }
    }
}
