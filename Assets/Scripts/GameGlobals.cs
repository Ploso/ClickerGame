using UnityEngine;
using System.Collections;

public class GameGlobals : MonoBehaviour {

	public static int rahe = 0;
	

	public static int GetRahe()
	{
		return rahe;
	}

	public static void SetRahe(int tempRahe)
	{
		rahe = tempRahe;
	}
}
