import string
import datetime
import random
#1
n = input("Введите вашу фамилию: ")
m = input("Введите оценку которую хотите за экзамен: ")
print(f"Поздравля {n} ваша оценка за экзамен {m}!")

#2
a = int(input("Введите количество чисел: "))
sum = 0
list = []
for i in range(a):
    b = list.append(input("Введите число: "))
    sum = sum + int(list[i])
    i = i + 1

print(list)
print(sum / a)
print(round(sum / a))
print(sum // a)

#3
strCheck = False
upCheck = False
lowCheck = False
numCheck = False
specCheck = False
spec = string.punctuation

while True:
    password = input("Введите пароль: ")
    for i in password:
        if i.isalpha():
            strCheck = True
        if i.isdigit():
            numCheck = True
        if i.isupper():
            upCheck = True
        if i.islower():
            lowCheck = True
        if i in spec:
            specCheck = True
    if len(password) <= 8:
        print("Пароль должен быть больше 8 символов")
    elif len(password) > 20:
        print("Пароль должен быть меньше 20 символов")
    elif strCheck == False:
        print("Пароль содержать буквы")
    elif numCheck == False:
        print("Пароль должен содержать цифры")
    elif specCheck == False:
        print("Пароль должен спец символы")
    elif upCheck == False:
        print("Пароль должен большие буквы")
    elif lowCheck == False:
        print("Пароль должен маленькие буквы")
    else:
        print("Все ок !")
        break
#4
i = 0
sum = 0

while i < 3:
    a = random.randint(1, 24)
    b = random.randint(1, 24)
    c = random.randint(1, 24)

    num = int(input(f"Введите число:  {i + 1}"))
    if num == a or num == b or num == c:
        sum = sum + 1

    print(a,b,c)

    i += 1

if sum < 2:
    print("Вы проиграли")
elif sum >= 2:
    print("Вы выиграли")
#5
a = random.randint(0,7)
cena = random.randint(50, 100)
srok = random.randint(1, 14)

dater = datetime.date.today() - datetime.timedelta(a)
darek = dater + datetime.timedelta(srok)

print(f"Дата изготовления: {dater}")
print(f"Дата конца: {darek}")

if dater == datetime.date.today():
    print(cena)
elif darek < datetime.date.today():
    print(cena * 0)
else:
    print(cena * 0.8)

#6
person_dict = {'person_id': [41, 84, 72],
            'person_name': ['Keanu Reeves', 'Jim Carrey', 'Negro']}
travel_log = { 'travel_id': [101, 102, 105],
               'person_id': [41, 72, 41],
               'country': [ 'USA', 'Japan', 'China'] }

name = input("Введите имя: ")
count = 0
dop_count = 0
for i in range(len(person_dict.get('person_name'))):
    if name == person_dict.get('person_name')[i]:
        for j in range(len(travel_log.get('person_id'))):
            if person_dict.get('person_id')[i] == travel_log.get('person_id')[j]:
                count = count + 1
                dop_count = dop_count + j

if count == 2:
    print("много")
elif count == 1:
    print(travel_log.get('country')[dop_count])
else:
    print("rabotjaga")

#7
bolel = 0
j = 0
datet = datetime.date.today()
markss = []
dater = []

while j < 10:
    marks = [2, 3, 4, 5, 'б', 'н', 'п']
    i = random.randint(0, 6)
    markss.append(marks[i])
    dater.append(datet + datetime.timedelta(1))
    print(marks[i], end=" || ")
    print(datet)
    # print(markss)
    if marks[i] == 'б' and dater[j - 1].month == datetime.date.today().month:
        bolel = bolel + 1
    datet = datet + datetime.timedelta(1)
    j += 1

# print(markss)
# print(dater)
print("Болел:", bolel)
# 8
class Students():
    name = None
    years = None
    group = None

    def __init__(self, name, years, group):
        self.name = name
        self.years = years
        self.group = group

    def __str__(self):
        return f"Студент {self.name} год поступления {self.years} группы {self.group}"

    def generate_marks(self):
        j = 0
        datet = datetime.date.today()
        while j < 10:
            marks = [2, 3, 4, 5, 'б', 'п', 'н']
            i = random.randint(0, 6)
            print(marks[i], end=" || ")
            datet = datet + datetime.timedelta(days=1)
            print(datet, self.name)
            j = j + 1


class Group(Students):
    nameGr = None
    groupr = []

    def __init__(self, nameGr):
        self.nameGr = nameGr

    def add(self, stud):
        self.groupr.append(stud)

    def print_gr(self):
        for i in self.groupr:
            print(i)


stud1 = Students("Andrew Popov", "2005", "ИС-21")
stud2 = Students("Ivan Popov", "2004", "ИС-21")
stud3 = Students("Petrov Popov", "2003", "ИС-21")
# stud1.generate_marks()
# print(stud1)
# print(stud2)
# print(stud3)
group1 = Group("ИС-21")
group1.add(stud1)
group1.add(stud2)
group1.add(stud3)
group1.print_gr()