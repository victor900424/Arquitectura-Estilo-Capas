using example.controller;
using example.model;

public class main
{
    public static void Main(string[] args)
    {
        UserController userController = new UserController();

        // Solicitar datos al usuario
        Console.Write("Ingrese el ID del usuario: ");
        string id = Console.ReadLine();

        Console.Write("Ingrese el nombre del usuario: ");
        string name = Console.ReadLine();

        Console.Write("Ingrese el correo electrónico del usuario: ");
        string email = Console.ReadLine();


        //creacion de nuevo usuario
        User newUser = new User(id, name, email);
        userController.saveUser(newUser);

        //Consultar el usuario
        User retrievedUser = userController.getUserById(id);
        Console.WriteLine("=================== Consulta de Datos ========================");
        Console.WriteLine($"Retrieved User: {retrievedUser.getName()}, Email: {retrievedUser.getEmail()}");
        Console.WriteLine("=================== Fin Consulta de Datos ====================");
    }
}
