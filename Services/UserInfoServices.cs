using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class UserInfoServices
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoServices(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public async Task<UserInfo> AddUserInfo(UserInfoRequestDTO request)
        {
            UserInfo userInfo = UserInfoDTOMapper.UserInfoDTOToEntityMapper(request);
            userInfo.CreatedAt = DateTime.Now;
            await _userInfoRepository.Add(userInfo);
            _userInfoRepository.Save();
            return userInfo;
        }
        public List<UserInfoResponseDTO> GetAll()
        {
            List<UserInfo> userInfos = _userInfoRepository.GetAll().ToList();
            return UserInfoDTOMapper.EntitiesToUserInfoDTOs(userInfos);
        }
        public bool RemoveUserInfo(int? id)
        {
            UserInfo userInfo = _userInfoRepository.Get(ans => ans.Id == id);
            if (userInfo == null)
            {
                return false;
            }
            _userInfoRepository.Remove(userInfo);
            _userInfoRepository.Save();
            return true;
        }
    }
}
