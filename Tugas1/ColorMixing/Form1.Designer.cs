namespace ColorMixing
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.previewColorBox = new System.Windows.Forms.Panel();
            this.Preview = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveColorBtn = new System.Windows.Forms.Button();
            this.colorNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRedIndicatorValue = new System.Windows.Forms.Label();
            this.lblGreenIndicatorValue = new System.Windows.Forms.Label();
            this.lblBlueIndicatorValue = new System.Windows.Forms.Label();
            this.redScrollBar = new System.Windows.Forms.HScrollBar();
            this.greenScrollBar = new System.Windows.Forms.HScrollBar();
            this.blueScrollBar = new System.Windows.Forms.HScrollBar();
            this.topPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.previewColorBox);
            this.topPanel.Controls.Add(this.Preview);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 10);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(642, 134);
            this.topPanel.TabIndex = 0;
            // 
            // previewColorBox
            // 
            this.previewColorBox.BackColor = System.Drawing.Color.Black;
            this.previewColorBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewColorBox.Location = new System.Drawing.Point(0, 32);
            this.previewColorBox.Name = "previewColorBox";
            this.previewColorBox.Size = new System.Drawing.Size(642, 102);
            this.previewColorBox.TabIndex = 1;
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.Dock = System.Windows.Forms.DockStyle.Top;
            this.Preview.Location = new System.Drawing.Point(0, 0);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(57, 17);
            this.Preview.TabIndex = 0;
            this.Preview.Text = "Preview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorNamesComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.saveColorBtn);
            this.groupBox1.Controls.Add(this.colorNameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(10, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Color";
            // 
            // colorNamesComboBox
            // 
            this.colorNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorNamesComboBox.FormattingEnabled = true;
            this.colorNamesComboBox.Location = new System.Drawing.Point(18, 100);
            this.colorNamesComboBox.Name = "colorNamesComboBox";
            this.colorNamesComboBox.Size = new System.Drawing.Size(234, 33);
            this.colorNamesComboBox.TabIndex = 3;
            this.colorNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.colorNamesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saved Color";
            // 
            // saveColorBtn
            // 
            this.saveColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveColorBtn.Location = new System.Drawing.Point(270, 31);
            this.saveColorBtn.Name = "saveColorBtn";
            this.saveColorBtn.Size = new System.Drawing.Size(133, 32);
            this.saveColorBtn.TabIndex = 1;
            this.saveColorBtn.Text = "Simpan";
            this.saveColorBtn.UseVisualStyleBackColor = true;
            this.saveColorBtn.Click += new System.EventHandler(this.saveColorBtn_Click);
            this.saveColorBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saveColorBtn_KeyPress);
            // 
            // colorNameTextBox
            // 
            this.colorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorNameTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.colorNameTextBox.Location = new System.Drawing.Point(18, 31);
            this.colorNameTextBox.Multiline = true;
            this.colorNameTextBox.Name = "colorNameTextBox";
            this.colorNameTextBox.Size = new System.Drawing.Size(234, 32);
            this.colorNameTextBox.TabIndex = 0;
            this.colorNameTextBox.Text = "Color Name";
            this.colorNameTextBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.colorNameTextBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRedIndicatorValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGreenIndicatorValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBlueIndicatorValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.redScrollBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.greenScrollBar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.blueScrollBar, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 217);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // lblRedIndicatorValue
            // 
            this.lblRedIndicatorValue.AutoSize = true;
            this.lblRedIndicatorValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRedIndicatorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedIndicatorValue.ForeColor = System.Drawing.Color.Red;
            this.lblRedIndicatorValue.Location = new System.Drawing.Point(431, 18);
            this.lblRedIndicatorValue.Name = "lblRedIndicatorValue";
            this.lblRedIndicatorValue.Size = new System.Drawing.Size(208, 18);
            this.lblRedIndicatorValue.TabIndex = 3;
            this.lblRedIndicatorValue.Text = "0";
            this.lblRedIndicatorValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGreenIndicatorValue
            // 
            this.lblGreenIndicatorValue.AutoSize = true;
            this.lblGreenIndicatorValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGreenIndicatorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenIndicatorValue.ForeColor = System.Drawing.Color.Green;
            this.lblGreenIndicatorValue.Location = new System.Drawing.Point(431, 90);
            this.lblGreenIndicatorValue.Name = "lblGreenIndicatorValue";
            this.lblGreenIndicatorValue.Size = new System.Drawing.Size(208, 18);
            this.lblGreenIndicatorValue.TabIndex = 4;
            this.lblGreenIndicatorValue.Text = "0";
            this.lblGreenIndicatorValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBlueIndicatorValue
            // 
            this.lblBlueIndicatorValue.AutoSize = true;
            this.lblBlueIndicatorValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBlueIndicatorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueIndicatorValue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueIndicatorValue.Location = new System.Drawing.Point(431, 162);
            this.lblBlueIndicatorValue.Name = "lblBlueIndicatorValue";
            this.lblBlueIndicatorValue.Size = new System.Drawing.Size(208, 18);
            this.lblBlueIndicatorValue.TabIndex = 5;
            this.lblBlueIndicatorValue.Text = "0";
            this.lblBlueIndicatorValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // redScrollBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.redScrollBar, 2);
            this.redScrollBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.redScrollBar.Location = new System.Drawing.Point(7, 41);
            this.redScrollBar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 0);
            this.redScrollBar.Maximum = 264;
            this.redScrollBar.Name = "redScrollBar";
            this.redScrollBar.Size = new System.Drawing.Size(628, 21);
            this.redScrollBar.TabIndex = 7;
            this.redScrollBar.TabStop = true;
            this.redScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScrollBar_Scroll);
            // 
            // greenScrollBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.greenScrollBar, 2);
            this.greenScrollBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.greenScrollBar.Location = new System.Drawing.Point(7, 113);
            this.greenScrollBar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 0);
            this.greenScrollBar.Maximum = 264;
            this.greenScrollBar.Name = "greenScrollBar";
            this.greenScrollBar.Size = new System.Drawing.Size(628, 21);
            this.greenScrollBar.TabIndex = 7;
            this.greenScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenScrollBar_Scroll);
            // 
            // blueScrollBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.blueScrollBar, 2);
            this.blueScrollBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.blueScrollBar.Location = new System.Drawing.Point(7, 185);
            this.blueScrollBar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 0);
            this.blueScrollBar.Maximum = 264;
            this.blueScrollBar.Name = "blueScrollBar";
            this.blueScrollBar.Size = new System.Drawing.Size(628, 21);
            this.blueScrollBar.TabIndex = 8;
            this.blueScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueScrollBar_Scroll);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(662, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Mixer";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label Preview;
        private System.Windows.Forms.Panel previewColorBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRedIndicatorValue;
        private System.Windows.Forms.Label lblGreenIndicatorValue;
        private System.Windows.Forms.Label lblBlueIndicatorValue;
        private System.Windows.Forms.HScrollBar redScrollBar;
        private System.Windows.Forms.HScrollBar greenScrollBar;
        private System.Windows.Forms.HScrollBar blueScrollBar;
        private System.Windows.Forms.Button saveColorBtn;
        private System.Windows.Forms.TextBox colorNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colorNamesComboBox;
    }
}

