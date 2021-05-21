# Agent-Safety
a puzzle to solve

The company runs a service to help keep their field agents safe  The field agent must check in regularly using their secured phone. Another agent will then record their check-in. If the user is late checking in the company will follow up to see what the problem is and if necessary will send a helo for extraction.

As the company has grown its clandestine operations they've become worried about losing one of the field agents. *It's very expensive to train them.*  So the company has contacted you to see if you help

Your mission, if you choose to accept it, is to write some code in c# that will identify agents who are overdue.  The inputs you have available to you are the check-in time and the due time.  Bonus points are available if your code works with multiple time-zones.

You'll need to show that your code will always identify overdue field agents. 

 __Hints__: 
 - Take a look at the sample [data.json](../data.json) file to help you identify the scenarios you may need to handle.
 - be careful around midnight
 - in order to run successfully your code will need to identify `now` at some point
 - tests may help
