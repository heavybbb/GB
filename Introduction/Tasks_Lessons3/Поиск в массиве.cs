        int[] numbers = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; 
        
       //Введите сюда свое решение
        int minRange =10;
        int maxRange=90;
        int numbers2 = 0;
    int count = numbers.Length;
        int i = 0;
        for (;i<count;i++) 
        { 
            if (numbers[i]>=minRange && numbers[i]<=maxRange)
            {
          numbers2 = numbers2+1 ;
       
        }
         
        }
Console.WriteLine(numbers2);
 // Console.WriteLine(numbers2);
