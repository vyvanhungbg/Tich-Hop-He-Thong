<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/XMLSchema2.xsd"
>
    <xsl:output method="html" indent="yes"/>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<td>MaSV</td>
						<td>MaMH</td>
						<td>DiemThi</td>
					</tr>
					<xsl:for-each select="a:Lop/a:SV">
						<xsl:sort select="a:DiemThi" order="descending"/>
						<xsl:if test="a:MaMH = 'THVP'">
							<xsl:if test="a:DiemThi >=5">
							<tr>
								<td>
									<xsl:value-of select="a:MaSV"/>
								</td>
								<td>
									<xsl:value-of select="a:MaMH"/>
								</td>
								<td>
									<xsl:value-of select="a:DiemThi"/>
								</td>
							</tr>
							</xsl:if>
						</xsl:if>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>
