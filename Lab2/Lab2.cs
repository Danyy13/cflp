using System;
using System.Collections.Generic;

public enum AccountType
{
    Person,
    Company
};

public class Account
{
    public readonly string accountHolder;
    public readonly AccountType accountType;
    public readonly string iban;
    private double amount { get; set; }

    private const double INITIAL_ACCOUNT_BALANCE = 0;

    public Account(string accountHolder, AccountType accountType, string iban)
    {
        this.accountHolder = accountHolder;
        this.accountType = accountType;
        this.iban = iban;
        this.amount = INITIAL_ACCOUNT_BALANCE;
    }

    public string getIban() => this.iban;

    public void deposit(double amountToDeposit)
    {
        this.amount += amountToDeposit;
    }

    public bool withdraw(double amountToWithdraw)
    {
        if (this.amount - amountToWithdraw < 0)
        {
            Console.WriteLine("Fonduri Insuficiente");
            return false;
        }
        this.amount -= amountToWithdraw;
        return true;
    }

    public override string ToString()
    {
        return $"Account Holder: {this.accountHolder}\nAccount Type: {this.accountType}\nIBAN: {this.iban}\nAmount: {this.amount}\n";
    }
}

public class Bank
{
    public readonly string name;
    public readonly string swift;
    public readonly List<Account> accounts;

    public Bank(string name, string swift)
    {
        this.name = name;
        this.swift = swift;
        accounts = new List<Account>();
    }

    public void openAccount(Account account)
    {
        // Pune un cont in lista
        this.accounts.Add(account);
    }

    private Account? getAccount(string iban)
    {
        foreach (Account account in this.accounts)
        {
            if (account.getIban().Equals(iban))
            {
                return account;
            }
        }
        return null;
    }

    public void showAccount(string iban)
    {
        Account? account = getAccount(iban);
        if (account == null)
        {
            Console.WriteLine("Contul cu IBAN-ul {0} nu a fost gasit", iban);
        }
        else
        {
            Console.WriteLine(account.ToString());
        }
    }

    public void depositIntoAccount(Account account, double amount)
    {
        account.deposit(amount);
    }

    public void withdrawFromAccount(Account account, double amount)
    {
        account.withdraw(amount);
    }

    public bool transfer(Account account1, Account account2, double amount)
    {
        // transfera suma de la 1 la 2
        if (account1.withdraw(amount) == false)
        {
            Console.WriteLine("Nu s-a putut efectua transferul");
            return false;
        }
        account2.deposit(amount);
        return true;
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank("Banca Mea", "BNCM");

        Account ion = new Account("Ion", AccountType.Person, "RO49INUALLL1007593843300");
        Account maria = new Account("Maria", AccountType.Person, "RO50IKLADVV1007593841200");
        Account ceva = new Account("Ceva SRL", AccountType.Company, "RO33IJURALL1007510243300");

        bank.openAccount(ion);
        bank.openAccount(maria);
        bank.openAccount(ceva);

        bank.showAccount("RO33IJURALL1007510243300");

        bank.showAccount(ion.getIban());
        bank.showAccount(maria.getIban());

        bank.depositIntoAccount(ion, 505.12);
        bank.transfer(ion, maria, 300);

        bank.showAccount(ion.getIban());
        bank.showAccount(maria.getIban());

        bank.withdrawFromAccount(ion, 500.13);
    }
}