<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
				xmlns:a="http://tempuri.org/XMLSchema1.xsd"
>
    <xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<td>MaMh</td>
						<td>TenMh</td>
						<td>SoGio</td>
					</tr>
					<xsl:for-each select="a:MonHoc/a:Mon">
						<xsl:sort select="a:SoGio"/>
						<xsl:if test="a:SoGio >= 40">
						<tr>
							<td>
								<xsl:value-of select="@MaMN"/>
							</td>
							<td>
								<xsl:value-of select="a:TenMH"/>
							</td>
							<td>
								<xsl:value-of select="a:SoGio"/>
							</td>
						</tr>
						</xsl:if>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
