﻿# Phát triển ứng dụng K18
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
### Mô hình
* N layer (Data, Business, Presentation): Data driven design
* Code first sử dụng Entity
### Install NuGet Packages
* Microsoft.EntityFrameworkCore v5.0.11
* Microsoft.EntityFrameworkCore.SqlServer v5.0.11
* Microsoft.EntityFrameworkCore.Design v5.0.11
* Microsoft.EntityFrameworkCore.Tools v5.0.11
* Microsoft.Extensions.Configuration.FileExtensions v5.0.0
* Microsoft.Extensions.Configuration.Json v5.0.0
* Microsoft.AspNetCore.Identity.EntityFrameworkCore v5.0.11
### Note
1. feature/fe01:
	* Thiết kế database
	* Tạo các Entity Class
	* Cấu hình Entity với Fluent API
	* Migration database
	* Update-database
2. feature/fe02:
	* Thêm bảng cho ASP.NET Core Identity (Add ASP.NET Identity tables)
3. feature/fe03:
	* Dựng cấu trúc tầng Application Service (Create application service layer structure)
	* Tạo phương thức search và phân trang (Create search and paging method)
* feature/update_nullable