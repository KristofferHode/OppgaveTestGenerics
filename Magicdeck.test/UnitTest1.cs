using Xunit.Sdk;

namespace modul2Oppgave1.test;

public class UnitTest1
{
    [Fact]
    public void Add_AddsCardToDeck()
    {
        var deck = new Deck<MagicCard>();
        var card = new MagicCard("Ligthningbolt", "Instant", 1);
    }
}
