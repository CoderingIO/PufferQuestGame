using UnityEngine;
using System.Collections;

public class fightingSpawner : MonoBehaviour {
	
	public float startWait;
	public float spawnWait;
	public float fishCount;
	public GameObject fish;
	public float fishyWait;
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
			for (int i = 0; i < fishCount; i++) 
			{
				
				Vector2 spawnPosition = new Vector2 (spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y));
				Quaternion spawnRotation = Quaternion.Euler (0f, 0f, 20f);
				Instantiate (fish, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
				
			}
			
			yield return new WaitForSeconds (fishyWait);
		}
	}
	void Update()
	{
		
	}
}

