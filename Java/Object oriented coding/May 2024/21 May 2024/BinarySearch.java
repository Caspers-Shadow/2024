public class BinarySearch
{
	public static int binSearch(int[] list, int key, int low, int high)
	{
		if(low > high)
			return -1;
		
		int mid = (low+high)/2;
		
		if(key < list[mid])
		{
			return binSearch(list,key,low,mid-1);
		}
		else if(key == list[mid])
		{
			return mid;
		}
		else
			return binSearch(list,key,mid+1,high);
		
	}
	
	public static void main(String args[])
	{
		System.out.println("\n\n====BINARY SEARCH====\n");
		int[] values = {5, 4, 2, 7, 8, 22, 19, 14, 11};
		int search =22;
		int pos = binSearch(values, search, 0, values.length-1);
		System.out.println(search + " is at position " + pos);
	}
}