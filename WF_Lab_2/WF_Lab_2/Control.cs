using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Lab_2
{
    [Serializable]
    public class Control
    {
        public Control() { }    
        public List<Airport> airport { get; set; } = new List<Airport>();
    }
}
