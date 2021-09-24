# Master-Micro-internship-task-1
Plotting arbitrary equations in a 2D graph

This application only accepts the following characters: "x1234567890-+*/^".
Any other character can't even be entered and there are some logical error messages that shows what you entered wrong in the equation textfield or the minimum and maximum X values 
and those occur in the following cases:
  - Inputting equal values of x 
  - Inputting minimum x value that is bigger than the maximum x value
  - Inputting equation with numbers or x symbols that aren't seperated by operators for example: 
  This is will produce an error: "23x", "xx"
  This will not produce an error: "23*x", "x*x"
  - Inputting two consecutive operands for example:
  This is will produce an error: "x**2", "x--x"
  This will not produce an error: "x*2", "x-x"
  - Starting the equation or ending it with an operand ("Knowing that you can start with '-' like "-x+2""):
  
  There are test cases that are applied on the "calculatingYvalues" function only and they're run by nunit library.
