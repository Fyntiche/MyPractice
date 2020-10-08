using System.Collections;

namespace _51_UserCollection.UserCollection
{
    internal class UserCollection : IEnumerable, IEnumerator
    {
        private Element[] userCollections = null;

        public UserCollection()
        {
            userCollections = new Element[4];
            userCollections[0] = new Element("1", "1", "1");
            userCollections[1] = new Element("2", "2", "2");
            userCollections[2] = new Element("3", "3", "3");
            userCollections[3] = new Element("4", "4", "4");
        }

        private int current = -1;
        public object Current => userCollections[current];

        public bool MoveNext()
        {
            if (current < userCollections.Length - 1)
            {
                current++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            current = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}