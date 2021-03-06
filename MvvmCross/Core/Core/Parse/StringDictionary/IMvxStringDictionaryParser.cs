// IMvxStringDictionaryParser.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.Core.Parse.StringDictionary
{
    using System.Collections.Generic;

    public interface IMvxStringDictionaryParser
    {
        IDictionary<string, string> Parse(string textToParse);
    }
}