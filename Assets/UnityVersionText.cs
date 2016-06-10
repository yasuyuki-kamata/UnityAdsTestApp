using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UnityVersionText : MonoBehaviour
{
	public Text text;
	void Start ()
	{
		if (text == null)
			text = GetComponent<Text> ();

		string _text = "";
		_text += "Built by Unity " + UnityEngine.Application.unityVersion.ToString();
		_text += "\n";
		_text += "Unity Ads Version : Built-in";
		text.text = _text;
	}
}
