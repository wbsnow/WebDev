<?xml version='1.0' encoding='utf-8'?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html"/>

<xsl:template match="/">
	<html><head></head>
		<body>
			<table>
				<tbody>
					<tr>
						<td>
							<xsl:apply-templates select="managers/manager"/>&#160; 
						</td>
					</tr>
				</tbody>
			</table>
		</body>
	</html>
</xsl:template>



<xsl:template match="manager">
	<p>
		<table style="; width: 100%" cellpadding="3">
			<tbody>
				<tr>
					<td vAlign="top">
						<img src="{portraitImageURL}" border="0"/>
					</td>
					<td vAlign="top">
						<p>
							<b><xsl:value-of select="name"/></b>
							&#160; <br />
						<br />
							<xsl:value-of select="openText" disable-output-escaping="yes"/>
						</p>
						<xsl:if test="bulletPoint/text()">
							<xsl:for-each select="bulletPoint">
								<p>&#160; &#160; - 
									<xsl:value-of select="text()"/>&#160; 
								</p>
							</xsl:for-each>
						</xsl:if>
						<xsl:if test="bulletPoint/text() = null">
		<xsl:for-each select="bulletPoint">
			<p>
				Error: Line #44 in Images/Portraits/Management.xslt
			</p>
		</xsl:for-each>
	</xsl:if>
						<p>
							<xsl:value-of select="closeText" disable-output-escaping="yes"/>
						</p>
					</td>
				</tr>
			</tbody>
		</table>
		<hr />
	</p>
</xsl:template>

</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2006. Progress Software Corporation. All rights reserved.
<metaInformation>
<scenarios ><scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="Management.xml" htmlbaseurl="" outputurl="" processortype="internal" useresolver="yes" profilemode="0" profiledepth="" profilelength="" urlprofilexml="" commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal" customvalidator=""/></scenarios><MapperMetaTag><MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="" destSchemaRoot="" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no"/><MapperBlockPosition></MapperBlockPosition><TemplateContext></TemplateContext><MapperFilter side="source"></MapperFilter></MapperMetaTag>
</metaInformation>
-->