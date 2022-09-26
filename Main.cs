using Godot;
using System;

public class Main : Node2D
{
	[Export] private float pipesHeightRange = 50;

	private PackedScene pipes;
	private Position2D spawnPoint;
	private Position2D despawnPoint;

	public override void _Ready()
	{
		spawnPoint = GetNode<Position2D>("Pipes_Spawn_Point");
		pipes = ResourceLoader.Load<PackedScene>("res://Pipes.tscn");
	}

	private void SpawnPipe()
	{
		GD.Print("spawn");
		var spawnedPipes = pipes.Instance<Node2D>();
		GetNode<Node2D>("Pipes").AddChild(spawnedPipes);
		//spawnedPipes.Position = new Vector2(spawnPoint.Position.x,
		//	spawnPoint.Position.y + (float)GD.RandRange(-pipesHeightRange, pipesHeightRange));
		
	}
}
