using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class UserTypeAllocationServices
    {
        private readonly IUserTypeAllocationRepository _userTypeAllocationRepository;
        public UserTypeAllocationServices(IUserTypeAllocationRepository userTypeAllocationRepository)
        {
            _userTypeAllocationRepository = userTypeAllocationRepository;
        }
        public async Task<UserTypeAllocation> AddUserTypeAllocation(UserTypeAllocationRequestDTO request)
        {
            UserTypeAllocation userTypeAllocation = UserTypeAllocationDTOMapper.UserTypeAllocationDTOToEntityMapper(request);
            userTypeAllocation.CreatedAt = DateTime.Now;
            await _userTypeAllocationRepository.Add(userTypeAllocation);
            _userTypeAllocationRepository.Save();
            return userTypeAllocation;
        }
        public List<UserTypeAllocationResponseDTO> GetAll()
        {
            List<UserTypeAllocation> userTypeAllocations = _userTypeAllocationRepository.GetAll().ToList();
            return UserTypeAllocationDTOMapper.EntitiesToUserTypeAllocationDTOs(userTypeAllocations);
        }
        public bool RemoveUserTypeAllocation(int? id)
        {
            UserTypeAllocation userTypeAllocation = _userTypeAllocationRepository.Get(ans => ans.Id == id);
            if (userTypeAllocation == null)
            {
                return false;
            }
            _userTypeAllocationRepository.Remove(userTypeAllocation);
            _userTypeAllocationRepository.Save();
            return true;
        }
    }
}
