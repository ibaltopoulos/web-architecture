namespace DeskManager.Core
{
    public class Desk
    {
        public string Id { get; set; }
        public string Number { get; set; }
        public Person Occupier { get; set; }

        public bool IsEmpty()
        {
            return !IsOccupied();
        }

        public bool IsOccupied()
        {
            return Occupier != null;
        }
    }

    public enum DeskStatus
    {
        Empty,
        Occupied
    }

    public class Person
    {
        public string Id { get; set; }
    }

}
