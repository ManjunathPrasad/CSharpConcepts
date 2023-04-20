using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Demo
{
    public class Fish
    {
        #region Private Fields
        private string? fishBreed;

        private string? fishSize = "";

        private int FishCount = 0;
        #endregion

        //FishRegion made as static with static keyword
        public static string? FishRegion = "Pacific Ocean";

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
                return FishBreed;
            }
            set 
            { 
                if (value == "Color Widow" || value == "Tiger Barb" || value =="Gold Fish") 
                {
                    FishBreed = value;
                }
                else
                {
                    FishBreed = "Unknown";
                }     
            }
        }

        public string? FishColor { get; set; }

        public string? FishSize
        {
            get
            {
                return FishSize;
            }
            set
            {
                if (fishSize == "Small" || fishSize == "Medium" || fishSize == "Large")
                {
                    FishSize = fishSize;
                }
                else
                {
                    FishSize = "Unsize";
                }
            }
        }
        #endregion

        #region Fish Methods
        public int CountFish ()
        {
            FishCount++;
            return FishCount;
        }
        #endregion
    }
}
