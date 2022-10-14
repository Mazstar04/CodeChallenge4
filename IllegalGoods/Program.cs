// See https://aka.ms/new-console-template for more information
Console.WriteLine(IllegalGoods("101"));

static int IllegalGoods(string s){
    int min = 0;
    while(s.IndexOf("1") != -1)
    {
        if(s[0] == '1' )
        {
            s = s.Substring(1);
            min++;
        }
        else if(s[s.Length -1] == '1')
        {
            s = s.Substring(0, s.Length-1);
            min++;
        }
        else if(s.Length > 1 && s[1] == '1')
        {
            s = s.Substring(1);
            min++;
        }
        else if(s.Length > 1 && s[s.Length-2] == '1')
        {
            s = s.Substring(0, s.Length-1);
            min++;
        }
        else{
            s= s.Substring(0, s.IndexOf('1')) + s.Substring(s.IndexOf('1')+1);
            min+=2;
        }
    }
    return min;
}