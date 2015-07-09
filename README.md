# RecipeBook-CS705
C# Console Application for CS705

Instruction(s): You are to build a C# Console Application for a fictional person named Amanda who owns a dessert shop. Your console application must allow you to choose something on the menu (like a recipe book). When you choose one of the desserts on the menu, then it will direct you to the ingredients list of your chosen dessert. When you press any key, then it will paint a different screen showing the instructions on how to make the dessert. 

Additionally, please make sure to meet the following requirements and briefly comment on how you achieved them --

1. Screen Management: Screens will be no longer than 25 rows and 80 characters wide.
  •Screen takes follows above mentioned instructions.
2. Each   screen will have its own name and unique recipe or menu.
  •Each screen has unique recipe. 
3. Each   screen will be its own class and therefore; will require a constructor.
  •Different class for each screen is made.
4. Everyone   will have an IDD class that will hold the static location of all the inbound   and outbound files.  (These will    all be static locations and therefore don’t require a constructor).
  •Created static location for all files by creating static class and it data member i.e list of file paths
5. Each class will have a “Header Comment” explaining what the class does; a “Properties   Comment”, explaining what the properties are used for; and Method Comments that explain what a method does.
  •Each class having header comment describing functionality of said class.
6. All code will be self-documenting (comment each line of code to explain what it does).
  •All necessary lines that are unique are commented properly
7. Each class will display the use and implementation of properties.
  •Each class demonstrates its properties and their usage 
8. Students  will “paint the screen” by either hardcoding a screen inside of the program itself or from a file that they will    create, reading line by line into the program and then reddening out the appropriate output to the screen.
  • implemented readRelevantFile() a function which reads data from relevant file and renders on screen
9. Students will hardcode and use an array; filled from a file.
  • I have used both arrays and lists in our console app.
10. Student will enable the computer to take input from the keyboard, in a pseudo conversational style.
  • System prompts user for input.
11. All   programs will “EXIT” from one screen.
  • Program functionality allows user to exit from one screen.
12. You should demonstrate all forms of looping in your language in your code.
  • I’ve incorporated and demonstrated all forms of looping in our code like while, do while, for, foreach, etc.
13. You need to demonstrate the use of Access Methods and explain their use in the Method Header Comment.
  • We’ve used getters and setters in each class to access private members of the class
14. Students will use a .TXT file and an .XML file for the storing of data.
  • We are using both .txt and .xml file output is being saved in .xml file by using a function named as saveInXml().
15. Students will use File Input and File Output.
  • Yes I used both File I/O.
16. Please demonstrate some string functions; this can be an offshoot from one of the recipe screens but it must be there.
  • I have used string functions like contains etc. as we can see while processing file paths.
f


