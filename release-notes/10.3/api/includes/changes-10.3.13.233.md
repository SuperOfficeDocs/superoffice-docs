---
uid: version_10.3.13.233_changes
date: 12/6/2024
---

Changes from v10.3.12.929 and v10.3.13.233

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.EMailAccount is Modified

* New items
  * Property `LastFetch`
  * Property `SimpleMode`

#### SuperOffice.CRM.Services.ISaleAgent is Modified

* New items
  * Method `SaleHasQuote(Int32)`

#### SuperOffice.CRM.Services.SaleAgent is Modified

* New items
  * Method `SaleHasQuote(Int32)`

## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Diagnostics.SimplePeriodicGrafanaReporter is Modified

* New items
  * Method `ReportMaxSample(String, String, String, Int32)`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_FEATURE_TOGGLES`
  * Field `SR_MENU_OPEN_TARGETS`
  * Field `SR_QUOTE_QUOTEALTERNATIVE_RENAME`
  * Field `SR_TICKET_REQUEST_PROPERTIES`

#### SuperOffice.Util.TimeConverter is Modified

* New items
  * Method `ConvertLocalKindToBase(DateTime)`

### Assembly: SoDatabase

### Modified Types

#### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.ExtensibleColumnsBase.DbColumnBinding is Modified

* New items
  * Property `.DbColumnBindingOrderByArgument`

#### SuperOffice.CRM.ArchiveLists.ExtraFieldExtenderBase is Modified

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentExtraFieldExtender is Modified

* New items
  * Method `AppointmentExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.ArchiveLists.Joiners.ContactExtraFieldExtender is Modified

* New items
  * Method `ContactExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.ArchiveLists.Joiners.ProjectExtraFieldExtender is Modified

* New items
  * Method `ProjectExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.ArchiveLists.Joiners.SaleExtraFieldExtender is Modified

* New items
  * Method `SaleExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.ArchiveLists.Joiners.TicketExtraFieldExtender is Modified

* New items
  * Method `TicketExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.ArchiveLists.MultiQueryProviderBase is Modified

* New items
  * Property `InhibitParallelStart`

#### SuperOffice.CRM.ArchiveLists.PersonExtraFieldExtender is Modified

* New items
  * Method `PersonExtraFieldExtender(String, Features)`

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.EmailAccountFields is Modified

* New items
  * Field `.EmailAccountFieldsLastFetch`
  * Field `.EmailAccountFieldsSimpleMode`

#### SuperOffice.CRM.Data.EmailAccountTableInfo is Modified

* New items
  * Property `LastFetch`
  * Property `SimpleMode`

#### SuperOffice.CRM.Rows.EmailAccountRecordData is Modified

* New items
  * Field `LastFetch`
  * Field `SimpleMode`

#### SuperOffice.CRM.Rows.EmailAccountRow is Modified

* New items
  * Property `LastFetch`
  * Property `SimpleMode`

#### SuperOffice.CRM.Ticket.LiveUiStatisticsHelper is Modified

* Deleted items
  * Method `CollectCounter(String, Int32)`
* New items
  * Method `CollectCounter(String, Int32, AccumulationType)`

##### SuperOffice.CRM.Ticket.LiveUiStatisticsHelper.AccumulationType is New

## Continuous Database

The following represent changes to SuperOffice database schema.

No changes detected.