using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_o51_Skirko_Ann_08_02_2026.Models
{
    // Статус квесту
    public enum QuestStatus
    {
        Active,      // активний
        Completed    // виконаний
    }

    // Категорія квесту
    public enum QuestCategory
    {
        Study,
        Work,
        Health,
        Personal
    }

    // Складність
    public enum QuestDifficulty
    {
        Easy,
        Medium,
        Hard
    }

    // Клас квесту
    public class Quest
    {
        public string Name { get; private set; }          // назва
        public string Description { get; private set; }   // опис
        public QuestCategory Category { get; private set; }   // категорія
        public QuestDifficulty Difficulty { get; private set; } // складність
        public QuestStatus Status { get; private set; }   // статус

        public int ExperienceReward { get; private set; } // нагорода XP

        // Конструктор
        public Quest(string name,
                     string description,
                     QuestCategory category,
                     QuestDifficulty difficulty)
        {
            Name = name;
            Description = description;
            Category = category;
            Difficulty = difficulty;

            Status = QuestStatus.Active; // по замовчуванню активний

            ExperienceReward = CalculateReward(); // розрахунок XP
        }

        // Розрахунок нагороди
        private int CalculateReward()
        {
            switch (Difficulty)
            {
                case QuestDifficulty.Easy: return 20;
                case QuestDifficulty.Medium: return 50;
                case QuestDifficulty.Hard: return 100;
                default: return 0;
            }
        }

        // Виконати квест
        public void Complete()
        {
            Status = QuestStatus.Completed;
        }

        // Як буде виглядати в ListBox
        public override string ToString()
        {
            return $"{Name} | {Category} | {Difficulty}";
        }
    }
}
