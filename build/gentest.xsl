<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:param name="TestModule"/>
  <xsl:output method="xml" version="1.0" indent="yes"/>

  <xsl:template match="/">
    <project name="test" default="test" basedir=".">
      <target name="test">
        <nunit2>
          <formatter type="Plain" />
          <test>
            <xsl:attribute name="assemblyname">
              <xsl:value-of select="$TestModule"/>
            </xsl:attribute>
          </test>  
        </nunit2>
      </target>
    </project>
  </xsl:template>

</xsl:stylesheet>
