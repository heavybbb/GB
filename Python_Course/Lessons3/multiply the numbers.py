#Дан словарь с числовыми значениями. Необходимо их все перемножить и вывести на экран.

numbers=[1,2,5,3,8]
multiply=1
for i in range(len(numbers)):
    multiply*=numbers[i]
print(multiply)



########## Второй пример
my_dictionary = {'data1': 375, 'data2': 567, 'data3': -37, 'data4': 21}
result = 1
for key in my_dictionary:    
    result = result * my_dictionary[key]
print(result)