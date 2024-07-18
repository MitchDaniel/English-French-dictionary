using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class EnglishFrancheDictionary
    {
        Dictionary<string, List<string>> _englishFrancheDictionary = new Dictionary<string, List<string>>();

        public void AddWord(string englishWord, params string[] frenchWords)
        {
            for (int i = 0; i < frenchWords.Length; i++)
            {
                frenchWords[i] = frenchWords[i].ToLower();
            }
            _englishFrancheDictionary.Add(englishWord.ToLower(), frenchWords.ToList());
        }

        public void AddNewTranslation(string englishWord, params string[] frenchWords)
        {
            for (int i = 0; i < frenchWords.Length; i++)
            {
                frenchWords[i] = frenchWords[i].ToLower();
            }
            foreach (var word in _englishFrancheDictionary)
            {
                if (word.Key == englishWord.ToLower())
                {
                    word.Value.AddRange(frenchWords.ToList());
                }
            }
        }

        public void DeleteEnglishWord(string englishWord)
        {
            foreach (var word in _englishFrancheDictionary)
            {
                if (word.Key == englishWord.ToLower())
                {
                    _englishFrancheDictionary.Remove(word.Key);
                    return;
                }
            }
            throw new Exception("English word not found in dictionary");
        }

        public void DeleteTranslation(string englishWord, string frenchWord)
        {
            foreach (var word in _englishFrancheDictionary)
            {
                if (word.Key == englishWord.ToLower())
                {
                    word.Value.Remove(frenchWord);
                    return;
                }
            }
            throw new Exception("Franch translation not found in dictionary");
        }

        public string[] GetFranchTranslation(string englishWord)
        {
            if (!_englishFrancheDictionary.TryGetValue(englishWord, out List<string>? result)) // что оно хочет от меня?
            {
                throw new Exception("English word not found in dictionary");
            }
            return result.ToArray();
        }

        public void Print()
        {
            foreach (var item in _englishFrancheDictionary)
            {
                Console.Write($"English: {item.Key}\t\t");
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < item.Value.Count - 1; i++)
                {
                    stringBuilder.Append($"{item.Value[i]}, ");
                }
                stringBuilder.Append($"{item.Value[^1]}.");
                Console.Write($"Frache:\t{stringBuilder.ToString()}");
                Console.WriteLine();
            }
        }

        public void EditEnglishWord(string oldEnglishWord, string newEnglishWord)
        {
            if(!_englishFrancheDictionary.ContainsKey(oldEnglishWord))
            {
                throw new Exception("English word not found in dictionary");
            }
            List<string> temp = _englishFrancheDictionary[oldEnglishWord];
            _englishFrancheDictionary.Remove(newEnglishWord);
            AddNewTranslation(newEnglishWord, temp.ToArray());
        }
    }
}

/*
Создайте приложение "Англо-французский словарь". Необходимо
хранить следующую информацию
-Слово на английском языке + 
-Варианты перевода на французский +
для хранения информации используйте Dictionry<T>.
Приложение должно предоставлять такую функциональность:
-добавление слова и вариантов перевода +
-удаление слова +
-удаление варианта перевода +
-изменение слова ??????????????
-изменение варианта перевода ???????????????
-поиск перевода слова +
 */