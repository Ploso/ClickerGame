using UnityEngine;
using System.Collections;

public class GameGlobals : MonoBehaviour {

	public static int rahe = 0;
	public static int ayyyluminium = 0;

	public static float autoRahe = 1f;
	public static int clickRahe = 1;
	

	public static int GetRahe()
	{
		return rahe;
	}

	public static void SetRahe(int tempRahe)
	{
		rahe = tempRahe;
	}

	public static float GetAuto()
	{
		return autoRahe;
	}
	
	public static void SetAuto(float tempAuto)
	{
		autoRahe = tempAuto;
	}

	public static int GetClick()
	{
		return clickRahe;
	}

	public static void SetClick(int tempClick)
	{
		clickRahe = tempClick;
	}

	public static int GetAyy()
	{
		return ayyyluminium;
	}
	
	public static void SetAyy(int tempAyy)
	{
		ayyyluminium = tempAyy;
	}



}
