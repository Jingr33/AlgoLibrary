# AlgoLibrary
**AlgoLibrary** is a C# class library containig implementations of fundamental algorithms for:
- Sorting
- Tree structures
- Heaps
- Graph algorithms

## Sorting Algorithms
There are several types of sorting algorithms divided into two categories.

### Generic Types Sorting
These work with any data type that supports comparison via a custom `Func<T, T, bool>` delegate.
Interface: `ISortingAlgo`
Algorithms:
* `BubbleSort()`
* `SelectionSort()`
* `InsertionSort()`
* `MergeSort()`
* `QuickSort()`

### Integer Arrays Sorting
These are optimized for `int[]` input.
Interface: `IIntSortingAlgo`
Algorithms:
* `CountingSort()`
* `RadixSort()`

Sorting order can be specified (ascending or descending).

## Heaps, Trees, Graphs
Coming soon...
