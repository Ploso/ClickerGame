using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private int playerHp;
	private int ammo;
	private int interval;

	public GameObject enemy1;

	void Start () {
		interval = 0;
	}
	

	void Update () {
		interval++;

		playerHp = GameGlobals.GetHp();
		ammo = GameGlobals.GetAmmo ();

		if (playerHp <= 0) {
			Application.LoadLevel (2);
		}
		if (Input.GetKeyDown(KeyCode.Mouse0) && ammo > 0){
			ammo--;
			GameGlobals.SetAmmo(ammo);
		}

		if (interval >=60)
		{
			Instantiate(enemy1, new Vector3(Random.Range(-2, 10),Random.Range(-2,10), 0), Quaternion.identity);
			interval = 0;
		}
	}


}
