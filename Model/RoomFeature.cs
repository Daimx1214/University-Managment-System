using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Model
{
    public class RoomFeature : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
    }
}



//RoomFeature:
//1.RoomFeatureName(string type)
//2.Code(string type)
//3.Description(string type)