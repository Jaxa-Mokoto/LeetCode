/* You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:

numberOfBoxesi is the number of boxes of type i.
numberOfUnitsPerBoxi is the number of units in each box of the type i.
You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.

Return the maximum total number of units that can be put on the truck.

 

Example 1:

Input: boxTypes = [[1,3],[2,2],[3,1]], truckSize = 4
Output: 8
Explanation: There are:
- 1 box of the first type that contains 3 units.
- 2 boxes of the second type that contain 2 units each.
- 3 boxes of the third type that contain 1 unit each.
You can take all the boxes of the first and second types, and one box of the third type.
The total number of units will be = (1 * 3) + (2 * 2) + (1 * 1) = 8.
Example 2:

Input: boxTypes = [[5,10],[2,5],[4,7],[3,9]], truckSize = 10
Output: 91
 

Constraints:

1 <= boxTypes.length <= 1000
1 <= numberOfBoxesi, numberOfUnitsPerBoxi <= 1000
1 <= truckSize <= 106 */
    
using System;

public class TruckUnits
{
    public static void Main(string[] args)
    {
    	int[,] boxTypes = new int[3, 2] { { 1, 3 }, { 2, 2 }, { 3, 1 } };
    	TruckUnits myTruckUnits = new TruckUnits();
		myTruckUnits.MaximumUnits(boxTypes, 4);
    }
    
    public int[,] Sort2DArray(int[,] boxTypes)
    {
        var tempKey = 0;
        var tempVal = 0;
        
        for (var i = 0; i <= boxTypes.GetLength(0)-1; i ++)
        {
            for (var j = i+1; j <= boxTypes.GetLength(0)-1; j++)
            {
              	tempKey = boxTypes[i, 0];
                tempVal = boxTypes[i, 1];
                
                if (boxTypes[i, 0] > boxTypes[j, 0])
                {
                    boxTypes[i,0] = boxTypes[j,0];
                    boxTypes[i, 1] = boxTypes[j, 1];
                    boxTypes[j,0] = tempKey;
                    boxTypes[j, 1] = tempVal;
                }

            }
        }
        return boxTypes;
    } 
    
  	public int MaximumUnits(int[,] boxTypes, int truckSize) 
    {
        int remainingTruckSize = truckSize;
        int boxCount = 0;
        int currentUnits = 0;
        
    	TruckUnits myTruckUnits = new TruckUnits();
		myTruckUnits.Sort2DArray(boxTypes);
        
        for (var i = 0; i <= boxTypes.GetLength(0); i ++)
        {
            boxCount = Math.Min(remainingTruckSize, boxTypes[i, 0]);
            currentUnits = currentUnits + (boxCount * boxTypes[i, 1]);
            remainingTruckSize = remainingTruckSize - boxCount;

			if (remainingTruckSize == 0)
            {
            	Console.WriteLine($"Total units are: {currentUnits}");
            	return currentUnits;
            }
        }
        return currentUnits;
    }
}
