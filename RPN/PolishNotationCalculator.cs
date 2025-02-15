using System;

namespace RPN
{
    public class PolishNotationCalculator
    {
        /* Use the IStack<double> interface type to allow the flexibility of using different stack implementations 
         * (e.g., ArrayStack or LinkedListStack). */
        private IStack<double> stack;

        public PolishNotationCalculator(IStack<double> ArrayStack)
        {
            stack = ArrayStack;
        }

        /// <summary>
        /// Evaluates a polish notation expression
        /// </summary>
        /// <param name="expression">The expression string</param>
        /// <returns>Expression calculation</returns>
        public double Evaluate(string expression)
        {
            
            // trim any extra space
            expression = expression.Trim();
            // split the expression into tokens using space as delimiter
            string[] tokens = expression.Split(' ');

            // iterate over the tokens - if number then push onto stack
            foreach (string token in tokens) 
                {
                   
                    // If the token is a number, push it onto the stack.
                    if ( double.TryParse(token, out double number) )
                    {
                        stack.Push(number);
                    }
                    /*
                     * If the token is an operator (+, -, *, /):
                     *  a. Pop two numbers from the stack (b first, then a).
                     *  b. Perform the operation (a + b, a - b, etc.).
                     *  c. Push the result back onto the stack.
                     */
                    else
                    {
                            double b = stack.Pop();
                            double a = stack.Pop();
                            switch (token)
                            {
                                case "*":
                                    stack.Push(a * b);
                                    break;
                                case "-":
                                    stack.Push(a - b);
                                    break;
                                case "/":
                                    if (b == 0)
                                    {
                                        throw new Exception("Division by 0");
                                    }
                                    stack.Push(a / b);
                                    break;
                                case "+":
                                    stack.Push(a + b);
                                    break;
                                default:
                                    throw new InvalidOperationException("Invalid operation");
                            }

                     }

                    
                    
                 
                }

            /*
             * 3. After processing all tokens, the result of the calculation will be the single number remaining on the stack.
             *    Pop and return it as the final result.
             */         
                
            return stack.Pop();
          
        }
    }
}
