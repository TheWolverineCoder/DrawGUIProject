﻿using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	/// </summary>
	[Serializable]
	public abstract class Shape
	{
		#region Constructors
		
		public Shape()
		{
		}
		
		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}

		public Shape(PointF one, PointF two, PointF three, PointF four, PointF five, PointF six)
        {
			this.One = one;
			this.Two = two;
			this.Three = three;
			this.Four = four;
			this.Five = five;
			this.Six = six;
			this.Location = one;
			
		}

		public Shape(PointF p1,PointF p2)
        {
			this.p1 = p1;
			this.p2 = p2;
        }

		
		
		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;
			this.BorderWidth = shape.BorderWidth;
			this.FillColor =  shape.FillColor;
		}
		#endregion

		#region Properties

		/// <summary>
		/// Обхващащ правоъгълник на елемента.
		/// </summary>
		
		private RectangleF rectangle;
		public PointF p1;
		public PointF p2;
		private PointF One;
		private PointF Two;
		private PointF Three;
		private PointF Four;
		private PointF Five;
		private PointF Six;

		public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}

		


		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}
		
		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}

		private float borderWidth;
		public virtual float BorderWidth
		{
			get { return borderWidth; }
			set { borderWidth = value; }
		}

		private string shapeName;
		public virtual string Name
		{
			get { return shapeName; }
			set { shapeName = value; }
		}


		private float shapeAngle;
		public virtual float ShapeAngle
		{
			get { return shapeAngle; }
			set { shapeAngle = value; }
		}
		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		/// <summary>
		/// Цвят на елемента.
		/// </summary>
		private Color fillColor;		
		public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}

		#endregion


		private Color strokeColor;
		public virtual Color StrokeColor
		{
			get { return strokeColor; }
			set { strokeColor = value; }
		}

		private int opacity;
		public virtual int Opacity
		{
			get { return opacity; }
			set { opacity = value; }
		}

		public virtual void MoveGroupedShape(float dx, float dy)
		{
			Location = new PointF(Location.X + dx, Location.Y + dy);

		}

		public virtual void ChangeGroupFillColor(Color color)
		{
			fillColor = color;
		}
		public virtual void ChangeGroupStrokeColor(Color color)
		{
			strokeColor = color;
		}

		public virtual void ChangeGroupOpacity(int opacityGroup)
		{
			opacity = opacityGroup;
		}

		public virtual void ChangeGroupStrokeWidth(float borderWidthShape)
		{
			borderWidth = borderWidthShape;
		}

		public virtual void ChangeGroupRotate(float angle)
		{
			ShapeAngle = angle;

		}

		public virtual void GroupResizeWidth(float width)
        {
			this.Width = width;
        }

		public virtual void GroupResizeHeight(float height)
		{
			this.Height = height;
		}
		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
			
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		}
		public virtual void RotateShape(Graphics grfx)
		{

			grfx.TranslateTransform(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
			grfx.RotateTransform(ShapeAngle);

			grfx.TranslateTransform(-(Rectangle.X + Rectangle.Width / 2), -(Rectangle.Y + Rectangle.Height / 2));

		}


	}
}
