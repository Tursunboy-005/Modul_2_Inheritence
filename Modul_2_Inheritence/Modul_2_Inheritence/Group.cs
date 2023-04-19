using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Inheritence
{
    internal class Group
    {
        private static int MaxStudentnumber = 24;
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Room { get; set; }
        public int Floor { get; set; }
        public int[] Students = new Students[MaxStudentnumber];

        public Group(int id, string name, int room, int floor, int[] student) 
        {
            Id = id;
            Name = name;
            Room = room;
            Floor = floor;
            Students = student;           
        }
       
        public void Display()
        {
            Console.WriteLine($"ID - {Id}, Name - {Name}, Room - {Room}, Floor - {Floor}, Students - {Students} ");
        }
    }
}