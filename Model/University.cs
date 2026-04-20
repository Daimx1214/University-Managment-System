using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManagementSystem.Model
{
    public class University : BaseModel
    {
        public string? UniversityName { get; set;}
        public string? Description { get; set; }
        public DateTime EstablishedIn { get; set; }
        public string? Address { get; set; }
        public List<Campus> Campuses { get; set; }
    }
}


//University:
//1.UniversityName(string type)
//2.Description(string type)
//3.EstablishedIn(datetime type)
//4.Address(string type)

//Campus:
//1.CampusName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.UniversityId(int type)

//Building:
//1.BuildingName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.CampusId(int type)

//Floor:
//1.FloorName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.BuildingId(int type)

//Room:
//1.RoomName(string type)
//2.Code(string type)
//3.Description(string type)
//4.EstablishedIn(datetime type)
//5.Address(string type)
//6.FloorId(int type)

//RoomType:
//1.RoomTypeName(string type)
//2.Code(string type)
//3.Description(string type)

//RoomFeature:
//1.RoomFeatureName(string type)
//2.Code(string type)
//3.Description(string type)

//RoomTypeAllocation:
//1.RoomId(int type)
//2.RoomTypeId(int type)

//RoomFeatureAllocation:
//1.RoomId(int type)
//2.RoomFeatureId(int type)
//3.Quantity(int type)
