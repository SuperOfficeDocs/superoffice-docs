---
title: Downloads element
uid: ns_config_Downloads
description: NetServer configuration values related to Downloads.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, WebTools, Downloads, DownloadFolder, NewTrayAppUrl, ReportingInterval, WebSiteEndPoint, WebToolVersion
so.topic: reference
so.envir: onsite
---

# NetServer Downloads element (SuperOffice only)

Configuration values related to Downloads.

```XML
<Downloads>
  <add key="WebToolVersion" value="8.3.0.0" />
</Downloads>
```

| Name | Description | Default |
|---|---|---|
| DownloadFolder | Folder of files to be downloaded to the client. | *~/Download* |
| DownloadFolderImpersonate | Impersonate as the document archive user when accessing the Download folder. | false |
| NewTrayAppUrl | Public address of the URL for showing download-page of new TrayApp. Empty value will calculate a default value. | |
| ReportingInterval | The interval (in seconds) that the web-installation will require activity updates from WebTools-clients for the clients to be considered active. | 60 |
| WebSiteEndPoint | Public address of the web server, including protocol and port. Empty value will calculate a default value. | |
| WebToolVersion | The version number to use for upgrade check. | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Downloads>
