using UnityEngine;
using System.Collections;

public class JellySpawner : MonoBehaviour {

	public float startWait;
	public float spawnWait;
	public float jellyCount;
	public GameObject jelly;
	public float jellyWait;
	public Vector2 spawnValues;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < jellyCount; i++) 
			{

				Vector2 spawnPosition = new Vector2 (spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
				Quaternion spawnRotation = Quaternion.Euler (0f, 0f, 90f);
				Instantiate (jelly, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
				
			}
			
			yield return new WaitForSeconds (jellyWait);
		}
	}
	void Update()
	{

	}
}
