using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.DTOMappers
{
    public class InstituteDTOMapper
    {
        public static Institute InstituteDTOToEntityMapper(InstituteRequestDTO dto)
        {
            Institute institute = new Institute();
            institute.InstituteName = dto.InstituteName;
            institute.Description = dto.Description;
            institute.EstablishedIn = dto.EstablishedIn;
            institute.Code = dto.Code;
            institute.FacultyCampusId = dto.FacultyCampusId;
            return institute;
        }

        public static Institute InstituteDTOToEntityMapper(Institute entity, InstituteRequestDTO dto)
        {
            entity.InstituteName = dto.InstituteName;
            entity.Description = dto.Description;
            entity.EstablishedIn = dto.EstablishedIn;
            entity.Code = dto.Code;
            entity.FacultyCampusId = dto.FacultyCampusId;
            entity.UpdatedAt = DateTime.Now;
            return entity;
        }

        public static InstituteResponseDTO EntityToInstituteDTO(Institute entity)
        {
            InstituteResponseDTO response = new InstituteResponseDTO();
            response.Id = entity.Id;
            response.InstituteName = entity.InstituteName;
            response.Description = entity.Description;
            response.EstablishedIn = entity.EstablishedIn;
            response.Code = entity.Code;
            response.FacultyCampusId = entity.FacultyCampusId;
            response.CreatedAt = DateTime.Now;
            response.UpdatedAt = DateTime.Now;
            response.IsActive = entity.IsActive;
            response.GlobalId = entity.GlobalId;
            return response;
        }

        public static List<InstituteResponseDTO> EntitiesToInstituteDTOs(List<Institute> entities)
        {
            List<InstituteResponseDTO> responseList = new List<InstituteResponseDTO>();
            foreach (Institute entity in entities)
            {
                responseList.Add(EntityToInstituteDTO(entity));
            }
            return responseList;
        }
    }
}
