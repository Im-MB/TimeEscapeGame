VAR correctAnswers = 0
VAR pass = 0
VAR comment = 0
VAR code = 0




~code = 1
aaa22
* [true]
~comment = 1
~correctAnswers = correctAnswers + 1
 -> qst2
 
* [false]
~comment = 0
 -> qst2
 
*[zero]
~comment = 0
 -> qst2
 
* [one]
~comment = 0
 -> qst2








=== qst2 ===
bbb22
~code = 2

* [6 1 2 8]
~comment = 0
 -> qst3

* [2 6 1 8]
~comment = 2
~correctAnswers = correctAnswers + 1
 -> qst3
 
* [8 6 2 1]
~comment = 0
 -> qst3
 
* [8 6 2 6]
~comment = 0
 -> qst3
    
    
    
    
    
    
    
    
=== qst3 ===
ccc22
~code = 3

* [NAN]
~comment = 0
 -> test3
 
* [0.0]
~comment = 0
 -> test3
 
* [infinity]
~comment = 3
~correctAnswers = correctAnswers + 1
 -> test3
 
* [1.1]
~comment = 0
 -> test3
 
 
 === test3 ===
  {correctAnswers < 1 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass | -> qst4 }

 

 
    
    
    
    
     
=== qst4 ===

~code = 4
ddd
* [erreur compilation]
~comment = 0
 -> test4
 
* [erreur execution]
~comment = 0
 -> test4
 
* [exception levée]
~comment = 0
 -> test4
 
* [code correcte]
~comment = 4
~correctAnswers = correctAnswers + 1
 -> test4
 
 
  === test4 ===
 {correctAnswers < 2 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass |  -> qst5 }
 
 
 
 
 
 
 
 
 
 === qst5 ===

~code = 5
eee
* [26.407]
~comment = 5
~correctAnswers = correctAnswers + 1
  -> test5
  
* [26]
~comment = 0
 -> test5
 
 * [26.408]
 ~comment = 0
  -> test5
  
* [26.40]
~comment = 0
   -> test5
    
=== test5 ===
 {correctAnswers > 2:  you win -> youPass | you lost -> youLose }
 
 
 
 
 
 
 
 
   === youLose ===
  ~pass = 4 
  ->  END
 
  === youPass ===
  ~pass = 1 
  ->  END