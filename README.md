Tuần 1:
Tổng thể bài toán:
Một bãi giữ xe có các tầng đỗ xe, vé gửi xe và sức chứa của từng loại xe.
Mỗi tầng có nhiều chỗ đỗ xe.
Mỗi chỗ đỗ xe có mã riêng, loại chỗ phù hợp và số xe tối đa cho 1 vị trí.
Xe sẽ được ghi nhận danh tính thông qua biển số xe.
Xe sẽ có 4 chủng loại: xe điện, xe đạp, xe máy, xe ô tô.
Các chủng loại sẽ có chỗ đỗ và tính phí khác nhau thông qua thời gian đỗ xe.
Vé giữ xe ghi nhận 1 lượt gửi xe, được cấp chỗ đỗ xe theo đề bài bởi ParkingSpot, thời gian vào và thời gian ra để tính tiền xe.

Khi xe vào sẽ được xác định là loại xe nào. Sau đó sẽ kiểm tra sức chứa của loại xe đó trong bãi còn vị trí nào trống không. Nếu còn sẽ được cấp vé, vị trí và trên hệ thống sẽ ghi nhận và trừ đi số vị trị còn trống.
Khi xe ra, cần cung cấp lại vé xe để xác định loại xe cho việc tính giá và giải phóng vị trí đó để phục vụ cho lượt sau.
Nếu không còn vị trí trống cho loại xe nào đó khi vào, hệ thống sẽ ngừng cung cấp vé xe và thông báo với tài xế.

Tuần 2:
Viết code khung C# dựa trên UML tuần 1.
Đổi tên lớp Slot thành ParkingSpot để thống nhất với đề bài.
Khai báo các lớp, thuộc tính, constructor và các hàm dự kiến.
Bổ sung sức chứa từng chỗ đỗ và khung hàm thống kê từng tầng, toàn bãi.
Main chỉ mới khởi tạo bãi xe và hai tầng, chưa xử lý logic các hàm hay in kết quả.