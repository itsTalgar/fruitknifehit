using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour 
{
	public Text tapAnywhereToHitTag, newRecordTag;
	private PathType pathType;
	private LoopType loopType;
	public ParticleSystem splash,penParticle, newRecordParticle;
	public Text scoreText, bestScoreText, bestScoreText_GameOver, scoreText_GameOver, gameOverText;
	private Ease easeType;
	public GameObject pointD, pointF, pointA, pointB, pointC,pointE, pointG, pointH, pointI, pointAGameOver, gameOverScreen, knifeImageI, knifeImageII, knifeImageIII;
	private bool genNextFruit = true, isKnifeAvailable = true, isGameOver;
	public Rigidbody2D penRB;
	private Rigidbody2D currentFruitRB;
	private float penVelocity = 20, patternSpeed;
	private Vector3 penInitialPos, fruitGenerationPoint;
	private Collider2D currentFruitCollider;
	public Image glowEffectScreen;


	public Vector3[] quadPath_1, quadPath_2, trianglePath_1, trianglePath_2, triangleOppositePath_1, triangleOppositePath_2, hourGlassPath_1, 
	hourGlassPath_2,zigZagPath_1,zigZagPath_2, circlePath_1,circlePath_2, infinityPath_1, infinityPath_2,heartPath_1,heartPath_2;

	private int score, knifesLeft = 4, bestScore;

	private int selectGenPoint, selectFruit, selectAnimationPattern, selectPathType, selectLoopType;
	private GameObject currentFruit;

	public void Replay()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Fruit Knife Hit");
	}

	public void Home()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Main Menu");
	}

	public void TapAnywhere()
	{
		tapAnywhereToHitTag.enabled = false;

		if (isKnifeAvailable) 
		{
			penRB.WakeUp ();
			penRB.velocity = new Vector2 (0, penVelocity);
			SoundManagerScript.knifeHitAudioSource.Play ();
		}

		isKnifeAvailable = false;
	}

	//================== TYPES OF PATTERNS ============================================

	void PatternHeart()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(heartPath_1,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(heartPath_2,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}
	}

	void PatternInfinity()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(infinityPath_1,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(infinityPath_2,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}
	}

	void PatternCircle()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(circlePath_1,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(circlePath_2,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}
	}

	void PatternZigZag()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(zigZagPath_1,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(zigZagPath_2,patternSpeed,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}
	}

	void PatternQuad ()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(quadPath_1,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(quadPath_2,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}		
	}

	void PatternLine()
	{
		if(fruitGenerationPoint == pointD.transform.position)
			currentFruit.transform.DOMove (pointF.transform.position,patternSpeed,false).SetEase(easeType).SetLoops(-1,LoopType.Yoyo);

		if(fruitGenerationPoint == pointF.transform.position)
			currentFruit.transform.DOMove (pointD.transform.position,patternSpeed,false).SetEase(easeType).SetLoops(-1,LoopType.Yoyo);
	}

	void PatternTriangle()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(trianglePath_1,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(trianglePath_2,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}	
	}

	void PatternTriangleOpposite()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(triangleOppositePath_1,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(triangleOppositePath_2,1.21f,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}	
	}

	void PatternHourGlass()
	{
		if (fruitGenerationPoint == pointD.transform.position) 
		{
			currentFruit.transform.DOPath(hourGlassPath_1,2,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}

		if (fruitGenerationPoint == pointF.transform.position) 
		{
			currentFruit.transform.DOPath(hourGlassPath_2,2,pathType,PathMode.Full3D,4,null).SetEase(Ease.Linear).SetLoops(-1,loopType);
		}	
	}

	IEnumerator SetPenRoutine()
	{
		yield return new WaitForSeconds (1.5f);
		transform.rotation = Quaternion.identity;
		penRB.transform.parent = null;
		splash.gameObject.transform.parent = null;
		transform.position = penInitialPos;
		currentFruitCollider.enabled = true;
		currentFruitCollider.gameObject.transform.localScale = new Vector3 (0, 0, 0);
		currentFruit = null;
		genNextFruit = true;
		isKnifeAvailable = true;
	}

	void DisableNewRecordText()
	{
		newRecordParticle.gameObject.SetActive (false);
		newRecordTag.enabled = false;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "top collider") 
		{
			knifesLeft--;
			isKnifeAvailable = true;
			transform.position = penInitialPos;
			penRB.isKinematic = false;
			penRB.Sleep ();
			Debug.Log (knifesLeft);

			switch (knifesLeft) 
			{
			case 3:
				knifeImageIII.SetActive (false);
				break;
			case 2:
				knifeImageII.SetActive (false);
				break;
			case 1:
				knifeImageI.SetActive (false);
				break;

			default:
				SoundManagerScript.gameoverAudioSource.Play ();
				gameOverText.gameObject.transform.DOBlendableLocalMoveBy (new Vector3 (0, 3, 0), 0.15f, false).SetEase (Ease.Linear).SetLoops (-1, LoopType.Yoyo);
				//bestScoreText_GameOver.gameObject.transform.DOBlendableMoveBy (new Vector3(0,3,0),0.15f,false).SetEase (Ease.Linear).SetLoops (-1, LoopType.Yoyo);
				//scoreText_GameOver.gameObject.transform.DOBlendableMoveBy (new Vector3(0,3,0),0.15f,false).SetEase (Ease.Linear).SetLoops (-1, LoopType.Yoyo);
				gameOverScreen.transform.DOMove (pointAGameOver.transform.position, 0.3f, false).SetEase (Ease.Flash);

				if (score >= bestScore) 
				{
					bestScore = score;
					PlayerPrefs.SetInt ("bestscore", bestScore);
				}

				bestScoreText_GameOver.text = bestScore.ToString ();
				scoreText_GameOver.text = score.ToString ();

				isGameOver = true;
				break;
			}
		}

		if (col.gameObject.tag == "fruit") 
		{
			score++;
			scoreText.text = score.ToString ();

			if (PlayerPrefs.HasKey ("bestscore")) 
			{
				if (score == bestScore + 1) 
				{
					newRecordParticle.gameObject.SetActive (true);
					newRecordParticle.Play ();
					newRecordTag.transform.DOBlendableScaleBy(new Vector3(0.11f,0.11f,0),0.25f).SetEase(Ease.Linear).SetLoops(8,LoopType.Yoyo).OnComplete(DisableNewRecordText);
					newRecordTag.enabled = true;
				}
			}

			//glowEffectScreen.DOColor(new Color(1,1,1,1.0f),0.1f).SetLoops(2,LoopType.Yoyo);
			scoreText.gameObject.transform.DOPunchScale (new Vector3 (0.21f, 0.21f, 0), 0.5f, 10, 0.5f).SetLoops(1,LoopType.Yoyo);
			//penParticle.Stop ();
			SoundManagerScript.fruitHitAudioSource.Play ();
			splash.gameObject.SetActive (true);
			splash.gameObject.transform.parent = col.gameObject.transform;
			splash.gameObject.transform.position = penRB.transform.position + new Vector3(0,0,1);
			splash.Play ();
			penRB.transform.parent = col.gameObject.transform;
			currentFruitCollider = col;
			currentFruitCollider.enabled = false;
			currentFruitRB = col.gameObject.GetComponent<Rigidbody2D> ();
			currentFruitRB.gameObject.transform.DOKill ();
			currentFruitRB.gravityScale = 2;
			currentFruitRB.velocity = new Vector2 (0,9.5f);
			currentFruitRB.AddTorque (351);
			penRB.isKinematic = true;
			penRB.Sleep ();
			StartCoroutine ("SetPenRoutine");
		}
	}

	void AnimationPattern()
	{
		selectAnimationPattern = Random.Range (0,20);

		switch (selectAnimationPattern) 
		{
		case 0:
			easeType = Ease.Flash;
			patternSpeed = 0.75f;
			PatternLine ();
			break;	
		
		case 1:
			easeType = Ease.InOutBack;
			patternSpeed = 1.51f;
			PatternLine ();
			break;

		case 2:
			easeType = Ease.InOutBounce;
			patternSpeed = 2.0f;
			PatternLine ();
			break;

		case 3:
			easeType = Ease.InOutCirc;
			patternSpeed = 1.0f;
			PatternLine ();
			break;

		case 4:
			easeType = Ease.InOutCubic;
			patternSpeed = 1.0f;
			PatternLine ();
			break;

		case 5:
			easeType = Ease.InOutExpo;
			patternSpeed = 1.21f;
			PatternLine ();
			break;

		case 6:
			easeType = Ease.InOutFlash;
			patternSpeed = 1.0f;
			PatternLine ();
			break;

		case 7:
			easeType = Ease.InOutQuad;
			patternSpeed = 0.75f;
			PatternLine ();
			break;

		case 8:
			easeType = Ease.InOutQuart;
			patternSpeed = 1.0f;
			PatternLine ();
			break;

		case 9:
			easeType = Ease.InOutQuint;
			patternSpeed = 1.21f;
			PatternLine ();
			break;

		case 10:
			easeType = Ease.InOutSine;
			patternSpeed = 1.0f;
			PatternLine ();
			break;

		case 11:
			easeType = Ease.Linear;
			patternSpeed = 0.5f;
			PatternLine ();
			break;	

		case 12:
			easeType = Ease.Linear;
			patternSpeed = 0.5f;
			PatternQuad ();
			break;

		case 13:
			easeType = Ease.Linear;
			patternSpeed = 0.5f;
			PatternTriangle ();
			break;

		case 14:
			easeType = Ease.Linear;
			patternSpeed = 0.5f;
			PatternTriangleOpposite ();
			break;

		case 15:
			easeType = Ease.Linear;
			patternSpeed = 1f;
			PatternHourGlass ();
			break;

		case 16:
			easeType = Ease.Linear;
			patternSpeed = 1.21f;
			PatternZigZag ();
			break;

		case 17:
			easeType = Ease.Linear;
			patternSpeed = 1.21f;
			PatternCircle ();
			break;

		case 18:
			easeType = Ease.Linear;
			patternSpeed = 1.5f;
			PatternInfinity ();
			break;

		case 19:
			easeType = Ease.Linear;
			patternSpeed = 1.5f;
			PatternHeart ();
			break;
		}
		//Debug.Log (easeType);
	}

	void Start ()	
	{
		if (PlayerPrefs.HasKey ("bestscore")) 
		{
			bestScore = PlayerPrefs.GetInt ("bestscore");
			bestScoreText.text = bestScore.ToString ();
		}

		tapAnywhereToHitTag.DOColor (new Color(1,1,1,0),0.51f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
		penInitialPos = transform.position;

		newRecordTag.enabled = false;
		newRecordParticle.gameObject.SetActive (false);
	}
	
	void Update ()
	{
		if (isGameOver)
			return;

		if (genNextFruit) 
		{
			//penParticle.Play ();
			selectGenPoint = Random.Range (0,2);

			//----------------- FTUITS GEN POINT --------------------------------------------------
			switch (selectGenPoint) 
			{
			case 0:
				fruitGenerationPoint = pointD.transform.position;
				break;

			case 1:
				fruitGenerationPoint = pointF.transform.position;
				break;
			}

			selectFruit = Random.Range (1, 23);

			//------------------ SELECT FRUIT TYPE HERE --------------------------------------------
			switch(selectFruit)
			{
			case 1:
				currentFruit = PoolManager.current.GetPooledObject_Apple ();
				break;

			case 2:
				currentFruit = PoolManager.current.GetPooledObject_BlueGrapes();
				break;

			case 3:
				currentFruit = PoolManager.current.GetPooledObject_Cherry();
				break;

			case 4:
				currentFruit = PoolManager.current.GetPooledObject_Donut();
				break;

			case 5:
				currentFruit = PoolManager.current.GetPooledObject_FingerChips();
				break;

			case 6:
				currentFruit = PoolManager.current.GetPooledObject_MelonCut();
				break;

			case 7:
				currentFruit = PoolManager.current.GetPooledObject_MelonHalf();
				break;

			case 8:
				currentFruit = PoolManager.current.GetPooledObject_Orange();
				break;

			case 9:
				currentFruit = PoolManager.current.GetPooledObject_OrangeHalf();
				break;

			case 10:
				currentFruit = PoolManager.current.GetPooledObject_PearGreen();
				break;

			case 11:
				currentFruit = PoolManager.current.GetPooledObject_PineappleLong();
				break;

			case 12:
				currentFruit = PoolManager.current.GetPooledObject_PineappleSmall();
				break;

			case 13:
				currentFruit = PoolManager.current.GetPooledObject_Pomegrate();
				break;

			case 14:
				currentFruit = PoolManager.current.GetPooledObject_Pumpkin();
				break;

			case 15:
				currentFruit = PoolManager.current.GetPooledObject_PurpleGrapes();
				break;

			case 16:
				currentFruit = PoolManager.current.GetPooledObject_RedGrapes();
				break;

			case 17:
				currentFruit = PoolManager.current.GetPooledObject_Strawberry();
				break;

			case 18:
				currentFruit = PoolManager.current.GetPooledObject_StrawberryCut();
				break;

			case 19:
				currentFruit = PoolManager.current.GetPooledObject_Tomato();
				break;

			case 20:
				currentFruit = PoolManager.current.GetPooledObject_WaterMelon();
				break;

			case 21:
				currentFruit = PoolManager.current.GetPooledObject_WaterMelonHalf();
				break;

			case 22:
				currentFruit = PoolManager.current.GetPooledObject_YellowPear();
				break;
			}

			currentFruit.transform.DOScale (new Vector3(1,1,1),0.25f);
			currentFruit.transform.position = fruitGenerationPoint;

			//========== SELECT PATHTYPE ===============
			selectPathType = Random.Range (0,2);
			switch (selectPathType) 
			{
			case 0:
				pathType = PathType.Linear;
				break;

			case 1:
				pathType = PathType.CatmullRom;
				break;
			}
			//========== SELECT LOOPTYPE ===============
			selectLoopType = Random.Range (0,2);
			switch (selectLoopType) 
			{
			case 0:
				loopType = LoopType.Restart;
				break;

			case 1:
				loopType = LoopType.Yoyo;
				break;
			}

			AnimationPattern ();
			currentFruit.SetActive (true);
			SoundManagerScript.fruitSpawnAudioSource.Play ();
			genNextFruit = false;
		}
	}
}

//          seq = DOTween.Sequence ();
//			seq.Append(currentFruit.transform.DOMove(pointB.transform.position,patternSpeed,false));
//			seq.Append(currentFruit.transform.DOMove(pointD.transform.position,patternSpeed,false));
//			seq.Append(currentFruit.transform.DOMove(pointH.transform.position,patternSpeed,false));
//			seq.Append(currentFruit.transform.DOMove(pointF.transform.position,patternSpeed,false));
//			seq.SetLoops(-1);
