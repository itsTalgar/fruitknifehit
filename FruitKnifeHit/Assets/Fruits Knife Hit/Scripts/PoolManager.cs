using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour 
{	
	public GameObject canvas;
	public static PoolManager current;
	public int pooledAmount;

	public GameObject pooledObject_Apple,pooledObject_BlueGrapes, pooledObject_Cherry, pooledObject_Donut, pooledObject_FingerChips,
	pooledObject_MelonCut, pooledObject_MelonHalf, pooledObject_Orange, pooledObject_OrangeHalf, pooledObject_PearGreen, pooledObject_PineappleLong,
	pooledObject_PineappleSmall, pooledObject_Pomegrate, pooledObject_Pumpkin, pooledObject_PurpleGrapes, pooledObject_RedGrapes, pooledObject_Strawberry,
	pooledObject_StrawberryCut, pooledObject_Tomato, pooledObject_WaterMelon, pooledObject_WaterMelonHalf, pooledObject_YellowPear;

	List<GameObject> pooledObjects_Apple,pooledObjects_BlueGrapes, pooledObjects_Cherry, pooledObjects_Donut, pooledObjects_FingerChips,
	pooledObjects_MelonCut, pooledObjects_MelonHalf, pooledObjects_Orange, pooledObjects_OrangeHalf, pooledObjects_PearGreen, pooledObjects_PineappleLong,
	pooledObjects_PineappleSmall, pooledObjects_Pomegrate, pooledObjects_Pumpkin, pooledObjects_PurpleGrapes, pooledObjects_RedGrapes, pooledObjects_Strawberry,
	pooledObjects_StrawberryCut, pooledObjects_Tomato, pooledObjects_WaterMelon, pooledObjects_WaterMelonHalf, pooledObjects_YellowPear;

	public bool willGrow;

	void Awake()
	{
		current = this;
	}

	//=========================================================================================
	void Start () 
	{
		pooledObjects_Apple = new List<GameObject> ();
		pooledObjects_BlueGrapes = new List<GameObject> ();
		pooledObjects_Cherry = new List<GameObject> ();
		pooledObjects_Donut = new List<GameObject> ();
		pooledObjects_FingerChips = new List<GameObject> ();
		pooledObjects_MelonCut = new List<GameObject> ();
		pooledObjects_MelonHalf = new List<GameObject> ();
		pooledObjects_Orange = new List<GameObject> ();
		pooledObjects_OrangeHalf = new List<GameObject> ();
		pooledObjects_PearGreen = new List<GameObject> ();
		pooledObjects_PineappleLong = new List<GameObject> ();
		pooledObjects_PineappleSmall = new List<GameObject> ();
		pooledObjects_Pomegrate = new List<GameObject> ();
		pooledObjects_Pumpkin = new List<GameObject> ();
		pooledObjects_PurpleGrapes = new List<GameObject> ();
		pooledObjects_RedGrapes = new List<GameObject> ();
		pooledObjects_Strawberry = new List<GameObject> ();
		pooledObjects_StrawberryCut = new List<GameObject> ();
		pooledObjects_Tomato = new List<GameObject> ();
		pooledObjects_WaterMelon = new List<GameObject> ();
		pooledObjects_WaterMelonHalf = new List<GameObject> ();
		pooledObjects_YellowPear = new List<GameObject> ();

		for (int i = 0; i < pooledAmount; i++) 
		{
			GameObject obj1 = (GameObject)Instantiate (pooledObject_Apple);
			obj1.SetActive (false);
			pooledObjects_Apple.Add (obj1);

			GameObject obj2 = (GameObject)Instantiate (pooledObject_BlueGrapes);
			obj2.SetActive (false);
			pooledObjects_BlueGrapes.Add (obj2);

			GameObject obj3 = (GameObject)Instantiate (pooledObject_Cherry);
			obj3.SetActive (false);
			pooledObjects_Cherry.Add (obj3);

			GameObject obj4 = (GameObject)Instantiate (pooledObject_Donut);
			obj4.SetActive (false);
			pooledObjects_Donut.Add (obj4);

			GameObject obj5 = (GameObject)Instantiate (pooledObject_FingerChips);
			obj5.SetActive (false);
			pooledObjects_FingerChips.Add (obj5);

			GameObject obj6 = (GameObject)Instantiate (pooledObject_MelonCut);
			obj6.SetActive (false);
			pooledObjects_MelonCut.Add (obj6);

			GameObject obj7 = (GameObject)Instantiate (pooledObject_MelonHalf);
			obj7.SetActive (false);
			pooledObjects_MelonHalf.Add (obj7);

			GameObject obj8 = (GameObject)Instantiate (pooledObject_Orange);
			obj8.SetActive (false);
			pooledObjects_Orange.Add (obj8);

			GameObject obj9 = (GameObject)Instantiate (pooledObject_OrangeHalf);
			obj9.SetActive (false);
			pooledObjects_OrangeHalf.Add (obj9);

			GameObject obj10 = (GameObject)Instantiate (pooledObject_PearGreen);
			obj10.SetActive (false);
			pooledObjects_PearGreen.Add (obj10);

			GameObject obj11 = (GameObject)Instantiate (pooledObject_PineappleLong);
			obj11.SetActive (false);
			pooledObjects_PineappleLong.Add (obj11);

			GameObject obj12 = (GameObject)Instantiate (pooledObject_PineappleSmall);
			obj12.SetActive (false);
			pooledObjects_PineappleSmall.Add (obj12);

			GameObject obj13 = (GameObject)Instantiate ( pooledObject_Pomegrate);
			obj13.SetActive (false);
			pooledObjects_Pomegrate.Add (obj13);

			GameObject obj14 = (GameObject)Instantiate (pooledObject_Pumpkin);
			obj14.SetActive (false);
			pooledObjects_Pumpkin.Add (obj14);

			GameObject obj15 = (GameObject)Instantiate (pooledObject_PurpleGrapes);
			obj15.SetActive (false);
			pooledObjects_PurpleGrapes.Add (obj15);		

			GameObject obj16 = (GameObject)Instantiate (pooledObject_YellowPear);
			obj16.SetActive (false);
			pooledObjects_YellowPear.Add (obj16);

			GameObject obj17 = (GameObject)Instantiate ( pooledObject_RedGrapes);
			obj17.SetActive (false);
			pooledObjects_RedGrapes.Add (obj17);

			GameObject obj18 = (GameObject)Instantiate (pooledObject_Strawberry);
			obj18.SetActive (false);
			pooledObjects_Strawberry.Add (obj18);

			GameObject obj19 = (GameObject)Instantiate (pooledObject_StrawberryCut);
			obj19.SetActive (false);
			pooledObjects_StrawberryCut.Add (obj19);

			GameObject obj20 = (GameObject)Instantiate ( pooledObject_Tomato);
			obj20.SetActive (false);
			pooledObjects_Tomato.Add (obj20);

			GameObject obj21 = (GameObject)Instantiate (pooledObject_WaterMelon);
			obj21.SetActive (false);
			pooledObjects_WaterMelon.Add (obj21);

			GameObject obj22 = (GameObject)Instantiate (pooledObject_WaterMelonHalf);
			obj22.SetActive (false);
			pooledObjects_WaterMelonHalf.Add (obj22);
		}	
	}	

	//=========================================================================================

	public GameObject GetPooledObject_Apple()
	{
		for (int i = 0; i < pooledObjects_Apple.Count; i++) 
		{
			if (!pooledObjects_Apple [i].activeInHierarchy) 
			{
				return pooledObjects_Apple [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Apple);
			pooledObjects_Apple.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_BlueGrapes()
	{
		for (int i = 0; i < pooledObjects_BlueGrapes.Count; i++) 
		{
			if (!pooledObjects_BlueGrapes [i].activeInHierarchy) 
			{
				return pooledObjects_BlueGrapes [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_BlueGrapes);
			pooledObjects_BlueGrapes.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Cherry()
	{
		for (int i = 0; i < pooledObjects_Cherry.Count; i++) 
		{
			if (!pooledObjects_Cherry [i].activeInHierarchy) 
			{
				return pooledObjects_Cherry [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Cherry);
			pooledObjects_Cherry.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Donut()
	{
		for (int i = 0; i < pooledObjects_Donut.Count; i++) 
		{
			if (!pooledObjects_Donut [i].activeInHierarchy) 
			{
				return pooledObjects_Donut [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Donut);
			pooledObjects_Donut.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_FingerChips()
	{
		for (int i = 0; i < pooledObjects_FingerChips.Count; i++) 
		{
			if (!pooledObjects_FingerChips [i].activeInHierarchy) 
			{
				return pooledObjects_FingerChips [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_FingerChips);
			pooledObjects_FingerChips.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_MelonCut()
	{
		for (int i = 0; i < pooledObjects_MelonCut.Count; i++) 
		{
			if (!pooledObjects_MelonCut [i].activeInHierarchy) 
			{
				return pooledObjects_MelonCut [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_MelonCut);
			pooledObjects_MelonCut.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_MelonHalf()
	{
		for (int i = 0; i < pooledObjects_MelonHalf.Count; i++) 
		{
			if (!pooledObjects_MelonHalf [i].activeInHierarchy) 
			{
				return pooledObjects_MelonHalf [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_MelonHalf);
			pooledObjects_MelonHalf.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Orange()
	{
		for (int i = 0; i < pooledObjects_Orange.Count; i++) 
		{
			if (!pooledObjects_Orange [i].activeInHierarchy) 
			{
				return pooledObjects_Orange [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Orange);
			pooledObjects_Orange.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_OrangeHalf()
	{
		for (int i = 0; i < pooledObjects_OrangeHalf.Count; i++) 
		{
			if (!pooledObjects_OrangeHalf [i].activeInHierarchy) 
			{
				return pooledObjects_OrangeHalf [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_OrangeHalf);
			pooledObjects_OrangeHalf.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_PearGreen()
	{
		for (int i = 0; i < pooledObjects_PearGreen.Count; i++) 
		{
			if (!pooledObjects_PearGreen [i].activeInHierarchy) 
			{
				return pooledObjects_PearGreen [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_PearGreen);
			pooledObjects_PearGreen.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_PineappleLong()
	{
		for (int i = 0; i < pooledObjects_PineappleLong.Count; i++) 
		{
			if (!pooledObjects_PineappleLong [i].activeInHierarchy) 
			{
				return pooledObjects_PineappleLong [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_PineappleLong);
			pooledObjects_PineappleLong.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_PineappleSmall()
	{
		for (int i = 0; i < pooledObjects_PineappleSmall.Count; i++) 
		{
			if (!pooledObjects_PineappleSmall [i].activeInHierarchy) 
			{
				return pooledObjects_PineappleSmall [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_PineappleSmall);
			pooledObjects_PineappleSmall.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Pomegrate()
	{
		for (int i = 0; i < pooledObjects_Pomegrate.Count; i++) 
		{
			if (!pooledObjects_Pomegrate [i].activeInHierarchy) 
			{
				return pooledObjects_Pomegrate [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Pomegrate);
			pooledObjects_Pomegrate.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Pumpkin()
	{
		for (int i = 0; i < pooledObjects_Pumpkin.Count; i++) 
		{
			if (!pooledObjects_Pumpkin [i].activeInHierarchy) 
			{
				return pooledObjects_Pumpkin [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Pumpkin);
			pooledObjects_Pumpkin.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_PurpleGrapes()
	{
		for (int i = 0; i < pooledObjects_PurpleGrapes.Count; i++) 
		{
			if (!pooledObjects_PurpleGrapes [i].activeInHierarchy) 
			{
				return pooledObjects_PurpleGrapes [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_PurpleGrapes);
			pooledObjects_PurpleGrapes.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_RedGrapes()
	{
		for (int i = 0; i < pooledObjects_RedGrapes.Count; i++) 
		{
			if (!pooledObjects_RedGrapes [i].activeInHierarchy) 
			{
				return pooledObjects_RedGrapes [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_RedGrapes);
			pooledObjects_RedGrapes.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Strawberry()
	{
		for (int i = 0; i < pooledObjects_Strawberry.Count; i++) 
		{
			if (!pooledObjects_Strawberry [i].activeInHierarchy) 
			{
				return pooledObjects_Strawberry [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Strawberry);
			pooledObjects_Strawberry.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_StrawberryCut()
	{
		for (int i = 0; i < pooledObjects_StrawberryCut.Count; i++) 
		{
			if (!pooledObjects_StrawberryCut [i].activeInHierarchy) 
			{
				return pooledObjects_StrawberryCut [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_StrawberryCut);
			pooledObjects_StrawberryCut.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_Tomato()
	{
		for (int i = 0; i < pooledObjects_Tomato.Count; i++) 
		{
			if (!pooledObjects_Tomato [i].activeInHierarchy) 
			{
				return pooledObjects_Tomato [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_Tomato);
			pooledObjects_Tomato.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_WaterMelon()
	{
		for (int i = 0; i < pooledObjects_WaterMelon.Count; i++) 
		{
			if (!pooledObjects_WaterMelon [i].activeInHierarchy) 
			{
				return pooledObjects_WaterMelon [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_WaterMelon);
			pooledObjects_WaterMelon.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_WaterMelonHalf()
	{
		for (int i = 0; i < pooledObjects_WaterMelonHalf.Count; i++) 
		{
			if (!pooledObjects_WaterMelonHalf [i].activeInHierarchy) 
			{
				return pooledObjects_WaterMelonHalf [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_WaterMelonHalf);
			pooledObjects_WaterMelonHalf.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
	public GameObject GetPooledObject_YellowPear()
	{
		for (int i = 0; i < pooledObjects_YellowPear.Count; i++) 
		{
			if (!pooledObjects_YellowPear [i].activeInHierarchy) 
			{
				return pooledObjects_YellowPear [i];
			}
		}

		if (willGrow) 
		{
			GameObject obj = (GameObject)Instantiate (pooledObject_YellowPear);
			pooledObjects_YellowPear.Add (obj);
			return obj;
		}

		return null;
	}
	//----------------------------------------------------------------------------------------
}