class Bai2 : BaiTap
{
    public Bai2() : base(2, "Sắp xếp tăng và giảm")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        (int[] tang, int[] giam) ketQua = SapXepHaiChieu(nums);

        Console.Write("Mảng tăng dần: ");
        InMang(ketQua.tang);
        Console.WriteLine();

        Console.Write("Mảng giảm dần: ");
        InMang(ketQua.giam);
        Console.WriteLine();

        Console.Write("Mảng gốc: ");
        InMang(nums);
        Console.WriteLine();
    }

    public (int[] tang, int[] giam) SapXepHaiChieu(int[] nums)
    {
        List<int> tang = new List<int>();
        List<int> giam = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            tang.Add(nums[i]);
            giam.Add(nums[i]);
        }

        tang.Sort();

        giam.Sort();
        giam.Reverse();

        return (tang.ToArray(), giam.ToArray());
    }
}
