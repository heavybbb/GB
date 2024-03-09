# Даны два словаря: dictionary_1 = {'a': 300, 'b': 400} и dictionary_2 = {'c': 500, 'd': 600}. 
# Объедините их в один при помощи встроенных функций языка Python.

dictionary_1 = {'a': 300, 'b': 400}
dictionary_2 = {'c': 500, 'd': 600}
dictionary_combine = {}

for key,value in dictionary_2.items():
    dictionary_combine[key]=value
    
for key,value in dictionary_1.items():
    dictionary_combine[key]=value
print(dictionary_combine)

##### Второй метод 
dictionary_combine2 = dictionary_1 | dictionary_2
print(dictionary_combine2)

####### Третий способ
dictionary_3 = dictionary_1.copy()
dictionary_3.update(dictionary_2)
print(dictionary_3)

######### Четвертый способ
dictionary_combine4={**dictionary_1,**dictionary_2}
print(dictionary_combine4)