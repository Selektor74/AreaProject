using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Interfaces;
using TestProject.Models;

namespace TestProject.Services
{
    public interface IFigureService
    {
        IFigure CreateCircle(double radius);
        IFigure CreateTriangle(double[] sides);
    }

    public class FigureService : IFigureService
    {
        public IFigure CreateCircle(double radius)
        {
            if (radius > 0)
            {
                return new Circle(radius);
            }
            throw new InvalidDataException("Incorrect Data");
        }

        public IFigure CreateTriangle(double[] sides)
        {
            if (sides.Length == 3)
            {
                return new Triangle(sides);
            }
            throw new InvalidDataException("Incorrect Data");
        }
    }
}
