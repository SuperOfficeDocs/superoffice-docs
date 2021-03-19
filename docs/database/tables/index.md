---
uid: database-table-listing-by-name
title: Database table listing
description: Lists all tables in the database.
so.generated: true
keywords:
  - "database"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Database tables by **name** | [table number](index-by-id.md)

> [!NOTE]
> Most table numbers are fixed, but could be different between databases - depends on whether there are custom 3rd party tables.

| Name | Description | Number |
|----|-----|----|
| [access\_script](access\_script.md) |Scripts to implement row-based access rules (sentry light)| 406 |
| [activeuser](activeuser.md) |Currently logged-on users. This table contains encrypted license information.  Changing it may disable login for all users and require intervention by SuperOffice support. Recommended use: for determining who is logged on, at what location, etc.| 28 |
| [address](address.md) |Contact and Person addresses| 7 |
| [AddressFormat](AddressFormat.md) |Address formats for GUI and labels. See more information: Addressformat on http://techdoc.superoffice.com| 57 |
| [AmountClass](AmountClass.md) |Amount Class list for SuperOffice Sales Intelligence (Saint) - used to group sales by amounts, into bins (low --&gt; high) called amount classes. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com | 225 |
| [AmountClassGroupLink](AmountClassGroupLink.md) |User group link table for AmountClass, for MDO item hiding| 226 |
| [AmountClassHeadingLink](AmountClassHeadingLink.md) |Heading link table for AmountClass, for MDO headers| 227 |
| [appointment](appointment.md) |Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this. | 9 |
| [area](area.md) |Definition of an Area (database subset for satellite and travel)| 38 |
| [areauserassignment](areauserassignment.md) |Link table indicating which users actually reside in this area.| 40 |
| [areauserinclusion](areauserinclusion.md) |Link table incidated whose data should be included in this area. If Include all data in Area (no filtering) is ticket then there will be no rows for this area in this table.| 41 |
| [associate](associate.md) |Employees, resources and other users - except for External persons| 2 |
| [AssociateGroupLink](AssociateGroupLink.md) |User group link table for Associate, for MDO item hiding| 3 |
| [AssociateHeadingLink](AssociateHeadingLink.md) |Heading link table for associate for display only. Supportive table, used for grouping and filtering on lists. | 4 |
| [AssociateHistory](AssociateHistory.md) |Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database| 488 |
| [attachment](attachment.md) |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table.| 296 |
| [attachment\_location](attachment\_location.md) |A location for storing attachments| 470 |
| [AudienceConfig](AudienceConfig.md) |Configuration data for Audience core and webparts| 236 |
| [AudienceLayout](AudienceLayout.md) |One layout (of webparts and other stuff) for an audience instance| 234 |
| [AudienceLayoutLink](AudienceLayoutLink.md) |Link between an audience layout and some target grouping table - might be Role or Category| 235 |
| [AudienceVisibility](AudienceVisibility.md) |How projects (or whatever) should be made visible in audience| 232 |
| [autosave](autosave.md) |Autosaved text clobs from ejscript and emarketeer messages| 402 |
| [BaseTZLocation](BaseTZLocation.md) |Time zone location for the database (how tz-related datetimes should be stored in the database)| 248 |
| [BatchTask](BatchTask.md) |Batch task request details, corresponding to the message body of a batch request message| 243 |
| [BatchTaskDefinition](BatchTaskDefinition.md) |Batch task definitiopns, populated from the SuperOffice.CRM.BatchProcessing.BatchTask attribute| 244 |
| [BinaryObject](BinaryObject.md) |Binary objects, i.e., blobs. Used for images, documents, SuperOffice inbox mail  and other large binary items| 205 |
| [BinaryObjectLink](BinaryObjectLink.md) |Link table, connects a BinaryObject with one or more owners| 206 |
| [Business](Business.md) |Business list table| 61 |
| [BusinessGroupLink](BusinessGroupLink.md) |User group link table for Business, for MDO item hiding| 62 |
| [BusinessHeadingLink](BusinessHeadingLink.md) |Heading link table for Business, for MDO headers| 63 |
| [CacheTables](CacheTables.md) |Specifies which tables should be cached to local files (or otherwise), generally these are the lists and other low-frequency-of-change tables. Contains the ID of any tables cached in SOCache. The files are binary and called &lt;tablename&gt;.bin.  &lt;Shift&gt;+&lt;F5&gt; throws all cache files. | 148 |
| [Category](Category.md) |Category list table| 64 |
| [category\_membership](category\_membership.md) |This table connects users to categories (many-to-many).| 270 |
| [CategoryFamily](CategoryFamily.md) |Grouping table so that multiple company categories can be grouped under one term; to simplify searching for things like &apos;all customers&apos;| 467 |
| [CategoryGroupLink](CategoryGroupLink.md) |User group link table for Category, for MDO item hiding| 65 |
| [CategoryHeadingLink](CategoryHeadingLink.md) |Heading link table for Category, for MDO headers| 66 |
| [chat\_message](chat\_message.md) |This table contains messages in a chat session.| 333 |
| [chat\_session](chat\_session.md) |This table contains chat sessions.| 332 |
| [chat\_topic](chat\_topic.md) |This table contains chat topics.| 330 |
| [chat\_topic\_user](chat\_topic\_user.md) |This table connected the chat topics with the users (i.e. the membership).| 331 |
| [company](company.md) |Information on license and owner of this SuperOffice database. This table should only have 1 row. This table contains encrypted license information. Changing it will disable login for all users and require you to restore the database from backup.| 1 |
| [company\_domain](company\_domain.md) |This table contains web-domains associated with a certain cust_company entry.| 303 |
| [Comptr](Comptr.md) |Comptr list table. List of all possible competitors (sale).| 109 |
| [ComptrGroupLink](ComptrGroupLink.md) |User group link table for Comptr, for MDO item hiding| 110 |
| [ComptrHeadingLink](ComptrHeadingLink.md) |Heading link table for Comptr, for MDO headers| 111 |
| [config](config.md) |This table contains certain system-wide configuration values.| 255 |
| [ConnectionConfigField](ConnectionConfigField.md) |Configuration data for Erp and Quote Connections| 421 |
| [ConsentPerson](ConsentPerson.md) |Link table that defines who has which consents| 466 |
| [ConsentPurpose](ConsentPurpose.md) |GDPR purpose alternatives| 463 |
| [ConsentSource](ConsentSource.md) |Consent source for GDPR| 465 |
| [contact](contact.md) |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.  | 5 |
| [contactinterest](contactinterest.md) |Link-table between contact and interests in ContInt| 14 |
| [ContInt](ContInt.md) |ContInt list table. List-text of all valid contact interest types.| 70 |
| [ContIntGroupLink](ContIntGroupLink.md) |User group link table for ContInt, for MDO item hiding| 71 |
| [ContIntHeadingLink](ContIntHeadingLink.md) |Heading link table for ContInt, for MDO headers| 72 |
| [CounterValue](CounterValue.md) |Visible for rights| 197 |
| [country](country.md) |Country information| 19 |
| [CountryGroupLink](CountryGroupLink.md) |User group link table for Country, for MDO item hiding| 20 |
| [CountryHeadingLink](CountryHeadingLink.md) |Heading link table for Country, for MDO headers| 21 |
| [Credentials](Credentials.md) |Alternative credentials| 250 |
| [Credited](Credited.md) |Credited list table. List of who is to be credited for the sale.| 97 |
| [CreditedGroupLink](CreditedGroupLink.md) |User group link table for Credited, for MDO item hiding| 98 |
| [CreditedHeadingLink](CreditedHeadingLink.md) |Heading link table for Credited, for MDO headers| 99 |
| [Currency](Currency.md) |Currency list table| 112 |
| [CurrencyGroupLink](CurrencyGroupLink.md) |User group link table for Currency, for MDO item hiding| 113 |
| [CurrencyHeadingLink](CurrencyHeadingLink.md) |Heading link table for Currency, for MDO headers| 114 |
| [cust\_category](cust\_category.md) |This table contains entries for categories exposed through a customer language.| 321 |
| [cust\_config](cust\_config.md) |This table contains JSON structures used for customizing the customer center| 471 |
| [cust\_lang](cust\_lang.md) |This table contains entries for customer languages.| 320 |
| [DatabaseModel](DatabaseModel.md) |New DatabaseModel used by Continuous Database| 456 |
| [DataRight](DataRight.md) |Data right definition| 195 |
| [dbi\_agent](dbi\_agent.md) |DBI agent settings| 381 |
| [dbi\_agent\_field](dbi\_agent\_field.md) |DBI agent fields| 382 |
| [dbi\_agent\_schedule](dbi\_agent\_schedule.md) |DBI agent schedule settings| 383 |
| [DeliveryTerms](DeliveryTerms.md) |The list of Delivery terms, in the internal product register| 433 |
| [DeliveryTermsGroupLink](DeliveryTermsGroupLink.md) |User group link table for DeliveryTerms, for MDO item hiding| 434 |
| [DeliveryTermsHeadingLink](DeliveryTermsHeadingLink.md) |Heading link table for DeliveryTerms, for MDO item headings| 435 |
| [DeliveryType](DeliveryType.md) |The list of Delivery types, in the internal product register| 436 |
| [DeliveryTypeGroupLink](DeliveryTypeGroupLink.md) |User group link table for DeliveryType, for MDO item hiding| 437 |
| [DeliveryTypeHeadingLink](DeliveryTypeHeadingLink.md) |Heading link table for DeliveryType, for MDO item headings| 438 |
| [DiaryView](DiaryView.md) |Configuration of a multi-user diary view| 214 |
| [DiaryViewRow](DiaryViewRow.md) |Configuration of a multi-user diary view| 215 |
| [dictionary](dictionary.md) |User added dictionary words| 358 |
| [dictionary\_base](dictionary\_base.md) |Language catalog for the ejournal dictionaries (automatic proof reading of message text etc)| 359 |
| [doc\_document](doc\_document.md) |This table contains documents.| 280 |
| [doc\_folder](doc\_folder.md) |A document folder.| 281 |
| [DocTmpl](DocTmpl.md) |DocTmpl list table. Describes templates available for writing new documents.| 130 |
| [DocTmplGroupLink](DocTmplGroupLink.md) |User group link table for DocTmpl, for MDO item hiding| 131 |
| [DocTmplHeadingLink](DocTmplHeadingLink.md) |Heading link table for DocTmpl, for MDO headers| 132 |
| [document](document.md) |Documents, this table is an extension of the Appointment table.  There is always a corresponding appointment record; the relation between appointment and document is navigable in both directions. A document-type appointment record always has a corresponding document record and a record in VisibleFor specifying who may see this.  | 10 |
| [eab\_entry](eab\_entry.md) |This table contains eab (email address book) entries, i.e. an alias (&amp;apos;Ola Hansen&amp;apos;) and an address (&amp;apos;ola@hansen.as&amp;apos;).| 315 |
| [eab\_folder](eab\_folder.md) |This table contains eab (email address book) folders, used for containing email addresses.| 314 |
| [ej\_category](ej\_category.md) |This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner.| 257 |
| [ej\_message](ej\_message.md) |This table contains the messages listed under tickets.| 258 |
| [ej\_role](ej\_role.md) |Define access rights, memberships and other properties for role user members| 323 |
| [EjCategoryGroupLink](EjCategoryGroupLink.md) |User group link table for EjCategory, for mass handling ej_category members| 450 |
| [ejpackage](ejpackage.md) |This table stores packages on the system.| 384 |
| [ejpackage\_item](ejpackage\_item.md) |This table stores info on installed packages in the system| 385 |
| [ejscript](ejscript.md) |ejscript| 377 |
| [ejscript\_debug](ejscript\_debug.md) |This table contains information when debugging an ejscript| 387 |
| [ejsel\_ejsel](ejsel\_ejsel.md) |This table defines sources for complex selections in a many/many relationship| 392 |
| [ejsel\_meta\_result](ejsel\_meta\_result.md) |This table stores result meta data| 397 |
| [ejsel\_result\_set](ejsel\_result\_set.md) |This table stores result set reference data, result sets for selections| 398 |
| [ejsel\_source\_idlist](ejsel\_source\_idlist.md) |This table stores id list source for selections| 393 |
| [ejsel\_source\_script](ejsel\_source\_script.md) |This table stores a selection script source| 394 |
| [ejsel\_source\_xml](ejsel\_source\_xml.md) |This table stores a selection source as xml| 395 |
| [ejselection](ejselection.md) |This table stores selections, dynamic groups.| 391 |
| [ejuser](ejuser.md) |This table contains entries for the users of the system.| 299 |
| [element\_profile](element\_profile.md) |The new (4.0) profile table. Contains profile for a single Html-element. Connected through element_profile_link| 328 |
| [Email](Email.md) |Email addresses for contacts, projects and persons| 55 |
| [email\_account](email\_account.md) |Email account information| 474 |
| [email\_attachment](email\_attachment.md) |Attachment info related to an email_item| 478 |
| [email\_folder](email\_folder.md) |Corresponds to an email folder on a mail server| 475 |
| [email\_item](email\_item.md) |Email data| 477 |
| [ErpConfiguration](ErpConfiguration.md) |Global settings for the Erp Integration Server| 449 |
| [ErpConnection](ErpConnection.md) |One connection to an ERP connector, specifying Client and other required information| 418 |
| [ErpConnectionAccess](ErpConnectionAccess.md) |Access control for Erp Connections| 420 |
| [ErpConnectionActorType](ErpConnectionActorType.md) |Data about the configuration of one Erp Actor on one ErpConnection| 419 |
| [ErpConnector](ErpConnector.md) |One ERP Connector, known by its URL| 417 |
| [ErpExternalKey](ErpExternalKey.md) |The external (ERP-facing) key related to a synchronized record / connection| 423 |
| [ErpField](ErpField.md) |Store the metadata describing the fields that belong to an actor/connection combination, as described by the Erp Connector| 425 |
| [ErpInternalKey](ErpInternalKey.md) |The internal (superoffice-facing) key related to a synchronized record| 422 |
| [ErpListItemMapping](ErpListItemMapping.md) |Defines a mapping of ERP to CRM fields, per connection and actor type| 424 |
| [ErpSyncLog](ErpSyncLog.md) |Record all field changes done by the Erp Sync| 426 |
| [ext\_datasource](ext\_datasource.md) |This table contains external datasources, used for databaseintegration of customers and companies.| 317 |
| [ext\_field](ext\_field.md) |This table contains entries mapping an external field to an internal field. Used for database integration.| 319 |
| [ext\_table](ext\_table.md) |This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration.| 318 |
| [ExtApp](ExtApp.md) |ExtApp list table. Applications startable from SuperOffice| 133 |
| [ExtAppGroupLink](ExtAppGroupLink.md) |User group link table for ExtApp, for MDO item hiding| 134 |
| [ExtAppHeadingLink](ExtAppHeadingLink.md) |Heading link table for ExtApp, for MDO headers| 135 |
| [external\_document](external\_document.md) |This table stores documents which can be viewed externaly, through the customer module| 401 |
| [ExternalEvent](ExternalEvent.md) |The definition of projects as events in Audience (or other Collaborative apps)| 233 |
| [extra\_fields](extra\_fields.md) |This table contains entries for the extra fields in the system.| 304 |
| [extra\_menus](extra\_menus.md) |This table contains entries for the extra menus in the system.| 307 |
| [extra\_tables](extra\_tables.md) |This table contains entries for the extra tables in the system.| 305 |
| [extra\_tables\_entry](extra\_tables\_entry.md) |Hits/entries in result set of executed search in ejournal extra tables| 309 |
| [extra\_tables\_result](extra\_tables\_result.md) |Result set of executed search in ejournal extra tables| 308 |
| [Favourite](Favourite.md) |Favourite records (star-marking)| 455 |
| [FieldLabel](FieldLabel.md) |Field label override table, makes it possible to override internal string resources. Define your own text for the panels in SuperOffice, e.g. rename Project to Cars in SOAdmin - System Options - Labels  This table contains controlling data for the string substitution mechanism. There is one row in this table for each label or string that can be substituted; the active field indicates whether the string is actually being substituted or not. Initially, all rows have this field set to 0. The table is loaded with initial data during database setup.  Only SuperOffice Development has the necessary expertise to safely add rows to this table.  If a row has active = 1, the table LocaleText should contain one or more rows pointing back to this table, with the actual text to be used. | 168 |
| [foreignapp](foreignapp.md) |Top level of Foreign Key system| 181 |
| [foreigndevice](foreigndevice.md) |Middle level of Foreign Key system| 182 |
| [foreignkey](foreignkey.md) |Foreign Key - enables storage of arbitrary extra key information for every table/row in SuperOffice. You may use this table to store your extra information instead of using the dictionary SDK to create your own tables.| 183 |
| [form](form.md) |A form which can be published on a webpage and submitted by visitors| 472 |
| [form\_keys](form\_keys.md) |Keys that makes sure a form is not posted twice| 366 |
| [form\_submission](form\_submission.md) |A form submission| 473 |
| [freetextindex](freetextindex.md) |This is the index table for the free text search function. Each word in FreeTextWords can have multiple occurrences in this table. Each record in this table points to one occurrence of the word, and points to both the table in which the word occurs (which might be contact or text), and also a pointer to the owner table (which is one of contact, person, project, appointment or sale). | 46 |
| [freetextstopwords](freetextstopwords.md) |Here are the words that can be excluded from Free Text Search by using the FreeTextAdmin. The words that appear here will not be found in FreeTextWords and typically include &quot;are&quot;, &quot;this&quot;, &quot;that&quot;, and so on - words that occur frequently, but are not useful for searching.  The more (good) stop words you have, the smaller the index will be.| 44 |
| [freetextwords](freetextwords.md) |This table contains the word list (automatically updated by the indexer) for the free-text search. Words are in UPPERCASE and truncated to 9 significant characters. Indexed words, dynamically updated by the freetext index| 45 |
| [FunctionRight](FunctionRight.md) |Functional right definition| 193 |
| [FunctionRightRoleLink](FunctionRightRoleLink.md) |Functional right definition| 194 |
| [Heading](Heading.md) |Heading items for all MDO lists, lists that are grouped and filtered.| 58 |
| [help](help.md) |This table contains the help pages.| 302 |
| [hierarchy](hierarchy.md) |This table contains folders used to group the extra tables in the system.| 306 |
| [History](History.md) |History lists for lists and searchable controls. Maintains history for Navigator or other search (find dialogs). A single table may have more than one record here, as indicated by the extra_id field. The HistorySize (preference may be set in maintenance client) defines how many records you can have in a history list.| 53 |
| [hotlist](hotlist.md) |The table is used by the hotlist to store the relationship between tickets and users| 363 |
| [ImportDefault](ImportDefault.md) |Defaults for import fields/objects| 189 |
| [ImportField](ImportField.md) |Import object types - see localetext for names| 187 |
| [ImportObject](ImportObject.md) |Import object types - see localetext for names.| 186 |
| [ImportRelation](ImportRelation.md) |Relations between import objects| 188 |
| [inbox](inbox.md) |Info and status for safe email import| 352 |
| [Intent](Intent.md) |Intent list for SAINT. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com | 216 |
| [IntentGroupLink](IntentGroupLink.md) |User group link table for Intent, for MDO item hiding| 217 |
| [IntentHeadingLink](IntentHeadingLink.md) |Heading link table for Intent, for MDO headers| 218 |
| [invitation](invitation.md) |Invitations to events| 479 |
| [invoice](invoice.md) |This table contains invoice entries, normally created when an invoice is sent to a customer, and we want to update the balance.| 265 |
| [invoice\_entry](invoice\_entry.md) |This table contain all invoices, connected to a message| 360 |
| [invoice\_sum](invoice\_sum.md) |This table is used temporarily when listing invoice statistics. It is used because we need to sort balances from both customers and companies.| 266 |
| [invoice\_type](invoice\_type.md) |A invoiceable item category (a product or service) that provides default invoice line values| 361 |
| [item\_config](item\_config.md) |This table is a generic table for storing item configuration. It is only used by the class ItemConfig.| 368 |
| [kb\_attachment](kb\_attachment.md) |This table connects FAQ entries to attachments.| 284 |
| [kb\_category](kb\_category.md) |Knowledge base folder hierarchy| 283 |
| [kb\_category\_log](kb\_category\_log.md) |Who and when, if somebody edits a knowledge base folder| 291 |
| [kb\_entry](kb\_entry.md) |This table contains FAQ entries.| 282 |
| [kb\_entry\_comment](kb\_entry\_comment.md) |Comments to entries in the knowledge base, typically made by customers| 289 |
| [kb\_entry\_keyword](kb\_entry\_keyword.md) |This table contains all keywords for the faq entries| 288 |
| [kb\_entry\_log](kb\_entry\_log.md) |Who and when, if somebody edits a knowledge base entry| 290 |
| [kb\_entry\_words](kb\_entry\_words.md) |This table contains all the words and how many times the are refered                  to in the FAQ entires| 354 |
| [kb\_group](kb\_group.md) |This table contains FAQ groups. A group is a cluster of entries (potentially located anywhere in the FAQ hierarchy). A group is located in a certain category.| 286 |
| [kb\_group\_entry](kb\_group\_entry.md) |This table contains group entries for FAQ groups.| 287 |
| [kb\_http\_link](kb\_http\_link.md) |This table contains URL&amp;apos;s associated with a single FAQ entry.| 285 |
| [kb\_solution\_finder](kb\_solution\_finder.md) |Knowledge base problem solving wizard, categories and subcategories for drilling down| 294 |
| [kb\_solution\_finder\_entry](kb\_solution\_finder\_entry.md) |Knowledge base problem solving wizard, items in a category linking to a knowledge base entry| 295 |
| [kb\_workflow](kb\_workflow.md) |Knowledge base workflow steps| 292 |
| [kb\_workflow\_access](kb\_workflow\_access.md) |Control of who can do what in a knowledge base workflow step| 293 |
| [LanguageInfo](LanguageInfo.md) |Information about languages, from ISO standards and related information| 210 |
| [LanguageInfoCountry](LanguageInfoCountry.md) |Many-many link between countries and languages, to give intelligent choices for language| 211 |
| [legal\_html\_tags](legal\_html\_tags.md) |This table is used as a list of all legal HTML tags. HTML tags not in this list                  will be ignored when viewing html versions of messages| 353 |
| [LegalBase](LegalBase.md) |Legal base for GDPR (Article 6)| 464 |
| [LicenseAssocLink](LicenseAssocLink.md) |Link between ModuleLicense and Associate, for per-assoc licenses; this is how licenses are assigned/consumed| 238 |
| [LicenseSatlLink](LicenseSatlLink.md) |Link between License and Satellite, for per-database licenses| 239 |
| [LocaleText](LocaleText.md) |Multi-language text items. Used for user-defined field labels. Must be assigned correct name to match the language they start SuperOffice in.  This table should be viewed in conjunction with FieldLabel. If a row in FieldLable has active = 1 this table will need to contain at least one row with the same resourceId as the FieldLabel row. The language id can be either 0 or one of the Windows language ID&apos;s; SuperOffice will pick the correct language on startup according to the user settings. If a label cannot be found with the given language and also not with language 0, it will not be substituted. | 169 |
| [locking](locking.md) |Generic locking and error messages| 380 |
| [log\_debug](log\_debug.md) |A log used for debugging, especially useful for bLogic/ejscript| 365 |
| [log\_events](log\_events.md) |System log| 364 |
| [login](login.md) |This table contains entries for the user sessions. | 297 |
| [login\_customer](login\_customer.md) |This table contains entries for customer sessions. At first only used for Soap logins, but will later also be used for web logins| 298 |
| [mail\_alias](mail\_alias.md) |This table contains the alias&amp;apos;es for each mailbox, one-to-many-relation. It is in so we can substract the alias&amp;apos;es when when listing the recipients of a message.     | 273 |
| [mail\_block](mail\_block.md) |This table controls the spam-protection system, ensuring that a single email recipient does not recieve too many emails during a certain period of time.| 316 |
| [mail\_in\_filter](mail\_in\_filter.md) |This table contains entries for the mailboxes the eJournal system is fetching mail from (POP3 or IMAP).| 271 |
| [mail\_in\_uidl](mail\_in\_uidl.md) |This table is used to avoid spamming the system by importing the same message several times (normally a result of a crash somewhere). When a mailbox is openede, then unique id for each message is stored in this table, and then removed only when the message has been correctly imported and deleted from mailbox.| 272 |
| [MergeMoveLog](MergeMoveLog.md) |Log of merge and move operations (person, contact, project)| 37 |
| [Message](Message.md) |Definition of a message, corresponding to the header of a protocol| 242 |
| [message\_customers](message\_customers.md) |This table contains all cutomers who are involved in a message| 260 |
| [message\_header](message\_header.md) |This table contains small pieces of information which is listed over the body for each message.| 259 |
| [message\_id](message\_id.md) |This table links an email message id to an eJournal item| 386 |
| [MessageHandler](MessageHandler.md) |Presence and heartbeat of a message handler, should be updated once a minute. Older records are stale| 241 |
| [ModuleLicense](ModuleLicense.md) |Module licenses, belonging to one single owner| 237 |
| [ModuleOwner](ModuleOwner.md) |Unique owner of a set of licensed modules| 212 |
| [MrMrs](MrMrs.md) |MrMrs list table. List of salutations.| 94 |
| [MrMrsGroupLink](MrMrsGroupLink.md) |User group link table for MrMrs, for MDO item hiding| 95 |
| [MrMrsHeadingLink](MrMrsHeadingLink.md) |Heading link table for MrMrs, for MDO headers| 96 |
| [ms\_filter](ms\_filter.md) |This table contains email filters. These are the filters allowing you to do advanced parsing of incomming emails.| 310 |
| [ms\_filter\_mail](ms\_filter\_mail.md) |This table connects mail filters (ms_filter) to mailboxes (mail_in_filter).| 311 |
| [ms\_substitute](ms\_substitute.md) |Regexp for extracting info from emails when they enter they system| 313 |
| [ms\_trashbin](ms\_trashbin.md) |This table contains entries for emails which have been trashed by a filter, waiting for confirmation of deletion or import.| 312 |
| [notice\_frame](notice\_frame.md) |PID controller for automatic adjustment of pop up message check rate| 404 |
| [notify](notify.md) |This table contains the pop-up messages displayed for users for various events, such as &amp;apos;new ticket&amp;apos;, etc.| 301 |
| [OLEField](OLEField.md) |Control data table for the OLE DB Provider| 165 |
| [OLEFieldText](OLEFieldText.md) |Control data table for the OLE DB Provider| 166 |
| [OLESubject](OLESubject.md) |Control data table for the OLE DB Provider| 161 |
| [OLESubjectText](OLESubjectText.md) |Control data table for the OLE DB Provider| 162 |
| [OLEView](OLEView.md) |Control data table for the OLE DB Provider| 163 |
| [OLEViewText](OLEViewText.md) |Control data table for the OLE DB Provider| 164 |
| [OnlineApp](OnlineApp.md) |Echo and track information about Online Apps and their usage| 482 |
| [outbox](outbox.md) |Outgoing emails with sending status and other info| 351 |
| [outgoing\_message](outgoing\_message.md) |Delivery of outgoing messages to messageplugins, updated with status asynchroneously| 407 |
| [OwnerContactLink](OwnerContactLink.md) |Table specifying which contacts can own associates.  All contacts that have rows in this table (i.e. rows with contact_id pointing to them) will be offered as associate owners in the maintenance client and as candidate Satellite owners. Such contacts have restrictions on editing and deletion to protect database consistency. | 167 |
| [password\_rules](password\_rules.md) |This table may contain one entry specifying rules for passwords.| 322 |
| [PaymentTerms](PaymentTerms.md) |The list of payment terms, in the internal product register| 427 |
| [PaymentTermsGroupLink](PaymentTermsGroupLink.md) |User group link table for PaymentTerms, for MDO item hiding| 428 |
| [PaymentTermsHeadingLink](PaymentTermsHeadingLink.md) |Heading link table for PaymentTerms, for MDO item headings| 429 |
| [PaymentType](PaymentType.md) |The list of payment types, in the internal product register| 430 |
| [PaymentTypeGroupLink](PaymentTypeGroupLink.md) |User group link table for PaymentType, for MDO item hiding| 431 |
| [PaymentTypeHeadingLink](PaymentTypeHeadingLink.md) |Heading link table for PaymentType, for MDO item headings| 432 |
| [PersInt](PersInt.md) |PersInt list table. List of Person interests.| 73 |
| [PersIntGroupLink](PersIntGroupLink.md) |User group link table for PersInt, for MDO item hiding| 74 |
| [PersIntHeadingLink](PersIntHeadingLink.md) |Heading link table for PersInt, for MDO headers| 75 |
| [person](person.md) |Persons in a company or an organizations. All associates have a corresponding person record| 6 |
| [personinterest](personinterest.md) |Note: If you add or remove rows in this table, you will need to update the interestCount field in the person table accordingly. This field should always reflect the number of interest records a person has, to enable the correct setting of the interest indicator on the tab in the person dialog.  Replication note: The combination of person_id and pinterest_idx is unique. If a duplicate is made on a replicated database, the system will replace the record in the target database with the one derived from the source database during replication. Therefore, do not assume that a record in this table will retain its ID indefinitely, even if the person keeps the interest.| 15 |
| [PersPos](PersPos.md) |PersPos list table. Contact person position list| 76 |
| [PersPosGroupLink](PersPosGroupLink.md) |User group link table for PersPos, for MDO item hiding| 77 |
| [PersPosHeadingLink](PersPosHeadingLink.md) |Heading link table for PersPos, for MDO headers| 78 |
| [phone](phone.md) |Contact and Person phonenumbers (+fax)| 8 |
| [PhoneFormat](PhoneFormat.md) |Formatting information for telephone numbers| 251 |
| [PMembType](PMembType.md) |PMembType list table. List text of titles (member types) for project members.| 91 |
| [PMembTypeGroupLink](PMembTypeGroupLink.md) |User group link table for PMembType, for MDO item hiding| 92 |
| [PMembTypeHeadingLink](PMembTypeHeadingLink.md) |Heading link table for PMembType, for MDO headers| 93 |
| [PrefDesc](PrefDesc.md) |Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. | 184 |
| [PrefDescLine](PrefDescLine.md) |Preference description - multiple choice line - drives the Preference GUI. May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files.| 185 |
| [preference](preference.md) |Not quite obsolete preference table; historical info mostly. From 6.1 this table now holds an upgrade stamp.| 22 |
| [PriceList](PriceList.md) |List of prices, cached from an ERP system| 128 |
| [PriceUnit](PriceUnit.md) |The list of price units, in the internal product register (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever)| 439 |
| [PriceUnitGroupLink](PriceUnitGroupLink.md) |User group link table for PriceUnit, for MDO item hiding| 440 |
| [PriceUnitHeadingLink](PriceUnitHeadingLink.md) |Heading link table for PriceUnit, for MDO item headings| 441 |
| [Priority](Priority.md) |Priority list table. Used with appointments: low, high.| 79 |
| [PriorityGroupLink](PriorityGroupLink.md) |User group link table for Priority, for MDO item hiding| 80 |
| [PriorityHeadingLink](PriorityHeadingLink.md) |Heading link table for Priority, for MDO headers| 81 |
| [Prob](Prob.md) |Prob list table. Probability, used in  sales .| 82 |
| [ProbGroupLink](ProbGroupLink.md) |User group link table for Prob, for MDO item hiding| 83 |
| [ProbHeadingLink](ProbHeadingLink.md) |Heading link table for Prob, for MDO headers| 84 |
| [Product](Product.md) |One Product, member of one price list| 129 |
| [ProductCategory](ProductCategory.md) |List for the ProductCategory field of the Product table (Quote Management)| 408 |
| [ProductCategoryGroupLink](ProductCategoryGroupLink.md) |User group link table for ProductCategory, for MDO item hiding| 409 |
| [ProductCategoryHeadingLink](ProductCategoryHeadingLink.md) |Heading link table for ProductCategory, for MDO item headings| 410 |
| [ProductFamily](ProductFamily.md) |List for the ProductFamily field of the Product table (Quote Management)| 411 |
| [ProductFamilyGroupLink](ProductFamilyGroupLink.md) |User group link table for ProductFamily, for MDO item hiding| 412 |
| [ProductFamilyHeadingLink](ProductFamilyHeadingLink.md) |Heading link table for ProductFamily, for MDO item headings| 413 |
| [ProductType](ProductType.md) |List for the ProductType field of the Product table (Quote Management)| 414 |
| [ProductTypeGroupLink](ProductTypeGroupLink.md) |User group link table for ProductType, for MDO item hiding| 415 |
| [ProductTypeHeadingLink](ProductTypeHeadingLink.md) |Heading link table for ProductType, for MDO item headings| 416 |
| [ProductVersion](ProductVersion.md) |Version information for code modules. Owner + code module must be unique| 240 |
| [profile](profile.md) |Deprecated. This table contains entries for the user profiles.| 329 |
| [project](project.md) |Projects| 11 |
| [projectmember](projectmember.md) |Project members. Link-table between person and project| 12 |
| [ProjectTypeStatusLink](ProjectTypeStatusLink.md) |Many-many link table between project type and status, similar to sale type-stage link; and an anchor point for guide items| 213 |
| [ProjStatus](ProjStatus.md) |ProjStatus list table. Project status| 88 |
| [ProjStatusGroupLink](ProjStatusGroupLink.md) |User group link table for ProjStatus, for MDO item hiding| 89 |
| [ProjStatusHeadingLink](ProjStatusHeadingLink.md) |Heading link table for ProjStatus, for MDO headers| 90 |
| [ProjType](ProjType.md) |ProjType list table. List of valid Project types.| 85 |
| [ProjTypeGroupLink](ProjTypeGroupLink.md) |User group link table for ProjType, for MDO item hiding| 86 |
| [ProjTypeHeadingLink](ProjTypeHeadingLink.md) |Heading link table for ProjType, for MDO headers| 87 |
| [Publish](Publish.md) |Publishing system for external users| 200 |
| [PushNotificationService](PushNotificationService.md) |Used for storing handles to user devices that should receive push notifications| 483 |
| [quick\_reply](quick\_reply.md) |Personal quick reply text fragments| 462 |
| [Quote](Quote.md) |Quote root level, at most one per Sale, always connected to one Sale| 34 |
| [QuoteAlternative](QuoteAlternative.md) |Quote Version is made up of one or more Alternatives. One of 1..n possible alternatives in a Quote Version. The reason we have alternatives is that a quote can say to a customer, “we can solve you problem in two (or more) different ways, with different technology and sideeffects (and price)”. An Alternative may have discounts on the total amount. The Alternative tracks whether the user on the order level entered the Discount , Earning amount or the TotalPrice fields so that the discount and earning and total can be re-calculated correctly when Quote Lines are added or changed.| 47 |
| [QuoteConnection](QuoteConnection.md) |Primary key in the CRM database. Definition of a connection to an external system, for the Quote system.| 26 |
| [QuoteConnectionAccess](QuoteConnectionAccess.md) |Access control for Quote Connections| 27 |
| [QuoteLine](QuoteLine.md) |One line in a QuoteAlternative. QuoteLines are mainly information copied from the Products provider. Products information is sometimes edited by the user before being included in the quote, so most information is duplicated from Product rather than referenced directly.| 127 |
| [QuoteLineConfiguration](QuoteLineConfiguration.md) |Configuration of quote lines - which fields are in use, rights, labels etc| 445 |
| [QuoteVersion](QuoteVersion.md) |There may be multiple Versions of a Quote, with one of them active| 39 |
| [QuoteVersionAttachment](QuoteVersionAttachment.md) |Actual attachments to a quote| 447 |
| [Reason](Reason.md) |Reason list table. Why we lost the sale (list)| 103 |
| [ReasonGroupLink](ReasonGroupLink.md) |User group link table for Reason, for MDO item hiding| 104 |
| [ReasonHeadingLink](ReasonHeadingLink.md) |Heading link table for Reason, for MDO headers| 105 |
| [ReasonSold](ReasonSold.md) |Why was the sale marked as sold (why did we succeed)| 115 |
| [ReasonSoldGroupLink](ReasonSoldGroupLink.md) |User group link table for ReasonSold, for MDO item hiding| 116 |
| [ReasonSoldHeadingLink](ReasonSoldHeadingLink.md) |Heading link table for ReasonSold, for MDO headers| 117 |
| [ReasonStalled](ReasonStalled.md) |Why was the sale marked as stalled| 154 |
| [ReasonStalledGroupLink](ReasonStalledGroupLink.md) |Link table for ReasonStalled, for MDO item hiding| 155 |
| [ReasonStalledHeadingLink](ReasonStalledHeadingLink.md) |Heading link table for ReasonStalled, for MDO headers| 156 |
| [RecurrenceRule](RecurrenceRule.md) |The recurrency pattern for a recurring event. Each recurring event has an appointment.recurrenceRuleId pointing to its pattern.| 207 |
| [redletterday](redletterday.md) |Red letter days for calendar (holidays, birthday of king etc)| 17 |
| [RefCountRange](RefCountRange.md) |Number allocation system, for keeping track of ranges of numbers loaned out to travel and satellite databases| 172 |
| [RefCounts](RefCounts.md) |Number counter for all tables that generate numbers, e.g. templates, contacts...   This table is used for the number allocation system and should not be confused with sequence, used for allocating internal ID&apos;s. This table is replicated during generation of satellites and during local update for travellers, using special logic. By default it contains rows for the SuperOffice standard counters, including one row for each DocTemplate record.  It is permissible to add new rows to this table, and such records are maintainable through the Maintenance client.  Changing the contents of the standard records is not recommended. | 171 |
| [registry](registry.md) |System settings| 253 |
| [RejectReason](RejectReason.md) |Rejection reason (suggested) for bookings| 222 |
| [RejectReasonGroupLink](RejectReasonGroupLink.md) |User group link table for Comptr, for MDO item hiding| 223 |
| [RejectReasonHeadingLink](RejectReasonHeadingLink.md) |Heading link table for RejectReason, for MDO headers| 224 |
| [relationdefinition](relationdefinition.md) |Definition of a relation. This table defines the relations that can exist in the database. Each relation has an active text and a passive text. The table RelationTarget specifies which pairs of tables this relation can connect.  Use of the active and passive texts is dependent on which direction the relation is viewed in, e.g., active text = &quot;Owns&quot; and passive text = &quot;Is owned by&quot;.| 48 |
| [relations](relations.md) |Instance of a relation, in principle between any two records, as long as they are defined in RelationDefinition. All instances of relations are held in this table; their definitions are in the RelDef table (RelDef + RelTarg define which relations you can have, this table contains the relations the user has actually entered). From 6.1 all links between appointments, sales and documents are also stored in this tabel.| 52 |
| [relationtarget](relationtarget.md) |Definition of targets for a relation. Links a relation definition (RelDef) to source and target tables. In general, a relation can be created between any pair of tables. This table is used for specifying which table pairs a particular relation can be used for. A relation definition should have at least one row in this table, and can have more. Note: The 5.0 Maintenance and GUI only support contact and person as valid values for the source_table and destination_table fields, in any combination. Other relations will not be shown, and relation definitions pointing to other tables will not be editable from the Maintenance GUI; however, nothing will crash.| 51 |
| [RelDefGroupLink](RelDefGroupLink.md) |User group link table for RelDef, for MDO item hiding| 49 |
| [RelDefHeadingLink](RelDefHeadingLink.md) |Heading link table for RelDef, for MDO headers| 50 |
| [reply\_template](reply\_template.md) |Templates for automatic and manual replies to emails/sms organized hierachically| 277 |
| [reply\_template\_attachment](reply\_template\_attachment.md) |This table is used to connect attachments to reply templates (many-to-many).| 278 |
| [reply\_template\_body](reply\_template\_body.md) |Contains the body of the reply templates in different languages| 279 |
| [reply\_template\_folder](reply\_template\_folder.md) |This table contains entries for folders for reply templates.| 276 |
| [ReporterListDef](ReporterListDef.md) |Reporter definitions| 170 |
| [ResourceOverride](ResourceOverride.md) |Generic mechanism for overriding (or even defining new) text resources, in multiple languages| 448 |
| [Role](Role.md) |User roles for role-based security, names and tooltips are in LocaleText. For more information regarding role based security, see http://techdoc.superoffice.com| 191 |
| [role\_category](role\_category.md) |Category membership associated with a role| 325 |
| [role\_element](role\_element.md) |Profiles associated with a role| 326 |
| [role\_member](role\_member.md) |Users linked to a role. Deprecated.| 324 |
| [role\_workflow](role\_workflow.md) |Knowledge base workflow access rights associated with a role| 327 |
| [s\_attachment](s\_attachment.md) |A connector between a message and attachments. One message can contain many attachments.| 349 |
| [s\_bounce\_shipment](s\_bounce\_shipment.md) |Email bounces from customers| 342 |
| [s\_dyn\_criteria](s\_dyn\_criteria.md) |Contains criterias for a dynamic list.| 350 |
| [s\_link](s\_link.md) |Links in messages to measure success rate of a campaign.| 336 |
| [s\_link\_customer](s\_link\_customer.md) |A connection between a customer and a link. Registered customers are identified when clicking on a link| 337 |
| [s\_link\_customer\_statical](s\_link\_customer\_statical.md) |A connection between a customer and a link. Registered customers are identified when clicking on a link| 338 |
| [s\_list](s\_list.md) |A list, dynamic or static| 344 |
| [s\_list\_customer](s\_list\_customer.md) |Elements in a customer list.| 346 |
| [s\_list\_element](s\_list\_element.md) |Elements in a static list.| 345 |
| [s\_list\_shipment](s\_list\_shipment.md) |A connector between shipment and list so that one shipment can have many lists, and one list can have many shipments| 348 |
| [s\_message](s\_message.md) |A message used in a shipment. Can be html and/or plain text| 335 |
| [s\_messageblock](s\_messageblock.md) |Contains a block of a mailing message, that can be reused in a mailing| 480 |
| [s\_picture\_entry](s\_picture\_entry.md) |This table describes each picture in the database| 340 |
| [s\_picture\_folder](s\_picture\_folder.md) |This table contains all picture folders| 339 |
| [s\_sent\_message](s\_sent\_message.md) |Emarketeer message control| 405 |
| [s\_shipment](s\_shipment.md) |Contains info about one shipment. The addresses are stored in s_shipment_addr| 334 |
| [s\_shipment\_addr](s\_shipment\_addr.md) |Addresses that are ready to be sent in a shipment.| 347 |
| [s\_smtp\_servers](s\_smtp\_servers.md) |Contains the smtp server for a shipment| 390 |
| [s\_washing](s\_washing.md) |Register of all bounced mail to enabel washing| 341 |
| [s\_washing\_list](s\_washing\_list.md) |Unused table that is ment to be used for active washing in spm v2| 343 |
| [SaintConfiguration](SaintConfiguration.md) |Configuration information for the Saint system| 458 |
| [sale](sale.md) |Sales  For every Sale record edited through the SuperOffice GUI, a copy of the previous version of the record will be saved in the SaleHist table. This also applies to editing done through the SaleModel COM interface, but not to editing done through the OLE DB Provider or other channels.  | 13 |
| [SaleHist](SaleHist.md) |Mirror image of the Sale table, providing a full transaction history. Every time you edit a sale, the previous record of the sale is moved here. | 157 |
| [SaleStakeholder](SaleStakeholder.md) |Stakeholders in the sale, very similar to project members| 121 |
| [SaleType](SaleType.md) |Type of sale - large solution, incremental, whatever fits the organization| 149 |
| [SaleTypeCat](SaleTypeCat.md) |Category for sale type| 118 |
| [SaleTypeCatGroupLink](SaleTypeCatGroupLink.md) |User group link table for SaleTypeCat, for MDO item hiding| 119 |
| [SaleTypeCatHeadingLink](SaleTypeCatHeadingLink.md) |Heading link table for SaleTypeCat, for MDO headers| 120 |
| [SaleTypeGroupLink](SaleTypeGroupLink.md) |User group link table for SaleType, for MDO item hiding| 150 |
| [SaleTypeHeadingLink](SaleTypeHeadingLink.md) |Heading link table for SaleType, for MDO headers| 151 |
| [SaleTypeQuoteAttachment](SaleTypeQuoteAttachment.md) |Default attachments to quotes linked to sales of this type| 446 |
| [SaleTypeStageLink](SaleTypeStageLink.md) |Many-many link table between sale type and stage; and an anchor point for guide items| 160 |
| [Salutation](Salutation.md) |Academic title for Person| 219 |
| [SalutationGroupLink](SalutationGroupLink.md) |User group link table for Salutation, for MDO item hiding| 220 |
| [SalutationHeadingLink](SalutationHeadingLink.md) |Heading link table for Salutation, for MDO headers| 221 |
| [satellite](satellite.md) |Definition of Satellites| 42 |
| [schedule](schedule.md) |Generic scheduled tasked handling time scheduling, locking and error messages| 379 |
| [scheduled\_task](scheduled\_task.md) |A scheduled entry executing a script at certain times| 376 |
| [screen\_chooser](screen\_chooser.md) |Screen choosers| 375 |
| [screen\_definition](screen\_definition.md) |A configurable screen| 370 |
| [screen\_definition\_action](screen\_definition\_action.md) |An action to perform for a certain button in an screen| 371 |
| [screen\_definition\_element](screen\_definition\_element.md) |An element in a configurable screen| 372 |
| [screen\_definition\_hidden](screen\_definition\_hidden.md) |The name of a hidden variable to keep for this screen| 373 |
| [screen\_definition\_language](screen\_definition\_language.md) |Custom language variables used for screens| 374 |
| [script\_trace](script\_trace.md) |Scripts which should be traced| 468 |
| [script\_trace\_run](script\_trace\_run.md) |Traces of executed scripts| 469 |
| [SearchCat](SearchCat.md) |SearchCat list table| 106 |
| [SearchCatGroupLink](SearchCatGroupLink.md) |User group link table for SearchCat, for MDO item hiding| 107 |
| [SearchCatHeadingLink](SearchCatHeadingLink.md) |Heading link table for SearchCat, for MDO headers| 108 |
| [SearchCriteria](SearchCriteria.md) |Criteria storage for Selection and other Find mechanisms| 201 |
| [SearchCriteriaGroup](SearchCriteriaGroup.md) |Criteria storage for Selection and other Find mechanisms| 202 |
| [SearchCriterion](SearchCriterion.md) |Criteria storage for Selection and other Find mechanisms| 203 |
| [SearchCriterionValue](SearchCriterionValue.md) |Criteria storage for Selection and other Find mechanisms| 204 |
| [selection](selection.md) |Selections| 23 |
| [selectionmember](selectionmember.md) |Selection detail table  Each row in a selection is represented by one record in this table. Contact_id is always filled in, person_id is optional, but if used, must point to a person belonging to the contact in contact_id.| 24 |
| [sequence](sequence.md) |next_id to be used for each table| 0 |
| [service\_auth](service\_auth.md) |Authentication for a service (imap, smtp...)| 476 |
| [session\_object](session\_object.md) |Generic session object, accessible from ejscript etc, typically xml or name=value syntax, may be stored over several rows if big| 254 |
| [ShipmentType](ShipmentType.md) |Shipment type list table. Classification of a mailing, allowing recipients to subscribe to lists| 484 |
| [ShipmentTypeReservation](ShipmentTypeReservation.md) |ShipmentTypes a person has reserved against. Note that the absense of a record here implies acceptance of a mailings of this type| 485 |
| [sms](sms.md) |This table will hold outgoing sms messages when transmitted with WebServices| 388 |
| [sms\_hysteria](sms\_hysteria.md) |Avoid sending too many sms messages in a short time interval to one person| 367 |
| [snapshot](snapshot.md) |Snapshots taken of the system database and attachments via soap| 369 |
| [soap\_access](soap\_access.md) |Table that contains constraints on the access to the soap interface| 362 |
| [SORCriteria](SORCriteria.md) |SuperOffice reporter data| 175 |
| [SORFCT](SORFCT.md) |SuperOffice reporter data| 178 |
| [SORField](SORField.md) |SuperOffice reporter data| 179 |
| [SORLabelLayout](SORLabelLayout.md) |SuperOffice reporter data| 180 |
| [SOROperators](SOROperators.md) |SuperOffice reporter data| 176 |
| [SORPublish](SORPublish.md) |SuperOffice reporter data| 174 |
| [SORPublishGroupLink](SORPublishGroupLink.md) |Link table used for filtering reports by user group| 25 |
| [SORSection](SORSection.md) |SuperOffice reporter data| 177 |
| [SORTemplate](SORTemplate.md) |SuperOffice reporter data| 173 |
| [Source](Source.md) |Source list table. Source for sale (list)| 100 |
| [SourceGroupLink](SourceGroupLink.md) |User group link table for Source, for MDO item hiding| 101 |
| [SourceHeadingLink](SourceHeadingLink.md) |Heading link table for Source, for MDO headers| 102 |
| [StakeholderRole](StakeholderRole.md) |Role a stakeholder has in a sale| 122 |
| [StakeholderRoleGroupLink](StakeholderRoleGroupLink.md) |User group link table for StakeholderRole, for MDO item hiding| 123 |
| [StakeholderRoleHeadingLink](StakeholderRoleHeadingLink.md) |Heading link table for StakeholderRole, for MDO headers| 124 |
| [static\_list\_ref](static\_list\_ref.md) |This table stores id references for selections id lists| 396 |
| [StatusDef](StatusDef.md) |Status definitions. Name and description are in LocaleText for internationalization| 198 |
| [StatusValue](StatusValue.md) |Values for statuses| 199 |
| [SubscriptionUnit](SubscriptionUnit.md) |The list of Subscription units, in the internal product register (year/quarter/month etc., or perhaps amounts if volume-based subscription)| 442 |
| [SubscriptionUnitGroupLink](SubscriptionUnitGroupLink.md) |User group link table for SubscriptionUnit, for MDO item hiding| 443 |
| [SubscriptionUnitHeadingLink](SubscriptionUnitHeadingLink.md) |Heading link table for SubscriptionUnit, for MDO item headings| 444 |
| [SuggestedAppointment](SuggestedAppointment.md) |Defines a suggested appointment for use in a Sale Guide or Project Guide| 125 |
| [SuggestedDocument](SuggestedDocument.md) |Unique owner of a set of licensed modules| 126 |
| [SuperListColumnSize](SuperListColumnSize.md) |Stores the relative size (in percent) or in characters of a column in a SuperList| 209 |
| [system\_script](system\_script.md) |A table containing the system script| 378 |
| [SystemEvent](SystemEvent.md) |System events, such as freetext rebuild, SAINT rebuild and such. Makes broadcasts to keep its siblings and clients updated. | 153 |
| [TabOrder](TabOrder.md) |Order of tabs within a tab control, if configured by a user| 152 |
| [Tags](Tags.md) |MDO List of tags for Service entities| 459 |
| [TagsGroupLink](TagsGroupLink.md) |User group link table for Tags, for MDO item hiding| 460 |
| [TagsHeadingLink](TagsHeadingLink.md) |Heading link table for Source, for MDO headers| 461 |
| [Task](Task.md) |Task list table, activity types, like Phone, Meeting| 67 |
| [TaskGroupLink](TaskGroupLink.md) |User group link table for Task, for MDO item hiding| 68 |
| [TaskHeadingLink](TaskHeadingLink.md) |Heading link table for Task, for MDO headers| 69 |
| [temporary\_words](temporary\_words.md) |This table is used as a temporary table, containing the words we want                  to search for in the FAQs| 356 |
| [TemporaryKey](TemporaryKey.md) |Temporary keys for lightweight authentications such as changing ones subscriptions| 486 |
| [text](text.md) |Long text fields from all over the system| 18 |
| [ticket](ticket.md) |This table contains the tickets (requests) of the system. Its purpose should be evident.| 262 |
| [ticket\_alert](ticket\_alert.md) |This table will contain ticket escalation levels. A ticket will be escalated along a &amp;apos;chain&amp;apos; of these levels.| 274 |
| [ticket\_attachment](ticket\_attachment.md) |This table connects an attachment to a message. It references the entry in the attachment table, and the message.| 256 |
| [ticket\_customers](ticket\_customers.md) |This table allows several customers to be connected to several tickets (many-to-many)| 264 |
| [ticket\_log](ticket\_log.md) |This table contains log entries for the tickets.| 267 |
| [ticket\_log\_action](ticket\_log\_action.md) |This table contains actions for the tickets.| 269 |
| [ticket\_log\_change](ticket\_log\_change.md) |This table contains log entries for the tickets.| 268 |
| [ticket\_priority](ticket\_priority.md) |This table contains the ticket priorities.| 275 |
| [ticket\_relation](ticket\_relation.md) |Contains ticket relations, used to drive processing logic| 454 |
| [ticket\_relation\_action](ticket\_relation\_action.md) |Contains ticket relation actions, used to drive processing logic together with ticket relations| 453 |
| [ticket\_relation\_type](ticket\_relation\_type.md) |Contains ticket relation types, used to drive processing logic together with ticket relations| 452 |
| [ticket\_status](ticket\_status.md) |This table user defined ticket status values.| 263 |
| [ticket\_status\_history](ticket\_status\_history.md) |This table contains the history of a tickets statuses. Each time a ticket changes status a copy of the previous status of the record will be saved | 261 |
| [ticket\_type](ticket\_type.md) |Contains ticket types, used to drive processing logic together with ticket relations| 451 |
| [timestamps](timestamps.md) |Timestamp information| 300 |
| [travelcurrent](travelcurrent.md) |Information about this database and its place in the hierarchy| 32 |
| [travelgenerateddatabase](travelgenerateddatabase.md) |Information about all databases generated from this database| 33 |
| [travelgeneratedtransaction](travelgeneratedtransaction.md) |Record of all generated replication data files from this database (*.dwn files from mother database to child, *.up from child database to mother)| 30 |
| [travelidmapping](travelidmapping.md) |Mapping of primary keys between Travel databases and the mother database  All travel database transactions get a high id to be able to see that this entry came from a database outside the central database. When update files are read into the central database, they get a normal low id. This table remembers the high travel id to map it to the low central id as long as this travel user is travelling. | 43 |
| [traveller](traveller.md) |Associates traveling out from this database| 31 |
| [traveltransactionlog](traveltransactionlog.md) |Log of all updates made to the database, that need to be replicated.| 29 |
| [TrayApp](TrayApp.md) |Tray application presence. SuperOffice CRM web extensions.| 252 |
| [tree\_explorer\_entry](tree\_explorer\_entry.md) |This table stores the entries in a tree-explorer| 399 |
| [tree\_explorer\_link](tree\_explorer\_link.md) |This table stores the link of entries in a tree-explorer| 400 |
| [TypicalSearch](TypicalSearch.md) |Owner of a set of predefined selection criteria| 481 |
| [TZDstRule](TZDstRule.md) |Time zone rule for daylight saving time| 247 |
| [TZLocation](TZLocation.md) |Time zone location| 245 |
| [TZStdRule](TZStdRule.md) |Time zone rule for standard time| 246 |
| [udappntlarge](udappntlarge.md) |User-defined fields| 229 |
| [udappntsmall](udappntsmall.md) |User-defined fields| 228 |
| [udcontactLarge](udcontactLarge.md) |User-defined fields for contact (long strings)| 36 |
| [udcontactSmall](udcontactSmall.md) |User-defined fields for contact| 35 |
| [uddoclarge](uddoclarge.md) |User-defined fields| 231 |
| [uddocsmall](uddocsmall.md) |User-defined fields| 230 |
| [UDefField](UDefField.md) |Definition table for user-defined fields; one row in this table corresponds to one generation of one field. The user defined fields that are in use, and earlier versions of user defined fields. ColumnId refers to the field type; see UDXXXSmall or UDXXXLarge for the referring ID.  Preferences prefsection=&apos;System&apos;, prefkey=&apos;CurrentUdefVersioncontact&apos;  (or CurrentUdefVersionperson, project, sale), gives you the current version of user defined fields.  prefkey=&apos;AdminUdefVersion&lt;...&gt;&apos; gives you the current version that&apos;s being edited. If Current version = admin version, no editing has been done since the last Publish of user defined field was performed.| 146 |
| [UDefFieldGL](UDefFieldGL.md) |User group link table for UDefField, for MDO item hiding| 147 |
| [UDList](UDList.md) |List table for user-defined lists, contains all user-defined lists. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.| 136 |
| [UDListDefinition](UDListDefinition.md) |List table that contains the list of user-defined lists, as well as system-defined lists. The list items are stored in the UDList table. | 139 |
| [UDListGroupLink](UDListGroupLink.md) |User group link table for UDList, for MDO item hiding. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.| 137 |
| [UDListHeadingLink](UDListHeadingLink.md) |Heading link table for UDList, for MDO headers. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.| 138 |
| [udpersonLarge](udpersonLarge.md) |User-defined fields| 141 |
| [udpersonSmall](udpersonSmall.md) |User-defined fields| 140 |
| [udprojectLarge](udprojectLarge.md) |User-defined fields. During conversion of user defined fields the data is stored in this table.| 143 |
| [udprojectSmall](udprojectSmall.md) |User-defined fields| 142 |
| [udsalelarge](udsalelarge.md) |User-defined fields| 159 |
| [udsalesmall](udsalesmall.md) |User-defined fields| 158 |
| [udtempLarge](udtempLarge.md) |User-defined fields| 145 |
| [udtempSmall](udtempSmall.md) |User-defined fields. During conversion of user defined fields the data is stored in this table.| 144 |
| [URL](URL.md) |Unified Resource Locators, URL to contacts, persons or projects.| 54 |
| [UsageStats](UsageStats.md) |Usage statistics| 190 |
| [user\_attribute](user\_attribute.md) |This table is used for storing various attributes for users.| 403 |
| [user\_candidate](user\_candidate.md) |This table will hold user candidate secrets| 389 |
| [UserGroup](UserGroup.md) |Secondary user groups| 59 |
| [UserGroupLink](UserGroupLink.md) |Link table between associate and usergroup, specifies secondary group membership. From SIX an associate may belong to more than one usergroup. Http://techdoc.superoffice.com has more information about how roles are implemented.| 60 |
| [UserPreference](UserPreference.md) |Preference system. If deflevel is set to 5; the user may change the preferences| 56 |
| [UserRoleLink](UserRoleLink.md) |Link between user role and user| 192 |
| [VisibleFor](VisibleFor.md) |Visible for rights, who may see this appointment/document, sale,  salehist or selection| 196 |
| [WebAppUsage](WebAppUsage.md) |Usage statistics for web applications| 249 |
| [Webhook](Webhook.md) |Webhook URL to call when events occur in the client or in NetServer. Also tracks call+error statistics.| 487 |
| [WinPosSize](WinPosSize.md) |Stores the position and size of each window, so they can be shown in the same place again| 208 |
| [word\_relations](word\_relations.md) |This table shows which word are used in which FAQ entry, and how many times            they are used in each| 355 |
| [wsdl\_description](wsdl\_description.md) |Soap wsdl files| 357 |
| [ziptocity](ziptocity.md) |Zip codes and city names. Zip codes used during address entry. You will find more information about addressformat on http://techdoc.superoffice.com | 16 |

