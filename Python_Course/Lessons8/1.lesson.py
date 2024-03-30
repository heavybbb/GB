#sp=[1,2,3,4,5,6,7,8,11,38,50,52,53]
# for i in range(len(sp)):
#     if sp[i]%2==0:
#         print(sp[i], sp[i]**2)


# res=list()
# for i in sp:
#     if i %2==0:
#         res.append((i, i**2))
# print(res)



def select(f, col):
    return [f(x) for x in col]

def where(f,col):
    return [x for x in col if f(x)]
sp=[1,2,3,4,5,6,7,8,11,38,50,52,53]
res = select(int, sp)
print(res) # список
res =where (lambda x:x%2==0, res)
print(res) # только четные
res = list(select(lambda x: (x, x**2), res))
print(res) #  список


