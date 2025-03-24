public class Testing
{
	public static void main(String args[])
	{
		String num = "12345678";
		int lengte = num.length(); 
		int[] digitArray = new int[lengte];
		
		if (lengte == 8)
		{			
			int j = 8;
			int sum = 0;
			int finalMod = 0;
			for (int i = 0; i < lengte; i++) 
			{
            digitArray[i] = Character.getNumericValue(num.charAt(i));			
			sum = sum + (digitArray[i] * j);			
			j--;
			}
			
			finalMod = sum %11;
			
			if(finalMod != 0)
			{
				System.out.println("Invalid!!!!!!!!!!!");
				
			}
		}		
	}
}	
	