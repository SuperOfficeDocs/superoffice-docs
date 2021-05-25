---
title: SoFormsAuthentication element
uid: ns_config_soformsauthentication
description: NetServer SoFormsAuthentication element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer SoFormsAuthentication element

The `SoFormsAuthentication` group contains configuration settings used to control access and used by the web client `FormsAuthentication`.

```XML
<SoFormsAuthentication>
  <Pages>
    <add key="LoginUrl" value="~/Security/Login.aspx" />
    <add key="DefaultUrl" value="~/Default.aspx" />
  </Pages>
  <IgnoreList>
    <add key="errorpages" value="~/ErrorPages" />
    <add key="erroraspx" value="error.aspx" />
    <add key="filedownload" value="filedownload.aspx" />
    <add key="jsincludeashx" value="jsinclude.ashx" />
    <add key="cssincludeashx" value="cssinclude.ashx" />
    <add key="federated_loginaspx" value="~/Security/Federated_login.aspx" />
    <add key="api" value="~/api" />
    <add key="swagger" value="~/swagger" />
    <add key="mlapi" value="~/maillink_api" />
  </IgnoreList>
</SoFormsAuthentication>
```

| Name | Description |
|---|---|
| IgnoreList | List of pages and folders the `SoFormsAuthentication` should ignore. |
| Pages | List of pages. Should contain a dictionary with the following keys:<br>Mandatory: LoginUrl and DefaultUrl<br>Optional: LogoutUrl and PocketCrmLoginPage |
