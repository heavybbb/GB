from random import random


CLASS_1 =10
def show_avg_value(sp):
    avg=sum(sp) / len(sp)
    print(avg)

# def calc_avg_value(sp):
#      avg=sum(sp) / len(sp)
#      return avg
 
 


def calc_avg_value(sp: list) -> float:
     avg=sum(sp) / len(sp)
     return avg
 
qwe = [10,1,3,45,3,456,8]

show_avg_value(qwe)
print(calc_avg_value(qwe))


tqw = tuple(qwe)
print(calc_avg_value(tqw))
 