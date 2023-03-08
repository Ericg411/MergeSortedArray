using MergeSortedArray;

namespace tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1() { _test = new Class1(); }
    
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 = { 2, 5, 6 };
        int n = 3;
        
        _test.Merge(nums1, m, nums2, n);
        bool sortedNoDupes = true;
        int dupeCheck = -1; 

        for (int i = 0; i < nums1.Length; i++)
        {
            if (i == 0)
            {
                dupeCheck = nums1[i];
                continue;
            }
            if (nums1[i] == dupeCheck) 
            {
                sortedNoDupes = false;
            }
        }

        Assert.IsTrue(sortedNoDupes);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums1 = { 1 };
        int m = 1;
        int[] nums2 = null;
        int n = 0;
        
        _test.Merge(nums1, m, nums2, n);
        bool sortedNoDupes = true;
        int dupeCheck = -1; 

        for (int i = 0; i < nums1.Length; i++)
        {
            if (i == 0)
            {
                dupeCheck = nums1[i];
                continue;
            }
            if (nums1[i] == dupeCheck) 
            {
                sortedNoDupes = false;
            }
        }

        Assert.IsTrue(sortedNoDupes);
    }   
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums1 = { 0 };
        int m = 0;
        int[] nums2 = { 1 };
        int n = 1;
        
        _test.Merge(nums1, m, nums2, n);
        bool sortedNoDupes = true;
        int dupeCheck = -1; 

        for (int i = 0; i < nums1.Length; i++)
        {
            if (i == 0)
            {
                dupeCheck = nums1[i];
                continue;
            }
            if (nums1[i] == dupeCheck) 
            {
                sortedNoDupes = false;
            }
        }

        Assert.IsTrue(sortedNoDupes);
    }
}