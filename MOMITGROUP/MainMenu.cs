/*
 This class is to handle Main Menu 
 * it contains different regions lik private members and member functions etc.
 * it reads data from relevnt files and stores it for later use.it is being acccessed from Main Menu file
 * some functions are private and some are public in here.
 * 
 * It reads file paths of all files included in this project and saves them in a collection and allso places those paths in static collection
 * as required by documnet.
 * now this static collection containing text data will be used for later use.
 * 
 * here getter and setters are used 
 * were are accessing list with the use of public property
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Amanda_Recipe_Book
{
    class MainMenu
    {

        #region Private Members
        private List<string> m_datafromfile = new List<string>();//created private variable and used standard of naming 
        //all private variables should start with m_ and all in lower
        private string[] m_filepaths;

        #endregion


        #region Constructor
        public MainMenu()
        {
            //this is doing nothing as it is main menu constructor.
        }
        #endregion

        #region Public Properties
        public List<string> MAINMENUFILEDATA
        {
            get
            {
                return m_datafromfile;
            }
            set
            {
                m_datafromfile = value;
            }
        
        }
        public string[] FILEPATHS
        {
            get
            {
                return m_filepaths;
            }
            set
            {
                m_filepaths = value;
            }

        }
        
        #endregion

        #region Public Member Functions

        private void readRelaventFile()//defining file reading function with scope private because it can be accessed from within class
        { 
            
            readAllFilesPath();//read and save in Public proerty named as FILEPATHS
            ReadDataFromMainFile();//read data from Main.txt and save in public property named as MAINMENUFILEDATA

        
        }

        public void showMainMenuScreen()
        {
            readRelaventFile();//reading main menu file to show data on screen
            string autndate = "Author: N/A\t\t\t\t\t  Date:" + System.DateTime.Now;//putting date time
            if (!MAINMENUFILEDATA.Contains(autndate))
            {
                MAINMENUFILEDATA.Insert(2, autndate);
            }
 top:       foreach (string item in MAINMENUFILEDATA)//using foreach loop to display data on screen
            {
                Console.WriteLine(item);
            }
        up:
         int n =0;
        try//using try catch block here to handle in case if user enters character instead of numbers.
        {
            n = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("You have not entered a number");
        }
            //using switch to check all the possible values that can be entered by users.
            switch (n)
            {
                case 1:
                    Console.Clear();
                    PeanutButterCookie pbc = new PeanutButterCookie();
                    pbc.showScreen();
                    break;
                case 2:
                    Console.Clear();
                    Khapse kp = new Khapse();
                    kp.showScreen();
                    break;
                case 3:
                    Console.Clear();
                    Biscohito bsc = new Biscohito();
                    bsc.showScreen();
                    break;
                case 4:
                    Console.Clear();
                    HalfMoonCookie hmc = new HalfMoonCookie();
                    hmc.showScreen();
                    break;
                case 5:
                    Console.Clear();
                    Bredele brd = new Bredele();
                    brd.showScreen();
                    break;
                case 6:
                    Console.Clear();
                    return;
                    //break;
                default:
                    Console.WriteLine("Please enter correct number");                    
                    goto up;
                    //break;
            }

            Console.WriteLine("Please type r to return to main menu or e to exit");
input:      string r = Console.ReadLine();//asking user to enter a character to decide what to do next
            if (r.ToLower() == "r")//either go to main menu or exit 
            {
                Console.Clear();
                goto top;
            }
            else if (r.ToLower() == "e")
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter correct value either r or e`");
                goto input;
            }
        }
        
        #endregion

        #region Private Member Functions
        private void ReadDataFromMainFile()
        {
            string path= FILEPATHS.First(p=>p.Contains("Main"));//getting specific file path out of 10 file paths using lambda expression
            StreamReader srObj = new StreamReader(path);
            
            string line = srObj.ReadLine();
            
            while (line != null)//reading data from file and making sure it is reading complete file by using a check
            {
                MAINMENUFILEDATA.Add(line);//adding read data in List we can press f12 to see where it is created
                line = srObj.ReadLine();//it reads line from a file
                
            }
           

        }

        private void readAllFilesPath()
        {            
            string path = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);//obtainging current directory path
            path += "files";
            //FileStream fs = new FileStream(path, FileMode.Append);
            FILEPATHS = Directory.GetFiles(path);//obtaining paths for all files and saving in FILEPATHS a public property.
            IDD.PATHSIDD = FILEPATHS;
        }

        #endregion



    }
}
/*
Screen Main Menu								      	Author: N/A
Amanda's Awesome Recipe Menu							Date:Oct 30, 2014


							Choose a Dessert of Your Choice:
								1. Peanut Butter Cookie
								2. Khapse
								3. Biscohito 
								4. Half-Moon Cookie
								5. Bredele
								6. Exit Menu
								
							Please Place Your Order */