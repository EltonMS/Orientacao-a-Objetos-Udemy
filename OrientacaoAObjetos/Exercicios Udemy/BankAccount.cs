using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO.Exercicios_Udemy
{
    internal class BankAccount
    {
        private int numberAccount { get; }
        private string holder { get; set; }
        private double Balance { get; set; }

        public BankAccount(int numberAccount, string holder)
        {
            this.numberAccount = numberAccount;
            this.holder = holder;
            Balance = 0;
        }

        public BankAccount(int numberAccount, string holder, double initialDeposit)
        {
            this.numberAccount = numberAccount;
            this.holder = holder;
            Balance = initialDeposit;
        }

        public void AddDeposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {numberAccount}, Titular: {holder}, Saldo: R$ {Balance:F2}";
        }


        private static void exec()
        {

            BankAccount account;
            Console.WriteLine("Digite o numero da conta:");
            int numberAccount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular:");
            string holder = Console.ReadLine();

            Console.WriteLine("Deseja fazer um deposito inicial? (s/n)");
            char opcao = Convert.ToChar(Console.ReadLine());

            if (opcao == 's')
            {
                Console.WriteLine("Digite o valor do deposito inicial:");
                double initialDeposit = Convert.ToDouble(Console.ReadLine());
                account = new BankAccount(numberAccount, holder, initialDeposit);

            }
            else
            {
                account = new BankAccount(numberAccount, holder);
            }

            Console.WriteLine("Account Data:");
            Console.WriteLine(account);

            Console.WriteLine("Digite o valor do deposito:");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.AddDeposit(deposit);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);

            Console.WriteLine("Digite o valor do saque:");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdraw);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);


        }



    }
}

