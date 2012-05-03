using System;
using Snowball.Graphics;
using Snowball;

namespace TurtleSharp
{
	public class TurtleGraphicsRenderer : ITurtleGraphics
	{
		GraphicsDevice graphicsDevice;
		Renderer renderer;

		Vector2 homePosition;
		Vector2 position;
		float rotation;

		public TurtleGraphicsRenderer(GraphicsDevice graphicsDevice)
		{
			if (graphicsDevice == null)
				throw new ArgumentNullException("graphicsDevice");

			this.graphicsDevice = graphicsDevice;
			this.renderer = new Renderer(this.graphicsDevice);
		}

		public void Begin(Vector2 position)
		{
			this.homePosition = position;
			this.position = position;
			this.rotation = 0.0f;

			this.renderer.Begin();
		}

		public void Home()
		{
			this.position = homePosition;
		}

		public void Forward(int units)
		{
			Vector2 newPosition = new Vector2(this.position.X, this.position.Y - units);

			Vector2.RotateAboutOrigin(ref newPosition, this.position, MathHelper.ToRadians(this.rotation));

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

		public void End()
		{
			this.renderer.End();
		}
	}
}
