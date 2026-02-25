using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("===계좌 개설===");
BankAccount bank1 = new BankAccount ("홍길동","1001",100000);
BankAccount bank2 = new BankAccount("이순신","1002",50000);


BankAccount.ShowTotalAccounts();

Console.WriteLine("===거래===");
bank1.Deposit(50000);
bank2.Deposit(30000);
bank1.Withdraw(200000);
bank1.Withdraw(100000);

Console.WriteLine("===최종 계좌 정보===");
bank1.ShowInfo();
bank2.ShowInfo();





class BankAccount
{




    static int TotalAccounts;
    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccounts}개");
    }
    public string AccountNumber;
    public string OwnerName;
    public int Balance;


    public BankAccount(string name, string Number, int bala)
    {
        AccountNumber = Number;
        OwnerName = name;
        Balance = bala;
        TotalAccounts++;
        Console.WriteLine($"[{AccountNumber}] {OwnerName} 계좌가 개설되었습니다");
    }

    public void Deposit(int amount)
    {
        Balance += amount;
        Console.WriteLine($"[{AccountNumber}] {amount}원 입금완료. 잔액: {Balance}");
    }
    public void Withdraw(int amount)
    {
        Balance -= amount;
        if (Balance < 0)
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금실패. 잔액이 부족합니다");
            Balance += amount;
        }
        else
        {
            Console.WriteLine($"[{AccountNumber}] {amount}원 출금완료. 잔액: {Balance}");
        }
    }

        public void ShowInfo()
        {
        Console.WriteLine($"계좌번호: {AccountNumber}, 예금주: {OwnerName}, " +
            $"잔액: {Balance}원"); 
        }
    }








