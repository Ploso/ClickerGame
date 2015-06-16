using UnityEngine;
using System.Collections;

public class MöröBehavior : MonoBehaviour {
	
	public int life = 3;
	private float approach;
	private int playerHp;
	private int ammo;

	void Start () {
		approach = 0;
		playerHp = GameGlobals.GetHp ();
	}
	

	void Update () {
		ammo = GameGlobals.GetAmmo ();

		approach++;

		if (approach <= 600) {
			transform.localScale += new Vector3 (0.01F, 0.01f, 0);
		} else {
			Destroy (gameObject);
		}
	
		if (life <= 0) {
			Destroy(gameObject);
		}
	}

	void OnMouseDown ()
	{
		if (ammo > 0) {
			life --;
		}
	}

	void OnDestroy()
	{
		playerHp = GameGlobals.GetHp ();
		playerHp = playerHp -10;
		GameGlobals.SetHp (playerHp);
	}
}
