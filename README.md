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
* FluentValidation.AspNetCore v10.3.4
### Install NuGet Packages to PTUD_eShopVPP.Application

### Install NuGet Packages to PTUD_eShopVPP.BackendAPI
* Swashbuckle.AspNetCore v6.2.3
* FluentValidation.AspNetCore v10.3.4
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
* feature/update_nullable
4. feature/fe04:
	* Thêm phương thức cập nhật sản phẩm | Update product method
	* Thêm bảng hình ảnh sản phẩm | Add product image table by migration
	* Thêm phương thức quản lý ảnh | Manage image method API
5. feature/fe05:
	* Tạo Web API Project | Create Web API Project
	* Thêm Swagger cho Web API | Add Swagger to Web API
	* Tạo RESTful API cho Product | Create RESTful API for Product
	* Thêm API Quản lý ảnh | Image management API
	* Tạo API đăng nhập và đăng ký | Create login and register APIs
	* Thêm Authorization header cho Swagger | Add Authorization to Swagger
	* Sử dụng Fluent Validation
	* Tạo ứng dụng Admin và thêm Template cho trang admin | Create Admin App and add Template