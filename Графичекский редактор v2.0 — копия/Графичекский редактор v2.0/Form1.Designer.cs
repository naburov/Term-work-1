namespace Графичекский_редактор_v2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.glControl1 = new OpenTK.GLControl();
            this.BrushButton = new System.Windows.Forms.Button();
            this.RectButton = new System.Windows.Forms.Button();
            this.СircleButton = new System.Windows.Forms.Button();
            this.StraightButton = new System.Windows.Forms.Button();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.ChoseThickness = new System.Windows.Forms.TrackBar();
            this.showAllLaysButton = new System.Windows.Forms.RadioButton();
            this.showFirstLayButton = new System.Windows.Forms.RadioButton();
            this.showSecondLayButton = new System.Windows.Forms.RadioButton();
            this.EraserButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.слойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьТекущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОбаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ChoseThickness)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 34);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(651, 650);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            // 
            // BrushButton
            // 
            this.BrushButton.Location = new System.Drawing.Point(857, 280);
            this.BrushButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(136, 73);
            this.BrushButton.TabIndex = 1;
            this.BrushButton.Text = "Кисть";
            this.BrushButton.UseVisualStyleBackColor = true;
            this.BrushButton.Click += new System.EventHandler(this.BrushButton_Click);
            // 
            // RectButton
            // 
            this.RectButton.Location = new System.Drawing.Point(693, 34);
            this.RectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(136, 73);
            this.RectButton.TabIndex = 2;
            this.RectButton.Text = "Прямоугольник";
            this.RectButton.UseVisualStyleBackColor = true;
            this.RectButton.Click += new System.EventHandler(this.RectButton_Click);
            // 
            // СircleButton
            // 
            this.СircleButton.Location = new System.Drawing.Point(693, 130);
            this.СircleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.СircleButton.Name = "СircleButton";
            this.СircleButton.Size = new System.Drawing.Size(136, 73);
            this.СircleButton.TabIndex = 3;
            this.СircleButton.Text = "Окружность";
            this.СircleButton.UseVisualStyleBackColor = true;
            this.СircleButton.Click += new System.EventHandler(this.СircleButton_Click);
            // 
            // StraightButton
            // 
            this.StraightButton.Location = new System.Drawing.Point(859, 130);
            this.StraightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StraightButton.Name = "StraightButton";
            this.StraightButton.Size = new System.Drawing.Size(136, 73);
            this.StraightButton.TabIndex = 4;
            this.StraightButton.Text = "Прямая";
            this.StraightButton.UseVisualStyleBackColor = true;
            this.StraightButton.Click += new System.EventHandler(this.StraightButton_Click);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 10;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.Location = new System.Drawing.Point(693, 375);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(169, 63);
            this.ChangeColorButton.TabIndex = 5;
            this.ChangeColorButton.Text = "Изменить цвет";
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoseThickness
            // 
            this.ChoseThickness.Location = new System.Drawing.Point(693, 469);
            this.ChoseThickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChoseThickness.Maximum = 20;
            this.ChoseThickness.Minimum = 1;
            this.ChoseThickness.Name = "ChoseThickness";
            this.ChoseThickness.Size = new System.Drawing.Size(248, 56);
            this.ChoseThickness.TabIndex = 6;
            this.ChoseThickness.Value = 1;
            this.ChoseThickness.Scroll += new System.EventHandler(this.ChoseThickness_Scroll);
            // 
            // showAllLaysButton
            // 
            this.showAllLaysButton.AutoSize = true;
            this.showAllLaysButton.Location = new System.Drawing.Point(709, 555);
            this.showAllLaysButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllLaysButton.Name = "showAllLaysButton";
            this.showAllLaysButton.Size = new System.Drawing.Size(152, 21);
            this.showAllLaysButton.TabIndex = 7;
            this.showAllLaysButton.TabStop = true;
            this.showAllLaysButton.Text = "Показать все слои";
            this.showAllLaysButton.UseVisualStyleBackColor = true;
            this.showAllLaysButton.CheckedChanged += new System.EventHandler(this.showAllLaysButton_CheckedChanged);
            // 
            // showFirstLayButton
            // 
            this.showFirstLayButton.AutoSize = true;
            this.showFirstLayButton.Location = new System.Drawing.Point(709, 582);
            this.showFirstLayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showFirstLayButton.Name = "showFirstLayButton";
            this.showFirstLayButton.Size = new System.Drawing.Size(183, 21);
            this.showFirstLayButton.TabIndex = 8;
            this.showFirstLayButton.TabStop = true;
            this.showFirstLayButton.Text = "Показать верхний слой";
            this.showFirstLayButton.UseVisualStyleBackColor = true;
            this.showFirstLayButton.CheckedChanged += new System.EventHandler(this.showFirstLayButton_CheckedChanged);
            // 
            // showSecondLayButton
            // 
            this.showSecondLayButton.AutoSize = true;
            this.showSecondLayButton.Location = new System.Drawing.Point(709, 609);
            this.showSecondLayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showSecondLayButton.Name = "showSecondLayButton";
            this.showSecondLayButton.Size = new System.Drawing.Size(185, 21);
            this.showSecondLayButton.TabIndex = 9;
            this.showSecondLayButton.TabStop = true;
            this.showSecondLayButton.Text = "Показать дальний слой";
            this.showSecondLayButton.UseVisualStyleBackColor = true;
            this.showSecondLayButton.CheckedChanged += new System.EventHandler(this.showSecondLayButton_CheckedChanged);
            // 
            // EraserButton
            // 
            this.EraserButton.Location = new System.Drawing.Point(693, 280);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(136, 73);
            this.EraserButton.TabIndex = 10;
            this.EraserButton.Text = "Ластик";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.слойToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItem1.Text = "Выход";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // слойToolStripMenuItem
            // 
            this.слойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьТекущийToolStripMenuItem,
            this.очиститьОбаToolStripMenuItem});
            this.слойToolStripMenuItem.Name = "слойToolStripMenuItem";
            this.слойToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.слойToolStripMenuItem.Text = "Слой";
            // 
            // очиститьТекущийToolStripMenuItem
            // 
            this.очиститьТекущийToolStripMenuItem.Name = "очиститьТекущийToolStripMenuItem";
            this.очиститьТекущийToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.очиститьТекущийToolStripMenuItem.Text = "Очистить текущий";
            this.очиститьТекущийToolStripMenuItem.Click += new System.EventHandler(this.очиститьТекущийToolStripMenuItem_Click);
            // 
            // очиститьОбаToolStripMenuItem
            // 
            this.очиститьОбаToolStripMenuItem.Name = "очиститьОбаToolStripMenuItem";
            this.очиститьОбаToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.очиститьОбаToolStripMenuItem.Text = "Очистить оба";
            this.очиститьОбаToolStripMenuItem.Click += new System.EventHandler(this.очиститьОбаToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.showSecondLayButton);
            this.Controls.Add(this.showFirstLayButton);
            this.Controls.Add(this.showAllLaysButton);
            this.Controls.Add(this.ChoseThickness);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.StraightButton);
            this.Controls.Add(this.СircleButton);
            this.Controls.Add(this.RectButton);
            this.Controls.Add(this.BrushButton);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChoseThickness)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button RectButton;
        private System.Windows.Forms.Button СircleButton;
        private System.Windows.Forms.Button StraightButton;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.TrackBar ChoseThickness;
        private System.Windows.Forms.RadioButton showAllLaysButton;
        private System.Windows.Forms.RadioButton showFirstLayButton;
        private System.Windows.Forms.RadioButton showSecondLayButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьТекущийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьОбаToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

