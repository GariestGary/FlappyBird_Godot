using Godot;
using System;

public class Bird : RigidBody2D
{
	[Export] private float force = 10;
	
	public override void _Process(float delta)
	{
		if (Input.IsMouseButtonPressed((int) ButtonList.Left))
		{
			AddForce(Position, Vector2.Up * force);
		}
	}
}
