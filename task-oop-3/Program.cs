using task_oop_3.Classes;
using task_oop_3.ClassesQ01;
using task_oop_3.ClassesQ02;
using task_oop_3.Q02;
using task_oop_3.Q03;

class Program
{
    static void Main(string[] args)
    {



        #region Part 01: Interface Basics - Multiple Choice (Answers Below)

        // Question 1: b) To define a blueprint for a class
        // Question 2: a) private
        // Question 3: b) No
        // Question 4: b) Yes, interfaces can inherit from multiple interfaces
        // Question 5: d) implements
        // Question 6: a) Yes (C# 8.0+ allows static methods in interfaces)
        // Question 7: b) No, all members are implicitly public
        // Question 8: a) To hide the interface members from outside access
        // Question 9: b) No, interfaces cannot have constructors
        // Question 10: c) By separating interface names with commas

        #endregion

        #region Question 1: IShape Implementation (Circle & Rectangle)
        IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion

            #region Question 2: IAuthenticationService
            IAuthenticationService authService = new BasicAuthenticationService();
            Console.WriteLine("Login: " + authService.AuthenticateUser("admin", "1234"));
            Console.WriteLine("Authorized? " + authService.AuthorizeUser("admin", "Admin"));
            #endregion

            #region Question 3: INotificationService
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("user@example.com", "Welcome!");
            smsService.SendNotification("0123456789", "Your OTP is 9999");
            pushService.SendNotification("userID_123", "New update available.");
            #endregion
    }
}


