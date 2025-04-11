using System;
using System.Text.RegularExpressions;


namespace ConsoleApp7.Classes
{
    public static class LogicalExpressionCalculator
    {
        public static bool Evaluate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Вираз не може бути порожнім");

            expression = expression.Replace(" ", "");

            var match = Regex.Match(expression,
                @"^(-?\d+)(==|!=|<=|>=|<|>)(-?\d+)$");

            if (!match.Success)
                throw new FormatException("Невірний формат виразу. Приклад: 3>2 або 7<=3");

            int leftOperand = int.Parse(match.Groups[1].Value);
            string operation = match.Groups[2].Value;
            int rightOperand = int.Parse(match.Groups[3].Value);

            return operation switch
            {
                "<" => leftOperand < rightOperand,
                ">" => leftOperand > rightOperand,
                "<=" => leftOperand <= rightOperand,
                ">=" => leftOperand >= rightOperand,
                "==" => leftOperand == rightOperand,
                "!=" => leftOperand != rightOperand,
                _ => throw new NotSupportedException($"Оператор {operation} не підтримується")
            };
        }
    }
}
