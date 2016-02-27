using System;

namespace ShutDown {

	public class ScheduleTask : Tache {

		public ScheduleTask() {
			this.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.System)+"\\schtasks.exe";
			this.Init();
		}
	}
}
