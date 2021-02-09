---
title: ns_config_client
description: NetServer Client Element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
so.client: web
---

# NetServer Client element (SuperOffice only)

Configuration values related to client configuration, extension of `ClientConfigurationProvider`.

```XML
<Client>
  <add key="ExportPageSize" value="10" />
</Client>
```

| Name | Description |
|---|---|
| ApplicationName | Web client application name - used to resolve page config files.<br>Default: WebClient - Don't change! |
| ApplicationInstance | Web client instance name - used to resolve page config files.<br>Default: Web - Don't change! |
| HelpFilesBaseUrl | Override the help files location - to support local deployments. |
| ExportPageSize |<br>Default: 10000 |
| ApplicationTitle | Application title.<br>Default: SuperOffice® CRM |
| WebAppUsage | Enable the collection of Web Client usage statistics (only view usage, no references to actual data). |
| ClientCacheKey | Cache key that is appended (if it exists) to the query string for javascript and CSS includes. |
| UrlSchemeOverride | Overridden value of scheme (HTTP or HTTPS). |
| UrlHostOverride | Overridden value of host, like: `web.superoffice.com`. |
| UrlPortOverride | Overridden value of port, like: 80 or 443. |
| GoogleImportDispatcher | URL to import from Google. |
| GoogleImportClientId | Client ID when importing from Google. |
| GoogleImportClientSecret | Client secret when importing from Google. |
| MasterDcfConfigHashKeyFormat | The format key used to generate a unique DCF page config hash.<br>{0} = MachineName (default)<br>{1} = Build-label<br>{2} = Assembly version |
| NetServicesStatusUrl | Override the default NetServices Status URL with this value. Useful for testing. |
| NetServicesNextDate | Override the Next Check Date preference for NetServices Status checking. Useful for testing. YYYY.MM.DD |
| ShowWelcomeDialogs | Allow automated tests to disable WebTools and welcome dialogs. |
| WWW3Url | The root-URL of the global SuperOffice www3 host. |
