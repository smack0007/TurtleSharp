using System;
using Snowball.Graphics;
using Snowball;

namespace TurtleSharp
{
	public class TurtleGraphicsRenderer : ITurtleGraphics
	{
		GraphicsDevice graphicsDevice;
		Renderer renderer;

		Vector2 position;

		public TurtleGraphicsRenderer(GraphicsDevice graphicsDevice)
		{
			if (graphicsDevice == null)
				throw new ArgumentNullException("graphicsDevice");

			this.graphicsDevice = graphicsDevice;
			this.renderer = new Renderer(this.graphicsDevice);
		}

		public void Begin(Vector2 position)
		{
			this.position = position;
			this.renderer.Begin();
		}

		public void Forward(int pixels)
		{
			Vector2 newPosition = new Vector2(this.position.X, this.position.Y - pixels);

			this.renderer.DrawLine(this.position, newPosition, Color.Red);

			this.position = newPosition;
		}

		public void End()
		{
			this.renderer.End();
		}
	}
}
