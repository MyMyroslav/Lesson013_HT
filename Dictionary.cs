using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] value2 = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; value2[0] = "книга(Р)";
            key[1] = "ручка"; value[1] = "pen"; value2[1] = "ручка(Р)";
            key[2] = "сонце"; value[2] = "sun"; value2[2] = "солнце";
            key[3] = "яблуко"; value[3] = "apple"; value2[3] = "яблоко";
            key[4] = "стіл"; value[4] = "table"; value2[4] = "стол";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || value[i] == index || value2[i] == index)
                        return key[i] + "-" + value[i] + "-" + value2[i];
                return string.Format("{0} - нема перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + "-" + value[index] + value2[index];
                else
                    return "Спроба звернення за Межі масиву.";
            }
        }
    }
}