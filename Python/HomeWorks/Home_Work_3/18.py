# Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

# *Пример:*

# 5
#     1 2 3 4 5
#     6
#     -> 5

n = int(input('Введите количество элемнтов в массиве: '))
import random
a = []
for i in range(n):
    arr = random.randint(1, 9) # создаем рандомные числа в диапозоне от 1 до 9
    a.append(arr) # каждую итерацию добавляем числа в строку "a"
print(a)

x = int(input('Введите искомое число: '))
res = a[0] # Наиболее близкое число массива к входящему х
for i in a:
    if abs(i - x) < abs(res - x):
        res = i

print(f'Искомое число {x} наиболее близко к числу {res}') # выводим количество вхождений числа x в массив