using UnityEngine;
using System.Collections;

public class timestringcs : MonoBehaviour {

	void Start () {
		System.DateTime dt = System.DateTime.Now;
		Debug.Log (dt.ToString ("yyyy-MM-dd hh:mm:ss"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
