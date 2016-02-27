using System;

namespace ShutDown {

	public class Cmd : Tache {
		
		public Cmd() {
			this.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System)+"\\shutdown.exe";
			this.Init();
		}
	}
}
