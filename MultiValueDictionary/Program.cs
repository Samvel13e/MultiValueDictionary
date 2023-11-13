class MyClass
{
    public static void Main()
    {
        var dic = new MultiValueDictionary.MultiValueDictionary<int, string>();

        dic.Add(1, "dasd");
        dic.Add(1, "iopui");
        dic.Add(2, "dasdfgd");

        dic.Add(3, "dfgdasd");
        dic.Add(4, "dgdasdgdd");

        dic.Add(12, "dfgQWEREdasd");
        dic.Add(15, "dasd");

        dic.Add(12, "dasd");



        foreach (var item in dic)
        {
            Console.WriteLine(item.Key + " // " + item.Value);
        }

        var kk = dic.Get(1);
        dic.Remove(1, "dasd");
        var ddd = dic[1];
        dic.Clear();
    }

}