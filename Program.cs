using Abstractionss;
using BankLibrary;
using Calculator_class;
using Constoverloading;
using Data_Hiding;
using Printable;
using System;
using System.Security.AccessControl;
using VideoPlayer;
namespace TEST_3__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1-bankdetails.cs
            //Console.Write("Enter initial balance: ");
            //decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            //BankDetails account = new BankDetails(initialBalance);

            //while (true)
            //{
            //    Console.WriteLine("\nChoose an option:");
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. Withdraw");
            //    Console.WriteLine("3. Check Balance");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter deposit amount: ");
            //            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            //            try
            //            {
            //                account.Deposit(depositAmount);
            //                Console.WriteLine("Deposit successful.");
            //            }
            //            catch (ArgumentException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;

            //        case "2":
            //            Console.Write("Enter withdrawal amount: ");
            //            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            //            try
            //            {
            //                if (account.Withdraw(withdrawAmount))
            //                    Console.WriteLine("Withdrawal successful.");
            //                else
            //                    Console.WriteLine("Insufficient balance.");
            //            }
            //            catch (ArgumentException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;

            //        case "3":
            //            Console.WriteLine($"Current Balance: {account.GetBalance():C}");
            //            break;

            //        case "4":
            //            Console.WriteLine("Exiting program.");
            //            return;

            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;


            //Q2-DATAHIDING
            //Console.Write("Enter name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter roll number: ");
            //int rollNo = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    DataHiding student = new DataHiding(name, rollNo);
            //    Console.WriteLine("\nStudent Details:");
            //    Console.WriteLine($"Name: {student.Name}");
            //    Console.WriteLine($"Roll Number: {student.RollNo}");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Q3-CONSTOVERLOADING
            //Book defaultBook = new Book();
            //Console.WriteLine($"Default Book: {defaultBook.Title}, {defaultBook.Author}, {defaultBook.ISBN}");

            //Book bookWithTitleAuthor = new Book("1984", "George Orwell");
            //Console.WriteLine($"Book: {bookWithTitleAuthor.Title}, {bookWithTitleAuthor.Author}, {bookWithTitleAuthor.ISBN}");

            //Book completeBook = new Book("The Hobbit", "J.R.R. Tolkien", "978-0618968633");
            //Console.WriteLine($"Book: {completeBook.Title}, {completeBook.Author}, {completeBook.ISBN}");

            //Q4-ABSTRACTIONSS
            //Circle circle = new Circle(5);
            //double circleArea = circle.CalculateArea();
            //Console.WriteLine($"The area of the circle is: {circleArea}");

            //// Instantiate a Rectangle with a width of 4 and height of 6
            //Rectangle rectangle = new Rectangle(4, 6);
            //double rectangleArea = rectangle.CalculateArea();
            //Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
            //Console.ReadLine();

            //Q5-mETHODOVERRIFDING

            //Vehicle myVehicle = new Vehicle();
            //myVehicle.Start();

            //Vehicle myCar = new Car();
            //myCar.Start();

            //Vehicle myBike = new Bike();
            //myBike.Start();




            //Q6-VIRTUALMETHOD
            //Vehicle myVehicle = new Vehicle();
            //myVehicle.Start();

            //Vehicle myCar = new Car();
            //myCar.Start();

            //Vehicle myBike = new Bike();
            //myBike.Start();

            //Q7 METHODOVE RLOADING WITH CLAC CLASS
            //Calculator calculator = new Calculator();

            //// Demonstrating method overloading
            //int sum1 = calculator.Add(1, 2); // Calls Add(int, int)
            //int sum2 = calculator.Add(1, 2, 3); // Calls Add(int, int, int)
            //double sum3 = calculator.Add(1.5, 2.5); // Calls Add(double, double)

            //Console.WriteLine($"Sum of 1 and 2: {sum1}");
            //Console.WriteLine($"Sum of 1, 2, and 3: {sum2}");
            //Console.WriteLine($"Sum of 1.5 and 2.5: {sum3}");


            //Q8 VIDEOPLAYER

            //IPlayable audioPlayer = new AudioPlayer();
            //IPlayable moviePlayer = new MoviePlayer();

            //audioPlayer.Play(); // Output: Playing audio...
            //moviePlayer.Play();



            //Q9 IPRINTABLE
            //Report report = new Report
            //{
            //    Title = "Monthly Report",
            //    Content = "This is the content of the monthly report."
            //};

            //report.Print();

            //string filePath = "report.txt";
            //report.SaveToFile(filePath);
            //Console.WriteLine($"Report saved to {filePath}");



            //Q10 ACESSCONTROL
            //User admin = new Admin { Username = "AdminUser" };
            //User customer = new Customer { Username = "CustomerUser" };

            //Console.WriteLine($"{admin.Username} - {admin.Role}");
            //admin.AccessControl();

            //Console.WriteLine($"{customer.Username} - {customer.Role}");
            //customer.AccessControl();


            //Q11 COMPLEXNUMBERS
            //ComplexNumber num1 = new ComplexNumber(3, 4);
            //ComplexNumber num2 = new ComplexNumber(1, 2);

            //ComplexNumber sum = num1 + num2;

            //Console.WriteLine($"First Complex Number: {num1}");
            //Console.WriteLine($"Second Complex Number: {num2}");
            //Console.WriteLine($"Sum: {sum}");



            //Q12 SHALLOCOPIER
            //Manager originalManager = new Manager("Alice");
            //Department originalDepartment = new Department("HR", originalManager);

            //Department shallowCopy = originalDepartment.ShallowCopy();
            //Department deepCopy = originalDepartment.DeepCopy();

            //Console.WriteLine("Before Modification:");
            //Console.WriteLine($"Original Manager: {originalDepartment.Manager.Name}");
            //Console.WriteLine($"Shallow Copy Manager: {shallowCopy.Manager.Name}");
            //Console.WriteLine($"Deep Copy Manager: {deepCopy.Manager.Name}");

            //// Modify the original manager's name
            //originalDepartment.Manager.Name = "Bob";

            //Console.WriteLine("\nAfter Modification:");
            //Console.WriteLine($"Original Manager: {originalDepartment.Manager.Name}");
            //Console.WriteLine($"Shallow Copy Manager: {shallowCopy.Manager.Name}");
            //Console.WriteLine($"Deep Copy Manager: {deepCopy.Manager.Name}");


            //Q13  BANKCLASS
            //Bank.SetInterestRate(3.5);

            //Bank account1 = new Bank("ABC Bank", 10000);
            //Bank account2 = new Bank("XYZ Bank", 20000);

            //account1.DisplayAccountInfo();
            //account2.DisplayAccountInfo();

            //Q14 SEALEDCLASS
            //SecuritySystem security = new SecuritySystem();

            //security.Activate();
            //security.Deactivate();



            //Q15 DEGATESOFR...
            //Button button = new Button();

            //// Subscribe to the OnClick event
            //button.OnClick += (sender, e) => Console.WriteLine("Button was clicked!");

            //// Simulate a button click
            //button.Click();



            //Q16 FACTORYPATTERN
            //VehicleFactory factory = new VehicleFactory();

            //IVehicle car = factory.GetVehicle("car");
            //car.Drive();

            //IVehicle bike = factory.GetVehicle("bike");
            //bike.Drive();



            //Q17  ILOGGER
            //string logFilePath = "log.txt";
            //ILogger fileLogger = new FileLogger(logFilePath);
            //ILogger timestampLogger = new TimestampLogger(fileLogger);
            //ILogger errorLogger = new ErrorCategorizationLogger(timestampLogger);

            //errorLogger.Log("This is a critical error.");
            //errorLogger.Log("System failure detected.");

            //Q18  CONFIGMANAGER
            //ConfigurationManager config = ConfigurationManager.Instance;
            //config.ApplicationName = "Singleton App";
            //config.DisplayConfiguration();


            //Q19 NOTIFICATION MANAGER
            //NotificationSubject subject = new NotificationSubject();

            //INotificationObserver emailNotifier = new EmailNotifier();
            //INotificationObserver smsNotifier = new SMSNotifier();

            //subject.RegisterObserver(emailNotifier);
            //subject.RegisterObserver(smsNotifier);

            //subject.NotifyObservers("System update available.");

            //subject.UnregisterObserver(smsNotifier);
            //subject.NotifyObservers("Security patch applied.");

            //Q20 STRATERGY PATTERN

            ShoppingCart cart = new ShoppingCart();

            cart.AddItem(100);
            cart.AddItem(200);
            cart.AddItem(300);

            Console.WriteLine("Total without discount: " + cart.CalculateTotal());

            cart.SetDiscountStrategy(new NoDiscount());
            Console.WriteLine("Total with no discount: " + cart.CalculateTotal());

            cart.SetDiscountStrategy(new PercentageDiscount(10));
            Console.WriteLine("Total with 10% discount: " + cart.CalculateTotal());

            cart.SetDiscountStrategy(new FixedAmountDiscount(50));
            Console.WriteLine("Total with $50 discount: " + cart.CalculateTotal());
        }

    }
}
