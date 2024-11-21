---
uid: version_10.3.12.929_changes
date: 11/21/2024
---

Changes from v10.3.11.910 and v10.3.12.929

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AppointmentAgent is Modified

* Deleted items
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, Int32, Int32, Int32, RecurrenceUpdateMode)`
* New items
  * Method `ConvertAppointmentToTask(Int32)`
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.EMailAgent is Modified

* New items
  * Method `CreateNewPhysicalDocumentFromEmail(Int32, Int32)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachment(Int32, Int32, String)`

#### SuperOffice.CRM.Services.IAppointmentAgent is Modified

* Deleted items
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, Int32, Int32, Int32, RecurrenceUpdateMode)`
* New items
  * Method `ConvertAppointmentToTask(Int32)`
  * Method `UpdateAppointmentWithMode(Int32, DateTime, DateTime, AppointmentStatus, AppointmentType, Int32, RecurrenceUpdateMode)`

#### SuperOffice.CRM.Services.IEMailAgent is Modified

* New items
  * Method `CreateNewPhysicalDocumentFromEmail(Int32, Int32)`
  * Method `CreateNewPhysicalDocumentFromEmailAttachment(Int32, Int32, String)`

#### SuperOffice.CRM.Services.ISentryAgent is Modified

* New items
  * Method `CanCreateAppointmentInEachAssociatesDiary(Int32[])`

#### SuperOffice.CRM.Services.SentryAgent is Modified

* New items
  * Method `CanCreateAppointmentInEachAssociatesDiary(Int32[])`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### New Types

* `SuperOffice.Data.ShipmentLinkRedirectKind`

### Modified Types

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ADD_OR_EDIT_PROJECT_MEMBERS`
  * Field `SR_ADD_OR_EDIT_SALE_STAKEHOLDERS`
  * Field `SR_EIS_ADV_SEARCH`
  * Field `SR_EIS_SIMPLE_SEARCH`
  * Field `SR_FORMS_LINK_INCLUDE_VARIABLES`
  * Field `SR_MB_ADD_PHOTO`


### Assembly: SoDatabase

### New Types

* `SuperOffice.Data.SQL.ShipmentLinkRedirectKindFieldInfo`

### Modified Types

#### SuperOffice.CRM.Data.DBC is Modified

* Modified items

##### SuperOffice.CRM.Data.DBC.DocumentFields is Modified

* New items
  * Field `.DocumentFieldsContentSetCount`


##### SuperOffice.CRM.Data.DBC.SLinkFields is Modified

* Deleted items
  * Field `.SLinkFieldsRedirectIsUrl`
* New items
  * Field `.SLinkFieldsFormId`
  * Field `.SLinkFieldsFormParameters`
  * Field `.SLinkFieldsLinkParameters`
  * Field `.SLinkFieldsRedirectKind`


#### SuperOffice.CRM.Data.DocumentTableInfo is Modified

* New items
  * Property `ContentSetCount`

#### SuperOffice.CRM.Data.FormTableInfo is Modified

* New items
  * Property `LeftOuterJoin_SLink_FormId`

#### SuperOffice.CRM.Data.SLinkTableInfo is Modified

* Deleted items
  * Property `RedirectIsUrl`
* New items
  * Property `FormId`
  * Property `FormId_InnerJoin_Form`
  * Property `FormParameters`
  * Property `LinkParameters`
  * Property `RedirectKind`

#### SuperOffice.CRM.Documents.SoArc2Helper is Modified

* Deleted items
  * Method `GetCurrentVersionFolderPath(IDocumentInfo)`
  * Method `GetFullArchivePath(IDocumentInfo)`
* New items
  * Method `GetCurrentVersionFolderPath(IDocumentInfo, String)`
  * Method `GetFullArchivePath(IDocumentInfo, String)`

#### SuperOffice.CRM.Lists.AssociateMDOProviderBase is Modified

* New items
  * Method `GetItemExtraInfo(ListTableRow)`
  * Method `GetPersonImage(Int32)`

#### SuperOffice.CRM.Lists.SpecifiedMailingsListProvider is Modified


#### SuperOffice.CRM.Rows.DocumentRecordData is Modified

* New items
  * Field `ContentSetCount`

#### SuperOffice.CRM.Rows.DocumentRow is Modified

* New items
  * Property `ContentSetCount`
  * Event `OnContentSetCountChange`

#### SuperOffice.CRM.Rows.RowValidator is Modified

* New items
  * Method `ValidateField(ShipmentLinkRedirectKind&, FieldInfo)`

#### SuperOffice.CRM.Rows.SLinkRecordData is Modified

* Deleted items
  * Field `RedirectIsUrl`
* New items
  * Field `FormId`
  * Field `FormParameters`
  * Field `LinkParameters`
  * Field `RedirectKind`

#### SuperOffice.CRM.Rows.SLinkRow is Modified

* Deleted items
  * Property `RedirectIsUrl`
* New items
  * Property `FormId`
  * Property `FormParameters`
  * Property `LinkParameters`
  * Property `RedirectKind`


## Continuous Database

The following represent changes to SuperOffice database schema.

No changes detected.


