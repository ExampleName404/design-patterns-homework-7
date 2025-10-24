using System;
using DesignPatternsHomework.Command;
using DesignPatternsHomework.TemplateMethod;
using DesignPatternsHomework.Mediator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Design Patterns Demo ===\n");

        // Command pattern demo
        Console.WriteLine("--- Command Pattern Demo ---");
        var invoker = new Invoker();

        var livingLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var frontDoor = new Door("Front");
        var thermostat = new Thermostat(22.0);
        var tv = new TV("Living Room");

        ICommand lightOn = new LightOnCommand(livingLight);
        ICommand kitchenOff = new LightOffCommand(kitchenLight);
        ICommand doorOpen = new DoorOpenCommand(frontDoor);
        ICommand tempUp = new ThermostatIncreaseCommand(thermostat, 2.5);
        ICommand tempDown = new ThermostatDecreaseCommand(thermostat, 1.0);
        ICommand tvOn = new TVOnCommand(tv);

        invoker.ExecuteCommand(lightOn);
        invoker.ExecuteCommand(doorOpen);
        invoker.ExecuteCommand(tempUp);
        invoker.ExecuteCommand(tvOn);

        invoker.UndoLast();
        invoker.UndoLastN(2);
        invoker.UndoLastN(5); // попытка отменить больше команд, чем есть в истории

        Console.WriteLine();

        // Template Method demo
        Console.WriteLine("--- Template Method Demo ---");
        Beverage tea = new Tea();
        tea.PrepareRecipe();

        Console.WriteLine();
        Beverage coffeeWith = new Coffee(true);
        coffeeWith.PrepareRecipe();

        Console.WriteLine();
        Beverage coffeeNo = new Coffee(false);
        coffeeNo.PrepareRecipe();

        Console.WriteLine();

        // Mediator demo
        Console.WriteLine("--- Mediator (ChatRoom) Demo ---");
        var chat = new ChatRoom();
        var putin = new User("Путин");
        var zelensky = new User("Зеленский");
        var trump = new User("Хеждео кодзима");

        chat.Register(putin);
        chat.Register(zelensky);
        chat.Register(trump);

        putin.Send("Hello everyone!");
        zelensky.SendPrivate("Путин", "Hi Путин, how are you?");

        // Попытка отправить сообщение от пользователя, который не в чате
        chat.SendMessage("Outsider", "Can I talk?");

        // Попытка отправить приватное сообщение несуществующему пользователю
        chat.SendPrivate("Путин", "NonUser", "Are you there?");

        Console.WriteLine("\nDemo finished.");
    }
}
