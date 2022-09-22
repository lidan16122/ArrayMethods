namespace ArrayMethods;

public class Tests
{
    int[] Append(int[] arr, int item)
    {
        if (arr == null || arr.Length == 0) return new int[] { item };
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[arr.Length] = item;
        return newArr;
    }

    [TestCase(new int[] { 1, 2 }, 3, ExpectedResult = new int[] { 1, 2, 3 })]
    [TestCase(new int[] { 23, 7 }, 1, ExpectedResult = new int[] { 23, 7, 1 })]
    public int[] Append_Test(int[] arr, int item)
    {
        return Append(arr, item);
    }

    
    int[] GetIndexes(int[] arr, int num)
    { 
        int count = 0;
        int[] newArr = new int[CountingIndexesEven(arr,num)];
        for (int i = 0; i < arr.Length; i++)
        {
           if (arr[i] == num)
            {
                newArr[count] = i;
                count++;
            } 
        }
        if (newArr.Length == 0) return null;
        return newArr;
    }
    int CountingIndexesEven(int[] arr, int num){
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                count++;
            }
        }
        return count;
    }

    [TestCase(new int[] { 1, 2, 1, 5, 9, 2 }, 1, ExpectedResult = new int[] { 0, 2 })]
    [TestCase(new int[] { 1, 4, 1, 5, 9, 2 }, 3, ExpectedResult = null)]
    public int[] GetIndexes_Test(int[] arr, int num)
    {
        return GetIndexes(arr, num);
    }

    int[] GetItemsAbove(int[] arr,int num){
        int[] newArr = new int[CountingIndexesBigger(arr,num)];
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > num)
            {
                newArr[count] = arr[i];
                count++;
            }
        }
        if (newArr.Length == 0) return null;
        return newArr;
    }
    int CountingIndexesBigger(int[] arr,int num){
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > num)
            {
                count++;
            }
        }
        return count;
    }

    [TestCase(new int[] {1,4,1,5,9,2} ,4,ExpectedResult = new int[] {5,9})]
    [TestCase(new int[] {1,4,1,5,9,2} ,31,ExpectedResult = null)]
    public int[] GetItemsAbove_Test(int[] arr,int num){
        return GetItemsAbove(arr,num);
    }
    int[] GetItemsExcept(int[] arr, int num){
     int[] newArr = new int[CountingIndexesDiff(arr,num)];
     int count = 0;
         for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != num)
            {
                newArr[count] = arr[i];
                count++;
            }
        }
        if (newArr.Length == 0) return null;
        return newArr;
    }

    int CountingIndexesDiff(int[] arr,int num){
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != num)
            {
                count++;
            }
        }
        return count;
    }

    [TestCase(new int[] {1,4,1,5,9,2},1,ExpectedResult=new int[] {4,5,9,2})]
    public int[] GetItemsExcept_Test(int[] arr,int num){
        return GetItemsExcept(arr,num);
    }

    int[] GetAllContains(int[] arr, int num)
    {
        
        int[] newArr = new int[CountingIndexesContain(arr, num)];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].ToString().Contains(num.ToString()))
            {
                newArr[count] = arr[i];
                count++;
            }
        }
         if (newArr.Length == 0) return null;
        return newArr;
    }

    int CountingIndexesContain(int[] arr, int num)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
                
            if (arr[i].ToString().Contains(num.ToString()))
            {
                count++;
            }
            
        }
        return count;
    }

    [TestCase(new int[] { 11, 4, 15, 5, 1, 29, 2 }, 1, ExpectedResult = new int[] { 11, 15, 1 })]
    [TestCase(new int[] { 11, 4, 15, 5, 1, 29, 2 }, 30, ExpectedResult = null)]
    public int[] GetAllContains_Test(int[] arr, int num)
    {
        return GetAllContains(arr, num);
    }

    int[] GetSorted(int[] arr){
        int temp;
         for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = 0; j < arr.Length - 1; j++) {
               if (arr[j] > arr[j + 1]) {
                  temp= arr[j + 1];
                  arr[j + 1] = arr[j];
                  arr[j] = temp;
               }
            }
         }
         return arr;
    }

    [TestCase(new int[] { 3, 2, 1 },ExpectedResult= new int[] { 1, 2, 3 })]
    [TestCase(new int[] { 3, 2, 5, 4, 1},ExpectedResult= new int[] { 1, 2, 3 , 4, 5})]
    public int[] GetSorted_Test(int[] arr){
        return GetSorted(arr);
    }

    bool AreItemsSame(int[] arr){
        bool isCellsSame = true;
        if (arr.Length == 0 || arr == null ) return isCellsSame;
        int firstIndex = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != firstIndex)
                return isCellsSame = false;
        }
        return isCellsSame;

    }
    
    [TestCase(new int[] {1,4,1}, ExpectedResult=false)]
    [TestCase(new int[] {4,4,4}, ExpectedResult=true)]
    [TestCase(new int[] {}, ExpectedResult=true)]
    public bool AreItemsSame_Test(int[] arr){
        return AreItemsSame(arr);
    }
}