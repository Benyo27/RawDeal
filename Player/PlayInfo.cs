using RawDealView.Formatters;

namespace RawDeal;

public class PlayInfo : IViewablePlayInfo
{
    public IViewableCardInfo CardInfo { get; set; }
    public string PlayedAs { get; set; }
    public PlayInfo(IViewableCardInfo cardInfo, string playedAs)
    {
        CardInfo = cardInfo;
        PlayedAs = playedAs;
    }
}