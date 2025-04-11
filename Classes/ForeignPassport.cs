using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp7.Classes
{
    public class ForeignPassport
    {
        private string _passportNumber;
        private string _fullName;
        private DateTime _issueDate;
        private DateTime _expiryDate;
        private string _issuingAuthority;

        public ForeignPassport(string passportNumber, string fullName, DateTime issueDate,
                             DateTime expiryDate, string issuingAuthority)
        {
            PassportNumber = passportNumber;
            FullName = fullName;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IssuingAuthority = issuingAuthority;
        }

        public string PassportNumber
        {
            get => _passportNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер паспорта не може бути порожнім");

                if (!Regex.IsMatch(value, @"^[A-Z0-9]{6,9}$"))
                    throw new ArgumentException("Номер паспорта має містити 6-9 літер або цифр");

                _passportNumber = value;
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ПІБ не може бути порожнім");

                if (value.Length < 5 || value.Length > 100)
                    throw new ArgumentException("ПІБ має містити від 5 до 100 символів");

                if (!Regex.IsMatch(value, @"^[\p{L}\s'-]+$"))
                    throw new ArgumentException("ПІБ має містити лише літери, пробіли, апостроф або дефіс");

                _fullName = value;
            }
        }

        public DateTime IssueDate
        {
            get => _issueDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Дата видачі не може бути у майбутньому");

                if (value < new DateTime(1991, 1, 1)) 
                    throw new ArgumentException("Дата видачі не може бути раніше 1991 року");

                _issueDate = value;
            }
        }

        public DateTime ExpiryDate
        {
            get => _expiryDate;
            set
            {
                if (value <= IssueDate)
                    throw new ArgumentException("Дата закінчення дії має бути після дати видачі");

                if (value < DateTime.Now)
                    throw new ArgumentException("Паспорт вже протермінований");

                _expiryDate = value;
            }
        }

        public string IssuingAuthority
        {
            get => _issuingAuthority;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Орган видачі не може бути порожнім");

                if (value.Length < 3 || value.Length > 50)
                    throw new ArgumentException("Назва органу видачі має містити від 3 до 50 символів");

                _issuingAuthority = value;
            }
        }

        public bool IsValid()
        {
            return DateTime.Now < ExpiryDate && DateTime.Now > IssueDate;
        }

        public override string ToString()
        {
            return $"Паспорт №{PassportNumber}\n" +
                   $"Власник: {FullName}\n" +
                   $"Виданий: {IssueDate:dd.MM.yyyy}\n" +
                   $"Дійсний до: {ExpiryDate:dd.MM.yyyy}\n" +
                   $"Орган видачі: {IssuingAuthority}\n" +
                   $"Статус: {(IsValid() ? "Дійсний" : "Не дійсний")}";
        }
    }
}
