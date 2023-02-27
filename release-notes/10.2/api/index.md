---
title: What's new in SuperOffice 10.2
uid: news-api-10.2
description: Release notes. What's new in SuperOffice 10.2
author: SuperOffice AS – Research and Development
so.date: 01.20.2023
keywords: API
so.version: 10.2
so.topic: reference
---

# API changes

## New Archive provider

* [Recycle ticket][2]

## New MDO Providers

* [Related data fields][3]
* [Task menu][4]
* [Task menu destination][5]
* [Task menu group][6]
* [URL encoding][7]

## New web service methods

| Agent Name | Method Name | REST Agent | SOAP Agent |
|------------|-------------|------------|------------|
|IArchiveAgent | GetRelatedData              | [REST Link][8]  | [SOAP Link][26] |
|IArchiveAgent | GetRelatedData2             | [REST Link][9]  | [SOAP Link][27] |
|IEMailAgent   | HasSPFRecord                | [REST Link][10] | [SOAP Link][28] |
|IListAgent    | CreateDefaultTaskMenu       | [REST Link][11] | [SOAP Link][29] |
|IListAgent    | DeleteAppTaskMenus          | [REST Link][12] | [SOAP Link][30] |
|IListAgent    | DeleteTaskMenu              | [REST Link][13] | [SOAP Link][31] |
|IListAgent    | GetAppTaskMenus             | [REST Link][14] | [SOAP Link][32] |
|IListAgent    | GetTaskMenu                 | [REST Link][15] | [SOAP Link][33] |
|IListAgent    | GetTaskMenuByProgId         | [REST Link][16] | [SOAP Link][34] |
|IListAgent    | SaveTaskMenu                | [REST Link][17] | [SOAP Link][35] |
|IPersonAgent  | CreateDefaultPersonImage    | [REST Link][18] | [SOAP Link][36] |
|IPersonAgent  | GetPersonImages             | [REST Link][19] | [SOAP Link][37] |
|ITicketAgent  | GetTicketMessageWithOptions | [REST Link][20] | [SOAP Link][38] |
|ITicketAgent  | UndeleteByIds               | [REST Link][21] | [SOAP Link][39] |
|ITicketAgent  | ValidateAttachments         | [REST Link][22] | [SOAP Link][40] |
|IUserAgent    | GetUserPresenceStatus       | [REST Link][23] | [SOAP Link][41] |
|IUserAgent    | SetUserPresenceStatus       | [REST Link][24] | [SOAP Link][42] |
|IUserDefinedFieldInfoAgent | ClearCaches    | [REST Link][25] | [SOAP Link][43] |

## NetServer Core changes

### Session Mode Changes

The config file setting for Session Mode has been removed.  This has been replaced with a session handling implementation to AddNetServerCore.

```csharp
services.AddNetServerCore<SuperOffice.Web.Security.HttpContextProvider>(options =>
{
  //... set options
}
```

The session mode is an implementation of ISoContextProvider

```csharp
public static IServiceCollection AddNetServerCore<TSessionMode>(this IServiceCollection services, Action<NetServerCoreOptionsBuilder> optionsAction = null) where TSessionMode : class, ISoContextProvider
{
  //...
}
```

There are several default implementations of ISoContextProvider located in SoCore.

* ThreadContextProvider
* ContextContextProvider
* ProcessContextProvider

Another is HttpContextProvider, located in SuperOffice.DCFWeb.

### Services Mode Changes

The Setting for Services Local or Remote NetServer mode has been removed from the Config.  This has been replaced with extension methods to IServiceCollection.

For Local mode calling Services Implementation, use:

* services.AddDCFServicesImplementation();
* services.AddServicesImplementation();
* services.AddMessagingServicesImplementation();

For remote mode using proxies, use:

* services.AddServicesProxies();

### Logging Changes

Configuration of logging has been moved from NetServer to the application using NetServer.  SuperOffice NetServer now support logging in the appsettings.json file.

```json
{
 "Logging": {
    "LogLevel": {
      "Default": "Error",
      "Microsoft": "Error",
      "SuperOffice": "Warning"
    }
  }
}
```

It is configured using the AddLogging extension method.

```csharp
services.AddLogging(a =>
{
   a.AddConfiguration(configuration.GetSection("Logging"));
});
```

## All API changes

* [Version 10.2.1][1]

<!-- Referenced links-->
[1]: 10.2.1-update.md
[2]: ../../../docs/en/api/archive-providers/reference/recycleticket.md
[3]: ../../../docs/en/api/mdo-providers/reference/relateddatafields.md
[4]: ../../../docs/en/api/mdo-providers/reference/taskmenu.md
[5]: ../../../docs/en/api/mdo-providers/reference/taskmenudestination.md
[6]: ../../../docs/en/api/mdo-providers/reference/taskmenugroup.md
[7]: ../../../docs/en/api/mdo-providers/reference/urlencoding.md
[8]: ../../../docs/en/api/reference/restful/agent/Archive_Agent/v1ArchiveAgent_GetRelatedData.md
[9]: ../../../docs/en/api/reference/restful/agent/Archive_Agent/v1ArchiveAgent_GetRelatedData2.md
[10]: ../../../docs/en/api/reference/restful/agent/EMail_Agent/v1EMailAgent_HasSPFRecord.md
[11]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_CreateDefaultTaskMenu.md
[12]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Deleteapptaskmenus.md
[13]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Deletetaskmenu.md
[14]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Getapptaskmenus.md
[15]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Gettaskmenu.md
[16]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Gettaskmenubyprogid.md
[17]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_Savetaskmenu.md
[18]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_createdefaultpersonimage.md
[19]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_getpersonimages.md
[20]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_getticketmessagewithoptions.md
[21]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_undeletebyids.md
[22]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_validateattachments.md
[23]: ../../../docs/en/api/reference/restful/agent/User_Agent/v1UserAgent_getuserpresencestatus.md
[24]: ../../../docs/en/api/reference/restful/agent/User_Agent/v1UserAgent_setuserpresencestatus.md
[25]: ../../../docs/en/api/reference/restful/agent/UserDefinedFieldInfo_Agent/v1UserDefinedFieldInfoAgent_clearcaches.md
[26]: ../../../docs/en/api/reference/soap/Services88/Archive/GetRelatedData.md
[27]: ../../../docs/en/api/reference/soap/Services88/Archive/GetRelatedData2.md
[28]: ../../../docs/en/api/reference/soap/Services88/Email/HasSpfRecord.md
[29]: ../../../docs/en/api/reference/soap/Services88/List/CreateDefaultTaskMenu.md
[30]: ../../../docs/en/api/reference/soap/Services88/List/Deleteapptaskmenus.md
[31]: ../../../docs/en/api/reference/soap/Services88/List/Deletetaskmenu.md
[32]: ../../../docs/en/api/reference/soap/Services88/List/Getapptaskmenus.md
[33]: ../../../docs/en/api/reference/soap/Services88/List/Gettaskmenu.md
[34]: ../../../docs/en/api/reference/soap/Services88/List/Gettaskmenubyprogid.md
[35]: ../../../docs/en/api/reference/soap/Services88/List/Savetaskmenu.md
[36]: ../../../docs/en/api/reference/soap/Services88/Person/CreateDefaultPersonImage.md
[37]: ../../../docs/en/api/reference/soap/Services88/Person/GetPersonImages.md
[38]: ../../../docs/en/api/reference/soap/Services88/Ticket/GetTicketMessageWithOptions.md
[39]: ../../../docs/en/api/reference/soap/Services88/Ticket/UndeleteByIds.md
[40]: ../../../docs/en/api/reference/soap/Services88/Ticket/ValidateAttachments.md
[41]: ../../../docs/en/api/reference/soap/Services88/User/GetUserPresenceStatus.md
[42]: ../../../docs/en/api/reference/soap/Services88/User/SetUserPresenceStatus.md
[43]: ../../../docs/en/api/reference/soap/Services88/UserDefinedFieldInfo/ClearCaches.md
