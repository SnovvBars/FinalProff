## Задача. ##

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Решение. ##
1. Определяем массив заданных значений.
2. Инициализируем счетчик со значением 0.
3. Перебираем в цикле все элементы заданного массива, если число символов в текущем элементе
меньше или равно 3, увеличиваем счетчик на 1.
4. Если после завершения цикла счетчик больше 0, создаем новый массив размерностью в значение счетчика.
в противном случае печатаем "Не найдено!"
5. Снова перебираем все элементы заданного массива в цикле, проверяем количество символов.
Если число символов меньше или равно 3, присваиваем значение текущего элемента элементу нового
массива с индексом значения счетчика. Увеличиваем счетчик на 1.
6. После выхода из цикла выводим на печать элементы нового массива.
7. Финиш

## Блок-схема ##

<code>![block](blockSkhema.jpg "Блок-схема")
</code>