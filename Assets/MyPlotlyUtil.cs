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
			"args=[[6, 7, 8], [3, 4, 5]]&" +
			"kwargs={\"filename\": \"plot from api 150919\"," +
//				"\"fileopt\": \"overwrite\"," + 
				"\"fileopt\": \"extend\"," +

//				"\"style\": {" + 
//					"\"type\": \"bar\"" +
//				"}," + 
//				"\"traces\": [1]," + 
				"\"layout\": {" +
					"\"title\": \"experimental data\"" +
				"}," + 
				"\"world_readable\": true" +
			"}";
			return res;
		}
	}
	
}