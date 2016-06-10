using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Events;

public class UnityAdsSample : MonoBehaviour
{
	public UnityEvent OnUnityAdsFinished;
	public UnityEvent OnUnityAdsSkipped;
	public UnityEvent OnUnityAdsFailed;
	ShowOptions option;

	void Start ()
	{
		option = new ShowOptions { resultCallback = HandleShowResult };
		OnUnityAdsFinished.AddListener(FinishedEvent);
		OnUnityAdsSkipped.AddListener(SkippedEvent);
		OnUnityAdsFailed.AddListener(FailedEvent);
	}

	private void HandleShowResult (ShowResult result)
	{
		switch (result)
		{
		case ShowResult.Finished:
			OnUnityAdsFinished.Invoke ();
			break;
		case ShowResult.Skipped:
			OnUnityAdsSkipped.Invoke ();
			break;
		case ShowResult.Failed:
			OnUnityAdsFailed.Invoke ();
			break;
		default:
			break;
		}
	}

	public void ShowAd ()
	{
		if (Advertisement.IsReady ()) {
			Debug.Log ("Show!", this);
			Advertisement.Show ("rewardedVideo", option);
		}
	}

	private void FinishedEvent ()
	{
		Debug.Log ("Finished!", this);
	}

	private void SkippedEvent ()
	{
		Debug.Log ("Skipped!", this);
	}

	private void FailedEvent ()
	{
		Debug.Log ("Failed!", this);
	}
}
