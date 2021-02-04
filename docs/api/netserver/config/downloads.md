---
title: ns_config_Downloads
description: NetServer Downloads element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| WebSiteEndPoint | Public address of the web server, including protocol and port. Empty value will calculate a default value. |
| NewTrayAppUrl | Public address of the URL for showing download-page of new TrayApp. Empty value will calculate a default value. |
| DownloadFolder | Folder of files to be downloaded to the client.<br>Default: *~/Download* |
| WebToolVersion | The version number to use for upgrade check. |
| DownloadFolderImpersonate | Impersonate as the document archive user when accessing the Download folder.<br>Default: false |
| ReportingInterval | The interval (in seconds) that the web-installation will require activity updates from WebTools-clients for the clients to be considered active.<br>Default: 60 |
