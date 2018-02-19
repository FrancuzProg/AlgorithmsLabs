namespace AlgorithmsLabs
{
    static class BouerMoure
    {
        static private int[] Getd(string s)
        {
            int[] d = new int[char.MaxValue];
            for (int i = 0; i < d.Length; i++)
                d[i] = s.Length;
            for (int i = 0; i < s.Length; i++)
                d[s[i]] = s.Length - i;
            return d;
        }

        static public int Find(string text, string template)
        {
            int[] d = Getd(template);
            for (int i = template.Length; i < text.Length + 1;)
                for (int j = template.Length - 1; j >= 0; j--)
                    if (template[j] == text[i - template.Length + j])
                    {
                        if (j == 0)
                            return (i - template.Length);
                    }
                    else
                    {
                        i += d[text[i]];
                        break;
                    }
            return -1;
        }
    }
}
