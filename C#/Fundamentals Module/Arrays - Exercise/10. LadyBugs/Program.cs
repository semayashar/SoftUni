namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(index => index >= 0 && index < fieldSize)
                .ToArray();

            int[] field = new int[fieldSize];

            foreach (int index in ladybugIndexes)
            {
                field[index] = 1;
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                int ladybugIndex = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int flyLength = int.Parse(commandArgs[2]);

                if (ladybugIndex >= 0 && ladybugIndex < fieldSize && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;

                    int newPosition = ladybugIndex;

                    while (true)
                    {
                        if (direction == "right")
                        {
                            newPosition += flyLength;
                        }
                        else if (direction == "left")
                        {
                            newPosition -= flyLength;
                        }

                        if (newPosition < 0 || newPosition >= fieldSize)
                        {
                            break;
                        }

                        if (field[newPosition] == 0)
                        {
                            field[newPosition] = 1;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}