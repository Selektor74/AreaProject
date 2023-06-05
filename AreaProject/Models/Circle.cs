using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Interfaces;
using TestProject.Services;

namespace TestProject.Models
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if(radius!=null&& radius>0)
            {
                SidesOrRadius[0] = radius;
                FigureType = this.GetType().Name;

            }
        }
        public double[] SidesOrRadius { get; set; }
        public string FigureType { get; set; }
        public string Message { get; set; }
        public double Area { get; set ; }

        public void FindArea()
        {
            AreaService areaService = new AreaService();
            Area = areaService.CircleArea(SidesOrRadius[0]);
        }
    }
}
