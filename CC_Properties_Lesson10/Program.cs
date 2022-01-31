using System;

namespace CC_Properties_Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Bank Account
            BankAccount ba = new BankAccount();
            ba.OwnerUser = new User
            {
                Name = "ztvika",
                Age = 31,
                Email = "MyEmail.Email.Com"
            };
            
            ba.bankName = "20000";//Setter
            string d/*Setter for 'd'*/ = ba.bankName;//Getter
            Console.WriteLine(ba.bankName);//Getter

            ba.GetBalance();//Getter
            ba.SetBalance(350.5);//Setter


            Console.WriteLine(ba.OwnerUser.Name);//Getter
            ba.OwnerUser.Name = "hezi";//Setter => set_OwnerName("hezi")
            string name = ba.OwnerUser.Name;//Getter => get_OwnerName()
                                            //<ownername>k_backing_field = "hezi"

            #endregion

            #region Table Exr

            Table t = new Table();
            //t.Manufacturer = "asd"; //manufactorer with only get
            t.Color = ConsoleColor.Red;
            //t.Price = 5100;//set private only

            Table t2 = new Table(ConsoleColor.Black, 10000, "shulhane Alon");

            #endregion

            #region Interfaces

            //IPerson ip = new IPerson();
            //IPerson ip3 = new Flower();
            IPerson ip2 = new Person();

            #endregion

        }
    }
}
