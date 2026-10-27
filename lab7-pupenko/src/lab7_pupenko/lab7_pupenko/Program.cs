using System;

namespace Lab7
{
    /// <summary>
    /// Класс для расчёта скидок в системе заказов компании «Обувь-Маг».
    /// </summary>
    public class DiscountCalculator
    {
        /// <summary>
        /// Размер скидки для товаров без заказов в прошлом месяце (25%).
        /// </summary>
        public const decimal DiscountRate = 0.25m;

        /// <summary>
        /// Название компании-заказчика.
        /// </summary>
        public string CompanyName { get; } = "Обувь-Маг";

        /// <summary>
        /// Рассчитывает цену со скидкой 25%, если по товару
        /// не было заказов в прошлом месяце.
        /// </summary>
        /// <param name="basePrice">Базовая цена товара.</param>
        /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
        /// <returns>Цена со скидкой или базовая цена.</returns>
        public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
        {
            if (hasOrdersLastMonth)
                return basePrice;

            return basePrice * (1m - DiscountRate);
        }
    }

    class Program
    {
        /// <summary>
        /// Точка входа в программу. Демонстрирует расчёт скидки
        /// и выводит результат в консоль.
        /// </summary>
        /// <param name="args">Аргументы командной строки (не используются).</param>
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();

            decimal price = 1000m;
            decimal discounted = calculator.GetDiscountedPrice(price, false);

            Console.WriteLine($"Компания: {calculator.CompanyName}");
            Console.WriteLine($"Базовая цена: {price}");
            Console.WriteLine($"Цена со скидкой: {discounted}");
            Console.WriteLine("Автор: Пупенко М.М., группа И-43"); 
            Console.ReadKey();
        }
    }
}