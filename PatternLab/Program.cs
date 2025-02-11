using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тестирование паттерна Prototype
            Console.WriteLine("Тестирование паттерна Prototype:");
            Sphere originalSphere = new Sphere(5, new Vector3(0, 0, 0));
            Sphere clonedSphere = (Sphere)originalSphere.Clone();
            clonedSphere.Position = new Vector3(1, 1, 1);

            Console.WriteLine($"Оригинальная сфера: Radius={originalSphere.Radius}, Position=({originalSphere.Position.X}, {originalSphere.Position.Y}, {originalSphere.Position.Z})");
            Console.WriteLine($"Склонированная сфера: Radius={clonedSphere.Radius}, Position=({clonedSphere.Position.X}, {clonedSphere.Position.Y}, {clonedSphere.Position.Z})");
            Console.WriteLine();

            // Тестирование паттерна State
            Console.WriteLine("Тестирование паттерна State:");
            CoffeeMachine coffeeMachine = new CoffeeMachine(new WaitingForCoin(null)); // Создаем coffeeMachine с пустым состоянием
            WaitingForCoin waitingForCoinState = new WaitingForCoin(coffeeMachine); // Создаем состояние
            coffeeMachine.SetState(waitingForCoinState); // Устанавливаем состояние

            coffeeMachine.InsertCoin();
            coffeeMachine.SelectDrink();
            coffeeMachine.DispenseDrink();
            Console.WriteLine();

            // Тестирование паттерна Mediator
            Console.WriteLine("Тестирование паттерна Mediator:");
            ChatMediator chatMediator = new ChatMediator();
            ChatUser user1 = new ChatUser("Пользователь 1", chatMediator);
            ChatUser user2 = new ChatUser("Пользователь 2", chatMediator);
            chatMediator.RegisterMember(user1);
            chatMediator.RegisterMember(user2);

            user1.SendMessage("Привет, как дела?");
            user2.SendMessage("Все хорошо, спасибо!");
            Console.WriteLine();

            // Тестирование паттерна Decorator
            Console.WriteLine("Тестирование паттерна Decorator:");
            IOrder order = new BaseOrder();
            order = new ExpressDelivery(order);
            order = new GiftWrap(order);

            Console.WriteLine($"Описание заказа: {order.GetDescription()}");
            Console.WriteLine($"Итоговая цена: {order.GetPrice()}");
            Console.WriteLine();

            // Тестирование паттерна Proxy
            Console.WriteLine("Тестирование паттерна Proxy:");
            IService proxyService = new ProxyService();

            Console.WriteLine(proxyService.GetData()); // Первый вызов (долгий)
            Console.WriteLine(proxyService.GetData()); // Второй вызов (быстрый)
            System.Threading.Thread.Sleep(6000); // Ждем, чтобы кэш истек
            Console.WriteLine(proxyService.GetData()); // Новый вызов (долгий)
        }
    }
}
