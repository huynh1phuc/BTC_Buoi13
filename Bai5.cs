class Bai5 : BaiTap
{
    public Bai5() : base(5, "Hợp hai danh sách")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        Console.WriteLine("Mảng a:");
        int[] a = NhapMangInt();

        Console.WriteLine("Mảng b:");
        int[] b = NhapMangInt();

        int[] ketQua = Hop(a, b);

        Console.Write("Hợp của hai mảng: ");
        InMang(ketQua);
        Console.WriteLine();
    }

    public int[] Hop(int[] a, int[] b)
    {
        HashSet<int> daGap = new HashSet<int>();
        List<int> ketQua = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (daGap.Add(a[i]))
            {
                ketQua.Add(a[i]);
            }
        }

        for (int i = 0; i < b.Length; i++)
        {
            if (daGap.Add(b[i]))
            {
                ketQua.Add(b[i]);
            }
        }

        return ketQua.ToArray();
    }
}
