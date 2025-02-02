﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Draw
{
	[Serializable]
	public class CircleShape : Shape
	{
		#region Constructor

		public CircleShape(RectangleF rect) : base(rect)
		{
		}

		public CircleShape(EllipseShape circle) : base(circle)
		{
		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
			{
				float a = Width / 2;
				float b = Height / 2;
				float x1 = Location.X + a;
				float y1 = Location.Y + b;
				bool isItOn = (Math.Pow((point.X - x1) / a, 2) + Math.Pow((point.Y - y1) / b, 2) - 1) <= 0;
				return isItOn;
			}

			else
			{
				return false;
			}


		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			
			//grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.FillEllipse(new SolidBrush(Color.FromArgb(Opacity, FillColor)), new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width));
			//grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor,BorderWidth), new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Width));

		}
	}
}
