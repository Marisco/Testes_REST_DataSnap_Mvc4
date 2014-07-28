Testes_REST_DataSnap_Mvc4
=========================


Olá pessoal obrigado por me ajudar!

Na "Pasta Delphi" contem o projeto datasnap rest web app. (delphi XE5)

Na "Pasta WebApp" o executável  do projeto web app  caso não tenham o XE5 instalado, ele simula o iis para consumir a dll.
(não esqueça do start)

Na "Pasta VisualStudio" o projeto mvc4 bem simples apenas pra consumir um método sayHello da dll.

Na "Pasta SayHello" Proxy as classes .cs geradas pelo delphi que já  estão incluídas no na solução mvc4.

Para visualizar  problema é simples:  coloque 3 breakpoints um na chmada, outro onde _sayHello = sResult e no return 
voces verão que a _sayHello só é pupulada depois do controller retornar o json.
