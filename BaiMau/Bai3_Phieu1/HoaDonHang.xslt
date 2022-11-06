<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Danh mục hóa đơn</title>
			</head>
			<body>
				<h2>Phiếu mua hàng</h2>
				<table border="0">
					<tr>
						<td>
							Hóa đơn: <xsl:value-of select="DS/HoaDon/MaHD"/>
						</td>
						<td>
							Ngày bán: <xsl:value-of select="DS/HoaDon/NgayBan"/>
						</td>
						<tr>
							<td>
								Loại hàng: <xsl:value-of select="DS/HoaDon/LoaiHang/@TenLoai"/>
							</td>
						</tr>
					</tr>
				</table>
				<table border="1" cellpadding="3">
					<tr>
						<td>Mã hàng</td>
						<td>Tên hàng</td>
						<td>Số lương</td>
						<td>Đơn giá</td>
						<td>Thành tiền</td>
					</tr>
					<xsl:for-each select="DS/HoaDon/LoaiHang/Hang">
						<tr>
							<td>
								<xsl:value-of select="@MaHang"/>
							</td>
							<td>
								<xsl:value-of select="TenHang"/>
							</td>
							<td>
								<xsl:value-of select="SoLuong"/>
							</td>
							<td>
								<xsl:value-of select="DonGia"/>
							</td>
							<td>
								<xsl:value-of select="DonGia*SoLuong"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body> 
		</html>
	</xsl:template>
</xsl:stylesheet>
