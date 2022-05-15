/****************************************************************\
* This code written by Itai Danielly                             *
* This program is free software: you can redistribute it and/or  *
* modify it under the terms of the GNU General Public License    *
* as published by the Free Software Foundation, either version 3 *
* of the License, or (at your option) any later version.         *
* This program is distributed in the hope that it will be useful *
* but WITHOUT ANY WARRANTY; without even the implied warranty of *
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.           *
* See the GNU General Public License for more details.           *
\****************************************************************/
using System;
using System.Windows.Forms;





namespace CshApplication
{
	public partial class ApplicationGUI : Form
	{
		public const string INPUT_ERROR = "Input error";

		public ApplicationGUI()
		{
			InitializeComponent();
		}

		private bool getNums(ref double num1, ref double num2){
			bool result = true;
			try
			{
				num1 = Double.Parse(Number1Text.Text);
				num2 = Double.Parse(Number2Text.Text);
			}catch(Exception e){
				result = false;
			}
			return result;
		}

		private void Multiply_Click(object sender, EventArgs e)
		{
			double num1 = 0, num2 = 0;
			if(getNums(ref num1, ref num2)){
				ResultText.Text = (num1 * num2).ToString();
			}
			else{
				ResultText.Text = INPUT_ERROR;
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			double num1 = 0, num2 = 0;
			if (getNums(ref num1, ref num2))
			{
				ResultText.Text = (num1 + num2).ToString();
			}
			else
			{
				ResultText.Text = INPUT_ERROR;
			}
		}

#if UNIT_TEST_ENA
		public string CmdMultiply(string num1, string num2)
		{
			Number2Text.Text = num1;
			Number1Text.Text = num2;

			Multiply_Click(null, null);

			return ResultText.Text;
		}

		public string CmdAdd(string num1, string num2)
		{
			Number2Text.Text = num1;
			Number1Text.Text = num2;

			Add_Click(null, null);

			return ResultText.Text;
		}

#endif
	}
}
