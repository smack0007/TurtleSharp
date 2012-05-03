using System;
using Snowball.Graphics;
using Snowball;
using System.Collections.Generic;

namespace TurtleSharp
{
	public class TurtleGraphicsRenderer : ITurtleGraphics
	{
		GraphicsDevice graphicsDevice;
		Renderer renderer;

		Vector2 homePosition;
		Stack<Vector2> positionStack;
		Vector2 position;
		float rotation;
		bool isPenDown;

		public TurtleGraphicsRenderer(GraphicsDevice graphicsDevice)
		{
			if (graphicsDevice == null)
				throw new ArgumentNullException("graphicsDevice");

			this.graphicsDevice = graphicsDevice;
			this.renderer = new Renderer(this.graphicsDevice);

			this.positionStack = new Stack<Vector2>();
		}

		public void Begin(Vector2 position)
		{
			this.homePosition = position;
			this.positionStack.Clear();
			this.position = position;
			this.rotation = 0.0f;
			this.isPenDown = true;

			this.renderer.Begin();
		}

		public void Home()
		{
			this.position = homePosition;
			this.rotation = 0.0f;
		}

		public void Forward(int units)
		{
			Vector2 newPosition = new Vector2(this.position.X, this.position.Y - units);

			Vector2.RotateAboutOrigin(ref newPosition, this.position, MathHelper.ToRadians(this.rotation));

			if (this.isPenDown)
				this.renderer.DrawLine(this.position, newPosition, Color.Red);
			
			this.position = newPosition;
		}

		public void Left(int degrees)
		{
			this.rotation -= degrees;

			if (this.rotation < 0.0f)
				this.rotation += 360.0f;
		}

		public void Right(int degrees)
		{
			this.rotation += degrees;

			if (this.rotation >= 360.0f)
				this.rotation -= 360.0f;
		}

		public void PenUp()
		{
			this.isPenDown = false;
		}

		public void PenDown()
		{
			this.isPenDown = true;
		}

		public void Push()
		{
			this.positionStack.Push(this.position);
		}

		public void Pop()
		{
			this.position = this.positionStack.Pop();
		}

		public void End()
		{
			this.renderer.End();
		}
	}
}
