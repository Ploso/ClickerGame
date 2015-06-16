using UnityEngine;
using System.Collections;

public class MöröBehavior : MonoBehaviour {
	
	public int life = 3;
	private float approach;
	private int playerHp;
	private int ammo;
	private bool dmg;
	public int enemyDmg;
	public int hit;
	public float speed;

	public SpriteRenderer sprite;
	private int sortingOrder;

	void Start () {
		dmg = true;
		approach = 0;
		sprite = GetComponent<SpriteRenderer> ();
		sortingOrder = 0;

		playerHp = GameGlobals.GetHp ();
		if (gameObject.name.Contains ("Moro2"))
		{
			transform.position = new Vector3(transform.position.x, -1.3f, transform.position.z);
		}
	}
	

	void Update () {
		ammo = GameGlobals.GetAmmo ();
		sprite.sortingOrder = sortingOrder;

		approach++;
		sortingOrder++;

		if (approach <= hit) {
			transform.localScale += new Vector3 (speed, speed, 0);
		} else {
			Destroy (gameObject);
		}
	
		if (life <= 0) {
			dmg = false;
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
		if (dmg == true) {
			playerHp = GameGlobals.GetHp ();
			playerHp = playerHp - enemyDmg;
			GameGlobals.SetHp (playerHp);
		}
		dmg = true;
	}
}
