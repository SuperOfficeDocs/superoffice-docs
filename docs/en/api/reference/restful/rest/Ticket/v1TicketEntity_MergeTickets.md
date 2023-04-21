---
title: POST Ticket/Merge
uid: v1TicketEntity_MergeTickets
---

# POST Ticket/Merge

```http
POST /api/v1/Ticket/Merge
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| secondaryTicketIds | array | **Required** Ids of secondary tickets |
| mergedTicketEntity.ticketId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.title | string |  The title of the ticket. |
| mergedTicketEntity.createdAt | date-time |  When the ticket was created. |
| mergedTicketEntity.lastChanged | date-time |  The last time the ticket was modified. |
| mergedTicketEntity.readByOwner | date-time |  The datetime for when the ticket last was read by the owner. |
| mergedTicketEntity.readByCustomer | date-time |  The datetime for when the ticket was read by the customer. |
| mergedTicketEntity.firstReadByOwner | date-time |  The datetime for when the ticket first was read by the current owner. |
| mergedTicketEntity.firstReadByUser | date-time |  The datetime for when the ticket first was read by a user. |
| mergedTicketEntity.activate | date-time |  When the ticket should be activated, if it is postponed. |
| mergedTicketEntity.closedAt | date-time |  When the ticket was closed. |
| mergedTicketEntity.repliedAt | date-time |  The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| mergedTicketEntity.alertTimeout | date-time |  The datetime for when the ticket should jump to the next alert_level. |
| mergedTicketEntity.deadline | date-time |  Deadline for ticket. |
| mergedTicketEntity.createdBy.associateId | int32 |  Primary key |
| mergedTicketEntity.createdBy.name | string |  Initials, also login name, possibly database user name |
| mergedTicketEntity.createdBy.personId | int32 |  Owning person record 
<para>Use MDO List name "person" to get list items.</para> |
| mergedTicketEntity.createdBy.rank | int32 |  Rank order |
| mergedTicketEntity.createdBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.createdBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.createdBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.createdBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.createdBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.createdBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.createdBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.createdBy.userName | string |  User name |
| mergedTicketEntity.createdBy.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.createdBy.tableRight.reason | string |   |
| mergedTicketEntity.createdBy.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.author | string |  A string representing the author of the ticket (same as author of first message). |
| mergedTicketEntity.ownedBy.associateId | int32 |  Primary key |
| mergedTicketEntity.ownedBy.name | string |  Initials, also login name, possibly database user name |
| mergedTicketEntity.ownedBy.personId | int32 |  Owning person record 
<para>Use MDO List name "person" to get list items.</para> |
| mergedTicketEntity.ownedBy.rank | int32 |  Rank order |
| mergedTicketEntity.ownedBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.ownedBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.ownedBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.ownedBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.ownedBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.ownedBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.ownedBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.ownedBy.userName | string |  User name |
| mergedTicketEntity.ownedBy.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.ownedBy.tableRight.reason | string |   |
| mergedTicketEntity.ownedBy.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.ticketCategoryId | int32 |  The id of the ticket category. (primary key) |
| mergedTicketEntity.category.parentId | int32 |  The parent category for this category. -1 if this is a toplevel category. |
| mergedTicketEntity.category.name | string |  The (short) name of this category. E.g. &amp;apos;support&amp;apos;. |
| mergedTicketEntity.category.fullname | string |  The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;. |
| mergedTicketEntity.category.categoryMaster | int32 |  The user associated with this category. |
| mergedTicketEntity.category.flags | Enum: Unknown, Internal, OnlyLoggedInUsers, DefaultToCategoryMaster, ListInMain, RedelegateNewMsg, DelegateToOurContact, PropagateReplyTemplate, MembersOnly, NotifyMembers, AcceptWhenReplying |  A bitmask representing flags for this category. |
| mergedTicketEntity.category.delegateMethod | Enum: Unknown, Even, Weighted, Unfair, Not |  An integer indicating the delegation method for this category. |
| mergedTicketEntity.category.externalName | string |  The external name for this category, used for the customer frontend. |
| mergedTicketEntity.category.closingStatus | Enum: UserDefined, Active, Closed, Postponed |  Determines the default status used in the GUI when creating a ticket |
| mergedTicketEntity.category.msgClosingStatus | Enum: UserDefined, Active, Closed, Postponed |  Determines the default status used in the GUI when adding a request to a ticket |
| mergedTicketEntity.category.assignmentLag | int32 |  Number of minutes we shall override the assignment if a customer sends consecutive messages to this category |
| mergedTicketEntity.category.replyTemplate | int32 |  Reply template to merge with messages posted in this category |
| mergedTicketEntity.category.notificationEmail | string |  Comma separated list of addresses to notify when requests are redelegated to (unassigned) in this category. |
| mergedTicketEntity.category.defaultTicketStatus.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.category.defaultTicketStatus.name | string |  Name of user defined ticket status |
| mergedTicketEntity.category.defaultTicketStatus.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.category.defaultTicketStatus.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.category.defaultTicketStatus.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.category.defaultTicketStatus.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.category.defaultTicketStatus.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.category.defaultTicketStatus.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.defaultTicketStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultTicketStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.defaultMessageStatus.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.category.defaultMessageStatus.name | string |  Name of user defined ticket status |
| mergedTicketEntity.category.defaultMessageStatus.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.category.defaultMessageStatus.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.category.defaultMessageStatus.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.category.defaultMessageStatus.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.category.defaultMessageStatus.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultMessageStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.effectiveReplyTemplateId | int32 |  Id of reply template to merge into messages, whose ticket belongs to this category. Also takes into account 'Apply to subcategories' on parent categories. This is a calculated, readonly field. |
| mergedTicketEntity.category.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead.
Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.category.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.
Custom fields combines user defined fields and extra fields into one bucket. 
The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this
combined collection. |
| mergedTicketEntity.category.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.category.tableRight.reason | string |   |
| mergedTicketEntity.category.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.slevel | Enum: Unknown, Internal, External |  The securitylevel of the ticket. |
| mergedTicketEntity.priority.ticketPriorityId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.priority.name | string |  The name of the priority. |
| mergedTicketEntity.priority.status | Enum: Unknown, Normal, Deleted |  The status (normal/deleted) of the priority. |
| mergedTicketEntity.priority.flags | Enum: Unknown, External, Default, AlertSchedule |  A bitmask of flags. |
| mergedTicketEntity.priority.sortOrder | int32 |  Indicates the sort order for this priority. 1 is first, 100 is last |
| mergedTicketEntity.priority.ticketRead | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is read |
| mergedTicketEntity.priority.changedOwner | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request changes owner (manually) |
| mergedTicketEntity.priority.ticketNewinfo | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request gets new info |
| mergedTicketEntity.priority.ticketClosed | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is closed |
| mergedTicketEntity.priority.ticketChangedPriority | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when the request is changed into this priority |
| mergedTicketEntity.priority.ticketNew | Enum: None, Stop, Continue, Restart |  This field indicates what to do with the escalation chain when a new request is registered |
| mergedTicketEntity.priority.deadline | int32 |  Deadline to add if escalated (minutes) |
| mergedTicketEntity.priority.monStart | date-time |  The work hour start for Mondays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.monStop | date-time |  The work hour start for Mondays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.tueStart | date-time |  The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.tueStop | date-time |  The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.wedStart | date-time |  The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.wedStop | date-time |  The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.thuStart | date-time |  The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.thuStop | date-time |  The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.friStart | date-time |  The work hour start for Fridays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.friStop | date-time |  The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.satStart | date-time |  The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.satStop | date-time |  The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.sunStart | date-time |  The work hour start for Sundays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.sunStop | date-time |  The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| mergedTicketEntity.priority.nonDates | array |  Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| mergedTicketEntity.priority.escalationLevels | array |  Escalation levels bound to the parent priority |
| mergedTicketEntity.priority.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.priority.tableRight.reason | string |   |
| mergedTicketEntity.priority.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.baseStatus | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The status of the ticket. I.e. active/closed/postponed/deleted 
<para>Use MDO List name "ticketstatus" to get list items.</para> |
| mergedTicketEntity.status.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.status.name | string |  Name of user defined ticket status |
| mergedTicketEntity.status.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.status.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.status.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.status.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.status.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.status.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.status.tableRight.reason | string |   |
| mergedTicketEntity.status.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.origin | Enum: Unknown, Email, SMS, Fax, Phone, Facebook, Twitter, Internal, CustomerCentre, EMarketing, AutoGenerated, Chat, Form |  What is the origin of this ticket |
| mergedTicketEntity.person.position | string |  The position. This is a predefined SuperOffice value, different from Title |
| mergedTicketEntity.person.personId | int32 |  Primary key |
| mergedTicketEntity.person.mrmrs | string |  e.g. Mrs   sex_title |
| mergedTicketEntity.person.firstname | string |  First name |
| mergedTicketEntity.person.lastname | string |  Last name |
| mergedTicketEntity.person.middleName | string |  Middle name or 'van' etc. |
| mergedTicketEntity.person.title | string |  Title |
| mergedTicketEntity.person.description | string |  Info text/description on person. |
| mergedTicketEntity.person.email | string |  First email on contact person. |
| mergedTicketEntity.person.fullName | string |  Get the persons full name (internal name used in clients for employees). |
| mergedTicketEntity.person.directPhone | string |  Returns the direct phone that belong to the contact person. |
| mergedTicketEntity.person.formalName | string |  Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| mergedTicketEntity.person.countryId | int32 |  Country |
| mergedTicketEntity.person.contactId | int32 |  Owning contact ID |
| mergedTicketEntity.person.contactName | string |  The persons company name |
| mergedTicketEntity.person.retired | int32 |  1 = the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.person.rank | int32 |  Display sort sequence for default sort order |
| mergedTicketEntity.person.activeInterests | int32 |  Number of records in pintr table; select count(*) from pintr pi where pi.person_id = this.person_id == activeInterests is always true |
| mergedTicketEntity.person.contactDepartment | string |  The persons contact department |
| mergedTicketEntity.person.contactCountryId | int32 |  The persons contact country id |
| mergedTicketEntity.person.contactOrgNr | string |  The persons contact organization number |
| mergedTicketEntity.person.faxPhone | string |  Returns the fax phone that belong to the contact person. |
| mergedTicketEntity.person.mobilePhone | string |  Returns the mobile phone that belong to the contact person. |
| mergedTicketEntity.person.contactPhone | string |  Returns the direct phone that belong to the persons contact. |
| mergedTicketEntity.person.associateName | string |  Name of the person's owner |
| mergedTicketEntity.person.associateId | int32 |  Id of the item's owner (Associate id) |
| mergedTicketEntity.person.usePersonAddress | bool |  If 1, use person's address for mailing instead of company address |
| mergedTicketEntity.person.contactFax | string |  Actual phone number as eneterd by the user |
| mergedTicketEntity.person.kanafname | string |  Kana first name, used in Japanese versions only |
| mergedTicketEntity.person.kanalname | string |  Kana last name, used in Japanese versions only |
| mergedTicketEntity.person.post1 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.post2 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.post3 | string |  Postal address, used in Japanese versions only |
| mergedTicketEntity.person.emailName | string |  E-mail description |
| mergedTicketEntity.person.contactFullName | string |  Company full name + department |
| mergedTicketEntity.person.activeErpLinks | int32 |  How many active ERP links are there for this person? |
| mergedTicketEntity.person.ticketPriorityId | int32 |  Ticket priority ID |
| mergedTicketEntity.person.supportLanguageId | int32 |  Support priority ID |
| mergedTicketEntity.person.supportAssociateId | int32 |  Our support contact for this person |
| mergedTicketEntity.person.categoryName | string |  The category list item name |
| mergedTicketEntity.person.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.person.tableRight.reason | string |   |
| mergedTicketEntity.person.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.secondaryPersons | array |  The secondary persons this ticket is connected to 
<para>Use MDO List name "person_new" to get list items.</para> |
| mergedTicketEntity.alertLevel | int32 |  The alert level for the ticket. Matches the level value of the ticket_alert table. |
| mergedTicketEntity.connectId | int32 |  If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| mergedTicketEntity.readStatus | Enum: Unknown, Green, Yellow, Red |  Whether the owner has read the ticket or not (red, yellow, green). |
| mergedTicketEntity.timeToReply | int32 |  The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| mergedTicketEntity.realTimeToReply | int32 |  Same as time_to_reply, but not calculated based on priority. |
| mergedTicketEntity.timeToClose | int32 |  The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| mergedTicketEntity.realTimeToClose | int32 |  Same as time_to_close, but not calculated based on priority. |
| mergedTicketEntity.timeSpentInternally | int32 |  The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| mergedTicketEntity.timeSpentExternally | int32 |  The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| mergedTicketEntity.timeSpentQueue | int32 |  The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| mergedTicketEntity.realTimeSpentInternally | int32 |  The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| mergedTicketEntity.realTimeSpentExternally | int32 |  The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| mergedTicketEntity.realTimeSpentQueue | int32 |  The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| mergedTicketEntity.hasAttachment | bool |  Boolean indicating if this ticket has one or more attachments. |
| mergedTicketEntity.numReplies | int32 |  The number of replies (messages) to the customer for this request. |
| mergedTicketEntity.numMessages | int32 |  The total number of messages for this request. |
| mergedTicketEntity.fromAddress | string |  The from-address used when this ticket got created, e.g. by email |
| mergedTicketEntity.messages | array |  TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| mergedTicketEntity.tags | array |  An array containing the tags assigned to this request |
| mergedTicketEntity.language | string |  The language of the first external message |
| mergedTicketEntity.sentiment | int32 |  The sentiment index of the last external message |
| mergedTicketEntity.sentimentConfidence | int32 |  The sentiment confidence of the last external message |
| mergedTicketEntity.suggestedCategoryId | int32 |  Suggestion for categorization, based on the text of the message (AI) |
| mergedTicketEntity.suggestedCategoryName | string |  Suggested category from AI |
| mergedTicketEntity.origHumanCategoryId | int32 |  Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| mergedTicketEntity.iconHint | string |  Icon representing ticket's state |
| mergedTicketEntity.sale.contactName | string |  Contact name |
| mergedTicketEntity.sale.saleDate | date-time |  (expected / lost / won) sales date |
| mergedTicketEntity.sale.saleId | int32 |  Primary key |
| mergedTicketEntity.sale.probability | int32 |  Actual probability, may differ from the one in the list |
| mergedTicketEntity.sale.title | string |  Sale heading (short description?) |
| mergedTicketEntity.sale.amount | double |  Total sale amount |
| mergedTicketEntity.sale.currency | string |  Currency the sale was made in. |
| mergedTicketEntity.sale.projectName | string |  Project name |
| mergedTicketEntity.sale.associateFullName | string |  The sale's owner |
| mergedTicketEntity.sale.description | string |  The sales description |
| mergedTicketEntity.sale.status | Enum: Unknown, Open, Sold, Lost, Stalled, SaintAll |  The sale's status, indicating wether the sale is open, sold or lost. |
| mergedTicketEntity.sale.weightedAmount | double |  The weighted amount ( amount *  probability / 100) |
| mergedTicketEntity.sale.projectId | int32 |  Optional project reference |
| mergedTicketEntity.sale.earningPercent | double |  Earning as percent of total |
| mergedTicketEntity.sale.earning | double |  Earning on sale |
| mergedTicketEntity.sale.contactId | int32 |  Optional contact reference |
| mergedTicketEntity.sale.associateId | int32 |  The sale's owner id |
| mergedTicketEntity.sale.personId | int32 |  The sale's contact persons id |
| mergedTicketEntity.sale.saleTypeId | int32 |  The sale's type id |
| mergedTicketEntity.sale.saleTypeName | string |  The sale's type name |
| mergedTicketEntity.sale.personFullName | string |  The name of the person this sale belongs to. |
| mergedTicketEntity.sale.completed | Enum: Unknown, NotStarted, Started, Completed |  The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| mergedTicketEntity.sale.activeErpLinks | int32 |  The number of active erp links |
| mergedTicketEntity.sale.nextDueDate | date-time |  Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| mergedTicketEntity.sale.number | string |  Alphanumeric user field |
| mergedTicketEntity.sale.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.sale.tableRight.reason | string |   |
| mergedTicketEntity.sale.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.project.projectId | int32 |  Primary key |
| mergedTicketEntity.project.name | string |  Project name |
| mergedTicketEntity.project.description | string |  The projects description |
| mergedTicketEntity.project.uRL | string |  URL address |
| mergedTicketEntity.project.type | string |  The project type. |
| mergedTicketEntity.project.associateId | int32 |  The project owner id (associate id) |
| mergedTicketEntity.project.associateFullName | string |  The project owner |
| mergedTicketEntity.project.typeId | int32 |   |
| mergedTicketEntity.project.updated | date-time |  Last updated date  in UTC. |
| mergedTicketEntity.project.statusId | int32 |  The projects status id |
| mergedTicketEntity.project.status | string |  The projects status |
| mergedTicketEntity.project.textId | int32 |  The id of the description |
| mergedTicketEntity.project.publishTo | date-time |  Publication valid to (inclusive) |
| mergedTicketEntity.project.publishFrom | date-time |  Publication valid from (inclusive) |
| mergedTicketEntity.project.isPublished | bool |   |
| mergedTicketEntity.project.uRLName | string |  Visible field |
| mergedTicketEntity.project.projectNumber | string |  Automatically generated number |
| mergedTicketEntity.project.activeErpLinks | int32 |  The number of active erp links |
| mergedTicketEntity.project.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.project.tableRight.reason | string |   |
| mergedTicketEntity.project.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead.
Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.
Custom fields combines user defined fields and extra fields into one bucket. 
The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this
combined collection. |
| mergedTicketEntity.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.tableRight.reason | string |   |
| mergedTicketEntity.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |

```http
POST /api/v1/Ticket/Merge?secondaryTicketIds=873,980
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketId=564
POST /api/v1/Ticket/Merge?mergedTicketEntity.title=sit
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdAt=02/04/2001 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.lastChanged=06/25/2013 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByOwner=09/14/2007 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByCustomer=02/21/2003 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByOwner=01/17/2011 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByUser=04/22/2000 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.activate=05/13/2010 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.closedAt=05/08/1997 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.repliedAt=10/07/2010 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertTimeout=01/15/2009 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.deadline=03/10/2020 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.associateId=288
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.name=quidem
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.personId=915
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.rank=30
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tooltip=esse
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.groupIdx=41
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fullName=Littel, Gibson and Abernathy
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.formalName=Beier, Weimann and Zulauf
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.ejUserId=647
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.userName=Anderson-Boehm
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.reason=quisquam
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.author=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.associateId=215
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.name=facere
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.personId=96
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.rank=211
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tooltip=non
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.groupIdx=269
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fullName=Ankunding Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.formalName=Rogahn LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.deleted=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.ejUserId=768
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.userName=O'Connell-Nienow
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.reason=esse
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.ticketCategoryId=709
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.parentId=7
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.name=vitae
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fullname=itaque
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.categoryMaster=118
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.flags=AcceptWhenReplying
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.delegateMethod=Even
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.externalName=Wilderman, Collier and VonRueden
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.closingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.msgClosingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.assignmentLag=764
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.replyTemplate=798
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.notificationEmail=oleta@huels.ca
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.ticketStatusId=854
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.name=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.reason=nihil
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.ticketStatusId=868
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.name=at
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.reason=autem
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.effectiveReplyTemplateId=625
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.reason=molestias
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.slevel=External
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketPriorityId=969
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.name=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.status=Deleted
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.flags=AlertSchedule
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sortOrder=266
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketRead=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.changedOwner=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNewinfo=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketClosed=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketChangedPriority=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNew=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.deadline=170
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStart=05/28/1996 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStop=12/27/2013 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStart=02/28/2012 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStop=02/23/2000 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStart=01/11/2021 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStop=06/22/2011 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStart=02/15/2002 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStop=11/08/2008 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStart=03/19/2010 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStop=02/07/2017 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStart=03/26/2013 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStop=10/04/2018 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStart=09/09/2019 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStop=12/07/2014 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.nonDates=quo,et
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.escalationLevels=reprehenderit,deserunt
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.reason=unde
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.baseStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.ticketStatusId=279
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.name=quasi
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.noEmailReopen=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.reason=iste
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.origin=AutoGenerated
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.position=illum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personId=34
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mrmrs=perferendis
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.firstname=vero
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.lastname=ducimus
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.middleName=Schroeder Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.title=impedit
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.description=sed
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.email=saepe
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fullName=Brakus Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.directPhone=393-848-7696
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.formalName=Veum, Mraz and Fisher
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.countryId=359
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactId=189
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactName=Howe, Pfannerstill and Mueller
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.retired=530
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.rank=496
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeInterests=549
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactDepartment=
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactCountryId=390
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactOrgNr=638610
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.faxPhone=243-230-5916 x017
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mobilePhone=270.381.1055 x5025
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactPhone=(059)777-7060
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateName=Casper, Langworth and Olson
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateId=336
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.usePersonAddress=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFax=quia
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanafname=perspiciatis
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanalname=illo
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post1=dolores
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post2=soluta
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post3=delectus
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.emailName=Pfannerstill, Kling and Johns
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFullName=Eveline Collins
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeErpLinks=985
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.ticketPriorityId=119
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportLanguageId=53
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportAssociateId=8
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.categoryName=Sawayn-Miller
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.reason=consequatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.secondaryPersons=et,sunt
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertLevel=960
POST /api/v1/Ticket/Merge?mergedTicketEntity.connectId=60
POST /api/v1/Ticket/Merge?mergedTicketEntity.readStatus=Green
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToReply=122
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToReply=492
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToClose=604
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToClose=575
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentInternally=718
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentExternally=765
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentQueue=845
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentInternally=63
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentExternally=6
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentQueue=316
POST /api/v1/Ticket/Merge?mergedTicketEntity.hasAttachment=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.numReplies=661
POST /api/v1/Ticket/Merge?mergedTicketEntity.numMessages=399
POST /api/v1/Ticket/Merge?mergedTicketEntity.fromAddress=dicta
POST /api/v1/Ticket/Merge?mergedTicketEntity.messages=qui,tenetur
POST /api/v1/Ticket/Merge?mergedTicketEntity.tags=quia,debitis
POST /api/v1/Ticket/Merge?mergedTicketEntity.language=optio
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentiment=165
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentimentConfidence=457
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryId=570
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryName=VIP Customer
POST /api/v1/Ticket/Merge?mergedTicketEntity.origHumanCategoryId=316
POST /api/v1/Ticket/Merge?mergedTicketEntity.iconHint=pariatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactName=Hermiston, Stoltenberg and Skiles
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleDate=01/16/2003 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleId=111
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.probability=586
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.title=dignissimos
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.amount=28632.224
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.currency=dicta
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectName=Ullrich-Bogisich
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateFullName=Taylor Jakubowski
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.description=qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.status=Lost
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.weightedAmount=4632.052
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectId=186
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earningPercent=11260.462
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earning=14046.588
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactId=756
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateId=113
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personId=82
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeId=923
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeName=Barrows-Hettinger
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personFullName=Adrian Ritchie
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.completed=Completed
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.activeErpLinks=337
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.nextDueDate=02/19/2003 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.number=est
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.reason=natus
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectId=251
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.name=tempora
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.description=quia
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRL=odio
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.type=laudantium
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateId=854
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateFullName=Cecilia Runte
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.typeId=79
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.updated=09/16/2000 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.statusId=746
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.status=repellat
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.textId=947
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishTo=01/14/2005 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishFrom=07/02/2020 15:29:32
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.isPublished=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRLName=Kub Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectNumber=1346065
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.activeErpLinks=981
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.reason=non
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.reason=nisi
POST /api/v1/Ticket/Merge?mergedTicketEntity.fieldProperties=An object of some kind
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | int32 | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | int32 | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | string | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | int32 | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | int32 | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | int32 | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | int32 | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | int32 | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | int32 | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | int32 | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | int32 | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | int32 | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| HasAttachment | bool | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | int32 | The number of replies (messages) to the customer for this request. |
| NumMessages | int32 | The total number of messages for this request. |
| FromAddress | string | The from-address used when this ticket got created, e.g. by email |
| Messages | array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | array | An array containing the tags assigned to this request |
| Language | string | The language of the first external message |
| Sentiment | int32 | The sentiment index of the last external message |
| SentimentConfidence | int32 | The sentiment confidence of the last external message |
| SuggestedCategoryId | int32 | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | string | Suggested category from AI |
| OrigHumanCategoryId | int32 | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | string | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket connected to  <para>Use MDO List name "project" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Ticket/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 550,
  "Title": "provident",
  "CreatedAt": "2022-01-09T15:29:30.7324857+01:00",
  "LastChanged": "2019-09-14T15:29:30.7324857+02:00",
  "ReadByOwner": "2017-07-27T15:29:30.7324857+02:00",
  "ReadByCustomer": "2022-10-20T15:29:30.7324857+02:00",
  "FirstReadByOwner": "2015-08-18T15:29:30.7324857+02:00",
  "FirstReadByUser": "2003-09-04T15:29:30.7324857+02:00",
  "Activate": "2015-01-02T15:29:30.7324857+01:00",
  "ClosedAt": "2004-07-01T15:29:30.7324857+02:00",
  "RepliedAt": "2009-10-03T15:29:30.7324857+02:00",
  "AlertTimeout": "2015-11-14T15:29:30.7324857+01:00",
  "Deadline": "2002-03-28T15:29:30.7324857+01:00",
  "CreatedBy": null,
  "Author": "aut",
  "OwnedBy": null,
  "Category": null,
  "Slevel": "External",
  "Priority": null,
  "BaseStatus": "Active",
  "Status": null,
  "Origin": "AutoGenerated",
  "Person": null,
  "SecondaryPersons": [
    {
      "Position": "qui",
      "PersonId": 81,
      "Mrmrs": "velit",
      "Firstname": "Myra",
      "Lastname": "Greenfelder",
      "MiddleName": "Huels LLC",
      "Title": "id",
      "Description": "Fully-configurable multi-state encoding",
      "Email": "magnolia@zulauf.ca",
      "FullName": "Jaden Emmanuel Klein III",
      "DirectPhone": "1-149-327-4794",
      "FormalName": "Stokes LLC",
      "CountryId": 333,
      "ContactId": 961,
      "ContactName": "Luettgen-Kreiger",
      "Retired": 87,
      "Rank": 930,
      "ActiveInterests": 698,
      "ContactDepartment": "",
      "ContactCountryId": 71,
      "ContactOrgNr": "1430959",
      "FaxPhone": "812-753-0051 x04788",
      "MobilePhone": "1-631-024-6993",
      "ContactPhone": "515.626.0870",
      "AssociateName": "Tromp-Lang",
      "AssociateId": 944,
      "UsePersonAddress": false,
      "ContactFax": "nesciunt",
      "Kanafname": "praesentium",
      "Kanalname": "et",
      "Post1": "ut",
      "Post2": "impedit",
      "Post3": "quibusdam",
      "EmailName": "aron.schultz@mcglynngrimes.name",
      "ContactFullName": "Ms. Darron Lesch I",
      "ActiveErpLinks": 319,
      "TicketPriorityId": 83,
      "SupportLanguageId": 841,
      "SupportAssociateId": 533,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "AlertLevel": 878,
  "ConnectId": 351,
  "ReadStatus": "Green",
  "TimeToReply": 920,
  "RealTimeToReply": 99,
  "TimeToClose": 232,
  "RealTimeToClose": 451,
  "TimeSpentInternally": 991,
  "TimeSpentExternally": 984,
  "TimeSpentQueue": 417,
  "RealTimeSpentInternally": 481,
  "RealTimeSpentExternally": 958,
  "RealTimeSpentQueue": 173,
  "HasAttachment": false,
  "NumReplies": 605,
  "NumMessages": 357,
  "FromAddress": "ratione",
  "Messages": [
    {
      "TicketMessageId": 1002,
      "CreatedAt": "2014-09-04T15:29:30.7374886+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "libero",
      "PersonId": 50,
      "PersonFullName": "Quinn Eichmann PhD",
      "ContactId": 78,
      "ContactName": "Hintz-Crona",
      "ContactDepartment": "",
      "NumAttachments": 579,
      "EmailHeader": "arvel_zboncak@murphy.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "in",
      "Sentiment": 887,
      "SentimentConfidence": 613,
      "CreatedBy": 932,
      "ChangedAt": "2013-07-26T15:29:30.7379861+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 9,
      "Name": "Walsh, Ebert and Senger",
      "ToolTip": "Nostrum qui laudantium perspiciatis est quis et voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 414
        }
      }
    },
    {
      "Id": 9,
      "Name": "Walsh, Ebert and Senger",
      "ToolTip": "Nostrum qui laudantium perspiciatis est quis et voluptatem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 414
        }
      }
    }
  ],
  "Language": "reiciendis",
  "Sentiment": 346,
  "SentimentConfidence": 785,
  "SuggestedCategoryId": 826,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 651,
  "IconHint": "quia",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "cupiditate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 566
    }
  }
}
```