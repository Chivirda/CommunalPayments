﻿namespace ProgramLogic.Model
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
