<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:a ="http://tempuri.org/XMLSchema.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <table border="1">
        <tr >
          <td colspan="6" align="center">Bảng chấm công</td>
        </tr>
        <tr>
          <td>STT</td>
          <td>Mã NV</td>
          <td>Ca làm việc</td>
          <td>Giờ vào</td>
          <td>Giờ ra</td>
          <td>Làm đêm</td>
        </tr>
        <xsl:for-each select="a:DsChamCong/a:ChamCong/a:NgayLamViec">
          <xsl:for-each select="a:NhanVien">
            <tr>
              <td>
                <xsl:value-of select="position()"/>
              </td>
              <td>
                <xsl:value-of select="@MaNV"/>
              </td>
              <td>
                <xsl:value-of select="a:CaLamViec"/>
              </td>
              <td>
                <xsl:value-of select="a:GioVao"/>
              </td>
              <td>
                <xsl:value-of select="a:GioRa"/>
              </td>

              <xsl:if test="a:CaLamViec='C3'">
                <td>
                  X
                </td>
              </xsl:if>
            </tr>
          </xsl:for-each>

          <tr>
            <td>
              Ngày làm việc :
            </td>
            <td>
              <xsl:value-of select="@Ngay"/>
            </td>
          </tr>
        
        </xsl:for-each>
       
      </table>
    </xsl:template>
</xsl:stylesheet>
