using System;

class BankAcount
{
    static void Main(string[] args)
    {
        string firstname = "Anatoli", 
               lastname = "Nankov", 
               surName = "Gavrailov",
               bankName="DSK",
               IBAN = "BG80 BNBG 9661 1020 3456 78";
        ulong numOne=4916200686580003,
               numTwo=4485142342918857,
               numThree=4929967222525800;
        int balance = 3455;
        Console.WriteLine(
@"
Firs name:            {1}
Surname:              {2}
Last name:            {3}
Bank name:            {4}
IBAN:                 {5}
Credit cards numbers: {6}  {7}  {8}
Balance:              {0:C2}",balance,firstname,surName,lastname,bankName,
                             IBAN,numOne,numTwo,numThree);
    }
}
