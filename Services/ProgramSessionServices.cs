using UniversityManagmentSystem.DTOMappers;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.DTOs.ResponseDTO;

namespace UniversityManagmentSystem.Services
{
    public class ProgramSessionServices
    {
        private readonly IProgramSessionRepository _programSessionRepository;

        public ProgramSessionServices(IProgramSessionRepository programSessionRepository)
        {
            _programSessionRepository = programSessionRepository;
        }
        public async Task<ProgramSession> AddProgramSession(ProgramSessionRequestDTO request)
        {
            ProgramSession programSession = ProgramSessionDTOMapper.ProgramSessionDTOToEntityMapper(request);

            programSession.CreatedAt = DateTime.Now;
            await _programSessionRepository.Add(programSession);
            _programSessionRepository.Save();
            return programSession;
        }
        public List<ProgramSessionResponseDTO> GetAll()
        {
            List<ProgramSession> programSessions = _programSessionRepository.GetAll().ToList();
            return ProgramSessionDTOMapper.ProgramSessionEntityToDTOMapper(programSessions);
        }
        public bool RemoveProgramSession(int? id)
        {
            ProgramSession programSession = _programSessionRepository.Get(programSession => programSession.Id == id);
            if (programSession == null)
            {
                return false; // Program session not found
            }
            _programSessionRepository.Remove(programSession);
            _programSessionRepository.Save();
            return true;
        }
    }
}
