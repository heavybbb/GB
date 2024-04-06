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
#print(data)

encoded_lst=encoder.fit_transform(data[['whoAmI']])
#print(encoded_lst)

encoded_data = pd.DataFrame(encoded_lst.toarray(), columns=encoder.get_feature_names_out(['whoAmI']))
data_encoded = pd.concat([data, encoded_data], axis=1)
data_encoded.drop('whoAmI', axis=1, inplace=True)
print(data_encoded)