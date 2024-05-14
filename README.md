# PHẦN MỀM QUẢN LÝ KHÁCH SẠN
## Nội dung

* [Tính năng](#Tính-năng)
* [Cài đặt](#Cài-đặt)
* [Môi trường](#Môi-trường)
* [Tài liệu tham khảo](#Tài-liệu-tham-khảo)
* [Tác giả](#Tác-giả)
* [Giấy phép](#Giấy-phép)

## Tính năng

* Đặt phòng
* Nhận phòng
* Đặt dịch vụ
* Thanh toán và in hóa đơn
* Quản lý phòng và loại phòng
* Quản lý dịch vụ và loại dịch vụ
* Quản lý tài khoản
* Báo cáo 

## Cài đặt

**1. Tải các thành phần liên quan**

* Khôi phục file backup database /Database/HotelManagement.bak

**2. Chỉnh sửa connection string**

* Mở file DAO/DataProvider.cs 
* Sửa đổi  private string connectionStr = @"Server=DaeSangHyeok;Initial Catalog=HotelManagement;Integrated Security=True";
với tên server tương ứng

**3. Tài khoản đăng nhập hệ thống**
username: admin
password: 123456789

username: nv1
password: 12345678

## Môi trường

* [Visual Studio 2019]
* [SQL Server 2019]

## Tài liệu tham khảo

Tai liệu hỗ trợ việc sử dụng C# [documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Tính năng đang phát triển
*Thống kê doanh thu*
*Phân quyền cho loại nhân viên*
*Thêm loại nhân viên*

## Tác giả

* Lâm Huỳnh Như - 52200028
* Hà Thị Nguyệt Hà - 52200017

## Giấy phép

[MIT](https://opensource.org/licenses/MIT)
