using System;

public class Circle
{
	public Circle()
	{
		radius = 0;
	}

	private decimal radius;

	public decimal calculateCircleArea(int r)
	{
		radius = r;
		decimal pi = Math.PI;
		decimal area = pi * radius * radius;
		return area;		
	}
}
