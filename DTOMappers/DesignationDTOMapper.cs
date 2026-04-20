using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DesignationDTOMapper
    {
        public static Designation DesignationDTOToEntityMapper(DesignationRequestDTO designationRequestDTO)
        {
            Designation designation = new Designation();
            designation.DesignationName = designationRequestDTO.DesignationName;
            designation.Description = designationRequestDTO.Description;
            designation.Code = designationRequestDTO.Code;
            return designation;
        }

        public static Designation DesignationEntityToDTOMapper(Designation designation , DesignationRequestDTO desinationRequestDTO)
        {
            designation.DesignationName = desinationRequestDTO.DesignationName;
            designation.Description = desinationRequestDTO.Description;
            designation.Code = desinationRequestDTO.Code;
            return designation;
        }
        public static DesignationResponseDTO EntityToDesignationDTO(Designation designation)
        {
            DesignationResponseDTO designationResponseDTO = new DesignationResponseDTO();
            designationResponseDTO.Id = designation.Id;
            designationResponseDTO.DesignationName = designation.DesignationName;
            designationResponseDTO.Description = designation.Description;
            designationResponseDTO.Code = designation.Code;
            designationResponseDTO.CreatedAt = designation.CreatedAt;
            designationResponseDTO.UpdatedAt = designation.UpdatedAt;
            designationResponseDTO.GlobalId = designation.GlobalId;
            return designationResponseDTO;
        }
        public static List<DesignationResponseDTO> DesignationEntityToDTOMapper(List<Designation> designations)
        {
            List<DesignationResponseDTO> designationResponseDTOs = new List<DesignationResponseDTO>();
            foreach (Designation designation in designations)
            {
                DesignationResponseDTO designationResponseDTO = EntityToDesignationDTO(designation);
                designationResponseDTOs.Add(designationResponseDTO);
            }
            return designationResponseDTOs;
        }
    }
}
