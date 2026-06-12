using MemoryPack;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class CookerSlotData
{
    public const int SlotsLength = 16; // TODO: 根据实际情况调整最大值，重构 PrepSceneManager 相关代码

    public int Id { get; set; } = -1;
    // 默认值为0
    public long Timestamp { get; set; }

    public CookerSlotData Clone()
    {
        return new CookerSlotData
        {
            Id = Id,
            Timestamp = Timestamp
        };
    }

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