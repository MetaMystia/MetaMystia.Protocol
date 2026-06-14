using MemoryPack;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 厨具槽位数据
/// </summary>
[MemoryPackable]
public partial class CookerSlotData
{
    /// <summary>槽位数组的最大长度</summary>
    /// <remarks>TODO: 根据实际情况调整最大值，重构 PrepSceneManager 相关代码</remarks>
    public const int SlotsLength = 16;

    /// <summary>厨具ID，-1表示空槽位</summary>
    public int Id { get; set; } = -1;
    
    /// <summary>时间戳（默认值为0）</summary>
    public long Timestamp { get; set; }

    /// <summary>
    /// 克隆当前槽位数据
    /// </summary>
    /// <returns>克隆后的CookerSlotData实例</returns>
    public CookerSlotData Clone()
    {
        return new CookerSlotData
        {
            Id = Id,
            Timestamp = Timestamp
        };
    }

    /// <summary>
    /// 创建默认的槽位数组
    /// </summary>
    /// <returns>包含SlotsLength个默认槽位的数组</returns>
    public static CookerSlotData[] CreateDefaultArray()
    {
        var slots = new CookerSlotData[SlotsLength];
        for (var i = 0; i < slots.Length; i++)
        {
            slots[i] = new CookerSlotData();
        }
        return slots;
    }
}