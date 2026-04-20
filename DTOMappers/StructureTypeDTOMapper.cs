using Microsoft.Identity.Client;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class StructureTypeDTOMapper
    {
        public static StructureType StructureTypeDTOToEntityMapper(StructureTypeRequestDTO requestDTO)
        {
            StructureType structureType = new StructureType();
            structureType.StructureTypeName = requestDTO.StructureTypeName;
            structureType.Description = requestDTO.Description;
            structureType.Code = requestDTO.Code;
            return structureType;
        }

        public static StructureType StructureTypeDTOToEntityMappers(StructureType structureType, StructureTypeRequestDTO structureTypeRequestDTO)
        {
            structureType.StructureTypeName = structureTypeRequestDTO.StructureTypeName;
            structureType.Description = structureTypeRequestDTO.Description;
            structureType.Code = structureTypeRequestDTO.Code;
            return structureType;
        }

        public static StructureTypeResponseDTO EntityToStructureTypeDTO(StructureType structureType) 
        {
            StructureTypeResponseDTO structureTypeResponseDTO = new StructureTypeResponseDTO();
            structureTypeResponseDTO.Id = structureType.Id;
            structureTypeResponseDTO.StructureTypeName = structureType.StructureTypeName;
            structureTypeResponseDTO.Code = structureType.Code;
            structureTypeResponseDTO.Description = structureType.Description;
            structureTypeResponseDTO.CreatedAt = structureType.CreatedAt;
            structureTypeResponseDTO.UpdatedAt = structureType.UpdatedAt;
            structureTypeResponseDTO.GlobalId = structureType.GlobalId;
            return structureTypeResponseDTO;
        }

        public static List<StructureTypeResponseDTO> StructureTypeEntityToDTOMapper(List<StructureType> structureType)
        {
            List<StructureTypeResponseDTO> structureTypeResponseDTOs = new List<StructureTypeResponseDTO>();
            foreach (StructureType structureTypeItem in structureType)
            {
                StructureTypeResponseDTO structureTypeResponseDTO = EntityToStructureTypeDTO(structureTypeItem);
                structureTypeResponseDTOs.Add(structureTypeResponseDTO);
            }
            return structureTypeResponseDTOs;
        }
    }
}
