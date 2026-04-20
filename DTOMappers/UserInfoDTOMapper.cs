using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class UserInfoDTOMapper
    {
        public static UserInfo UserInfoDTOToEntityMapper(UserInfoRequestDTO dto)
        {
            UserInfo entity = new UserInfo();
            entity.UiUser = dto.UiUser;
            entity.UiPass = dto.UiPass;
            entity.UserName = dto.UserName;
            return entity;
        }

        public static UserInfo UserInfoDTOToEntityMapper(UserInfo entity, UserInfoRequestDTO dto)
        {
            entity.UiUser = dto.UiUser;
            entity.UiPass = dto.UiPass;
            entity.UserName = dto.UserName;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static UserInfoResponseDTO EntityToUserInfoDTO(UserInfo entity)
        {
            UserInfoResponseDTO response = new UserInfoResponseDTO();
            response.Id = entity.Id;
            response.UiUser = entity.UiUser;
            response.UiPass = entity.UiPass;
            response.UserName = entity.UserName;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<UserInfoResponseDTO> EntitiesToUserInfoDTOs(List<UserInfo> entities)
        {
            List<UserInfoResponseDTO> responseList = new List<UserInfoResponseDTO>();
            foreach (UserInfo entity in entities)
            {
                responseList.Add(EntityToUserInfoDTO(entity));
            }
            return responseList;
        }
    }
}
