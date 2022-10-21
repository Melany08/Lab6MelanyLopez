void StackNoParams() {
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int num5 = 0;
}
void StackWithParams(int num1, int num2, int num3) 
{
    }

void StackWithHeap(int num1, int num2, int[] num3) 
{
    num1 = 0;
    num2 = 0;
    num3 = new int[3] {0, 1, 2};
}
void StackOver(int num)
{
try 
    {
        sbyte newnum = (sbyte) num;
        Console.WriteLine("Converted the {0} value {1} to the {2} value {3}.", 
            num.GetType().Name, num, 
            newnum.GetType().Name, newnum);
    }
    catch (OverflowException) 
    {
        Console.WriteLine("Exception: {0} > {1}.", num, SByte.MaxValue);
    }
}