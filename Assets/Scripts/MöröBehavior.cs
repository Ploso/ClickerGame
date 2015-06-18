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
	public int bounty;
	private int p_shield;

	private int p_plDmg;

	public SpriteRenderer sprite;
	private int sortingOrder;

	public Texture2D cursorTexture;
	public Texture2D cursorTexture2;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	void Start () {
		dmg = true;
		approach = 0;
		sprite = GetComponent<SpriteRenderer> ();
		sortingOrder = 0;
		p_shield = GameGlobals.GetShield ();
		p_plDmg = GameGlobals.GetPlayerDamage ();

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
			bounty = GameGlobals.GetRahe();
			bounty++;
			GameGlobals.SetRahe(bounty);
			dmg = false;
			Destroy(gameObject);

		}
	}

	void OnMouseDown ()
	{
		if (ammo > 0) {
			life = life - p_plDmg;
		}
	}

	void OnMouseEnter()
	{
		Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
	}

	void OnMouseExit()
	{
		Cursor.SetCursor (cursorTexture2, hotSpot, cursorMode);
	}

	void OnDestroy()
	{
		if (dmg == true && Player.mapTimer < Player.p_mapLength) {
			if (p_shield >= 0){
				p_shield = GameGlobals.GetShield();
				p_shield = p_shield -enemyDmg;
				GameGlobals.SetShield(p_shield);
			} else {
				playerHp = GameGlobals.GetHp ();
				playerHp = playerHp - enemyDmg;
				GameGlobals.SetHp (playerHp);
			}
		}
		dmg = true;
		Cursor.SetCursor (cursorTexture2, hotSpot, cursorMode);
	}
}
