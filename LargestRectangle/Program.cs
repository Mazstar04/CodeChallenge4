// See https://aka.ms/new-console-template for more information
Console.WriteLine(LargestRectangle(new int[] {1,2,3,4,5}));

static long LargestRectangle(int[] h)
{
    long max = 0;
    for(int i = 0; i< h.Length; i++)
    {
        long con = 1;
        for(int j = i+1; j<h.Length; j++)
        {
            if(h[i] <= h[j]) {
                con++;
            }
            else break;
        }

        for(int j = i-1; j>=0; j--)
        {
            if(h[i] <= h[j]) {
                con++;
            }
            else break;
        }
        long currentMax = h[i]*con;

        if(currentMax> max) max= currentMax;

    }
    return max;
}