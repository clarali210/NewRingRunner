using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

	public static GameObject[] obstacles;
	public static int numSpawned = 0;
	public static int numToSpawn = 1;

	
	// Use this for initialization
	void Start () {
		obstacles = Resources.LoadAll<GameObject>("Prefabs");
	}

	void SpawnObstacle() 
	{    
		//spawns item in array position between 0 and 100
		int obstacle = Random.Range (0, 100);
		
		
		GameObject myObj = Instantiate (obstacles [obstacle]) as GameObject;
		
		numSpawned++;
		
		myObj.transform.position = transform.position;

	}

	// Update is called once per frame
	void Update () {
		if (numToSpawn > numSpawned) 
		{
			int x = Random.Range ();
			//where your instantiated object spawns from
			transform.position = new Vector3(2, 3, 0);
			SpawnObstacle ();
		}
	}
}
