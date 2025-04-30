using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO.Exercicios_Alura
{
    public class Rectangle
    {
        public double widht;
        public double heigth;

        public double Area(double widht, int heigth) {
            this.widht = widht;
            this.heigth = heigth;  
            double area = widht * heigth;
            return area;
        }
        public double Perimeter(double widht, int heigth)
        {
            this.widht = widht;
            this.heigth = heigth;
            double perimeter = 2 * (widht + heigth);
            return perimeter;
        }
        public double Diagonal(double widht, int heigth)
        {
            this.widht = widht;
            this.heigth = heigth;
            double result = (widht * widht) + (heigth * heigth);
            double diagonal = Math.Sqrt(result);
            return diagonal;
        }

    }
}
