using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private int playerHp;
	private int ammo;
	private int interval;
	private int maxInterval;
	private int minInterval;

	public GameObject [] enemies;

	void Start () {
		interval = 0;
		maxInterval = 60;
		minInterval = 20;
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

		if (interval >= maxInterval)
		{
			Instantiate(enemies [Random.Range (0, enemies.GetLength (0))], new Vector3(Random.Range(-7, 7),Random.Range(-1.5f,4), 0), Quaternion.identity);
			interval = 0;
			if (maxInterval > minInterval){
				maxInterval = maxInterval -1;
			}
		}
	}
	


}
