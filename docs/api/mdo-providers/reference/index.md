---
uid: mdo-provider-listing
title: MDO List Provider names
description: Valid list of provider names
so.generated: true
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# MDO List Providers

## List of MDO table names

|Provider Name|Implemented by Class|
| ---------- | ----------- |
| [AmountClass](AmountClass.md) |MDO List stored in the database. Table id 225|
| [associate](associate.md) |MDO List stored in the database. Table id 2|
| [Business](Business.md) |MDO List stored in the database. Table id 61|
| [Category](Category.md) |MDO List stored in the database. Table id 64|
| [Comptr](Comptr.md) |MDO List stored in the database. Table id 109|
| [ContInt](ContInt.md) |MDO List stored in the database. Table id 70|
| [country](country.md) |MDO List stored in the database. Table id 19|
| [Credited](Credited.md) |MDO List stored in the database. Table id 97|
| [Currency](Currency.md) |MDO List stored in the database. Table id 112|
| [DeliveryTerms](DeliveryTerms.md) |MDO List stored in the database. Table id 433|
| [DeliveryType](DeliveryType.md) |MDO List stored in the database. Table id 436|
| [DocTmpl](DocTmpl.md) |MDO List stored in the database. Table id 130|
| [ExtApp](ExtApp.md) |MDO List stored in the database. Table id 133|
| [Intent](Intent.md) |MDO List stored in the database. Table id 216|
| [MrMrs](MrMrs.md) |MDO List stored in the database. Table id 94|
| [PaymentTerms](PaymentTerms.md) |MDO List stored in the database. Table id 427|
| [PaymentType](PaymentType.md) |MDO List stored in the database. Table id 430|
| [PersInt](PersInt.md) |MDO List stored in the database. Table id 73|
| [PersPos](PersPos.md) |MDO List stored in the database. Table id 76|
| [PMembType](PMembType.md) |MDO List stored in the database. Table id 91|
| [PriceUnit](PriceUnit.md) |MDO List stored in the database. Table id 439|
| [Priority](Priority.md) |MDO List stored in the database. Table id 79|
| [Prob](Prob.md) |MDO List stored in the database. Table id 82|
| [ProductCategory](ProductCategory.md) |MDO List stored in the database. Table id 408|
| [ProductFamily](ProductFamily.md) |MDO List stored in the database. Table id 411|
| [ProductType](ProductType.md) |MDO List stored in the database. Table id 414|
| [ProjStatus](ProjStatus.md) |MDO List stored in the database. Table id 88|
| [ProjType](ProjType.md) |MDO List stored in the database. Table id 85|
| [Reason](Reason.md) |MDO List stored in the database. Table id 103|
| [ReasonSold](ReasonSold.md) |MDO List stored in the database. Table id 115|
| [ReasonStalled](ReasonStalled.md) |MDO List stored in the database. Table id 154|
| [RejectReason](RejectReason.md) |MDO List stored in the database. Table id 222|
| [relationdefinition](relationdefinition.md) |MDO List stored in the database. Table id 48|
| [SaleType](SaleType.md) |MDO List stored in the database. Table id 149|
| [SaleTypeCat](SaleTypeCat.md) |MDO List stored in the database. Table id 118|
| [Salutation](Salutation.md) |MDO List stored in the database. Table id 219|
| [SearchCat](SearchCat.md) |MDO List stored in the database. Table id 106|
| [Source](Source.md) |MDO List stored in the database. Table id 100|
| [StakeholderRole](StakeholderRole.md) |MDO List stored in the database. Table id 122|
| [SubscriptionUnit](SubscriptionUnit.md) |MDO List stored in the database. Table id 442|
| [Tags](Tags.md) |MDO List stored in the database. Table id 459|
| [Task](Task.md) |MDO List stored in the database. Table id 67|
| [UDList](UDList.md) |MDO List stored in the database. Table id 136|

## List of other valid MDO providers

|Provider Name|Implemented by Class|
| ---------- | ----------- |
| [activitystatus](activitystatus.md) |MDO provider for the ActivityStatus enum: NotStarted, Started, Completed|
| [addressformat](addressformat.md) |MDO list provider for AddressFormats Id returned is the layout_id, not the addressformat_id.|
| [allpersonsearch](allpersonsearch.md) |Provider for selecting a Person, including search on contacts that match as well as persons. this provider wil|
| [allpreferencekeys](allpreferencekeys.md) |MDO Provider that retrieves all preference keys|
| [amountclass](amountclass.md) |GenericMDOProvider reads MDO lists with default settings|
| [appointment](appointment.md) ||
| [appointmentcautionwarning](appointmentcautionwarning.md) |Appointment.CautionWarning. Appointment and invitation synchronization info|
| [appointmentcompleted](appointmentcompleted.md) |Appointment completed statuses: AppointmentStatus.NotStarted, AppointmentStatus.Completed|
| [appointmentfavourite](appointmentfavourite.md) |MDO list provider for Favourites|
| [appointmentgroup](appointmentgroup.md) |Appointment grouping types: TaskType.Appointment, Phone, ToDo|
| [appointmenttask](appointmenttask.md) |MDO list provider for the task list of the AppointmentDialog. This list extends the basic <see cref="T:SuperOffice.CRM.Rows.TaskRow" /> wit|
| [appointmenttextid](appointmenttextid.md) |Special case of appointment list where we get the id value from the Text table. For use when we wan|
| [appointmenttype](appointmenttype.md) |List of AppointmentType values: inDiary, inChecklist, Note, Document, SavedReport, BookingForDiary, BookingForChecklist|
| [area](area.md) |List of all defined areas.|
| [associaterestrictions](associaterestrictions.md) |Public MDO provider based on the AssociateRestrictionsMDOProviderBase.|
| [associatewithmail](associatewithmail.md) ||
| [attachment](attachment.md) ||
| [availablereports](availablereports.md) |AvailableReportsProvider creates an MDO list containing the available reports|
| [business](business.md) |GenericMDOProvider reads MDO lists with default settings|
| [category](category.md) |GenericMDOProvider reads MDO lists with default settings|
| [chatbot](chatbot.md) |List of all script folders that contain a script named like "%bot%register%"|
| [chatchannel](chatchannel.md) ||
| [chatservice](chatservice.md) ||
| [chatuser](chatuser.md) ||
| [colorindex](colorindex.md) |List of named colors from the "ColorIndex" enum|
| [combinedcontactpersonsearch](combinedcontactpersonsearch.md) |Provider for selecting a Person or a Contact, including search on contacts that match as well as persons. this provider wil|
| [comptr](comptr.md) |GenericMDOProvider reads MDO lists with default settings|
| [consentpurpose](consentpurpose.md) |MDO list provider for ConsentPurpose|
| [consentsource](consentsource.md) |MDO list provider for Consent source|
| [contact](contact.md) |Provider for selecting a Contact - without person search|
| [contactfavourite](contactfavourite.md) |MDO list provider for Favourites|
| [contactperson_freetextsearch](contactperson_freetextsearch.md) |Provider for selecting a Contact - with person search|
| [contactphone](contactphone.md) ||
| [contactrelationdefinition](contactrelationdefinition.md) |MDO list provider for contact/person relation definitions. This provider is a takes a mandator|
| [contactwithpersonsearch](contactwithpersonsearch.md) |Provider for selecting a Contact, including search on persons that match as well as contacts. this provider wil|
| [contactwithpersonsearch_new](contactwithpersonsearch_new.md) |Provider for selecting a Contact, including search on persons that match as well as contacts. this provider wil|
| [contact_freetextsearch](contact_freetextsearch.md) |Provider for selecting a Contact - without person search|
| [contact_new](contact_new.md) |Provider for selecting a Contact - without person search|
| [contint](contint.md) |GenericMDOProvider reads MDO lists with default settings|
| [createdocumenttemplateplugin](createdocumenttemplateplugin.md) |List of document plugins that can create document templates.|
| [credentialgroup](credentialgroup.md) |List of user groups supported by a named creditial plugin, sorted by group name.|
| [credited](credited.md) |GenericMDOProvider reads MDO lists with default settings|
| [crmscript](crmscript.md) |Archive of CRMScripts. Returns script id + name of script as hierarchy.|
| [culture](culture.md) ||
| [culturesolanguage](culturesolanguage.md) |List of SuperOffice cultures with old-style SO Culture name in ExtraInfo|
| [currency](currency.md) |GenericMDOProvider reads MDO lists with default settings|
| [currentudeffields](currentudeffields.md) |Get a list of udef fields for a given type. Pass the type as AdditionalInfo|
| [customerlanguage](customerlanguage.md) |Customer Languages list. From the CustLang table.|
| [dashboardtile](dashboardtile.md) |MDO list provider for Dashboard tile|
| [dashboardtileentitytype](dashboardtileentitytype.md) |List of dashboard tile types: Company, Project, Sale, Product, Activity, Web Panel|
| [dayofmonth](dayofmonth.md) |MDO provider for the hard-coded list of day alternatives in the recurrence dialog.|
| [deliveryterms](deliveryterms.md) |GenericMDOProvider reads MDO lists with default settings|
| [deliverytype](deliverytype.md) |GenericMDOProvider reads MDO lists with default settings|
| [diaryowner](diaryowner.md) |List provider that returns diary owners, i.e., our own employees plus resources|
| [direction](direction.md) |Document and Task directions: TaskDirection.Incoming, Outgoing|
| [disconnectpersonactions](disconnectpersonactions.md) |List of actions to perform when disconnecting a contact from a company|
| [doctmpl](doctmpl.md) |GenericMDOProvider reads MDO lists with default settings|
| [document](document.md) |MDO list provider for documents.|
| [documentcompleted](documentcompleted.md) |Document completed status list: Not done, Done.|
| [documentfavourite](documentfavourite.md) |MDO list provider for Favourites|
| [documentgroup](documentgroup.md) |Document types: TaskType.Document, Email, Fax, Merge draft, Merge Final.|
| [documentmailing](documentmailing.md) |Document shipments (mail merges).|
| [documentmailingtemplate](documentmailingtemplate.md) |Document mailing templates|
| [documenttemplatelanguage](documenttemplatelanguage.md) ||
| [documenttemplatesfiltered](documenttemplatesfiltered.md) |MDO Provider for Document Templates, excluding Document details and quote mail templates, which are for system use rather than end-user choosing.|
| [documenttypes](documenttypes.md) |List of document types for the given plugin|
| [ejcategory](ejcategory.md) |EjCategoryProvider creates a flat or tree list based on the table: EJ_CATEGORY|
| [ejuser](ejuser.md) ||
| [emailaddress](emailaddress.md) |List of e-mail addresses matching the search valu|
| [emailfolder](emailfolder.md) |EmailFolderProvider gives you the folder hierarchy of a given mail account|
| [emailrecipient](emailrecipient.md) |List of most recent e-mail recipients cached for the current user.|
| [erpconnections](erpconnections.md) |Retrieve the list of all defined Erp Connections (not Connectors, that's another list)|
| [erpconnectors](erpconnectors.md) |Retrieve the list of all defined Erp Connectors (not Connections, that's another list)|
| [erpdeliveryterms](erpdeliveryterms.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erpdeliverytype](erpdeliverytype.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erppaymentterms](erppaymentterms.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erppaymenttype](erppaymenttype.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erpproductcategory](erpproductcategory.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erpproductfamily](erpproductfamily.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [erpproducttype](erpproducttype.md) |Dynamic provider that dispatches Quote Connector lists, based on QuoteAlternativeId or SaleId and "Erp"+&lt;list name&gt;|
| [eventhandlertype](eventhandlertype.md) |Screen trigger event types: members of <see cref="T:SuperOffice.Data.EventHandlerType" /> enum.|
| [everymonth](everymonth.md) |MDO provider for the hard-coded list of day month in the recurrence dialog.|
| [executeonevent](executeonevent.md) |List of windows client events to execute tasks on: Logon, Logoff, LocalUpdate|
| [exporttemplate](exporttemplate.md) ||
| [extapp](extapp.md) |GenericMDOProvider reads MDO lists with default settings|
| [faqcategory](faqcategory.md) ||
| [faqreplytemplate](faqreplytemplate.md) ||
| [faqreplytemplatefavourite](faqreplytemplatefavourite.md) |MDO list provider for Favourites|
| [favouritetype](favouritetype.md) |MDO list provider for Favourite types|
| [filterassociates](filterassociates.md) |Associate list for the Filter dialog. This associate list differs from the standard list in two ways|
| [filterfuturedate](filterfuturedate.md) |MDO provider for the hard-coded list of future date alternatives in the Filter dialog|
| [filtergroups](filtergroups.md) |User groups, filtered according to the usergroups selected in the filter dialog.|
| [findproduct](findproduct.md) |QuickSearch for the Add Quote Line dialog, where a single-line user input is passed to th|
| [fontsize](fontsize.md) |List of font types|
| [fonttype](fonttype.md) |List of font types|
| [form](form.md) |Get all forms with folder hierarchy. Set ExtraInfo to "onlyActive" if you only want to get active forms|
| [formfolder](formfolder.md) |EjCategoryProvider creates a flat or tree list based on the table: EJ_CATEGORY|
| [formmailings](formmailings.md) ||
| [formsubmissionstatusprovider](formsubmissionstatusprovider.md) ||
| [freetextsearchentity](freetextsearchentity.md) |List provider that returns the entities supported by free text search. The extraInfo field contains th|
| [functionrights](functionrights.md) |FunctionRightsListProvider returns a MDO list of function rights in the database|
| [genericperson](genericperson.md) |List of persons with mail. Supports Selection(any type), project and associate|
| [genericpersonwithmail](genericpersonwithmail.md) |List of persons with mail. Supports Selection(any type), project and associate|
| [groupview](groupview.md) |GroupViewMDOProvider uses the AssociateMDOProvider + DiaryView to create the MDOlist for Groupview in Diary view.|
| [heading](heading.md) |List provider for the Heading table. While this table looks like an MDO table|
| [hierarchy](hierarchy.md) |List provider for the Hierarchy table. Pass the domain using Additional info|
| [htmlmailing](htmlmailing.md) |MDO provider for the different types of Mailings|
| [htmlmailingtemplate](htmlmailingtemplate.md) |MDO provider for the different types of Mailing templates|
| [importblankaction](importblankaction.md) |Import actions for blank values: Use Person Name, Skip|
| [importcontactduplicatematch](importcontactduplicatematch.md) |List of fields to match contact imports.|
| [importduplicateaction](importduplicateaction.md) |Import Duplicate actions: Add, Merge, Replace, Skip|
| [importduplicateactionwithoutadd](importduplicateactionwithoutadd.md) |Import duplicate; Merge, Replace, Skip|
| [importfields](importfields.md) |MDO provider for column headers used in import|
| [importnewlistitem](importnewlistitem.md) |Import list items: Add item, use default, use blank|
| [importnewpositionitem](importnewpositionitem.md) |Import position items: Add to list, set to blank|
| [importnewproductlistitem](importnewproductlistitem.md) |Import product list items: add, use blank|
| [importpersonduplicatematch](importpersonduplicatematch.md) |Import Person Fields to match on: Name, E-mail, phone, number, id, None|
| [importphoneurlsemail](importphoneurlsemail.md) |Import phone/url/email values: Add, Replace, Skip|
| [importproductduplicatematch](importproductduplicatematch.md) |Import product detect duplicates based on field:  Name, Code, Name+Code|
| [importproductfields](importproductfields.md) |MDO provider for column headers used in import|
| [intent](intent.md) |GenericMDOProvider reads MDO lists with default settings|
| [iso639language](iso639language.md) ||
| [kbentry](kbentry.md) ||
| [language](language.md) ||
| [legalbase](legalbase.md) |MDO list provider for Legal base|
| [lists](lists.md) |List of all MDO list providers.|
| [locatecontact](locatecontact.md) |Provider for selecting a Contact, including search on persons that match as well as contacts. this provider wil|
| [locatecontact_new](locatecontact_new.md) |Provider for selecting a Contact, including search on persons that match as well as contacts. this provider wil|
| [locateperson](locateperson.md) |Person list with contact name.|
| [location](location.md) |Implements the mdo provider for the list of avaiable locations. This list aggregates element|
| [mailhtmltemplate](mailhtmltemplate.md) |List provider for the Mailtemplates.|
| [mailing](mailing.md) |All mailings - history ids|
| [mailingfavourite](mailingfavourite.md) |MDO list provider for Favourites|
| [mailingtemplate](mailingtemplate.md) |General mailing templates|
| [mailingtype](mailingtype.md) |Mailing types: Html mail, SMS, Word Document|
| [mailtemplate](mailtemplate.md) |List provider for the Mailtemplates.|
| [mergedocument](mergedocument.md) |MDO list provider for documents marked as type <see cref="F:SuperOffice.Data.TaskType.MailMergeDraft" />.|
| [mergetags](mergetags.md) ||
| [month](month.md) |MDO provider for the hard-coded list of "of" months in the recurrence dialog.|
| [mrmrs](mrmrs.md) |GenericMDOProvider reads MDO lists with default settings|
| [nextavailabletime](nextavailabletime.md) ||
| [ofmonth](ofmonth.md) |MDO provider for the hard-coded list of "of" months in the recurrence dialog.|
| [ownercontact](ownercontact.md) |MDO provider for listing owner contacts.|
| [paymentterms](paymentterms.md) |GenericMDOProvider reads MDO lists with default settings|
| [paymenttype](paymenttype.md) |GenericMDOProvider reads MDO lists with default settings|
| [period](period.md) |Period values: Day, Week, Month, Quarter, Year|
| [periods](periods.md) |Period values: Day, Week, Month, Quarter, Year|
| [persint](persint.md) |GenericMDOProvider reads MDO lists with default settings|
| [person](person.md) |List of persons from the Archive provider|
| [personcontactfavourite](personcontactfavourite.md) |MDO list provider for Favourites|
| [personcontact_freetextsearch](personcontact_freetextsearch.md) |Provider for selecting a Person - with contact search|
| [personemailaddress](personemailaddress.md) |List of e-mail addresses matching the search value, possibly restricted to a given company or person.|
| [personfavourite](personfavourite.md) |MDO list provider for Favourites|
| [personphone](personphone.md) |Search phone numbers for matching values, restricted to a given company or person.|
| [personrestrictions](personrestrictions.md) |Implements a person mdolist provider that uses the conflicts detector to append information o|
| [personurl](personurl.md) |List of urls (web pages) matching the search value, possibly restricted to a given company or person.|
| [personwithmail](personwithmail.md) |List of persons fetched based on provided criteri|
| [person_freetextsearch](person_freetextsearch.md) |Provider for selecting a Person - without contact search|
| [perspos](perspos.md) |GenericMDOProvider reads MDO lists with default settings|
| [phonesearch](phonesearch.md) |Search phone numbers for matching stripped numbers, across person and contacts|
| [plugin](plugin.md) |List of installed and available Document plugins|
| [pmembtype](pmembtype.md) |GenericMDOProvider reads MDO lists with default settings|
| [prefdescline](prefdescline.md) |PrefDesc creates a MDO list of prefdesclines for a given prefdesc id.|
| [preferencekey](preferencekey.md) |MDO Provider that retrieves a list of preference keys corresponding to a given section|
| [preferencelineitem](preferencelineitem.md) ||
| [preferencesearch](preferencesearch.md) |MDO Provider that retrieves a list of preference keys corresponding to a given keyword.|
| [preferencesection](preferencesection.md) |MDO Provider that retrieves a list of preference sections|
| [pricelist](pricelist.md) |List of pricelists from the PriceList table|
| [priceunit](priceunit.md) |GenericMDOProvider reads MDO lists with default settings|
| [priority](priority.md) |GenericMDOProvider reads MDO lists with default settings|
| [privacytemplate](privacytemplate.md) |This is a variant of the DocTmpl list - document templates - restricted to those that are of some privacy document type.|
| [prob](prob.md) |GenericMDOProvider reads MDO lists with default settings|
| [productcategory](productcategory.md) |GenericMDOProvider reads MDO lists with default settings|
| [productfamily](productfamily.md) |GenericMDOProvider reads MDO lists with default settings|
| [productimage](productimage.md) |Return product images from the blob table|
| [producttype](producttype.md) |GenericMDOProvider reads MDO lists with default settings|
| [project](project.md) |Provider for selecting a project.|
| [projectassociate](projectassociate.md) |MDO provider for associates that are members of a project|
| [projectfavourite](projectfavourite.md) |MDO list provider for Favourites|
| [projectimage](projectimage.md) |Project images from the blob table|
| [projectmemberwithmail](projectmemberwithmail.md) ||
| [projectstatus](projectstatus.md) |List of project guide steps status values.|
| [projecttype](projecttype.md) |Project type list. Encodes Default project duration in extra info.|
| [projecttypeflatlist](projecttypeflatlist.md) |Project type list. Encodes Default project duration in extra info.|
| [project_freetextsearch](project_freetextsearch.md) |Provider for selecting a Project|
| [project_new](project_new.md) |Provider for selecting a project. Returns search results in rank orde|
| [projstatus](projstatus.md) |GenericMDOProvider reads MDO lists with default settings|
| [projtype](projtype.md) |GenericMDOProvider reads MDO lists with default settings|
| [quotealternatives](quotealternatives.md) |Quote alternative selector for one Quote Version. Send QuoteVersionId=&lt;id&gt; in ExtraInfo to specify quote version id|
| [quoteapprovalassociate](quoteapprovalassociate.md) |MDO provider for associates that are allowed to approve a quote.|
| [quoteapprovers](quoteapprovers.md) |Retrieve the list of all users that can approve quotes|
| [quoteconnections](quoteconnections.md) |Retrieve the list of all defined Quote Connections - i.e. not the connectors (DLLs)|
| [quoteconnectors](quoteconnectors.md) |Retrieve the list of all installed (i.e., loaded assemblies) Quote Connectors|
| [quotedocumentgroupfields](quotedocumentgroupfields.md) |Possible choices for fields that you can GROUP BY in quote detail documents.|
| [quotedocumentorderbyfields](quotedocumentorderbyfields.md) |Possible choices for fields you can ORDER BY, within a group (or without grouping)|
| [quotedocuments](quotedocuments.md) ||
| [quotedocumenttype](quotedocumenttype.md) |List of quote document types - assumes ExtraInfo is the name of RecordType enum value|
| [quotelinestatus](quotelinestatus.md) |Hard-coded list of values for the QuoteLine.Status field, see <see cref="T:SuperOffice.Data.QuoteStatus" /> enum.|
| [quotetemplate](quotetemplate.md) |This is a variant of the DocTmpl list - document templates - restricted to those that are of some quote document type|
| [quoteversion](quoteversion.md) |Quote version selector for one Quote. Send QuoteId=&lt;id&gt; in ExtraInfo to specify quote id|
| [quoteversionstate](quoteversionstate.md) |List provider for the <see cref="T:SuperOffice.Data.QuoteVersionState" /> enum|
| [reason](reason.md) |GenericMDOProvider reads MDO lists with default settings|
| [reasonsold](reasonsold.md) |GenericMDOProvider reads MDO lists with default settings|
| [reasonstalled](reasonstalled.md) |GenericMDOProvider reads MDO lists with default settings|
| [recordtype](recordtype.md) |A complete and generic mapping of record types to resource strings|
| [recurrenceweekcycle](recurrenceweekcycle.md) |MDO provider for the hard-coded list of week cycle alternatives in the recurrence dialog.|
| [rejectreason](rejectreason.md) |GenericMDOProvider reads MDO lists with default settings|
| [relationssearchlistproviderappointmentactive](relationssearchlistproviderappointmentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentappointmentactive](relationssearchlistproviderappointmentappointmentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentappointmentpassive](relationssearchlistproviderappointmentappointmentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentdocumentactive](relationssearchlistproviderappointmentdocumentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentdocumentpassive](relationssearchlistproviderappointmentdocumentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentpassive](relationssearchlistproviderappointmentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentsaleactive](relationssearchlistproviderappointmentsaleactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderappointmentsalepassive](relationssearchlistproviderappointmentsalepassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactactive](relationssearchlistprovidercontactactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactcontactactive](relationssearchlistprovidercontactcontactactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactcontactpassive](relationssearchlistprovidercontactcontactpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactpassive](relationssearchlistprovidercontactpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactpersonactive](relationssearchlistprovidercontactpersonactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidercontactpersonpassive](relationssearchlistprovidercontactpersonpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentactive](relationssearchlistproviderdocumentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentappointmentactive](relationssearchlistproviderdocumentappointmentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentappointmentpassive](relationssearchlistproviderdocumentappointmentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentdocumentactive](relationssearchlistproviderdocumentdocumentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentdocumentpassive](relationssearchlistproviderdocumentdocumentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentpassive](relationssearchlistproviderdocumentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentsaleactive](relationssearchlistproviderdocumentsaleactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderdocumentsalepassive](relationssearchlistproviderdocumentsalepassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersonactive](relationssearchlistproviderpersonactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersoncontactactive](relationssearchlistproviderpersoncontactactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersoncontactpassive](relationssearchlistproviderpersoncontactpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersonpassive](relationssearchlistproviderpersonpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersonpersonactive](relationssearchlistproviderpersonpersonactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistproviderpersonpersonpassive](relationssearchlistproviderpersonpersonpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersaleactive](relationssearchlistprovidersaleactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersaleappointmentactive](relationssearchlistprovidersaleappointmentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersaleappointmentpassive](relationssearchlistprovidersaleappointmentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersaledocumentactive](relationssearchlistprovidersaledocumentactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersaledocumentpassive](relationssearchlistprovidersaledocumentpassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersalepassive](relationssearchlistprovidersalepassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersalesaleactive](relationssearchlistprovidersalesaleactive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [relationssearchlistprovidersalesalepassive](relationssearchlistprovidersalesalepassive.md) |Serve the active and passive texts of relations, with a given table as source (active|
| [reportcategory](reportcategory.md) |ReportCategoryProvider creates an MDO list that consists of the values in <see cref="T:SuperOffice.Data.ReportCategory" />|
| [reportlayout](reportlayout.md) |ReportCategoryProvider creates an MDO list that consists of the values in <see cref="T:SuperOffice.Data.ReportCategory" />|
| [resource](resource.md) |MDO provider for resources (from the associate table)|
| [resourcerestrictions](resourcerestrictions.md) |MDO provider for resources (from the associate table) that uses restrictions to includ|
| [restrictionoperators](restrictionoperators.md) |This SoList provider will generate the operator list for a given search criterion data type. The data type i|
| [roles](roles.md) |RoleListProvider creates a MDO list of roles in the database|
| [saintactivitytype](saintactivitytype.md) |This SoList provider generates the appointment/task type list for the Saint criteria. This is a simple, hard-coded list correspondin|
| [saintamountclass](saintamountclass.md) |This SoList provider generates the amount class list for the Saint criteria. This list is an extension of the basi|
| [saintdirection](saintdirection.md) |This SoList provider generates the appointment/task direction list for the Saint criteria. This is a simple, hard-coded list correspondin|
| [saintintention](saintintention.md) |This SoList provider generates the Intent list for the Saint criteria. This list is an extension of the basi|
| [saintsalestatus](saintsalestatus.md) |This SoList provider generates the sale status list for the Saint criteria. This is a simple, hard-coded list correspondin|
| [saintticketcategory](saintticketcategory.md) |This SoList provider generates the eJournal top-level categories, meant for the saint system|
| [saintticketstatus](saintticketstatus.md) |This SoList provider generates the ticket status list for the Saint criteria. This is a simple, hard-coded list, special for this context|
| [sale](sale.md) |List of sales|
| [saledone](saledone.md) |Sale Done status: SaleDone.Done or NotDone.|
| [salefavourite](salefavourite.md) |MDO list provider for Favourites|
| [saleguidestage](saleguidestage.md) |MDO provider for the stage list, customized for the sale guide stage button row|
| [saleprobability](saleprobability.md) |MDO list provider for the probability list of the Sale dialog. This list extends the basic <see cref="!:ProbRow" /> list with a leadin|
| [salesource](salesource.md) |MDO list provider for the source list of the Sale dialog|
| [salestage](salestage.md) |Provider for selecting a stage. AdditionalInfo is used as criteria to filter stages based on SaleType.|
| [salestatus](salestatus.md) |List for the Sale.Status field: Open, Lost, Sold, Stalled.|
| [saletype](saletype.md) |List of sale types, with default sale duration in minutes in extra info.|
| [saletypecat](saletypecat.md) |GenericMDOProvider reads MDO lists with default settings|
| [saletypecategories](saletypecategories.md) |SaleTypeCategories creates a MDO list of sale type categories in the database.|
| [sale_freetextsearch](sale_freetextsearch.md) |Provider for selecting a Sale|
| [sale_new](sale_new.md) |List of sales|
| [salutation](salutation.md) |GenericMDOProvider reads MDO lists with default settings|
| [satellites](satellites.md) |SatelliteProvider creates a MDO list of satellites.|
| [searchcat](searchcat.md) |GenericMDOProvider reads MDO lists with default settings|
| [selection](selection.md) |Provider for selecting a selection|
| [selectionfavourite](selectionfavourite.md) |MDO list provider for Favourites|
| [selectionmembertype](selectionmembertype.md) |MDO provider for the selection archive providers types|
| [selectionmembertypeclean](selectionmembertypeclean.md) ||
| [selectionmembertypev2](selectionmembertypev2.md) |MDO provider for the selection archive providers types|
| [selectionmemberwithmail](selectionmemberwithmail.md) |List of selection members fetched based on provided criteri|
| [selectiontype](selectiontype.md) |MDO provider for the hard-coded list of selection kinds: Static, Dynamic, Combined|
| [selectionuniontype](selectionuniontype.md) |Different ways to combine selections: Union, Intersect, Disjoin, Left or Right Subtraction.|
| [selection_freetextsearch](selection_freetextsearch.md) |Provider for selecting a Selection|
| [sentiment](sentiment.md) ||
| [serviceassociate](serviceassociate.md) |MDO provider for associates that are allowed to approve a quote.|
| [shipmenttype](shipmenttype.md) |MDO list provider for ConsentPurpose|
| [smsmailing](smsmailing.md) |SMS Shipment names|
| [smsmailingtemplate](smsmailingtemplate.md) |SMS Mailing templates|
| [source](source.md) |GenericMDOProvider reads MDO lists with default settings|
| [sourceproduct](sourceproduct.md) |Products: Sales &amp; Marketing, Customer Service|
| [stakeholderrole](stakeholderrole.md) |GenericMDOProvider reads MDO lists with default settings|
| [statusdef](statusdef.md) |Return list of status monitors defined in the system|
| [statusmonitorimage](statusmonitorimage.md) |List of images for status monitors in the blob table.|
| [stopword](stopword.md) |List of stop words. i.e. words which will not be included in the free-text index.|
| [subscriptionunit](subscriptionunit.md) |GenericMDOProvider reads MDO lists with default settings|
| [suggestedappointment](suggestedappointment.md) |Suggested Appointment Provider creates a MDO list of suggested appointments for a given guide stage.|
| [suggesteddocument](suggesteddocument.md) |SuggestedDocumentProvider creates a MDO list of suggested documents in the database.|
| [suggestedstopword](suggestedstopword.md) |Analyze free text records and suggest stop words based on word frequency|
| [systemeventtype](systemeventtype.md) |System event types: NoLogin, NoFreeText, NoTravel, Message-of-the-day|
| [tags](tags.md) |GenericMDOProvider reads MDO lists with default settings|
| [task](task.md) |Task table MDO list. Optional include "None" as first value.|
| [ticket](ticket.md) ||
| [ticketfavourite](ticketfavourite.md) |MDO list provider for Favourites|
| [ticketorigin](ticketorigin.md) |Ticket Origin|
| [ticketpriority](ticketpriority.md) |MDO list provider for ticket priorities.|
| [ticketread](ticketread.md) ||
| [ticketslevel](ticketslevel.md) |Ticket Security Level|
| [ticketstatus](ticketstatus.md) |Ticket status values: Open, Closed, Inactive, Deleted, Connected|
| [ticketticketstatus](ticketticketstatus.md) |TicketTicketStatusProvider creates a flat list based on the table: TICKET_STATUS|
| [time](time.md) |MDO provider for the hard-coded list of time alternatives in the appointment dialog and in edit/preference|
| [timezone](timezone.md) |Provides the timezone list|
| [timezonewithcode](timezonewithcode.md) |Provides the timezone list. The country code is given in the type field|
| [typegroup](typegroup.md) |Type Group: Task, Activity, Document, Sale|
| [typicalsearch](typicalsearch.md) |MDO provider for the TypicalSearch Title, Tooltip and I|
| [udeffields](udeffields.md) |Get a list of udef fields for a given type|
| [udeffieldswithchanges](udeffieldswithchanges.md) |Get a list of udef fields for a given type|
| [udeffieldtype](udeffieldtype.md) ||
| [udlist](udlist.md) |MDO Provider for 'user-defined' lists, i.e., those that reside in the UDList table. Mandatory additionalInfo is th|
| [udlist28](udlist28.md) |Dynamic MDO provider that will create a list with the name udlist&lt;id&gt; for each user-defined list in the UDListDefinition table|
| [udlist29](udlist29.md) |Dynamic MDO provider that will create a list with the name udlist&lt;id&gt; for each user-defined list in the UDListDefinition table|
| [udlist30002](udlist30002.md) |MDO provider for the ChatService|
| [usergroup](usergroup.md) |List provider for the UserGroup table. While this table looks like an MDO table|
| [usergroupwithhistoryall](usergroupwithhistoryall.md) |List provider for the UserGroup table. While this table looks like an MDO table|
| [usertype](usertype.md) |Simple, hard-coded provider for the associate type: Employee, ExternalPerson, Resource, Anonymous, System, Invalid User Type|
| [visiblefor](visiblefor.md) |List provider for the VisibleFor dropdown control. Items are of type associate, usergroup or all, wit|
| [visiblein](visiblein.md) |Visible in list for web panels.|
| [visibleinmenu](visibleinmenu.md) |Visible in menu list: Toolbox menu, View menu|
| [visibleintask](visibleintask.md) |Visible in list for tasks: places where task button can appear.|
| [webpanel](webpanel.md) |List of WebPanels visible possible for use with groups and headings.|
| [webpanelgroup](webpanelgroup.md) |List of WebPanels with visible for groups as commaseperated ids in extrainfo field|
| [weekday](weekday.md) |MDO provider for the hard-coded list of week days.|
| [weeknumber](weeknumber.md) |MDO provider for the hard-coded list of numbered weeks in the recurrence dialog.|

