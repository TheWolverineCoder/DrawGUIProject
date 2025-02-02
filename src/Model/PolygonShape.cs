﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Draw
{
	[Serializable]
	public class PolygonShape : Shape
    {


	#region Constructor
	PointF One = new PointF();
	PointF Two = new PointF();
    PointF Three = new PointF();
	PointF Four = new PointF();
    PointF Five = new PointF();
	PointF Six = new PointF();
		PointF[] arrayOfPoints;
	public PolygonShape(PointF one,PointF two,PointF three,PointF four,PointF five,PointF six) : base(one,two,three,four,five,six)
	{
		One = one;
		Two = two;
		Three = three;
		Four = four;
		Five = five;
		Six = six;
		//arrayOfPoints = new PointF[]{ new PointF(One.X, One.Y) , new PointF(Two.X, Two.Y), new PointF(Three.X, Three.Y), new PointF(Four.X, Four.Y), new PointF(Five.X, Five.Y) };
	}

	public PolygonShape(PolygonShape polygon) : base(polygon)
	{

			
			polygon.arrayOfPoints = new PointF[] { new PointF(polygon.One.X, polygon.One.Y), new PointF(polygon.Two.X, polygon.Two.Y), new PointF(polygon.Three.X, polygon.Three.Y), new PointF(polygon.Four.X, polygon.Four.Y), new PointF(polygon.Five.X, polygon.Five.Y) };
	}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		/// 
		/*public static bool IsPointInPolygon4(PointF[] polygon, PointF testPoint)
		{
			bool result = false;
			int j = polygon.Count() - 1;
			for (int i = 0; i < polygon.Count(); i++)
			{
				if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y || polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
				{
					if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) * (polygon[j].X - polygon[i].X) < testPoint.X)
					{
						result = !result;
					}
				}
				j = i;
			}
			return result;
		}*/
		/*
		public static bool IsInPolygon(PointF[] poly, PointF p)
		{
			
			
		}*/
		
		

		public override bool Contains(PointF point)
	{
            //if (base.Contains(point))
            //{
            //return IsInPolygon(arrayOfPoints, point);
				if(point.X > this.One.X)
            {
				return true;
			}
            else
            {
				return false;
			}
				
		//}

		//else {
			// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
			//return false;
		//}
	}
	/// <summary>
	/// Частта, визуализираща конкретния примитив.
	/// </summary>
	public override void DrawSelf(Graphics grfx)
	{
			/*Random rnd = new Random();*/
			//int firstX = rnd.Next(50, 150);
			//int firstY = rnd.Next(50, 150);
			/*int firstX = rnd.Next(50, 550);
			int firstY = rnd.Next(150, 500);
			*/
			/*polygonPoints[0] = new Point(firstX, firstY);
			polygonPoints[1] = new Point((int)(firstX/2.5), (int)(firstY / 2.3));
			polygonPoints[2] = new Point(firstX*2, firstY/15);
			polygonPoints[3] = new Point((int)(firstX*3.5), (int)(firstY / 2.3));
			polygonPoints[4] = new Point(firstY, firstY);
			polygonPoints[5] = new Point(firstX, firstY);*/
			/*PointF one = new PointF(firstX, firstY);
			PointF two = new PointF(firstX - 30, firstY - 85);
			PointF three = new PointF(firstX + 50, firstY - 140);
			PointF four = new PointF(firstX + 125, firstY - 85);
			PointF five = new PointF(firstX + 100, firstY);
			PointF six = new PointF(firstX, firstY);*/
			base.DrawSelf(grfx);
			this.Location = this.One;
			grfx.FillPolygon(new SolidBrush(Color.FromArgb(Opacity, FillColor)), new PointF[] { One,Two,Three,Four,Five});
			grfx.DrawPolygon(new Pen(StrokeColor,BorderWidth), new PointF[] { One,Two,Three,Four,Five });
			
			


	}

	}
}
