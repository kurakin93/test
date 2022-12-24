// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Задаем массив строки.

string[] arr =  {"Hello","am",
                     "ee",
                     "ohh",
                     "is",
                     "mah!",
                     "Kitteh","I'm 1337",
                     "Your the machine, I'm the human.",
                     "Fire your own laser.",
                     "Shut up noob.",
                     "Luk, I am your father.",
                     "Kitteh","Orly?",
                     "I was made in C#.",
                     "Randomness!",
                     "Are you sure?",
                     "Yeah, me too.",
                     "What are you talking about?",
                     "Kids these days","I know right?",
                     "Icecream is good.",
                     "#include i<ostream>",
                     "Man, I'm bored.",
                     "Just shut up will ya?",
                     "Are you sure?","Yeah!",
                     "As",
                     "egg", "happy",
                     "You made me angry",
                     "Uh",
                     "What is wrong with you?",
                     "Oog","733","Blobbeh",
                     "Turtlegiant",
                     "If","And","Or",
                     "day",
                     "I'm truly random.",
                     "Are you?",
                     "I'm a pretty smart AI.",
                     "Yarly.","Kitteh Behind Yeh!.",
                     "Man I'm bored","Your not making any sense",
                     "Never!!!","lol",
                     "Rofl","I'm hungry","My food!"};


void PrintArraySorting(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] SortingArray(string[] arr)
{
    string[] sortingArray = new string[arr.GetLength(0)];
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3)
        {
            sortingArray[temp] = arr[i];
            temp++;
        }
    }
    return sortingArray;
}

Console.WriteLine("Выводим отсортированный массив: ");
string[] sortingArray = SortingArray(arr);
PrintArraySorting(sortingArray);