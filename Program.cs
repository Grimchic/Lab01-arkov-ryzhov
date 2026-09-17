// // // // System.Console.WriteLine($"Компьютер:{Environment.MachineName}");
// // // // System.Console.WriteLine($"Пользователь:{Environment.UserName}");
// // // // System.Console.WriteLine($"Дата и время:{DateTime.Now:dd.MM.yyyy HH:mm}");
// // // System.Console.WriteLine($"OC:{Environment.OSVersion}");
// // // System.Console.WriteLine($"64-битная OC:{Environment.Is64BitOperatingSystem}");
// // System.Console.WriteLine($"Логических процессов: {Environment.ProcessorCount}");
// using System.Runtime.Intrinsics.Arm;

// System.Console.WriteLine($"PID процесса:{Environment.ProcessId}");
// long memory = Environment.WorkingSet / 1024 / 1024;
// System.Console.WriteLine($"Память процесса: {memory} МБ");
// Console.ReadLine();
using System.Diagnostics;

System.Console.WriteLine("МИНИ_МОНИТОР СИСТЕМЫ\n");
System.Console.WriteLine($"Компьютер: {Environment.MachineName}");
System.Console.WriteLine($"Пользователь: {Environment.UserName}");
System.Console.WriteLine($"OC: {Environment.OSVersion}");
System.Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");
System.Console.WriteLine($"Логических процессов: {Environment.ProcessorCount}\n");
Process currentProcess = Process.GetCurrentProcess();

System.Console.WriteLine($"PID процесса: {currentProcess.Id}\n");
System.Console.WriteLine("Память процесса:");
for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();
    long memory = currentProcess.WorkingSet64 / 1024 / 1024;
    System.Console.WriteLine($"{i} измерение: {memory} МБ");
    if (i < 3)
    {
        System.Console.WriteLine("Обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}
System.Console.WriteLine("Исследование завершено.");



