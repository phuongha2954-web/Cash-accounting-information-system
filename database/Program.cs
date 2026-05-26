using Microsoft.Data.SqlClient;
using VPWebsiteMVC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache(); // Bắt buộc để sử dụng Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Thời gian tồn tại của Session
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

/* Lấy thông tin Database vào DLL */
VPConnectDB.Datas.InforDB.SQLName = HeThong.SQLName;
VPConnectDB.Datas.InforDB.SQLUser = HeThong.SQLUser;
VPConnectDB.Datas.InforDB.SQLPass = HeThong.SQLPass;
VPConnectDB.Datas.InforDB.Database = HeThong.Database;
VPConnectDB.Datas.InforDB.tencongty = HeThong.tencongty;
VPConnectDB.Datas.InforDB.diachi = HeThong.diachi;
VPConnectDB.Datas.InforDB.masothue = HeThong.masothue;
VPConnectDB.Datas.InforDB.sodienthoai = HeThong.sodienthoai;
VPConnectDB.Datas.InforDB.giamdoc = HeThong.giamdoc;
VPConnectDB.Datas.InforDB.ktt = HeThong.ktt;
VPConnectDB.Datas.InforDB.tensv = HeThong.tensv;
VPConnectDB.Datas.InforDB.gvhd = HeThong.gvhd;
VPConnectDB.Datas.InforDB.SendKey = HeThong.SendKey;
VPConnectDB.Datas.InforDB.Accept = HeThong.Accept;

VPConnectDB.ConnectDB.WriteRegKey("Login", "SQLName", VPConnectDB.Datas.InforDB.SQLName);
VPConnectDB.ConnectDB.WriteRegKey("Login", "SQLUser", VPConnectDB.Datas.InforDB.SQLUser);
VPConnectDB.ConnectDB.WriteRegKey("Login", "SQLPass", VPConnectDB.Datas.InforDB.SQLPass);
VPConnectDB.ConnectDB.WriteRegKey("Login", "Database", VPConnectDB.Datas.InforDB.Database);

VPConnectDB.ConnectDB.WriteRegKey("Login", "tencongty", VPConnectDB.Datas.InforDB.tencongty);
VPConnectDB.ConnectDB.WriteRegKey("Login", "diachi", VPConnectDB.Datas.InforDB.diachi);
VPConnectDB.ConnectDB.WriteRegKey("Login", "masothue", VPConnectDB.Datas.InforDB.masothue);
VPConnectDB.ConnectDB.WriteRegKey("Login", "giamdoc", VPConnectDB.Datas.InforDB.giamdoc);
VPConnectDB.ConnectDB.WriteRegKey("Login", "ktt", VPConnectDB.Datas.InforDB.ktt);
VPConnectDB.ConnectDB.WriteRegKey("Login", "tensv", VPConnectDB.Datas.InforDB.tensv);
VPConnectDB.ConnectDB.WriteRegKey("Login", "gvhd", VPConnectDB.Datas.InforDB.gvhd);
VPConnectDB.ConnectDB.WriteRegKey("Login", "Accept", VPConnectDB.Datas.InforDB.Accept);

VPConnectDB.Datas.InforDB.sodienthoai = "0866223638"; // Số điện thoại của bạn
VPConnectDB.Datas.InforDB.LoadRegistry();
VPConnectDB.Datas.InforDB.LoadThongTin();
VPConnectDB.Datas.InforDB.btnSend_Click();
VPConnectDB.Datas.InforDB.btnOk_Click();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession(); // Kích hoạt Session

app.UseRouting();

app.UseAuthorization();

/*Xử lý lỗi kết nối*/
if (VPConnectDB.ConnectDB.strcon() != null && VPConnectDB.ConnectDB.strcon() != "")
{
    Console.WriteLine("✅ Kết nối SQL thành công!");

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
}
else
{
    Console.WriteLine("❌ Lỗi kết nối SQL: " + VPConnectDB.Datas.InforDB.SendKey);

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=LoiKetNoi}/{id?}");

}    

app.Run();
