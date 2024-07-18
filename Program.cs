namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnglishFrancheDictionary englishFrancheDictionary = new EnglishFrancheDictionary();
            englishFrancheDictionary.AddWord("bank", "banque", "rive");
            englishFrancheDictionary.AddWord("letter", "lettre", "lettre");
            englishFrancheDictionary.AddWord("ball", "balle", "bal");
            englishFrancheDictionary.AddWord("bat", "chauve-souris", "batte");
            englishFrancheDictionary.AddWord("bark", "écorce", "aboiement");
            englishFrancheDictionary.AddWord("right", "droit", "droite");
            englishFrancheDictionary.AddWord("trip", "voyage", "trébuchement");

            englishFrancheDictionary.Print();
            Console.WriteLine();
            englishFrancheDictionary.DeleteTranslation("bank", "rive");
            englishFrancheDictionary.Print();
            Console.WriteLine();
            englishFrancheDictionary.AddNewTranslation("bank", "rive");
            englishFrancheDictionary.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Delete English word");
            englishFrancheDictionary.DeleteEnglishWord("Bank");
            englishFrancheDictionary.Print();




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
-удаление слова ???????????????
-удаление варианта перевода +
-изменение слова ??????????????
-изменение варианта перевода ???????????????
-поиск перевода слова ???????????
 */