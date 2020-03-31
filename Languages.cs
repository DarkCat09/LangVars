using System;
using System.Collections.Generic;

namespace MyProgram
{
    public class Languages
    {
        public static Dictionary<string, string> Rus = new Dictionary<string, string>() {
            {"Настройки", "Настройки"},
            {"Выберите язык", "Выберите язык"},
            {"Выберите сложность", "Выберите сложность"},
            {"Новичок", "Новичок"},
            {"Любитель", "Любитель"},
            {"Профи", "Профи"}
        };

        public static Dictionary<string, string> Eng = new Dictionary<string, string>() {
            {"Настройки", "Settings"},
            {"Выберите Язык", "Select language"},
            {"Выберите язык", "Select tongue"},
            {"Выберите сложность", "Select difficulty"},
            {"Новичок", "Beginner"},
            {"Любитель", "Amateur"},
            {"Профи", "Prof"}
        };

        public static Dictionary<string, string> Ukr = new Dictionary<string, string>()
        {
            {"Настройки", "Налаштування"},
            {"Выберите Язык", "Виберіть мову"},
            {"Выберите язык", "Виберіть язик"},
            {"Выберите сложность", "Виберіть складність"},
            {"Новичок", "Новачок"},
            {"Любитель", "Любитель"},
            {"Профи", "Профі"}
        };
    }
}
