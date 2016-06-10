using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

[RequireComponent(typeof(Text))]
public class UnityAdsReadyText : MonoBehaviour
{
	public Text text;

	void Start ()
	{
		if (text == null)
			text = GetComponent<Text> ();
	}

	void Update ()
	{
		text.text = "isReady?: " + Advertisement.IsReady ().ToString ();
	}
}
