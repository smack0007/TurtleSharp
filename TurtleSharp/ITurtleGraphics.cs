using System;

namespace TurtleSharp
{
	public interface ITurtleGraphics
	{
		void Home();

		void Forward(int units);

		void Left(int degrees);

		void Right(int degrees);

		void PenUp();

		void PenDown();

		void Push();

		void Pop();
	}
}
