using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class UserRightServices
    {
        private readonly IUserRightRepository _userRightRepository;
        public UserRightServices(IUserRightRepository userRightRepository)
        {
            _userRightRepository = userRightRepository;
        }
        public async Task<UserRight> AddUserRight(UserRightRequestDTO request)
        {
            UserRight userRight = UserRightDTOMapper.UserRightDTOToEntityMapper(request);
            userRight.CreatedAt = DateTime.Now;
            await _userRightRepository.Add(userRight);
            _userRightRepository.Save();
            return userRight;
        }
        public List<UserRightResponseDTO> GetAll()
        {
            List<UserRight> userRights = _userRightRepository.GetAll().ToList();
            return UserRightDTOMapper.EntitiesToUserRightDTOs(userRights);
        }
        public bool RemoveUserRight(int? id)
        {
            UserRight userRight = _userRightRepository.Get(ans => ans.Id == id);
            if (userRight == null)
            {
                return false;
            }
            _userRightRepository.Remove(userRight);
            _userRightRepository.Save();
            return true;
        }
    }
}
