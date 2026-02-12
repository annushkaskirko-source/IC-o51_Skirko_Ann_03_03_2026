using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_o51_Skirko_Ann_08_02_2026.Models
{
    // Патерн Singleton
    public class GameManager
    {
        private static GameManager _instance;

        // Єдиний екземпляр класу
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();

                return _instance;
            }
        }

        public Player Player { get; private set; } // гравець
        public List<Quest> Quests { get; private set; } // список квестів

        // Приватний конструктор
        private GameManager()
        {
            Player = new Player("Anna"); // створення гравця
            Quests = new List<Quest>();  // створення списку
        }

        // Додати квест
        public void AddQuest(Quest quest)
        {
            Quests.Add(quest);
        }

        // Завершити квест
        public void CompleteQuest(Quest quest)
        {
            if (quest.Status == QuestStatus.Active)
            {
                quest.Complete(); // змінюємо статус
                Player.AddExperience(quest.ExperienceReward); // додаємо XP
            }
        }
    }
}
