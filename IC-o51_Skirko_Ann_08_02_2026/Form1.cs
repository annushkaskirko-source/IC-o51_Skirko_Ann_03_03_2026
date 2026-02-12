using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IC_o51_Skirko_Ann_08_02_2026.Models;

namespace IC_o51_Skirko_Ann_08_02_2026
{
    public partial class Form1 : Form
    {
        private GameManager gameManager; // посилання на менеджер гри

        public Form1()
        {
            InitializeComponent();

            gameManager = GameManager.Instance;

            // Заповнюємо ComboBox значеннями enum
            categoryComboBox.DataSource = Enum.GetValues(typeof(QuestCategory));
            difficultyComboBox.DataSource = Enum.GetValues(typeof(QuestDifficulty));

            UpdateStats();
        }

        // Обробник кнопки "Додати квест"
        private void addQuestButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(questTextBox.Text))
            {
                MessageBox.Show("Введіть назву квесту");
                return;
            }

            Quest quest = new Quest(
                questTextBox.Text,
                "Без опису",
                (QuestCategory)categoryComboBox.SelectedItem,
                (QuestDifficulty)difficultyComboBox.SelectedItem
            );

            gameManager.AddQuest(quest);
            questListBox.Items.Add(quest);

            questTextBox.Clear();
        }

        // Обробник кнопки "Виконати квест"
        private void completeQuestButton_Click(object sender, EventArgs e)
        {
            if (questListBox.SelectedItem == null)
            {
                MessageBox.Show("Оберіть квест");
                return;
            }

            Quest selectedQuest = (Quest)questListBox.SelectedItem;

            gameManager.CompleteQuest(selectedQuest);
            questListBox.Items.Remove(selectedQuest);

            UpdateStats();
        }

        // Метод оновлення рівня та XP
        private void UpdateStats()
        {
            levelLabel.Text = $"Рівень: {gameManager.Player.Level}";
            xpLabel.Text = $"XP: {gameManager.Player.Experience}";
            xpProgressBar.Value = gameManager.Player.GetProgressPercent();
        }
    }
}
