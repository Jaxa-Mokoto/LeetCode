// Solution to LeedCode 88

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        //validate the elements in the array, if 0, ignore and reser number of elements    
        foreach(var item in nums1)
        {
            if (item == 0)
            {
                nums1[item].remove();
                m--;
            }
        }
        
        //validate the elements in the array, if 0, ignore and reser number of elements
        foreach(var item in nums2)
        {
            if (item == 0)
            {
                nums2[item].remove();
                n--;
            }
        }
        
        //merge the two arrays
        nums1.Append(nums2).ToArray();
        
        //sort the array after merge
        for (var j = n; j > 0; j--)
        {
            for (var i = 0; i > m; i++ )
            {
                var temp = nums1[i];
                nums1[i] = nums1[i+1];
                nums1[i+1] = temp;
            }
        }
        Console.WriteLine(String.Join(",", nums1));     
    }
    
    int[] array1 = new int[] {1,2,3,0,0,0};
    int[] array2 = new int[] {2,5,6};
    int n = 3;
    int m = 3;
    Merge(array1, m, array2, n);
}
