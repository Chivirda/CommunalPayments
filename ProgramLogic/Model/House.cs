namespace ProgramLogic.Model
{
    class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
