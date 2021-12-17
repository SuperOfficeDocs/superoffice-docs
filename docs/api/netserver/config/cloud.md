---
title: Cloud element
uid: ns_config_cloud
description: NetServer configuration for SuperOffice CRM Online.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: web.config, Cloud element, TemplatePath, ArchivePath, DefaultCallbackUrl
so.topic: reference
so.envir: cloud
so.client: online
---

# NetServer Cloud element (SuperOffice only)

Configuration for SuperOffice CRM Online. Used by SuperOffice only.

| Name | Description |
|---|---|
| ArchivePath | The path/URI to the archive. |
| CloudUrl | The URL to the SuperOffice cloud. |
| DefaultCallbackUrl | The default callback URL. |
| DispatcherUrl | The URL to the SuperOffice Dispatcher service |
| DocumentContentType | The content type to be used when creating new documents. |
| PresentationContentType | The content type to be used when creating new presentations. |
| Provider | The provider to use (Microsoft365/Google) |
| SpreadSheetContentType | The content type to be used when creating new spreadsheets. |
| TemplatePath | The path/URI to the templates. |
| TenantId | The tenant ID. |
| UseInheritedPermissions | If true, don't set permissions in the document plugin. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Cloud>
