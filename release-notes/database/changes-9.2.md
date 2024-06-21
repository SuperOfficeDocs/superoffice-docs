---
uid: database-whats-new-92
title: What's New
description: What's new in the latest database version.
generated: true
keywords:
  - "database"
date: 03.22.2021
topic: reference
envir:
  - "onsite"
  - "online"
version: 9.2
---
<!-- markdownlint-disable-file MD036 -->

# Released database changes in version 9.8.7717.1401

## SuperOffice

* [Modify table CacheTables](../../docs/en/database/tables/cachetables.md)
subKeyId
* [Modify table ImportRelation](../../docs/en/database/tables/importrelation.md)
foreignKey
* Remove table HeadingTemp

**Step 18**

Clear out orphan person records (contact_id != 0, no such contact record exists), as well as email, phone, address and udef records that point to nonexistent parents

* [Modify table person](../../docs/en/database/tables/person.md)
* [Modify table phone](../../docs/en/database/tables/phone.md)

**Step 19**

Add fields and attributes to support the Soft Delete feature on person and contact tables

* [Modify table Contact](../../docs/en/database/tables/contact.md)
DeletedDate
* [Modify table Person](../../docs/en/database/tables/person.md)
DeletedDate

**Step 20**

Support Saint V2, with more entities and enable/disable

* [Add table SaintConfiguration](../../docs/en/database/tables/saintconfiguration.md)
* [Modify table StatusDef](../../docs/en/database/tables/statusdef.md)
generationStart, lastGenerated

**Step 23**

Add UserName to Associate

* [Modify table Associate](../../docs/en/database/tables/associate.md)
userName

**Step 26**

Minor update in ZipCity; update of preference descriptions; update of FI address layout; update of SuperOffice data for SW, DA, GE

**Step 27**

Preference Description update with Service mappings and new rank/group fields; also cleanup of obsolete Counter preferences (#63450)

* [Modify table PrefDesc](../../docs/en/database/tables/prefdesc.md)
rank, subGroup, minLevel

**Step 28**

Add the Tags MDO list, a new Function Right to directly define tags, and assign that right to List and General admins

* [Add table Tags](../../docs/en/database/tables/tags.md)
* [Add table TagsGroupLink](../../docs/en/database/tables/tagsgrouplink.md)
* [Add table TagsHeadingLink](../../docs/en/database/tables/tagsheadinglink.md)

**Step 29**

Reload the CacheTabs table, to add new lists

**Step 30**

It is now possible to turn off trailing-whitespace trimming of string fields in the database; and specify this and TimeZone processing in a generic manner

* [Modify table appointment](../../docs/en/database/tables/appointment.md)
do\_By, done, endDate, activeDate
* [Modify table recurrenceRule](../../docs/en/database/tables/recurrencerule.md)
startDate, endDate
* [Modify table email\_folder](../../docs/en/database/tables/email-folder.md)
name

**Step 31**

Preference descriptions for the R project

**Step 32**

Transfer any password rules set in the now-obsolete preference System/PasswordPolicy into the password_rules table with id=1

**Step 33**

Add 4 fields to DocTemplate table to support Email-templates and prime in 1 row in UdListDefinition table to declare Email templates as a list

* [Modify table DocTmpl](../../docs/en/database/tables/doctmpl.md)
includeSignature, showCurrents, senderEmailMode, senderEmailAddress

**Step 34**

Re-add the Tags MDO list in UdListDefinition table.

**Step 35**

Preference descriptions for the R project

**Step 36**

New classifier fields to enabled personalized and source-bound archive layouts

* [Modify table SuperListColumnSize](../../docs/en/database/tables/superlistcolumnsize.md)
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

* [Add table AssociateHistory](../../docs/en/database/tables/associatehistory.md)

**Step 45**

Add a field snum to table document, and cautionWarning to appointment

* [Modify table Document](../../docs/en/database/tables/document.md)
snum
* [Modify table Appointment](../../docs/en/database/tables/appointment.md)
cautionWarning

**Step 46**

Updated preferences

**Step 47**

Update preferences priming; add a virtual field on person (dotsyntax); populate the new Main Contact field on all contact records

* [Modify table person](../../docs/en/database/tables/person.md)
emailBounceCount
* [Modify table contact](../../docs/en/database/tables/contact.md)

**Step 48**

Add fields for language and sentiment to ej_message; Update preferences priming: move the EmailBounceThreshold preference from the System section to the Mail section

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
language, sentiment, sentimentConfidence

**Step 49**

Add fields for language and sentiment to ej_message; Update preferences priming: move the EmailBounceThreshold preference from the System section to the Mail section

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
suggestedCategory\_id

**Step 50**

Fix inconsistent Main Contact (supportPersonId) after bug in Sales.Web GUI

**Step 51**

Add a virtual field on contact (dotsyntax)

* [Modify table contact](../../docs/en/database/tables/contact.md)
emailBounceCount

**Step 52**

Add 1 field to DocTemplate table to support Invitation type templates

* [Modify table DocTmpl](../../docs/en/database/tables/doctmpl.md)
invitationDocType, privacyDocType

**Step 53**

Update Red Letter Days, table is overwritten, adding Red days for 2005-2030 for 23 countries

**Step 54**

Add a virtual field on person and contact (dotsyntax): emailLastBounce

* [Modify table contact](../../docs/en/database/tables/contact.md)
emailLastBounce
* [Modify table person](../../docs/en/database/tables/person.md)
emailLastBounce

**Step 55**

Reset bounceCount and lastBounce on the Email table for rows where lastBounce is before the start of year 2020

**Step 56**

Remove several sections and some individual preferences, that were only relevant to the Windows client.
Remove never-used fields in searchcriterionvalue and replace with a string field for valueType

* [Modify table searchcriterionvalue](../../docs/en/database/tables/searchcriterionvalue.md)
valueType, valueDataType
* [Modify table searchcriterionvalue](../../docs/en/database/tables/searchcriterionvalue.md)
valueType

**Step 57**

Add TimeSpan=Minutes markers to relevant fields on the ticket, ej_message, invoice and ticket_priority tables; controls behaviour in Archives including Selection

* [Modify table ticket](../../docs/en/database/tables/ticket.md)
* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
time\_spent, time\_charge
* [Modify table invoice](../../docs/en/database/tables/invoice.md)
time\_charged
* [Modify table ticket\_priority](../../docs/en/database/tables/ticket-priority.md)
deadline
* [Modify table ticket\_status\_history](../../docs/en/database/tables/ticket-status-history.md)
timespan, real\_timespan
* [Modify table appointment](../../docs/en/database/tables/appointment.md)
done, do\_by, activeDate, endDate
* [Modify table text](../../docs/en/database/tables/text.md)
updatedCount

**Step 58**

Update SOCompany information for new Online databases based on what is in the template and what data is wanted spring 2020

**Step 60**

Add mother_associate_id to appointments to optimize logic that depends on the owner of the mother appointment

* [Modify table appointment](../../docs/en/database/tables/appointment.md)
mother\_associate\_id

**Step 61**

Add soundex field to freetext words table to enable soundex searching

* [Modify table freetextwords](../../docs/en/database/tables/freetextwords.md)
word, soundEx
* [Modify table freetextindex](../../docs/en/database/tables/freetextindex.md)
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

, New preference for document dialog in SOFO (and possible later OML, GmailLink and WEB)

## chat

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
* [Modify table chat\_topic\_user](../../docs/en/database/tables/chat-topic-user.md)
can\_respond, notifications, can\_listen, manager
* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
name, company\_name, email, phone, first\_message, last\_message, flags
* [Modify table chat\_message](../../docs/en/database/tables/chat-message.md)
created\_by
* [Modify table ejuser](../../docs/en/database/tables/ejuser.md)
chat\_status

**Step 2**

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
widget\_language
* [Modify table cust\_lang](../../docs/en/database/tables/cust-lang.md)
iso\_code

**Step 3**

* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
project\_id, sale\_id, ticket\_id, contact\_id, transfer\_to
* [Modify table config](../../docs/en/database/tables/config.md)
feature\_toggle

**Step 4**

* [Modify table login\_customer](../../docs/en/database/tables/login-customer.md)
created\_at
* [Add table quick\_reply](../../docs/en/database/tables/quick-reply.md)

**Step 6**

* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
consented

**Step 7**

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)

**Step 8**

Adding field for using a custom message in the chat widget queue message

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
custom\_queue\_text

**Step 9**

Add CS language to chat_session table. Specify displayField to chat_topic table.

* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)

**Step 10**

Add index on the chat_session table, to optimize the 'anything happening now?' requests that come in every 15 seconds, per service rep

* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)

**Step 11**

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
flags

**Step 12**

* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
status
* [Modify table chat\_message](../../docs/en/database/tables/chat-message.md)
type, special\_type

**Step 13**

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
bot\_enabled, bot\_name, bot\_register\_trigger\_id, bot\_newsession\_trigger\_id, bot\_statechange\_trigger\_id, bot\_newmessage\_trigger\_id
* [Modify table chat\_session](../../docs/en/database/tables/chat-session.md)
chatbot\_isactive

**Step 14**

* [Modify table chat\_topic](../../docs/en/database/tables/chat-topic.md)
bot\_register\_trigger\_id, bot\_newsession\_trigger\_id, bot\_statechange\_trigger\_id, bot\_newmessage\_trigger\_id, bot\_register\_scriptid, bot\_session\_created\_scriptid, bot\_session\_changed\_scriptid, bot\_message\_received\_scriptid

## ConsentManagement

* [Modify table category](../../docs/en/database/tables/category.md)
family\_id

**Step 6**

* [Modify table Category](../../docs/en/database/tables/category.md)
family\_id
* Remove table consent\_person
* Remove table consent\_purpose
* Remove table ConsentSource
* Remove table LegalBase
* Remove table category\_family
* [Add table ConsentPurpose](../../docs/en/database/tables/consentpurpose.md)
* [Add table LegalBase](../../docs/en/database/tables/legalbase.md)
* [Add table ConsentSource](../../docs/en/database/tables/consentsource.md)
* [Add table ConsentPerson](../../docs/en/database/tables/consentperson.md)
* [Add table CategoryFamily](../../docs/en/database/tables/categoryfamily.md)
* [Modify table DocTmpl](../../docs/en/database/tables/doctmpl.md)
privacyDocType, emailSubject
* [Modify table Category](../../docs/en/database/tables/category.md)
CategoryFamily\_id

**Step 7**

* [Modify table outbox](../../docs/en/database/tables/outbox.md)
rfc822\_content

**Step 10**

* [Modify table ConsentPerson](../../docs/en/database/tables/consentperson.md)

**Step 11**

* [Modify table ConsentPerson](../../docs/en/database/tables/consentperson.md)
* [Modify table ConsentPerson](../../docs/en/database/tables/consentperson.md)
* [Modify table ShipmentTypeReservation](../../docs/en/database/tables/shipmenttypereservation.md)
* [Modify table ConsentPurpose](../../docs/en/database/tables/consentpurpose.md)
* [Modify table ConsentSource](../../docs/en/database/tables/consentsource.md)
* [Modify table LegalBase](../../docs/en/database/tables/legalbase.md)
* [Modify table ShipmentType](../../docs/en/database/tables/shipmenttype.md)

**Step 12**

* [Modify table ErpConnection](../../docs/en/database/tables/erpconnection.md)
ConsentSourceId, LegalBaseId

**Step 13**

* [Modify table ErpConnection](../../docs/en/database/tables/erpconnection.md)
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

* [Add table script\_trace](../../docs/en/database/tables/script-trace.md)
* [Add table script\_trace\_run](../../docs/en/database/tables/script-trace-run.md)
* [Modify table screen\_chooser](../../docs/en/database/tables/screen-chooser.md)
description, enabled

**Step 2**

* [Modify table ejscript](../../docs/en/database/tables/ejscript.md)
extra\_menus\_id

**Step 3**

* [Modify table ejscript](../../docs/en/database/tables/ejscript.md)
unique\_identifier, registered, registered\_associate\_id, updated, updated\_associate\_id, updatedCount
* [Modify table screen\_chooser](../../docs/en/database/tables/screen-chooser.md)
unique\_identifier, registered, registered\_associate\_id, updated, updated\_associate\_id, updatedCount

**Step 4**

Flag unique_identfier fields that they should be auto-populated with a GUID on creation; and populate existing rows with GUID's

* [Modify table ejscript](../../docs/en/database/tables/ejscript.md)
unique\_identifier
* [Modify table screen\_chooser](../../docs/en/database/tables/screen-chooser.md)
unique\_identifier

**Step 5**

Create unique indexes for GUID identifiers

* [Modify table ejscript](../../docs/en/database/tables/ejscript.md)
unique\_identifier
* [Modify table screen\_chooser](../../docs/en/database/tables/screen-chooser.md)
unique\_identifier

**Step 6**

New flag field in screen_definition: autosave

* [Modify table screen\_definition](../../docs/en/database/tables/screen-definition.md)
autosave

## CS

* [Modify table ticket](../../docs/en/database/tables/ticket.md)
from\_address

**Step 3**

* [Modify table s\_message](../../docs/en/database/tables/s-message.md)
long\_description

**Step 4**

* [Modify table ticket\_status](../../docs/en/database/tables/ticket-status.md)
status
* [Modify table ticket\_priority](../../docs/en/database/tables/ticket-priority.md)
status, flags, ticket\_read, changed\_owner, ticket\_newinfo, ticket\_closed, ticket\_changed\_priority, ticket\_new
* [Modify table ej\_category](../../docs/en/database/tables/ej-category.md)
delegate\_method, closing\_status, msg\_closing\_status, flags

**Step 5**

* [Modify table ticket](../../docs/en/database/tables/ticket.md)
status, slevel, origin, read\_status
* [Modify table ticket\_status](../../docs/en/database/tables/ticket-status.md)
status

**Step 6**

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
slevel, type, message\_category

**Step 7**

Adding a field to ej_message, allowing the user to filter and view only important messages

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
important

**Step 8**

Add a ForeignKeyArray field to the ticket table as the first entity to use Tags; and add a contact_id to start off that project

* [Modify table Ticket](../../docs/en/database/tables/ticket.md)
tags, contact\_id

**Step 9**

Transfer mobile phone from ticket to person if no phone on person

**Step 10**

Set ticket.contact_id to be consistent with ticket.cust_id.contact_id; and copy the person classifiers (associate_id, group_id, business_idx, category_idx) from contact to person unless person.contact_id = 0

**Step 11**

Add flags to s_list_element table.

* [Modify table s\_list\_element](../../docs/en/database/tables/s-list-element.md)
status

**Step 12**

Create new table, attachment_location, to be able to store attachments in multiple locations

* [Add table attachment\_location](../../docs/en/database/tables/attachment-location.md)
* [Modify table attachment](../../docs/en/database/tables/attachment.md)
attachment\_location\_id

**Step 13**

Create and enable password rules if they have not been changed from the default

**Step 14**

Add field for storing Mailgun DSN setting for each mailbox

* [Modify table mail\_in\_filter](../../docs/en/database/tables/mail-in-filter.md)
mailgun\_dsn

**Step 15**

Add sentiment and language values to ticket table. Add index on ej_message.created_at

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
* [Modify table ticket](../../docs/en/database/tables/ticket.md)
language, sentiment, sentimentConfidence

**Step 16**

Move ej_message.suggestedCategory_id to the ticket table. Add ticket.orig_human_category_id

* [Modify table ej\_message](../../docs/en/database/tables/ej-message.md)
suggestedCategory\_id
* [Modify table ticket](../../docs/en/database/tables/ticket.md)
suggestedCategory\_id, origHumanCategory\_id

**Step 17**

Add details clob to ticket_log_action table for JSON logging

* [Modify table ticket\_log\_action](../../docs/en/database/tables/ticket-log-action.md)
details

**Step 18**

Change type of mail_in_filter.server_type to a defined enum called MailboxType

* [Modify table mail\_in\_filter](../../docs/en/database/tables/mail-in-filter.md)
server\_type

## customerCenter

Create new table for storing customer center styling and configuration options

* [Add table cust\_config](../../docs/en/database/tables/cust-config.md)

**Step 2**

Prime in default Customer Center Config

## forms

* [Add table form](../../docs/en/database/tables/form.md)
* [Add table form\_submission](../../docs/en/database/tables/form-submission.md)

**Step 2**

* [Modify table form](../../docs/en/database/tables/form.md)
active, expires, maxSubmits

**Step 3**

* [Modify table form](../../docs/en/database/tables/form.md)
type

**Step 4**

* [Modify table form](../../docs/en/database/tables/form.md)
recipe

**Step 5**

* [Modify table form\_submission](../../docs/en/database/tables/form-submission.md)
is\_submitted

**Step 6**

* [Modify table form\_submission](../../docs/en/database/tables/form-submission.md)
is\_submitted, status, processing\_log

**Step 7**

* [Modify table form](../../docs/en/database/tables/form.md)
group\_id

**Step 8**

* [Modify table ticket](../../docs/en/database/tables/ticket.md)
form\_submission\_id

**Step 9**

* [Modify table form](../../docs/en/database/tables/form.md)
form\_key

**Step 10**

Create new field to be able to filter out forms that are used to creating tickets

* [Modify table form](../../docs/en/database/tables/form.md)
new\_ticket

## inbox

* [Add table email\_account](../../docs/en/database/tables/email-account.md)
* [Add table email\_folder](../../docs/en/database/tables/email-folder.md)
* [Add table service\_auth](../../docs/en/database/tables/service-auth.md)
* [Add table email\_item](../../docs/en/database/tables/email-item.md)

**Step 2**

* [Modify table email\_item](../../docs/en/database/tables/email-item.md)

**Step 3**

* [Modify table email\_item](../../docs/en/database/tables/email-item.md)
replied\_at, in\_reply\_to, messageId
* [Modify table email\_account](../../docs/en/database/tables/email-account.md)
default

**Step 4**

* [Modify table email\_account](../../docs/en/database/tables/email-account.md)
account\_status
* [Modify table email\_item](../../docs/en/database/tables/email-item.md)
cc
* [Modify table service\_auth](../../docs/en/database/tables/service-auth.md)
associate\_id, auth\_status

**Step 5**

* [Modify table timestamps](../../docs/en/database/tables/timestamps.md)
mailsync

**Step 6**

* [Modify table email\_account](../../docs/en/database/tables/email-account.md)
email\_address
* [Modify table email\_folder](../../docs/en/database/tables/email-folder.md)
account\_id

**Step 7**

* [Modify table email\_account](../../docs/en/database/tables/email-account.md)
encryptedCheck, associate\_id, incoming\_auth, outgoing\_auth
* [Modify table service\_auth](../../docs/en/database/tables/service-auth.md)
encryptedCheck, associate\_id, server, port, auth\_type, username, password

**Step 8**

* [Modify table email\_account](../../docs/en/database/tables/email-account.md)
error\_count, error\_reason
* [Modify table email\_item](../../docs/en/database/tables/email-item.md)
* [Add table email\_attachment](../../docs/en/database/tables/email-attachment.md)

**Step 9**

* [Modify table email\_folder](../../docs/en/database/tables/email-folder.md)
folder\_separator

**Step 10**

* [Modify table email\_item](../../docs/en/database/tables/email-item.md)
cal\_data

**Step 11**

Ensure all email-IDs used as foreignkeys in the foreignkey-table are enclosed in tags. Update all rows as needed, in one operation

## invitation

Adds support for invitations (iCal) leading to appointments

* [Add table invitation](../../docs/en/database/tables/invitation.md)
* [Modify table email](../../docs/en/database/tables/email.md)
appointment\_id

**Step 2**

Allows for storage of the organizer's email and full name in the table; Adds support for recurring invitations.

* [Modify table invitation](../../docs/en/database/tables/invitation.md)
organizer\_email, organizer\_fullname, recurring\_end\_date

**Step 3**

Set preference "Diary sync active" if Infobridge synchronizer seem to be in use.

**Step 4**

Adds support for modifications of single appointments in a recurring series.

* [Modify table invitation](../../docs/en/database/tables/invitation.md)
recurring\_start\_date
* [Modify table erpexternalkey](../../docs/en/database/tables/erpexternalkey.md)

**Step 5**

Adds better support for modifications of single appointments in a recurring series.

* [Modify table appointment](../../docs/en/database/tables/appointment.md)
original\_start\_date

## Mailings

Adding field to store the document mailing recipient sort order

* [Modify table s\_shipment](../../docs/en/database/tables/s-shipment.md)
sorting

**Step 2**

Add fields for storing the design of a mailing message and mailing design type

* [Modify table s\_message](../../docs/en/database/tables/s-message.md)
design, designtype
* [Add table s\_messageblock](../../docs/en/database/tables/s-messageblock.md)
* [Modify table s\_message](../../docs/en/database/tables/s-message.md)
flags

**Step 3**

Remove the old SOEditor mailing templates for new Online installations

**Step 4**

Change type of S_Shipment.Status to a defined enum called ShipmentStatus and change type of (S_Link_Customer/S_Link_Customer_Statical).LinkType to ShipmentLinkType.

* [Modify table s\_shipment](../../docs/en/database/tables/s-shipment.md)
status
* [Modify table s\_link\_customer](../../docs/en/database/tables/s-link-customer.md)
link\_type
* [Modify table s\_link\_customer\_statical](../../docs/en/database/tables/s-link-customer-statical.md)
link\_type

## NewSelection

The typical search table is an owner of a set of predefined selection criteria

**Step 2**

Cleanup after initial (obsolete) table definition

* Remove table TypicalSearch

**Step 3**

Define the TypicalSearch table from scratch

* [Add table TypicalSearch](../../docs/en/database/tables/typicalsearch.md)

**Step 4**

Cleanup 'temporary selection' marking by introducing the IsTemporary field

* [Modify table selection](../../docs/en/database/tables/selection.md)
SystemType

**Step 5**

Add fields to table selection for more functionality. Also update the default sidepanel view for all pages, in userpreference

* [Modify table selection](../../docs/en/database/tables/selection.md)
chartKey, lastLoaded, lastLoadedBy, lastMembershipChange, lastMembershipChangeBy

**Step 6**

SelectionForFind creates a dynamic selection for each entity/associate as needed; they were missing the required VisibleFor row; those are added here

**Step 7**

Update targetTableNumber to 5 where it was 0, and reset membercounts to -1 where we have no recent data

**Step 8**

Due to limitations in the Windows code stack, the chartKey field is shortened to 254 characters

* [Modify table selection](../../docs/en/database/tables/selection.md)
chartKey

## Online

Add table OnlineApp, to echo information about authorizations and usage. Optimize indexes for userpreference table, based on Ops data

* [Add table OnlineApp](../../docs/en/database/tables/onlineapp.md)
* [Modify table userpreference](../../docs/en/database/tables/userpreference.md)
* [Modify table userpreference](../../docs/en/database/tables/userpreference.md)

## Optimization

* [Modify table TravelTransactionLog](../../docs/en/database/tables/traveltransactionlog.md)
* [Modify table ForeignKey](../../docs/en/database/tables/foreignkey.md)

**Step 2**

Deleting obsolete counter-preferences

## Pocket

* [Add table PushNotificationService](../../docs/en/database/tables/pushnotificationservice.md)

**Step 2**

* [Modify table PushNotificationService](../../docs/en/database/tables/pushnotificationservice.md)
Language

**Step 3**

* [Modify table PushNotificationService](../../docs/en/database/tables/pushnotificationservice.md)
PocketVersion, OSVersion

**Step 5**

Adding rank field to favourites

* [Modify table Favourite](../../docs/en/database/tables/favourite.md)
Rank

## R_Service

Add field for storing flags on a service login session

* [Modify table login](../../docs/en/database/tables/login.md)
flags

**Step 2**

Change value of registry entry for maximum width of components

**Step 3**

Make sure the row with id=1 in ejuser contains the '(System)' user

## SubscriptionMgmt

* Add table MailingType
* Add table MailingTypeReservation
* [Modify table s\_shipment](../../docs/en/database/tables/s-shipment.md)
mailingtype\_id

**Step 3**

* [Add table TemporaryKey](../../docs/en/database/tables/temporarykey.md)

**Step 5**

* Modify table MailingTypeReservation
MailingType\_id
* [Modify table s\_shipment](../../docs/en/database/tables/s-shipment.md)
mailingtype\_id
* Rename table MailingType to ShipmentType
* [Modify table ShipmentType](../../docs/en/database/tables/shipmenttype.md)
MailingType\_id
* Rename table MailingTypeReservation to ShipmentTypeReservation
* [Modify table ShipmentTypeReservation](../../docs/en/database/tables/shipmenttypereservation.md)
MailingTypeReservation\_id, MailingType\_id
* [Modify table s\_shipment](../../docs/en/database/tables/s-shipment.md)
mailingtype\_id

**Step 6**

* [Modify table ShipmentTypeReservation](../../docs/en/database/tables/shipmenttypereservation.md)

## SuperId

* [Modify table associate](../../docs/en/database/tables/associate.md)
waiting\_for\_approval

**Step 2**

* [Modify table associate](../../docs/en/database/tables/associate.md)
waiting\_for\_approval

**Step 3**

* [Modify table associate](../../docs/en/database/tables/associate.md)
waiting\_for\_approval

## Webhooks

The **Webhook** table keeps track of the **Target\_URL** where we will dispatch HTTP POST notificationsof events that happen in SuperOffice. The webhook state should be ACTIVE(1). If too many errors are received when we try to POST to the TargetUrl, then the webhook state is changed to TOO-MANY-ERRORS(3).

* [Add table Webhook](../../docs/en/database/tables/webhook.md)
