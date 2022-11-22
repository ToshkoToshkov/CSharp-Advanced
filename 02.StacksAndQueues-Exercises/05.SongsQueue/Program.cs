namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");

            string command = Console.ReadLine();

            Queue<string> songs = new Queue<string>(input);

            while (songs.Count >= 0)
            {
                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string newSong = string.Empty;

                if (cmd[0] == "Play")
                {
                    if (songs.Count > 0)
                    {
                        songs.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (cmd[0] == "Add")
                {

                    for (int i = 1; i < cmd.Length; i++)
                    {
                        newSong += cmd[i] + " ";
                    }

                    string newSongName = newSong.TrimEnd();

                    if (songs.Contains(newSongName))
                    {
                        Console.WriteLine($"{newSongName} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(newSongName);
                    }
                }
                else if (cmd[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                command = Console.ReadLine();
            }
        }
    }
}
