// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;

namespace UMACharacterSystem
{
    public class ColorUtility
    {

        public static string ToHtmlStringRGBA(Color c) 
		{  
			Color32 cb = c;
			string s = string.Format("{0:X02}{1:X02}{2:X02}{3:X02}",cb.r,cb.g,cb.b,cb.a	);
			return s;
        }

        public static bool TryParseHtmlString(string htmlcolor, out Color c)
        {
			if (htmlcolor.StartsWith("#"))
			{
				htmlcolor = htmlcolor.Substring(1,8);
			}

			if (htmlcolor.Length == 6)
			{
				// add alpha
				htmlcolor += "ff";
			}

			if (htmlcolor.Length == 8)
			{
				try
				{
					byte r = Convert.ToByte(htmlcolor.Substring(0,2));
					byte g = Convert.ToByte(htmlcolor.Substring(2,2));
					byte b = Convert.ToByte(htmlcolor.Substring(4,2));
					byte a = Convert.ToByte(htmlcolor.Substring(6,2));
					Color32 cb = new Color32(r,g,b,a);
					c = cb;
					return true;
				}
				catch
				{
					c = Color.black;
					return false;
				}
			}
			c = Color.black;
            return false;
        }
    }
}

