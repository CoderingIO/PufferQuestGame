using UnityEngine;
using System.Collections;

public class myParallax : MonoBehaviour
{
	public Transform[] backgrounds;
	public float parallaxScale;
	public float parralaxReductionFactor;
	public float smoothing;


	private Transform cam;
	private Vector3 prevCamPos;

	void Awake()
	{
		cam = Camera.main.transform;
	}

	void Start ()
	{
		prevCamPos = cam.position;

	}
	void Update ()
	{
		float parallax = (prevCamPos.x - cam.position.x) * parallaxScale;

		for (int i = 0; i < backgrounds.Length; i ++)
		{
			float backgroundTargetPosX = backgrounds[i].position.x + parallax * (i * parralaxReductionFactor + 1);

			Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);
		
			backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
		}
		prevCamPos = cam.position;
	}
}
