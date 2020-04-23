namespace ProgramLogic.Model
{
    class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
