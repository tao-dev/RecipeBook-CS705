/*
 This class is to handle Khapse 
 * it contains different regions lik private members and member functions etc.
 * it reads data from relevnt files and stores it for later use.it is being acccessed from Main Menu file
 * some functions are private and some are public in here.
 
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
namespace Amanda_Recipe_Book
{
    class Khapse
    {
         
        #region Private Members
        private List<string> m_pbcData = new List<string>();//created private variable and used standard of naming 
        //all private variables should start with m_ and all in lower
        List<string> m_relevantFilesPath = new List<string>();

        #endregion


        #region Constructor
        public Khapse()
        {
            //FILEPATH.Add(IDD.PATHSIDD.First(p=>p.Contains("2 ing")));
            FILEPATH.Add(IDD.PATHSIDD.First(p => p.Contains("2 ins")));//it is getting file path of 3 ing file i.e 3 ingredient.
            // actually PATHSIDD contains all files path so it is getting of specified file name only.
        }
        #endregion

        #region Public Properties
        public List<string> PBCDATA
        {
            get
            {
                return m_pbcData;
            }
            set
            {
                m_pbcData = value;
            }
        
        }
        public List<string> FILEPATH
        {
            get
            {
                return m_relevantFilesPath;
            }
            set
            {
                m_relevantFilesPath = value;
            }

        }
        
        #endregion

        #region Public Member Functions

        private void readRelaventFile()//defining file reading function with scope private because it can be accessed from within class
        {       
            ReadDataFromRelevantFile();//read data from Main.txt and save in public property named as MAINMENUFILEDATA        
        }

        public void showScreen()
        {
            readRelaventFile();
            string autndate = "Author: N/A\t\t\t\t\t  Date:" + System.DateTime.Now;
            PBCDATA.Insert(2, autndate);
            int i = 0;
            while (i < PBCDATA.Count)
            {
                Console.WriteLine(PBCDATA[i]);
                i++;
            }
        }
        
        #endregion

        #region Private Member Functions
        private void ReadDataFromRelevantFile()
        {
            for (int i = 0; i < FILEPATH.Count; i++)
            {
                StreamReader srObj = new StreamReader(FILEPATH[i]);
                string line = srObj.ReadLine();
                while (line != null)
                {
                    PBCDATA.Add(line);
                    line = srObj.ReadLine();
                }

                PBCDATA.Add("\n\n\n");
            }   
            
        }

        #endregion
    }
}
