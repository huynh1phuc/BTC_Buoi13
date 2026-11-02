class Bai8 : BaiTap
{
    public Bai8() : base(8, "Thống kê xếp loại")
    {
    }

    public override void Chay()
    {
        InTieuDe();

        double[] diem = NhapMangDouble();

        Dictionary<string, int> ketQua = ThongKeXepLoai(diem);

        foreach (KeyValuePair<string, int> cap in ketQua)
        {
            Console.WriteLine(cap.Key + ": " + cap.Value);
        }
    }

    public Dictionary<string, int> ThongKeXepLoai(double[] diem)
    {
        Dictionary<string, int> ketQua = new Dictionary<string, int>();
        ketQua["Giỏi"] = 0;
        ketQua["Khá"] = 0;
        ketQua["Trung bình"] = 0;
        ketQua["Yếu"] = 0;

        for (int i = 0; i < diem.Length; i++)
        {
            if (diem[i] >= 8)
            {
                ketQua["Giỏi"]++;
            }
            else if (diem[i] >= 6.5)
            {
                ketQua["Khá"]++;
            }
            else if (diem[i] >= 5)
            {
                ketQua["Trung bình"]++;
            }
            else
            {
                ketQua["Yếu"]++;
            }
        }

        return ketQua;
    }
}
