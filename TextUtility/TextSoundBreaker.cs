public class TextSoundBreaker
{
    public TextSoundBreaker(ModeSetting mode = ModeSetting.Lower, char c = 'o')
    {
        _mode = mode;
        _lowerChar = char.ToLower(c);
        _upperChar = char.ToUpper(c);
    }

    public string BreakTextSound(string text)
    {
        if (_mode == ModeSetting.None) { return text; }

        Span<char> chars = stackalloc char[text.Length];

        bool isLower = IsEnable(ModeSetting.Lower);
        bool isUpper = IsEnable(ModeSetting.Upper);

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (isLower)
            {
                switch (c)
                {
                    case 'a':
                    case 'i':
                    case 'u':
                    case 'e':
                    case 'o':
                        c = _lowerChar;
                        break;
                }
            }

            if (isUpper)
            {
                switch (c)
                {
                    case 'A':
                    case 'I':
                    case 'U':
                    case 'E':
                    case 'O':
                        c = _upperChar;
                        break;
                }
            }

            chars[i] = c;
        }

        return new string(chars);
    }

    private ModeSetting _mode = ModeSetting.Lower;
    private char _lowerChar;
    private char _upperChar;

    private bool IsEnable(ModeSetting setting) => (_mode & setting) != 0;

    [Flags]
    public enum ModeSetting : byte
    {
        None = 0,
        Lower = 1,
        Upper = 2,
        Both = Lower | Upper
    }
}

