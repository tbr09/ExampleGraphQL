namespace ExampleGraphQL.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public RoomStatus Status { get; set; }
    }

    public enum RoomStatus
    {
        Unavailable = 0,
        Available = 1
    }
}
