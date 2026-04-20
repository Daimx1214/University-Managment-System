using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Model
{
    public class Floor : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public List<Room> Rooms { get; set; }
    }
}




//Floor:
//1.FloorName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.BuildingId(int type)
