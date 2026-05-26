namespace VPWebsiteMVC
{
    public static class HeThong
    {
        public static string SQLName = @"DESKTOP-OG86JQJ\MSSQLSERVER05"; //Tên Server Name của SQL
        public static string SQLUser = "sa"; //Tên User đăng nhập SQL
        public static string SQLPass = "123"; //Mật khẩu đăng nhập SQL
        public static string Database = "VonBangTien"; //Tên CSDL dự án đã restore
        public static string tencongty = "CÔNG TY TNHH FPT IS"; //Tên công ty đầy đủ
        public static string diachi = "Số 10 phố Phạm Văn Bạch, Phường Cầu Giấy, Hà Nội, Việt Nam"; //Địa chỉ
        public static string masothue = "0104128565"; //Mã số thuế
        public static string sodienthoai = "0866224368"; //Số điện thoại công ty
        public static string giamdoc = "Nguyễn Hoàng Minh"; //Họ tên giám độc
        public static string tensv = "Trương Thị Hà"; //Họ tên sinh viên
        public static string gvhd = "ThS. Hoàng Hải Xanh"; //Họ tên GVHD
        public static string ktt = "Phạm Quang Duy"; //Họ tên kế toán trưởng

        public static string SendKey = "";
        public static string Accept = "8954412D512Tà12Th12Nh120512CS127212";

        public static VPConnectDB.Models.N0Para P_ThamSo { get; set; } = new VPConnectDB.Models.N0Para();
        public static VPConnectDB.Models.N0Mes P_ThongBao = new VPConnectDB.Models.N0Mes();

    }
}
