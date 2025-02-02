﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw
{
	[Serializable]
	public class LineShape : Shape
		{
		#region Constructor


		
		public LineShape(RectangleF lineSha) : base(lineSha)
        {
			
        }

		public LineShape(LineShape line) : base(line)
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
		/// 
		bool IsOnLine(PointF point1, PointF point2, PointF p, int width = 5)
		{
			using (var path = new GraphicsPath())
			{
				using (var pen = new Pen(Brushes.Black, width))
				{
					path.AddLine(point1, point2);
					return path.IsOutlineVisible(p, pen);
				}
			}
		}

		public override bool Contains(PointF mouseAt)
		{
			if (base.Contains(mouseAt))
			{
				float paramOne = Width / 2;
				float paramTwo = Height / 2;
				float x1 = Location.X + paramOne;
				float y1 = Location.Y + paramTwo;
				bool isItOnTheLine = Math.Pow((mouseAt.X - x1) / paramOne,2) + Math.Pow((mouseAt.Y - y1) / paramTwo, 2) - BorderWidth <= 0;
				return isItOnTheLine;
			}

			else {
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
			}
		}
			/// <summary>
			/// Частта, визуализираща конкретния примитив.
			/// </summary>
			public override void DrawSelf(Graphics grfx)
			{
				Pen blackPen = new Pen(Color.FromArgb(Opacity, FillColor), BorderWidth);
				base.DrawSelf(grfx);
				base.RotateShape(grfx);
			PointF P1 = new PointF(Rectangle.X, Rectangle.Y);
			PointF P2 = new PointF(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Width);
			grfx.DrawLine(blackPen, P1, P2);
			//grfx.DrawLine(blackPen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.ResetTransform();


		}
		
	}
}
