using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Demo
{
    public class Fish : IFish
    {
        #region public Fields

        private string fishBreed;

        public string fishColor;

        private string fishSize;

        public int FishCount = 0;

        #endregion

        //FishRegion made as static with static keyword
        public static string FishRegion = "Pacific Ocean";

        #region Fish Constructor
        public Fish(string breed, string color, string size)
        {
            FishBreed = breed;
            FishColor = color;
            FishSize = size;
        }
        #endregion

        #region Fish Properties
        public string FishBreed
        {
            get
            {
                return fishBreed;
            }
            set
            {
                if (value == "Color Widow" || value == "Tiger Barb" || value == "Gold Fish")
                {
                    fishBreed = value;
                }
                else
                {
                    fishBreed = "Unknown";
                }
            }
        }

        public string FishColor 
        {
            get
            {
                return fishColor;
            } 
            set
            {
                fishColor = value;
            }
             
        }

        public string FishSize
        {
            get
            {
                return fishSize;
            }
            set
            {
                if (value == "Small" || value == "Medium" || value == "Large")
                {
                    fishSize = value;
                }
                else
                {
                    fishSize = "Unsize";
                }
            }
        }
        #endregion

        #region Fish Methods
        public int CountFish()
        {
            FishCount++;
            return FishCount;
        }
        #endregion
    }
}
