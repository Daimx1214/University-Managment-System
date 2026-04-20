using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;
public class PLOToCLODTOMapper
{
    public static PLOToCLO PLOToCLODTOToEntityMapper(PLOToCLORequestDTO dto)
    {
        PLOToCLO entity = new PLOToCLO();
        entity.PLOId = dto.PLOId;
        entity.CLOId = dto.CLOId;
        return entity;
    }

    public static PLOToCLO PLOToCLODTOToEntityMapper(PLOToCLO entity, PLOToCLORequestDTO dto)
    {
        entity.PLOId = dto.PLOId;
        entity.CLOId = dto.CLOId;
        entity.UpdatedAt = DateTime.Now;
        return entity;
    }

    public static PLOToCLOResponseDTO EntityToPLOToCLODTO(PLOToCLO entity)
    {
        PLOToCLOResponseDTO response = new PLOToCLOResponseDTO();
        response.Id = entity.Id;
        response.PLOId = entity.PLOId;
        response.CLOId = entity.CLOId;
        response.CreatedAt = entity.CreatedAt;
        response.UpdatedAt = entity.UpdatedAt;
        response.IsActive = entity.IsActive;
        response.GlobalId = entity.GlobalId;
        return response;
    }

    public static List<PLOToCLOResponseDTO> EntitiesToPLOToCLODTOs(List<PLOToCLO> entities)
    {
        List<PLOToCLOResponseDTO> responseList = new List<PLOToCLOResponseDTO>();
        foreach (PLOToCLO entity in entities)
        {
            responseList.Add(EntityToPLOToCLODTO(entity));
        }
        return responseList;
    }
}

