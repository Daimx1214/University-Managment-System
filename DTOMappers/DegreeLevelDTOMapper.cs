using UniversityManagementSystem.Model;
using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.DTOs.ResponseDTP;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class DegreeLevelDTOMapper
    {
        public static DegreeLevel DegreeLevelDTOToEntityMapper(DegreeLevelRequestDTO degreeLevelRequestDTO)
        {
            DegreeLevel degreeLevel = new DegreeLevel();
            degreeLevel.DegreeLevelName = degreeLevelRequestDTO.DegreeLevelName;
            degreeLevel.Description = degreeLevelRequestDTO.Description;
            degreeLevel.Code = degreeLevelRequestDTO.Code;
            degreeLevel.Level = degreeLevelRequestDTO.Level;

            //degreeLevel LevelId = degreeLevelRequestDTO.Id;
            degreeLevel.IsActive = true; // Assuming IsActive is a property in BaseModel
            return degreeLevel;
        }
        public static DegreeLevel DegreeLevelEntityToDTOMapper(DegreeLevel degreeLevel , DegreeLevelRequestDTO degreeLevelRequestDTO)
        {
            degreeLevel.DegreeLevelName = degreeLevelRequestDTO.DegreeLevelName;
            degreeLevel.Description = degreeLevelRequestDTO.Description;
            degreeLevel.Code = degreeLevelRequestDTO.Code;
            degreeLevel.Level = degreeLevelRequestDTO.Level;
            //degreeLevel LevelId = degreeLevelRequestDTO.Id;
            degreeLevel.IsActive = true; // Assuming IsActive is a property in BaseModel
            return degreeLevel;
        }

        public static DegreeLevelResponseDTO EntityToDegreeLevelDTO(DegreeLevel degreeLevel)
        {
            DegreeLevelResponseDTO degreeLevelResponseDTO = new DegreeLevelResponseDTO();
            degreeLevelResponseDTO.Id = degreeLevel.Id;
            degreeLevelResponseDTO.DegreeLevelName = degreeLevel.DegreeLevelName;
            degreeLevelResponseDTO.Description = degreeLevel.Description;
            degreeLevelResponseDTO.Code = degreeLevel.Code;
            degreeLevelResponseDTO.Level = degreeLevel.Level;
            degreeLevelResponseDTO.IsActive = degreeLevel.IsActive;
            degreeLevelResponseDTO.CreatedAt = degreeLevel.CreatedAt;
            degreeLevelResponseDTO.UpdatedAt = degreeLevel.UpdatedAt;
            degreeLevelResponseDTO.GlobalId = degreeLevel.GlobalId;
            return degreeLevelResponseDTO;
        }

        public static List<DegreeLevelResponseDTO> EntitiesToDegreeLevelDTOs(List<DegreeLevel> degreeLevels)
        {
            List<DegreeLevelResponseDTO> degreeLevelResponseDTOs = new List<DegreeLevelResponseDTO>();
            foreach (DegreeLevel degreelevel in degreeLevels)
            {
                DegreeLevelResponseDTO degreeLevelResponseDTO = EntityToDegreeLevelDTO(degreelevel);
                degreeLevelResponseDTOs.Add(degreeLevelResponseDTO);
            }
            return degreeLevelResponseDTOs;
        }
    }
}

