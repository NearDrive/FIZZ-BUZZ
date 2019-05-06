using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    /// <summary>
    /// The FizzBuzz class gives on demand the numbers secuence following this rule:
    /// "Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz. Numbers divisible by both become fizzbuzz"
    /// 
    /// This class could throw an exception if the initial number value exceeds the max number value.
    /// </summary>
    public class FizzBuzz
    {

        #region variables definitions
        public const string FIZZ = "FIZZ";
        public const string BUZZ = "BUZZ";
        
        //Variables
        private int initialNumber = -1;
        private int maxNumber = -1;

        private int currentNumber = -1;

        private int Error = 0;

        #endregion

        #region variables methods

        public int InitialNumber
        {
            get {return initialNumber;}
            set{initialNumber = value;}
        }

        public int MaxNumber
        {
            get{return maxNumber;}
            set{maxNumber = value;}
        }

        public int CurrentNumber
        {
            get {return currentNumber;}
            set{currentNumber = value;}
        }

        #endregion

        #region Initializers
        public FizzBuzz()
        {
            InitVariables(); 
        }

        public FizzBuzz(int initialNumber)
        {
            InitialNumber = initialNumber;
            InitVariables();
        }

        public FizzBuzz(int initialNumber, int maxNumber)
        {
            InitialNumber = initialNumber;
            MaxNumber = maxNumber;
            InitVariables();
        }

        /// <summary>
        /// Check if any variable is not initialized and manages to get a value for it.
        /// </summary>
        private int InitVariables()
        {
            if(InitialNumber < 0)
            {
                //ask for a .config variable
                //InitialNumber = config variable
                //TODO
            }

            if (MaxNumber <= 0)
            {
                //ask for a .config variable
                //MaxNumber = config variable
                //TODO
            }

            return CheckValues();
        }

        /// <summary>
        /// Check this class variables and throws an exception if there is any error
        /// </summary>
        private int CheckValues()
        {
            if (InitialNumber > MaxNumber)
            {
                return -1;
            }

            return 0;
        }

        #endregion

        /// <summary>
        /// This method returs a list with all the fizz-buzz and numbers from the initial value given to this object to the max value.
        /// </summary>
        /// <returns>A list of numbers, Fizz, Buzz and FizzBuzz</returns>
        public string getFizzBuzzList()
        {
            string fizzBuzzList = CalculateFizzBuzzList();
            return fizzBuzzList;
        }

        /// <summary>
        /// Calculates the list of Fizz buzz
        /// </summary>
        /// <returns>A list of numbers, Fizz, Buzz and FizzBuzz</returns>
        private string CalculateFizzBuzzList()
        {
            StringBuilder fizzBuzzList = new StringBuilder();

            fizzBuzzList.Append(System.DateTime.Now.ToString() + '-');
            for (CurrentNumber = InitialNumber; CurrentNumber<=MaxNumber; CurrentNumber ++) {
                fizzBuzzList.Append(CalculateNextValue() + ':');
            }

            return fizzBuzzList.ToString();
        }

        /// <summary>
        /// Calculates the individual values of the Fizz Buzz list
        /// </summary>
        /// <returns>A number, a Fizz, a Buzz or a FizzBuzz</returns>
        private string CalculateNextValue()
        {
            if(CurrentNumber % 3 == 0)
            {
                if(CurrentNumber % 5 == 0)
                {
                    return FIZZ + BUZZ;
                }
                return FIZZ;
            }else if (CurrentNumber % 5 == 0)
            {
                return BUZZ;
            }
            return CurrentNumber.ToString();
        }

    }
}
