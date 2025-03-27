---
uid: version_10.5.3.711_changes
date: 27.03.2025
---

Changes from v10.5.2.435 and v10.5.3.711

## Web Services

These changes are observed in both NetServer SOAP and WebAPI (REST) APIs.

### Assembly: SuperOffice.Services

### New Types

* `SuperOffice.CRM.Services.CacheInvalidation`
* `SuperOffice.CRM.Services.UserAndInstallationLicenceStatus`

### Modified Types

#### SuperOffice.CRM.Services.AppointmentInfo is Modified

* New items
  * Property `IsBooking`
  * Property `PersonName`

#### SuperOffice.CRM.Services.DiagnosticsAgent is Modified

* New items
  * Method `GetCacheInvalidationGenerations(String[])`

#### SuperOffice.CRM.Services.IDiagnosticsAgent is Modified

* New items
  * Method `GetCacheInvalidationGenerations(String[])`

#### SuperOffice.CRM.Services.ILicenseAgent is Modified

* New items
  * Method `GetUserAndInstallationLicenceStatus(Int32)`

#### SuperOffice.CRM.Services.LicenseAgent is Modified

* New items
  * Method `GetUserAndInstallationLicenceStatus(Int32)`


## NetServer Core

The following represent changes to assemblies SoCore, SoDatabase, SoLicense and SuperOffice.Plugins.

### Assembly: SoCore

### Modified Types

#### SuperOffice.Configuration.VersionProperties is Modified

* New items
  * Method `GetAllSettings()`

#### SuperOffice.Configuration.VersionPropertyNames is Modified

* New items
  * Field `SampleInCustomCrmScript`

#### SuperOffice.CRM.ArchiveLists.ArchiveRow is Modified

* New items
  * Method `OverwriteColumn(String, ArchiveColumnData)`

#### SuperOffice.CRM.ArchiveLists.Constants is Modified

* Modified items

##### SuperOffice.CRM.ArchiveLists.Constants.ExtraFieldAttrib is Modified

* New items
  * Field `.ExtraFieldAttribEntity`


#### SuperOffice.Globalization.RC is Modified

* New items
  * Field `HEL_Test_HTML`
  * Field `SR_CP_ADD_CUSTOM`
  * Field `SR_CP_COLOR_VALUE`
  * Field `SR_CP_CUSTOM_COLORS`
  * Field `SR_CP_DEFAULT_COLORS`
  * Field `SR_CP_SET_COLOR`
  * Field `SR_EMAIL_EDITOR_CANT_OPEN`
  * Field `SR_NO_ACTIONS_SELECTED`
  * Field `SR_TICKET_ACTION_COLLAPSE_ALL_MESSAGES`
  * Field `SR_TICKET_ACTION_EXPAND_ALL_MESSAGES`

#### SuperOffice.WebApi.PartnerAppRequestInfo is Modified

* New items
  * Property `LogAllRequestsUntil`


### Assembly: SoDatabase

### New Types

* `SuperOffice.CRM.Cache.FavoritesCache`
* `SuperOffice.CRM.Cache.HistoryCache`
* `SuperOffice.Data.Cache.CacheInvalidationOperations`
* `SuperOffice.Data.SQL.HasFlag`

### Modified Types

#### SuperOffice.CRM.ArchiveLists.AppointmentAssociateExtender is Modified

* Deleted items
  * Method `AppointmentAssociateExtender()`
* New items
  * Method `AppointmentAssociateExtender(String)`

#### SuperOffice.CRM.ArchiveLists.AppointmentPublishExtender is Modified

* Deleted items
  * Method `AppointmentPublishExtender()`
* New items
  * Method `AppointmentPublishExtender(String)`

#### SuperOffice.CRM.ArchiveLists.AppointmentVisibleForExtender is Modified

* Deleted items
  * Method `AppointmentVisibleForExtender()`
* New items
  * Method `AppointmentVisibleForExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ConsentSourceExtender is Modified

* Deleted items
  * Method `ConsentSourceExtender()`
* New items
  * Method `ConsentSourceExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactAddressExtenderBase is Modified

* Deleted items
  * Method `ContactAddressExtenderBase()`
* New items
  * Method `ContactAddressExtenderBase(String)`

#### SuperOffice.CRM.ArchiveLists.ContactAnyAddressExtender is Modified

* Deleted items
  * Method `ContactAnyAddressExtender()`

#### SuperOffice.CRM.ArchiveLists.ContactAnyPhoneExtender is Modified

* Deleted items
  * Method `ContactAnyPhoneExtender()`
* New items
  * Method `ContactAnyPhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactAssociateExtender is Modified

* Deleted items
  * Method `ContactAssociateExtender()`
* New items
  * Method `ContactAssociateExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactEmailExtender is Modified

* Deleted items
  * Method `ContactEmailExtender()`
* New items
  * Method `ContactEmailExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactPhoneExtender is Modified

* Deleted items
  * Method `ContactPhoneExtender()`
* New items
  * Method `ContactPhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ContactPhoneExtenderBase is Modified

* Deleted items
  * Method `ContactPhoneExtenderBase(PhoneType)`
* New items
  * Method `ContactPhoneExtenderBase(PhoneType, String)`

#### SuperOffice.CRM.ArchiveLists.ContactPostalAddressExtender is Modified

* Deleted items
  * Method `ContactPostalAddressExtender()`

#### SuperOffice.CRM.ArchiveLists.ContactStreetAddressExtender is Modified

* Deleted items
  * Method `ContactStreetAddressExtender()`

#### SuperOffice.CRM.ArchiveLists.ContactUrlExtender is Modified

* Deleted items
  * Method `ContactUrlExtender()`
* New items
  * Method `ContactUrlExtender(String)`

#### SuperOffice.CRM.ArchiveLists.DynamicTicketExtender is Modified


#### SuperOffice.CRM.ArchiveLists.EmailExtenderBase is Modified

* New items
  * Method `SetEmailAddressColumn(SoDataReader, ArchiveRow, EmailTableInfo, Boolean)`
  * Method `SetHasBounced(SoDataReader, ArchiveRow, EmailTableInfo, Boolean)`

#### SuperOffice.CRM.ArchiveLists.HasConsentExtender is Modified

* Deleted items
  * Method `HasConsentExtender()`
* New items
  * Method `HasConsentExtender(String)`

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentInternalNotesTextExtender is Modified

* Deleted items
  * Method `AppointmentInternalNotesTextExtender()`
* New items
  * Method `AppointmentInternalNotesTextExtender(String)`

#### SuperOffice.CRM.ArchiveLists.Joiners.AppointmentTextConversionExtender is Modified

* Deleted items
  * Method `AppointmentTextConversionExtender()`
* New items
  * Method `AppointmentTextConversionExtender(String)`

#### SuperOffice.CRM.ArchiveLists.LegalBaseExtender is Modified

* Deleted items
  * Method `LegalBaseExtender()`
* New items
  * Method `LegalBaseExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonAddressExtender is Modified

* Deleted items
  * Method `PersonAddressExtender()`
* New items
  * Method `PersonAddressExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonAssociateExtender is Modified

* Deleted items
  * Method `PersonAssociateExtender()`
* New items
  * Method `PersonAssociateExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonDirectFaxExtender is Modified

* Deleted items
  * Method `PersonDirectFaxExtender()`
* New items
  * Method `PersonDirectFaxExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonDirectPhoneExtender is Modified

* Deleted items
  * Method `PersonDirectPhoneExtender()`
* New items
  * Method `PersonDirectPhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonEmailExtender is Modified

* Deleted items
  * Method `PersonEmailExtender()`
* New items
  * Method `PersonEmailExtender(Boolean, String)`
  * Method `InnerModifyQuery()`
  * Method `InnerPopulateRowFromReader(SoDataReader, ArchiveRow)`

#### SuperOffice.CRM.ArchiveLists.PersonInfoTextExtender is Modified

* Deleted items
  * Method `PersonInfoTextExtender()`
* New items
  * Method `PersonInfoTextExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonMobilePhoneExtender is Modified

* Deleted items
  * Method `PersonMobilePhoneExtender()`
* New items
  * Method `PersonMobilePhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonPagerPhoneExtender is Modified

* Deleted items
  * Method `PersonPagerPhoneExtender()`
* New items
  * Method `PersonPagerPhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonPhoneExtenderBase is Modified

* Deleted items
  * Method `PersonPhoneExtenderBase(PhoneType)`
* New items
  * Method `PersonPhoneExtenderBase(PhoneType, String)`

#### SuperOffice.CRM.ArchiveLists.PersonPrivatePhoneExtender is Modified

* Deleted items
  * Method `PersonPrivatePhoneExtender()`
* New items
  * Method `PersonPrivatePhoneExtender(String)`

#### SuperOffice.CRM.ArchiveLists.PersonUrlExtender is Modified

* Deleted items
  * Method `PersonUrlExtender()`
* New items
  * Method `PersonUrlExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectAssociateExtender is Modified

* Deleted items
  * Method `ProjectAssociateExtender()`
* New items
  * Method `ProjectAssociateExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectExternalEventExtender is Modified

* Deleted items
  * Method `ProjectExternalEventExtender()`
* New items
  * Method `ProjectExternalEventExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectProjectMemberExtender is Modified

* Deleted items
  * Method `ProjectProjectMemberExtender(Features)`
* New items
  * Method `ProjectProjectMemberExtender(Features, String)`

#### SuperOffice.CRM.ArchiveLists.ProjectPublishExtender is Modified

* Deleted items
  * Method `ProjectPublishExtender()`
* New items
  * Method `ProjectPublishExtender(String)`

#### SuperOffice.CRM.ArchiveLists.ProjectUrlExtender is Modified

* Deleted items
  * Method `ProjectUrlExtender()`
* New items
  * Method `ProjectUrlExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SaleAssociateExtender is Modified

* Deleted items
  * Method `SaleAssociateExtender()`
* New items
  * Method `SaleAssociateExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SaleVisibleForExtender is Modified

* Deleted items
  * Method `SaleVisibleForExtender()`
* New items
  * Method `SaleVisibleForExtender(String)`

#### SuperOffice.CRM.ArchiveLists.SubscriptionExtender is Modified

* Deleted items
  * Method `SubscriptionExtender()`
* New items
  * Method `SubscriptionExtender(String)`

#### SuperOffice.CRM.ArchiveLists.TicketCreatedByExtender is Modified

* Deleted items
  * Method `TicketCreatedByExtender()`
* New items
  * Method `TicketCreatedByExtender(String)`

#### SuperOffice.CRM.ArchiveLists.TicketExtenderBase is Modified

* New items
  * Property `OwnedBy`

#### SuperOffice.CRM.ArchiveLists.TicketOwnedByExtender is Modified

* Deleted items
  * Method `TicketOwnedByExtender()`
* New items
  * Method `TicketOwnedByExtender(String)`

#### SuperOffice.CRM.Data.SearchCriteriaGroupTableInfo is Modified

* New items
  * Method `IdxSearchCriteriaId(Int32)`

#### SuperOffice.CRM.Entities.EntityCustomFieldsHelper is Modified

* Deleted items
  * Method `GetExtraInfo(String)`

#### SuperOffice.CRM.Entities.EntityExtraFieldsHelper is Modified

* Modified items
  * Method `GetExtraInfo(String)`
  * Method `GetExtraInfo(String, TableInfo, Object)`

#### SuperOffice.CRM.Globalization.FadTags is Modified


#### SuperOffice.CRM.Globalization.TemplateVariables is Modified

* New items
  * Method `SetCurrentPerson()`

#### SuperOffice.CRM.Lists.LiteralsOnlyBase is Modified

* New items
  * Property `HistoryIds`
  * Property `OnlyReadHistory`

#### SuperOffice.CRM.Lists.TicketTypeProvider is Modified

* Deleted items
  * Field `Admin`
* New items
  * Field `IgnoreGroupingAndHeadingsForAdmin`

#### SuperOffice.CRM.Rows.SearchCriteriaGroupRows is Modified

* New items
  * Method `GetFromIdxSearchCriteriaId(Int32)`
  * Method `GetFromIdxSearchCriteriaIdRank(Int32, Int16)`

##### SuperOffice.CRM.Rows.SearchCriteriaGroupRows.IdxSearchCriteriaId is New

##### SuperOffice.CRM.Rows.SearchCriteriaGroupRows.IdxSearchCriteriaIdRank is New

#### SuperOffice.CRM.Rows.SearchCriterionRows is Modified

* New items
  * Method `GetFromIdxColumnName(String)`
  * Method `GetFromIdxSearchCriteriaGroupId(Int32)`

##### SuperOffice.CRM.Rows.SearchCriterionRows.IdxColumnName is New

##### SuperOffice.CRM.Rows.SearchCriterionRows.IdxSearchCriteriaGroupId is New

#### SuperOffice.CRM.Rows.SearchCriterionValueRows is Modified

* New items
  * Method `GetFromIdxSearchCriterionId(Int32)`

##### SuperOffice.CRM.Rows.SearchCriterionValueRows.IdxSearchCriterionId is New

#### SuperOffice.CRM.Security.VisibleForSentryHelper is Modified

* New items
  * Method `AddVisibleForGroupsRestriction(Int32[], Or&, Int32ArrayFieldInfo)`

#### SuperOffice.Data.Dialect.Dialect is Modified

* New items
  * Method `ToSql(HasFlag)`

#### SuperOffice.Data.SoCommand is Modified

* Modified items
  * Method `ExecuteReader(CommandBehavior, Int32, Int32)`

#### SuperOffice.Data.SQL.Argument is Modified

* New items
  * Method `HasFlag(Argument)`


## Continuous Database

The following represent changes to SuperOffice database schema.

### Assembly: SuperOffice.CD.DSL.Database

### New Types

* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_117_Expanded_Messages`
* `SuperOffice.CD.DSL.Database.Steps_SuperOffice.SuperOffice_118_SearchCritIndexes`
