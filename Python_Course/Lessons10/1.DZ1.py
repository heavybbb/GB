# Задача 44: В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего из 1 столбца. 
# Ваша задача перевести его в one hot вид. 
# Надо это сделать без get_dummies. И надо сделать это без циклов.

from sklearn.preprocessing import OneHotEncoder
import pandas as pd
import random

encoder = OneHotEncoder()

lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})
data.head()
print(data)

encoder_data=encoder.fit_transform(data[['whoAmI']])
print(encoder_data)