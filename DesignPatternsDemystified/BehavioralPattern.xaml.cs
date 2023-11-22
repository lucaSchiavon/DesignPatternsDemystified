using DesignPatternsDemystified.BehavioralPatterns.ChainOfResponsability;
using DesignPatternsDemystified.BehavioralPatterns.Command.LightControl;
using DesignPatternsDemystified.BehavioralPatterns.Interpreter.DateInterpreter;
using DesignPatternsDemystified.BehavioralPatterns.Interpreter.NumberInterpreter;
using DesignPatternsDemystified.BehavioralPatterns.Iterator.BookIterator;
using DesignPatternsDemystified.BehavioralPatterns.Iterator.StudentIterator;
using DesignPatternsDemystified.BehavioralPatterns.Mediator;
using DesignPatternsDemystified.BehavioralPatterns.Memento;
using DesignPatternsDemystified.BehavioralPatterns.NullObject;
using DesignPatternsDemystified.BehavioralPatterns.Observer.StockMarket;
using DesignPatternsDemystified.BehavioralPatterns.State.AudioPlayer;
using DesignPatternsDemystified.BehavioralPatterns.State.TrafficLight;
using DesignPatternsDemystified.BehavioralPatterns.Strategy;
using DesignPatternsDemystified.BehavioralPatterns.TemplateMethod;
using DesignPatternsDemystified.BehavioralPatterns.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesignPatternsDemystified
{
    /// <summary>
    /// Logica di interazione per BehavioralPattern.xaml
    /// </summary>
    public partial class BehavioralPattern : Window
    {
        public BehavioralPattern()
        {
            InitializeComponent();
        }

        private void BtnVisitor_Click(object sender, RoutedEventArgs e)
        {
            // Create a list of elements in a document.
            List<Element> elements = new List<Element>
        {
            new BehavioralPatterns.Visitor.TextElement { Text = "This is a paragraph of text." },
            new HyperlinkElement { Url = "https://www.example.com", Text = "Visit Example.com" }
        };

            // Create visitors (HTML and plain text) and apply them to the elements.
            IVisitor htmlVisitor = new HtmlVisitor();
            IVisitor plainTextVisitor = new PlainTextVisitor();

            Console.WriteLine("HTML Output:");
            foreach (var element in elements)
            {
                element.Accept(htmlVisitor);
            }

            Console.WriteLine("\nPlain Text Output:");
            foreach (var element in elements)
            {
                element.Accept(plainTextVisitor);
            }
        }

        private void BtnTemplateMethod_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Making a BLT Sandwich:");
            Sandwich bltSandwich = new BLTSandwich();
            bltSandwich.MakeSandwich();

            Console.WriteLine("\nMaking a Veggie Sandwich:");
            Sandwich veggieSandwich = new VeggieSandwich();
            veggieSandwich.MakeSandwich();
        }

        private void BtnStrategy_Click(object sender, RoutedEventArgs e)
        {
            var cart = new ShoppingCart(new CreditCardPayment());

            // Make a payment
            cart.Checkout(100.00);

            // Change the payment method to PayPal
            cart.SetPaymentStrategy(new PayPalPayment());

            // Make another payment with the new payment method (PayPal)
            cart.Checkout(50.00);

            // Change the payment method to Bitcoin
            cart.SetPaymentStrategy(new BitcoinPayment());

            // Make another payment with the new payment method (Bitcoin)
            cart.Checkout(200.00);
        }



        private void BtnStateTrafficLight_Click(object sender, RoutedEventArgs e)
        {
            TrafficLight trafficLight = new TrafficLight();

            for (int i = 0; i < 5; i++)
            {
                trafficLight.Request();
            }
        }

        private void BtnStateAudioPlayer_Click(object sender, RoutedEventArgs e)
        {
            AudioPlayer player = new AudioPlayer();

            player.Play();  // Output: Starting playback.

            player.Pause(); // Output: Cannot pause, the player is stopped.

            player.Stop();  // Output: Already stopped.

            player.Play();  // Output: Starting playback.

            player.Pause(); // Output: Pausing the playback.
        }

        private void BtnObserver_Click(object sender, RoutedEventArgs e)
        {
            //Create the stock market and investors
            StockMarket stockMarket = new StockMarket();
            Investor investor1 = new Investor("John");
            Investor investor2 = new Investor("Alice");

            //Attach investors to the stock market
            stockMarket.Attach(investor1);
            stockMarket.Attach(investor2);

            //Add stocks to the market
            stockMarket.AddStock("AAPL", 150.0m);
            stockMarket.AddStock("GOOGL", 2800.0m);

            //Update stock prices
            stockMarket.UpdateStockPrice("AAPL", 155.0m);
            stockMarket.UpdateStockPrice("GOOGL", 2850.0m);
        }

        private void BtnNullObject_Click(object sender, RoutedEventArgs e)
        {
            // Create customers with and without notification preferences
            var customer1 = new Customer("Alice", new EmailNotification("alice@example.com"));
            var customer2 = new Customer("Bob", new SMSNotification("+123456789"));

            var customer3 = new Customer("Charlie"); // No preference, uses Null Notification

            // Notify customers
            customer1.Notify("Your order has shipped.");
            customer2.Notify("Payment received.");
            customer3.Notify("Special offer!");

            // Customer 3 won't receive any notifications due to Null Notification.
        }

        private void BtnMemento_Click(object sender, RoutedEventArgs e)
        {
            TextEditor textEditor = new TextEditor();
            TextEditorHistory history = new TextEditorHistory();

            // Editing and saving state
            textEditor.Text = "First draft";
            history.Memento = textEditor.Save();

            textEditor.Text = "Second draft";

            // Restoring state
            textEditor.Restore(history.Memento);

            Console.WriteLine("Current text: " + textEditor);
        }

        private void BtnMediator_Click(object sender, RoutedEventArgs e)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser user1 = new ChatUser(chatMediator, "User 1");
            IUser user2 = new ChatUser(chatMediator, "User 2");
            IUser user3 = new ChatUser(chatMediator, "User 3");

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Hello, everyone!");
            user2.SendMessage("Hi, User 1!");
        }

        private void BtnIteratorStudentList_Click(object sender, RoutedEventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList.AddStudent(new Student("Alice", 1001));
            studentList.AddStudent(new Student("Bob", 1002));
            studentList.AddStudent(new Student("Charlie", 1003));

            IIterator iterator = studentList.CreateIterator();

            while (iterator.HasNext())
            {
                Student student = (Student)iterator.Next();
                Console.WriteLine($"Student Name: {student.Name}, Student ID: {student.StudentID}");
            }
        }

        private void BtnIteratorBookCatalog_Click(object sender, RoutedEventArgs e)
        {
            BookCatalog catalog = new BookCatalog();
            catalog.AddBook(new Book("Book 1", "Author 1"));
            catalog.AddBook(new Book("Book 2", "Author 2"));
            catalog.AddBook(new Book("Book 3", "Author 3"));

            IIterator<Book> iterator = catalog.CreateIterator();

            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }
        }



        private void BtnInterpreterNumber_Click(object sender, RoutedEventArgs e)
        {
            // Context with variable values
            var context = new Dictionary<string, int>
            {
                { "a", 5 },
                { "b", 3 }
            };

            // Create the expression tree: a + b - 2
            IExpression expression = new AddExpression(new VariableExpression("a"), new VariableExpression("b"));
            expression = new SubtractExpression(expression, new NumberExpression(2));

            // Interpret the expression
            int result = expression.Interpret(context);
            Console.WriteLine("Result: " + result); // Output: Result: 6
        }

        private void BtnInterpreterDate_Click(object sender, RoutedEventArgs e)
        {
            // Context: a specific date
            var context = new DateTime(2023, 10, 1);

            // Create the expression: (context - 7) + 14
            IDateExpression expression = new SubtractDaysExpression(new AddDaysExpression(new DateExpression(context), -7), 14);

            // Interpret the expression
            DateTime result = expression.Interpret(context);
            Console.WriteLine("Result: " + result.ToString("yyyy-MM-dd")); // Output: Result: 2023-10-8
        }

        private void BtnCommandLighControl_Click(object sender, RoutedEventArgs e)
        {
            Light light = new Light();
            BehavioralPatterns.Command.LightControl.ICommand turnOnCommand = new TurnOnLightCommand(light);
            BehavioralPatterns.Command.LightControl.ICommand turnOffCommand = new TurnOffLightCommand(light);

            RemoteControl remote = new RemoteControl();
            remote.AddCommand(turnOnCommand);
            remote.AddCommand(turnOffCommand);

            remote.PressButton(0); // Turn on the light
            remote.PressButton(1); // Turn off the light
            remote.UndoButton(1); // Undo turning off (turn on again)
        }

        private void BtnChainOfR_PurchaseRequest_Click(object sender, RoutedEventArgs e)
        {
            // Construct the chain of approvers
            IApprover manager = new Approver("Manager", 1000);
            IApprover director = new Approver("Director", 5000, manager);
            IApprover vicePresident = new Approver("Vice President", 10000, director);


            // Client creates a purchase request
            PurchaseRequest request1 = new PurchaseRequest("Laptop", 8000);
            PurchaseRequest request2 = new PurchaseRequest("Office Chair", 1200);
            PurchaseRequest request3 = new PurchaseRequest("Stationery", 300);

            // Client initiates requests through the chain
            vicePresident.ProcessRequest(request1);
            Console.WriteLine();

            vicePresident.ProcessRequest(request2);
            Console.WriteLine();

            vicePresident.ProcessRequest(request3);
        }
    }
}
