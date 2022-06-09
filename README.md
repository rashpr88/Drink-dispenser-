# Drink-dispenser-

1.	Introduction
              This is an application to handle the activities related to a drink dispenser which is developed using C# programming language as the project for CS3101. Here the objective is to automate the processes like drink selection according to customer preference and placement of orders, acceptance of customer payments, dispense drinks and return customer balance based on the validity of transactions, which were initially performed manually. Hence both the customer and the seller are benefited in many ways like quick accessibility, ease of handling, time saving, absence of physical interactions between both parties which is very suited with the prevailing pandemic situation etc. 
             This is a stand-alone application based on database handling. The graphical user interface is designed in a simple way so that the customers will not find any difficulties when using the system. Exceptions are well handled and accurate methodologies are utilized to output reliable results related to orders and transactions  

2.	Assumptions
	Only three drink types are available in the dispenser.
	A money collector and a counter are present to accept customer payment and get the value of payment and display it in the application.
	A money dispenser is available to return customer balance after counting as specified by the application for the transaction done.
	On successful payment, there is a separate system to handle the number of items to dispense out based on the item type as stated in the order placed through the application.
	A separate system is used to set up the price and number of available items by category, which will be available within the database to retrieve by the application. 



4.	Main features and functionalities

I.	Home section
Features :
 

Display three types of drinks stored in the cabinet of the drink dispenser as “Pepsi”, “Coca Cola”, “Orange Crush” with a separate button for each of the drink type.
Functionalities :
	Based on the customer preferences, when the button corresponding to relevant drink is clicked, customer get directed to the selection interface with an informational message containing details like availability, unit price and available quantity which are retrieved from the database related to the drink selected.

 

II.	Selection section
Features :
 
Functionalities :
	On availability of drinks numeric keypad will be actively available to enter the desired quantity by the customer which will be displayed within the textbox provided. ”C” button clear the content inside the textbox digit by digit while “AC” button will clear the whole content at once.
	In case of drinks unavailability, selections are not allowed while displaying an informational message saying “Unavailable!” and disabling the numeric pad and all the other buttons except “Cancel” button.
  
	When “OK” button is clicked after entering the required quantity a confirmational message will pop up as below. By clicking “Yes”, if the entered quantity is within the available range, selected quantity will get added to the bucket list Clearing the content within the textbox.
If the customer selects “No” option, it will not get added to the bucket list and the customer can make changes with the quantity entered.


	Customer is allowed to select more than 1 drink type as below. 
	With the bucket list a button called “Clear Selection” will appear which will remove the recently added items one by one when clicked.
 


	Using the “NEXT” button, customer can navigate to the next interface. Prior to navigation a confirmation message will pop up asking whether the customer needs to buy more drinks or not. Navigation will not happen unless customer selects the option “No”. View of the selection interface corresponding to this scenario is shown below.
 




If customer click on “NEXT” button without selecting any item, a warning will be given as shown above asking to first select items and add those to the bucket list.





III.	Order summary section
Features :
 

Functionalities :
	Calculations related to the placed order are shown along with the total value of the order.
	“PAY” button directs the customer to the payment page.
	“CANCLE” button cancel the entire order by directing the customer back to the home page.
	“BACK” button directs the customer again to the selection page by allowing customer to change the selections (more selections or remove selections).


 

IV.	Payment section
Features :
 
Functionalities :
	When the customer enter money, entered amount will get displayed within the text box given.
	When customer confirms the entered amount as the payment by clicking “OK” button, if the confirmed customer payment is insufficient, error message will be given by the system as shown below.
	If the confirmed customer payment is sufficient enough, then only navigation happens to the bill summary interface.
 


In case of an insufficient customer payment, order will not get completed until the sufficient amount is entered by the customer.



V.	Bill summary section
Features :
 
	If the customer pays the exact price, the system displays the balance as zero and paid amount within the read only textboxes and a greeting marking the end of order completion as shown above.
	If the customer pays more than the cost, the system requests the customer to collect the balance with an informational message while displaying the balance and the payment made within the read only textboxes. 



	“HOME” button will direct the customer back to the home interface.

