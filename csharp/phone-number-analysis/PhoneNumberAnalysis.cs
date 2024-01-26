using System;

public static class PhoneNumber
{

    
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)         
        {
            (bool isNY, bool isFake, string FourDigits) operand = (false, false, phoneNumber[8..]);
            if (phoneNumber[..^9] == "212")
            { operand.isNY = true; }
            if (phoneNumber[4..7] == "555")
            { operand.isFake = true; }
            return (operand.isNY, operand.isFake, operand.FourDigits);
        }

        public static bool IsFake((bool, bool isFake, string) phoneNumberInfo) => phoneNumberInfo.isFake;
}
