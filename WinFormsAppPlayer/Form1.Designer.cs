namespace WinFormsAppPlayer
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_file_open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuItem_file_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_exit = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button_stop = new System.Windows.Forms.Button();
			this.button_play = new System.Windows.Forms.Button();
			this.volume_volumeSlider = new NAudio.Gui.VolumeSlider();
			this.waveViewer1 = new NAudio.Gui.WaveViewer();
			this.textBox_filename = new System.Windows.Forms.TextBox();
			this.MenuItem_file_unloadFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_file});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(484, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuItem_file
			// 
			this.MenuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_file_open,
            this.MenuItem_file_unloadFile,
            this.toolStripSeparator1,
            this.MenuItem_file_exit});
			this.MenuItem_file.Name = "MenuItem_file";
			this.MenuItem_file.Size = new System.Drawing.Size(37, 20);
			this.MenuItem_file.Text = "File";
			// 
			// MenuItem_file_open
			// 
			this.MenuItem_file_open.BackColor = System.Drawing.SystemColors.Control;
			this.MenuItem_file_open.Name = "MenuItem_file_open";
			this.MenuItem_file_open.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_file_open.Text = "Open...";
			this.MenuItem_file_open.Click += new System.EventHandler(this.MenuItem_file_open_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// MenuItem_file_exit
			// 
			this.MenuItem_file_exit.Name = "MenuItem_file_exit";
			this.MenuItem_file_exit.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_file_exit.Text = "Exit";
			this.MenuItem_file_exit.Click += new System.EventHandler(this.MenuItem_file_exit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button_exit);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Controls.Add(this.volume_volumeSlider);
			this.panel1.Controls.Add(this.waveViewer1);
			this.panel1.Controls.Add(this.textBox_filename);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(484, 197);
			this.panel1.TabIndex = 3;
			// 
			// button_exit
			// 
			this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_exit.AutoSize = true;
			this.button_exit.Location = new System.Drawing.Point(391, 154);
			this.button_exit.Margin = new System.Windows.Forms.Padding(10);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(80, 30);
			this.button_exit.TabIndex = 1;
			this.button_exit.Text = "Exit";
			this.button_exit.UseVisualStyleBackColor = true;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.button_stop, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.button_play, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 154);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 30);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// button_stop
			// 
			this.button_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_stop.Location = new System.Drawing.Point(89, 0);
			this.button_stop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.button_stop.Name = "button_stop";
			this.button_stop.Size = new System.Drawing.Size(80, 30);
			this.button_stop.TabIndex = 3;
			this.button_stop.Text = "Stop";
			this.button_stop.UseVisualStyleBackColor = true;
			// 
			// button_play
			// 
			this.button_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_play.Location = new System.Drawing.Point(3, 0);
			this.button_play.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(80, 30);
			this.button_play.TabIndex = 4;
			this.button_play.Text = "Play";
			this.button_play.UseVisualStyleBackColor = true;
			// 
			// volume_volumeSlider
			// 
			this.volume_volumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.volume_volumeSlider.AutoSize = true;
			this.volume_volumeSlider.Location = new System.Drawing.Point(13, 168);
			this.volume_volumeSlider.Name = "volume_volumeSlider";
			this.volume_volumeSlider.Size = new System.Drawing.Size(150, 14);
			this.volume_volumeSlider.TabIndex = 5;
			// 
			// waveViewer1
			// 
			this.waveViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.waveViewer1.AutoSize = true;
			this.waveViewer1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.waveViewer1.Location = new System.Drawing.Point(13, 36);
			this.waveViewer1.Name = "waveViewer1";
			this.waveViewer1.SamplesPerPixel = 128;
			this.waveViewer1.Size = new System.Drawing.Size(458, 100);
			this.waveViewer1.StartPosition = ((long)(0));
			this.waveViewer1.TabIndex = 2;
			this.waveViewer1.WaveStream = null;
			// 
			// textBox_filename
			// 
			this.textBox_filename.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox_filename.Location = new System.Drawing.Point(10, 10);
			this.textBox_filename.Name = "textBox_filename";
			this.textBox_filename.ReadOnly = true;
			this.textBox_filename.Size = new System.Drawing.Size(464, 20);
			this.textBox_filename.TabIndex = 0;
			// 
			// MenuItem_file_unloadFile
			// 
			this.MenuItem_file_unloadFile.Name = "MenuItem_file_unloadFile";
			this.MenuItem_file_unloadFile.Size = new System.Drawing.Size(180, 22);
			this.MenuItem_file_unloadFile.Text = "Unload File";
			this.MenuItem_file_unloadFile.Click += new System.EventHandler(this.MenuItem_file_unloadFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(484, 221);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_file;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_file_open;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_file_exit;
		private System.Windows.Forms.Panel panel1;
		private NAudio.Gui.WaveViewer waveViewer1;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.TextBox textBox_filename;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button_stop;
		private System.Windows.Forms.Button button_play;
		private NAudio.Gui.VolumeSlider volume_volumeSlider;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_file_unloadFile;
	}
}

