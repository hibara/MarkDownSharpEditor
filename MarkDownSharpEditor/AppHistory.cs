using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace MarkDownSharpEditor
{

	public class AppHistory
	{
		//-----------------------------------
		#region メンバ変数
		//-----------------------------------

		public string md;
		public string css;

		#endregion

		//-----------------------------------
		#region コンストラクタ
		//-----------------------------------
		//コンストラクタがあるとシリアライズでうまくいかないようだ。
		/*
		[NonSerialized()]
		public AppHistory(string key = "", string val = "")
		{
			md = key;
			css = val;
		}
		*/

		#endregion


	}

}
