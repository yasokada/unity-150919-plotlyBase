using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for Input Field

using NS_MyPlotlyUtil; 

public class PostButtonScript : MonoBehaviour {

	public InputField IF_apikey;
	public Text errText;

	public void PostButtonClick() {
		StartCoroutine ("PostProcess");
	}

	IEnumerator PostProcess() {
		string url = "https://plot.ly/clientresp";
		float xpos = Random.Range (0, 100) / 10.0f;
		float ypos = Random.Range (0, 100) / 10.0f;
		string dataStr 
			= MyPlotlyUtil.GetPostString ("7of9", IF_apikey.text, xpos, ypos);

		byte [] data = System.Text.Encoding.UTF8.GetBytes (dataStr);
		
		WWW www = new WWW (url, data);
		yield return www;

		Debug.Log (www.text);
	
		if (www.text.Contains ("support")) {
			errText.text = "API Key error";
		}

		int nop = 1; // for breakpoint
	}

}
