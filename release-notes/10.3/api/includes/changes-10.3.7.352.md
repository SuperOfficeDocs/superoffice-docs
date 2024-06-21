---
uid: version_10.3.7.352_changes
date: 5/31/2024
---

Changes from v10.3.6.552 and v10.3.7.352

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `SetStatusOnWorkflow(Int32, WorkflowDefinitionStatus)`

#### SuperOffice.CRM.Services.PersonEntity is Modified

* New items
  * Property `CreatedByFormId`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `SetStatusOnWorkflow(Int32, WorkflowDefinitionStatus)`

#### SuperOffice.CRM.Services.WorkflowStepNotifyByEmail is Modified

* New items
  * Property `ShipmentId`

#### SuperOffice.CRM.Services.WorkflowStepNotifyBySMS is Modified

* New items
  * Property `From`
  * Property `ShipmentId`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Configuration.ConfigFile is Modified

* Modified items

##### SuperOffice.Configuration.ConfigFile.Client is Modified

* New items
  * Property `.ClientSynchronizerSettingsUrl`


##### SuperOffice.Configuration.ConfigFile.ClientSection is Modified

* New items
  * Property `.ClientSectionSynchronizerSettingsUrl`


#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `SR_ARCHIVE_UPDATED_BY_FLOW_WHEN`
  * Field `SR_BULKUPDATE_JOBCONFIRMATIONDIALOG_MESSAGE_CUSTOMOBJECTS`
  * Field `SR_BULKUPDATE_QUEUECOUNT_CUSTOMOBJECTS`
  * Field `SR_BULKUPDATE_RESULTSINFO_BASE_CUSTOMOBJECTS`
  * Field `SR_CONFIGSCREEN_FROM_ARCHIVE_TO_COLUMNS`
  * Field `SR_CONFIGSCREEN_FROM_COLUMNS_TO_ARCHIVE`
  * Field `SR_MB_CREATE_SELECTION`
  * Field `SR_SYNCHRONIZER_SETTINGS`
  * Field `SR_WORKFLOW_ERROR_NOCONTACTINFO`
  * Field `SR_WORKFLOW_ERROR_NOEMAILTEXT`
  * Field `SR_WORKFLOW_ERROR_NOFROM`
  * Field `SR_WORKFLOW_ERROR_NONAMEEMAIL`
  * Field `SR_WORKFLOW_ERROR_NONAMEPHONE`
  * Field `SR_WORKFLOW_ERROR_NOSETTINGS`
  * Field `SR_WORKFLOW_ERROR_NOSPECIFICEMAILADDRESSES`
  * Field `SR_WORKFLOW_ERROR_NOSPECIFICPHONENUMBERS`
  * Field `SR_WORKFLOW_ERROR_NOSUBJECT`
  * Field `SR_WORKFLOW_ERROR_NOTEXT`
  * Field `SR_WORKFLOW_ERROR_NOVALIDFROM`
  * Field `SR_WORKFLOW_ERROR_NOVALIDSETTINGS`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Lists.CustomObjectListProvider`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentTextConversionExtender is Modified

* New items
  * Method `GetTexts(SoDataReader)`
  * Method `IsConverted(SoDataReader, String&, String&)`

#### SuperOffice.CRM.Cache.ExtraFieldsCache is Modified

* New items
  * Method `GetAllExtraTables()`

#### SuperOffice.CRM.Workflow.NotifyByEmailSettings is Modified

* New items
  * Property `ShipmentId`

#### SuperOffice.CRM.Workflow.NotifyBySMSSettings is Modified

* New items
  * Property `From`
  * Property `ShipmentId`

#### SuperOffice.CRM.Workflow.WorkflowStepNotifyByEmail is Modified

* New items
  * Method `Execute()`

#### SuperOffice.CRM.Workflow.WorkflowStepNotifyBySMS is Modified

* Modified items
  * Method `GetSettings(String)`
* New items
  * Method `Execute()`

#### SuperOffice.Security.Principal.AssociateResolver is Modified

* New items
  * Method `SecretFromPassword(Int32, String, String)`


### Assembly: SoLicense

### Modified Types

#### SuperOffice.License.LicenseInfoHelper is Modified

* New items
  * Method `SaveLicenseAsImportFile(LicenseInfo, StringWriter, String)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.DocTemplateResourceReader`
* `SuperOffice.CD.DSL.Database.IDocTemplateResourceReader`


