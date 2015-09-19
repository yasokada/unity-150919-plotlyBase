using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for Input Field

using NS_MyPlotlyUtil; 

/*
 * v0.1 2015/09/19
 *   - adding random x,y data
 */ 

public class PostButtonScript : MonoBehaviour {

	public InputField IF_username;
	public InputField IF_apikey;
	public Text errText;

	public void PostButtonClick() {
		StartCoroutine ("PostProcess");
	}

	IEnumerator PostProcess() {
		string url = "https://plot.ly/clientresp";

		for (int loop=1; loop<=5; loop++) {
			errText.text = "posting(" + loop.ToString() + "/5)";
			float xpos = Random.Range (0, 100) / 10.0f;
			float ypos = Random.Range (0, 100) / 10.0f;

			string dataStr = MyPlotlyUtil.GetAddString_xy (
				IF_username.text, IF_apikey.text, xpos, ypos);

			byte [] data = System.Text.Encoding.UTF8.GetBytes (dataStr);
		
			WWW www = new WWW (url, data);
			yield return www;

			Debug.Log (www.text);
	
			if (www.text.Contains ("support")) {
				errText.text = "API Key error";
				break;
			} else {
				errText.text = "data added";
			}
			yield return new WaitForSeconds(2.0f);
		}
	}
}
