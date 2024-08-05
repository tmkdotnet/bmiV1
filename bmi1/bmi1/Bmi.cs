using System;
using System.Windows;

namespace bmi1.Model
{
    internal class Bmi
    {
        private double _weight;
        private double _height;

        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentException("Waga musi byc +");
                }

            }

        }

        public double Height
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {

                    throw new ArgumentException("Wzrost musi byc +");
                }
            }

        }


        public Bmi(double weight, double height)
        {

            if (weight <= 0)
            {
                throw new ArgumentException($"Waga musi byc +");
            }
            if (height <= 0)
            {
                throw new ArgumentException($"Wzrost musi byc +");
            }

            this._weight = weight;
            this._height = height;
        }


        public double CalculateBmi(out string classyfication)
        {

            if (_height == 0)
            {
                throw new InvalidOperationException("Wzrost musi byc wiekszy niz  0");
            };
            // BMI = waga (kg) / (wzrost (m) * wzrost (m))

            double heightInMeters = _height / 100; // Zakładając, że wzrost jest w centymetrach
            double bmi = _weight / (heightInMeters * heightInMeters);

            classyfication = ClassifyBmi(Math.Round(bmi, 2));
            
            return Math.Round(bmi, 1);
        }

        private string ClassifyBmi(double computedBmi)
        {
         
            if (computedBmi < 16.0)
            {
                return "Wyglodzenie";
            }
            else if (computedBmi >= 16.0 && computedBmi <= 16.9)
            {
                return "Wychudzenie";
            }
            else if (computedBmi >= 17.0 && computedBmi <= 18.49)
            {
                
                return "Niedowaga";
            }
            else if (computedBmi >= 18.5 && computedBmi <= 24.9)
            {
                return "Prawidlowa waga 18-65 lat";
            }
            else if (computedBmi >= 25.0 && computedBmi <= 29.9)
            {
                return "Nadwaga";
            }
            else if (computedBmi >= 30.0 && computedBmi <= 34.9)
            {
                return "1-wszy stopien otylosci";
            }
            else if (computedBmi >= 35.0 && computedBmi <= 39.9)
            {
                return "2-gi stopien otylosci";
            }
            else
            {
                return "3-ci stopien otylosci";
            }
        
        }
    }//End BMI
}



