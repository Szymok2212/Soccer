using Soccer.Logic;

namespace Soccesr.Logic.Tests
{
    class TestLuckFactory : ILuckFactory
    {
        private readonly int retrunValue;

        public TestLuckFactory(int retrunValue)
        {
            this.retrunValue = retrunValue;
        }

        public int GetLuck()
        {
            return retrunValue;
        }
    }
}
