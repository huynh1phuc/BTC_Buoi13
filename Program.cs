class Program
{
    static void Main()
    {
        List<BaiTap> danhSachBai = new List<BaiTap>();
        danhSachBai.Add(new Bai1());
        danhSachBai.Add(new Bai2());
        danhSachBai.Add(new Bai3());
        danhSachBai.Add(new Bai4());
        danhSachBai.Add(new Bai5());
        danhSachBai.Add(new Bai6());
        danhSachBai.Add(new Bai7());
        danhSachBai.Add(new Bai8());
        danhSachBai.Add(new Bai9());
        danhSachBai.Add(new Bai10());

        while (true)
        {
            Console.WriteLine("Chọn bài muốn thực hiện (1 - 10), gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát:");
            string choice = Console.ReadLine();

            if (choice == "exit")
            {
                return;
            }

            if (choice == "all")
            {
                for (int i = 0; i < danhSachBai.Count; i++)
                {
                    danhSachBai[i].Chay();
                    Console.WriteLine();
                }
            }
            else
            {
                int so;
                if (int.TryParse(choice, out so) && so >= 1 && so <= danhSachBai.Count)
                {
                    danhSachBai[so - 1].Chay();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 1 đến 10 hoặc gõ 'all' để chạy tất cả hoặc gõ 'exit' để thoát.");
                }
            }
        }
    }
}
