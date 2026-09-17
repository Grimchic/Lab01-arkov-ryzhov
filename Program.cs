// // // System.Console.WriteLine($"Компьютер:{Environment.MachineName}");
// // // System.Console.WriteLine($"Пользователь:{Environment.UserName}");
// // // System.Console.WriteLine($"Дата и время:{DateTime.Now:dd.MM.yyyy HH:mm}");
// // System.Console.WriteLine($"OC:{Environment.OSVersion}");
// // System.Console.WriteLine($"64-битная OC:{Environment.Is64BitOperatingSystem}");
// System.Console.WriteLine($"Логических процессов: {Environment.ProcessorCount}");
using System.Runtime.Intrinsics.Arm;

System.Console.WriteLine($"PID процесса:{Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
System.Console.WriteLine($"Память процесса: {memory} МБ");
Console.ReadLine();
