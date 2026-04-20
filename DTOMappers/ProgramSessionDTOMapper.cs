using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
namespace UniversityManagmentSystem.DTOMappers
{
    public class ProgramSessionDTOMapper
    {
        public static ProgramSession ProgramSessionDTOToEntityMapper(ProgramSessionRequestDTO programSessionRequestDTO)
        {
            ProgramSession programSession = new ProgramSession();
            programSession.SessionName = programSessionRequestDTO.ProgramSessionName;
            programSession.Description = programSessionRequestDTO.Description;
            programSession.Code = programSessionRequestDTO.Code;
            return programSession;
        }

        public static ProgramSession ProgramSessionEntityToDTOMapper(ProgramSession programsession, ProgramSessionRequestDTO programsessionRequestDTO)
        {
            programsession.SessionName = programsessionRequestDTO.ProgramSessionName;
            programsession.Description = programsessionRequestDTO.Description;
            programsession.Code = programsessionRequestDTO.Code;
            return programsession;
        }
        public static ProgramSessionResponseDTO EntityToProgramSessionDTO(ProgramSession programsession)
        {
            ProgramSessionResponseDTO programSessionResponseDTO = new ProgramSessionResponseDTO();
            programSessionResponseDTO.Id = programsession.Id;
            programSessionResponseDTO.ProgramSessionName = programsession.SessionName;
            programSessionResponseDTO.Description = programsession.Description;
            programSessionResponseDTO.Code = programsession.Code;
            programSessionResponseDTO.CreatedAt = programsession.CreatedAt;
            programSessionResponseDTO.UpdatedAt = programsession.UpdatedAt;
            programSessionResponseDTO.DeletedAt = programsession.DeletedAt;
            programSessionResponseDTO.CreatedBy = programsession.CreatedBy;
            programSessionResponseDTO.UpdatedBy = programsession.UpdatedBy;
            programSessionResponseDTO.DeletedBy = programsession.DeletedBy;
            programSessionResponseDTO.IsActive = programsession.IsActive;


            return programSessionResponseDTO;
        }
        public static List<ProgramSessionResponseDTO> ProgramSessionEntityToDTOMapper(List<ProgramSession> programSession)
        {
            List<ProgramSessionResponseDTO> programSessionResponseDTOs = new List<ProgramSessionResponseDTO>();
            foreach (ProgramSession programSessionItem in programSession)
            {
                ProgramSessionResponseDTO programSessionResponseDTO = EntityToProgramSessionDTO(programSessionItem);
                programSessionResponseDTOs.Add(programSessionResponseDTO);
            }
            return programSessionResponseDTOs;
        }
    }
}
