using UnityEngine;
using System.Collections;

public class FlashingLightSpecial : MonoBehaviour {

	private Transform myTransform;

	private static bool flashingLightsEnabled = true;
	private static LightmapData[] lightmap_data;

	public Transform movingObject;
	public Light Light;

	void OnEnable()
	{
		Messenger.AddListener("enable flashing lights", enableFlashingLights);
	}
	void OnDisable()
	{
		Messenger.RemoveListener("enable flashing lights", enableFlashingLights);
	}
	// Use this for initialization
	void Start () {
		myTransform = transform;

		lightmap_data = LightmapSettings.lightmaps;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Debug.Log ("Distance to flashing lights " + Vector3.Distance (movingObject.position, myTransform.position));
		if (flashingLightsEnabled){
			if (Vector3.Distance (movingObject.position, myTransform.position) <= 13f) {
				lightmap_data = LightmapSettings.lightmaps;
				LightmapSettings.lightmaps = new LightmapData[]{ };

				float RandomNumber = Random.value;
				Light.enabled = false;

				if (RandomNumber < 0.4) {
					Light.enabled = true;
				} else {
					Light.enabled = false;
				}
			} else {
				LightmapSettings.lightmaps = lightmap_data;
			}
		}
	}

	public void enableFlashingLights(){
		flashingLightsEnabled = true;
	}
}
