using System;

namespace Day22_BinarySearchTrees
{
    public class NonEmptyBST<D> : ITree<D> where D : IComparable
    {
        D data;
        ITree<D> left;
        ITree<D> right;

        public NonEmptyBST(D elt)
        {
            data = elt;
            left = new EmptyBST<D>();
            right = new EmptyBST<D>();
        }

        public NonEmptyBST(D elt, ITree<D> leftTree, ITree<D> rightTree)
        {
            data = elt;
            left = leftTree;
            right = rightTree;
        }


        public bool IsEmpty()
        {
            return false;
        }

        /*
         * This method recursively adds up the number of elements of the BST with
         * this node as the root.
         * 
         * Using the example below;
         *       6      lvl A
         *     /   \
         *    3     8   lvl B
         *   / \   / \
         *  1   4 6   9 lvl C
         *  
         *  The cardinality of '6' is 7 because there are 7 elements in it's set.
         *  Recursion comes into play here because a NonEmptyBST will always return 1,
         *  whilst an EmptyBST will return 0. We're working down the tree until all
         *  1's are added up.
         */
        public int Cardinality()
        {
            return 1 + left.Cardinality() + right.Cardinality();
        }

        /*
         * Here's another method which makes use of the BST structure in order to
         * practise recursion.
         * What's happening here is; 
         *  'if the supplied `elt` is equal to data then true is returned'
         *  'else if `elt` is less than data, invoke Member on the left tree'
         *  'else invoke Member on the right tree'
         * These three statements are repeated until either true is returned
         * or the 'base case' is reached, that is we reach an EmptyBST.
         */
        public bool Member(D elt)
        {
            if (elt.CompareTo(data) == 0)
            {
                return true;
            }
            else
            {
                if (elt.CompareTo(data) < 0)
                {
                    return left.Member(elt);
                }
                else
                {
                    return right.Member(elt);
                }
            }
        }

        /*
         * In the first case, the element we're attempting to add already exists,
         * so we can return it.
         * Now here's the recursion again, if the element we're adding is less than
         * the root node then we return a new NonEmptyBST with the new supplied
         * element in the left child node. And the right child node stays the same.
         * When the element we're adding is greater than the root node, we return a
         * new NonEmptyBST with the element included in the right child node, and the
         * left child node remaining the same.
         */
        public NonEmptyBST<D> Add(D elt)
        {
            if (elt.CompareTo(data) == 0)
            {
                return this;
            }
            else
            {
                if(elt.CompareTo(data) < 0)
                {
                    return new NonEmptyBST<D>(data, left.Add(elt), right);
                } else
                {
                    return new NonEmptyBST<D>(data, left, right.Add(elt));
                }
            }

        }
    }
}