using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Interfaces
{
    public interface IFigure
    {
        double[] SidesOrRadius { get; set; }
        string FigureType { get; set; }
        double Area { get; set; }
        string Message { get; set; }

        void FindArea();

    }
}
