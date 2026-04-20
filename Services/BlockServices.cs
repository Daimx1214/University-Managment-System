using UniversityManagementSystem.DTOMappers;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.Services
{
    public class BlockServices
    {
        private readonly IBlockRepository _blockRepository;
        public BlockServices(IBlockRepository blockRepository)
        {
            _blockRepository = blockRepository;
        }
        public async Task<Block> AddBlock(BlockRequestDTO request)
        {
            Block block = BlockDTOMapper.BlockDTOToEntityMapper(request);
            block.CreatedAt = DateTime.Now;
            await _blockRepository.Add(block);
            _blockRepository.Save();
            return block;
        }
        public List<BlockResponseDTO> GetAll()
        {
            List<Block> blocks = _blockRepository.GetAll().ToList();
            return BlockDTOMapper.EntitiesToBlockDTOs(blocks);
        }
        public bool RemoveBlock(int? id)
        {
            Block block = _blockRepository.Get(ans => ans.Id == id);
            
            _blockRepository.Remove(block);
            _blockRepository.Save();
            return true;
        }
    }
}
