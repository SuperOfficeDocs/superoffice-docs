---
uid: database-whats-new-10.2.9.778
title: What's new in version 10.2.9.778
description: What's new in database version 10.2.9.778.
so.generated: true
keywords: database
so.topic: reference
so.envir: onsite, online
---

# Released database changes in version 10.2.9.778

## SuperOffice

* Modify table CacheTables
subKeyId
* Modify table ImportRelation
foreignKey
* Remove table HeadingTemp

**Step 18**

Clear out orphan person records (contact_id != 0, no such contact record exists), as well as email, phone, address and udef records that point to nonexistent parents

* Modify table person
* Modify table phone

**Step 19**

Add fields and attributes to support the Soft Delete feature on person and contact tables

* Modify table Contact
DeletedDate
* Modify table Person
DeletedDate

**Step 20**

Support Saint V2, with more entities and enable/disable

* Add table SaintConfiguration
* Modify table StatusDef
generationStart, lastGenerated

**Step 23**

Add UserName to Associate

* Modify table Associate
userName

**Step 26**

Minor update in ZipCity; update of preference descriptions; update of FI address layout; update of SuperOffice data for SW, DA, GE


**Step 27**

Preference Description update with Service mappings and new rank/group fields; also cleanup of obsolete Counter preferences (#63450)

* Modify table PrefDesc
rank, subGroup, minLevel

**Step 28**

Add the Tags MDO list, a new Function Right to directly define tags, and assign that right to List and General admins

* Add table Tags
* Add table TagsGroupLink
* Add table TagsHeadingLink

**Step 29**

Reload the CacheTabs table, to add new lists


**Step 30**

It is now possible to turn off trailing-whitespace trimming of string fields in the database; and specify this and TimeZone processing in a generic manner

* Modify table appointment
do\_By, done, endDate, activeDate
* Modify table recurrenceRule
startDate, endDate
* Modify table email\_folder
name

**Step 31**

Preference descriptions for the R project


**Step 32**

Transfer any password rules set in the now-obsolete preference System/PasswordPolicy into the password_rules table with id=1


**Step 33**

Add 4 fields to DocTemplate table to support Email-templates and prime in 1 row in UdListDefinition table to declare Email templates as a list

* Modify table DocTmpl
includeSignature, showCurrents, senderEmailMode, senderEmailAddress

**Step 34**

Re-add the Tags MDO list in UdListDefinition table.


**Step 35**

Preference descriptions for the R project


**Step 36**

New classifier fields to enabled personalized and source-bound archive layouts

* Modify table SuperListColumnSize
ownerTable, ownerRecord, group\_id, configurationName

**Step 37**

Preference descriptions for invitation support


**Step 38**

Preference descriptions for invitation support and cleanup of UserPreference table


**Step 39**

New preference: default appointment type for incoming invitations


**Step 40**

This step has been made obsolete by later changes


**Step 41**

This step has been made obsolete by later changes


**Step 42**

Updated preferences, and translated name of functional right to create Tags


**Step 43**

Updated ZipCity for Norway


**Step 44**

Add a table to keep historical information related to deleted associates

* Add table AssociateHistory

**Step 45**

Add a field snum to table document, and cautionWarning to appointment

* Modify table Document
snum
* Modify table Appointment
cautionWarning

**Step 46**

Updated preferences


**Step 47**

Update preferences priming; add a virtual field on person (dotsyntax); populate the new Main Contact field on all contact records

* Modify table person
emailBounceCount
* Modify table contact

**Step 48**

Add fields for language and sentiment to ej_message; Update preferences priming: move the EmailBounceThreshold preference from the System section to the Mail section

* Modify table ej\_message
language, sentiment, sentimentConfidence

**Step 49**

Add fields for language and sentiment to ej_message; Update preferences priming: move the EmailBounceThreshold preference from the System section to the Mail section

* Modify table ej\_message
suggestedCategory\_id

**Step 50**

Fix inconsistent Main Contact (supportPersonId) after bug in Sales.Web GUI


**Step 51**

Add a virtual field on contact (dotsyntax)

* Modify table contact
emailBounceCount

**Step 52**

Add 1 field to DocTemplate table to support Invitation type templates

* Modify table DocTmpl
invitationDocType, privacyDocType

**Step 53**

Update Red Letter Days, table is overwritten, adding Red days for 2005-2030 for 23 countries


**Step 54**

Add a virtual field on person and contact (dotsyntax): emailLastBounce

* Modify table contact
emailLastBounce
* Modify table person
emailLastBounce

**Step 55**

Reset bounceCount and lastBounce on the Email table for rows where lastBounce is before the start of year 2020


**Step 56**

Remove several sections and some individual preferences, that were only relevant to the Windows client. 
Remove never-used fields in searchcriterionvalue and replace with a string field for valueType

* Modify table searchcriterionvalue
valueType, valueDataType
* Modify table searchcriterionvalue
valueType

**Step 57**

Add TimeSpan=Minutes markers to relevant fields on the ticket, ej_message, invoice and ticket_priority tables; controls behaviour in Archives including Selection

* Modify table ticket
* Modify table ej\_message
time\_spent, time\_charge
* Modify table invoice
time\_charged
* Modify table ticket\_priority
deadline
* Modify table ticket\_status\_history
timespan, real\_timespan
* Modify table appointment
done, do\_by, activeDate, endDate
* Modify table text
updatedCount

**Step 58**

Update SOCompany information for new Online databases based on what is in the template and what data is wanted spring 2020


**Step 60**

Add mother_associate_id to appointments to optimize logic that depends on the owner of the mother appointment

* Modify table appointment
mother\_associate\_id

**Step 61**

Add soundex field to freetext words table to enable soundex searching

* Modify table freetextwords
word, soundEx
* Modify table freetextindex
contact\_id

**Step 62**

New preference for disabling Image editor in Unlayer mailings editor


**Step 63**

New functional right for hiding Service and Mailings button and screen


**Step 64**

New preference for invitations, no tentative appointments for others


**Step 65**

New preference for mailing, disable image library for royalty-free images


**Step 66**

Add starting 0 to german zipcodes where it missed. Update N_List for US, remove duplicate MrMrs.


**Step 67**

, Remove duplicate of LowerLimitsaletypecat, new preference for mailing, disable image library for royalty-free images, translations


**Step 68**

New preference for document dialog in SOFO (and possible later OML, GmailLink and WEB)


**Step 69**

Update some languageinfo and languageinfocountry for correct detecting of language for GDPR confirmation mail. Update RedLetterDay and SOCompany address for Germany. Add a zipcode for DK: Orø. Set group for quote documents for new dbs. 


**Step 70**

Added filename field to BatchTask table to be used by ExportArchiveBatchTask.

* Modify table BatchTask
FileName

**Step 71**

New preference for Mailing, DisableFormsPoweredBy. Rename Mailing header to Marketing. Some fixes of quotes to single quotes.


**Step 72**

New field in Document-table for URL to external documents. Should be used internally by DocPlugins only!

* Modify table document
ExtUrl

**Step 73**

Turn on freetext index in online.


**Step 74**

* Add table CacheInvalidation

**Step 75**

New preference: disable export of tile data


**Step 76**

Cleanup LocaleText - Reinsert all data


**Step 77**

Cleanup Prefdesc and prefdescline: Only partner-added rows are left, all SuperOffice-maintained preferences are now described in code


**Step 78**

Updated ZipToCity for Norway and Sweden


**Step 79**

New complete LocaleText - with new ticket notifications


**Step 80**

LocaleText - with LanguageRows for detection of supported GUI languages 


**Step 81**

Add functional right 'Lock / Unlock Target Assignment' 


**Step 82**

Index names for extrafields need to be as the Service code creates them; SDB import did not conform. This step will locate and rename any wrongly-named physical indexes (only applicable to databases that have been SDB-imported).
There was also another bug where index-creation logic for extrafields was inverted, such that a field would get an index when it should not have, and vice versa. This is also corrected, both ways.


**Step 83**

Historically, extra-fields of type 'long text' where 'ntext' in Sql Server. This data type is obsolete and such steps will be converted to 'nvarchar(max)', though without reallocating storage space as that might take a long time depending on the amount of data


**Step 84**

Update translations for functional right 'Can lock and unlock target assignment'


**Step 85**

New fields in QuoteVersion-table for use when requesting quote approval

* Modify table QuoteVersion
request\_associate\_id, request\_comment

**Step 86**

New list tables to define quote approval and quote denied reasons

* Add table QuoteApprReason
* Add table QuoteApprReasonGroupLink
* Add table QuoteApprReasonHeadingLink
* Add table QuoteDenyReason
* Add table QuoteDenyReasonGroupLink
* Add table QuoteDenyReasonHeadingLink

**Step 87**

Add quote approval push notification texts


**Step 88**

Add functional right 'Targets Administrator' 


**Step 89**

Add phone description and searchphone fields to freetext index

* Modify table phone
description, searchPhoneNumber

**Step 90**

Reset possible flag that says TAGS list is MDO grouped - not supported and should always be off


**Step 91**

Change code-generation flags for the ticket and ej_message tables, to give a custome Row implementation in NetServer. No changes to physical DB schema.

* Modify table ticket
* Modify table ej\_message

**Step 92**

Add invitation declined push notification texts


**Step 93**

Update userpreference for Mirroring rows.Technical update of some imp files. 


**Step 95**

Correct a red date for UK.


**Step 96**

Update SOCompany information for new Online databases based on data wanted december 2022


**Step 97**

Updated descriptions for UserCandidate fields. This removes the need to define descriptions further up in the carrier etc.

* Modify table user\_candidate
person\_id, secret\_key, secret\_value

**Step 98**

This table will contain the number of different entities an associate has created for usage statistics

* Add table EntityCounts

**Step 99**

Repair missing ForeignKey relations for person.associate_id and person.group_id


**Step 100**

Update SOCompany information for new Online databases based on data wanted april 2023


**Step 101**

Add composite index to avoid sql server making a very poor decisions in query execution of appointment conflict detector queries

* Modify table appointment

**Step 102**

Mark udef number fields as freetext index sources.

* Modify table udcontactSmall
* Modify table udpersonSmall
* Modify table udappntsmall
* Modify table uddocsmall
* Modify table udprojectSmall
* Modify table udsalesmall

**Step 103**

Correct spelling for danish city Aarhus


**Step 104**

FreetextWords and FreetextIndex tables used random primary keys during incremental indexing. This is now changing to ordinary PK's from the sequence table. During the transition we need to "make room at the top" of the id space, to ensure we avoid collisions until the next full reindexing


## chat

* Modify table chat\_topic
* Modify table chat\_topic\_user
can\_respond, notifications, can\_listen, manager
* Modify table chat\_session
name, company\_name, email, phone, first\_message, last\_message, flags
* Modify table chat\_message
created\_by
* Modify table ejuser
chat\_status

**Step 2**

* Modify table chat\_topic
widget\_language
* Modify table cust\_lang
iso\_code

**Step 3**

* Modify table chat\_session
project\_id, sale\_id, ticket\_id, contact\_id, transfer\_to
* Modify table config
feature\_toggle

**Step 4**

* Modify table login\_customer
created\_at
* Add table quick\_reply

**Step 6**

* Modify table chat\_session
consented

**Step 7**

* Modify table chat\_topic

**Step 8**

Adding field for using a custom message in the chat widget queue message

* Modify table chat\_topic
custom\_queue\_text

**Step 9**

Add CS language to chat_session table. Specify displayField to chat_topic table.

* Modify table chat\_session
* Modify table chat\_topic

**Step 10**

Add index on the chat_session table, to optimize the 'anything happening now?' requests that come in every 15 seconds, per service rep

* Modify table chat\_session

**Step 11**

* Modify table chat\_topic
flags

**Step 12**

* Modify table chat\_session
status
* Modify table chat\_message
type, special\_type

**Step 13**

* Modify table chat\_topic
bot\_enabled, bot\_name, bot\_register\_trigger\_id, bot\_newsession\_trigger\_id, bot\_statechange\_trigger\_id, bot\_newmessage\_trigger\_id
* Modify table chat\_session
chatbot\_isactive

**Step 14**

* Modify table chat\_topic
bot\_register\_trigger\_id, bot\_newsession\_trigger\_id, bot\_statechange\_trigger\_id, bot\_newmessage\_trigger\_id, bot\_register\_scriptid, bot\_session\_created\_scriptid, bot\_session\_changed\_scriptid, bot\_message\_received\_scriptid

**Step 15**

Add fields for setting lunch hours on a chat topic.

* Modify table chat\_topic
use\_lunch\_hours, lunch\_start, lunch\_stop

**Step 16**

Add more fields to chat_topic for agent use firstname.

* Modify table chat\_topic
widget\_agent\_use\_firstname

**Step 17**

Add suport for country in chat_session.

* Modify table chat\_session
country

**Step 18**

Add notification interval for new chat messages in chat_topic.

* Modify table chat\_topic
warning\_chat\_message, manager\_warning\_chat\_message

**Step 19**

Add fields for enabling offline form capabilites when customer is in chat queue.

* Modify table chat\_topic
offline\_form\_time\_limit, offline\_form\_queue\_length

**Step 20**

Add fields for support rating of a chat session.

* Modify table chat\_topic
widget\_enable\_rating, widget\_rating\_text
* Modify table chat\_session
rating

**Step 21**

Add field for chat widget badge color

* Modify table chat\_topic
widget\_badge\_color

**Step 22**

Add field for chat widget styles

* Modify table chat\_topic
widget\_badge\_text\_color, widget\_cust\_msg\_color, widget\_cust\_msg\_text\_color, widget\_agent\_msg\_color, widget\_agent\_msg\_text\_color, widget\_font\_size, widget\_button\_color, widget\_button\_text\_color

## configurablescreens

This table will contain deltas for configurable screens to add and remove from recipes in SCIL

* Add table ConfigurableScreenDelta

**Step 2**

Added state enum for draft and published state for the json recipe deltas

* Modify table ConfigurableScreenDelta
deltaState

**Step 3**

Clear out all rows in SystemEvent, in preparation for a unique index to be defined


**Step 4**

Create unique index on SystemEvent, to support multi-user-safe event locking

* Modify table SystemEvent

**Step 5**

This table will contain a mapping on which type of data (appliesToKey) will be used to differ between layouts in the given recipeId 

* Add table ConfigurableScreenAppliesTo

**Step 6**

This table will contain list items for merging in as menu items in taskmenus

* Add table TaskMenu
* Add table TaskMenuGroupLink
* Add table TaskMenuHeadingLink

**Step 7**

Added enocding enum ANSI UniCode or None

* Modify table TaskMenu
encoding

**Step 8**

Move webpanels that are actually task menu items to new table taskmenu


## ConsentManagement

* Modify table category
family\_id

**Step 6**

* Modify table Category
family\_id
* Remove table consent\_person
* Remove table consent\_purpose
* Remove table ConsentSource
* Remove table LegalBase
* Remove table category\_family
* Add table ConsentPurpose
* Add table LegalBase
* Add table ConsentSource
* Add table ConsentPerson
* Add table CategoryFamily
* Modify table DocTmpl
privacyDocType, emailSubject
* Modify table Category
CategoryFamily\_id

**Step 7**

* Modify table outbox
rfc822\_content

**Step 10**

* Modify table ConsentPerson

**Step 11**

* Modify table ConsentPerson
* Modify table ConsentPerson
* Modify table ShipmentTypeReservation
* Modify table ConsentPurpose
* Modify table ConsentSource
* Modify table LegalBase
* Modify table ShipmentType

**Step 12**

* Modify table ErpConnection
ConsentSourceId, LegalBaseId

**Step 13**

* Modify table ErpConnection
ConsentSourceId, LegalBaseId

**Step 14**

Set the #STORE consent on all person records that do not already have it; we assume that all persons in the customers database are there for a legitimate reason


**Step 16**

As we now set the #STORE consent on all person records that do not already have it, we also set a default consent and legal base for new persons, thus we set the Default legal base preference.


**Step 22**

Remove confirmation mail links for consent sources where SuperOffice does not send privacy confirmation email by design.


**Step 23**

Update document template to sync emailmode with privacytype


## CRMScript

* Add table script\_trace
* Add table script\_trace\_run
* Modify table screen\_chooser
description, enabled

**Step 2**

* Modify table ejscript
extra\_menus\_id

**Step 3**

* Modify table ejscript
unique\_identifier, registered, registered\_associate\_id, updated, updated\_associate\_id, updatedCount
* Modify table screen\_chooser
unique\_identifier, registered, registered\_associate\_id, updated, updated\_associate\_id, updatedCount

**Step 4**

Flag unique_identfier fields that they should be auto-populated with a GUID on creation; and populate existing rows with GUID's

* Modify table ejscript
unique\_identifier
* Modify table screen\_chooser
unique\_identifier

**Step 5**

Create unique indexes for GUID identifiers

* Modify table ejscript
unique\_identifier
* Modify table screen\_chooser
unique\_identifier

**Step 6**

New flag field in screen_definition: autosave

* Modify table screen\_definition
autosave

**Step 7**

Fix triggers with screen_type = 130. Set to 113 and disable.


**Step 8**

Adds a type field to the ej_script table, to indicate what type of script this is.

* Modify table ejscript
type

**Step 9**

Adds a frames field to the script_trace_run table to contain the JSON frames of the trace.

* Modify table script\_trace\_run
frames

## CS

* Modify table ticket
from\_address

**Step 3**

* Modify table s\_message
long\_description

**Step 4**

* Modify table ticket\_status
status
* Modify table ticket\_priority
status, flags, ticket\_read, changed\_owner, ticket\_newinfo, ticket\_closed, ticket\_changed\_priority, ticket\_new
* Modify table ej\_category
delegate\_method, closing\_status, msg\_closing\_status, flags

**Step 5**

* Modify table ticket
status, slevel, origin, read\_status
* Modify table ticket\_status
status

**Step 6**

* Modify table ej\_message
slevel, type, message\_category

**Step 7**

Adding a field to ej_message, allowing the user to filter and view only important messages

* Modify table ej\_message
important

**Step 8**

Add a ForeignKeyArray field to the ticket table as the first entity to use Tags; and add a contact_id to start off that project

* Modify table Ticket
tags, contact\_id

**Step 9**

Transfer mobile phone from ticket to person if no phone on person


**Step 10**

Set ticket.contact_id to be consistent with ticket.cust_id.contact_id; and copy the person classifiers (associate_id, group_id, business_idx, category_idx) from contact to person unless person.contact_id = 0


**Step 11**

Add flags to s_list_element table.

* Modify table s\_list\_element
status

**Step 12**

Create new table, attachment_location, to be able to store attachments in multiple locations

* Add table attachment\_location
* Modify table attachment
attachment\_location\_id

**Step 13**

Create and enable password rules if they have not been changed from the default


**Step 14**

Add field for storing Mailgun DSN setting for each mailbox

* Modify table mail\_in\_filter
mailgun\_dsn

**Step 15**

Add sentiment and language values to ticket table. Add index on ej_message.created_at

* Modify table ej\_message
* Modify table ticket
language, sentiment, sentimentConfidence

**Step 16**

Move ej_message.suggestedCategory_id to the ticket table. Add ticket.orig_human_category_id

* Modify table ej\_message
suggestedCategory\_id
* Modify table ticket
suggestedCategory\_id, origHumanCategory\_id

**Step 17**

Add details clob to ticket_log_action table for JSON logging


**Step 18**

Change type of mail_in_filter.server_type to a defined enum called MailboxType

* Modify table mail\_in\_filter
server\_type

**Step 19**

Stage 1 of 3: Introduce proper ForeignKey fields for ej_category: closing_status and msg_closing_status, and populate them

* Modify table ej\_category
closing\_status\_temp, msg\_closing\_status\_temp

**Step 20**

Stage 2 of 3: Drop old fields for ej_category: closing_status and msg_closing_status

* Modify table ej\_category
closing\_status, msg\_closing\_status

**Step 21**

Stage 3 of 3: Rename new fields for ej_category: closing_status_temp and msg_closing_status_temp to original names

* Modify table ej\_category
closing\_status\_temp, msg\_closing\_status\_temp

**Step 22**

Add fields for enabling/disabling AI operations on a Service mailbox

* Modify table mail\_in\_filter
ai\_suggest\_category, ai\_text\_analysis

**Step 23**

Change ticket notification expiry from 10 minutes to 24 hours


**Step 24**

Add support for setting tags on email filter

* Modify table ms\_filter
new\_tags

**Step 25**

Add field for setting an URL on custom notifications

* Modify table notify
custom\_url

**Step 26**

Increase the length of the field inbox.uidl

* Modify table inbox
uidl

**Step 28**

* Modify table reply\_template\_body
flags
* Modify table reply\_template
flags

**Step 29**

Mark Ticket fields as freetext indexable.

* Modify table ticket
title, author, from\_address

**Step 30**

Add changed_at and changed_by fields to EjMessage table.

* Modify table ej\_message
changed\_at
* Modify table ej\_message
changed\_by

**Step 31**

Add sale_id, project_id to Ticket table.

* Modify table ticket
sale\_id, project\_id

**Step 32**

Add IsDefinedByUserGroup field to CATEGORY_MEMBERSHIP table.

* Modify table category\_membership
is\_defined\_by\_usergroup, weight

**Step 33**

Increase the length of the field ej_message.message_id to 850 (as this is max size for an indexed field).

* Modify table ej\_message
message\_id

**Step 34**

Interprets TicketLogAction table's LogAction field as enum instead of int

* Modify table ticket\_log\_action
log\_action

**Step 35**

Adds badge column to explicitly determine how a message was generated

* Modify table ej\_message
badge

**Step 36**

Add registered and registered_associate_id fields to Notify table

* Modify table notify
registered, registered\_associate\_id

**Step 37**

Mark Ticket status field as freetext indexable.

* Modify table ticket
status

**Step 38**

Add time_spent field to Ticket table

* Modify table ticket
time\_spent

**Step 39**

This step has been superseded by a later step

* Modify table ticket
ticket\_type, request\_type

**Step 40**

Remove priming data for RequestType list that we wish to move to another table


**Step 41**

Remove tables for never-implemented TicketType functionality. The motivation is to clear out junk, as well as keep a consistent naming scheme for ticket functionality

* Modify table ticket\_type
* Modify table ticket\_relation\_type
* Modify table ticket\_relation\_action
* Modify table ticket\_relation
source, target, relation\_type, registered, registered\_associate\_id, updated, updated\_associate\_id, updatedCount
* Remove table request\_type
* Remove table request\_type\_priority
* Remove table request\_type\_status
* Modify table ticket
request\_type
* Rename table ticket\_type to obsolete\_1
* Rename table ticket\_relation\_type to obsolete\_2
* Rename table ticket\_relation\_action to obsolete\_3
* Rename table ticket\_relation to obsolete\_4

**Step 42**

Re-create the tables needed for the new ticket_type functionality

* Add table ticket\_type
* Add table ticket\_type\_priority
* Add table ticket\_type\_status
* Modify table ticket
ticket\_type

**Step 43**

Adjust tables and priming data needed for the new ticket_type functionality

* Modify table ticket\_type
deleted

**Step 44**

Add TimeSpan=Minutes marker to ticket.time_spent column; controls behaviour in Archives including Selection

* Modify table ticket
time\_spent

**Step 45**

Remove primary key constraint from now-obsolete tables, to prevent faults during Database Mirroring. Only relevant for Online


**Step 46**

Add ticket_type.is_default column and insert the first, default, request type

* Modify table ticket\_type
is\_default

## customerCenter

Create new table for storing customer center styling and configuration options

* Add table cust\_config

**Step 2**

Prime in default Customer Center Config


**Step 3**

Create cc_template table for customer center templates

* Add table cc\_template

## dashboard

Add tables for Dashboard V2, these will store info about dashboards and dashboard tiles

* Add table dashboard
* Add table dashboard\_theme
* Add table dashboard\_tile\_definition
* Add table dashboard\_tile
* Add table dashboard\_tile\_field

**Step 2**

Add rank to tiles

* Modify table dashboard\_tile
rank

**Step 3**

Add selection foreign key, currency and more to tile definition

* Modify table dashboard\_tile\_definition
selection\_id, currency\_id, currency\_mode, sort\_by, measure, measure\_field

**Step 4**

Add visible for, pinning, and more

* Modify table dashboard\_tile\_definition
secondary\_selection\_id, layout\_config, entity\_name
* Modify table dashboard
visible\_for\_all, visible\_for\_associates, visible\_for\_groups, pin\_for\_all, pin\_for\_associates, pin\_for\_groups

**Step 5**

Add rank to DashboardTheme

* Modify table dashboard\_theme
rank

**Step 6**

Add functional right


**Step 7**

Remove fulltext indexing generated by the FkArray datatype. FT indexing is good for large tables, but is asynchronous and that creates some headaches

* Modify table dashboard

**Step 8**

Add columns to dashboard

* Modify table dashboard
columns

**Step 9**

Add measure_by_field column to dashboard

* Modify table dashboard\_tile\_definition
measure\_by\_field

**Step 10**

Add dashboard_tile_definition_id foreign key to selection

* Modify table selection
dashboard\_tile\_definition\_id

**Step 11**

Add client column to dashboard_theme table

* Modify table dashboard\_theme
client

**Step 12**

Prime default data

* Modify table dashboard\_theme
isBuiltIn
* Modify table dashboard
guid

**Step 13**

Add currency_code to DashboardTileDefinition

* Modify table dashboard\_tile\_definition
currency\_id, currency\_code

**Step 14**

Set the required attributes to activate Sentry functionality on dashboard, dashboard_tile and dashboard_tile_definition. Update DashboardTheme with new font colors for dark themes.

* Modify table dashboard
* Modify table dashboard\_tile
* Modify table dashboard\_tile\_definition

**Step 15**

Update dashboard theme data with fixed IDs


**Step 16**

Generate Dataright rows for the new Dashboard, in the data right matrix in Admin


**Step 17**

Add 'style' to DashTheme

* Modify table dashboard\_theme
style

**Step 18**

Update big number colors in dark mode for built-in dashboard themes


**Step 19**

Update DashboardTileDefinition with information about where it can be used

* Modify table dashboard\_tile\_definition
usage

**Step 20**

Update colors for stalled and open sales in dashboards.


## forms

* Add table form
* Add table form\_submission

**Step 2**

* Modify table form
active, expires, maxSubmits

**Step 3**

* Modify table form
type

**Step 4**

* Modify table form
recipe

**Step 5**

* Modify table form\_submission
is\_submitted

**Step 6**

* Modify table form\_submission
is\_submitted, status, processing\_log

**Step 7**

* Modify table form
group\_id

**Step 8**

* Modify table ticket
form\_submission\_id

**Step 9**

* Modify table form
form\_key

**Step 10**

Create new field to be able to filter out forms that are used to creating tickets

* Modify table form
new\_ticket

## inbox

* Add table email\_account
* Add table email\_folder
* Add table service\_auth
* Add table email\_item

**Step 2**

* Modify table email\_item

**Step 3**

* Modify table email\_item
replied\_at, in\_reply\_to, messageId
* Modify table email\_account
default

**Step 4**

* Modify table email\_account
account\_status
* Modify table email\_item
cc
* Modify table service\_auth
associate\_id, auth\_status

**Step 5**

* Modify table timestamps
mailsync

**Step 6**

* Modify table email\_account
email\_address
* Modify table email\_folder
account\_id

**Step 7**

* Modify table email\_account
encryptedCheck, associate\_id, incoming\_auth, outgoing\_auth
* Modify table service\_auth
encryptedCheck, associate\_id, server, port, auth\_type, username, password

**Step 8**

* Modify table email\_account
error\_count, error\_reason
* Modify table email\_item
* Add table email\_attachment

**Step 9**

* Modify table email\_folder
folder\_separator

**Step 10**

* Modify table email\_item
cal\_data

**Step 11**

Ensure all email-IDs used as foreignkeys in the foreignkey-table are enclosed in tags. Update all rows as needed, in one operation


## invitation

Adds support for invitations (iCal) leading to appointments

* Add table invitation
* Modify table email
appointment\_id

**Step 2**

Allows for storage of the organizer's email and full name in the table; Adds support for recurring invitations.

* Modify table invitation
organizer\_email, organizer\_fullname, recurring\_end\_date

**Step 3**

Set preference "Diary sync active" if Infobridge synchronizer seem to be in use.


**Step 4**

Adds support for modifications of single appointments in a recurring series.

* Modify table invitation
recurring\_start\_date
* Modify table erpexternalkey

**Step 5**

Adds better support for modifications of single appointments in a recurring series.

* Modify table appointment
original\_start\_date

## Mailings

Adding field to store the document mailing recipient sort order

* Modify table s\_shipment
sorting

**Step 2**

Add fields for storing the design of a mailing message and mailing design type

* Modify table s\_message
design, designtype
* Add table s\_messageblock
* Modify table s\_message
flags

**Step 3**

Remove the old SOEditor mailing templates for new Online installations


**Step 4**

Change type of S_Shipment.Status to a defined enum called ShipmentStatus and change type of (S_Link_Customer/S_Link_Customer_Statical).LinkType to ShipmentLinkType.

* Modify table s\_shipment
status
* Modify table s\_link\_customer
link\_type
* Modify table s\_link\_customer\_statical
link\_type

**Step 5**

Add field for storing foreign key to form_submission in s_shipment_addr. This is used to connect a mailing recipient with a form_submission, to be used to populate the parser.

* Modify table s\_shipment\_addr
form\_submission\_id

**Step 6**

Add two new fields so s_shipment_addr and Email for storing bounce code and bounce reason as separate fields.

* Modify table s\_shipment\_addr
bounce\_code, bounce\_reasontag, cleaned
* Modify table Email
lastBounceCode, lastBounceReason

**Step 7**

Add fields to s_shipment for cached statistical values

* Modify table s\_shipment
* Modify table s\_link\_customer\_statical
* Modify table s\_link\_customer
* Modify table s\_shipment\_addr

**Step 8**

Remove are_statistics_dirty from s_shipment, we want it to be NOT NULL with a DEFAULT (see next step)

* Modify table s\_shipment
are\_statistics\_dirty

**Step 9**

Add are_statistics_dirty to s_shipment, with a NOT NULL and a DEFAULT of 1 (true)

* Modify table s\_shipment
are\_statistics\_dirty

**Step 10**

Creates a new List called MailingDomains. The table will contain entries consisting of domain addresses, which can be used for enforcing a mailing to use one of these in the senders email address.

* Add table MailingDomains

**Step 11**

Add sent_num field to s_shipment for cached statistical values

* Modify table s\_shipment
sent\_num

## NewFollowupDialog

Changes length of text-field in Text-table, and adds html_text-field. Adds agenda_text_id and internal_notes_text_id to appointment.

* Modify table text
text, html\_text
* Modify table appointment
agenda\_text\_id, internal\_notes\_text\_id

## NewSelection

The typical search table is an owner of a set of predefined selection criteria


**Step 2**

Cleanup after initial (obsolete) table definition

* Remove table TypicalSearch

**Step 3**

Define the TypicalSearch table from scratch

* Add table TypicalSearch

**Step 4**

Cleanup 'temporary selection' marking by introducing the IsTemporary field

* Modify table selection
SystemType

**Step 5**

Add fields to table selection for more functionality. Also update the default sidepanel view for all pages, in userpreference

* Modify table selection
chartKey, lastLoaded, lastLoadedBy, lastMembershipChange, lastMembershipChangeBy

**Step 6**

SelectionForFind creates a dynamic selection for each entity/associate as needed; they were missing the required VisibleFor row; those are added here


**Step 7**

Update targetTableNumber to 5 where it was 0, and reset membercounts to -1 where we have no recent data


**Step 8**

Due to limitations in the Windows code stack, the chartKey field is shortened to 254 characters

* Modify table selection
chartKey

## Notifications

Adds modified_appointment_fields field to appointment, and defines related ModifiedAppointmentFields enum.

* Modify table appointment
modified\_appointment\_fields

**Step 2**

Add index on appointment, fields: type, activeDate for efficient queries

* Modify table appointment

## Online

Add table OnlineApp, to echo information about authorizations and usage. Optimize indexes for userpreference table, based on Ops data

* Add table OnlineApp
* Modify table userpreference
* Modify table userpreference

## Optimization

* Modify table TravelTransactionLog
* Modify table ForeignKey

**Step 2**

Deleting obsolete counter-preferences


## Pocket

* Add table PushNotificationService

**Step 2**

* Modify table PushNotificationService
Language

**Step 3**

* Modify table PushNotificationService
PocketVersion, OSVersion

**Step 5**

Adding rank field to favourites

* Modify table Favourite
Rank

**Step 6**

Add TimeZoneId field to PushNotificationService, so notifications can use the recipients preferred timezone

* Modify table PushNotificationService
TimeZoneId

## R_Service

Add field for storing flags on a service login session

* Modify table login
flags

**Step 2**

Change value of registry entry for maximum width of components


**Step 3**

Make sure the row with id=1 in ejuser contains the '(System)' user


## SubscriptionMgmt

* Add table MailingType
* Add table MailingTypeReservation
* Modify table s\_shipment
mailingtype\_id

**Step 3**

* Add table TemporaryKey

**Step 5**

* Modify table MailingTypeReservation
MailingType\_id
* Modify table s\_shipment
mailingtype\_id
* Rename table MailingType to ShipmentType
* Modify table ShipmentType
MailingType\_id
* Rename table MailingTypeReservation to ShipmentTypeReservation
* Modify table ShipmentTypeReservation
MailingTypeReservation\_id, MailingType\_id
* Modify table s\_shipment
mailingtype\_id

**Step 6**

* Modify table ShipmentTypeReservation

## SuperId

* Modify table associate
waiting\_for\_approval

**Step 2**

* Modify table associate
waiting\_for\_approval

**Step 3**

* Modify table associate
waiting\_for\_approval

## targets

Add tables for Targets (Sales, Project, Selection....


**Step 2**

Some further normalization

* Remove table target\_group
* Remove table target\_period
* Remove table target\_period\_assignment
* Add table target\_group
* Add table target\_period
* Add table target\_assignment\_info
* Add table target\_assignment\_value

**Step 3**

Generate Dataright rows for Targets, in the data right matrix in Admin


**Step 4**

Add tables for Targets revision history

* Add table target\_revision\_history
* Add table target\_revision
* Add table target\_change

**Step 5**

Support larger values than 2 billion and log more revision details

* Modify table target\_revision\_history
target\_assignment\_info\_id, target\_group\_id
* Modify table target\_assignment\_value
target\_value2
* Modify table target\_change
value\_change\_from2, value\_change\_to2

**Step 6**

Remove old value fields

* Modify table target\_assignment\_value
target\_value, target\_value2
* Modify table target\_change
value\_change\_from, value\_change\_to, value\_change\_from2, value\_change\_to2

**Step 7**

Support for new dimensions in targets system

* Add table target\_dimension
* Modify table target\_group
target\_dimension\_id
* Modify table target\_assignment\_info
target\_dimension\_item\_id

**Step 8**

List field rename

* Modify table target\_dimension
dimension\_list

## Webhooks

The **Webhook** table keeps track of the **Target\_URL** where we will dispatch HTTP POST notificationsof events that happen in SuperOffice. The webhook state should be ACTIVE(1). If too many errors are received when we try to POST to the TargetUrl, then the webhook state is changed to TOO-MANY-ERRORS(3).

* Add table Webhook

**Step 2**

The **Webhook_usage** table keeps track of How many calls/errors a webhook has encountered. Moved off the main **Webhook** table to avoid disturbing Webhook cache.

* Add table Webhook\_usage

**Step 3**

Remove the old usage fields from the webhooks table after the usage has been copied to the new webhook_usage table.

* Modify table Webhook
total\_calls, total\_errors, consecutive\_errors, last\_error

**Step 4**

The **errors_email** field tracks where to send an e-mail when NetServer receives too many errors trying to notify a webhook.

* Modify table Webhook
errors\_email

## Workflows

Add tables for Workflows (email flows etc.)

* Add table workflow
* Add table email\_flow
* Add table workflow\_instance
* Add table workflow\_goal
* Add table workflow\_step
* Add table workflow\_trigger

**Step 2**

Add step rank

* Modify table workflow\_step
Rank

**Step 3**

Add hierarchy_id (folder structure)

* Modify table email\_flow
hierarchy\_id

**Step 4**

Email settings on email flow

* Modify table email\_flow
* Modify table workflow\_instance
next\_step, wait\_until

**Step 5**

Workflow settings for start, stop, remove from flow

* Modify table workflow
use\_workflow\_start, workflow\_start, use\_enrollment\_end, enrollment\_end, tzLocationId, remove\_from\_flows
* Modify table email\_flow
tzLocationId

**Step 6**

Workflow blocklist and more

* Modify table workflow
block\_lists
* Modify table email\_flow
from\_type, reply\_to\_type

**Step 7**

WorkflowStepOptions and Reply-To name

* Modify table workflow\_step
parent\_workflow\_step\_id
* Modify table email\_flow
reply\_to\_name
* Add table workflow\_step\_option
* Add table workflow\_step\_option\_link

**Step 8**

Email flow content (connected message assets)

* Add table email\_flow\_content\_link

**Step 9**

Store datetimes as UTC and disable automatic time zone conversion


**Step 10**

Locking system for concurrency control needed by workflows (and others)

* Add table temp\_db\_lock

**Step 11**

Workflow instance fields added

* Modify table workflow\_instance
next\_step, last\_communication\_step, dropout\_reason, step\_started, step\_level

**Step 12**

Linking s_shipment_addr to workflow step and workflow instance to track responses

* Modify table s\_shipment\_addr
workflow\_step\_id, workflow\_instance\_id

**Step 13**

Indexing new foreign keys on s_shipment_addr

* Modify table s\_shipment\_addr

