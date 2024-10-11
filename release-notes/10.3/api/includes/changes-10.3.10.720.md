---
uid: version_10.3.10.720_changes
date: 10/11/2024
---

Changes from v10.3.9.718 and v10.3.10.720

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.ActivitySummaryItem is Modified

* Modified items
  * Property `Date`

#### SuperOffice.CRM.Services.AlarmData is Modified

* Modified items
  * Property `EndDate`
  * Property `StartTime`

#### SuperOffice.CRM.Services.Appointment is Modified

* Modified items
  * Property `ActiveDate`
  * Property `EndDate`
  * Property `StartDate`

#### SuperOffice.CRM.Services.AppointmentEntity is Modified

* Modified items
  * Property `ActiveDate`
  * Property `EndDate`
  * Property `StartDate`

#### SuperOffice.CRM.Services.AppointmentSyncData is Modified

* Modified items
  * Property `EndDate`
  * Property `StartDate`

#### SuperOffice.CRM.Services.DocumentEntity is Modified

* Modified items
  * Property `Date`

#### SuperOffice.CRM.Services.DocumentMigrationAgent is Modified

* New items
  * Method `GetNumberOfConfidentialDocuments()`

#### SuperOffice.CRM.Services.IDocumentMigrationAgent is Modified

* New items
  * Method `GetNumberOfConfidentialDocuments()`

#### SuperOffice.CRM.Services.IPersonAgent is Modified

* New items
  * Method `CreateTemporaryKeyWithPayload(TemporaryKeyDomain, Int32, Int32, DateTime, String)`

#### SuperOffice.CRM.Services.PersonAgent is Modified

* New items
  * Method `CreateTemporaryKeyWithPayload(TemporaryKeyDomain, Int32, Int32, DateTime, String)`

#### SuperOffice.CRM.Services.TemporaryKeyInfo is Modified

* New items
  * Property `Payload`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SoCore.Shared.CRM.Services.TimeZoneDiaryAdjustment`

### Modified Types

#### SoCore.Shared.CRM.Services.TimeZoneHintAttribute is Modified

* New items
  * Property `DiaryAdjust`
  * Method `TimeZoneHintAttribute(TimeZoneInterpretation, TimeZoneDiaryAdjustment)`

#### SuperOffice.Data.TemporaryKeyDomain is Modified

* New items
  * Field `RegisterCustomerCenterEmailVerification`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_MAILING_AUDIT_HEADER`
  * Field `SR_MAILING_AUDIT_TEXT`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Workflow.FlowEngineState`
* `SuperOffice.Util.UsedPrefKeysUtils`

### Modified Types

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.TemporaryKeyFields is Modified

* New items
  * Field `.TemporaryKeyFieldsPayload`


#### SuperOffice.CRM.Data.TemporaryKeyTableInfo is Modified

* New items
  * Property `Payload`

#### SuperOffice.CRM.Globalization.DocumentTags is Modified


#### SuperOffice.CRM.Lists.SpecifiedMailingsListProvider is Modified


#### SuperOffice.CRM.Rows.TemporaryKeyRecordData is Modified

* New items
  * Field `Payload`

#### SuperOffice.CRM.Rows.TemporaryKeyRow is Modified

* New items
  * Property `Payload`

#### SuperOffice.CRM.TemporaryKeyHelper is Modified

* Deleted items
  * Method `CreateTemporaryKey(TemporaryKeyDomain, Int32, Int32, DateTime)`
* New items
  * Method `CreateTemporaryKey(TemporaryKeyDomain, Int32, Int32, DateTime, String)`

#### SuperOffice.CRM.Workflow.WorkflowStepBase is Modified

* Deleted items
  * Method `NextStepId()`
* New items
  * Method `NextStepId(Int32)`

#### SuperOffice.CRM.Workflow.WorkflowStepSplit is Modified

* Deleted items
  * Method `NextStepId()`
* New items
  * Method `NextStepId(Int32)`

#### SuperOffice.CRM.Workflow.WorkflowUtil is Modified

* New items
  * Method `GoalReached(Int32, Int32[], Int32[])`

#### SuperOffice.Data.PrefDescCacheExtensions is Modified

* Modified items
  * Method `IsSectionHeader(PrefDescRecordData)`
  * Method `IsUserLevel(PrefDescRecordData)`
  * Method `NoSectionHeaders(IEnumerable<PrefDescRecordData>)`
  * Method `OnlySectionHeaders(IEnumerable<PrefDescRecordData>)`
  * Method `OrderByKey(IEnumerable<PrefDescRecordData>)`
  * Method `OrderBySectionThenKey(IEnumerable<PrefDescRecordData>)`
  * Method `Search(IEnumerable<PrefDescRecordData>, String)`

#### SuperOffice.Data.QueryExectionExtensions is Modified

* New items
  * Method `ExecuteScalar<T>(SqlCommand, Boolean)`

#### SuperOffice.Data.QueryExecutionHelper is Modified

* New items
  * Method `ExecuteTypedScalar<ReturnType>(SqlCommand, Boolean)`


### Assembly: SoLicense

## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### Modified Types

#### SuperOffice.CD.Database.TemporaryKeyDomain is Modified

* New items
  * Field `RegisterCustomerCenterEmailVerification`

#### SuperOffice.CD.DSL.Database.T_TemporaryKey is Modified

* New items
  * Field `Payload`



