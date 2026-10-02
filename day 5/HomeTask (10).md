
### Home Task 1
Write a C# Sharp program to display the Day properties (year, month, day, hour, minute, second, millisecond etc.).

Напишите программу C# Sharp для отображения свойств дня (год, месяц, день, час, минута, секунда, миллисекунда и т. д.).

Барои намоиш додани хосиятҳои Day (сол, моҳ, рӯз, соат, дақиқа, сония, миллисония ва ғ.) барномаи C# Sharp-ро нависед.

**Expected Output :**
```csharp
year = 2016                                                                      
month = 8                                                                        
day = 16                                                                         
hour = 3                                                                         
minute = 57                                                                      
second = 32                                                                      
millisecond = 11
``` 
---------------------------------

### Home Task 2: Reading Strings 
- Write a program that reads strings from the user until the user inputs the string “end”.
- At that point the program should print how many strings have been read.
- The string “end” should not be included in the number strings read.

- Напишите программу, которая считывает строки от пользователя до тех пор, пока пользователь не введет строку «конец».
- В этот момент программа должна вывести количество прочитанных строк.
- Строка «конец» не должна включаться в считываемые числовые строки.

- Барномае нависед, ки сатрҳоро аз корбар то он даме, ки корбар сатри "охир"-ро ворид кунад, мехонад.
- Дар он лаҳза барнома бояд чоп кунад, ки чанд сатр хонда шудааст.
- Сатри “охир” набояд ба сатри рақамҳои хондашуда дохил карда шавад.

**Input**
```
> I 
> have
> a
> feeling
> that
> I
> have
> written
> this
> wrong
> before
> end 
```
**Output**
```
11
```
**Input**
```
end
```
**Output**
```
0
```
---------------------------------------------------------------

### Home Task 3: Gauge
Create the class **Gauge**. The gauge has the variable **public int value** and **a constructor without parameters.**                                              
Constructor sets the initial value of the meter variable to 0.

The class has following three methods.
Firstly **public void Increase()** grows the value instance variable’s value by one. It does not grow the value beyond five.

Secondly **public void Decrease()** decreases the value instance variable’s value by one. It does not decrease the value to negative values.

Thirdly **public bool Full()** returns **True** if the instance variable value has the value five. Otherwise, it returns **False**.

Give the value ability for get and set: **Make the value public rather than private, and add { get; set; } on the declaring lines!**


Создайте класс **Gauge**. Датчик имеет переменную **public int value** и **конструктор без параметров.**
Конструктор устанавливает начальное значение переменной счетчика равным 0.

Класс имеет следующие три метода.
Во-первых, **public void Enhance()** увеличивает значение переменной экземпляра значения на единицу. Значение не превышает пяти.

Во-вторых, **public void Decrease()** уменьшает значение переменной экземпляра значения на единицу. Это не уменьшает значение до отрицательных значений.

В-третьих, **public bool Full()** возвращает **True**, если значение переменной экземпляра имеет значение пять. В противном случае возвращается **False**.

Предоставьте возможность значения для get и set: ** Сделайте значение общедоступным, а не частным, и добавьте { get; набор; } в объявляющих строках!**

Синфи **Gauge**ро эҷод кунед. Нишондиҳанда дорои тағирёбандаи **public int value** ва **конструктор бидуни параметр мебошад.**
Конструктор арзиши ибтидоии тағирёбандаи метрро ба 0 муқаррар мекунад.

Дар синф се усули зерин мавҷуд аст.
Аввалан **public void Increase()** арзиши тағирёбандаи мисоли арзишро як маротиба зиёд мекунад. Он арзиши беш аз панҷ намеафзояд.

Сониян **public void Decrease()** арзиши тағирёбандаи мисоли арзишро як маротиба коҳиш медиҳад. Он арзишро ба арзишҳои манфӣ кам намекунад.

Сеюм, **public bool Full()** **True**-ро бармегардонад, агар арзиши тағирёбандаи мисол арзиши панҷ дошта бошад. Дар акси ҳол, он **дурӯғ**-ро бармегардонад.

Қобилияти арзишро барои гирифтан ва танзим диҳед: **Арзишро на хусусӣ, балки оммавӣ кунед ва { get; маҷмӯи; } дар сатрхои эълон!**


---------------------------------------------------------------

### Home Task 4 : Overloaded Counter
Implement a class called **Counter**. The class contains a number, whichs value can be increased and decreased.                                                   
The class must have the following constructors.

**public Counter(int startValue)** sets the start value of the counter to startValue.                                               
**public Counter()** sets the start value of the counter to 0.                                                                      
And the following methods and properties.                                                                         

**public int value { get; set; }**                                 
**public void Increase()** increases the value by 1                                    
**public void Decrease()** decreases the value by 1                                                               
**public void Increase(int increaseBy)** increases the value of the counter by the value of increaseBy.                                                                  
If the value of increaseBy is negative, the value of the counter does not change.                                                                                
**public void Decrease(int decreaseBy)** decreases the value of the counter by the value of decreaseBy.                                                        
If the value of decreaseBy is negative, the value of the counter does not change.    

Реализуйте класс **Counter**. Класс содержит число, значение которого можно увеличивать и уменьшать.
Класс должен иметь следующие конструкторы.

**public Counter(int startValue)** устанавливает начальное значение счетчика в startValue.
**public Counter()** устанавливает начальное значение счетчика равным 0.
И следующие методы и свойства.

** общедоступное значение int { get; набор; }**
**public void Increase()** увеличивает значение на 1
**public void Decrease()** уменьшает значение на 1
**public void Increase(int increaseBy)** увеличивает значение счетчика на значение increaseBy.
Если значение увеличенияBy отрицательное, значение счетчика не изменится.
**public void Decrease(int decreaseBy)** уменьшает значение счетчика на значение decreaseBy.
Если значение уменьшенияBy отрицательное, значение счетчика не изменится.

Татбиқи синф бо номи **Counter**. Синф рақамеро дар бар мегирад, ки арзиши онро метавон зиёд ва кам кард.
Синф бояд конструкторҳои зерин дошта бошад.

**Counter public(int startValue)** арзиши ибтидоии ҳисобкунакро ба startValue муқаррар мекунад.
**Counter public()** арзиши оғози ҳисобкунакро ба 0 муқаррар мекунад.
Ва Методхо ва хосиятҳои зерин.

**public int value { даст; маҷмӯи; }**
**void public Increase()** арзишро 1 зиёд мекунад
**public void Decrease()** арзишро 1 кам мекунад
**void public Increase(int increaseBy)** арзиши ҳисобкунакро бо арзиши афзоишиBy зиёд мекунад.
Агар арзиши афзоишиBy манфӣ бошад, арзиши ҳисобкунак тағир намеёбад.
**void public Decrease(int reduceBy)** арзиши ҳисобкунакро бо арзиши коҳишёбӣ коҳиш медиҳад.
Агар арзиши коҳишёбииBy манфӣ бошад, арзиши ҳисобкунак тағир намеёбад.
 


### Home Task 5: Card Payments
In the previous exercise, we created a class called PaymentCard that had methods for eating lunch,                                                            
drinking coffee, and adding money to the card. However, this implementation had a problem.                                                                         
The card knew the prices of the different payments, which meant that any changes in pricing or new items                                                            
being added would require replacing all existing cards with new ones that are aware of the new prices.                                                                        

To solve this problem, we need to make the cards "happy" and only keep track of their balance.                                                                                          
All the intelligence should be in separate objects, payment terminals.        

В предыдущем упражнении мы создали класс PaymentCard, в котором были методы для обеда,
пью кофе и добавляю деньги на карту. Однако в этой реализации была проблема.
Карта знала цены различных платежей, а это означало, что любые изменения цен или новые товары
добавление потребует замены всех существующих карт новыми, которые знают новые цены.

Чтобы решить эту проблему, нам нужно сделать карты «счастливыми» и следить только за их балансом.
Весь интеллект должен быть в отдельных объектах, платежных терминалах.

Дар машқи қаблӣ, мо синферо бо номи PaymentCard таъсис додем, ки усулҳои хӯрдани хӯроки нисфирӯзӣ дошт.
нӯшидани қаҳва, ва илова кардани пул ба корт. Бо вуҷуди ин, ин татбиқ мушкилот дошт.
Корт нархи пардохтҳои гуногунро медонист, ки ин маънои онро дошт, ки ҳама гуна тағирот дар нархгузорӣ ё ашёи нав
илова кардан лозим аст, ки иваз кардани ҳамаи кортҳои мавҷуда бо кортҳои нав, ки аз нархҳои нав огоҳанд.

Барои ҳалли ин мушкилот, мо бояд кортҳоро "хушбахт" кунем ва танҳо баланси онҳоро пайгирӣ кунем.
Тамоми разведка бояд дар объектхои алохида, терминалхои пардохт бошад.

#### Section 1
Let's first implement the "happy" version of the PaymentCard.                                                         
The card should only have the ability to ask for the balance, add money, and take money.                                             
Implement the `TakeMoney` method in the class      

Давайте сначала реализуем «счастливую» версию PaymentCard.
Карта должна иметь возможность только запрашивать баланс, добавлять деньги и снимать деньги.
Реализуйте метод TakeMoney в классе.

Биёед аввал версияи "хушбахт"-и PaymentCard-ро амалӣ кунем.
Корт бояд танҳо қобилияти талаб кардани тавозун, илова кардани пул ва гирифтани пул дошта бошад.
Усули "TakeMoney" -ро дар синф татбиқ кунед

#### Section 2
When visiting a student cafeteria, the customer pays either with cash or with a payment card.                                                                   
The cashier uses a payment terminal to charge the card or to process the cash payment. Let's create a terminal that's suitable for cash payments.      

При посещении студенческой столовой клиент рассчитывается наличными или платежной картой.
Кассир использует платежный терминал для списания средств с карты или обработки наличного платежа. Давайте создадим терминал, подходящий для оплаты наличными.

Ҳангоми боздид аз ошхонаи донишҷӯӣ муштарӣ ё бо пули нақд ё бо корти пардохт пардохт мекунад.
Кассир барои ситонидани корт ё коркарди пули нақд аз терминали пардохт истифода мебарад. Биёед терминалеро созем, ки барои пардохтҳои нақдӣ мувофиқ бошад.

#### Section 3
Let's extend our payment terminal to also support card payments. We are going to create new methods for the terminal.                                               
It receives a payment card as a parameter and decreases its balance by the price of the meal that was purchased.  

Давайте расширим наш платежный терминал, чтобы он также поддерживал платежи по картам. Мы собираемся создать новые методы для терминала.
Он получает в качестве параметра платежную карту и уменьшает ее баланс на стоимость купленного обеда.

Биёед терминали пардохтии худро васеъ кунем, то пардохтҳои кортро низ дастгирӣ кунем. Мо барои терминал усулҳои нав эҷод карданием.
Он ҳамчун параметр корти пардохтро мегирад ва тавозуни худро бо нархи хӯроки харидашуда коҳиш медиҳад.

#### Section 4
Let's create a method for the terminal that can be used to add money to a payment card.                                                                
Recall that the payment that is received when adding money to the card is stored in the register (adding cash).   

Давайте создадим для терминала метод, с помощью которого можно пополнить счет платежной карты.
Напомним, что в регистре сохраняется платеж, который поступает при пополнении карты (пополнение наличных).

Биёед барои терминал як усулеро эҷод кунем, ки метавонад барои илова кардани пул ба корти пардохт истифода шавад.
Ёдовар мешавем, ки пардохте, ки ҳангоми илова кардани пул ба корт гирифта мешавад, дар реестр нигоҳ дошта мешавад (илова кардани пули нақд).

       
