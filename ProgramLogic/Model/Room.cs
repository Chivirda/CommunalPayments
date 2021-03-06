﻿namespace ProgramLogic.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public int HouseId { get; set; }
        public virtual House House { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
