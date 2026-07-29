public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
            switch (operation)
            {
                case null:
                    throw new ArgumentNullException();
                case "-":
                    throw new ArgumentOutOfRangeException();
                case "":
                    throw new ArgumentException();
                case "+":
                    return $"{operand1} + {operand2} = {operand1 + operand2}";
                case "*":
                    return $"{operand1} * {operand2} = {operand1 * operand2}";
                case string when operand2 == 0 && operation == "/":
                    return ("Division by zero is not allowed.");
                case "/":
                    return $"{operand1} / {operand2} = {operand1 / operand2}";
                default:
                    throw new ArgumentOutOfRangeException();
            }
    }
}
