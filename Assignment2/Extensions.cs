namespace Assignment2;

public static class Extensions
{

public static bool IsSecure(this Uri input){ //extends Uri by "this" keyword
        if(input.Scheme == "https"){
        return true;
    }
        return false;
    }

public static int WordCount(this string word){ //extends strings by "this" keyword
    int letter = 0;

    foreach(char a in word){
        if(Char.IsLetter(a))
        letter++;
    }

    return letter;
}
}
