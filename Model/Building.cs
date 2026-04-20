using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Model
{
    public class Building : BaseModel
    {
        public string? Name {  get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn {  get; set; }
        public string? Address { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
        public List<Floor> Floors { get; set; }
    }
}


//Building:
//1.BuildingName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.CampusId(int type)
