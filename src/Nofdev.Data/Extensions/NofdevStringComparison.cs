using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Extensions
{
    public enum NofdevStringComparison
    {
        //
        // 摘要:
        //     使用区域敏感排序规则和当前区域比较字符串。
        CurrentCulture = 0,
        //
        // 摘要:
        //     使用区域敏感排序规则、当前区域来比较字符串，同时忽略被比较字符串的大小写。
        CurrentCultureIgnoreCase = 1,
        //
        // 摘要:
        //     使用区域敏感排序规则和固定区域比较字符串。
        InvariantCulture = 2,
        //
        // 摘要:
        //     使用区域敏感排序规则、固定区域来比较字符串，同时忽略被比较字符串的大小写。
        InvariantCultureIgnoreCase = 3,
        //
        // 摘要:
        //     使用序号排序规则比较字符串。
        Ordinal = 4,
        //
        // 摘要:
        //     使用序号排序规则并忽略被比较字符串的大小写，对字符串进行比较。
        OrdinalIgnoreCase = 5
    }
}
