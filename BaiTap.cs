abstract class BaiTap
{
    private int soBai;
    private string tieuDe;

    protected BaiTap(int soBai, string tieuDe)
    {
        this.soBai = soBai;
        this.tieuDe = tieuDe;
    }

    public abstract void Chay();

    protected void InTieuDe()
    {
        Console.WriteLine("Bài " + soBai + ": " + tieuDe);
    }

    protected int[] NhapMangInt()
    {
        Console.Write("Nhập các số nguyên, cách nhau bởi dấu cách: ");
        string input = Console.ReadLine();

        string[] chuoiSo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[chuoiSo.Length];

        for (int i = 0; i < chuoiSo.Length; i++)
        {
            nums[i] = int.Parse(chuoiSo[i]);
        }

        return nums;
    }

    protected double[] NhapMangDouble()
    {
        Console.Write("Nhập các điểm, cách nhau bởi dấu cách: ");
        string input = Console.ReadLine();

        string[] chuoiSo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double[] diem = new double[chuoiSo.Length];

        for (int i = 0; i < chuoiSo.Length; i++)
        {
            diem[i] = double.Parse(chuoiSo[i]);
        }

        return diem;
    }

    protected void InMang(int[] nums)
    {
        Console.Write("[");

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);

            if (i < nums.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.Write("]");
    }
}
