using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_BinarySearchTrees
{
    /*
        ITree specifies an interface which NonEmptyBST and EmptyBST implement.
        Note the declaration header `<D> where D: IComparable` this informs us
        that a class implementing this interface must also implement IComparable.
        This design decision is based on the BST rule where the left child node
        is less than the parent node, and the right child node is greater than 
        the parent node.

        Note that <D> refers to the Generic type.
     */
    public interface ITree<D> where D: IComparable
    {
        bool IsEmpty();
        // Cardinality means 'number of elements in a set'.
        int Cardinality();
        // Use of D here, the element passed as `elt` must be the same type as
        // the class implementing ITree.
        bool Member(D elt);
        // This method returns a NonEmptyBST of type D.
        NonEmptyBST<D> Add(D elt);
    }
}
