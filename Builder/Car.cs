namespace Builder;

public class Car
{
    public string? Model { get; set; }
    public int? Seats { get; set; }
    public string? Engine { get; set; }
    public bool? TripComputer { get; set; }
    public bool? GPS { get; set; }

    public override string ToString() =>
        "Машина: " +
        $"Модель:{(string.IsNullOrEmpty(Model)
            ? "Неизвестна"
            : Model)}, " +
        $"Сиденья: {(!Seats.HasValue
            ? "Количество неизвестно"
            : Seats.ToString())}, " +
        $"Двигатель:{(string.IsNullOrEmpty(Engine)
            ? "Неизвестен"
            : Engine)}, " +
        $"Бортовой компьютер: {(!TripComputer.HasValue
            ? "Неизвестно наличие"
            : TripComputer.Value
                ? "Присутствует"
                : "Отсутствует")}, " +
        $"GPS: {(!GPS.HasValue
            ? "Неизвестно наличие"
            : GPS.Value
                ? "Присутствует"
                : "Отсутствует")}\n";
}