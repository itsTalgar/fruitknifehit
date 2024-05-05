using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour 
{
	public GameObject FruitTag, KnifeHitTag, BestScoreTag, playButtonGO, quitButtonGO;
	public Text bestScoreText;
	private int bestScore;

	public void Play()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		SceneManager.LoadScene ("Fruit Knife Hit");
	}

	public void Quit()
	{
		SoundManagerScript.buttonAudioSource.Play ();
		Application.Quit ();
	}

	void Start () 
	{
		FruitTag.transform.DOBlendableScaleBy(new Vector3(0.025f,0.025f,0),0.11f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
		KnifeHitTag.transform.DOBlendableScaleBy(new Vector3(0.025f,0.025f,0),0.11f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);
		BestScoreTag.transform.DOBlendableMoveBy(new Vector3(0,2f,0),0.21f,false).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo);

		if (PlayerPrefs.HasKey ("bestscore")) 
		{
			bestScore = PlayerPrefs.GetInt ("bestscore");
			bestScoreText.text = bestScore.ToString ();
		}
	}
}
