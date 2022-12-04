<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                xmlns:a ="http://tempuri.org/thuvien.xsd"
>
    <xsl:output method="html" indent="yes"/>

  
    <xsl:template match="/">
     
      <table border="1" >
        <tr>
          <td colspan="4" align="center">Danh mục sách</td>
        </tr>
        <xsl:for-each select="a:TV/a:NhaXB">
          <tr>
            <td colspan="4" align="center">-------------</td>
          </tr>
          <tr>
            <td>Nhà xuất bản</td>
            <td colspan="3">
              <xsl:value-of select="@TenNXB"/>
            </td>
          </tr>
          <tr>
            <td>STT</td>
            <td>Tên Sách</td>
            <td>Số trang</td>
            <td>Giá</td>
          </tr>
          <xsl:for-each select="a:Sach">
            <tr>
              <td>
                <xsl:value-of select="position()"/>
              </td>
              <td>
                <xsl:value-of select="a:TenSach"/>
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
                    <xsl:value-of select="(a:SoTrang - 100) * 3000 + 100 * 4000"/>
                  </xsl:when>

                  <xsl:otherwise>
                    <xsl:value-of select="50 * 3000 + 100 * 4000 + (a:SoTrang - 150) * 2000"/>
                  </xsl:otherwise>
                </xsl:choose>
              </td>
            </tr>
          </xsl:for-each>
        </xsl:for-each>
      </table>
    </xsl:template>
</xsl:stylesheet>
