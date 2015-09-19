using UnityEngine;
using System.Collections;
//using System; // for System.DateTime

namespace NS_MyPlotlyUtil
{
	public static class MyPlotlyUtil {
		public static string GetAddString_xy(string username, string apikey, float xpos, float ypos) {
			string res = 
			"un=" + username + "&" +
			"key=" + apikey + "&" +
			"origin=plot&" +
			"platform=lisp&" +
			"args=[[" + xpos.ToString("0.000") + "]," +
				  "[" + ypos.ToString("0.000") + "]]&" +
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
				"\"world_readable\": true" + // set graph to public
			"}";
			return res;
		}

		public static string GetAddString_time_y(string username, string apikey, System.DateTime dt, float ypos) {
			string res = 
				"un=" + username + "&" +
					"key=" + apikey + "&" +
					"origin=plot&" +
					"platform=lisp&" +
					"args=[[\"" + dt.ToString ("yyyy-MM-dd hh:mm:ss") + "\"]," +
					"[" + ypos.ToString("0.000") + "]]&" +
					"kwargs={\"filename\": \"plot from api 150919time\"," +
					//				"\"fileopt\": \"overwrite\"," + 
					"\"fileopt\": \"extend\"," +
					
					"\"layout\": {" +
					"\"title\": \"experimental data\"" +
					"}," + 
					"\"world_readable\": true" + // set graph to public
					"}";
			return res;
		}
	}
}

