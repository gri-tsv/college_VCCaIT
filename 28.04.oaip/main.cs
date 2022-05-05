using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    ///  выводящий текст "Hello, World!"
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main() является
        /// входной точкой работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            // Форматируем шапку программы
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("********************");
            Console.WriteLine("**** Мой проект ****");
            Console.WriteLine("********************");
            // Основная программа
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hello, World!");

            // Ожидание нажатия клавиши Enter перед завершением работы
            Console.ReadLine();
        }
    }
}
/*<c>	        Помечает текст в строке как код
<code>	        Помечает множество строк как код
<example>	    Помечает пример кода
<exception>	    Документирует класс исключения (синтаксис проверяется компилятором)
<include>	    Включает комментарии из другого файла документации (синтаксис проверяется компилятором)
<list>	        Вставляет список в документацию
<param>	        Помечает параметр метода (синтаксис проверяется компилятором)
<paramref>	    Указывает, что слово является параметром метода (синтаксис проверяется компилятором)
<permission>	Документирует доступ к члену (синтаксис проверяется компилятором)
<remarks>	    Добавляет описание члена
<returns>	    Документирует возвращаемое методом значение
<see>	        Представляет перекрестную ссылку на другой параметр (синтаксис проверяется компилятором)
<seealso>	    Представляет раздел "see also" ("смотреть также") в описании (синтаксис проверяется компилятором)
<summary>	    Представляет краткий итог о типе или члене
<value>	        Описывает свойство
 */
