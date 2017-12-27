using System.Text;
using Xunit;

namespace NBitcoin.Dash.Tests
{
    public class DashNetworksTests
    {
        [Fact]
        public void ShouldGenerateAndParsePrivateKeyTest()
        {
            var key = new Key();
            var privateKey = key.GetWif(DashNetworks.Testnet).ToString();
            var address = key.PubKey.GetAddress(DashNetworks.Testnet).ToString();

            Assert.Equal(DashNetworks.Testnet, BitcoinAddress.Create(address).Network);
            Assert.Equal(address, new BitcoinSecret(privateKey, DashNetworks.Testnet).GetAddress().ToString());
        }

        [Fact]
        public void ShouldGenerateAndParsePrivateKeyMain()
        {
            var key = new Key();
            var privateKey = key.GetWif(DashNetworks.Mainnet).ToString();
            var address = key.PubKey.GetAddress(DashNetworks.Mainnet).ToString();

            Assert.Equal(DashNetworks.Mainnet, BitcoinAddress.Create(address).Network);
            Assert.Equal(address, new BitcoinSecret(privateKey, DashNetworks.Mainnet).GetAddress().ToString());
        }
    }
}
