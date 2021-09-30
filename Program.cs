class Program
    {
        static void Main(string[] args)
        {
            string virus = Console.ReadLine();
            int numberOfPeople = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] result = new int[numberOfPeople];
            while (i < numberOfPeople)
            {
                string code = Console.ReadLine();

                int fCodePointer = 0;
                int rCodePointer = code.Length - 1;
                int fVirusPointer = 0;
                int rVirusPointer = virus.Length - 1;
                
                int count = 0;
                
                if (code.Length > virus.Length || code.Length==0 || virus.Length==0)
                {
                   i++;
                   continue;
                }

                while ((fCodePointer <= rCodePointer) && (fVirusPointer <= rVirusPointer) )
                {
                    if (code[fCodePointer] == virus[fVirusPointer])
                    {
                        count++;
                        fCodePointer++;// increment code pointer from left to right 
                       
                    }
                    if (count == code.Length)
                    {
                        result[i] = 1;
                        break;
                    }
                    if (fVirusPointer!=rVirusPointer)
                    if (code[rCodePointer] == virus[rVirusPointer])
                    {
                        count++;
                        rCodePointer--; // Decrement you reverse code pointer
                       
                    }
                    if (count == code.Length)
                    {
                        result[i] = 1;
                        break;
                    }
                    fVirusPointer++;
                    rVirusPointer--;
                    if (fVirusPointer >= (virus.Length) || rVirusPointer < 0)
                        break;
                }
                
                i++;
            }
            foreach (int a in result)
            {
                if (a == 0)
                    Console.WriteLine("NEGATIVE");
                else
                    Console.WriteLine("POSITIVE");
            }
            Console.ReadLine();
        }

    }
