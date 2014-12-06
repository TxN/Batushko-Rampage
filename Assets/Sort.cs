using UnityEngine;
using System.Collections;

public class Sort : MonoBehaviour {

	// Use this for initialization
	void Start () {
		particleSystem.renderer.sortingLayerName = "Foreground";
		particleSystem.renderer.sortingOrder = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
