using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
bool isSelected = false;
int choice;
while (!isSelected) {
    Console.WriteLine("1. Add product records");
    Console.WriteLine("2. Display product records");
    Console.WriteLine("3. Delete product by Id");
    Console.WriteLine("4. Exit");
    Console.Write("Please select [1 - 4]: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice) {
        case 1:
            Console.WriteLine("OK");
            break;
        case 2:
            Console.WriteLine("Display");
            break;
        case 3:
            Console.WriteLine("Delete");
            break;
        case 4:
            Console.Write("Bye bye");
            isSelected = true;
            break;
    }
}