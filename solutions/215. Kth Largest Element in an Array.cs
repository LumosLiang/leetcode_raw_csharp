class Heap
{
    private List<int> _heap;
    private int _length;
​
    public Heap()
    {
        _heap = new List<int>();
        _length = 0;
    }
​
    public void Enqueue(int num)
    {
        _heap.Add(num);
        _length++;
        SiftUp(_length - 1);
    }
​
    private void SiftUp(int start)
    {
        int currIdx = start;
        int parentIdx = (start - 1) / 2;
​
        while (parentIdx >= 0)
        {
            if (_heap[parentIdx] > _heap[currIdx])
            {
                Swap(_heap, parentIdx, currIdx);
                currIdx = parentIdx;
                parentIdx = (currIdx - 1) / 2;
            }
            else
                break;
        }
​
    }
​
    public int Dequeue()
    {
        if (_length == 0) throw new IndexOutOfRangeException();
        Swap(_heap, 0, _length - 1);
        var res = _heap[_length - 1];
        _heap.RemoveAt(_length - 1);
        _length--;
        SiftDown(0);
        return res;
    }
​
    private void SiftDown(int start)
    {
        int currIdx = start;
        int left = currIdx * 2 + 1;
​
        while (left < _length)
        {
            if (left + 1 < _length && _heap[left + 1] < _heap[left])
                left++;
            if (_heap[currIdx] > _heap[left])
            {
                Swap(_heap, currIdx, left);
                currIdx = left;
                left = currIdx * 2 + 1;
            }
            else
                break;
        }
​
    }
​
    private void Swap(List<int> nums, int left, int right)
    {
