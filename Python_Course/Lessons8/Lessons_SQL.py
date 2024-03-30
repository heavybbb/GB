import sqlite3 as sl
from easygui import *
# подключение к БД, если БД нет, то она создается
conn = sl.connect("test_evening.db")
cur = conn.cursor()
# Создаем таблицу users с колонками KEY,name,surname
cur.execute("""
            CREATE TABLE IF NOT EXISTS users
            (
            id INTEGER PRIMARY KEY,
            name TEXT,
            surname TEXT
            );
            """)

def select_all():
    cur.execute("SELECT * FROM users;")
    return cur.fetchall()

def add_values():
     cur.execute("INSERT INTO users VALUES (7,'Ваня','Петров');")
    # cur.execute("INSERT INTO users VALUES (4,'Сергей','Сергеев');")
add_values()
     
choice = choicebox("Выберите запрос", "Главная форма", 
                    ['Все записи', "Только Ваня"])

if choice == "Все записи":
    msg = str(select_all())
    msgbox(msg, "Результат запроса")
if choice == "Только Ваня":
    msg = str(select_ivan())
    msgbox(msg, "Результат запроса")
# conn.commit()
# conn.close()