# Требуется найти в массиве list_1 самый близкий по значению элемент к заданному числу k 
# и вывести его.
# Считать, что такой элемент может быть только один. Если значение k 
# совпадает с этим элементом - выведите его.
list_1 = [2, 4, 1, 6, 8, 2, 9, 3, 2, 5]
k = 3
# q=0
# w=0
# list_1.append(k)
# list_1.append(23132)
# list_1.sort()
# ind1=list_1.index(k)
# #print(list_1)
# #print (ind1)
# num1=list_1[ind1-1]
# num2=list_1[ind1+1]
# r=num1
# t=num2
# # for i in range(len(list_1)):
# #     print(i,list_1[i])
# #print("предыдущее число 1: ",num1)
# #print("Следующее число 2: ", num2)
# while r<k:
#     r=r+1
#     q=q+1
# while t>k:
#     t=t-1
#     w=w+1
# if k-q > k-w:
#     print(num1)
# else:
#     print(num2)

####### Решение учителя ##############
m = abs(k - list_1[0])  # модуль числа
number = list_1[0]
for i in range(1, len(list_1)):
    if m > abs(list_1[i] - k):
        m = abs(list_1[i] - k)
        number = list_1[i]
print(number)