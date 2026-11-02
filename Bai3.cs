class Bai3 : BaiTap
{
    public Bai3() : base(3, "Loại phần tử trùng lặp")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        int[] ketQua = LoaiTrung(nums);

        Console.Write("Mảng sau khi loại trùng: ");
        InMang(ketQua);
        Console.WriteLine();
    }

    public int[] LoaiTrung(int[] nums)
    {
        HashSet<int> daGap = new HashSet<int>();
        List<int> ketQua = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (daGap.Add(nums[i]))
            {
                ketQua.Add(nums[i]);
            }
        }

        return ketQua.ToArray();
    }
}
