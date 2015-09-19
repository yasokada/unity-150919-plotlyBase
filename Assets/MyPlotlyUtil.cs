using UnityEngine;
using System.Collections;
//using System.Net; // for Dns.XXX()

namespace NS_MyPlotlyUtil
{
	public static class MyPlotlyUtil {
		public static string GetPostString(string username, string apikey) {
			string res = 
			"un=" + username + "&" +
			"key=" + apikey + "&" +
			"origin=plot&" +
			"platform=lisp&" +
			"args=[[0, 1, 2], [3, 4, 5], [1, 2, 3], [6, 6, 5]]&" +
			"kwargs={\"filename\": \"plot from api 150919\"," +
				"\"fileopt\": \"overwrite\"," + 
				"\"style\": {" + 
					"\"type\": \"bar\"" +
				"}," + 
				"\"traces\": [1]," + 
				"\"layout\": {" +
					"\"title\": \"experimental data\"" +
				"}," + 
				"\"world_readable\": true" +
			"}";
			return res;
		}
	}
	
}