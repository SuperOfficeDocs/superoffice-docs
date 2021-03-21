---
uid: database-whats-new
title: What's New
description: What's new in the latest database version.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Released database changes in version 9.8.7717.1401

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

, New preference for document dialog in SOFO (and possible later OML, GmailLink and WEB)


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

* Modify table ticket\_log\_action
details

**Step 18**

Change type of mail_in_filter.server_type to a defined enum called MailboxType

* Modify table mail\_in\_filter
server\_type

## customerCenter

Create new table for storing customer center styling and configuration options

* Add table cust\_config

**Step 2**

Prime in default Customer Center Config


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

## Webhooks

The **Webhook** table keeps track of the **Target\_URL** where we will dispatch HTTP POST notificationsof events that happen in SuperOffice. The webhook state should be ACTIVE(1). If too many errors are received when we try to POST to the TargetUrl, then the webhook state is changed to TOO-MANY-ERRORS(3).

* Add table Webhook

