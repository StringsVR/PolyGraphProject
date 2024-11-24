using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolyGraphProject
{
    //Data type for the data the polygraphTest sends via HID.
    public class PolyData
    {
        public float Temp { get; set; }   // Temperature
        public float Moist { get; set; }  // Moisture
        public float Heart { get; set; } // Heart Rate

        public PolyData(float temp = 0, float moist = 0, float heart = 0) 
        {
            Temp = temp;
            Moist = moist;
            Heart = heart;
        }

        public override string ToString()
        {
            return $"Temp: {Temp}, Moist: {Moist}, Heart: {Heart}";
        }
    }
}
