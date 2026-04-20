using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class UserTypeDTOMapper
    {
        public static UserType UserTypeDTOToEntityMapper(UserTypeRequestDTO dto)
        {
            UserType entity = new UserType();
            entity.UserTypeCode = dto.UserTypeCode;
            entity.UserName = dto.UserName;
            return entity;
        }

        public static UserType UserTypeDTOToEntityMapper(UserType entity, UserTypeRequestDTO dto)
        {
            entity.UserTypeCode = dto.UserTypeCode;
            entity.UserName = dto.UserName;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static UserTypeResponseDTO EntityToUserTypeDTO(UserType entity)
        {
            UserTypeResponseDTO response = new UserTypeResponseDTO();
            response.Id = entity.Id;
            response.UserTypeCode = entity.UserTypeCode;
            response.UserName = entity.UserName;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<UserTypeResponseDTO> EntitiesToUserTypeDTOs(List<UserType> entities)
        {
            List<UserTypeResponseDTO> responseList = new List<UserTypeResponseDTO>();
            foreach (UserType entity in entities)
            {
                responseList.Add(EntityToUserTypeDTO(entity));
            }
            return responseList;
        }
    }
}
