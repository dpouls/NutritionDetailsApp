using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionApp
{
    public class Food
    {
        //creates all the properties
        private string _food;
        private string _calcium;
        private string _serving_size;
        private string _weight;
        private string _percent_water;
        private string _energy;
        private string _protein;
        private string _carb;
        private string _fiber;
        private string _chol;
        private string _total_fat;
        private string _sat_fat;
        private string _mon_fat;
        private string _poly_fat;
        private string _iron;
        private string _magnesium;
        private string _sodium;
        private string _phos;
        private string _cap;
        private string _potassium;
        private string _zinc;
        private string _niacin;
        private string _thiamin;
        private string _ribo;
        private string _vit_a;
        private string _vit_b;
        private string _vit_c;
        private string _food_type;
        /// <summary>
        /// constructor to create all the variables that you find in this class each time you instantiate the class.
        /// </summary>
        /// <param name="foodArray"></param>
        public Food(string[] foodArray)
        {
            FoodName = foodArray[0];
            Calcium = foodArray[1];
            ServingSize = foodArray[2];
            Weight = foodArray[3];
            PercentWater = foodArray[4];

            Energy = foodArray[5];
            Protein = foodArray[6];
            Carb = foodArray[7];
            Fiber = foodArray[8];
            Cholesterol = foodArray[9];

            TotalFat = foodArray[10];
            SatFat = foodArray[11];
            MonFat = foodArray[12];
            PolyFat = foodArray[13];
            Iron = foodArray[14];

            Magnesium = foodArray[15];
            Sodium = foodArray[16];
            Phos = foodArray[17];
            Cap = foodArray[18];
            Potassium = foodArray[19];

            Zinc = foodArray[20];
            Niacin = foodArray[21];
            Thiamin = foodArray[22];
            Ribo = foodArray[23];
            VitA = foodArray[24];

            VitB = foodArray[25];
            VitC = foodArray[26];
            FoodType = foodArray[27];

        }

        public string FoodType
        {
            get { return _food_type; }
            set { _food_type = value; }
        }


        public string VitC
        {
            get { return _vit_c; }
            set { _vit_c = value; }
        }


        public string VitB
        {
            get { return _vit_b; }
            set { _vit_b = value; }
        }


        public string VitA
        {
            get { return _vit_a; }
            set { _vit_a = value; }
        }

        public string Ribo
        {
            get { return _ribo; }
            set { _ribo = value; }
        }

        public string Thiamin
        {
            get { return _thiamin; }
            set { _thiamin = value; }
        }

        public string Niacin
        {
            get { return _niacin; }
            set { _niacin = value; }
        }

        public string Zinc
        {
            get { return _zinc; }
            set { _zinc = value; }
        }


        public string Potassium
        {
            get { return _potassium; }
            set { _potassium = value; }
        }

        public string Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }


        public string Phos
        {
            get { return _phos; }
            set { _phos = value; }
        }

        public string Sodium
        {
            get { return _sodium; }
            set { _sodium = value; }
        }

        public string Magnesium
        {
            get { return _magnesium; }
            set { _magnesium = value; }
        }

        public string Iron
        {
            get { return _iron; }
            set { _iron = value; }
        }

        public string PolyFat
        {
            get { return _poly_fat; }
            set { _poly_fat = value; }
        }

        public string MonFat
        {
            get { return _mon_fat; }
            set { _mon_fat = value; }
        }


        public string SatFat
        {
            get { return _sat_fat; }
            set { _sat_fat = value; }
        }

        public string TotalFat
        {
            get { return _total_fat; }
            set { _total_fat = value; }
        }


        public string Cholesterol
        {
            get { return _chol; }
            set { _chol = value; }
        }

        public string Fiber
        {
            get { return _fiber; }
            set { _fiber = value; }
        }

        public string Carb
        {
            get { return _carb; }
            set { _carb = value; }
        }


        public string Protein
        {
            get { return _protein; }
            set { _protein = value; }
        }

        public string Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }


        public string PercentWater
        {
            get { return _percent_water; }
            set { _percent_water = value; }
        }


        public string Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public string ServingSize
        {
            get { return _serving_size; }
            set { _serving_size = value; }
        }


        public string Calcium
        {
            get { return _calcium; }
            set { _calcium = value; }
        }

        public string FoodName
        {
            get { return _food; }
            set { _food = value; }
        }

    }
}
