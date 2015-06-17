using UnityEngine;
using System.Collections;

public class GameGlobals : MonoBehaviour {

	public static int rahe = 0;
	public static int ayyyluminium = 0;
	public static int titayyynium = 0;
	public static int ayyyntimatter = 0;
	public static int fiftAyyylement = 0;

	public static int ammo = 1000;
	public static int hp = 100;
	public static int shield = 0;
	public static int maxShield = 0;

	public static float autoRahe = 1f;
	public static int clickRahe = 1;
	public static int rahePerSecond = 0;

	public static int increasePrize = 10;
	public static int rahePrize = 1;
	public static int clickPrize = 16;
	public static int autoPrice = 20;
	public static int rootPrice = 1;

	public static int currentLevel = 1;
	public static int mapLength = 600;

	public static bool autorahe1buy = true;
	public static bool shieldUnBought = true;

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
	
	public static int GetRahePerSecond()
	{
		return rahePerSecond;
	}
	
	public static void SetRahePerSecond(int tempRPS)
	{
		rahePerSecond = tempRPS;
	}

	public static int GetRahePrize()
	{
		return rahePrize;
	}
	
	public static void SetRahePrize(int tempRP)
	{
		rahePrize = tempRP;
	}

	public static int GetClickPrize()
	{
		return clickPrize;
	}
	
	public static void SetClickPrize(int tempCP)
	{
		clickPrize = tempCP;
	}

	public static int GetAutoPrice()
	{
		return autoPrice;
	}
	
	public static void SetAutoPrice(int tempAP)
	{
		autoPrice = tempAP;
	}

	public static int GetRootPrice()
	{
		return rootPrice;
	}
	
	public static void SetRootPrice(int tempRP)
	{
		rootPrice = tempRP;
	}
	
	public static bool GetAutoRahe1buy()
	{
		return autorahe1buy;
	}
	
	public static void SetAutoRahe1buy(bool AR1B)
	{
		autorahe1buy = AR1B;
	}

	public static int GetCurrentLevel()
	{
		return currentLevel;
	}
	
	public static void SetCurrentLevel(int tempLevel)
	{
		currentLevel = tempLevel;
	}

	public static int GetMapLength()
	{
		return mapLength;
	}
	
	public static void SetMapLength(int tempLength)
	{
		mapLength = tempLength;
	}

	public static int GetShield()
	{
		return shield;
	}
	
	public static void SetShield(int tempShield)
	{
		shield = tempShield;
	}

	public static int GetMaxShield()
	{
		return maxShield;
	}
	
	public static void SetMaxShield(int tempShield)
	{
		maxShield = tempShield;
	}
	
	public static bool GetShieldBought()
	{
		return shieldUnBought;
	}
	
	public static void SetShieldBought(bool ssb)
	{
		shieldUnBought = ssb;
	}
	
}
