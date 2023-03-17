VAR correctAnswers = 0
VAR pass = 0
VAR comment = 0
VAR code = 0




~code = 1
aaa
* [0 1 2 3]
~comment = 1
~correctAnswers = correctAnswers + 1
 -> qst2
 
* [i j k l m]
~comment = 0
 -> qst2
 
* [i i i i]
~comment = 0
 -> qst2
 
* [i 1 i l]
~comment = 0
 -> qst2








=== qst2 ===
bbb
~code = 2

* [21.783330]
~comment = 0
 -> qst3

* [21.783331]
~comment = 2
~correctAnswers = correctAnswers + 1
 -> qst3
 
* [21.783332]
~comment = 0
 -> qst3
 
* [21.783334]
~comment = 0
 -> qst3
    
    
    
    
    
    
    
    
=== qst3 ===
ccc
~code = 3

* [2]
~comment = 0
 -> test3
 
* [3]
~comment = 0
 -> test3
 
* [4]
~comment = 3
~correctAnswers = correctAnswers + 1
 -> test3
 
* [5]
~comment = 0
 -> test3
 
 
 === test3 ===
  {correctAnswers < 1 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass | -> qst4 }

 

 
    
    
    
    
     
=== qst4 ===

~code = 4
ddd
* [61105]
~comment = 0
 -> test4
 
* [65445]
~comment = 0
 -> test4
 
* [60000]
~comment = 0
 -> test4
 
* [66454]
~comment = 4
~correctAnswers = correctAnswers + 1
 -> test4
 
 
  === test4 ===
 {correctAnswers < 2 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass |  -> qst5 }
 
 
 
 
 
 
 
 
 
 === qst5 ===

~code = 5
eee
* [calculer : exception : division par zero]
~comment = 5
~correctAnswers = correctAnswers + 1
  -> test5
  
* [exception : division par zero]
~comment = 0
 -> test5
 
 * [ exception :]
 ~comment = 0
  -> test5
  
* [calculer :]
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