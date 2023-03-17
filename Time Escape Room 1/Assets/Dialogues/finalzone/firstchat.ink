VAR correctAnswers = 0
VAR pass = 0
VAR comment = 0




L'age de la terre est :
* [4.54 Billions années]
~comment = 11
~correctAnswers = correctAnswers + 1
 -> qst2
* [560.2 Millions années]
~comment = 0
 -> qst2
* [5.2 Millions années]
~comment = 0
 -> qst2
* [230 Billions années]
~comment = 0
 -> qst2








=== qst2 ===

Il y a 65 Ma d'années, il y a eu une crise qui a entraîné...
* [La disparition de tous les dinosaures]
~comment = 0
 -> qst3

* [La disparition de la plupart des dinosaures]
~comment = 2
~correctAnswers = correctAnswers + 1
 -> qst3
* [La disparition de certains dinosaures]
~comment = 0
 -> qst3
* [La disparition des mammifères]
~comment = 0
 -> qst3
    
    
    
    
    
    
    
    
=== qst3 ===

Quand est apparu du dioxygène dans l'atmosphère ?
* [Il y a 13 milliards d'années]
~comment = 0
 -> test3
* [Il y a 4 500 millions d'années]
~comment = 0
 -> test3
* [Il y a 2 500 millions d'années]
~comment = 3
~correctAnswers = correctAnswers + 1
 -> test3
* [Il y a 1 milliard d'années]
~comment = 0
 -> test3
 
 
 === test3 ===
  {correctAnswers < 1 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass | -> qst4 }

 

 
    
    
    
    
     
=== qst4 ===

Qu'est-ce qu'un fossile ?
* [Reste d'un dinosaure sous terre]
~comment = 0
 -> test4
* [Reste d'un mammifère sous terre]
~comment = 0
 -> test4
* [Reste d'une végétation conservé dans le sol]
~comment = 0
 -> test4
* [Reste d'un organisme conservé dans les roches sédimentaires]
~comment = 4
~correctAnswers = correctAnswers + 1
 -> test4
 
 
  === test4 ===
 {correctAnswers < 2 : you lost -> youLose }
 {correctAnswers > 2:  you win -> youPass |  -> qst5 }
 
 
 
 
 
 
 
 
 
 === qst5 ===

Où sont apparus les premiers signes d'écriture ?
* [Au Croissant Fertile]
~comment = 5
~correctAnswers = correctAnswers + 1
  -> test5
* [En Amérique]
~comment = 0
 -> test5
 * [En Afrique du Sud]
 ~comment = 0
  -> test5
* [En europe]
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
 

    
