/* CLASSE ABSTRATA - Classes Abstratas sao classes que nao podem ser instanciadas. Isso garante Heranca Total.
 * 
 * Exemplo: Suponha que um negocio relacionado a um banco tenha apenas contas poupanca e para empresas. Nao ha contas comuns.
 *          Para garantir que as contas omuns nao possam ser instanciadas, basta acrescentar a palavra "abstract" na
 *          declaracao da classe.
 *              
 *                  namespase Course {
 *                      abstract class Account {
 *                      (...)
 *                      
 *          Na notacao UML, a Classe Abstrata e representada em Italico.
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Globalization;
using System.Collections.Generic;
using Aula134_ClassesAbstratas.Entities;

namespace Aula134_ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
