<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                xmlns:a ="http://tempuri.org/thuvien.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <table border="1">
        <tr>
          <td colspan="5" align="center">Danh mục sách</td>
        </tr>
        <xsl:for-each select="a:TV/a:NhaXB">
          <br></br>
          <tr>
            <td>
              Nhà xuất bản : 
            </td>
            <td>
              <xsl:value-of select="@TenNXB"/>
            </td>
          </tr>

          <tr>
            <td>STT</td>
            <td>Tên sách</td>
            <td>Thể loại</td>
            <td>Số trang</td>
            <td>Giá</td>
          </tr>
          <xsl:for-each select="a:Sach">
            <tr>
              <td>
                <xsl:value-of select="@MaSach"/>
              </td>
              <td>
                <xsl:value-of select="a:TenSach"/>
              </td>
              <td>
                <xsl:value-of select="a:TheLoai"/>
              </td>
              <td>
                <xsl:value-of select="a:SoTrang"/>
              </td>
              <td>
                <xsl:choose>
                  <xsl:when test="a:SoTrang &lt;= 100">
                    <xsl:value-of select="a:SoTrang * 4000"/>
                  </xsl:when>
                  <xsl:when test="a:SoTrang &lt;= 150">
                    <xsl:value-of select="(a:SoTrang - 100) * 3000 + 1000 * 4000"/>
                </xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select="(a:SoTrang - 150) * 2000 + 1000 * 4000 + 50 * 3000"/>
                  </xsl:otherwise>
                </xsl:choose>
              </td>
            </tr>
          </xsl:for-each>
          
        </xsl:for-each>
      </table>
    </xsl:template>
</xsl:stylesheet>
