class Bai9 : BaiTap
{
    public Bai9() : base(9, "Kiểm tra phần tử trùng lặp")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        bool ketQua = CoTrungLap(nums);

        if (ketQua)
        {
            Console.WriteLine("true: Mảng có phần tử trùng lặp");
        }
        else
        {
            Console.WriteLine("false: Mảng không có phần tử trùng lặp");
        }
    }

    public bool CoTrungLap(int[] nums)
    {
        HashSet<int> daGap = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (daGap.Add(nums[i]) == false)
            {
                return true;
            }
        }

        return false;
    }
}
