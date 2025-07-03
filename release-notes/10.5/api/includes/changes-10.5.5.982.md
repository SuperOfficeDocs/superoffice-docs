---
uid: version_10.5.5.982_changes
date: 09.05.2025
---

<!-- markdownlint-disable-file MD041 MD033 MD024-->
Changes from v10.5.4.867 and v10.5.5.982

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.AppointmentMoveData`
* `SuperOffice.CRM.Services.VideoMeetingReservation`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `CreateVideoMeetingReservation()`
  * Method `DeleteVideoMeetingReservation(String)`
  * Method `MoveExtended(AppointmentMoveData)`

#### SuperOffice.CRM.Services.CustomerServiceAgent is Modified

* New items
  * Method `EventHandlersExists(EventHandlerType[])`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableDeleted(String)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `CreateVideoMeetingReservation()`
  * Method `DeleteVideoMeetingReservation(String)`
  * Method `MoveExtended(AppointmentMoveData)`

#### SuperOffice.CRM.Services.ICustomerServiceAgent is Modified

* New items
  * Method `EventHandlersExists(EventHandlerType[])`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `PerformTasksAfterCustomObjectTableDeleted(String)`

#### SuperOffice.CRM.Services.ISaleAgent is Modified

* New items
  * Method `SetAsLostWithReason(Int32[], Int32)`
  * Method `SetAsSoldWithReason(Int32[], Int32)`

#### SuperOffice.CRM.Services.SaleAgent is Modified

* New items
  * Method `SetAsLostWithReason(Int32[], Int32)`
  * Method `SetAsSoldWithReason(Int32[], Int32)`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Deleted Types

* `SuperOffice.IO.Files.SoArcConfiguration`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.IconHints is Modified

* New items
  * Field `.IconHintsAppointment_Busy`
  * Field `.IconHintsAppointment_Free`

#### SuperOffice.CRM.FunctionRightStrings is Modified

* New items
  * Field `HideService`

#### SuperOffice.Data.ShipmentAddrStatus is Modified

* New items
  * Field `TestMail`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ARCHIVE_SALE_STAGE_ID`
  * Field `SR_ARCHIVE_SALE_STAGE_NAME`
  * Field `SR_ARCHIVE_SALETYPE_ID`
  * Field `SR_BOARD_COLOR_BY`
  * Field `SR_BOARD_DAYS_SINCE`
  * Field `SR_BOARD_FILTER_COUNT`
  * Field `SR_BOARD_FILTER_SALE`
  * Field `SR_BOARD_FILTER_TICKET`
  * Field `SR_BOARD_FILTER_TOOLBAR`
  * Field `SR_BOARD_HIDE_CLOSED_SALES`
  * Field `SR_BOARD_HIDE_EMPTY_GROUPS`
  * Field `SR_BOARD_INVALID_GROUP_SUBGROUP`
  * Field `SR_BOARD_INVALID_STAGE`
  * Field `SR_BOARD_REGISTERED_SINCE`
  * Field `SR_BOARD_SET_AS_LOST`
  * Field `SR_BOARD_SET_AS_SOLD`
  * Field `SR_BOARD_SUBGROUP_BY`
  * Field `SR_BOARD_SUM_BY`
  * Field `SR_BOARD_TOGGLE_TOOLBAR`
  * Field `SR_BOARD_VIEW`
  * Field `SR_DIARYARCHIVE_ISFREE`
  * Field `SR_DIARYARCHIVE_ISFREE_TOOLTIP`
  * Field `SR_EIS_PROVIDEMANDATORY`
  * Field `SR_PL_INTERESTS_PERSON`
  * Field `SR_SALESARCHIVE_NUMBER`
  * Field `SR_SELECTION_VIEW`
  * Field `SR_TICKET_AI_BAD_RESPONSE`
  * Field `SR_TICKET_AI_GENERATED_REPLY`
  * Field `SR_TICKET_AI_GOOD_RESPONSE`
  * Field `SR_TICKET_CATEGORY_ID`
  * Field `SR_TICKET_CATEGORY_ID_TOOLTIP`
  * Field `SR_TICKET_INSERT_REPLY`
  * Field `SR_TICKET_PRIORITY_ID`
  * Field `SR_TICKET_PRIORITY_ID_TOOLTIP`
  * Field `SR_TICKET_READSTATUS_CHANGED`
  * Field `SR_TICKET_READSTATUS_READ`
  * Field `SR_TICKET_READSTATUS_UNREAD`
  * Field `SR_TICKET_REPLY_TEMPLATES_AND_FAQ`
  * Field `SR_TICKET_STATUS_ID`
  * Field `SR_TICKET_SUGGESTED_FAQS`

#### SuperOffice.IO.ITempFileProvider is Modified

* New items
  * Method `CreateFileForAppending(String)`

#### SuperOffice.Util.HtmlHelper is Modified

* New items
  * Method `ExtractBodyFromHtml(String, Boolean)`

### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.ArchiveLists.RecipientFavouritesProvider`
* `SuperOffice.CRM.Lists.RecipientFavoriteListProvider`
* `SuperOffice.CRM.Tooltips.TicketReadStatusTooltipPlugin`
* `SuperOffice.Data.SQL.HasNoFlag`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.TicketProvider is Modified

* New items
  * Method `PostProcessQuery()`

#### SuperOffice.CRM.Documents.ArchiveTempFileProvider is Modified

* New items
  * Method `CreateFileForAppending(String)`

#### SuperOffice.CRM.Lists.AssociateMDOProviderBase is Modified

#### SuperOffice.CRM.Ticket.TicketHelper is Modified

* New items
  * Method `AddRestrictionToOwnCategories(Select, TicketTableInfo, Int32)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(HasNoFlag)`

#### SuperOffice.Data.SQL.Argument is Modified

* New items
  * Method `HasNoFlag(Argument)`

#### SuperOffice.Util.VideoMeetingHelper is Modified

* New items
  * Property `ReserveMeetingUrl`
  * Method `CreateVideoMeetingReservation()`
  * Method `DeleteMeetingUrl(String)`
  * Method `DeleteVideoMeetingReservation(String)`
  * Method `UnreserveMeetingUrl(String)`

##### SuperOffice.Util.VideoMeetingHelper.VideoMeetingReservation is New

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_120_CopyLabelSubstitutions`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_121_PrimingDataUpdateRLDaysDA`

### Modified Types

#### SuperOffice.CD.Database.ShipmentAddrStatus is Modified

* New items
  * Field `TestMail`
