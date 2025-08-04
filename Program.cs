
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter height: ");
        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        int volume = length * width * height;
        double cost = 2.5;

        if (volume > 0 && volume <= 100)
        {
            cost = cost + (cost * 0.10);
        }
        else if (volume > 500 && volume <= 1000)
        {
            cost = cost + (cost * 0.25);
        }

        Console.WriteLine (cost);
    

