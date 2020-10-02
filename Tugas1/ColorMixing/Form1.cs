using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixing
{
    public partial class Window : Form
    {
        private int red;
        private int blue;
        private int green;

        private Dictionary<string, Color> colorNames = new Dictionary<string, Color>();

        public Window()
        {
            InitializeComponent();
        }

        private void redScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            handleColorChange("red", e.NewValue);
        }

        private void greenScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            handleColorChange("green", e.NewValue);
        }

        private void blueScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            handleColorChange("blue", e.NewValue);
        }

        /**
         * Set color value di lable indikator dan di variable
         * @param text - red, green, blue 
         * @value value - nilai dari warna 
         */
        private void handleColorChange(String text, int value)
        {
            switch (text)
            {

                case "red":
                    red = value;
                    lblRedIndicatorValue.Text = value.ToString();
                    break;
                case "green":
                    green = value;
                    lblGreenIndicatorValue.Text = value.ToString();
                    break;
                case "blue":
                    blue = value;
                    lblBlueIndicatorValue.Text = value.ToString();
                    break;
                default:
                    Console.WriteLine("Subject is C#");
                    break;
            }

            setPreviewColor();
        }

        // get red green blue color variable and set to preivew box  
        private void setPreviewColor()
        {
            previewColorBox.BackColor = Color.FromArgb(red, green, blue);
        }

        // for text box when get focus 
        private void textBox_Enter(object sender, EventArgs e)
        {
            if (colorNameTextBox.Text == "Color Name")
            {
                colorNameTextBox.ForeColor = Color.FromName("black");
                colorNameTextBox.Text = "";
            }
        }

        // for text box when lost focus
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (colorNameTextBox.Text == "")
            {
                colorNameTextBox.ForeColor = Color.FromName("silver");
                colorNameTextBox.Text = "Color Name";
            }
        }

        private void saveColorBtn_Click(object sender, EventArgs e)
        {
            saveColorNameAction();
        }

        private void saveColorBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
            {
                saveColorNameAction();
            }
        }

        private void colorNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get color selected color value from dictionary 
            Color newColor;
            colorNames.TryGetValue((string)colorNamesComboBox.SelectedItem, out newColor);


            // set color to indicator and scrollbar
            red = newColor.R;
            green = newColor.G;
            blue = newColor.B;

            redScrollBar.Value = red;
            greenScrollBar.Value = green;
            blueScrollBar.Value = blue;

            setPreviewColor();
        }

        private void saveColorNameAction()
        {
            // check if textbox is empty
            if (colorNameTextBox.Text == "Color Name" || colorNameTextBox.Text == "")
            {
                MessageBox.Show("Sorry, tentukan nama untuk komposisi wana terlebih dahulu ", "Color Mixer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // add name to combo box
                colorNamesComboBox.Items.Add(colorNameTextBox.Text);

                // add name and color value to dictionary 
                ;
                colorNames.Add(colorNameTextBox.Text, previewColorBox.BackColor);

                // set combo box to last added item 
                colorNamesComboBox.SelectedIndex = colorNamesComboBox.Items.Count - 1;

                // change textBox to initial state 
                colorNameTextBox.ForeColor = Color.FromName("silver");
                colorNameTextBox.Text = "Color Name";
            }
        }
    }
}
