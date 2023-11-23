---
title: POST Ticket/Merge
uid: v1TicketEntity_MergeTickets
generated: true
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
| mergedTicketEntity.timeSpent | int32 |  The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| mergedTicketEntity.formSubmission.formSubmissionId | int32 |  Primary key |
| mergedTicketEntity.formSubmission.emailAddress | string |  The email address of the person who submitted |
| mergedTicketEntity.formSubmission.status | Enum: Unknown, InProgress, EmailVerification, Submitted, Processed, Failed |  What is the status of this submission |
| mergedTicketEntity.ticketType.ticketTypeId | int32 |  Primary key |
| mergedTicketEntity.ticketType.name | string |  The list item |
| mergedTicketEntity.ticketType.rank | int32 |  Rank order |
| mergedTicketEntity.ticketType.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.ticketType.icon | string |  Name of the icon |
| mergedTicketEntity.ticketType.defaultTicketStatus | int32 |  Default ticket status for new tickets |
| mergedTicketEntity.ticketType.ticketStatuses | array |  Relevant/available ticket statuses for this Request type. Empty field means all statuses are available. |
| mergedTicketEntity.ticketType.defaultTicketPriority | int32 |  Default ticket priority for new tickets |
| mergedTicketEntity.ticketType.ticketPriorities | array |  Relevant/available ticket priorities for this Request type. Empty field means all priorities are available. |
| mergedTicketEntity.ticketType.replyTemplate | int32 |  Reply template to use when replying to a ticket of this type |
| mergedTicketEntity.ticketType.isExternalVisible | bool |  Is this request type visible to external people and they can submit requests of this type |
| mergedTicketEntity.ticketType.isDefault | bool |  Is this Ticket Type marked as default |
| mergedTicketEntity.ticketType.tableRight.mask | Enum: None, Select, Update, Insert, Delete, Filtering, RestrictedUpdate, Unused1, Uninitialized, FULL, WRITE, URU, UDR, UR, URI, R, RI, RF, F, FI |   |
| mergedTicketEntity.ticketType.tableRight.reason | string |   |
| mergedTicketEntity.ticketType.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
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
POST /api/v1/Ticket/Merge?secondaryTicketIds=505,141
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketId=381
POST /api/v1/Ticket/Merge?mergedTicketEntity.title=officia
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdAt=04/16/2005 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.lastChanged=09/22/2017 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByOwner=06/14/2010 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByCustomer=04/21/1997 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByOwner=12/29/2015 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByUser=04/15/2014 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.activate=08/18/2014 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.closedAt=04/28/2013 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.repliedAt=03/19/2003 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertTimeout=08/05/2009 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.deadline=05/24/1999 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.associateId=77
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.name=quia
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.personId=418
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.rank=925
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tooltip=voluptatibus
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.groupIdx=547
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fullName=Mann, Schultz and Bruen
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.formalName=Towne, Bailey and Harris
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.ejUserId=705
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.userName=Wisozk-Wiza
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.reason=commodi
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.author=optio
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.associateId=770
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.name=tempora
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.personId=132
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.rank=339
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tooltip=quis
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.groupIdx=104
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fullName=Cole, Willms and Windler
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.formalName=Rohan, Vandervort and Thompson
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.deleted=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.ejUserId=569
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.userName=Rowe, Macejkovic and Runolfsson
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.reason=eum
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.ticketCategoryId=862
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.parentId=652
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.name=molestias
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fullname=qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.categoryMaster=147
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.flags=AcceptWhenReplying
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.delegateMethod=Even
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.externalName=Price Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.closingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.msgClosingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.assignmentLag=141
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.replyTemplate=574
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.notificationEmail=sydni@rohan.name
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.ticketStatusId=193
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.name=fugit
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.noEmailReopen=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.reason=distinctio
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.ticketStatusId=746
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.name=expedita
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.isDefault=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.reason=magnam
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.effectiveReplyTemplateId=403
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.reason=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.slevel=External
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketPriorityId=412
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.name=mollitia
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.status=Deleted
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.flags=AlertSchedule
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sortOrder=110
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketRead=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.changedOwner=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNewinfo=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketClosed=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketChangedPriority=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNew=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.deadline=351
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStart=06/21/2010 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStop=09/17/2001 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStart=01/18/2001 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStop=03/17/2001 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStart=07/09/2013 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStop=06/13/2001 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStart=03/24/2013 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStop=07/01/2014 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStart=01/22/2017 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStop=11/19/1997 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStart=04/12/1999 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStop=09/30/2004 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStart=03/18/2007 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStop=03/03/2004 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.nonDates=odit,omnis
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.escalationLevels=laudantium,maiores
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.reason=assumenda
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.baseStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.ticketStatusId=896
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.name=voluptas
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.reason=id
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.origin=AutoGenerated
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.position=officiis
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personId=229
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mrmrs=aliquid
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.firstname=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.lastname=soluta
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.middleName=Smith, Schmitt and Marks
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.title=voluptatem
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.description=provident
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.email=ducimus
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fullName=Howe, O'Connell and Kohler
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.directPhone=1-987-968-1341 x9337
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.formalName=Torphy, Abshire and Herzog
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.countryId=755
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactId=343
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactName=Halvorson Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.retired=238
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.rank=243
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeInterests=69
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactDepartment=
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactCountryId=933
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactOrgNr=1076529
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.faxPhone=736-940-7716 x53364
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mobilePhone=(136)503-0221 x1551
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactPhone=(761)516-7230
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateName=Borer, Bernhard and Cummings
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateId=882
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.usePersonAddress=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFax=doloribus
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanafname=dolore
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanalname=porro
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post1=vel
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post2=quidem
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post3=rerum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.emailName=Nolan, VonRueden and Bergnaum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFullName=Miss Harry Shania Wunsch
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeErpLinks=466
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.ticketPriorityId=8
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportLanguageId=675
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportAssociateId=174
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.categoryName=Schimmel, Steuber and Wolf
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.reason=sapiente
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.secondaryPersons=a,quae
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertLevel=904
POST /api/v1/Ticket/Merge?mergedTicketEntity.connectId=161
POST /api/v1/Ticket/Merge?mergedTicketEntity.readStatus=Green
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToReply=892
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToReply=545
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToClose=245
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToClose=933
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentInternally=776
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentExternally=479
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentQueue=790
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentInternally=268
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentExternally=258
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentQueue=364
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpent=319
POST /api/v1/Ticket/Merge?mergedTicketEntity.hasAttachment=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.numReplies=85
POST /api/v1/Ticket/Merge?mergedTicketEntity.numMessages=543
POST /api/v1/Ticket/Merge?mergedTicketEntity.fromAddress=perferendis
POST /api/v1/Ticket/Merge?mergedTicketEntity.messages=dolore,harum
POST /api/v1/Ticket/Merge?mergedTicketEntity.tags=labore,hic
POST /api/v1/Ticket/Merge?mergedTicketEntity.language=nisi
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentiment=414
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentimentConfidence=84
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryId=166
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryName=VIP Customer
POST /api/v1/Ticket/Merge?mergedTicketEntity.origHumanCategoryId=81
POST /api/v1/Ticket/Merge?mergedTicketEntity.iconHint=repudiandae
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactName=Bartoletti Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleDate=12/13/2017 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleId=539
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.probability=337
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.title=consequatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.amount=3315.772
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.currency=esse
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectName=Glover, Gusikowski and DuBuque
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateFullName=Cassandra Gerhold
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.description=enim
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.status=Lost
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.weightedAmount=17500.256
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectId=945
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earningPercent=9875.234
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earning=11056.752
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactId=369
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateId=769
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personId=844
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeId=193
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeName=Romaguera, Corkery and Lakin
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personFullName=Jess D'Amore
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.completed=Completed
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.activeErpLinks=704
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.nextDueDate=02/09/2013 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.number=ea
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.reason=ea
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectId=684
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.name=sunt
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.description=rerum
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRL=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.type=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateId=432
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateFullName=Jewell O'Connell
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.typeId=295
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.updated=03/04/2014 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.statusId=737
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.status=similique
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.textId=953
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishTo=04/25/2021 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishFrom=06/21/2000 13:38:18
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.isPublished=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRLName=Lakin Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectNumber=989696
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.activeErpLinks=684
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.reason=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.formSubmissionId=483
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.emailAddress=voluptas
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.status=EmailVerification
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketTypeId=25
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.name=eligendi
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.rank=519
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tooltip=molestiae
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.icon=doloribus
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketStatus=721
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketStatuses=473,51
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketPriority=496
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketPriorities=946,750
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.replyTemplate=575
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.isExternalVisible=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.reason=perspiciatis
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.mask=Delete
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.reason=ut
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
| TimeSpent | int32 | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Ticket/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 315,
  "Title": "officiis",
  "CreatedAt": "2002-11-14T13:38:17.7180436+01:00",
  "LastChanged": "2006-03-11T13:38:17.7180436+01:00",
  "ReadByOwner": "2019-05-20T13:38:17.7180436+02:00",
  "ReadByCustomer": "2019-09-05T13:38:17.7180436+02:00",
  "FirstReadByOwner": "2019-12-31T13:38:17.7180436+01:00",
  "FirstReadByUser": "2006-06-26T13:38:17.7180436+02:00",
  "Activate": "2012-11-16T13:38:17.7180436+01:00",
  "ClosedAt": "1996-11-11T13:38:17.7180436+01:00",
  "RepliedAt": "2013-04-26T13:38:17.7180436+02:00",
  "AlertTimeout": "1999-02-21T13:38:17.7180436+01:00",
  "Deadline": "2003-07-27T13:38:17.7180436+02:00",
  "CreatedBy": null,
  "Author": "sint",
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
      "Position": "exercitationem",
      "PersonId": 935,
      "Mrmrs": "autem",
      "Firstname": "Vance",
      "Lastname": "Bogan",
      "MiddleName": "Conn-Stanton",
      "Title": "facere",
      "Description": "Visionary fresh-thinking utilisation",
      "Email": "geraldine.rice@goldnerschuppe.co.uk",
      "FullName": "Prof. Vern Mraz",
      "DirectPhone": "761.244.6201",
      "FormalName": "Hickle-Ziemann",
      "CountryId": 746,
      "ContactId": 146,
      "ContactName": "Schaefer LLC",
      "Retired": 932,
      "Rank": 419,
      "ActiveInterests": 364,
      "ContactDepartment": "",
      "ContactCountryId": 737,
      "ContactOrgNr": "369155",
      "FaxPhone": "819.919.5347",
      "MobilePhone": "777-454-7808",
      "ContactPhone": "075-010-2909 x662",
      "AssociateName": "Satterfield Inc and Sons",
      "AssociateId": 910,
      "UsePersonAddress": true,
      "ContactFax": "enim",
      "Kanafname": "odit",
      "Kanalname": "rem",
      "Post1": "omnis",
      "Post2": "aut",
      "Post3": "dolores",
      "EmailName": "dortha@nikolaus.info",
      "ContactFullName": "Adan Yundt",
      "ActiveErpLinks": 319,
      "TicketPriorityId": 958,
      "SupportLanguageId": 534,
      "SupportAssociateId": 11,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    }
  ],
  "AlertLevel": 952,
  "ConnectId": 950,
  "ReadStatus": "Green",
  "TimeToReply": 596,
  "RealTimeToReply": 341,
  "TimeToClose": 342,
  "RealTimeToClose": 679,
  "TimeSpentInternally": 367,
  "TimeSpentExternally": 726,
  "TimeSpentQueue": 849,
  "RealTimeSpentInternally": 290,
  "RealTimeSpentExternally": 490,
  "RealTimeSpentQueue": 112,
  "TimeSpent": 835,
  "HasAttachment": false,
  "NumReplies": 176,
  "NumMessages": 752,
  "FromAddress": "qui",
  "Messages": [
    {
      "TicketMessageId": 974,
      "CreatedAt": "2017-02-13T13:38:17.7336652+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "ut",
      "PersonId": 616,
      "PersonFullName": "Mrs. Nelda Ashleigh Deckow",
      "ContactId": 392,
      "ContactName": "Parisian-Johnson",
      "ContactDepartment": "",
      "NumAttachments": 471,
      "EmailHeader": "muriel@strackewyman.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eaque",
      "Sentiment": 565,
      "SentimentConfidence": 1000,
      "CreatedBy": 938,
      "ChangedAt": "2023-04-28T13:38:17.7336652+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 1000,
      "Name": "Pollich Inc and Sons",
      "ToolTip": "Doloremque rem eaque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    {
      "Id": 1000,
      "Name": "Pollich Inc and Sons",
      "ToolTip": "Doloremque rem eaque.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "Language": "rem",
  "Sentiment": 229,
  "SentimentConfidence": 952,
  "SuggestedCategoryId": 252,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 436,
  "IconHint": "voluptates",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 366
    }
  }
}
```