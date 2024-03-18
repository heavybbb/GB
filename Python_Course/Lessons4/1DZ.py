# Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# На вход подается 2 числа через пробел: n m
# n - кол-во элементов первого множества.
# m - кол-во элементов второго множества.
# Затем подаются элементы каждого множества через пробел в виде строки. ! Писать input() не надо

# Пример

# На входе:

# var1 = '5 4' # количество элементов первого и второго множества
# var2 = '1 3 5 7 9' # элементы первого множества через пробел
# var3 = '2 3 4 5' # элементы второго множества через пробел

# На выходе:

# 3 5
# from random import randint
# n_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов первого множества: '))))
# print(n_set)
# m_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов второго множества: '))))
# print(m_set)
# s_set = sorted(n_set.intersection(m_set))
# print(*s_set)


# from random import randint
# var1 = '12 2322'
# var2 = '10 21 30 75 50'
# var3 = '10 21 30 40 50'
# number1 = set(var2)
# number2 = set(var3)
# print(number1)
# print(type(number1))
# print(number2)
# sort = sorted(number1.intersection(number2))
# print(*sort)

# var1 = '5 4'
# var2 = '1 3 5 7 9'
# var3 = '2 3 4 5'
# var2=var2.split()
# var3=var3.split()
# number2=[]
# number3=[]

# for number in  var2:
#     if number.isnumeric():
#         number2.append(int(number))
# for number in  var3:
#     if number.isnumeric():
#         number3.append(int(number))
         
#var1 = int(var1)
#var1qw= int(var1[2])
# #print(type(number2[0]))
# print(number2)
# print(number3)
# sort = sorted(number2[0].intersection(number3[2]))
# print(*sort)


#print(var1qw)

var1 = '12 2322'
var2 = '10 21 30 75 50'
var3 = '10 21 30 40 50'

# Convert strings to sets of integers
number1 = set(map(int, var2.split()))
number2 = set(map(int, var3.split()))

sorted = sorted(number1.intersection(number2))
print(*sorted)