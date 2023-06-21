using System;
using System.Globalization;

namespace AcademyProject1_Class
{
    public class DebitCard
    {
        private string CardNumber;
        private string CodeCVV;
        public string EndDate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public string BankCredential { get; set; }

        public string GetCardNumber() { return CardNumber; }
        public void SetCardNumber(string cardNumber)
        {
            if (cardNumber == null) Console.WriteLine("No card number detected."); ;
            if (cardNumber.Length != 16) Console.WriteLine("Invalid card number entered.");

            CardNumber = cardNumber;
        }

        public string GetCodeCVV() { return CodeCVV; }
        public void SetCodeCVV(string code)
        {
            if (code == null) Console.WriteLine("No CVV code detected.");
            if (code.Length != 3) Console.WriteLine("Invalid CVV code entered.");

            CodeCVV = code;
        }

        public DebitCard()
        {
            CardNumber = "(No card name)"; CodeCVV = "(No CVV code)";
            EndDate = "(No any end date)";
            OwnerName = OwnerSurname = "(No any user credential)";
            BankCredential = "(No any bank info)";
        }

        public DebitCard(string cardnumber, string cvv, string enddate,
            string ownname, string ownsurname, string bank)
        {
            this.CardNumber = cardnumber;
            this.CodeCVV = cvv;
            this.EndDate = enddate;
            this.OwnerName = ownname;
            this.OwnerSurname = ownsurname;
            this.BankCredential = bank;
        }

        public override string ToString()
        {
            return $"Card Number --> {CardNumber}\n" +
                $"CVV Code --> {CodeCVV}\n" +
                $"End Date --> {EndDate}\n" +
                $"Owner First Name --> {OwnerName}\n" +
                $"Owner Last Name --> {OwnerSurname}\n" +
                $"Bank Credential --> {BankCredential}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DebitCard card1 = new DebitCard("4127208132419941", "891", "11/24", "Aliheydar", "Heydarov", "ABB");
            Console.WriteLine(card1);

            DebitCard card_null = new DebitCard();
            Console.WriteLine(card_null);

        }
    }
}
