using UnityEngine;
using System.Collections.Generic;

public class Path : MonoBehaviour 
{
	//public List<Vector3> waypoints = new List<Vector3>();
	public List<Transform> waypoints = new List<Transform>();
	public int next = 0;
	public bool looped = true;

	public void CreatePath()
	{
		/*
		for(int i = 0; i < 10; i++)
		{
			waypoints.Add (Random.insideUnitSphere * 150f);
		}
		*/

		foreach(Transform waypoint in waypoints)
		{
			waypoints.Add(waypoint);
		}

	}
	
	public Vector3 NextWaypoint()
	{
		return waypoints[next].position;
	}
	
	public bool IsLastCheckpoint()
	{
		return(next == waypoints.Count-1);
	}
	
	public void AdvanceWaypoint()
	{
		if(looped)
		{
			next = (next + 1) % waypoints.Count;
		}
		else
		{
			if(!IsLastCheckpoint())
			{
				next = next + 1;
			}
		}
	}
}
