using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppPlayer
{
	public partial class Form1 : Form
	{
		private bool play;
		private string filename;

		public Form1()
		{
			play = false;
			filename = null;

			InitializeComponent();

			this.enablePlayerbuttons(false);
		}


		private void exit()
		{
			this.Close();
		}

		private void enablePlayerbuttons(bool enable)
		{
			button_play.Enabled = enable;
			button_stop.Enabled = enable;
		}

		private void unloadFile()
		{
			filename = null;
			textBox_filename.Text = filename;
		}



		//	Menue

		private void MenuItem_file_open_Click(object sender, EventArgs e)
		{
			OpenFileDialog file_select = new OpenFileDialog();
			file_select.Title = "open...";
			file_select.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			file_select.ShowDialog();

			if (System.IO.File.Exists(file_select.FileName))
			{
				filename = file_select.FileName;
				textBox_filename.Text = filename;
				this.enablePlayerbuttons(true);
				waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(filename);
			}
		}

		private void MenuItem_file_unloadFile_Click(object sender, EventArgs e)
		{
			this.enablePlayerbuttons(false);
			this.waveViewer1.WaveStream.Dispose();
			this.waveViewer1.WaveStream.Close();
			this.waveViewer1.WaveStream = null;
			this.unloadFile();
		}

		private void MenuItem_file_exit_Click(object sender, EventArgs e)
		{
			this.exit();
		}



		//	Buttons

		private void button_exit_Click(object sender, EventArgs e)
		{
			this.exit();
		}
	}
}
