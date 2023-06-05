using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject.Services
{
    public interface IAreaService
    {
        double CircleArea(double radius);

        double TriangleArea(double sideA, double sideB, double sideC);

    }
    public class AreaService : IAreaService
    {
        public double CircleArea(double radius)
        {
            if (radius > 0)
            {
                var result = Math.PI * (radius * radius);
                return result;
            }
            throw new InvalidDataException("Incorrect data");

        }

        public double TriangleArea(double sideA, double sideB, double sideC)
        {

            if (Validation(sideA, sideB, sideC))
            {
                var p = (sideA + sideB + sideC) / 2;

                var area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                return area;
            }
            throw new InvalidDataException("Incorrect data");
        }



        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            if (Validation(sideA, sideB, sideC))
            {
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    return true;
                }
                if (sideA * sideA + sideC * sideC == sideB * sideB)
                {
                    return true;
                }
                if (sideB * sideB + sideC * sideC == sideA * sideA)
                {
                    return true;
                }
                return false;
            }
            return false;

        }



        private bool Validation(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new InvalidDataException("Incorrect data");

            if (sideA > sideC + sideB || sideB > sideC + sideA || sideC > sideA + sideB)
                throw new InvalidDataException("Incorrect data");

            else return true;
        }
    }
}

