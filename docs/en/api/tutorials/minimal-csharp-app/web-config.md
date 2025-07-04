---
title: Web.Config configuration overview
uid: minimal_csharp_app_web_config
description: Web.Config configuration overview
author: SuperOffice Product and Engineering
keywords:
content_type: tutorial
deployment: online
platform: web
---

# Web.Config configuration overview

This section will present the technical details to understand what is required to get the example running on your machine. This section also explains how the example application works.

**Key sections:**

* SuperOffice>Data>Session
* SuperOffice>Service
* appSettings

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

The `Session Mode` property instructs NetServer to use the **PartnerHttpContext** provider to store the user's context when the application is run.

## SuperOffice Services

### DefaultMode

Must be *Remote* to work with SuperOffice Online web services.

### ApplicationToken

Must be set to identify partner applications. Online services will reject unidentified callers.

* This property is expected and used by the NetServer proxy assemblies.
* The token is exchanged only after a secured HTTP connection has been established.

[Application credentials][1] are environment-specific. The value of **ApplicationToken** will be different in SOD and production.

## appSettings

### SoAuthCookie

An identity used when persisting a Cookie.

### SoAppId

A public application identifier.

It is used by the `AuthenticationHelper` class and is appended to the URL used when forwarding your application to the SoFederationGateway URL (also defined in **AppSettings**).

The **SoAppId** appears in the browser's address bar when forwarded to SuperID and is vulnerable to man-in-the-middle attacks. However, you can mitigate this threat by validating tokens after each successful authentication.

The SoAppId is relevant when a new user attempts to access your partner application for the first time. That user will be prompted to allow your application to run within the user's context. This consent feature also enables a partner to revoke access if necessary. Although inaccessible to partners today, this feature will be made accessible in the future.

Application credentials are environment-specific. The value of SoAppId will be different in SOD and production.

### SoFederationGateway

Specifies the URL where SuperID resides.

SuperID is environment-specific. The value of **SoFederationGateway** will be different in SOD and production.

* **SOD:** `https://sod.superoffice.com`
* **Production:** `https://online.superoffice.com/login/`

### SystemTokenCertificatePath

Path to a local file containing the partners' **application private key**.

**Example private key file:**

```xml
<RSAKeyValue>
  <Modulus>migUNK1X11GNYZ7XpQ/EPrXohsC0VYCsx2n/0Gp1PmtLJe/9j+GtYqU09GNYTpFeQF/G0hXvbwZSjZJmGEkWgFCZUS+oFfGr3NfiVFPqCBPvjJlXMe/1XudxdUZLzUVIOb+uCSFzLkaEVh0IFnE4HRKYKkvEjvkItphxNBoNbFU=</Modulus>
  <Exponent>AQAB</Exponent>
  <P>1KhY+C+sYE6xH6raJDG8dQ14nZOGt/hlw5sZ+0Bk7EnCeTdzxnI7t6qiUYO9GJvsXEiCdRdcUF9TL6DI6+XJOw==</P>
  <Q>uZNfZNXMnZt50G/SJewg3TqsfT9N3QyAqsifoSV1xoNhVpNL6A64iD8OyVrSzp50Rwnh1QS1fdDWLuI8AOTHrw==</Q>
  <DP>E8LZEacMc56cYv7zam2cv5vS24G8ARh6DGU7Ute3CSYJhk4a2hP/bJ/UmZKOXd0PZ7vtM4hKMcXJ6yEbyp/9xQ==</DP>
  <DQ>DNXxsjLLjVc0rMMfQPo9J7AoQB2B0DlOKQHpcKb7p3hs4iUcCfgCsYHTDwBWNm5lUoiPc0F5IDOyrNl/Fvy8Bw==</DQ>
  <InverseQ>S9ptGHigXK+m/tvwE+9xroinx1FYhCJ7CtDlh2dMaeVPL9ZJkn1LHSf3BBsclf8dkvcGvBPPHZ+GvdpZxntYw==</InverseQ>
  <D>Kgv/guS6/mBgmz1bnUqBIQe17jdWmLG5rsSjQWIgK4/RVf4xH5MTG0JrgLMuLXPqDM3y6W+ROKu1TaceUMZyq81xAROGxh+Yd+F77EIL3aendQulp977kyiVjdfIABNjHjcpu+lt11TgzlwaHne57TE+i0T9g3Jx0Yd5B4YlY7s=</D>
</RSAKeyValue>
```

### SuperIdCertificate

The certificate thumbprint identifier on the machine hosting the website. The thumbprint is used by the `SuperIdTokenHandler` class to verifying the JWT token returned by SuperID to the partner web application.

The thumbprint identifier is environment-specific. The value of `SuperIdCertificate` will be different in SOD and production.

<!-- Referenced links -->
[1]: ../../../developer-portal/getting-started/index.md#terminology
