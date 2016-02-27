/*
 * Crée par SharpDevelop.
 * Utilisateur: Ours
 * Date: 26/02/2016
 * Heure: 18:06
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace ShutDown
{
	partial class MainForm {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.RadioButton rdbShutdown;
		private System.Windows.Forms.RadioButton rdbRestart;
		private System.Windows.Forms.RadioButton rdbLogoff;
		private System.Windows.Forms.RadioButton rdbSleep;
		private System.Windows.Forms.RadioButton rdbDate;
		private System.Windows.Forms.RadioButton rdbTimer;

		private System.Windows.Forms.GroupBox grpbAction;
		private System.Windows.Forms.GroupBox grpbDans;
		private System.Windows.Forms.GroupBox grpbLe;
		
		private System.Windows.Forms.NumericUpDown nudSecond;
		private System.Windows.Forms.NumericUpDown nudMinute;
		private System.Windows.Forms.NumericUpDown nudHour;
		private System.Windows.Forms.NumericUpDown nudSecondGrpbLe;
		private System.Windows.Forms.NumericUpDown nudMinuteGrpbLe;
		private System.Windows.Forms.NumericUpDown nudHeureGrpbLe;
		
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		
		private System.Windows.Forms.Button btnAction;
		
		private System.Windows.Forms.SplitContainer splitContainer1;
		
		private System.Windows.Forms.DateTimePicker dtPicker;
		private System.Windows.Forms.Button btnCancel;

		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		protected void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rdbShutdown = new System.Windows.Forms.RadioButton();
			this.rdbRestart = new System.Windows.Forms.RadioButton();
			this.rdbLogoff = new System.Windows.Forms.RadioButton();
			this.rdbSleep = new System.Windows.Forms.RadioButton();
			this.rdbTimer = new System.Windows.Forms.RadioButton();
			this.rdbDate = new System.Windows.Forms.RadioButton();
			this.grpbAction = new System.Windows.Forms.GroupBox();
			this.grpbLe = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nudSecondGrpbLe = new System.Windows.Forms.NumericUpDown();
			this.nudMinuteGrpbLe = new System.Windows.Forms.NumericUpDown();
			this.nudHeureGrpbLe = new System.Windows.Forms.NumericUpDown();
			this.dtPicker = new System.Windows.Forms.DateTimePicker();
			this.grpbDans = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudSecond = new System.Windows.Forms.NumericUpDown();
			this.nudMinute = new System.Windows.Forms.NumericUpDown();
			this.nudHour = new System.Windows.Forms.NumericUpDown();
			this.btnAction = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpbAction.SuspendLayout();
			this.grpbLe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSecondGrpbLe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinuteGrpbLe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeureGrpbLe)).BeginInit();
			this.grpbDans.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rdbShutdown
			// 
			this.rdbShutdown.Location = new System.Drawing.Point(6, 26);
			this.rdbShutdown.Name = "rdbShutdown";
			this.rdbShutdown.Size = new System.Drawing.Size(121, 24);
			this.rdbShutdown.TabIndex = 0;
			this.rdbShutdown.TabStop = true;
			this.rdbShutdown.Text = "Eteindre";
			this.rdbShutdown.UseVisualStyleBackColor = true;
			// 
			// rdbRestart
			// 
			this.rdbRestart.Location = new System.Drawing.Point(6, 56);
			this.rdbRestart.Name = "rdbRestart";
			this.rdbRestart.Size = new System.Drawing.Size(121, 24);
			this.rdbRestart.TabIndex = 1;
			this.rdbRestart.TabStop = true;
			this.rdbRestart.Text = "Redémarrer";
			this.rdbRestart.UseVisualStyleBackColor = true;
			// 
			// rdbLogoff
			// 
			this.rdbLogoff.Location = new System.Drawing.Point(6, 86);
			this.rdbLogoff.Name = "rdbLogoff";
			this.rdbLogoff.Size = new System.Drawing.Size(121, 24);
			this.rdbLogoff.TabIndex = 2;
			this.rdbLogoff.TabStop = true;
			this.rdbLogoff.Text = "Fermer séssion";
			this.rdbLogoff.UseVisualStyleBackColor = true;
			// 
			// rdbSleep
			// 
			this.rdbSleep.Location = new System.Drawing.Point(6, 116);
			this.rdbSleep.Name = "rdbSleep";
			this.rdbSleep.Size = new System.Drawing.Size(121, 24);
			this.rdbSleep.TabIndex = 3;
			this.rdbSleep.TabStop = true;
			this.rdbSleep.Text = "Veille prolongée";
			this.rdbSleep.UseVisualStyleBackColor = true;
			// 
			// rdbTimer
			// 
			this.rdbTimer.Location = new System.Drawing.Point(15, 0);
			this.rdbTimer.Name = "rdbTimer";
			this.rdbTimer.Size = new System.Drawing.Size(69, 24);
			this.rdbTimer.TabIndex = 0;
			this.rdbTimer.TabStop = true;
			this.rdbTimer.Text = "Dans :";
			this.rdbTimer.UseVisualStyleBackColor = true;
			this.rdbTimer.CheckedChanged += new System.EventHandler(this.RdbTimerCheckedChanged);
			// 
			// rdbDate
			// 
			this.rdbDate.Location = new System.Drawing.Point(15, 0);
			this.rdbDate.Name = "rdbDate";
			this.rdbDate.Size = new System.Drawing.Size(49, 24);
			this.rdbDate.TabIndex = 0;
			this.rdbDate.TabStop = true;
			this.rdbDate.Text = "Le :";
			this.rdbDate.UseVisualStyleBackColor = true;
			this.rdbDate.CheckedChanged += new System.EventHandler(this.RdbDateCheckedChanged);
			// 
			// grpbAction
			// 
			this.grpbAction.Controls.Add(this.rdbSleep);
			this.grpbAction.Controls.Add(this.rdbShutdown);
			this.grpbAction.Controls.Add(this.rdbLogoff);
			this.grpbAction.Controls.Add(this.rdbRestart);
			this.grpbAction.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpbAction.Location = new System.Drawing.Point(3, 3);
			this.grpbAction.Name = "grpbAction";
			this.grpbAction.Size = new System.Drawing.Size(156, 148);
			this.grpbAction.TabIndex = 0;
			this.grpbAction.TabStop = false;
			this.grpbAction.Text = "Action";
			// 
			// grpbLe
			// 
			this.grpbLe.Controls.Add(this.label4);
			this.grpbLe.Controls.Add(this.label5);
			this.grpbLe.Controls.Add(this.label6);
			this.grpbLe.Controls.Add(this.nudSecondGrpbLe);
			this.grpbLe.Controls.Add(this.nudMinuteGrpbLe);
			this.grpbLe.Controls.Add(this.nudHeureGrpbLe);
			this.grpbLe.Controls.Add(this.dtPicker);
			this.grpbLe.Controls.Add(this.rdbDate);
			this.grpbLe.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpbLe.Location = new System.Drawing.Point(5, 82);
			this.grpbLe.Name = "grpbLe";
			this.grpbLe.Size = new System.Drawing.Size(304, 133);
			this.grpbLe.TabIndex = 0;
			this.grpbLe.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(208, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Seconde";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(145, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Minute";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(90, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 24);
			this.label6.TabIndex = 7;
			this.label6.Text = "Heure";
			// 
			// nudSecondGrpbLe
			// 
			this.nudSecondGrpbLe.Location = new System.Drawing.Point(209, 100);
			this.nudSecondGrpbLe.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudSecondGrpbLe.Name = "nudSecondGrpbLe";
			this.nudSecondGrpbLe.Size = new System.Drawing.Size(41, 27);
			this.nudSecondGrpbLe.TabIndex = 4;
			// 
			// nudMinuteGrpbLe
			// 
			this.nudMinuteGrpbLe.Location = new System.Drawing.Point(150, 100);
			this.nudMinuteGrpbLe.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudMinuteGrpbLe.Name = "nudMinuteGrpbLe";
			this.nudMinuteGrpbLe.Size = new System.Drawing.Size(41, 27);
			this.nudMinuteGrpbLe.TabIndex = 3;
			// 
			// nudHeureGrpbLe
			// 
			this.nudHeureGrpbLe.Location = new System.Drawing.Point(92, 100);
			this.nudHeureGrpbLe.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudHeureGrpbLe.Name = "nudHeureGrpbLe";
			this.nudHeureGrpbLe.Size = new System.Drawing.Size(41, 27);
			this.nudHeureGrpbLe.TabIndex = 2;
			// 
			// dtPicker
			// 
			this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtPicker.Location = new System.Drawing.Point(106, 34);
			this.dtPicker.Name = "dtPicker";
			this.dtPicker.Size = new System.Drawing.Size(115, 27);
			this.dtPicker.TabIndex = 1;
			// 
			// grpbDans
			// 
			this.grpbDans.Controls.Add(this.label3);
			this.grpbDans.Controls.Add(this.label2);
			this.grpbDans.Controls.Add(this.label1);
			this.grpbDans.Controls.Add(this.nudSecond);
			this.grpbDans.Controls.Add(this.nudMinute);
			this.grpbDans.Controls.Add(this.nudHour);
			this.grpbDans.Controls.Add(this.rdbTimer);
			this.grpbDans.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpbDans.Location = new System.Drawing.Point(5, 3);
			this.grpbDans.Name = "grpbDans";
			this.grpbDans.Size = new System.Drawing.Size(304, 80);
			this.grpbDans.TabIndex = 0;
			this.grpbDans.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(208, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Seconde";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(145, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Minute";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(90, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Heure";
			// 
			// nudSecond
			// 
			this.nudSecond.Location = new System.Drawing.Point(209, 46);
			this.nudSecond.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudSecond.Name = "nudSecond";
			this.nudSecond.Size = new System.Drawing.Size(41, 27);
			this.nudSecond.TabIndex = 3;
			// 
			// nudMinute
			// 
			this.nudMinute.Location = new System.Drawing.Point(150, 46);
			this.nudMinute.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudMinute.Name = "nudMinute";
			this.nudMinute.Size = new System.Drawing.Size(41, 27);
			this.nudMinute.TabIndex = 2;
			// 
			// nudHour
			// 
			this.nudHour.Location = new System.Drawing.Point(92, 46);
			this.nudHour.Maximum = new decimal(new int[] {
			60,
			0,
			0,
			0});
			this.nudHour.Name = "nudHour";
			this.nudHour.Size = new System.Drawing.Size(41, 27);
			this.nudHour.TabIndex = 1;
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(38, 157);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(75, 23);
			this.btnAction.TabIndex = 4;
			this.btnAction.Text = "Go !";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.BtnActionClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
			this.splitContainer1.Panel1.Controls.Add(this.btnAction);
			this.splitContainer1.Panel1.Controls.Add(this.grpbAction);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grpbLe);
			this.splitContainer1.Panel2.Controls.Add(this.grpbDans);
			this.splitContainer1.Size = new System.Drawing.Size(488, 218);
			this.splitContainer1.SplitterDistance = 162;
			this.splitContainer1.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(38, 186);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 242);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ShutDown";
			this.grpbAction.ResumeLayout(false);
			this.grpbLe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudSecondGrpbLe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinuteGrpbLe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeureGrpbLe)).EndInit();
			this.grpbDans.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}