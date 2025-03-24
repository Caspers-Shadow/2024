public class Search
{
	public static int linSearch(int[] list, int searchVal)
	{
		for(int i=0;i<= list.length;i++)
		{
			if(list[i] == searchVal)
				return i+1;
		}
		return -1;
		
	}
	
	public static void main(String args[])
	{
		System.out.println("\n\n====LINEAR SEARCH====\n");
		int[] values = {5, 4, 2, 7, 8, 22, 19, 14, 11};
		int search = 8;
		int pos = linSearch(values, search);
		System.out.println(search + " is at position " + pos);
	}
}