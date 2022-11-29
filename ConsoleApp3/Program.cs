int FindElement<T>(T [] arr,CheckNumber<T> ch)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (ch(arr[i]))
		{
			return i;
		}
	}
    return -1;
}

bool IsZero(int element)
{
	if(element == 0)
	{
		return true;
	}
	return false;
}

Console.WriteLine(FindElement(new int[] {-1,2,0,3,0}, IsZero));

delegate bool CheckNumber<K>(K element);