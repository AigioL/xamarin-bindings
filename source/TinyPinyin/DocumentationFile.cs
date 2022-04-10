#if NETSTANDARD
namespace TinyPinyin
{
    /// <summary>
    /// 字符串转拼音引擎，支持字典和 <see cref="ISegmentationSelector"/>
    /// </summary>
    partial class Engine
    {
    }

    partial class PinyinHelper
    {
#if NETSTANDARD
        /// <summary>
        /// 使用 <see cref="Config"/> 初始化 <see cref="TinyPinyin"/> 库
        /// </summary>
        /// <param name="config">相应的设置，传入 <see langword="null"/> 则会清空所有的词典</param>
        public static void Init(Config? config)
        {

        }

        /// <summary>
        /// 向 <see cref="TinyPinyin"/> 中追加词典
        /// <para>注意: 若有多个词典，推荐使用性能更优的 <see cref="Init(Config?)"/> 初始化 <see cref="TinyPinyin"/></para>
        /// </summary>
        /// <param name="dict">输入的词典</param>
        public static void Add(IPinyinDict? dict)
        {

        }

        /// <summary>
        /// 返回新的 <see cref="Config"/> 对象
        /// </summary>
        /// <returns>新的 <see cref="Config"/> 对象</returns>
        public static Config NewConfig()
        {
            return null!;
        }

        /// <summary>
        /// 将输入字符串转为拼音，转换过程中会使用之前设置的用户词典，以字符为单位插入分隔符
        /// <para>例: "hello:中国" 在 separator 为 "," 时，输出： "h,e,l,l,o,:,ZHONG,GUO,!"</para>
        /// </summary>
        /// <param name="str">输入字符串</param>
        /// <param name="separator">分隔符</param>
        /// <returns>中文转为拼音的字符串</returns>
        public static string? GetPinyin(string? str, string? separator)
        {
            return null!;
        }

        /// <summary>
        /// 将输入字符串转为拼音，转换过程中会使用之前设置的用户词典，以字符为单位插入分隔符
        /// <para>例: "hello:中国" 在 separator 为 "," 时，输出： "h,e,l,l,o,:,ZHONG,GUO,!"</para>
        /// </summary>
        /// <param name="str">输入字符串</param>
        /// <param name="separator">分隔符</param>
        /// <param name="rules">自定义的规则，具有最高优先级</param>
        /// <returns>中文转为拼音的字符串</returns>
        public string? ToPinyin(string? str, string? separator, PinyinRules? rules)
        {
            return null!;
        }

        /// <summary>
        /// 将输入字符转为拼音
        /// </summary>
        /// <param name="c">输入字符</param>
        /// <returns>return pinyin if c is chinese in uppercase, String.valueOf(c) otherwise.</returns>
        public static string? GetPinyin(char c)
        {
            return null!;
        }

        /// <summary>
        /// 将输入字符转为拼音
        /// </summary>
        /// <param name="c">输入字符</param>
        /// <param name="rules">自定义规则，具有最高优先级</param>
        /// <returns>return pinyin if c is chinese in uppercase, String.valueOf(c) otherwise.</returns>
        public static unsafe string? ToPinyin(char c, PinyinRules? rules)
        {
            return null!;
        }

        /// <summary>
        /// 判断输入字符是否为汉字
        /// </summary>
        /// <param name="c">输入字符</param>
        /// <returns>return whether c is chinese</returns>
        public static bool IsChinese(char c)
        {
            return false;
        }
#endif

        public partial class Config
        {
            /// <summary>
            /// 添加字典
            /// </summary>
            /// <param name="dict">字典</param>
            /// <returns>返回 <see cref="Config"/> 对象，支持继续添加字典</returns>
            public Config? With(IPinyinDict? dict)
            {
                return this;
            }
        }
    }

    partial class PinyinRules
    {

    }

    /// <summary>
    /// 字典接口，字典应保证对 <see cref="Words"/> 中的所有词，<see cref="ToPinyin(string?)"/> 均返回非 <see langword="null"/> 的结果
    /// </summary>
    partial interface IPinyinDict
    {
#if NETSTANDARD
        /// <summary>
        /// 将词转换为拼音
        /// </summary>
        /// <param name="p0">词</param>
        /// <returns>应保证对 <see cref="Words"/> 中的所有词，<see cref="ToPinyin(string?)"/> 均返回非 <see langword="null"/> 的结果</returns>
        string[]? ToPinyin(string? p0);

        /// <summary>
        /// 字典所包含的所有词
        /// </summary>
        /// <returns>所包含的所有词</returns>
        System.Collections.Generic.ICollection<string>? Words();
#endif
    }

    /// <summary>
    /// 基于 <see cref="Java.Util.Map"/> 的字典实现，利于添加自定义字典
    /// </summary>
    partial class PinyinMapDict
    {
#if NETSTANDARD
        /// <summary>
        /// Key 为字典的词，Value 为该词所对应的拼音
        /// </summary>
        /// <returns>包含词和对应拼音的 <see cref="Java.Util.Map"/></returns>
        public System.Collections.Generic.IDictionary<string, string[]>? Mapping()
        {
            return null;
        }
#endif
    }

    /// <summary>
    /// 分词选择算法应实现的接口
    /// </summary>
    partial interface ISegmentationSelector
    {
        /// <summary>
        /// 从匹配到的所有词中，挑选出合适的词列表
        /// <para>例如，词典为："中国"，"中国人"，"人民" "中国人民来了" 的 emits 为：[0,1]中国、[0,2]中国人、[2,3]人民</para>
        /// <para>按照正向最大匹配算法，会挑选出：[0,2]中国人</para>
        /// <para>Waring:  返回的 Emit 列表中，不能存在交集，如上例中，不能同时返回 [0,2]中国人 和 [2,3]人民</para>
        /// </summary>
        /// <param name="p0">匹配到的所有词</param>
        /// <returns>返回的 Emit 列表, 不能存在交集</returns>
        System.Collections.Generic.IList<Org.Ahocorasick.Trie.Emit>? Select(System.Collections.Generic.ICollection<Org.Ahocorasick.Trie.Emit>? p0);
    }
}
#if NETSTANDARD
namespace Java.Util
{
    public partial class Map
    {

    }
}

namespace Org.Ahocorasick.Trie
{
    public partial class Emit
    {

    }
}
#endif
#endif