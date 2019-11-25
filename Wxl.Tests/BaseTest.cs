namespace Wxl.Tests
{
    public abstract class BaseTest<T>
    {
        protected T _test;
        
        public T Given { 
            get {
                return _test;
            }
        }

        public T And
        {
            get
            {
                return _test;
            }
        }

        public T When
        {
            get
            {
                return _test;
            }
        }

        public T Then
        {
            get
            {
                return _test;
            }
        }
    }
}
