﻿using UnityEngine;
using System.Collections;

public class GameGlobals : MonoBehaviour {

	public static int rahe = 0;
	public static int ayyyluminium = 0;
	public static int titayyynium = 0;
	public static int ayyyntimatter = 0;
	public static int fiftAyyylement = 0;
	public static int ammo = 10;
	public static int hp = 100;

	public static float autoRahe = 1f;
	public static int clickRahe = 1;

	public static int increasePrize = 10;
	

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

	public static int GetIncreasePrize()
	{
		return increasePrize;
	}
	
	public static void SetIncreasePrize(int tempIp)
	{
		increasePrize = tempIp;
	}

	public static int GetTitayyynium()
	{
		return titayyynium;
	}
	
	public static void SetTitayyynium(int tempTita)
	{
		titayyynium = tempTita;
	}

	public static int GetAyyyntimatter()
	{
		return ayyyntimatter;
	}
	
	public static void SetAyyyntimatter(int tempMatter)
	{
		ayyyntimatter = tempMatter;
	}

	public static int GetFiftAyyylement()
	{
		return fiftAyyylement;
	}
	
	public static void SetFiftAyyylement(int tempAyyylement)
	{
		fiftAyyylement = tempAyyylement;
	}

	public static int GetAmmo()
	{
		return ammo;
	}
	
	public static void SetAmmo(int tempAmmo)
	{
		ammo = tempAmmo;
	}

	public static int GetHp()
	{
		return hp;
	}
	
	public static void SetHp(int tempHp)
	{
		hp = tempHp;
	}
	


}
