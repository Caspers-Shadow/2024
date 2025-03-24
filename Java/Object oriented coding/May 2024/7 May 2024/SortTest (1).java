import java.util.*;
class SortTest 
{
	public static void main(String[] args) 
	{
		int [] data = new int[100000000];
		Scanner input = new Scanner(System.in);
		boolean sorted = true;
		int i=-1;
		int num;
		long time0=System.currentTimeMillis();      
		while (input.hasNextInt())
		{
			data[++i] = input.nextInt();
		}
		num = i++;
		long time1=System.currentTimeMillis();      
		System.out.println("Finished reading data, time to read data = "+(time1-time0)/1000.0+" seconds");
		
		
		Arrays.sort(data,0,num);
		
		
		long time2=System.currentTimeMillis();
		System.out.println("\nFinished sorting data, time to sort data = "+(time2-time1)/1000.0+" seconds");
		i=1;
		while (i<num && sorted)
		{
			if (data[i]<data[i-1])
			sorted = false;
			i++;
		}
		if(sorted)
			System.out.println("Sorted");
		else
			System.out.println("Not sorted");
				
	}
}