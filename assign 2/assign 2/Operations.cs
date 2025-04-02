using System;

namespace MyOperations
{
    public class Operations
    {
        // Perform Division
        public int Divide(int numerator, int denominator)
        {
            try
            {
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Attempted to divide by zero.");
                }
                return numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                throw new MyCustomException(1001, ex.Message); // Rethrow as MyCustomException
            }
        }

        // Access Array Element
        public int AccessArrayElement(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new MyCustomException(1002, ex.Message); // Rethrow as MyCustomException
            }
        }
    }
}
