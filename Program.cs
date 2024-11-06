using AtmModels;
using AtmRepository.Interfaces;
using AtmServices;
using AtmServices.Interfaces;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ATM
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AddressServices addressServices = new AddressServices();
            UserServices userServices = new UserServices();
            BankAccountServices bankAccountSevices = new BankAccountServices();
            TransactionServices transactionServices = new TransactionServices();
            IWithdrawalTransactionServices withdrawalTransactionServices = new WithdrawalTransactionServices();
            IDepositTransactionServices depositTransactionServices = new DepositTransactionServices();
            IPaymentServicesTransactionServices paymentServicesTransactionServices = new PaymentServicesTransactionServices();
            IBankTransferTransactionServices bankTransferTransactionServices = new BankTransferTransactionServices();

            //Address
            #region
            ////Display all Adresses
            //List<Address> addresses = addressServices.GetAllAddresses();

            //foreach (Address address in addresses)
            //{
            //    Console.WriteLine(address.Street);
            //    Console.WriteLine(address.Number);

            //}

            ////Get AddressById 
            //Console.Write("Input AddressId : ");
            //int addressId = Convert.ToInt32(Console.ReadLine());

            //Address address = addressServices.GetAddressById(addressId);

            //Console.WriteLine($"{address.Street} {address.Number} {address.City}");

            ////InsertNewAddress

            //Address newAddress = new Address
            //{
            //    Street = "Rua Chá",
            //    Number = 22,
            //    PostalCode = "1235 - 568",
            //    City = "Porto"

            //};

            //addressServices.InsertNewAddress(newAddress);



            ////UpdateAddress
            //Address updatedAddress = new Address
            //{
            //    Id = 6,
            //    Street = "Rua Prata",
            //    Number = 22,
            //    PostalCode = "1235 - 568",
            //    City = "Lisboa"

            //};

            //addressServices.UpdateAddress(updatedAddress);
            #endregion
            //User
            #region
            //User

            ////Get UserById 
            //Console.Write("Input UserId : ");
            //int userId = Convert.ToInt32(Console.ReadLine());

            //User user = userServices.GetUserById(userId);

            //Console.WriteLine($"{user.FirstName} {user.LastName} {user.Birthdate} idade {user.Age}");


            ////Login
            //Console.Write("Enter username: ");
            //string username = Console.ReadLine();

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();

            //User user = userServices.Login(username, password);

            //if (user != null)
            //{
            //    Console.WriteLine($"Login successful. Welcome, {user.UserName}!");
            //}
            //else
            //{
            //    Console.WriteLine("Login failed. Invalid username or password.");
            //}

            ////Get All Users

            //List<User> users = userServices.GetAllUsers();

            //foreach (User user in users)
            //{
            //    Console.WriteLine(user.FirstName);
            //    Console.WriteLine(user.LastName);
            //    Console.WriteLine($"{user.Address.Street} {user.Address.Number} {user.Address.City}");

            //}



            ////InsertNewUser

            //User user = new User
            //{
            //    FirstName = "Test2",
            //    LastName = "Test2",
            //    Birthdate = Convert.ToDateTime("15/03/1990"),
            //    Address = new Address
            //    {
            //        Street = "Test2",
            //        Number = 7,
            //        PostalCode = "Test2",
            //        City = "Test2",                   

            //    },
            //    Email = "Test2",
            //    Password = "Test2",
            //    UserName = "Test2",

            //};

            //userServices.InsertNewUser(user);




            ////Update User

            //User updateUser = new User
            //{
            //    Id = 6,
            //    FirstName = "Test3",
            //    LastName = "Test3",
            //    Birthdate = Convert.ToDateTime("25/09/1990"),
            //    Address = new Address
            //    {
            //        Street = "Test3",
            //        Number = 7,
            //        PostalCode = "Test3",
            //        City = "Test3",

            //    },
            //    Email = "Test3",
            //    Password = "Test3",
            //    UserName = "Test3",

            //};

            //userServices.UpdateUser(updateUser);
            #endregion
            //BankAccount
            #region



            ////Get BankAccountById 
            //Console.Write("Input BankAccountId : ");
            //int BankAccountId = Convert.ToInt32(Console.ReadLine());

            //BankAccount bankAccount = bankAccountSevices.GetBankAccountById(BankAccountId);

            //Console.WriteLine($"{bankAccount.User.FirstName} {bankAccount.User.LastName} {bankAccount.User.Birthdate} Age {bankAccount.User.Age}");
            //Console.WriteLine($"{bankAccount.Number} {bankAccount.Balance}");

            ////GetAllBankAccounts
            //List<BankAccount> bankAccounts = bankAccountSevices.GetAllBankAccounts();

            //foreach (BankAccount bankAccount in bankAccounts)
            //{
            //    Console.WriteLine($"{bankAccount.User.FirstName}");
            //    Console.WriteLine(bankAccount.Number);
            //    Console.WriteLine($"{bankAccount.Balance}");

            //}

            ////Get BankAccount By UserId

            //Console.Write("Input userId : ");
            //int userId = Convert.ToInt32(Console.ReadLine());

            //List<BankAccount> bankAccounts = bankAccountSevices.GetBankAccountByUserId(userId);

            //foreach (BankAccount bankAccount in bankAccounts)
            //{
            //    Console.WriteLine($"{bankAccount.User.FirstName}");
            //    Console.WriteLine(bankAccount.Number);
            //    Console.WriteLine($"{bankAccount.Balance}");
            //}


            #endregion
            //Transaction
            #region

            ////Get TransationById
            //Console.Write("Input TransationId : ");
            //int transationById = Convert.ToInt32(Console.ReadLine());

            //Transaction transaction = transactionServices.GetTransactionById(transationById);

            //Console.WriteLine($"{transaction.Date} {transaction.Type}");
            //Console.WriteLine($"{transaction.BankAccount.User.FirstName} {transaction.BankAccount.User.LastName}");
            //Console.WriteLine($"{transaction.BankAccount.Number} {transaction.BankAccount.Balance}");

            ////GetAllTransactions
            //List<Transaction> transactions = transactionServices.GetAllTransactions();

            //foreach (Transaction transaction in transactions)
            //{
            //    Console.WriteLine($"{transaction.Date} {transaction.Type}");
            //    Console.WriteLine($"{transaction.BankAccount.User.FirstName} {transaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{transaction.BankAccount.Number} {transaction.BankAccount.Balance}");

            //}

            ////Get Transaction By bankAccountId

            //Console.Write("Input bankAccountId : ");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());

            //List<Transaction> transactions = transactionServices.GetTransactionByBankAccountId(bankAccountId);

            //foreach (Transaction transaction in transactions)
            //{
            //    Console.WriteLine($"{transaction.Date} {transaction.Type}");
            //    Console.WriteLine($"{transaction.BankAccount.User.FirstName} {transaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{transaction.BankAccount.Number} {transaction.BankAccount.Balance}");

            //    Console.WriteLine("------------------------------------------");
            //}



            ////InsertTransaction  NOTA Aqui podemos escolher o Type que são construtores das classes Transaction

            //WithdrawalTransaction WithdrawalTransaction = new WithdrawalTransaction
            //{

            //    BankAccount = new BankAccount
            //    {
            //        Id = 1,
            //    },
            //    Date = DateTime.Now,
            //    Amount = 50               

            //};

            //transactionServices.InsertNewTransaction(WithdrawalTransaction);



            ////Get specific informacions type of transation

            //Console.Write("Input bankAccountId : ");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());

            ////Lista para armazenar todas as transações
            //List<Transaction> allTransactions = new List<Transaction>();

            ////Obter todas as transações de saque por BankAccountId
            //List<WithdrawalTransaction> withdrawals = withdrawalTransactionServices.GetWithdrawalTransactionsByBankAccountId(bankAccountId);
            //allTransactions.AddRange(withdrawals);

            ////Obter todas as transações de depósito por BankAccountId
            //List<DepositTransaction> deposits = depositTransactionServices.GetDepositTransactionsByBankAccountId(bankAccountId);
            //allTransactions.AddRange(deposits);

            //List<PaymentServicesTransaction> paymentServices = paymentServicesTransactionServices.GetPaymentServicesTransactionsByBankAccountId(bankAccountId);
            //allTransactions.AddRange(paymentServices);


            //List<BankTransferTransaction> bankTransferTransactions = bankTransferTransactionServices.GetBankTransferTransactionByBankAccountId(bankAccountId);
            //allTransactions.AddRange(bankTransferTransactions);
            ////Iterar sobre todas as transações e exibir suas propriedades específicas
            //foreach (Transaction transaction in allTransactions)
            //{
            //    Console.WriteLine($"{transaction.Date} {transaction.Type}");
            //    Console.WriteLine($"{transaction.BankAccount.User.FirstName} {transaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{transaction.BankAccount.Number} {transaction.BankAccount.Balance}");

            //    if (transaction is WithdrawalTransaction withdrawal)
            //    {
            //        Console.WriteLine($"Withdrawal Amount: {withdrawal.Amount}");
            //    }
            //    else if (transaction is DepositTransaction deposit)
            //    {
            //        Console.WriteLine($"Deposit Amount: {deposit.Amount}");
            //    }
            //    else if (transaction is PaymentServicesTransaction paymentService)
            //    {
            //        Console.WriteLine($"Payment Services Amount: {paymentService.Amount}");
            //        Console.WriteLine($"Payment Services Name: {paymentService.NameService}");
            //    }
            //    else if (transaction is BankTransferTransaction bankTransferTransaction)
            //    {
            //        Console.WriteLine($"Bank Transfer Amount: {bankTransferTransaction.Amount}");
            //        Console.WriteLine($"Bank Transfer Destination Account: {bankTransferTransaction.DestinationAccount.Number} ");
            //        Console.WriteLine($"Bank Transfer Destination Account Name: {bankTransferTransaction.DestinationAccount.User.FirstName} {bankTransferTransaction.DestinationAccount.User.LastName}");
            //    }
            //    Console.WriteLine("------------------------------------------");
            //}




            #endregion\
            //WithdrawalTransaction
            #region
            ////GetAllWithdrawalTransaction
            //List<WithdrawalTransaction> withdrawalTransactions = withdrawalTransactionServices.GetAllWithdrawalTransactions();

            //foreach (WithdrawalTransaction withdrawalTransaction in withdrawalTransactions)
            //{
            //    Console.WriteLine($"{withdrawalTransaction.Date} {withdrawalTransaction.Amount}");
            //    Console.WriteLine($"{withdrawalTransaction.BankAccount.Number} {withdrawalTransaction.BankAccount.User.FirstName}");
            //    Console.WriteLine($"{withdrawalTransaction.BankAccount.Balance}")
            //    ;

            //}

            ////GetWithdrawalTransactionById

            //Console.Write("Input WithdrawalTransactionId : ");
            //int withdrawalTransactionId = Convert.ToInt32(Console.ReadLine());

            //WithdrawalTransaction withdrawalTransaction = withdrawalTransactionServices.GetWithdrawalTransactionById(withdrawalTransactionId);

            //Console.WriteLine($"{withdrawalTransaction.Date} {withdrawalTransaction.Amount}");
            //Console.WriteLine($"{withdrawalTransaction.BankAccount.Number} {withdrawalTransaction.BankAccount.User.FirstName}");
            //Console.WriteLine($"{withdrawalTransaction.BankAccount.Balance}");


            ////Get WithdrawalTransaction By TransactionId

            //Console.Write("Input TransactionId : ");
            //int transactionId = Convert.ToInt32(Console.ReadLine());

            //List<WithdrawalTransaction> withdrawalTransactions = withdrawalTransactionServices.GetWithdrawalTransactionByTransactionId(transactionId);

            //foreach (WithdrawalTransaction withdrawalTransaction in withdrawalTransactions)
            //{
            //    Console.WriteLine($"{withdrawalTransaction.Date} {withdrawalTransaction.Type}");
            //    Console.WriteLine($"{withdrawalTransaction.BankAccount.User.FirstName} {withdrawalTransaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{withdrawalTransaction.BankAccount.Number} {withdrawalTransaction.BankAccount.Balance}");

            //}


            ////InsertNewWithdrawalTransaction
            //WithdrawalTransaction WithdrawalTransaction = new WithdrawalTransaction
            //{

            //    BankAccount = new BankAccount
            //    {
            //        Id = 2,
            //    },
            //    Date = DateTime.Now,
            //    Amount = 500

            //};

            //transactionServices.InsertNewTransaction(WithdrawalTransaction);
            //int lastTransactionId = transactionServices.LastTransactionId();
            //WithdrawalTransaction.Id = lastTransactionId;
            //withdrawalTransactionServices.InsertNewWithdrawalTransaction(WithdrawalTransaction);

            ////Withdrawal
            //Console.WriteLine("BankAccountId:");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //withdrawalTransactionServices.Withdrawal(bankAccountId, amount);

            #endregion

            //DepositTransaction
            #region
            ////GetAllDepositTransaction
            //List<DepositTransaction> depositTransactions = depositTransactionServices.GetAllDepositTransactions();

            //foreach (DepositTransaction depositTransaction in depositTransactions)
            //{
            //    Console.WriteLine($"{depositTransaction.Date} {depositTransaction.Amount}");
            //    Console.WriteLine($"{depositTransaction.BankAccount.Number} {depositTransaction.BankAccount.User.FirstName}");
            //    Console.WriteLine($"{depositTransaction.BankAccount.Balance}")
            //    ;

            //}

            ////GetDepositTransactionById

            //Console.Write("Input DepositTransactionId : ");
            //int depositTransactionId = Convert.ToInt32(Console.ReadLine());

            //DepositTransaction depositTransaction = depositTransactionServices.GetDepositTransactionById(depositTransactionId);

            //Console.WriteLine($"{depositTransaction.Date} {depositTransaction.Amount}");
            //Console.WriteLine($"{depositTransaction.BankAccount.Number} {depositTransaction.BankAccount.User.FirstName}");
            //Console.WriteLine($"{depositTransaction.BankAccount.Balance}");

            //Get DepositTransaction By TransactionId

            //Console.Write("Input TransactionId : ");
            //int transactionId = Convert.ToInt32(Console.ReadLine());

            //List<DepositTransaction> depositTransactions = depositTransactionServices.GetDepositTransactionByTransactionId(transactionId);

            //foreach (DepositTransaction depositTransaction in depositTransactions)
            //{
            //    Console.WriteLine($"{depositTransaction.Date} {depositTransaction.Type}");
            //    Console.WriteLine($"{depositTransaction.BankAccount.User.FirstName} {depositTransaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{depositTransaction.BankAccount.Number} {depositTransaction.BankAccount.Balance}");

            //}


            ////InsertDepositTransactionTransaction
            //DepositTransaction depositTransaction = new DepositTransaction
            //{

            //    BankAccount = new BankAccount
            //    {
            //        Id = 3,
            //    },
            //    Date = DateTime.Now,
            //    Amount = 5000

            //};

            //transactionServices.InsertNewTransaction(depositTransaction);
            //int lastTransactionId = transactionServices.LastTransactionId();
            //depositTransaction.Id = lastTransactionId;
            //depositTransactionServices.InsertNewDepositTransaction(depositTransaction);



            ////Deposit
            //Console.WriteLine("BankAccountId:");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //depositTransactionServices.Deposit(bankAccountId, amount);
            #endregion

            //PaymentServicesTransaction
            #region
            //GetPaymentServicesTransaction
            //List<PaymentServicesTransaction> PaymentServicesTransactions = paymentServicesTransactionServices.GetAllPaymentServicesTransaction();

            //foreach (PaymentServicesTransaction paymentServicesTransaction in PaymentServicesTransactions)
            //{
            //    Console.WriteLine($"{paymentServicesTransaction.Date} {paymentServicesTransaction.Amount}");
            //    Console.WriteLine($"{paymentServicesTransaction.BankAccount.Number} {paymentServicesTransaction.BankAccount.User.FirstName}");
            //    Console.WriteLine($"{paymentServicesTransaction.BankAccount.Balance}");
            //    Console.WriteLine($"{paymentServicesTransaction.NameService}")
            //    ;

            //}

            ////GetPaymentServicesTransactionById

            //Console.Write("Input PaymentServicesTransactionId : ");
            //int paymentServicesTransactionId = Convert.ToInt32(Console.ReadLine());

            //PaymentServicesTransaction paymentServicesTransaction = paymentServicesTransactionServices.GetPaymentServicesTransactionById(paymentServicesTransactionId);

            //Console.WriteLine($"{paymentServicesTransaction.Date} {paymentServicesTransaction.Amount}");
            //Console.WriteLine($"{paymentServicesTransaction.BankAccount.Number} {paymentServicesTransaction.BankAccount.User.FirstName}");
            //Console.WriteLine($"{paymentServicesTransaction.BankAccount.Balance}");
            //Console.WriteLine($"{paymentServicesTransaction.NameService}");

            ////Get PaymentServicesTransaction By TransactionId

            //Console.Write("Input TransactionId : ");
            //int transactionId = Convert.ToInt32(Console.ReadLine());

            //List<PaymentServicesTransaction> paymentServicesTransactions = paymentServicesTransactionServices.GetPaymentServicesTransactionByTransactionId(transactionId);

            //foreach (PaymentServicesTransaction paymentServicesTransaction in paymentServicesTransactions)
            //{
            //    Console.WriteLine($"{paymentServicesTransaction.Date} {paymentServicesTransaction.Type}");
            //    Console.WriteLine($"{paymentServicesTransaction.BankAccount.User.FirstName} {paymentServicesTransaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{paymentServicesTransaction.BankAccount.Number} {paymentServicesTransaction.BankAccount.Balance}");
            //    Console.WriteLine($"{paymentServicesTransaction.NameService}");
            //}


            ////InsertDepositTransactionTransaction
            //PaymentServicesTransaction paymentServicesTransaction = new PaymentServicesTransaction
            //{

            //    BankAccount = new BankAccount
            //    {
            //        Id = 3,
            //    },
            //    Date = DateTime.Now,
            //    Amount = 65,
            //    NameService = "GásStation"

            //};

            //transactionServices.InsertNewTransaction(paymentServicesTransaction);
            //int lastTransactionId = transactionServices.LastTransactionId();
            //paymentServicesTransaction.Id = lastTransactionId;
            //paymentServicesTransactionServices.InsertNewPaymentServicesTransaction(paymentServicesTransaction);


            ////PaymentServices
            //Console.WriteLine("BankAccountId:");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Name Service:");
            //string nameService = Console.ReadLine();
            //paymentServicesTransactionServices.PaymentServices(bankAccountId, amount, nameService);

            #endregion

            //BankTransferTransaction
            #region

            ////GetAllBankTransferTransaction
            //List<BankTransferTransaction> bankTransferTransactions = bankTransferTransactionServices.GetAllBankTransferTransactions();

            //foreach (BankTransferTransaction bankTransferTransaction in bankTransferTransactions)
            //{
            //    Console.WriteLine($"Conta Origem");
            //    Console.WriteLine($" Date - {bankTransferTransaction.Date} {bankTransferTransaction.Amount}");
            //    Console.WriteLine($"{bankTransferTransaction.BankAccount.Number} {bankTransferTransaction.BankAccount.User.FirstName}");
            //    Console.WriteLine($"Conta Destino:");
            //    Console.WriteLine($"{bankTransferTransaction.BankAccount.User.FirstName} {bankTransferTransaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"{bankTransferTransaction.BankAccount.Number}")
            //    ;

            //}


            ////GetBankTransferTransactionById

            //Console.Write("Input BankTransferTransactionId : ");
            //int bankTransferTransactionId = Convert.ToInt32(Console.ReadLine());

            //BankTransferTransaction bankTransferTransaction = bankTransferTransactionServices.GetBankTransferTransactionById(bankTransferTransactionId);
            //Console.WriteLine($"Conta Origem");
            //Console.WriteLine($"{bankTransferTransaction.Date} {bankTransferTransaction.Amount}");
            //Console.WriteLine($"{bankTransferTransaction.BankAccount.Number} {bankTransferTransaction.BankAccount.User.FirstName}");
            //Console.WriteLine($"Conta Destino");
            //Console.WriteLine($"{bankTransferTransaction.DestinationAccount.Number}");
            //Console.WriteLine($"{bankTransferTransaction.DestinationAccount.User.FirstName} {bankTransferTransaction.DestinationAccount.User.LastName}");

            ////Get BankTransferTransaction By TransactionId

            //Console.Write("Input TransactionId : ");
            //int transactionId = Convert.ToInt32(Console.ReadLine());

            //List<BankTransferTransaction> bankTransferTransactions = bankTransferTransactionServices.GetBankTransferTransactionByTransactionId(transactionId);

            //foreach (BankTransferTransaction bankTransferTransaction in bankTransferTransactions)
            //{
            //    Console.WriteLine($"Conta Origem");
            //    Console.WriteLine($"{bankTransferTransaction.Date} {bankTransferTransaction.Amount}");
            //    Console.WriteLine($"{bankTransferTransaction.BankAccount.Number} {bankTransferTransaction.BankAccount.User.FirstName}");
            //    Console.WriteLine($"Conta Destino");
            //    Console.WriteLine($"{bankTransferTransaction.DestinationAccount.Number}");
            //    Console.WriteLine($"{bankTransferTransaction.DestinationAccount.User.FirstName} {bankTransferTransaction.DestinationAccount.User.LastName}");
            //}

            ////InsertBankTransferTransaction
            //BankTransferTransaction bankTransferTransaction = new BankTransferTransaction
            //{

            //    BankAccount = new BankAccount
            //    {
            //        Id = 3,
            //    },
            //    Date = DateTime.Now,
            //    Amount = 65,
            //    DestinationAccount = new BankAccount
            //    {
            //        Id = 5,
            //    }

            //};

            //transactionServices.InsertNewTransaction(bankTransferTransaction);
            //int lastTransactionId = transactionServices.LastTransactionId();
            //bankTransferTransaction.Id = lastTransactionId;
            //bankTransferTransactionServices.InsertBankTransferTransaction(bankTransferTransaction);


            ////bankTransfer
            //Console.WriteLine("BankAccountId:");
            //int bankAccountId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amount:");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("DestinationAccountId:");
            //int destinationAccount = Convert.ToInt32(Console.ReadLine());
            //bankTransferTransactionServices.BankTransfer(bankAccountId, amount, destinationAccount);



            //GetAllBankTransferTransaction by DestinationAccountId
            //int destinationAccountId = Convert.ToInt32(Console.ReadLine());

            //List<BankTransferTransaction> bankTransferTransactions = bankTransferTransactionServices.GetBankTransferTransactionByDestinationAccountId(destinationAccountId);

            //foreach (BankTransferTransaction transaction in bankTransferTransactions)
            //{
            //    Console.WriteLine($"{transaction.Date} {transaction.Type}");
            //    Console.WriteLine($"From Account: {transaction.BankAccount.User.FirstName} {transaction.BankAccount.User.LastName}");
            //    Console.WriteLine($"From Account Number: {transaction.BankAccount.Number}");
            //    Console.WriteLine($"From Account Balance: {transaction.BankAccount.Balance}");
            //    Console.WriteLine($"To Account: {transaction.DestinationAccount.User.FirstName} {transaction.DestinationAccount.User.LastName}");
            //    Console.WriteLine($"To Account Number: {transaction.DestinationAccount.Number}");
            //    Console.WriteLine($"To Account Balance: {transaction.DestinationAccount.Balance}");
            //    Console.WriteLine($"Amount: {transaction.Amount}");
            //    Console.WriteLine("------------------------------------------");
            //}

            #endregion

        }


    }
    
}