using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class UserRightAllocationServices
    {
        private readonly IUserRightAllocationRepository _userRightAllocationRepository;
        public UserRightAllocationServices(IUserRightAllocationRepository userRightAllocationRepository)
        {
            _userRightAllocationRepository = userRightAllocationRepository;
        }
        public async Task<UserRightAllocation> AddUserRightAllocation(UserRightAllocationRequestDTO request)
        {
            UserRightAllocation userRightAllocation = UserRightAllocationDTOMapper.UserRightAllocationDTOToEntityMapper(request);
            userRightAllocation.CreatedAt = DateTime.Now;
            await _userRightAllocationRepository.Add(userRightAllocation);
            _userRightAllocationRepository.Save();
            return userRightAllocation;
        }
        public List<UserRightAllocationResponseDTO> GetAll()
        {
            List<UserRightAllocation> userRightAllocations = _userRightAllocationRepository.GetAll().ToList();
            return UserRightAllocationDTOMapper.EntitiesToUserRightAllocationDTOs(userRightAllocations);
        }
        public bool RemoveUserRightAllocation(int? id)
        {
            UserRightAllocation userRightAllocation = _userRightAllocationRepository.Get(ans => ans.Id == id);
            if (userRightAllocation == null)
            {
                return false;
            }
            _userRightAllocationRepository.Remove(userRightAllocation);
            _userRightAllocationRepository.Save();
            return true;
        }
    }
}
