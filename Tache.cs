using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ShutDown {

	public abstract class Tache : Process{

		public string ReadArgs(Dictionary<string, string> dictArgs) {
			string args = "";
			foreach(KeyValuePair<string, string> kvp in dictArgs) {
				args += kvp.Key+" "+kvp.Value;
			}
			return args;
		}
		
		public bool SetArgs(string args) {
			if (string.IsNullOrEmpty(args)) {
				return false;
			}
			try {
				this.StartInfo.Arguments = args;
				return true;
			}
			catch (Exception e) {
				return false;
			}
		}
		
		public bool setArgs(Dictionary<string, string> dictArgs) {
			try {
				string s = ReadArgs(dictArgs);
				this.StartInfo.Arguments = s;
				return true;
			}
			catch(Exception e) {
				return false;
			}
		}
		
		protected void Init() {
			this.StartInfo.UseShellExecute 	= false;
			this.StartInfo.CreateNoWindow 	= true;
		}
	}
}
