<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                xmlns:a="http://tempuri.org/XMLSchema1.xsd"
>
    <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <h1>PHIEU MUA HANG</h1>
      <table>
        <tr>
          <td>Hoa Don : 
            <xsl:value-of select="a:DS/a:HoaDon/a:MaHD"/>
          </td>

          <td>
            Ngay Ban :
            <xsl:value-of select="a:DS/a:HoaDon/a:NgayBan"/>
          </td>
        </tr>

        <tr>
          <td>
            Loai Hang :
            <xsl:value-of select="a:DS/a:HoaDon/a:LoaiHang/@TenLoai"/>
          </td>
        </tr>

      </table>

      <table border="1">
        <tr>
          <td>Ma hang</td>
          <td>Ten hang</td>
          <td>So luong</td>
          <td>Don Gia</td>
          <td>Thanh Tien</td>
        </tr>

        <xsl:for-each select="a:DS/a:HoaDon/a:LoaiHang/a:Hang">
          <tr>
            <td>
              <xsl:value-of select="@MaHang"/>
            </td>
            <td>
              <xsl:value-of select="a:TenHang"/>
            </td>
            <td>
              <xsl:value-of select="a:SoLuong"/>
            </td>
            <td>
              <xsl:value-of select="a:DonGia"/>
            </td>
            <td><xsl:value-of select="a:SoLuong*a:DonGia"/></td>
          </tr>
          
        </xsl:for-each>
        
      </table>
    </html>
  </xsl:template>
</xsl:stylesheet>
