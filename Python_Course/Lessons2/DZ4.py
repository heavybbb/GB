# задача 1 необязательная

# Валентина прогуляла лекцию по математике.
# Преподаватель решил подшутить над нерадивой студенткой и
# попросил ее на практическом занятии перечислить все положительные делители некоторых целых чисел.
# Для несложных примеров студентка быстро нашла решения (для числа 6 это: 1, 2, 3, 6; а для числа 16 это: 1, 2, 4, 8, 16), но этим все не закончилось.
# На домашнее задание ей дали варианты посложнее: 23436, 190187200, 380457890232.
# •
# Решить такое вручную, как вы понимаете, практически нереально.
# Вот Валентина и обратилась к вам за помощью.
# Помогите ей.
# Постарайтесь найти самое оптимальное решение.
# Результат представьте в виде списка (не забудьте отсортировать по возрастанию).
number=int(input('Введите число: '))
list_1= []
i=int(0)
y=0
for i in range(number):
    y+=1
    number2=number/y
    #print(number2)
    if number2%2==0:
        list_1.append(int(number2))
        list_1.sort()
print(f'делители числа {number} ',(list_1))