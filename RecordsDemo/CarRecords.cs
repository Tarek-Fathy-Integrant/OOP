using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo
{
    internal record CarRecord
    {
        //Properties
        public string Make { get; init; }
        public string Model { get; init; }
        public string Color { get; init; }
        //Constructors
        public CarRecord() { }
        public CarRecord(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }
        //Methods
        public string DisplayCarDetails()
        {
            return $"Car Details:\n------------\nMake: {Make}\nModel: {Model}\nColor: {Color}\n===============\n";
        }
    }
}
