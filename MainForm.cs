using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShutDown {

	public partial class MainForm : Form {
		
		List<RadioButton> _radioButtonGroup 	= new List<RadioButton>();

		List<NumericUpDown> _controlgrpbDans 	= new List<NumericUpDown>();
		List<NumericUpDown> _controlGrpbLe 		= new List<NumericUpDown>();
		
		Dictionary<string, string> argval 		= new Dictionary<string, string>();
		
		const string REBOOT 					= "/r";
		const string SHUTDOWN 					= "/s";
		const string CANCEL 					= "/a";
		const string LOGOFF 					= "/l";
		const string FORCE 						= "/f";

		int compteur 							= 0;

		[DllImport("user32")]
		public static extern void LockWorkStation();

		public MainForm() {

			InitializeComponent();

			_radioButtonGroup.Add(rdbDate);
			_radioButtonGroup.Add(rdbTimer);

			_controlgrpbDans.Add(nudHour);
			_controlgrpbDans.Add(nudMinute);
			_controlgrpbDans.Add(nudSecond);
			
			_controlGrpbLe.Add(nudHeureGrpbLe);
			_controlGrpbLe.Add(nudMinuteGrpbLe);
			_controlGrpbLe.Add(nudSecondGrpbLe);
			
			DisableControlGrpbLe();
			DisableControlGrpbDans();
		}

		void BtnActionClick(object sender, EventArgs e) {
			string context = "";
			argval.Clear();

			if (!rdbDate.Checked && !rdbTimer.Checked) {
				MessageBox.Show("Veuillez selectionnez un type sur le coté droit de la fenêtre.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			if (rdbDate.Checked) {
				ScheduleTask st = new ScheduleTask();
				string argToRun = "";

				if (rdbRestart.Checked)  { argToRun = REBOOT; context = REBOOT;  	  	  }
				if (rdbShutdown.Checked) { argToRun = SHUTDOWN; context = SHUTDOWN;   	  }
				if (rdbLogoff.Checked) 	 { argToRun = LOGOFF+" "+FORCE; context = LOGOFF; }

				argval.Add("/Create ", "");
				argval.Add("/SC ", "ONCE");
				argval.Add(" /TN ", "\"Opération "+compteur+"\"");
				argval.Add(" /TR ", "\"shutdown.exe "+argToRun+" /t 0\"");
				argval.Add(" /SD ", dtPicker.Value.ToString("dd/MM/yyyy"));
				argval.Add(" /ST ", nudHeureGrpbLe.Value.ToString().PadLeft(2, '0')+":"+nudMinuteGrpbLe.Value.ToString().PadLeft(2, '0'));
				
				st.setArgs(argval);
				st.Start();
				st.WaitForExit(100);
				
				AfficherMessage(st.ExitCode, context);
				
				compteur++;
			}

			if (rdbTimer.Checked) {
				long s = GetTime();
				Cmd st = new Cmd();

				if (rdbShutdown.Checked) { argval.Add(SHUTDOWN, ""); context = SHUTDOWN; 	   }
				if (rdbRestart.Checked)  { argval.Add(REBOOT, "");  context = REBOOT;    	   }
				if (rdbLogoff.Checked)	 { argval.Add(LOGOFF+" "+FORCE, ""); context = LOGOFF; }
				
				argval.Add("/t ", s.ToString());
				
				st.setArgs(argval);
				st.Start();
				st.WaitForExit(100);
				
				AfficherMessage(st.ExitCode, context);
			}
		}
		
		void AfficherMessage(int exitCode, string context="") {
			
			string motCle = "";
			
			if (context == REBOOT)   { motCle = "va redémarrer"; }
			if (context == SHUTDOWN) { motCle = "s'éteindra";	 }
			if (context == "") 	 	 { exitCode = 1; 			 }
			
			if (rdbDate.Checked) {
				if (exitCode == 0) {
					MessageBox.Show("Votre ordinateur "+motCle+" de lui même le "+dtPicker.Value.ToString("dd/MM/yyyy")+" à "
					                +nudHeureGrpbLe.Value+"h"+nudMinuteGrpbLe.Value+"m", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else {
					MessageBox.Show("Une erreur est survenue pendant la mise en oeuvre de la tâche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}				
			}
			else {
				if (exitCode == 0) {
					MessageBox.Show("Votre ordinateur "+motCle+" dans "+nudHour.Value+" h "+nudMinute.Value+" m", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else {
					MessageBox.Show("Une erreur est survenue pendant la mise en oeuvre de la tâche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		void RdbTimerCheckedChanged(object sender, EventArgs e) {
			rdb_checkChanged(sender, e);
			EnableControlGrpbDans();
			DisableControlGrpbLe();
		}

		void RdbDateCheckedChanged(object sender, EventArgs e) {
			rdb_checkChanged(sender, e);
			DisableControlGrpbDans();
			EnableControlGrpbLe();
		}

		void rdb_checkChanged(object sender, EventArgs e) {
			RadioButton rb = (RadioButton)sender;

			if (rb.Checked) {
				foreach(RadioButton other in _radioButtonGroup) {
					if (other == rb) {
						continue;
					}
					other.Checked = false;
				}
			}
		}
		
		void DisableControlGrpbDans() {
			foreach(NumericUpDown nud in _controlgrpbDans) {
				nud.Enabled = false;
			}
		}
		
		void EnableControlGrpbDans() {
			foreach(NumericUpDown nud in _controlgrpbDans) {
				nud.Enabled = true;
			}
		}
		
		void DisableControlGrpbLe() {
			foreach(NumericUpDown nud in _controlGrpbLe) {
				nud.Enabled = false;
			}
			dtPicker.Enabled = false;
		}
		
		void EnableControlGrpbLe() {
			foreach(NumericUpDown nud in _controlGrpbLe) {
				nud.Enabled = true;
			}
			dtPicker.Enabled = true;
		}

		long GetTime() {
			long s = 0;
			if (rdbTimer.Checked) {
				s = Convert.ToUInt32(nudHour.Value*3600+nudMinute.Value*60+nudSecond.Value);
			}
			if (rdbDate.Checked) {
				s = Convert.ToUInt32(nudHeureGrpbLe.Value*3600+nudMinuteGrpbLe.Value*60+nudSecondGrpbLe.Value);
			}
			return s;
		}

		void BtnCancelClick(object sender, EventArgs e) {
			Cmd cmd = new Cmd();
			cmd.SetArgs(CANCEL);
			cmd.Start();
			cmd.WaitForExit(100);
			if (cmd.ExitCode==0) {
				MessageBox.Show("Opération annulée");
			}
			else {
				MessageBox.Show("Erreur");
			}
		}
	}
}
