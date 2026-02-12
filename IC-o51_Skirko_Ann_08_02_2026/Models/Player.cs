using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC_o51_Skirko_Ann_08_02_2026.Models
{
    // Клас гравця
    public class Player
    {
        // Приватні поля (інкапсуляція)
        private string _name;          // зберігає ім'я
        private int _experience;       // зберігає досвід

        public const int XP_PER_LEVEL = 100; // Скільки XP потрібно на 1 рівень

        // Властивість Name з перевіркою
        public string Name
        {
            get => _name; // повертає ім'я
            set
            {
                // перевірка на пусте значення
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Iм'я не може бути порожнiм.");

                _name = value;
            }
        }

        // Рівень доступний тільки для читання
        public int Level { get; private set; }

        // Досвід з автоматичним перерахунком рівня
        public int Experience
        {
            get => _experience;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Досвiд не може бути негативним.");

                _experience = value;

                // Формула рівня
                Level = _experience / XP_PER_LEVEL + 1;
            }
        }

        // Конструктор
        public Player(string name)
        {
            Name = name;
            Experience = 0; // стартовий досвід
        }

        // Метод додавання досвіду
        public void AddExperience(int xp)
        {
            if (xp > 0)
                Experience += xp;
        }

        // Відсоток до наступного рівня
        public int GetProgressPercent()
        {
            return (Experience % XP_PER_LEVEL) * 100 / XP_PER_LEVEL;
        }
    }
}
