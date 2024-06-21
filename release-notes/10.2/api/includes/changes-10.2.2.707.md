---
uid: version_10.2.2.706_changes
date: 2/15/2023
generated: 1
---

# Changes from v10.2.1.1698 and v10.2.2.706

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `SetSeenMany(Int32[], RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `SetSeenMany(Int32[], RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.IMarketingAgent is Modified

* New items
  * Method `GetFormSubmissionsCount(Int32, FormSubmissionStatus)`

#### SuperOffice.CRM.Services.MarketingAgent is Modified

* New items
  * Method `GetFormSubmissionsCount(Int32, FormSubmissionStatus)`

#### SuperOffice.CRM.Services.Ticket is Modified

* New items
  * Property `ProjectName`
  * Property `SaleHeading`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `Microsoft.Extensions.DependencyInjection.IScopedServiceProviderInheritor`

### New Types

* `SuperOffice.Data.TicketLogAction`
* `SuperOffice.Data.TicketLogFieldChange`
* `SuperOffice.Diagnostics.ExceptionLoggingContextExtensions`
* `SuperOffice.Diagnostics.IExceptionLoggingContext`
* `SuperOffice.Diagnostics.ResourceUsageBucket`
* `SuperOffice.Factory.ISoRequestItems`
* `SuperOffice.Factory.ISoRequestItemsAccessor`
* `SuperOffice.Factory.SoRequestItems`
* `SuperOffice.Factory.SoRequestItemsAccessorBase`
* `SuperOffice.Factory.SoRequestItemsAccessorExtensions`

### Modified Types

#### Microsoft.Extensions.DependencyInjection.NetServerCoreOptionsBuilder is Modified

* New items
  * Method `UseRequestItemsAccessor<TRequestContextAccessor>()`

#### Microsoft.Extensions.DependencyInjection.NetServerServiceProviderExtensions is Modified

* Deleted items
  * Method `CreateInheritedScope(IServiceProvider)`

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Mail is Modified

* Modified items

##### .Mail.Component is Modified

* Deleted items
  * Property `.ComponentReader`
  * Property `.ComponentSender`


##### .Mail.ComponentSection is Modified

* Deleted items
  * Property `.ComponentSectionReader`
  * Property `.ComponentSectionSender`


* New items

##### SuperOffice.Configuration.ConfigFile.Smtp is New

##### SuperOffice.Configuration.ConfigFile.SmtpSection is New

#### SuperOffice.Globalization.RC is Modified

* Deleted items
  * Field `SR_NOTIFICATION_SETTINGS`
* New items
  * Field `SR_FILEUPLOAD_UPLOAD_FORMAT_ERROR`
  * Field `SR_MAILING_BOUNCES`
  * Field `SR_MAILING_FORMLIST`
  * Field `SR_MAILING_FORMTEMPLATELIST`
  * Field `SR_MAILING_MESSAGETEMPLATES`
  * Field `SR_MAILING_TRACKEDLINKS`
  * Field `SR_NOTIFY_AGE_JUST_NOW`
  * Field `SR_NOTIFY_CLEAR_ALL`
  * Field `SR_NOTIFY_DONE`
  * Field `SR_NOTIFY_MEETING_CANCELLED`
  * Field `SR_NOTIFY_MEETING_CHANGED`
  * Field `SR_NOTIFY_MEETING_DECLINED`
  * Field `SR_NOTIFY_MEETING_FROM`
  * Field `SR_NOTIFY_NEW_DATE`
  * Field `SR_NOTIFY_NEW_DATETIME`
  * Field `SR_NOTIFY_NEW_LOCATION`
  * Field `SR_NOTIFY_NEW_TIME`
  * Field `SR_NOTIFY_RECURRING_ACTIVITY`
  * Field `SR_NOTIFY_SETTINGS`
  * Field `SR_NOTIFY_SETTINGS_APPOINTMENT_HEADING`
  * Field `SR_NOTIFY_SETTINGS_notifyAppointmentCancel`
  * Field `SR_NOTIFY_SETTINGS_notifyAppointmentChange`
  * Field `SR_NOTIFY_SETTINGS_notifyAppointmentDecline`
  * Field `SR_NOTIFY_SETTINGS_notifyAppointmentInvitation`
  * Field `SR_NOTIFY_SETTINGS_notifyCustomMessage`
  * Field `SR_NOTIFY_SETTINGS_notifyFavouriteRequest`
  * Field `SR_NOTIFY_SETTINGS_notifyNewMessage`
  * Field `SR_NOTIFY_SETTINGS_notifyNewRequest`
  * Field `SR_NOTIFY_SETTINGS_notifyRequestActivated`
  * Field `SR_NOTIFY_SETTINGS_notifyRequestAssignedAway`
  * Field `SR_NOTIFY_SETTINGS_notifyRequestEscalated`
  * Field `SR_NOTIFY_SETTINGS_REQUEST_HEADING`
  * Field `SR_NOTIFY_TICKET_NEW`
  * Field `SR_PD_notification_notifyAppointmentCancel_DESC`
  * Field `SR_PD_notification_notifyAppointmentCancel_NAME`
  * Field `SR_PD_notification_notifyAppointmentChange_DESC`
  * Field `SR_PD_notification_notifyAppointmentChange_NAME`
  * Field `SR_PD_notification_notifyAppointmentDecline_DESC`
  * Field `SR_PD_notification_notifyAppointmentDecline_NAME`
  * Field `SR_PD_notification_notifyAppointmentInvitation_DESC`
  * Field `SR_PD_notification_notifyAppointmentInvitation_NAME`
  * Field `SR_TICKET_STATUS_BLUE_TOOLTIP`
  * Field `SR_TICKET_STATUS_GREEN_TOOLTIP`
  * Field `SR_TICKET_STATUS_GREY_TOOLTIP`
  * Field `SR_TICKET_STATUS_RED_TOOLTIP`
  * Field `SR_TOGGLE_NAVIGATOR_TOOLTIP`
  * Field `SR_TOGGLE_SIDEPANEL_TOOLTIP`

#### SuperOffice.WebApi.OnlineAppRequestInfo is Modified

* Deleted items
  * Method `ProvideInheritance(IServiceProvider, IServiceProvider)`


### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.Data.Private.TicketLogger`
* `SuperOffice.Data.Private.TicketLoggerProcessor`
* `SuperOffice.Data.Private.TicketLoggingLogic`

### New Types

* `SuperOffice.CRM.ArchiveLists.AppointmentAcceptedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentAcceptedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentCancelledNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentCancelledNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationExtenderBase`
* `SuperOffice.CRM.ArchiveLists.AppointmentNotificationProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.AppointmentUpdatedNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.AppointmentUpdatedNotificationSubProvider`
* `SuperOffice.CRM.ArchiveLists.NotificationNotificationExtender<Info>`
* `SuperOffice.CRM.ArchiveLists.NotificationProvider`
* `SuperOffice.CRM.ArchiveLists.TicketNotificationExtender`
* `SuperOffice.CRM.ArchiveLists.TicketNotificationSubProvider`
* `SuperOffice.CRM.Data.MailingDomainsTableInfo`
* `SuperOffice.CRM.Rows.MailingDomainsRecordData`
* `SuperOffice.CRM.Rows.MailingDomainsRecordDataExtensions`
* `SuperOffice.CRM.Rows.MailingDomainsRow`
* `SuperOffice.CRM.Rows.MailingDomainsRows`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateMailingDomainsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateMailingDomainsRowsFactory`
* `SuperOffice.CRM.Ticket.TicketChangeData`
* `SuperOffice.CRM.Ticket.TicketChangeNotificator`
* `SuperOffice.Data.Private.TicketLogging.TicketLogger`
* `SuperOffice.Data.Private.TicketLogging.TicketLoggerProcessor`
* `SuperOffice.Data.Private.TicketLogging.TicketLoggingLogic`
* `SuperOffice.Data.SQL.TicketLogActionFieldInfo`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.DocumentExtenderWithoutDescriptionBase is Modified


#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified


#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* New items
  * Property `LeftOuterJoin_MailingDomains_RegisteredAssociateId`
  * Property `LeftOuterJoin_MailingDomains_UpdatedAssociateId`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.SShipmentFields is Modified

* New items
  * Field `.SShipmentFieldsSentNum`

* New items
  * Field `MailingDomains`

##### SuperOffice.CRM.Data.DBC.MailingDomainsFields is New

#### SuperOffice.CRM.Data.SShipmentTableInfo is Modified

* New items
  * Property `SentNum`

#### SuperOffice.CRM.Data.TicketLogActionTableInfo is Modified

* Modified items
  * Property `LogAction`

#### SuperOffice.CRM.FacadeHelper is Modified

* New items
  * Method `CallFacadeMethod(String, Object)`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(TicketLogAction&, FieldInfo)`
  * Method `ValidateField(TicketLogFieldChange&, FieldInfo)`

#### SuperOffice.CRM.Rows.SShipmentRecordData is Modified

* New items
  * Field `SentNum`

#### SuperOffice.CRM.Rows.SShipmentRow is Modified

* New items
  * Property `SentNum`

#### SuperOffice.CRM.Rows.TicketLogActionRecordData is Modified

* Modified items
  * Field `LogAction`

#### SuperOffice.CRM.Rows.TicketLogActionRow is Modified

* Modified items
  * Property `LogAction`

#### SuperOffice.CRM.Security.TicketSentry is Modified

* Deleted items
  * Method `EvaluateTicketRights(TableRight, Int32, Int32, Int32, TicketIntent)`
* New items
  * Method `EvaluateTicketRights(TableRight, Int32, Int32, Int32, DateTime, Int32, TicketIntent)`

#### SuperOffice.CRM.Services.Implementation.ServiceFacades.ServiceFacade is Modified

* New items
  * Method `FireServiceCall(String, Object)`

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* Deleted items
  * Method `HasUpdateRight(Int32, Int32, Int32)`
* New items
  * Method `GetTicketData(Int32)`
  * Method `HasUpdateRight(Int32, Int32, Int32, DateTime, Int32)`

#### SuperOffice.Data.SQL.SqlCommand is Modified

* New items
  * Field `AdditionalInfo`

#### SuperOffice.Data.SQL.TargetedSelect<MainTableInfo> is Modified

* Modified items
  * Method `SetIgnoreSentry(Boolean)`

#### SuperOffice.Data.TablesInfo is Modified

* New items
  * Method `GetMailingDomainsTableInfo()`


### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.Database.TicketLogAction`
* `SuperOffice.CD.Database.TicketLogFieldChange`
* `SuperOffice.CD.DSL.Database.Steps_ConfigurableScreen.Mailing_10_DomainList`
* `SuperOffice.CD.DSL.Database.Steps_CS.CS_34_TicketLogActionEnum`
* `SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_11_StatisticsSentNum`
* `SuperOffice.CD.DSL.Database.T_MailingDomains`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_SShipment is Modified

* New items
  * Field `SentNum`
