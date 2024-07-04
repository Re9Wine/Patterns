namespace AbstractFactory.Furniture.Tables;

// Интерфейс стола, он может быть реализован как
// абстрактный класс при необходимости. Он содержит
// все методы (поля), присущие для кресла
public interface ITable
{
    string GetTable();
}