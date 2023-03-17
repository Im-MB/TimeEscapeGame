INCLUDE Globals.ink


->main

===main===
Donnez l'abreviation de AWT?
    +[Applet Windowing Toolkit]
        ~ question1 = "false"
        Votre reponse est incorrecte
        -> DONE
    +[Abstract Windowing Toolkit]
        ~ question1 = "true"
        Votre reponse est correcte
        -> DONE
    +[Absolute Windowing Toolkit]
        ~ question1 = "false"
        Votre reponse est incorrecte
        -> DONE
    +[Aucune de ces reponses n'est vraie]
        ~ question1 = "false"
        Votre reponse est incorrecte
        -> DONE


-> END