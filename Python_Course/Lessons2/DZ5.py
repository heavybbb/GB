# Задача 2 необязательная
# Имеется список случайных целых чисел. 
# Создайте список, в который попадают числа, описывающие максимальную сплошную 
# возрастающую последовательность. Порядок элементов менять нельзя.
# Одно число - это не последовательность.

# Пример:

# [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

# [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

# [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8

list1 = [ 25, 22, 23, 8, 7, 24, 7]
list2=[]
nr=list1[0]
x=0
n=0
y=0
count=0
list1.sort()
print(list1)

for n in list1:
    #x+=1
    if list1[x] > range(len(list1[n])):
        
        x+=1
        list2.append([n])
       
        if list1[count] > 1:
             count+=1
             print(list1)
             print (count)
    















# for nr in range(len(list1)):
#     x=list1[nr]
#     #print(list1[nr])
#     x=x+1
#     for y in range(len(list1)):
#         if x== list1[y-1] :
#             list2.append(y)
#             print(list2)
#         else:
#             continue
#         #print(list2[y])
       
#            # print(list1)