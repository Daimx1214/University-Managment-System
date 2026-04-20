using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Model
{
    public class Campus : BaseModel
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public int UniversityId { get; set; }
        public University University { get; set; }
        public List<Building> Buildings { get; set; }
    }
}
//Campus:
//1.CampusName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.UniversityId(int type)
