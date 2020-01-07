namespace WordpressAutomationTests.Core.Infrastructure
{
    public class EmptyAsserts<TElements> : AssertsBase<TElements>
        where TElements : ElementsBase
    {
        public EmptyAsserts() 
            : base(null, null)
        {
        }
    }
}
