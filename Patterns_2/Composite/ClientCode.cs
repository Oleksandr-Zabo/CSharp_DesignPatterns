namespace Patterns_2.Composite;

public class ClientCode
{
    public void Main()
        {
            var fileSystem = new FileSystem();
            bool running = true;

            Console.WriteLine("File System Simulator");
            Console.WriteLine("Available commands:");
            Console.WriteLine("  create file <path> <size>");
            Console.WriteLine("  create dir <path>");
            Console.WriteLine("  delete <path>");
            Console.WriteLine("  show tree");
            Console.WriteLine("  show info <path>");
            Console.WriteLine("  exit");

            while (running)
            {
                Console.Write("\n> ");
                var command = Console.ReadLine()?.Split(' ');

                try
                {
                    if (command == null || command.Length == 0) continue;

                    switch (command[0].ToLower())
                    {
                        case "create" when command.Length >= 3:
                            if (command[1] == "file" && command.Length >= 4)
                            {
                                fileSystem.CreateFile(command[2], int.Parse(command[3]));
                            }
                            else if (command[1] == "dir")
                            {
                                fileSystem.CreateDirectory(command[2]);
                            }
                            break;

                        case "delete" when command.Length >= 2:
                            fileSystem.Delete(command[1]);
                            break;

                        case "show" when command.Length >= 2:
                            if (command[1] == "tree")
                            {
                                fileSystem.ShowTree();
                            }
                            else if (command[1] == "info" && command.Length >= 3)
                            {
                                fileSystem.ShowInfo(command[2]);
                            }
                            break;

                        case "exit":
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Unknown command. Type 'help' for available commands.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
}