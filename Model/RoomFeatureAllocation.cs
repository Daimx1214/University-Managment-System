namespace UniversityManagementSystem.Model
{
    public class RoomFeatureAllocation : BaseModel
    {
        public int RoomId { get; set; }
        public int RoomFeatureId { get; set; }
        public int Quantity { get; set; }
    }
}


//RoomFeatureAllocation:
//1.RoomId(int type)
//2.RoomFeatureId(int type)
//3.Quantity(int type)
