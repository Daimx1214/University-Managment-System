using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Model
{
    public class Room : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public int FloorId { get; set; }
        public Floor Floor { get; set; }
        public List<RoomFeatureAllocation> FeatureAllocation { get; set; }
        public List<RoomTypeAllocation> TypeAllocation { get; set; }
    }
}



//Room:
//1.RoomName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.FloorId(int type)
