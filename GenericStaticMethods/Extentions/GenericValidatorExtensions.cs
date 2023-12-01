namespace GenericStaticMethods.Extentions
{
    public static class GenericValidatorExtensions
    {
        public static bool ValidateAndLog<T>(this T value, Func<T, bool> validationFunction)
        {
            bool isValid = validationFunction(value);

            if (isValid)
            {
                value.LogSuccess();
            }
            else
            {
                value.LogError();
            }

            return isValid;
        }

        private static void LogSuccess<T>(this T value)
        {
            Console.WriteLine($"Validation successful for: {value}");
        }

        private static void LogError<T>(this T value)
        {
            Console.WriteLine($"Validation failed for: {value}");
        }
    }
}
