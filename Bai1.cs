class Bai1 : BaiTap
{
    public Bai1() : base(1, "Tổng các số thỏa điều kiện")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        Console.Write("Nhập mốc: ");
        int moc = int.Parse(Console.ReadLine());

        long ketQua = TongLonHon(nums, moc);

        Console.WriteLine("Tổng các phần tử lớn hơn " + moc + " : " + ketQua);
    }

    public long TongLonHon(int[] nums, int moc)
    {
        long tong = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > moc)
            {
                tong = tong + nums[i];
            }
        }

        return tong;
    }
}
