---
uid: version_10.3.9.734_changes
date: 01.10.2024
---

Changes from v10.3.9.718 and v10.3.9.734

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


### Assembly: SoDatabase

No Changes.

### Assembly: SoLicense

No Changes.

## Continuous Database

No Changes.
