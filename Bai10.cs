class Bai10 : BaiTap
{
    public Bai10() : base(10, "Đếm mảng con có tổng bằng K")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        Console.Write("Nhập k: ");
        int k = int.Parse(Console.ReadLine());

        int ketQua = DemMangConCoTongK(nums, k);

        Console.WriteLine("Số mảng con liên tiếp có tổng bằng " + k + " : " + ketQua);
    }

    public int DemMangConCoTongK(int[] nums, int k)
    {
        Dictionary<int, int> dem = new Dictionary<int, int>();
        dem[0] = 1;

        int tong = 0;
        int ketQua = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            tong = tong + nums[i];

            if (dem.ContainsKey(tong - k))
            {
                ketQua = ketQua + dem[tong - k];
            }

            if (dem.ContainsKey(tong))
            {
                dem[tong]++;
            }
            else
            {
                dem[tong] = 1;
            }
        }

        return ketQua;
    }
}
