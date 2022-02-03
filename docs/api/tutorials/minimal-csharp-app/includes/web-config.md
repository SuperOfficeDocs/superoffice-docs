```xml
<configuration>
 <configSections>
    <sectionGroup name="SuperOffice">

        <sectionGroup name="Data">
        <section name="Session" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
        </sectionGroup>
        <section name="Services" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </sectionGroup>
 </configSections>
 <SuperOffice>
    <Data>
        <Session>
            <!-- HttpContext means session information is stored, vs being recreated all the time -->
            <add key="Mode" value="PartnerHttpContext" />
        </Session>
</Data>
<Services>
    <!-- Mode can be Local, Remote, Switch; local for web + appserver on same machine, remote otherwise -->
    <add key="DefaultMode" value="Remote" />
    <add key="ApplicationToken" value="df2d5bd84dd3848a8235e1d7e40d5b64" />
    </Services>
</SuperOffice>
<appSettings>
    <add key="SoAuthCookie" value="PartnerAuth" />
    <add key="SoAppId" value="c2f1cee99dfab952d7f3cbda30d9762a" />
    <add key="SoFederationGateway" value="https://sod.superoffice.com/login/" />
    <add key="SystemTokenCertificatePath" value="certificates\partnerprivatekey.xml" />
    <add key="SuperIdCertificate" value="16b7fb8c3f9ab06885a800c64e64c97c4ab5e98c" />
</appSettings>…
```