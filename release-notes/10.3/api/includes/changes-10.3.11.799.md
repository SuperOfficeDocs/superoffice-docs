---
uid: version_10.3.11.799_changes
date: 10/24/2024
---

Changes from v10.3.10.720 and v10.3.11.799

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* New items
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, Int32, Int32, Int32, RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `HasAlarm`
  * Property `IsBookingMain`
  * Property `IsCompleted`
  * Property `IsTentative`
  * Property `ProjectName`
  * Property `RecurrenceInfo`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* New items
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, Int32, Int32, Int32, RecurrenceUpdateMode)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_COMMON_FILE_MAXIMUM_SIZE`
  * Field `SR_INBOX_EMPTY_NO_SELECTION`
  * Field `SR_MAIL_FOLDER_FREETEXT_SEARCH`
  * Field `SR_QUOTE_DELETE_QUOTELINES`
  * Field `SR_SALES_ROLES`
  * Field `SR_SELECTED_CONTACTS`
  * Field `SR_SELECTION_TASK_PRINT_SELECTION`

### Assembly: SoDatabase

### Modified Types

#### SuperOffice.CRM.ArchiveLists.WorkflowExtenderBase is Modified

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.ScreenChooserFields is Modified

* New items
  * Field `.ScreenChooserFieldsEjscriptId`

#### SuperOffice.CRM.Data.EjscriptTableInfo is Modified

* New items
  * Property `LeftOuterJoin_ScreenChooser_EjscriptId`

#### SuperOffice.CRM.Data.ScreenChooserTableInfo is Modified

* New items
  * Property `EjscriptId`
  * Property `EjscriptId_InnerJoin_Ejscript`

#### SuperOffice.CRM.Lists.ShipmentLinksListProvider is Modified

* New items
  * Method `ExecuteReader(SoCommand)`

#### SuperOffice.CRM.Rows.ScreenChooserRecordData is Modified

* New items
  * Field `EjscriptId`

#### SuperOffice.CRM.Rows.ScreenChooserRow is Modified

* New items
  * Property `EjscriptId`

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.CRMScriptStep11_ScreenChooserFK`
* `SuperOffice.CD.DSL.Database.CsPackageResourceReader`
* `SuperOffice.CD.DSL.Database.ICsPackageResourceReader`
* `SuperOffice.CD.DSL.Database.Steps_Mailing.Mailing_13_LinkLength`

### Modified Types

#### SuperOffice.CD.DSL.Database.T_ScreenChooser is Modified

* New items
  * Field `EjscriptId`
