<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:a ="http://tempuri.org/XMLSchema.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
      <table>
        <tr colspan="6">
          <td align="center">Bảng chấm công</td>
        </tr>
        <tr>
          <td>STT</td>
          <td>Mã NV</td>
          <td>Ca làm việc</td>
          <td>Giờ vào</td>
          <td>Giờ ra</td>
          <td>Làm đêm</td>
        </tr>
      </table>
    </xsl:template>
</xsl:stylesheet>
