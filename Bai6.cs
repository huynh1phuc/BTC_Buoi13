class Bai6 : BaiTap
{
    public Bai6() : base(6, "Giao hai danh sách")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        Console.WriteLine("Mảng a:");
        int[] a = NhapMangInt();

        Console.WriteLine("Mảng b:");
        int[] b = NhapMangInt();

        int[] ketQua = Giao(a, b);

        Console.Write("Giao của hai mảng: ");
        InMang(ketQua);
        Console.WriteLine();
    }

    public int[] Giao(int[] a, int[] b)
    {
        HashSet<int> tapB = new HashSet<int>();
        List<int> ketQua = new List<int>();

        for (int i = 0; i < b.Length; i++)
        {
            tapB.Add(b[i]);
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (tapB.Contains(a[i]))
            {
                ketQua.Add(a[i]);
                tapB.Remove(a[i]);
            }
        }

        return ketQua.ToArray();
    }
}
