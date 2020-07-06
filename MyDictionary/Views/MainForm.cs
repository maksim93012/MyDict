using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyDictionary
{
    public partial class MainForm : Form
    {
        DictionaryManager manager;
        public MainForm()
        {
            manager = new DictionaryManager();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        void UpdateInfo()
        {
            infoBox.Text = "Словарь: " + manager.FilePath;
            wordsInDictLabel.Text = "Слов в словаре: " + manager.ItemsCount;
            wordsStudiedLabel.Text = "Слов изучено: " + manager.Studied;
            toDayLabel.Text = "Сегодня задано: " + manager.AskedToDay;
            rightAswerLabel.Text = "Правильных ответов: " + manager.AnsweredToDay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                button1.Text = "Стоп";
                Quest();
            }
            else
            {
                button1.Text = "Старт";
                QuestionLabel.Text = "-";
                inputAnswer.Text = "";
                inputAnswer.BackColor = Color.White;
                manager.CancelQuestion();
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            inputAnswer.BackColor = Color.White;
            if (e.KeyCode == Keys.Enter && !manager.GameStop)
            {
                if (manager.Check(QuestionLabel.Text, inputAnswer.Text))
                {
                    inputAnswer.Text = "";
                    Quest();
                }
                else
                {
                    inputAnswer.BackColor = Color.FromArgb(200, 55, 34);
                    MessageBox.Show($"Неверно! ({manager.QuestEnglish} - {manager.QuestRussian})");
                }
                UpdateInfo();
            }
        }

        private void Quest()
        {
            string quest = manager.GetQuestion(rus_eng_radio.Checked);
            if (quest != null) QuestionLabel.Text = quest;
            else MessageBox.Show("Не найдено слов для изучения");
        }

        private void добавитьСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InsertForm(manager).Show();
        }

        private void удалитьСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteForm(manager).Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void сбросСчетчиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.ResetStat();
            UpdateInfo();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Словарь {manager.FilePath} будет полностью очищен!",
                "Внимание!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                manager.ClearFile();
            UpdateInfo();
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DictionaryForm(manager).Show();
        }

        private void удалитьСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Файл {manager.FilePath} будет полностью удален!",
                "Внимание!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                manager.DeleteFile();
            UpdateInfo();
        }

        private void загрузитьСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл словаря";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.ShowDialog();
            manager.OpenFile(openFileDialog.SafeFileName);
            UpdateInfo();
        }

        private void разборТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TextForm(manager).Show();
        }

        private void новыйСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewFileForm(manager).Show();
        }
    }
}
