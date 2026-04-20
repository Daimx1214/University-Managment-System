using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Model
{
    public class RoomType : BaseModel
    {
        public string? Name { get; set; }
        public string? Code {  get; set; }
        public string? Description { get; set; }

    }
}


//RoomType:
//1.RoomTypeName(string type)
//2.Code(string type)
//3.Description(string type)