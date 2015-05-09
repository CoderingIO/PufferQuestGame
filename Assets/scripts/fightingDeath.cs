using UnityEngine;
using System.Collections;

public class fightingDeath : MonoBehaviour 
{
	public Animator death;
	public int hp = 2;
	public Transform target;
	private float dir;
	private bool isDead;


	void Start ()
	{
		target = GameObject.Find("pufferFish").transform;

	}
	        

		void OnTriggerEnter2D(Collider2D other)
			
			
		{

			if(other.gameObject.tag == "quill")
				
				
			{
				
			hp--;
				
			}
		}

	void Update ()
	{
		if (hp == 0 && isDead == false)
		{
			death.SetTrigger("Dying");
			DestroyObject(gameObject, 5);
			currentScore.Score += 1000;
			isDead = true;
		}

		dir = target.transform.position.x - transform.position.x;

		if (dir <= 0)
			transform.localScale = new Vector3(1f, 1f, 1f);
		else
			transform.localScale = new Vector3(-1f, 1f, 1f);


	}

	public void OnMoveFinished()
	{
		StartCoroutine(waitAndRestart());
	}

	IEnumerator waitAndRestart()
	{
		yield return new WaitForSeconds(1f);
		GetComponent<iTweenEvent>().Play();
	}

}
	
	

