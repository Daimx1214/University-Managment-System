using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class UserTypeServices
    {
        private readonly IUserTypeRepository _userTypeRepository;
        public UserTypeServices(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }
        public async Task<UserType> AddUserType(UserTypeRequestDTO request)
        {
            UserType userType = UserTypeDTOMapper.UserTypeDTOToEntityMapper(request);
            userType.CreatedAt = DateTime.Now;
            await _userTypeRepository.Add(userType);
            _userTypeRepository.Save();
            return userType;
        }
        public List<UserTypeResponseDTO> GetAll()
        {
            List<UserType> userTypes = _userTypeRepository.GetAll().ToList();
            return UserTypeDTOMapper.EntitiesToUserTypeDTOs(userTypes);
        }
        public bool RemoveUserType(int? id)
        {
            UserType userType = _userTypeRepository.Get(ans => ans.Id == id);
            if (userType == null)
            {
                return false;
            }
            _userTypeRepository.Remove(userType);
            _userTypeRepository.Save();
            return true;
        }
    }
}
