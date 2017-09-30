using System.Collections.Generic;
using WearManager.Enums;

namespace WearManager.Models
{
    public class Wheel : AbstractComponent 
    {
        public string Set { get; set; }
        public Position Type { get; set; }
        public Part Tire { get; set; }
        public Part CogSet { get; set; }
        
    }
}