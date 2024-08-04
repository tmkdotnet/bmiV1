using System;

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


        public double CalculateBmi()
        {

            if (_height == 0)
            {
                throw new InvalidOperationException("Wzrost musi byc wiekszy niz  0");
            };
            // BMI = waga (kg) / (wzrost (m) * wzrost (m))

            double heightInMeters = _height / 100; // Zakładając, że wzrost jest w centymetrach
            double bmi = _weight / (heightInMeters * heightInMeters);
            return Math.Round(bmi,1);
        }
    }//End BMI
}
