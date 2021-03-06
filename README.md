# 421-GroupCalc

### Issue with Travis CL
For some reason Travis CL is giving us errors regarding a missing package. After searching the internet and trying to resolve the issue with downloading/removing a lot of packages, we still get the build failed. Our tests pass though so nothing is wrong with the code or tests.
![Passing Test](https://github.com/mnichols17/421-GroupCalc/blob/master/tests.jpg)

* Calculator Object
   * Properties
      * Result 
   * Methods
      * Addition -> Calls addition static method from math operations
      * Subtraction -> Call subtraction static method from Math operations
      * Multiplication -> Calls multiplication static method from Math Operations
      * Division -> Calls Division static method from Math Operations
      * Exponentiation -> Calls Exponentiation static method from Math Operations
      * Radical -> Calls Radical static method from Math Operations
   * Math Operations Static Class
      * Methods
         * Addition -> Calls addition class method of sum
         * Subtraction->Calls subtraction class method of difference
         * Multiplication -> Calls multiplication class method of product
         * Division -> Calls divide class method of quotient 
         * Exponentiation -> Calls Exponentiation class method of power
         * Radical -> Calls Radical class method of square
   * Operations class(s)
      * Addition
         * Int & Double
         * Methods 
            * Sum 1 numbers
            * Sum List of numbers
      * Subtraction
         * Int & Double
         * Methods
            * Subtract 2 numbers
      * Product
         * Int & Double
         * Methods
            * Multiply 2 numbers
      * Divide
         * Int & Double
         * Method
            * Divide 2 values
      * Power
         * Int & Double
         * Method
            * Takes in a base and exponent
               * Returns base += base * base for exponent times
      * Root
         * Int & Double
         * Method
            * Takes number and nth root
               * Returns root of number


* Stats Calculator Object
   * Properties
      * Result
   * Methods
      * Simple Sampling -> Calls the simple sampling static method from Population Operations
      * Systematic Sampling -> Calls the systematic sampling static method from Population Operations
      * Confidence Interval -> Calls the confidence interval static method from Population Operations
      * Margin of Error -> Calls the margin of error static method from Population Operations
      * Cochran Formula -> Calls the Cochran Formula static method from Population Operations
      * SampleSize -> Calls the sample size static method from Population Operations
      * Mean -> Calls the mean static method from Static Operations
      * Median -> Calls the median static method from Static Operations
      * Mode -> Calls the mode static method from Static Operations
      * Variance -> Calls the Variance static method from Static Operations
      * Standard Deviation -> Calls the standard deviation static method from Static Operations
      * Quartiles -> Calls the quartiles static method from Static Operations
      * Skewness-> Calls the skewness static method from Static Operations
      * Sample Correlation -> Calls the sample correlation static method from Static Operations
      * Population Correlation -> Calls the population correlation static method from Static Operations
      * Z Score -> Calls the z score static method from Static Operations
      * Deviation -> Calls the deviation static method from Static Operations
      * Random Number Generator - Calls the random number generator static method from Static Operations
   * Statistic Operations Static Class
      * Methods
         * Mean
         * Median
         * Mode
         * Variance
         * Standard Deviation
         * Quartiles
         * Skewness
         * Sample Correlation
         * Populator Correlation
         * Z Score
         * Deviation
   * Population Operations Static Class
      * Methods
         * Simple Sampling
         * Systematic Sampling
         * Confidence Interval
         * Margin of Error
         * Cochran Formula
         * Sample Size
   * Random Operations Static Class
      * Methods (all use polymorphism to take and return Ints & Decimals)
         * Random Number
         * Random Range
         * Random List
         * Random List in a Range
         * Systematic List (for Systematic Sampling)
