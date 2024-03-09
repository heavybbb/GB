y=8
x=8
block=0.625
r=0
i=0
itog=0
for i in range(y):
    r=x/block
    x=x-1
    itog=r+itog
    print(r)
print(itog)