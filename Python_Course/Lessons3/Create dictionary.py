#Создайте словарь, в котором ключами будут числа от 1 до 10, а значениями эти же числа, возведенные в куб.
dictionary={}
value=0
for key in range(1,11):
    value+=1
    dictionary[key]=value**3
print(dictionary)


################### Второй способ
my_dict = {i : i ** 3 for i in range(1, 11)}
print(my_dict)