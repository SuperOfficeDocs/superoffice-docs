---
uid: version_11.12.675.0_changes
date: 08.04.2026
---

Changes from v11.11.589.0 and v11.12.675.0

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Assembly: SuperOffice.Services.Implementation

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADMIN_ALREADY_CONTAINS_RELATION_BETWEEN`
  * Field `SR_ADMIN_AND`
  * Field `SR_ADMIN_ARE_SET`
  * Field `SR_ADMIN_AS_CHILD_TO`
  * Field `SR_ADMIN_AS_PARENT_TO`
  * Field `SR_ADMIN_AS_RELATED_TO`
  * Field `SR_ADMIN_BEHAVIOR`
  * Field `SR_ADMIN_CONDITION`
  * Field `SR_ADMIN_DEFINE_AUTOMATIC_BEHAVIOR`
  * Field `SR_ADMIN_DEFINE_AUTOMATIC_BEHAVIOUR`
  * Field `SR_ADMIN_DESCRIPTION`
  * Field `SR_ADMIN_EXPLAIN_THE_RULE`
  * Field `SR_ADMIN_FROM_SOURCE`
  * Field `SR_ADMIN_HAS_AN_UNKNOWN_RELATION_TO`
  * Field `SR_ADMIN_HELP`
  * Field `SR_ADMIN_IS_SET`
  * Field `SR_ADMIN_IS_SET_AS_CHILD_TO`
  * Field `SR_ADMIN_IS_SET_AS_PARENT_TO`
  * Field `SR_ADMIN_IS_SET_AS_RELATED_TO`
  * Field `SR_ADMIN_OFFER_TO_CLOSE_CHILDREN_WHEN_PARENT_IS_CLOSED`
  * Field `SR_ADMIN_OFFER_TO_CLOSE_PARENT_WHEN_ALL_CHILDREN_ARE_CLOSED`
  * Field `SR_ADMIN_ON_CLOSE`
  * Field `SR_ADMIN_ON_CREATION`
  * Field `SR_ADMIN_PREVENT_PARENT_CLOSURE`
  * Field `SR_ADMIN_RELATION`
  * Field `SR_ADMIN_RELATION_RULES`
  * Field `SR_ADMIN_REQUIRE_PARENT_TO_BE_SET`
  * Field `SR_ADMIN_ROLE_NO_ROLE_CHANGES`
  * Field `SR_ADMIN_RULE_NAME`
  * Field `SR_ADMIN_RULE_SET_APPLIES`
  * Field `SR_ADMIN_RULES_TRIGGER_AUTOMATIC_ACTIONS`
  * Field `SR_ADMIN_THESE_RULES_APPLY_WHEN`
  * Field `SR_ADMIN_THESE_RULES_APPLY_WHEN_REQUEST`
  * Field `SR_ADMIN_THIS_CONFIGURATION_CONFLICTS_WITH_EXISTING_RULES`
  * Field `SR_ADMIN_TICKET_TICKETTYPE`
  * Field `SR_ADMIN_TITLE`
  * Field `SR_ADMIN_TO_TARGET`
  * Field `SR_ERROR_COLON_NOT_ALLOWED_IN_LIST_NAME`
  * Field `SR_SMC_OPTIONS_HEADING`
  * Field `SR_TICKET_BULKCLOSE_CLOSE`
  * Field `SR_TICKET_BULKCLOSE_SEND_CLOSE`
  * Field `SR_TICKET_BULKCLOSE_SEND_MESSAGE`
  * Field `SR_TICKET_BULKCLOSE_SEND_MESSAGE_DISABLED_TOOLTIP`
  * Field `SR_TICKET_BULKCLOSE_SHOW_RECIPIENTS`
  * Field `SR_TICKET_BULKCLOSE_TICKETCOUNT`
  * Field `SR_TICKET_RELATED_WILL_NOT_BE_RELATED`
  * Field `SR_TICKET_RELATION_MISSING_TICKET_ID`
  * Field `SR_TICKET_RELATION_OTHER_ERRORS`
  * Field `SR_TICKET_RELATION_RELATION_ALREADY_EXISTS_REASON`
  * Field `SR_TICKET_RELATION_SAME_SOURCE_DESTINATION`
  * Field `SR_TICKET_RELATION_TEXT`

### Assembly: SoDatabase

### Deleted Types

* `SuperOffice.CRM.Data.UsageStatsTableInfo`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateUsageStatsRowFactory`
* `SuperOffice.CRM.Rows.PrivateFactory.PrivateUsageStatsRowsFactory`
* `SuperOffice.CRM.Rows.UsageStatsRecordData`
* `SuperOffice.CRM.Rows.UsageStatsRecordDataExtensions`
* `SuperOffice.CRM.Rows.UsageStatsRow`
* `SuperOffice.CRM.Rows.UsageStatsRows`

### New Types

* `SuperOffice.CRM.Ticket.TicketParentRelationtData`

### Modified Types

#### SuperOffice.CRM.Data.AssociateTableInfo is Modified

* Deleted items
  * Property `LeftOuterJoin_UsageStats_AssocId`

#### SuperOffice.CRM.Data.DBC is Modified

* Deleted items
  * Field `UsageStats`

##### SuperOffice.CRM.Data.DBC.UsageStatsFields is Deleted

#### SuperOffice.CRM.Ticket.TicketData is Modified

* New items
  * Property `Slevel`

#### SuperOffice.CRM.Ticket.TicketRelationHelper is Modified

* Deleted items
  * Method `GetParentRelationInfo(Int32, CancellationToken)`
  * Method `ResolveParentId(Int32, ValueTuple<Int32, Int32, Int32>)`
* Modified items
  * Method `EvaluateTicketRelationActionsAsync(Int32, CancellationToken)`
* New items
  * Method `CheckExistingRelationAsync(Int32, Int32, Int32, CancellationToken)`
  * Method `CheckIfRelationDefinitionForTicketTypesExistsAsync(Int32, Int32, Int32, TicketRelationType, CancellationToken)`
  * Method `GetTicketParentRelationDataAsync(Int32, CancellationToken)`

#### SuperOffice.Data.TablesInfo is Modified

* Deleted items
  * Method `GetUsageStatsTableInfo()`


### Assembly: SoDatabase.BusinessLogic

### Deleted Types

* `SuperOffice.CallHome.WinUsageStatCallHome`
* `SuperOffice.CRM.ArchiveLists.UsageStatsExterderBase`
* `SuperOffice.CRM.ArchiveLists.UsageStatsProvider`
* `SuperOffice.CRM.ArchiveLists.UsageStatsUsageStatsExtender`
* `SuperOffice.CRM.Lists.ContIntProvider`
* `SuperOffice.CRM.Lists.PersIntProvider`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.PhaseOneQueryCacher is Modified

* New items
  * Method `InstanceDispose()`

#### SuperOffice.CRM.Entities.AppointmentMatrix is Modified

* New items
  * Method `CalculateDaysAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Entities.IAppointmentMatrix is Modified

* New items
  * Method `CalculateDaysAsync(Int32, CancellationToken)`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `RecalculateDays(Int32)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Deleted Types

* `SuperOffice.CD.DSL.Database.T_UsageStats`


