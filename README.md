# Phát triển ứng dụng K18
## Website Bán Hàng
## SV Trần Phú Thiên
* MSSV: 118001431
* Lớp 18CT112
* Email: tranpthien2412@gmail.com
### Công nghệ
* ASP.NET Core 3.1
* Entity Framework Core 5.0.11
* Visual Studio 2019
* SQL Server 2019
* SQL Server 2019
### Mô hình
* N layer (Data, Business, Presentation): Data driven design
* Code first sử dụng Entity
### Install NuGet Packages to PTUD_eShopVPP.Data
* Microsoft.EntityFrameworkCore v5.0.11
* Microsoft.EntityFrameworkCore.SqlServer v5.0.11
* Microsoft.EntityFrameworkCore.Design v5.0.11
* Microsoft.EntityFrameworkCore.Tools v5.0.11
* Microsoft.Extensions.Configuration.FileExtensions v5.0.0
* Microsoft.Extensions.Configuration.Json v5.0.0
* Microsoft.AspNetCore.Identity.EntityFrameworkCore v5.0.11
### Install NuGet Packages to PTUD_eShopVPP.ViewModels
* Microsoft.AspNetCore.Http.Features v5.0.11
* FluentValidation.AspNetCore v8.6.2
### Install NuGet Packages to PTUD_eShopVPP.Application
* Microsoft.EntityFrameworkCore v5.0.11
* Microsoft.AspNetCore.Http.Features v5.0.11
### Install NuGet Packages to PTUD_eShopVPP.BackendAPI
* Swashbuckle.AspNetCore v6.2.3
* Microsoft.AspNetCore.Authentication.JwtBearer v3.1.2
* FluentValidation.AspNetCore v8.6.2
* Microsoft.VisualStudio.Web.CodeGeneration.Design v3.1.1
### Install NuGet Packages to PTUD_eShopVPP.AdminApp
* Microsoft.VisualStudio.Web.CodeGeneration.Design v3.1.1
* Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation v3.1.2
* FluentValidation.AspNetCore v8.6.2
* Microsoft.IdentityModel.Logging v6.5.0
* Microsoft.IdentityModel.Tokens v5.6.0
* System.IdentityModel.Tokens.Jwt v5.6.0
* Microsoft.AspNetCore.Session v2.2.0
### Note
1. feature/fe01:
	* Thiết kế database
	* Tạo các Entity Class
	* Cấu hình Entity với Fluent API
	* Migration database
	* Update-database
2. feature/fe02:
	* Thêm bảng cho ASP.NET Core Identity | Add ASP.NET Identity tables
3. feature/fe03:
	* Dựng cấu trúc tầng Application Service | Create application service layer structure
	* Tạo phương thức search và phân trang | Create search and paging method
4. feature/fe04:
	* Phương thức cập nhật sản phẩm | Update product method
5. feature/fe05:
	* Thêm bảng hình ảnh sản phẩm | Add product image table by migration
6. feature/fe06:
	* Phương thức quản lý ảnh | Manage image method API
7. feature/fe07:
	* Tạo web API project | Create Web API Project
8. feature/fe08:
	* Thêm swagger cho web API | Add Swagger web API
9. feature/fe09:
	* Tạo RESTful API cho Product | Create RESTful API for Product
10. feature/fe10:
	* API Quản lý ảnh | Image management API
11. feature/fe11:
	* Tạo API đăng nhập và đăng ký | Create login and register APIs
12. feature/fe12:
	* Thêm Authorization header cho Swagger | Add Authorization to Swagger
13. feature/fe13:
	* Use Fluent Validation
14. feature/fe14:
	* Tạo ứng dụng Admin và thêm Template | Create Admin App and add Template
	* Dùng template SB Admin | Use template SB Admin
15. feature/fe15:
	* Tạo trang login và tích hợp Backend API | Login page and integrate API
16. feature/fe16:
	* Cookie Authentication without ASP.NET Identity
17. feature/fe17:
	* Lấy danh sách user | Get user list
18. feature/fe18:
	* Tạo mới user | Create new user
19. feature/fe19:
	* Cập nhật user | Update exising user
20. feature/fe20:
	* Phân trang danh sách user | User list paging
	* Xem chi tiết user | View user details
21. feature/fe21:
	* Xóa người dùng | Delete user
22. feature/fe22:
	* Tìm kiếm trong danh sách user | User list filtering