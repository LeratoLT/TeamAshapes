using System;
using System.Collections.Generic;
using System.Text;

namespace GitShapesTest
{
    class Triangle
    {
		private decimal t_base, t_height;
		public decimal getT_base()
		{
			return t_base;
		}
		public decimal getT_height()
		{
			return t_base;
		}
		public Triangle(decimal t_base, decimal t_height)
		{
			this.t_base = t_base;
			this.t_height = t_height;
		}
		public decimal calculate_area()
		{
			return  0.5m * getT_base() * getT_height();
		}
	}
}
