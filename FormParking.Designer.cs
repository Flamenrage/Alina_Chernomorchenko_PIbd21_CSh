namespace Plane_project
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakePlane = new System.Windows.Forms.PictureBox();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(2, 32);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(717, 561);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTakePlane);
            this.groupBox.Controls.Add(this.buttonTakePlane);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(728, 308);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(121, 290);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // pictureBoxTakePlane
            // 
            this.pictureBoxTakePlane.Location = new System.Drawing.Point(10, 125);
            this.pictureBoxTakePlane.Name = "pictureBoxTakePlane";
            this.pictureBoxTakePlane.Size = new System.Drawing.Size(110, 157);
            this.pictureBoxTakePlane.TabIndex = 3;
            this.pictureBoxTakePlane.TabStop = false;
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(14, 85);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(95, 26);
            this.buttonTakePlane.TabIndex = 2;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.ButtonTakePlane_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(18, 57);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(30, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(725, 8);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(60, 17);
            this.labelLevel.TabIndex = 4;
            this.labelLevel.Text = "Уровни:";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(725, 32);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(116, 84);
            this.listBoxLevels.TabIndex = 5;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.ListBoxLevels_SelectedIndexChanged_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(725, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 43);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Заказать самолет";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(857, 30);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "«txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "«txt file | *.txt";
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(727, 198);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(113, 40);
            this.button_sort.TabIndex = 8;
            this.button_sort.Text = "Сортировка";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.Button_sort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 621);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "PlaneParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakePlane)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxTakePlane;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_sort;
    }
}