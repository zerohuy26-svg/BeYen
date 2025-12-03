var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // Quan trọng: cho phép dùng index.html làm trang mặc định
app.UseStaticFiles();    // Cho phép truy cập file HTML/CSS/JS trong wwwroot

app.Run();
