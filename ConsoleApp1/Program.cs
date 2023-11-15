// See https://aka.ms/new-console-template for more information

static bool StringChallenge(string str)
{
    char[] artiesittir = new char[2];
    artiesittir[0] = '+';
    artiesittir[1] = '=';


        if (str[0] == '+' || str[0]=='=')
        {
            
        }
        else
        {
            return false;
        }
        
        if (str[str.Length - 1] == '+' || str[str.Length-1]=='=')
        {
        }
        else
        {
            return false;
        }

        for (int i = 0; i < str.Length-1; i++)
        {
            if (artiesittir.Contains(str[i]))//bunun bir harf olup lomadıgı kontro edildi
            {
            }
            else
            {
                if (artiesittir.Contains(str[++i]))
                {
                    
                }
                else
                {
                    return false;
                }
            }
        }
    return true;
}


Console.WriteLine(StringChallenge("=g+h=+b+h=+g+"));











 
 