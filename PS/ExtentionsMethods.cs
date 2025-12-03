// To Create Extention Methods::

// You must Create Another Class From Type ( Static ) & All Methods you Created in this Class must be From The Type ( Static )
// عشان اقدر اني استدعيها من خلال كتابة اسم الكلاس مباشرة بدون انشاء كائن من ذلك الكلاس Static الدوال جوا الكلاس من نوع 
// You must use Keyword ( this ) before The First Parameter 


namespace PS
{
    public static class ExtentionsMethods
    {
        public static IEnumerable<int> Is_Even(this IEnumerable<int> lst, Predicate<int> predicate) 
        {
            foreach (int item in lst) 
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
