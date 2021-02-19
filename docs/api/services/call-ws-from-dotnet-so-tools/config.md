---
title: config_ns_so_tools
description: Configure NetServer for SuperOffice web services with SuperOffice tools
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto
---

# Configure NetServer for SuperOffice web services with SuperOffice tools

## \<Services> section in application's config

The following config file section is from the application that we’re developing.

```XML
<Services>
  <!-- Mode can be Local, Remote, Switch -->
  <add key="DefaultMode" value="Remote" />

  <!-- Default mode for the switch.  Can be Local or Remote -->
  <add key="SwitchDefault"  value="Local" />

  <!-- Timeout before failover in seconds -->
  <add key="SwitchFailover" value="60" />

  <!-- Base URL for remote services -->
  <add key="RemoteBaseURL" value="http://localhost/SOWebService" />
</Services>
```

In the above config file section, we have given the `DefaultMode` as remote that is because the web service is a remote application to our application. The `RemoteBaseURL` is the URL of the web service.

## \<Services> section in web.config

We have to have a `web.config` file in the web service as well. In that config file, the service section should look like this:

```XML
<Services>
  <!-- Mode can be Local, Remote, Switch -->
  <add key="DefaultMode" value="Local" />

  <!-- Default mode for the switch.  Can be Local or Remote -->
  <add key="SwitchDefault" value="Remote" />

  <!-- Timeout before failover in seconds -->
  <add key="SwitchFailover" value="60" />

  <!-- Base URL for remote services -->
  <add key="RemoteBaseURL" value="" />
</Services>
```

Here we have set the `DefaultMode` to *Local* because the services will be called from DLLs that reside in the local machine that is hosting the web service.

## \<Data> section in web.config

These are not the only config data that should be in the `web.config` file! The `Data` section is also very important. Below is a sample data section of a `web.config` file.

```XML
<Data>
  <Session>
    <add key="Mode" value="Thread" />
  </Session>

  <Database>
    <add key="DatabaseMajor" value="MSSQL" />
    <add key="DatabaseMinor" value="8" />
    <add key="Server" value="eccolwxpbwi" />
    <add key="Database" value="SuperOfficeDemo" />
    <add key="CommandTimeOut" value="300" />
    <add key="TablePrefix" value="CRM5" />
    <add key="ConnectionString" value="Server=[@Server];Database=[@Database];User ID=[@User];Password=[@Password]" />
  </Database>

  <ImplicitAnonymous>
    <add key="Allowed" value="True" />
    <add key="DBUser" value="crm5" />
    <add key="DBPassword" value="crm5myd" />
    <add key="CommonDBConnection" value="True" />
    <add key="SoUser" value="ANONYMOUS" />
    <add key="SoPassword" value="ANONYMOUS" />
  </ImplicitAnonymous>

  <Explicit>
    <add key="ExternalPersonAllowed" value="True" />
    <add key="EmployeeAllowed" value="True" />
    <add key="SystemAllowed" value="True" />
    <add key="DBUser" value="crm5" />
    <add key="DBPassword" value="crm5myd" />
    <add key="CommonDBConnection" value="True" />
  </Explicit>
</Data>
```

The database attributes that are specified here will be used when logging into the database and selecting what is the server and what is the actual database name will be also done from what we specify here.

## \<Cryptography> section in web.config

> [!NOTE]
> If you have a cluster of web servers, it is very important to keep the `cryptography` section of `web.config` files the same in all cluster machines. For example, if the below cryptography section is used in one `web.config` file, all other `web.config` files in the cluster **must maintain the same secret**.

```XML
<Cryptography>
  <add key="SymmetricKey" value="ttkggjjj5uiuuGTREdfdsfsfkoKKwqeqeGGGkjuiuJJ=" />
  <add key="SymmetricIV" value="aBL3Kh0mXHzn+NvXkSS/Lg==" />
  <add key="SymmetricSecret" value="SupperOffice Testing" />
</Cryptography>
```
