using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private int playerHp;
	private int ammo;
	private int interval;
	private int maxInterval;
	private int minInterval;
	private int mapTimer;
	private int p_mapLength;

	private int level;

	public Texture2D cursorTexture;
	public Texture2D cursorClickTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public GameObject [] enemies;

	private int shield;

	void Start () {

		shield = GameGlobals.GetMaxShield ();
		GameGlobals.SetShield (shield);

		interval = 0;
		maxInterval = 60;
		minInterval = 20;
		mapTimer = 0;
		p_mapLength = GameGlobals.GetMapLength();
		level = GameGlobals.GetCurrentLevel();

		Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);


	}
	

	void Update () {

		interval++;
		mapTimer++;

		playerHp = GameGlobals.GetHp();
		ammo = GameGlobals.GetAmmo ();

		if (playerHp <= 0) {
			Application.LoadLevel (0);
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
				maxInterval = maxInterval -level;
			}
		}

		if (mapTimer >= p_mapLength) {

			int prizeRng;
			int prizeAmount;
			int temp;
			prizeAmount = level;

			prizeRng = Random.Range (1, 5);
			if (prizeRng == 1){
				temp = GameGlobals.GetAyy();
				temp = temp + prizeAmount;
				GameGlobals.SetAyy(temp);
			} else if (prizeRng == 2){
				temp = GameGlobals.GetTitayyynium();
				temp = temp + prizeAmount;
				GameGlobals.SetTitayyynium(temp);
			} else if (prizeRng == 3){
				temp = GameGlobals.GetAyyyntimatter();
				temp = temp + prizeAmount;
				GameGlobals.SetAyyyntimatter(temp);
			} else if (prizeRng == 4){
				temp = GameGlobals.GetFiftAyyylement();
				temp = temp + prizeAmount;
				GameGlobals.SetFiftAyyylement(temp);
			} else if (prizeRng == 5){
				temp = GameGlobals.GetRahe();
				temp = temp + prizeAmount * 100;
				GameGlobals.SetRahe(temp);
		}

			level++;
			p_mapLength = p_mapLength + level;
			GameGlobals.SetCurrentLevel(level);
			GameGlobals.SetMapLength(p_mapLength);
			Application.LoadLevel(1);

		}
	}

	void OnMouseUp()
	{
		Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
	}




}
