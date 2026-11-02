class Bai4 : BaiTap
{
    public Bai4() : base(4, "Đếm tần suất phần tử")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        Dictionary<int, int> ketQua = DemTanSuat(nums);

        foreach (KeyValuePair<int, int> cap in ketQua)
        {
            Console.WriteLine("Giá trị " + cap.Key + " xuất hiện " + cap.Value + " lần");
        }
    }

    public Dictionary<int, int> DemTanSuat(int[] nums)
    {
        Dictionary<int, int> dem = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dem.ContainsKey(nums[i]))
            {
                dem[nums[i]]++;
            }
            else
            {
                dem[nums[i]] = 1;
            }
        }

        return dem;
    }
}
