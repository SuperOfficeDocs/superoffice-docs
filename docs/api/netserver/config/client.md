---
title: NetServer Client element
uid: ns_config_client
description: Configuration values related to NetServer client configuration, extension of ClientConfigurationProvider.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: NetServer, web.config, ClientConfigurationProvider, Client, export
so.topic: reference
so.envir: onsite
so.client: web
---

# NetServer Client element (SuperOffice only)

Configuration values related to client configuration, extension of `ClientConfigurationProvider`.

In this section, you add the [Reverse proxy][4] override if you want to export larger selections (Task-Export to Excel) from the web client.

```XML
<Client>
  <add key="ExportPageSize" value="10" />
</Client>
```

| Name | Description | Default |
|---|---|---|
| ApplicationInstance | Web client instance name - used to resolve page config files. | Web - **Don't change!** |
| ApplicationName | Web client application name - used to resolve page config files. | WebClient - **Don't change!** |
| ApplicationTitle | Application title shown to the user. For example, "My customized site name". | SuperOffice® CRM |
| ClientCacheKey | Cache key that is appended (if it exists) to the query string for JavaScript and CSS includes. | |
| ExportBatchTaskThreshold | Threshold when an Export is delegated to a Batch Task, rather than being run directly in the Web server. | |
| ExportPageSize | **Obsolete, no longer in use.** See `ExportRowLimit` and `ExportBatchTaskThreshold`. | 10000 rows |
| ExportRowLimit | Absolute upper limit for the number of rows in a file export, such as an Excel Export from Archives. | |
| GoogleImportClientId | Client ID when importing from Google. | |
| GoogleImportClientSecret | Client secret when importing from Google. | |
| GoogleImportDispatcher | URL to import from Google. | |
| HelpFilesBaseUrl | Override the help files location. Used to support local deployments and to point to one help file location in large server farm environments. | |
| MasterDcfConfigHashKeyFormat | The format key used to generate a unique DCF page config hash.<br>{0} = MachineName; {1} = Build-label;{2} = Assembly version | 0 |
| NetServicesNextDate | Override the Next Check Date preference for NetServices Status checking. Useful for testing. YYYY.MM.DD | |
| NetServicesStatusUrl | Override the default NetServices Status URL with this value. Useful for testing. | |
| ShowWelcomeDialogs | Allow automated tests to disable WebTools and welcome dialogs. | |
| UrlHostOverride | Overridden value of host, like: `web.superoffice.com` or `socrm.myorganization.com`. | |
| UrlPortOverride | Overridden value of port, like: 80 or 443. | |
| UrlSchemeOverride | Overridden value of scheme (HTTP or HTTPS). | |
| WebAppUsage | Enable the collection of Web Client usage statistics (only view usage, no references to actual data). | |
| WWW3Url | The root-URL of the global SuperOffice www3 host. | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Client>
[2]: ../../../../superoffice-docs/docs/onsite/install/iis/reverse-proxy.md
