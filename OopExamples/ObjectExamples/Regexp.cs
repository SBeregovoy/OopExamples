using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ObjectExamples
{
    public static class Regexes
    {
        public const string Phone = @"\(\s*\d\s*\d\s*\d\s*\)\s*\d\s*\d\s*\d-\s*\d\s*\d-\s*\d\s*\d\s*";
        public const string PhoneWithCountry = @"^\+(7)?[\- ]?\(?(\d{3})\)?[\- ]?([\d ]{3})\-([\d\- ]{2})\-([\d]{2})$";
        public const string Snils = @"^\d{3}-\d{3}-\d{3} \d{2}$";
        public const string TextRegex = @"^[\S]+(\s[\S]+)*$";
        public const string OnlyRussianText = @"^[а-яёА-ЯЁ0-9«№»(,\-]+(\s\(?«?[а-яёА-ЯЁ0-9»\-\.,№)]+)*$";
        public const string EmailRegex = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        public const string Ogrn = @"^(([0-9]{13})|([0-9]{15}))$";
        public const string INN = @"^(([0-9]{10})|([0-9]{12}))$";
        public const string Postcode = @"^[0-9]{6}$";
        public const string Site = @"^(http|ftp|https):\/\/[a-zA-Zа-яА-Я0-9-]+(\.[a-zA-Zа-яА-Я0-9-]+)+([a-zA-Zа-яА-Я0-9-\.,@?^=%&amp;:/~\+#_]*[a-zA-Zа-яА-Я0-9-\@?^=%&amp;/~\+#_])$";
        public const string Date = @"^(((0[1-9]|[12]\d|3[01])\.(0[13578]|1[02])\.((19|20)\d{2}))|((0[1-9]|[12]\d|30)\.(0[13456789]|1[012])\.((19|20)\d{2}))|((0[1-9]|1\d|2[0-8])\.02\.((19|20)\d{2}))|(29\.02\.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$";
        public const string Name = @"[А-ЯЁ]{1}[а-яё]*([ -][А-ЯЁ]{1}[а-яё]*)*";
        public const string LastName = @"[А-ЯЁ]{1}(([']{1}[А-ЯЁ]{1})|[а-яё]*)([\s-]{1}[А-ЯЁ]{1}[а-яё]*)*";
        public const string NameWithHyphen = @"[А-ЯЁ]{1}[а-яё]+(([\s-].[а-яё]+)*|(\s)?)";
        public const string LowercaseNameWithHyphen = @"[а-яё]+(([\s-].[а-яё]+)*|(\s)?)";
        public const string NameWithNumbers = @"[А-ЯЁ]{1}[а-яё0-9 ]*(([\s-].[а-яё0-9 ]+)|(\s)?)";
        public const string NameWithNumbersOnly = @"[ а-яА-ЯёЁ\d\-]*";
        public const string NameWithNumbersOnlyAndEng = @"[ a-zA-Zа-яА-ЯёЁ\d\-]*";
        public const string Time = @"^[0-9]{1,2}:[0-9]{2}$";
        public const string MonthDay = @"^(0[1-9]|[12][0-9]|3[01])[.](0[1-9]|1[012])$";
        public const string Number = @"^\d*$";
        public const string Decimal = @"^-?(?:\d+|\d{1,3}(?:\.\d{3})+)(?:,\d+)?$";
        public const string PositiveNumber = @"^[1-9][0-9]*$";
        public const string SmsConfirmationCode = @"^[0-9]{6}$";
        public const string PhonePassword = @"^[0-9]{4}$";
        public const string LoginRegex = @"^[a-zA-Z0-9._-]+$";
    }
}
