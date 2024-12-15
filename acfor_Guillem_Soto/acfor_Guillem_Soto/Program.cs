namespace acfor_Guillem_Soto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string getInputNums = "Quants numeros vols emmagatzemar?";
            const string getNums = "Introdueix numeros";
            const string errorMsg = "El numero introduit es incorrecte";
            string finalString = "Els teus numeros son: ";
            int inputNum = 0;
            bool flag = true;
            Console.WriteLine(getInputNums);
            while (flag)
            {
                try
                {
                    inputNum = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMsg);
                    flag = true;
                }
            }
            int[] storeNum = new int[inputNum];
            Console.WriteLine(getNums);
            for (int i = 0; i < inputNum; i++)
            {
                try
                {
                    storeNum[i] = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMsg);
                    flag = false;
                }
            }
            BubbleSort(ref storeNum);
            for (int i = 0; i < storeNum.Length; i++)
            {
                finalString = finalString + storeNum[i] + " ";
            }
            Console.WriteLine(finalString);
        }
        public static void BubbleSort(ref int[] storeNum)
        {
            {
                for (int i = 0; i < storeNum.Length - 1; i++)

                {

                    for (int j = i + 1; j < storeNum.Length; j++)

                    {

                        if (storeNum[i] > storeNum[j])

                        {

                            int aux = storeNum[i];

                            storeNum[i] = storeNum[j];

                            storeNum[j] = aux;

                        }

                    }

                }
            }
        }
    }
}
