class Bai7 : BaiTap
{
    public Bai7() : base(7, "Phần tử lớn thứ hai")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        int[] nums = NhapMangInt();

        int ketQua = LonThuHai(nums);

        if (ketQua == int.MinValue)
        {
            Console.WriteLine("Không tồn tại phần tử lớn thứ hai");
        }
        else
        {
            Console.WriteLine("Phần tử lớn thứ hai là: " + ketQua);
        }
    }

    public int LonThuHai(int[] nums)
    {
        if (nums.Length == 0)
        {
            return int.MinValue;
        }

        int lon = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > lon)
            {
                lon = nums[i];
            }
        }

        int thuHai = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < lon && nums[i] > thuHai)
            {
                thuHai = nums[i];
            }
        }

        return thuHai;
    }
}
