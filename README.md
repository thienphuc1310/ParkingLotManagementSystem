# HỆ THỐNG QUẢN LÝ BÃI ĐẬU XE ĐA TẦNG

**Môn học:** Lập trình hướng đối tượng (OOP) – HK1 2026–2027  
**Giảng viên hướng dẫn:** Huỳnh Xuân Phụng  
**Ngôn ngữ lập trình:** C#  
**Thời gian thực hiện:** 4 tuần

## 1. Tổng quan

Dự án xây dựng hệ thống quản lý bãi đậu xe đa tầng bằng C#, áp dụng các nguyên lý lập trình hướng đối tượng (OOP): tính trừu tượng, đóng gói, kế thừa và đa hình.

Hệ thống hỗ trợ quản lý nhiều loại phương tiện, tự động phân bổ chỗ đỗ phù hợp, theo dõi tình trạng bãi xe và tính phí khi phương tiện rời bãi.

## 2. Chức năng của hệ thống

- **Quản lý phương tiện:** Ô tô, xe máy, xe máy điện và xe đạp.
- **Quản lý bãi đỗ:** Quản lý các tầng, vị trí đỗ và sức chứa.
- **Gửi xe:** Tự động tìm và phân bổ vị trí phù hợp với loại xe.
- **Lấy xe:** Xác nhận vé, tính phí và giải phóng vị trí.
- **Quản lý vé:** Lưu thông tin xe, vị trí đỗ, thời gian vào và ra.
- **Thống kê:** Theo dõi số vị trí còn trống và đang sử dụng.
- **Xử lý ngoại lệ:** Từ chối xe khi hết chỗ phù hợp, ngăn gửi xe trùng và sử dụng vé không hợp lệ.

## 3. Mô tả các lớp chính

| Lớp | Chức năng |
|---|---|
| `Vehicle` | Lớp trừu tượng đại diện cho phương tiện |
| `Car` | Quản lý thông tin và phí gửi ô tô |
| `Motorcycle` | Quản lý thông tin và phí gửi xe máy |
| `ElectricMotorcycle` | Quản lý thông tin và phí gửi xe máy điện |
| `Bicycle` | Quản lý thông tin và phí gửi xe đạp |
| `ParkingSpot` | Quản lý vị trí đỗ, sức chứa và xe đang đỗ |
| `ParkingLevel` | Quản lý các vị trí đỗ trên một tầng |
| `Ticket` | Quản lý vé, thời gian gửi và phí gửi xe |
| `ParkingLot` | Điều phối gửi xe, lấy xe và thống kê toàn bãi |


## 4. Quy tắc tính phí

| Loại phương tiện | Đơn giá |
|---|---:|
| Ô tô | 50.000 VNĐ/giờ |
| Xe máy | 4.000 VNĐ/giờ |
| Xe máy điện | 4.000 VNĐ/giờ |
| Xe đạp | 2.000 VNĐ/giờ |

**Công thức tính phí:**

`Phí gửi xe = Số giờ gửi (làm tròn lên) × Đơn giá`

Thời gian gửi được tính từ lúc xe vào bãi đến lúc xe rời bãi. Thời gian lẻ được làm tròn lên giờ tiếp theo.

## 5. Phân chia công việc theo tuần

| Tuần | Công việc |
|---|---|
| **Tuần 1** | Phân tích yêu cầu, thiết kế sơ đồ lớp UML, xác định thuộc tính, phương thức và quan hệ giữa các lớp. |
| **Tuần 2** | Xây dựng code khung các class, khai báo thuộc tính, constructor và phương thức. Chưa triển khai logic. |
| **Tuần 3** | Triển khai logic các class: phân bổ chỗ đỗ, gửi xe, lấy xe, quản lý vé, tính phí và thống kê. |
| **Tuần 4** | Kiểm thử, sửa lỗi, cập nhật lại UML nếu có thay đổi và hoàn thiện báo cáo. |

## 6. Tài liệu kèm theo

- **Sơ đồ UML:** Mô tả cấu trúc và quan hệ giữa các lớp.
- **AI Usage Log:** Nhật ký sử dụng AI trong quá trình thực hiện dự án.
