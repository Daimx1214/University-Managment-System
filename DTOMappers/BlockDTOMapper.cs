using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class BlockDTOMapper
    {
        public static Block BlockDTOToEntityMapper(BlockRequestDTO blockDTO)
        {
            Block block = new Block();
            block.Name = blockDTO.Name;
            block.Description = blockDTO.Description;
            block.EstablishedIn = blockDTO.EstablishedIn;
            block.Code = blockDTO.Code;
            return block;
        }

        public static Block BlockDTOToEditEntityMapper(Block block, BlockRequestDTO blockDTO)
        {
            block.Name = blockDTO.Name;
            block.Description = blockDTO.Description;
            block.EstablishedIn = blockDTO.EstablishedIn;
            block.Code = blockDTO.Code;
            block.UpdatedAt = DateTime.Now;
            return block;
        }

        public static BlockResponseDTO EntityToBlockDTO(Block block)
        {
            BlockResponseDTO blockResponseDTO = new BlockResponseDTO();
            blockResponseDTO.Id = block.Id;
            blockResponseDTO.Name = block.Name;
            blockResponseDTO.Description = block.Description;
            blockResponseDTO.EstablishedIn = block.EstablishedIn;
            blockResponseDTO.Code = block.Code;
            blockResponseDTO.CreatedAt = DateTime.Now;
            blockResponseDTO.UpdatedAt = DateTime.Now;
            blockResponseDTO.GlobalId = block.GlobalId;
            return blockResponseDTO;
        }

        public static List<BlockResponseDTO> EntitiesToBlockDTOs(List<Block> blocks)
        {
            List<BlockResponseDTO> blockResponseDTOs = new List<BlockResponseDTO>();
            foreach (Block block in blocks)
            {
                BlockResponseDTO blockResponseDTO = EntityToBlockDTO(block);
                blockResponseDTOs.Add(blockResponseDTO);
            }
            return blockResponseDTOs;
        }
    }
}
