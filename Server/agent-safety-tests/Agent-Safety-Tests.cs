using Microsoft.VisualStudio.TestTools.UnitTesting;
using agent_safety;

namespace agent_safety_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgentOverdue_True()
        {
            var isOverDue = Program.IsOverdue();                        
            Assert.IsTrue(isOverDue);
        }

        [TestMethod]
        public void AgentOverdue_False()
        {
            var isOverDue = Program.IsOverdue();                        
            Assert.IsFalse(isOverDue);
        }
    }
}
