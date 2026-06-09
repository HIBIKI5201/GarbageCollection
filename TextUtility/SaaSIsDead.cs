using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 死んだSaaSの怨念
/// </summary>
public class SaaSIsDead
{
    private const string SAAS_IS_DEAD = "SaaSIsDead";

    private readonly Random _random = new();

    public string SasSIsDead(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        StringBuilder result = new(text);

        int i = 0;

        while (i < result.Length)
        {
            char current = result[i];

            List<int> targetIndices = new();

            for (int j = 0; j < SAAS_IS_DEAD.Length; j++)
            {
                if (SAAS_IS_DEAD[j] == current)
                {
                    targetIndices.Add(j);
                }
            }

            if (targetIndices.Count == 0)
            {
                i++;
                continue;
            }

            int targetIndex = targetIndices[_random.Next(targetIndices.Count)];

            int start = i - targetIndex;

            if (start < 0)
            {
                result.Insert(0, new string(' ', -start));

                i -= start;
                start = 0;
            }

            int requiredLength = start + SAAS_IS_DEAD.Length;

            if (requiredLength > result.Length)
            {
                result.Append(' ', requiredLength - result.Length);
            }

            for (int j = 0; j < SAAS_IS_DEAD.Length; j++)
            {
                result[start + j] = SAAS_IS_DEAD[j];
            }

            i = start + SAAS_IS_DEAD.Length;
        }

        return result.ToString();
    }
}