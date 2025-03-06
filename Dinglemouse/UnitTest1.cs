namespace Dinglemouse
{
    public class Tests
    {
        [Test, Order(1)]
        public void Ex1()
        {
            char[][] house =
            {
            "  o                o        #######".ToCharArray(),
            "###############             #     #".ToCharArray(),
            "#             #        o    #     #".ToCharArray(),
            "#  X          ###############     #".ToCharArray(),
            "#                                 #".ToCharArray(),
            "###################################".ToCharArray()
        };
            Assert.That(Kata.AllAlone(house), Is.EqualTo(true));
        }

        [Test, Order(2)]
        public void Ex2()
        {
            char[][] house =
            {
            "#################             ".ToCharArray(),
            "#     o         #   o         ".ToCharArray(),
            "#          ######        o    ".ToCharArray(),
            "####       #                  ".ToCharArray(),
            "   #       ###################".ToCharArray(),
            "   #                         #".ToCharArray(),
            "   #                  X      #".ToCharArray(),
            "   ###########################".ToCharArray()
        };
            Assert.That(Kata.AllAlone(house), Is.EqualTo(false));
        }
    }
}