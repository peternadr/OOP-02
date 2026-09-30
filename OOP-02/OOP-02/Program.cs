using OOP_02.SmartDeliveryManagementSystem;

namespace OOP_02;

internal class Program
{
    static void Main(string[] args)
    {

        #region Theoretical Questions

        #region Question 01
        // a) What is the difference between a class and a struct?
        /*
         * struct stored in stack ---- class stored in heap
         * struct not support inheritance ----  class support inheritance
         * struct uses for small data best performance -- class uses for large, complex data
         */

        // b) Why are classes more suitable than structs for large applications?
        // becuse classes stores in heap


        #endregion

        #region Question 02
        // a) Which class is the parent class?
        // Shipment

        // b) Which class is the child class?
        // ExpressShipment

        // c) What members are inherited by ExpressShipment?
        // TrackingCode

        // d) Why is inheritance better than duplicating the same code in multiple classes?
        // Avoids code duplication
        // Makes the code easier to maintain.

        #endregion

        #endregion

        #region building main

        #region Creat DeliveryCenter
        //Read the center name from the user.
        Console.Write("Enter the Center Name: ");
        string centerName = Console.ReadLine();

        // Create a DeliveryCenter.
        DeliveryCenter deliveryCenter = new DeliveryCenter(centerName);
        #endregion

        #region Creat StanderdShipment
        bool flag = false;

        //Read the city from the user.
        Console.Write("City: ");
        string city = Console.ReadLine();

        //Read the street from the user.
        Console.Write("Street: ");
        string street = Console.ReadLine();

        // Get building number from user
        int buildingNumber;
        do
        {
            Console.Write("Enter Valid Bulding Number: ");
            flag = int.TryParse(Console.ReadLine(), out buildingNumber);
        }
        while (!flag);

        //Read the center name from the user.
        Console.Write("Tracking Code: ");
        string trackingCode = Console.ReadLine();

        //Read the center name from the user.
        Console.Write("Description: ");
        string description = Console.ReadLine();

        // Get weight from user
        decimal weight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out weight);
        }
        while (!flag || weight <= 0);

        // Get DeliveryFee from user
        decimal deliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
        }
        while (!flag || deliveryFee <= 0);

        //creat delivery address
        DeliveryAdress deliveryAdress1 = new DeliveryAdress(city, street, buildingNumber);

        //Create one StandardShipment.
        StandardShipment standardShipment = new StandardShipment(
            deliveryAdress1,
            trackingCode,
            description,
            weight,
            deliveryFee
            );

        Console.WriteLine();

        // Add StandardShipment
        if (deliveryCenter.AddShipment(standardShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");
          
        }
        Console.WriteLine("--------------------------");
        #endregion

        #region Creat ExpressShipment

        //Read the city from the user.
        Console.Write("City: ");
        string ExpressCity = Console.ReadLine();

        //Read the street from the user.
        Console.Write("Street: ");
        string ExpressStreet = Console.ReadLine();

        // Get building number from user
        int ExpressBuildingNumber;
        do
        {
            Console.Write("Enter Valid Bulding Number: ");
            flag = int.TryParse(Console.ReadLine(), out ExpressBuildingNumber);
        }
        while (!flag);

        //Read the center name from the user.
        Console.Write("Tracking Code: ");
        string ExpressTrackingCode = Console.ReadLine();

        //Read the center name from the user.
        Console.Write("Description: ");
        string ExpressDescription = Console.ReadLine();

        // Get weight from user
        decimal ExpressWeight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressWeight);
        }
        while (!flag || ExpressWeight <= 0);

        // Get DeliveryFee from user
        decimal ExpressDeliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressDeliveryFee);
        }
        while (!flag || ExpressDeliveryFee <= 0);

        // Get extraFee from user
        decimal ExpressExtraFee;
        do
        {
            Console.Write("Enter Valid Extra Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out ExpressExtraFee);
        }
        while (!flag || ExpressExtraFee < 0);



        //creat delivery address
        DeliveryAdress deliveryAdress2 = new DeliveryAdress(
            ExpressCity,
            ExpressStreet,
            ExpressBuildingNumber
            );

        //Create one ExpressShipment.
        ExpressShipment expressShipment = new ExpressShipment(
            deliveryAdress2,
            ExpressTrackingCode,
            ExpressDescription,
            ExpressWeight,
            ExpressDeliveryFee,
            ExpressExtraFee
            );

        Console.WriteLine();

        // Add ExpressShipment
        if (deliveryCenter.AddShipment(expressShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");

        }
        Console.WriteLine("--------------------------");

        #endregion

        #region Creat InternationlShipment

        //Read the city from the user.
        Console.Write("City: ");
        string InternationlCity = Console.ReadLine();

        //Read the street from the user.
        Console.Write("Street: ");
        string InternationlStreet = Console.ReadLine();

        // Get building number from user
        int InternationlBuildingNumber;
        do
        {
            Console.Write("Enter Valid Bulding Number: ");
            flag = int.TryParse(Console.ReadLine(), out InternationlBuildingNumber);
        }
        while (!flag);

        //Read the center name from the user.
        Console.Write("Tracking Code: ");
        string InternationlTrackingCode = Console.ReadLine();

        //Read the center name from the user.
        Console.Write("Description: ");
        string InternationlDescription = Console.ReadLine();

        // Get weight from user
        decimal InternationlWeight;
        do
        {
            Console.Write("Enter Valid Weight: ");
            flag = decimal.TryParse(Console.ReadLine(), out InternationlWeight);
        }
        while (!flag || InternationlWeight <= 0);

        // Get DeliveryFee from user
        decimal InternationlDeliveryFee;
        do
        {
            Console.Write("Enter Valid Delivery Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out InternationlDeliveryFee);
        }
        while (!flag || InternationlDeliveryFee <= 0);

        // Get customsFee from user
        decimal customsFee;
        do
        {
            Console.Write("Enter Valid customs Fee: ");
            flag = decimal.TryParse(Console.ReadLine(), out customsFee);
        }
        while (!flag || customsFee < 0);

        //Read destinationCountry from user
        Console.Write("Destination Country");
        string destinationCountry = Console.ReadLine();

        //creat delivery address
        DeliveryAdress deliveryAdress3 = new DeliveryAdress(
            InternationlCity,
            InternationlStreet,
            InternationlBuildingNumber
            );

        //Create one ExpressShipment.
        InternationalShipment internationlShipment = new InternationalShipment(
            deliveryAdress3,
            InternationlTrackingCode,
            InternationlDescription,
            InternationlWeight,
            InternationlDeliveryFee,
            destinationCountry,
            customsFee
            );

        Console.WriteLine();

        // Add ExpressShipment
        if (deliveryCenter.AddShipment(internationlShipment))
        {
            Console.WriteLine("Shipment Add Successfully ");

        }
        Console.WriteLine("--------------------------");

        #endregion

        //Print all shipments.
        deliveryCenter.printAll();
        Console.WriteLine();

        #region Search for a shipment

        // Search about Shipment With Tracking Code
        Console.Write("Enter a Tracking Code To Search: ");
        string searchCode = Console.ReadLine();
        Console.WriteLine();
        Shipment foundShipment = deliveryCenter[searchCode];

        //Print the shipment if found; otherwise print:Shipment not found. 
        if (!string.IsNullOrWhiteSpace(foundShipment.TrackingCode))
        {
            Console.WriteLine("Shipment Found: ");
            foundShipment.PrintShipment();
        }
        else
        {
            Console.WriteLine("Shipment Not Found: ");
        }
        Console.WriteLine();

        #endregion

        #region Remove Shipment
        // get tracing code to remove
        Console.WriteLine("Enter a Tracking Code To Remove shipment: ");
        string RemoveCode = Console.ReadLine();

        if (deliveryCenter.RemoveShipment(RemoveCode))
        {
            Console.WriteLine("Shipmint Removed successfully");
        }
        else
        {
            Console.WriteLine("your tracking code not found");
        }

        #endregion

        //Print the remaining shipments.
        Console.WriteLine();
        deliveryCenter.printAll();

        #endregion

    }

}
