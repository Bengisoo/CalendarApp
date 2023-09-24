// See https://aka.ms/new-console-template for more information
using Calendar_App.Entities;

Console.WriteLine("Calendar App");

Meeting meeting1 = new()
{
    Title = "YetGen & Akbank Backend Eğitimi",
    Details = new List<string>()
    {
        "Katılımcıların alım süreçleri konuşulacak",
        "Akbank'tan gelen mail konuşulacak",
        "Bütçe planlaması konuşulacak"
    },
    StartTime = new DateTime(2023, 09, 25, 20, 00, 00),
    EndTime = new DateTime(2023, 09, 25, 22, 00, 00),
    Guests = new() { "ece", "ege", "efe" },

};

Todo todo1 = new()
{
    Title = "Katılımcıların geri bildirimlerini teslim et",
    Details = new List<string>()
    {
        "Sonuçların anonimleştirilmesi",
        "Grafik oluşturma"
    },
    StartTime = new DateTime(2023, 09, 27, 18, 30, 00),
    EndTime = new DateTime(2023, 09, 27, 20, 30, 00),
    Importance ="High Priority"

};

meeting1.GetNotification();

todo1.GetNotification();




