<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:a="http://tempuri.org/Bai5Phieu1.xsd">
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <table border="1">
        <xsl:for-each select="a:DSSV/a:SinhVien">
          <tr>
            <td>
              <xsl:value-of select="a:STT"/>
            </td>
            <td>
              <xsl:value-of select="a:MaSv"/>
            </td>
            <td>
              <xsl:value-of select="a:TenSv"/>
            </td>

            <td>
              <xsl:value-of select="a:GioiTinh"/>
            </td>

            <td>
              <xsl:value-of select="@Tien"/>
            </td>

          </tr>
        </xsl:for-each>
        <xsl:variable name="sumTien" select="sum(a:DSSV/a:SinhVien/@Tien)"></xsl:variable>
        <xsl:variable name="sumSTT" select="sum(a:DSSV/a:SinhVien/a:STT)"></xsl:variable>
        <xsl:value-of select="($sumTien div $sumSTT)"/>
      </table>
    </xsl:template>
</xsl:stylesheet>
