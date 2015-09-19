using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for Input Field

using NS_MyPlotlyUtil; 

public class PostButtonScript : MonoBehaviour {

	public InputField IF_apikey;

	public void PostButtonClick() {
		StartCoroutine ("PostProcess");
	}

	IEnumerator PostProcess() {
		string url = "https://plot.ly/clientresp";
		string dataStr = MyPlotlyUtil.GetPostString ("7of9", IF_apikey.text);

		byte [] data = System.Text.Encoding.UTF8.GetBytes (dataStr);
		
		WWW www = new WWW (url, data);
		yield return www;
		
		int nop = 1; // for breakpoint
	}

}
