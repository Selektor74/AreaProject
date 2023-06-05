using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Interfaces;
using TestProject.Services;

namespace TestProject.Models
{
    public class Triangle : IFigure
    {
        public Triangle(double[] sides)
        {
            if(sides!=null&&sides.Length==3)
            {
                SidesOrRadius = sides;
                FigureType = this.GetType().Name;
            }
        }
        public double[] SidesOrRadius { get ; set ; }
        public string FigureType { get ; set ; }
        public double Area { get; set; }
        public string Message { get; set; }

        public void FindArea()
        {
            AreaService areaService = new AreaService();
            Area = areaService.TriangleArea(SidesOrRadius[0], SidesOrRadius[1], SidesOrRadius[2]);
            Message = areaService.IsRightTriangle(SidesOrRadius[0], SidesOrRadius[1], SidesOrRadius[2]) == true ? "Triangle is Right" : "Triangle is not Right";


        }
    }
}
