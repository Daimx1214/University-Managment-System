using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class UserRightAllocationDTOMapper
    {
        public static UserRightAllocation UserRightAllocationDTOToEntityMapper(UserRightAllocationRequestDTO dto)
        {
            UserRightAllocation entity = new UserRightAllocation();
            entity.UserRightID = dto.UserRightID;
            entity.UserTypeId = dto.UserTypeId;
            return entity;
        }

        public static UserRightAllocation UserRightAllocationDTOToEntityMapper(UserRightAllocation entity, UserRightAllocationRequestDTO dto)
        {
            entity.UserRightID = dto.UserRightID;
            entity.UserTypeId = dto.UserTypeId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static UserRightAllocationResponseDTO EntityToUserRightAllocationDTO(UserRightAllocation entity)
        {
            UserRightAllocationResponseDTO response = new UserRightAllocationResponseDTO();
            response.Id = entity.Id;
            response.UserRightID = entity.UserRightID;
            response.UserTypeId = entity.UserTypeId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<UserRightAllocationResponseDTO> EntitiesToUserRightAllocationDTOs(List<UserRightAllocation> entities)
        {
            List<UserRightAllocationResponseDTO> responseList = new List<UserRightAllocationResponseDTO>();
            foreach (UserRightAllocation entity in entities)
            {
                responseList.Add(EntityToUserRightAllocationDTO(entity));
            }
            return responseList;
        }
    }
}
