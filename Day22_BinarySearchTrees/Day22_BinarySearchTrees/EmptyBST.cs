using System;

namespace Day22_BinarySearchTrees
{
    public class EmptyBST<D> : ITree<D> where D : IComparable
    {
        public EmptyBST()
        {

        }
        public bool IsEmpty()
        {
            return true;
        }

        public int Cardinality()
        {
            return 0;
        }

        public bool Member(D elt)
        {
            return false;
        }

        public NonEmptyBST<D> Add(D elt)
        {
            return new NonEmptyBST<D>(elt);
        }
    }
}