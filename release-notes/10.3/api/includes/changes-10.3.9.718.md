---
uid: version_10.3.9.718_changes
date: 9/15/2024
---

Changes from v10.3.8.2017 and v10.3.9.718

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### Modified Types

#### SuperOffice.CRM.Services.AIAgent is Modified

* New items
  * Method `CreateTextForAppointment(AppointmentEntity, String)`

#### SuperOffice.CRM.Services.CRMScriptAgent is Modified

* Deleted items
  * Method `ResolveIncludes(String)`
* New items
  * Method `ResolveIncludes(String, Boolean)`

#### SuperOffice.CRM.Services.IAIAgent is Modified

* New items
  * Method `CreateTextForAppointment(AppointmentEntity, String)`

#### SuperOffice.CRM.Services.ICRMScriptAgent is Modified

* Deleted items
  * Method `ResolveIncludes(String)`
* New items
  * Method `ResolveIncludes(String, Boolean)`

#### SuperOffice.CRM.Services.IWorkflowAgent is Modified

* New items
  * Method `CopyEmailFlow(Int32, String)`

#### SuperOffice.CRM.Services.WorkflowAgent is Modified

* New items
  * Method `CopyEmailFlow(Int32, String)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Data.EventHandlerType is Modified

* New items
  * Field `SalesAfterSaveCustomObject`
  * Field `SalesBeforeSaveCustomObject`

#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `NO_SYSTEM_NOTIFICATIONS`
  * Field `SR_AI_MENU_CASUAL_STYLE`
  * Field `SR_AI_MENU_CREATE_TEXT`
  * Field `SR_AI_MENU_FIX_SPELLING`
  * Field `SR_AI_MENU_FORMAL_STYLE`
  * Field `SR_AI_MENU_LENGTHEN`
  * Field `SR_AI_MENU_REWRITE_TEXT`
  * Field `SR_AI_MENU_SUMMARIZE`
  * Field `SR_AI_MENU_TRANSLATE`
  * Field `SR_ARCHIVE_SHOW`
  * Field `SR_PRINT_LABELS_INFO`
  * Field `SR_PRINT_LABELS_INFO_TEXT`
  * Field `SR_SYSTEM_EVENTS_CONFIRM_DELETE`
  * Field `SR_WORKFLOW_ADDEDTOFLOW`
  * Field `SR_WORKFLOWS_COPY_FLOW`

#### SuperOffice.Util.ThreadedQueueProcessor<T> is Modified

* New items
  * Property `QueueLength`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.LspApiClient.ILspApi`
* `SuperOffice.CRM.LspApiClient.OnsiteLspClient`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.SaleExtenderBase is Modified


#### SuperOffice.CRM.Entities.EntityDetailsHelper<TParent, TChild> is Modified

* New items
  * Method `Edit(TChild)`
  * Event `OnEntityDetailsHelperEdited`

#### SuperOffice.CRM.Entities.LinksHelper is Modified

* New items
  * Method `EditSimilarLink(RelationsRow)`

#### SuperOffice.CRM.Entities.RecurrenceManager is Modified

* New items
  * Method `OnLinksEdited(Appointment, ActivityLinksHelper, AppointmentRow, RelationsRow)`

#### SuperOffice.CRM.Security.EjCategoryCache is Modified

* New items
  * Method `RestrictedCategories(Int32)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_114_FunctionalRights`

### Modified Types

#### SuperOffice.CD.DSL.Database.EventHandlerType is Modified

* New items
  * Field `SalesAfterSaveCustomObject`
  * Field `SalesBeforeSaveCustomObject`



