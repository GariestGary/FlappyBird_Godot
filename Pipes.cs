using Godot;
using System;

public class Pipes : Node2D
{
	[Export] private float speed = 10;

	public override void _Process(float delta)
	{
		Translate(Vector2.Left * speed * delta);
	}
}
