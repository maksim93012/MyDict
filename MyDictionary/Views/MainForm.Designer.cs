namespace MyDictionary
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСловоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСловоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросСчетчиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разборТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.rus_eng_radio = new System.Windows.Forms.RadioButton();
            this.eng_rus_radio = new System.Windows.Forms.RadioButton();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.rightAswerLabel = new System.Windows.Forms.Label();
            this.toDayLabel = new System.Windows.Forms.Label();
            this.wordsStudiedLabel = new System.Windows.Forms.Label();
            this.wordsInDictLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.словарьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйСловарьToolStripMenuItem,
            this.загрузитьСловарьToolStripMenuItem,
            this.удалитьСловарьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйСловарьToolStripMenuItem
            // 
            this.новыйСловарьToolStripMenuItem.Name = "новыйСловарьToolStripMenuItem";
            this.новыйСловарьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйСловарьToolStripMenuItem.Text = "Создать";
            this.новыйСловарьToolStripMenuItem.Click += new System.EventHandler(this.новыйСловарьToolStripMenuItem_Click);
            // 
            // загрузитьСловарьToolStripMenuItem
            // 
            this.загрузитьСловарьToolStripMenuItem.Name = "загрузитьСловарьToolStripMenuItem";
            this.загрузитьСловарьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьСловарьToolStripMenuItem.Text = "Открыть";
            this.загрузитьСловарьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСловарьToolStripMenuItem_Click);
            // 
            // удалитьСловарьToolStripMenuItem
            // 
            this.удалитьСловарьToolStripMenuItem.Name = "удалитьСловарьToolStripMenuItem";
            this.удалитьСловарьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьСловарьToolStripMenuItem.Text = "Удалить";
            this.удалитьСловарьToolStripMenuItem.Click += new System.EventHandler(this.удалитьСловарьToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСловоToolStripMenuItem,
            this.удалитьСловоToolStripMenuItem,
            this.сбросСчетчиковToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьСловоToolStripMenuItem
            // 
            this.добавитьСловоToolStripMenuItem.Name = "добавитьСловоToolStripMenuItem";
            this.добавитьСловоToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.добавитьСловоToolStripMenuItem.Text = "Добавить слово";
            this.добавитьСловоToolStripMenuItem.Click += new System.EventHandler(this.добавитьСловоToolStripMenuItem_Click);
            // 
            // удалитьСловоToolStripMenuItem
            // 
            this.удалитьСловоToolStripMenuItem.Name = "удалитьСловоToolStripMenuItem";
            this.удалитьСловоToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удалитьСловоToolStripMenuItem.Text = "Удалить слово";
            this.удалитьСловоToolStripMenuItem.Click += new System.EventHandler(this.удалитьСловоToolStripMenuItem_Click);
            // 
            // сбросСчетчиковToolStripMenuItem
            // 
            this.сбросСчетчиковToolStripMenuItem.Name = "сбросСчетчиковToolStripMenuItem";
            this.сбросСчетчиковToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сбросСчетчиковToolStripMenuItem.Text = "Сброс счетчиков";
            this.сбросСчетчиковToolStripMenuItem.Click += new System.EventHandler(this.сбросСчетчиковToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить ";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.показатьToolStripMenuItem,
            this.разборТекстаToolStripMenuItem});
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.словарьToolStripMenuItem.Text = "Словарь";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить информацию";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.показатьToolStripMenuItem_Click);
            // 
            // разборТекстаToolStripMenuItem
            // 
            this.разборТекстаToolStripMenuItem.Name = "разборТекстаToolStripMenuItem";
            this.разборТекстаToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.разборТекстаToolStripMenuItem.Text = "Разбор текста";
            this.разборТекстаToolStripMenuItem.Click += new System.EventHandler(this.разборТекстаToolStripMenuItem_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionLabel.Location = new System.Drawing.Point(15, 124);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(380, 50);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(380, 50);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "-";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rus_eng_radio
            // 
            this.rus_eng_radio.AutoSize = true;
            this.rus_eng_radio.Checked = true;
            this.rus_eng_radio.Location = new System.Drawing.Point(6, 26);
            this.rus_eng_radio.Name = "rus_eng_radio";
            this.rus_eng_radio.Size = new System.Drawing.Size(123, 17);
            this.rus_eng_radio.TabIndex = 2;
            this.rus_eng_radio.TabStop = true;
            this.rus_eng_radio.Text = "Русско-английский";
            this.rus_eng_radio.UseVisualStyleBackColor = true;
            // 
            // eng_rus_radio
            // 
            this.eng_rus_radio.AutoSize = true;
            this.eng_rus_radio.Location = new System.Drawing.Point(6, 49);
            this.eng_rus_radio.Name = "eng_rus_radio";
            this.eng_rus_radio.Size = new System.Drawing.Size(99, 17);
            this.eng_rus_radio.TabIndex = 3;
            this.eng_rus_radio.Text = "Англо-русский";
            this.eng_rus_radio.UseVisualStyleBackColor = true;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.rightAswerLabel);
            this.infoBox.Controls.Add(this.toDayLabel);
            this.infoBox.Controls.Add(this.wordsStudiedLabel);
            this.infoBox.Controls.Add(this.wordsInDictLabel);
            this.infoBox.Location = new System.Drawing.Point(13, 28);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(200, 93);
            this.infoBox.TabIndex = 4;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Словарь: ";
            // 
            // rightAswerLabel
            // 
            this.rightAswerLabel.AutoSize = true;
            this.rightAswerLabel.Location = new System.Drawing.Point(6, 66);
            this.rightAswerLabel.Name = "rightAswerLabel";
            this.rightAswerLabel.Size = new System.Drawing.Size(125, 13);
            this.rightAswerLabel.TabIndex = 3;
            this.rightAswerLabel.Text = "Правильных ответов: 0";
            // 
            // toDayLabel
            // 
            this.toDayLabel.AutoSize = true;
            this.toDayLabel.Location = new System.Drawing.Point(7, 51);
            this.toDayLabel.Name = "toDayLabel";
            this.toDayLabel.Size = new System.Drawing.Size(100, 13);
            this.toDayLabel.TabIndex = 2;
            this.toDayLabel.Text = "Сегодня задано: 0";
            // 
            // wordsStudiedLabel
            // 
            this.wordsStudiedLabel.AutoSize = true;
            this.wordsStudiedLabel.Location = new System.Drawing.Point(7, 36);
            this.wordsStudiedLabel.Name = "wordsStudiedLabel";
            this.wordsStudiedLabel.Size = new System.Drawing.Size(87, 13);
            this.wordsStudiedLabel.TabIndex = 1;
            this.wordsStudiedLabel.Text = "Слов изучено: ?";
            // 
            // wordsInDictLabel
            // 
            this.wordsInDictLabel.AutoSize = true;
            this.wordsInDictLabel.Location = new System.Drawing.Point(7, 20);
            this.wordsInDictLabel.Name = "wordsInDictLabel";
            this.wordsInDictLabel.Size = new System.Drawing.Size(98, 13);
            this.wordsInDictLabel.TabIndex = 0;
            this.wordsInDictLabel.Text = "Слов в словаре: ?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rus_eng_radio);
            this.groupBox1.Controls.Add(this.eng_rus_radio);
            this.groupBox1.Location = new System.Drawing.Point(228, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип задания";
            // 
            // inputAnswer
            // 
            this.inputAnswer.Location = new System.Drawing.Point(12, 195);
            this.inputAnswer.Name = "inputAnswer";
            this.inputAnswer.Size = new System.Drawing.Size(320, 20);
            this.inputAnswer.TabIndex = 6;
            this.inputAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My dict 1.75";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСловоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСловоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросСчетчиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton rus_eng_radio;
        private System.Windows.Forms.RadioButton eng_rus_radio;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label toDayLabel;
        private System.Windows.Forms.Label wordsStudiedLabel;
        private System.Windows.Forms.Label wordsInDictLabel;
        private System.Windows.Forms.Label rightAswerLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разборТекстаToolStripMenuItem;
    }
}