using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var strands = new List<string>();
        string codon = string.Empty;

        for (int i = 0; i < strand.Length; i++)
        {
            codon += strand[i];
            if (codon.Length == 3)
            {
                _codons.Keys
                    .ToList()
                    .ForEach(x => 
                    {                              
                        if (x.Contains(codon)) 
                        {
                            strands.Add(_codons.GetValueOrDefault(x));
                            codon = string.Empty;
                        };
                        
                    });
                if (strands.Contains("STOP"))
                {
                    strands.RemoveAt(strands.Count - 1);
                    break;
                }
            }
        }
        return strands.ToArray();

    }

    
    private static Dictionary<List<string>, string> _codons = new()
    {
        {new List<string>(){"AUG"}, "Methionine"},
        {new List<string>(){"UUU", "UUC"}, "Phenylalanine"},
        {new List<string>(){"UUA", "UUG"}, "Leucine"},
        {new List<string>(){"UCU", "UCC", "UCA", "UCG"}, "Serine"},
        {new List<string>(){"UAU", "UAC"}, "Tyrosine"},
        {new List<string>(){"UGU", "UGC"}, "Cysteine"},
        {new List<string>(){"UGG"}, "Tryptophan"},
        {new List<string>(){"UAA", "UAG", "UGA"}, "STOP"}
    };
}