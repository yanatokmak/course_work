using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public static class Validation
    {
        
        // Проверка на то, что строка не содержит цифр
        public static void ValidateNoDigits(string value, string fieldName)
        {
            if (value.Any(char.IsDigit))
                throw new ArgumentException($"Поле {fieldName} не может содержать цифры.");
        }

        // Проверка так то, что строка состоит только из цифр и содержит определенное число символов
        public static void ValidateOnlyDigits(string value, string fieldName, int? length = null)
        {
            if (length.HasValue && value.Length != length)
                throw new ArgumentException($"{fieldName} должно содержать ровно {length} цифр.");
        }


        // Проверяет, что строка из чисел содержит число символов в конкретном диапазоне
        public static void ValidateLength(string value, string fieldName, int minLength, int maxLength)
        {
            if (!value.All(char.IsDigit))
                throw new ArgumentException($"Поле {fieldName} должно содержать только цифры.");

            if (value.Length < minLength || value.Length > maxLength)
                throw new ArgumentException($"Поле {fieldName} должно содержать от {minLength} до {maxLength} символов.");
        }
        // Проверяет, что строка состоит только из букв и пробелов
        public static void ValidateAlphabetOnly(string value, string fieldName)
        {
            if (!value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                throw new ArgumentException($"Поле {fieldName} может содержать только буквы и пробелы.");
        }

        // Проверяет, что номер содержит только цифры, дефисы и слэши
        public static void ValidateNumberWithSymbols(string value, string fieldName)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[\d\-\/]+$"))
                throw new ArgumentException($"Поле {fieldName} может содержать только цифры, дефисы или слэши.");
        }

        // Проверка на то, что дата не в будущем
        public static void ValidateDateNotInFuture(DateTime date, string fieldName)
        {
            if (date > DateTime.Now)
                throw new ArgumentException($"Поле {fieldName} не может быть позднее текущего дня.");
        }
    }
}