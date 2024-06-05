// See https://aka.ms/new-console-template for more information
Console.WriteLine("DateTime Formats");
Console.WriteLine(DateTime.Now.ToString("%K"));
// Displays -07:00
Console.WriteLine(DateTime.UtcNow.ToString("O"));
// Displays Z
Console.WriteLine("'{0}'",
                  DateTime.SpecifyKind(DateTime.Now,
                       DateTimeKind.Utc).ToString("O"));
// Displays ''
Console.WriteLine("Offset Formats");
Console.WriteLine(DateTimeOffset.Now.ToString("O"));
Console.WriteLine(DateTimeOffset.Now.UtcDateTime.ToString("O"));
Console.WriteLine(DateTimeOffset.Now.DateTime.ToString("O"));
// Displays -07:00
Console.WriteLine(DateTimeOffset.UtcNow.ToString("%K"));
// Displays +00:00
Console.WriteLine(new DateTimeOffset(2008, 5, 1, 6, 30, 0,
                      new TimeSpan(5, 0, 0)).ToString("%K"));
// Displays +05:00
Console.WriteLine("Hello, World!");
