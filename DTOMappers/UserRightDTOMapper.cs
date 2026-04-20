using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class UserRightDTOMapper
    {
        public static UserRight UserRightDTOToEntityMapper(UserRightRequestDTO dto)
        {
            UserRight entity = new UserRight();
            entity.RightCode = dto.RightCode;
            entity.UserRightName = dto.UserRightName;
            entity.URL = dto.URL;
            entity.TabName = dto.TabName;
            return entity;
        }

        public static UserRight UserRightDTOToEntityMapper(UserRight entity, UserRightRequestDTO dto)
        {
            entity.RightCode = dto.RightCode;
            entity.UserRightName = dto.UserRightName;
            entity.URL = dto.URL;
            entity.TabName = dto.TabName;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static UserRightResponseDTO EntityToUserRightDTO(UserRight entity)
        {
            UserRightResponseDTO response = new UserRightResponseDTO();
            response.Id = entity.Id;
            response.RightCode = entity.RightCode;
            response.UserRightName = entity.UserRightName;
            response.URL = entity.URL;
            response.TabName = entity.TabName;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<UserRightResponseDTO> EntitiesToUserRightDTOs(List<UserRight> entities)
        {
            List<UserRightResponseDTO> responseList = new List<UserRightResponseDTO>();
            foreach (UserRight entity in entities)
            {
                responseList.Add(EntityToUserRightDTO(entity));
            }
            return responseList;
        }
    }
}
