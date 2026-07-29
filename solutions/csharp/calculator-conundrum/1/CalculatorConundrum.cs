public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            switch (operation)
            {
                case "+":
                    return $"{operand1} + {operand2} = {operand1 + operand2}";
                case "*":
                    return $"{operand1} * {operand2} = {operand1 * operand2}";
                case string when operand2 == 0 && operation == "/":
                    throw new Exception("Division by zero is not allowed.");
                case "/":
                    return $"{operand1} / {operand2} = {operand1 / operand2}";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }catch(Exception ex)
        {
            return ex.Message;
        }
    }
}
