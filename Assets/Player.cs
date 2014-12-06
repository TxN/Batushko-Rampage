using UnityEngine;
using System.Collections;

public class Player : Character {

	public bool canControl = true;

	public GameObject mainWeapon;

	void Update () {


		if (Input.GetMouseButton (0)) {
			mainWeapon.particleSystem.renderer.sortingOrder = 10;
			mainWeapon.transform.rotation = Quaternion.Slerp(mainWeapon.transform.rotation, Quaternion.LookRotation (new Vector3 (sightDir.x, sightDir.y, 0)),.1f);
			//mainWeapon.SetActive (true);
			mainWeapon.particleSystem.Play ();
		} else {
			//mainWeapon.SetActive(false);
			//mainWeapon.particleSystem.Stop ();
		}

		if (Input.GetKey ("s")) {
			MoveTo (1);
		}

		if (Input.GetKey ("a")) {
			MoveTo (2);
		}

		if (Input.GetKey ("w")) {
			MoveTo (3);
		}

		if (Input.GetKey ("d")) {
			MoveTo (4);
		}

	}


}
