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

* v10.2.6
  * [EmailFlowContentProvider][120]
  * [ExternalDocumentItems][121]

* v10.2.5
  * ExternalDocumentFolder (Renamed in 10.2.6)
  * [ExternalDocumentItems][121]
  * [ExternalDocuments][122]

* v10.2.4
  * [EmailFlowFolders][62]
  * [EmailFlowInstances][63]
  * [EmailFlows][64]
  * [EmailFlowsAndFolders][65]
  * [TicketNewMessageNotification (replaces TicketUpdatedNotification)][66]

* v10.2.3
  * [ticketactivatednotification][52]
  * [ticketcustommessagenotification][53]
  * [ticketescalatednotification][54]
  * [ticketfavouriteupdatednotification][55]
  * [ticketnewnotification][56]
  * [ticketnotification][58]
  * [tickettransferrednotification][57]

* v10.2.2
  * [Recycle ticket][2]

## New MDO Providers

* v10.2.10
  * [EmailPhone][210]
  * [WorkflowSplitOptionType][211]

* v10.2.9
  * [ShipmentLinks][180]
  * [SpecifiedMailings][181]
  * [TimeZoneIANA][182]
  * [WorkflowTimeWaitAlgorithm][183]
  * [WorkflowTimeWaitIntervalType][184]

* v10.2.8
  * [AppointmentResource][140]
  * [contact_and_person_freetextsearch][141]
  * [contact_and_person_freetextsearch_hierarchical][142]
  * [tickettype][179]

* v10.2.4
  * [EmailFlow][67]
  * [EmailFromType][68]
  * [EmailReplyToType][69]
  * [MailingDomains][70]
  * [WorkflowDefinitionStatus][71]
  * [WorkflowGoalType][72]
  * [WorkflowInstanceStatus][73]
  * [WorkflowTriggerType][74]

* v10.2.3
  * [workflowsteptype][59]

* v10.2.2
  * [Related data fields][3]
  * [Task menu][4]
  * [Task menu destination][5]
  * [Task menu group][6]
  * [URL encoding][7]

## New web service methods

| Agent Name       | Method Name                            | Version | REST Agent      | SOAP Agent      |
|------------------|----------------------------------------|:-------:|-----------------|-----------------|
|IAIAgent          | ExpandText                             |10.2.9   | [REST Link][185]| [SOAP Link][197] |
|IAIAgent          | GetChatbotPromptSuggestions            |10.2.9   | [REST Link][186]| [SOAP Link][198] |
|IAIAgent          | GetChatbotResponse                     |10.2.9   | [REST Link][187]| [SOAP Link][199] |
|IAIAgent          | GetSummarizeContactPrompt              |10.2.9   | [REST Link][188]| [SOAP Link][200] |
|IAIAgent          | GetSummarizeSalePrompt                 |10.2.9   | [REST Link][189]| [SOAP Link][201] |
|IAIAgent          | GetSummarizeTicketPrompt               |10.2.9   | [REST Link][190]| [SOAP Link][202] |
|IAIAgent          | RephraseText                           |10.2.9   | [REST Link][191]| [SOAP Link][203] |
|IAIAgent          | SummarizeContact                       |10.2.9   | [REST Link][192]| [SOAP Link][204] |
|IAIAgent          | SummarizeSale                          |10.2.9   | [REST Link][193]| [SOAP Link][205] |
|IAIAgent          | SummarizeText                          |10.2.9   | [REST Link][194]| [SOAP Link][206] |
|IAIAgent          | SummarizeTicket                        |10.2.9   | [REST Link][195]| [SOAP Link][207] |
|IAppointmentAgent | CleanUpBookingDeletedWithUpdateMode    |10.2.3   | [REST Link][44] | [SOAP Link][45] |
|IAppointmentAgent | CreateAppointmentEntityFromExisting    |10.2.8   | [REST Link][137]| [SOAP Link][138]|
|IAppointmentAgent | GetNextAvailableTime                   |10.2.10  | [REST Link][213]| [SOAP Link][212]|
|IAppointmentAgent | SetSeenMany                            |10.2.2   | [REST Link][60] | [SOAP Link][61] |
|IArchiveAgent     | GetRelatedData                         |10.2.1   | [REST Link][8]  | [SOAP Link][26] |
|IArchiveAgent     | GetRelatedData2                        |10.2.1   | [REST Link][9]  | [SOAP Link][27] |
|IAssociateAgent   | GetEncryptionKey                       |10.2.6   | [REST Link][123]| [SOAP Link][124]|
|IContactAgent     | GetDomainDuplicates                    |10.2.10  | [REST Link][214]| [SOAP Link][215]|
|ICRMScriptAgent   | ExecuteScriptByString                  |10.2.8   | [REST Link][139]| [SOAP Link][143]|
|ICRMScriptAgent   | ValidateScriptByString                 |10.2.8   | [REST Link][144]| [SOAP Link][145]|
|IDiagnosticsAgent | GetEntityCountsForCurrentUser          |10.2.4   | [REST Link][76] | [SOAP Link][98] |
|IDocumentAgent    | CopyDocumentToCsAttachment             |10.2.8   | [REST Link][146]| [SOAP Link][147]|
|IEMailAgent       | HasSPFRecord                           |10.2.1   | [REST Link][10] | [SOAP Link][28] |
|IEMailAgent       | ResolveEMailRecipients                 |10.2.4   | [REST Link][77] | [SOAP Link][99] |
|IListAgent        | CreateDefaultTaskMenu                  |10.2.1   | [REST Link][11] | [SOAP Link][29] |
|IListAgent        | CreateDefaultTicketTypeEntity          |10.2.8   | [REST Link][148]| [SOAP Link][149]|
|IListAgent        | DeleteAppTaskMenus                     |10.2.1   | [REST Link][12] | [SOAP Link][30] |
|IListAgent        | DeleteTaskMenu                         |10.2.1   | [REST Link][13] | [SOAP Link][31] |
|IListAgent        | DeleteTicketTypeEntity                 |10.2.8   | [REST Link][151]| [SOAP Link][152]|
|IListAgent        | GetAllTicketTypeEntities               |10.2.8   | [REST Link][177]| [SOAP Link][178]|
|IListAgent        | GetTicketType                          |10.2.8   | [REST Link][153]| [SOAP Link][154]|
|IListAgent        | GetTicketTypeEntity                    |10.2.8   | [REST Link][155]| [SOAP Link][156]|
|IListAgent        | GetTicketTypeList                      |10.2.8   | [REST Link][157]| [SOAP Link][158]|
|IListAgent        | GetTicketTypes                         |10.2.8   | [REST Link][159]| [SOAP Link][160]|
|IListAgent        | GetAppTaskMenus                        |10.2.1   | [REST Link][14] | [SOAP Link][32] |
|IListAgent        | GetTaskMenu                            |10.2.1   | [REST Link][15] | [SOAP Link][33] |
|IListAgent        | GetTaskMenuByProgId                    |10.2.1   | [REST Link][16] | [SOAP Link][34] |
|IListAgent        | GlobalChangeTicketType                 |10.2.10  | [REST Link][216]| [SOAP Link][217]|
|IListAgent        | SaveTaskMenu                           |10.2.1   | [REST Link][17] | [SOAP Link][35] |
|IListAgent        | SaveTicketTypeEntity                   |10.2.8   | [REST Link][161]| [SOAP Link][162]|
|IMarketingAgent   | GetFormSubmissionsCount                |10.2.2   | [REST Link][17] | [SOAP Link][35] |
|IPersonAgent      | CreateDefaultPersonImage               |10.2.1   | [REST Link][18] | [SOAP Link][36] |
|IPersonAgent      | CreateOrUpdateUserCandidate            |10.2.4   | [REST Link][78] | [SOAP Link][100]|
|IPersonAgent      | GetCustomerCentrePasswordReplyTemplate |10.2.4   | [REST Link][79] | [SOAP Link][101]|
|IPersonAgent      | GetPersonImages                        |10.2.1   | [REST Link][19] | [SOAP Link][37] |
|IPersonAgent      | GetUserCandidateByPerson               |10.2.4   | [REST Link][80] | [SOAP Link][102]|
|IPersonAgent      | SendEmail                              |10.2.4   | [REST Link][81] | [SOAP Link][103]|
|IPersonAgent      | SendEmailWithEventName                 |10.2.10  | [REST Link][218]| [SOAP Link][219]|
|ITicketAgent      | ClearNotify                            |10.2.3   | [REST Link][46] | [SOAP Link][47] |
|ITicketAgent      | CopyFromCRMDocument                    |10.2.3   | [REST Link][48] | [SOAP Link][49] |
|ITicketAgent      | CopyToTempFile                         |10.2.6   | [REST Link][125]| [SOAP Link][126]|
|ITicketAgent      | GetDefaultMessageContentFull           |10.2.10  | [REST Link][220]| [SOAP Link][221]|
|ITicketAgent      | GetNextInQueue                         |10.2.3   | [REST Link][50] | [SOAP Link][51] |
|ITicketAgent      | GetTicketMessageEntities               |10.2.9   | [REST Link][196]| [SOAP Link][208]   |
|ITicketAgent      | GetTicketMessageWithOptions            |10.2.1   | [REST Link][20] | [SOAP Link][38] |
|ITicketAgent      | SplitTicket                            |10.2.8   | [REST Link][163]| [SOAP Link][164]|
|ITicketAgent      | UndeleteByIds                          |10.2.1   | [REST Link][21] | [SOAP Link][39] |
|ITicketAgent      | ValidateAttachments                    |10.2.1   | [REST Link][22] | [SOAP Link][40] |
|IUserAgent        | GetUserPresenceStatus                  |10.2.1   | [REST Link][23] | [SOAP Link][41] |
|IUserAgent        | SetUserPresenceStatus                  |10.2.1   | [REST Link][24] | [SOAP Link][42] |
|IUserDefinedFieldInfoAgent | ClearCaches                   |10.2.1   | [REST Link][25] | [SOAP Link][43] |
|IViewStateAgent   | GetLiveUiConfig                        |10.2.4   | [REST Link][82] | [SOAP Link][104]|
|IViewStateAgent   | PublishAndRetrieveUiEvents (in 10.2.4) |10.2.6   | [REST Link][83] | [SOAP Link][105]|
|IWorkflowAgent    | ConnectEmailFlowContent                |10.2.6   | [REST Link][127]| [SOAP Link][128]|
|IWorkflowAgent    | CopyEmailFlowContent                   |10.2.8   | [REST Link][165]| [SOAP Link][166]|
|IWorkflowAgent    | CreateDefaultWorkflowEvent             |10.2.8   | [REST Link][167]| [SOAP Link][168]|
|IWorkflowAgent    | CreateDefaultWorkflowEventResult       |10.2.8   | [REST Link][169]| [SOAP Link][170]|
|IWorkflowAgent    | CreateDefaultWorkflowFilter            |10.2.4   | [REST Link][84] | [SOAP Link][106]|
|IWorkflowAgent    | CreateDefaultWorkflowGoal              |10.2.4   | [REST Link][85] | [SOAP Link][107]|
|IWorkflowAgent    | CreateDefaultWorkflowStepFromType      |10.2.4   | [REST Link][86] | [SOAP Link][108]|
|IWorkflowAgent    | CreateDefaultWorkflowStepOptionFromType|10.2.10  | [REST Link][222]| [SOAP Link][223]|
|IWorkflowAgent    | CreateDefaultWorkflowTrigger           |10.2.4   | [REST Link][88] | [SOAP Link][110]|
|IWorkflowAgent    | CreateEmailFlowContent                 |10.2.6/8 | [REST Link][129]| [SOAP Link][130]|
|IWorkflowAgent    | DeleteWorkflowGoal                     |10.2.4   | [REST Link][89] | [SOAP Link][111]|
|IWorkflowAgent    | DeleteWorkflowTrigger                  |10.2.4   | [REST Link][91] | [SOAP Link][113]|
|IWorkflowAgent    | GetWorkflowGoal                        |10.2.4   | [REST Link][92] | [SOAP Link][114]|
|IWorkflowAgent    | GetWorkflowStepOption                  |10.2.4   | [REST Link][93] | [SOAP Link][115]|
|IWorkflowAgent    | GetWorkflowTrigger                     |10.2.4   | [REST Link][94] | [SOAP Link][116]|
|IWorkflowAgent    | RemoveParticipantsFromEmailFlow        |10.2.8   | [REST Link][171]| [SOAP Link][172]|
|IWorkflowAgent    | Run                                    |10.2.8   | [REST Link][173]| [SOAP Link][174]|
|IWorkflowAgent    | SaveWorkflowGoal                       |10.2.4   | [REST Link][95] | [SOAP Link][117]|
|IWorkflowAgent    | SaveWorkflowTrigger                    |10.2.4   | [REST Link][97] | [SOAP Link][119]|
|IWorkflowAgent    | SendEvent                              |10.2.8   | [REST Link][175]| [SOAP Link][176]|

## Breaking changes - modified web service methods

| Agent Name       | Method Name                           | Version | Reason                            |
|------------------|---------------------------------------|:-------:|-----------------|-----------------|
|ITicketAgent      | SaveTicketMessageEntityWithOptions    |10.2.4   |                                   |
|ITicketAgent      | SplitTicket                           |10.2.8   | Added two new arguments.          |
|IWorkflowAgent    | CreateEmailFlowContent                |10.2.8   | Added one new argument            |
|IWorkflowAgent    | CreateDefaultWorkflowStepOption       |10.2.10  | Deleted                           |
|IWorkflowAgent    | DeleteWorkflowStepOption              |10.2.10  | Deleted                           |
|IWorkflowAgent    | SaveWorkflowStepOption                |10.2.10  | Deleted                           |

### Authentication using SoAccessTokenSecurityToken

The following is a breaking change in the API. SoAccessTokenSecurityToken was removed from the codebase in version 10.? without notification.

```csharp
var accessToken = "8A:Cust12345.ey...token_string...54321abcd";

using (var session = SoSession.Authenticate(new SoAccessTokenSecurityToken(accessToken)))
{
  Console.WriteLine($"Authenticated {session.Principal.Associate} using implicit Windows Identity.");
}
```

Instead, now you are required to use the new SoCredentials class.

```csharp
var accessToken = "8A:Cust12345.ey...token_string...54321abcd";

using (var session = SoSession.Authenticate(new SoCredentials(accessToken)))
{
    // execute NetServer code...
}
```

### Context Provider changes

The custom ContextProvider functionality was changed and caused breaking changes for partner applications. Please refer to the [forum post on Community](https://community.superoffice.com/en/technical/forums/api-forums/online-web-services/how-to-use-netserver-nuget-packages-in-10.2-against-remote-webservices/).

No additional resources exist for this topic.

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
  //... set options
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
* [Version 10.2.2][131]
* [Version 10.2.3][132]
* [Version 10.2.4][133]
* [Version 10.2.5][134]
* [Version 10.2.6][135]
* [Version 10.2.8][136]
* [Version 10.2.9][209]
* [Version 10.2.10][224]
* [Version 10.2.11][225]

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
[44]: ../../../docs/en/api/reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CleanUpBookingDeletedWithUpdateMode.md
[45]: ../../../docs/en/api/reference/soap/Services88/Appointment/CleanUpBookingDeletedWithUpdateMode.md
[46]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_ClearNotify.md
[47]: ../../../docs/en/api/reference/soap/Services88/Ticket/ClearNotify.md
[48]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_CopyFromCRMDocument.md
[49]: ../../../docs/en/api/reference/soap/Services88/Ticket/CopyFromCRMDocument.md
[50]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_GetNextInQueue.md
[51]: ../../../docs/en/api/reference/soap/Services88/Ticket/GetNextInQueue.md
[52]: ../../../docs/en/api/archive-providers/reference/ticketactivatednotification.md
[53]: ../../../docs/en/api/archive-providers/reference/ticketcustommessagenotification.md
[54]: ../../../docs/en/api/archive-providers/reference/ticketescalatednotification.md
[55]: ../../../docs/en/api/archive-providers/reference/ticketfavouriteupdatednotification.md
[56]: ../../../docs/en/api/archive-providers/reference/ticketnewnotification.md
[57]: ../../../docs/en/api/archive-providers/reference/tickettransferrednotification.md
[58]: ../../../docs/en/api/archive-providers/reference/ticketnotification.md
[59]: ../../../docs/en/api/mdo-providers/reference/workflowsteptype.md
[60]: ../../../docs/en/api/reference/restful/agent/Appointment_Agent/v1AppointmentAgent_SetSeenMany.md
[61]: ../../../docs/en/api/reference/soap/Services88/Appointment/SetSeenMany.md
[62]: ../../../docs/en/api/archive-providers/reference/emailflowfolders.md
[63]: ../../../docs/en/api/archive-providers/reference/emailflowinstances.md
[64]: ../../../docs/en/api/archive-providers/reference/emailflows.md
[65]: ../../../docs/en/api/archive-providers/reference/emailflowsandfolders.md
[66]: ../../../docs/en/api/archive-providers/reference/ticketnewmessagenotification.md
[67]: ../../../docs/en/api/mdo-providers/reference/emailflow.md
[68]: ../../../docs/en/api/mdo-providers/reference/emailfromtype.md
[69]: ../../../docs/en/api/mdo-providers/reference/emailreplytotype.md
[70]: ../../../docs/en/api/mdo-providers/reference/mailingdomains.md
[71]: ../../../docs/en/api/mdo-providers/reference/workflowdefinitionstatus.md
[72]: ../../../docs/en/api/mdo-providers/reference/workflowgoaltype.md
[73]: ../../../docs/en/api/mdo-providers/reference/workflowinstancestatus.md
[74]: ../../../docs/en/api/mdo-providers/reference/workflowtriggertype.md
[76]: ../../../docs/en/api/reference/restful/agent/Diagnostics_Agent/v1DiagnosticsAgent_GetEntityCountsForCurrentUser.md
[77]: ../../../docs/en/api/reference/restful/agent/EMail_Agent/v1EMailAgent_ResolveEMailRecipients.md
[78]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_CreateOrUpdateUserCandidate.md
[79]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_GetCustomerCentrePasswordReplyTemplate.md
[80]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_GetUserCandidateByPerson.md
[81]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_SendEmail.md
[82]: ../../../docs/en/api/reference/restful/agent/ViewState_Agent/v1ViewStateAgent_GetLiveUiConfig.md
[83]: ../../../docs/en/api/reference/restful/agent/ViewState_Agent/v1ViewStateAgent_PublishAndRetrieveUiEvents.md
[84]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowFilter.md
[85]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowGoal.md
[86]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepFromType.md
[88]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowTrigger.md
[89]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_DeleteWorkflowGoal.md
[91]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_DeleteWorkflowTrigger.md
[92]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetWorkflowGoal.md
[93]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetWorkflowStepOption.md
[94]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_GetWorkflowTrigger.md
[95]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveWorkflowGoal.md
[97]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SaveWorkflowTrigger.md
[98]: ../../../docs/en/api/reference/soap/Services88/Diagnostics/GetEntityCountsForCurrentUser.md
[99]: ../../../docs/en/api/reference/soap/Services88/EMail/ResolveEMailRecipients.md
[100]: ../../../docs/en/api/reference/soap/Services88/Person/CreateOrUpdateUserCandidate.md
[101]: ../../../docs/en/api/reference/soap/Services88/Person/GetCustomerCentrePasswordReplyTemplate.md
[102]: ../../../docs/en/api/reference/soap/Services88/Person/GetUserCandidateByPerson.md
[103]: ../../../docs/en/api/reference/soap/Services88/Person/SendEmail.md
[104]: ../../../docs/en/api/reference/soap/Services88/ViewState/GetLiveUiConfig.md
[105]: ../../../docs/en/api/reference/soap/Services88/ViewState/PublishAndRetrieveUiEvents.md
[106]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowFilter.md
[107]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowGoal.md
[108]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowStepFromType.md
[110]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowTrigger.md
[111]: ../../../docs/en/api/reference/soap/Services88/Workflow/DeleteWorkflowGoal.md
[113]: ../../../docs/en/api/reference/soap/Services88/Workflow/DeleteWorkflowTrigger.md
[114]: ../../../docs/en/api/reference/soap/Services88/Workflow/GetWorkflowGoal.md
[115]: ../../../docs/en/api/reference/soap/Services88/Workflow/GetWorkflowStepOption.md
[116]: ../../../docs/en/api/reference/soap/Services88/Workflow/GetWorkflowTrigger.md
[117]: ../../../docs/en/api/reference/soap/Services88/Workflow/SaveWorkflowGoal.md
[119]: ../../../docs/en/api/reference/soap/Services88/Workflow/SaveWorkflowTrigger.md
[120]: ../../../docs/en/api/archive-providers/reference/externaldocumentfolders.md
[121]: ../../../docs/en/api/archive-providers/reference/externaldocumentitems.md
[122]: ../../../docs/en/api/archive-providers/reference/externaldocuments.md
[123]: ../../../docs/en/api/reference/restful/agent/Associate_Agent/v1AssociateAgent_GetEncryptionKey.md
[124]: ../../../docs/en/api/reference/soap/Services88/Associate/GetEncryptionKey.md
[125]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_CopyToTempFile.md
[126]: ../../../docs/en/api/reference/soap/Services88/Ticket/CopyToTempFile.md
[127]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_ConnectEmailFlowContent.md
[128]: ../../../docs/en/api/reference/soap/Services88/Workflow/ConnectEmailFlowContent.md
[129]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateEmailFlowContent.md
[130]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateEmailFlowContent.md
[131]: 10.2.2-update.md
[132]: 10.2.3-update.md
[133]: 10.2.4-update.md
[134]: 10.2.5-update.md
[135]: 10.2.6-update.md
[136]: 10.2.8-update.md
[137]: ../../../docs/en/api/reference/restful/agent/Appointment_Agent/v1AppointmentAgent_CreateAppointmentEntityFromExisting.md
[138]: ../../../docs/en/api/reference/soap/Services88/Appointment/CreateAppointmentEntityFromExisting.md
[139]: ../../../docs/en/api/reference/restful/agent/CRMScript_Agent/v1CRMScriptAgent_ExecuteScriptByString.md
[140]: ../../../docs/en/api/mdo-providers/reference/appointmentresource.md
[141]: ../../../docs/en/api/mdo-providers/reference/contact_and_person_freetextsearch.md
[142]: ../../../docs/en/api/mdo-providers/reference/contact_and_person_freetextsearch_hierarchical.md
[143]: ../../../docs/en/api/reference/soap/Services88/CRMScript/ExecuteScriptByString.md

[144]: ../../../docs/en/api/reference/restful/agent/CRMScript_Agent/v1CRMScriptAgent_ValidateScriptByString.md
[145]: ../../../docs/en/api/reference/soap/Services88/CRMScript/ValidateScriptByString.md

[146]: ../../../docs/en/api/reference/restful/agent/Document_Agent/v1DocumentAgent_CopyDocumentToCsAttachment.md
[147]: ../../../docs/en/api/reference/soap/Services88/Document/CopyDocumentToCsAttachment.md

[148]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_CreateDefaultTicketTypeEntity.md
[149]: ../../../docs/en/api/reference/soap/Services88/List/CreateDefaultTicketTypeEntity.md

[151]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_DeleteTicketTypeEntity.md
[152]: ../../../docs/en/api/reference/soap/Services88/List/DeleteTicketTypeEntity.md

[153]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GetTicketType.md
[154]: ../../../docs/en/api/reference/soap/Services88/List/GetTicketType.md

[155]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GetTicketTypeEntity.md
[156]: ../../../docs/en/api/reference/soap/Services88/List/GetTicketTypeEntity.md

[157]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GetTicketTypeList.md
[158]: ../../../docs/en/api/reference/soap/Services88/List/GetTicketTypeList.md

[159]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GetTicketTypes.md
[160]: ../../../docs/en/api/reference/soap/Services88/List/GetTicketTypes.md

[161]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_SaveTicketTypeEntity.md
[162]: ../../../docs/en/api/reference/soap/Services88/List/SaveTicketTypeEntity.md

[163]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_SplitTicket.md
[164]: ../../../docs/en/api/reference/soap/Services88/Ticket/SplitTicket.md

[165]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CopyEmailFlowContent.md
[166]: ../../../docs/en/api/reference/soap/Services88/Workflow/CopyEmailFlowContent.md

[167]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowEvent.md
[168]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowEvent.md

[169]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowEventResult.md
[170]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowEventResult.md

[171]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_RemoveParticipantsFromEmailFlow.md
[172]: ../../../docs/en/api/reference/soap/Services88/Workflow/RemoveParticipantsFromEmailFlow.md

[173]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_Run.md
[174]: ../../../docs/en/api/reference/soap/Services88/Workflow/Run.md

[175]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_SendEvent.md
[176]: ../../../docs/en/api/reference/soap/Services88/Workflow/SendEvent.md

[177]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GetAllTicketTypeEntities.md
[178]: ../../../docs/en/api/reference/soap/Services88/List/GetAllTicketTypeEntities.md

[179]: ../../../docs/en/api/mdo-providers/reference/tickettype.md

[180]: ../../../docs/en/api/mdo-providers/reference/shipmentlinks.md
[181]: ../../../docs/en/api/mdo-providers/reference/specifiedmailings.md
[182]: ../../../docs/en/api/mdo-providers/reference/timezoneiana.md
[183]: ../../../docs/en/api/mdo-providers/reference/workflowtimewaitalgorithm.md
[184]: ../../../docs/en/api/mdo-providers/reference/workflowtimewaitintervaltype.md

[185]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_ExpandText.md
[186]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_GetChatbotPromptSuggestions.md
[187]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_GetChatbotResponse.md
[188]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_GetSummarizeContactPrompt.md
[189]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_GetSummarizeSalePrompt.md
[190]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_GetSummarizeTicketPrompt.md
[191]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_RephraseText.md
[192]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_SummarizeContact.md
[193]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_SummarizeSale.md
[194]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_SummarizeText.md
[195]: ../../../docs/en/api/reference/restful/agent/AI_Agent/v1AIAgent_SummarizeTicket.md
[196]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_GetTicketMessageEntities.md
[197]: ../../../docs/en/api/reference/soap/Services88/AI/ExpandText.md
[198]: ../../../docs/en/api/reference/soap/Services88/AI/GetChatbotPromptSuggestions.md
[199]: ../../../docs/en/api/reference/soap/Services88/AI/GetChatbotResponse.md
[200]: ../../../docs/en/api/reference/soap/Services88/AI/GetSummarizeContactPrompt.md
[201]: ../../../docs/en/api/reference/soap/Services88/AI/GetSummarizeSalePrompt.md
[202]: ../../../docs/en/api/reference/soap/Services88/AI/GetSummarizeTicketPrompt.md
[203]: ../../../docs/en/api/reference/soap/Services88/AI/RephraseText.md
[204]: ../../../docs/en/api/reference/soap/Services88/AI/SummarizeContact.md
[205]: ../../../docs/en/api/reference/soap/Services88/AI/SummarizeSale.md
[206]: ../../../docs/en/api/reference/soap/Services88/AI/SummarizeText.md
[207]: ../../../docs/en/api/reference/soap/Services88/AI/SummarizeTicket.md
[208]: ../../../docs/en/api/reference/soap/Services88/Ticket/GetTicketMessageEntities.md
[209]: 10.2.9-update.md

[210]: ../../../docs/en/api/mdo-providers/reference/emailphone.md
[211]: ../../../docs/en/api/mdo-providers/reference/workflowsplitoptiontype.md

[212]: ../../../docs/en/api/reference/soap/Services88/Appointment/GetNextAvailableTime.md
[213]: ../../../docs/en/api/reference/restful/agent/Appointment_Agent/v1AppointmentAgent_GetNextAvailableTime.md

[214]: ../../../docs/en/api/reference/restful/agent/Contact_Agent/v1ContactAgent_GetDomainDuplicates.md
[215]: ../../../docs/en/api/reference/soap/Services88/Contact/GetDomainDuplicates.md

[216]: ../../../docs/en/api/reference/restful/agent/List_Agent/v1ListAgent_GlobalChangeTicketType.md
[217]: ../../../docs/en/api/reference/soap/Services88/List/GlobalChangeTicketType.md

[218]: ../../../docs/en/api/reference/restful/agent/Person_Agent/v1PersonAgent_SendEmailWithEventName.md
[219]: ../../../docs/en/api/reference/soap/Services88/Person/SendEmailWithEventName.md

[220]: ../../../docs/en/api/reference/restful/agent/Ticket_Agent/v1TicketAgent_GetDefaultMessageContentFull.md
[221]: ../../../docs/en/api/reference/soap/Services88/Ticket/GetDefaultMessageContentFull.md

[222]: ../../../docs/en/api/reference/restful/agent/Workflow_Agent/v1WorkflowAgent_CreateDefaultWorkflowStepOptionFromType.md
[223]: ../../../docs/en/api/reference/soap/Services88/Workflow/CreateDefaultWorkflowStepOptionFromType.md

[224]: 10.2.10-update.md
[225]: 10.2.11-update.md