<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:msb="http://schemas.microsoft.com/developer/msbuild/2003">
  <xsl:output method="xml" version="1.0" indent="yes"/>

  <xsl:template match="/msb:Project">
    <project default="Debug" basedir=".">
      <description>Generated by csproj2build.</description>

      <xsl:call-template name="make-compile-target">
        <xsl:with-param name="build-type">Debug</xsl:with-param>
      </xsl:call-template>

      <xsl:call-template name="make-compile-target">
        <xsl:with-param name="build-type">Release</xsl:with-param>
      </xsl:call-template>

      <target name="clean">
        <delete>
          <xsl:attribute name="dir">
            <xsl:call-template name="get-work-dir">
              <xsl:with-param name="build-type">Debug</xsl:with-param>
            </xsl:call-template>
          </xsl:attribute>
        </delete>
        <delete>
          <xsl:attribute name="dir">
            <xsl:call-template name="get-work-dir">
              <xsl:with-param name="build-type">Release</xsl:with-param>
            </xsl:call-template>
          </xsl:attribute>
        </delete>
      </target>
    </project>
  </xsl:template>

  <xsl:template name="make-compile-target">
    <xsl:param name="build-type"/>

    <xsl:variable name="project-type">
      <xsl:value-of select="/msb:Project/msb:PropertyGroup/msb:OutputType/text()"/>
    </xsl:variable>
    <xsl:variable name="extension">
      <xsl:call-template name="get-extension"/>
    </xsl:variable>
    <xsl:variable name="work-dir">
      <xsl:call-template name="get-work-dir">
        <xsl:with-param name="build-type" select="$build-type"/>
      </xsl:call-template>
    </xsl:variable>
    <xsl:variable name="module-base" select="concat($work-dir, '/', /msb:Project/msb:PropertyGroup/msb:AssemblyName/text())"/>
    <xsl:variable name="module" select="concat($module-base, '.', $extension)"/>

    <target>
      <xsl:attribute name="name">
        <xsl:value-of select="$build-type"/>
      </xsl:attribute>

      <mkdir>
        <xsl:attribute name="dir">
          <xsl:value-of select="$work-dir"/>
        </xsl:attribute>
      </mkdir>
      <csc>
        <xsl:attribute name="target">
          <xsl:choose>
            <xsl:when test="$project-type='Library'">
              <xsl:text>library</xsl:text>
            </xsl:when>
            <xsl:when test="$project-type='Exe'">
              <xsl:text>exe</xsl:text>
            </xsl:when>
            <xsl:when test="$project-type='WinExe'">
              <xsl:text>exe</xsl:text>
            </xsl:when>
          </xsl:choose>
        </xsl:attribute>
        <xsl:attribute name="output">
          <xsl:value-of select="$module"/>
        </xsl:attribute>
        <xsl:attribute name="debug">
          <xsl:choose>
            <xsl:when test="$build-type='Debug'">
              <xsl:text>true</xsl:text>
            </xsl:when>
            <xsl:otherwise>
              <xsl:text>false</xsl:text>              
            </xsl:otherwise>
          </xsl:choose>
        </xsl:attribute>
        <xsl:if test="$build-type='Release'">
          <xsl:attribute name="doc">
            <xsl:value-of select="concat($module-base, '.XML')"/>
          </xsl:attribute>
        </xsl:if>

        <references>
          <xsl:choose>
            <xsl:when test="$build-type='Debug'">
              <xsl:apply-templates mode="debugref"/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:apply-templates mode="releaseref"/>
            </xsl:otherwise>
          </xsl:choose>
        </references>

        <resources dynamicprefix="true">
          <xsl:attribute name="prefix">
            <xsl:value-of select="/msb:Project/msb:PropertyGroup/msb:RootNamespace/text()"/>
          </xsl:attribute>

          <xsl:apply-templates mode="resource"/>
        </resources>
        <sources>
          <xsl:apply-templates mode="source"/>
        </sources>
      </csc>
    </target>
  </xsl:template>

  <xsl:template match="msb:ItemGroup" mode="debugref">
    <xsl:apply-templates mode="debugref"/>
  </xsl:template>

  <xsl:template match="msb:ItemGroup" mode="releaseref">
    <xsl:apply-templates mode="releaseref"/>
  </xsl:template>

  <xsl:template match="msb:ItemGroup" mode="dependencies">
    <xsl:apply-templates mode="dependencies"/>
  </xsl:template>

  <xsl:template match="msb:ProjectReference" mode="debugref">
    <include>
      <xsl:attribute name="name">
        <xsl:call-template name="get-path-from-csproj">
          <xsl:with-param name="build-type">Debug</xsl:with-param>
          <xsl:with-param name="csproj" select="@Include"/>
        </xsl:call-template>
      </xsl:attribute>
    </include>
  </xsl:template>

  <xsl:template match="msb:ProjectReference" mode="releaseref">
    <include>
      <xsl:attribute name="name">
        <xsl:call-template name="get-path-from-csproj">
          <xsl:with-param name="build-type">Release</xsl:with-param>
          <xsl:with-param name="csproj" select="@Include"/>
        </xsl:call-template>
      </xsl:attribute>
    </include>
  </xsl:template>

  <xsl:template match="msb:Reference" mode="debugref">
    <xsl:if test="msb:HintPath/text()">
      <include>
        <xsl:attribute name="name">
          <xsl:value-of select="msb:HintPath/text()"/>          
        </xsl:attribute>
      </include>      
    </xsl:if>
  </xsl:template>

  <xsl:template match="msb:Reference" mode="releaseref">
    <xsl:if test="msb:HintPath/text()">
      <xsl:variable name="path">
        <xsl:call-template name="get-release-ref">
          <xsl:with-param name="hint-path" select="msb:HintPath/text()"/>
        </xsl:call-template>
      </xsl:variable>

      <include>
        <xsl:attribute name="name">
          <xsl:value-of select="$path"/>          
        </xsl:attribute>
      </include>      
    </xsl:if>
  </xsl:template>

  <xsl:template match="msb:Reference" mode="dependencies">
    <xsl:if test="msb:HintPath/text()">
      <xsl:variable name="hint-path">
        <xsl:value-of select="msb:HintPath/text()"/>
      </xsl:variable>
      <xsl:variable name="path">
        <xsl:call-template name="get-release-ref">
          <xsl:with-param name="hint-path" select="$hint-path"/>
        </xsl:call-template>
      </xsl:variable>

      <xsl:if test="$path!=$hint-path">
        <copy todir="program">
          <xsl:attribute name="file">
            <xsl:value-of select="$path"/>
          </xsl:attribute>
        </copy>
      </xsl:if>
    </xsl:if>
  </xsl:template>

  <xsl:template match="node()" mode="debugref">
  </xsl:template>

  <xsl:template match="node()" mode="releaseref">
  </xsl:template>

  <xsl:template match="node()" mode="dependencies">
  </xsl:template>

  <xsl:template match="msb:ItemGroup" mode="resource">
    <xsl:apply-templates mode="resource"/>
  </xsl:template>

  <xsl:template match="msb:EmbeddedResource" mode="resource">
    <include>
      <xsl:attribute name="name">
        <xsl:value-of select="@Include"/>
      </xsl:attribute>
    </include>
  </xsl:template>

  <xsl:template match="node()" mode="resource">
  </xsl:template>

  <xsl:template match="msb:ItemGroup" mode="source">
    <xsl:apply-templates mode="source"/>
  </xsl:template>

  <xsl:template match="msb:Compile" mode="source">
    <include>
      <xsl:attribute name="name">
        <xsl:value-of select="@Include"/>
      </xsl:attribute>
    </include>
  </xsl:template>

  <xsl:template match="node()" mode="source">
  </xsl:template>

  <xsl:template name="get-release-ref">
    <xsl:param name="hint-path"/>

    <xsl:variable name="other-type-path-component">\Debug\</xsl:variable>

    <xsl:choose>
      <xsl:when test="contains($hint-path, $other-type-path-component)">
        <xsl:value-of select="concat(substring-before($hint-path, $other-type-path-component), '\Release\', substring-after($hint-path, $other-type-path-component))"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$hint-path"/> 
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="get-work-dir">
    <xsl:param name="build-type"/>

    <xsl:value-of select="concat('bin/', $build-type)"/>
  </xsl:template>

  <xsl:template name="get-path-from-csproj">
    <xsl:param name="csproj"/>
    <xsl:param name="build-type"/>

    <xsl:choose>
      <xsl:when test="contains($csproj, 'MMCUtils.csproj')">
        <xsl:value-of select="concat('bin\', $build-type, '\MMC.PortalCS.InstatOnline.MMCUtils.dll')"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="concat('bin\', $build-type, '\', substring-before(substring-after(substring-before($csproj, '.csproj'), '..\'), '\'), '.dll')"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="get-extension">
    <xsl:variable name="project-type">
      <xsl:value-of select="/msb:Project/msb:PropertyGroup/msb:OutputType/text()"/>
    </xsl:variable>

    <xsl:choose>
      <xsl:when test="$project-type='Library'">
        <xsl:text>dll</xsl:text>
      </xsl:when>
      <xsl:when test="$project-type='Exe'">
        <xsl:text>exe</xsl:text>
      </xsl:when>
      <xsl:when test="$project-type='WinExe'">
        <xsl:text>exe</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:message terminate="yes">
          Unknown project type
          <xsl:value-of select="msb:PropertyGroup/msb:OutputType/text()"/>
        </xsl:message>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

</xsl:stylesheet>
