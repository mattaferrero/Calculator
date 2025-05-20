// Used to keep track of basic string information during our parsing.
using system;

public class TokenScanner {
    private string _input;

    // constructors.
    public TokenScanner(string input) {
        _input = input; 
    }

    // properties.
    public int Offset { get; set; } = 0;
    
    public string Str {
        get { return _input; }
        set { _input = value; }
    }

    public char GetCurrentChar {
        get { return Str[Offset]; }
    }

    public string GetRemainingSubstring {
        get {
            return Str.Substring(Offset);
        }
    }
}
