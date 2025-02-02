﻿using Flyweight_Pattern;

class Program
{
    static void Main(string[] args)
    {
        var factory = new _Character.CharacterFactory();

        var character1 = factory.GetCharacter("Герой", "Воин", "warrior.png");
        var character2 = factory.GetCharacter("Герой", "Воин", "warrior.png");

        character1.Level = 5;
        character1.Experience = 100;

        Console.WriteLine($"Персонаж 1: {character1.Name}, Тип: {character1.Type}, Уровень: {character1.Level}, Опыт: {character1.Experience}");
        Console.WriteLine($"Персонаж 2: {character2.Name}, Тип: {character2.Type}, Уровень: {character2.Level}, Опыт: {character2.Experience}");

        Console.WriteLine($"Оба объекта ссылаются на один и тот же экземпляр? {ReferenceEquals(character1, character2)}");
    }
}