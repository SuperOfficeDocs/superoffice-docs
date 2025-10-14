---
title: POST Ticket/Merge
uid: v1TicketEntity_MergeTickets
generated: true
content_type: reference
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
| mergedTicketEntity.createdBy.personId | int32 |  Owning person record Use MDO List name "person" to get list items. |
| mergedTicketEntity.createdBy.rank | int32 |  Rank order |
| mergedTicketEntity.createdBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.createdBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.createdBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.createdBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.createdBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.createdBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.createdBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.createdBy.userName | string |  User name |
| mergedTicketEntity.createdBy.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.Associate.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.createdBy.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.Associate.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.createdBy.tableRight.mask | string |   |
| mergedTicketEntity.createdBy.tableRight.reason | string |   |
| mergedTicketEntity.createdBy.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.author | string |  A string representing the author of the ticket (same as author of first message). |
| mergedTicketEntity.ownedBy.associateId | int32 |  Primary key |
| mergedTicketEntity.ownedBy.name | string |  Initials, also login name, possibly database user name |
| mergedTicketEntity.ownedBy.personId | int32 |  Owning person record Use MDO List name "person" to get list items. |
| mergedTicketEntity.ownedBy.rank | int32 |  Rank order |
| mergedTicketEntity.ownedBy.tooltip | string |  Tooltip or other description |
| mergedTicketEntity.ownedBy.type | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  User type - 1 = internal user, 2 = resource, 3 = external user, 4 = anonymous, 5 = system |
| mergedTicketEntity.ownedBy.groupIdx | int32 |  Primary group membership, see UserGroupLink for secondary memberships |
| mergedTicketEntity.ownedBy.fullName | string |  The associate's culture formatted fullname (firstname, middleName and lastname) |
| mergedTicketEntity.ownedBy.formalName | string |  The associate's culture formatted formalname (firstname, middleName and lastname, title, mrmrs) |
| mergedTicketEntity.ownedBy.deleted | bool |  If true, the user is retired and should have no rights, not appear in lists, etc. |
| mergedTicketEntity.ownedBy.ejUserId | int32 |  ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| mergedTicketEntity.ownedBy.userName | string |  User name |
| mergedTicketEntity.ownedBy.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.Associate.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.ownedBy.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.Associate.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.ownedBy.tableRight.mask | string |   |
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
| mergedTicketEntity.category.defaultTicketStatus.tableRight.mask | string |   |
| mergedTicketEntity.category.defaultTicketStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultTicketStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.defaultMessageStatus.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.category.defaultMessageStatus.name | string |  Name of user defined ticket status |
| mergedTicketEntity.category.defaultMessageStatus.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.category.defaultMessageStatus.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.category.defaultMessageStatus.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.category.defaultMessageStatus.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.category.defaultMessageStatus.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.mask | string |   |
| mergedTicketEntity.category.defaultMessageStatus.tableRight.reason | string |   |
| mergedTicketEntity.category.defaultMessageStatus.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.category.effectiveReplyTemplateId | int32 |  Id of reply template to merge into messages, whose ticket belongs to this category. Also takes into account 'Apply to subcategories' on parent categories. This is a calculated, readonly field. |
| mergedTicketEntity.category.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketCategoryEntity.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.category.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.TicketCategoryEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.category.tableRight.mask | string |   |
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

| Parameter Name | Type |  Description |
|----------------|------|--------------|
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
| mergedTicketEntity.priority.tableRight.mask | string |   |
| mergedTicketEntity.priority.tableRight.reason | string |   |
| mergedTicketEntity.priority.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.baseStatus | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The status of the ticket. I.e. active/closed/postponed/deleted Use MDO List name "ticketstatus" to get list items. |
| mergedTicketEntity.status.ticketStatusId | int32 |  The primary key (auto-incremented) |
| mergedTicketEntity.status.name | string |  Name of user defined ticket status |
| mergedTicketEntity.status.status | Enum: Unknown, Active, Closed, Postponed, Deleted, Merged, PostponedSpecific, Postponed1Hour, Postponed2Hours, Postponed3Hours, Postponed4Hours, PostponedDay, PostponedWeek, PostponedMonth |  The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| mergedTicketEntity.status.timeCounter | Enum: None, Internally, Externally, Queue |  Which field in ticket we count time spent on (queue, internal, external) |
| mergedTicketEntity.status.noEmailReopen | bool |  Whether inbound emails can reopen requests with this status or not |
| mergedTicketEntity.status.isDefault | bool |  Indicates if status is default one as there might be more than one status with same internal status |
| mergedTicketEntity.status.usedInQueue | bool |  If set, status is used in GetNext calculations |
| mergedTicketEntity.status.tableRight.mask | string |   |
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
| mergedTicketEntity.person.personNumber | string |  Alphanumeric user field |
| mergedTicketEntity.person.tableRight.mask | string |   |
| mergedTicketEntity.person.tableRight.reason | string |   |
| mergedTicketEntity.person.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.secondaryPersons | array |  The secondary persons this ticket is connected to Use MDO List name "person_new" to get list items. |
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

| Parameter Name | Type |  Description |
|----------------|------|--------------|
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
| mergedTicketEntity.sale.tableRight.mask | string |   |
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
| mergedTicketEntity.project.tableRight.mask | string |   |
| mergedTicketEntity.project.tableRight.reason | string |   |
| mergedTicketEntity.project.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.formSubmission.formSubmissionId | int32 |  Primary key |
| mergedTicketEntity.formSubmission.emailAddress | string |  The email address of the person who submitted |
| mergedTicketEntity.formSubmission.status | Enum: Unknown, InProgress, EmailVerification, Submitted, Processed, Failed |  What is the status of this submission |
| mergedTicketEntity.ticketType.ticketTypeId | int32 |  Primary key |
| mergedTicketEntity.ticketType.name | string |  The list item |
| mergedTicketEntity.ticketType.icon | string |  Name of the icon |
| mergedTicketEntity.ticketType.defaultTicketStatus | int32 |  Default ticket status for new tickets |
| mergedTicketEntity.ticketType.defaultTicketPriority | int32 |  Default ticket priority for new tickets |
| mergedTicketEntity.ticketType.isDefault | bool |  Is this Ticket Type marked as default |
| mergedTicketEntity.ticketType.showInNew | bool |  Enables this request type to be accessible in +New in top bar |
| mergedTicketEntity.ticketType.excludeSignature | bool |  Do not insert user signature automatically |
| mergedTicketEntity.ticketType.excludeEmailRecipients | bool |  Create request without initially having to send outbound e-mail |
| mergedTicketEntity.ticketType.externalAsDefault | bool |  Ability to set external access level for this request type |
| mergedTicketEntity.ticketType.visibleForGroups | array |  Array of references to the visible for groups |
| mergedTicketEntity.ticketType.replyForwardNoSignature | bool |  Do not insert user signature when replying or forwarding the message |
| mergedTicketEntity.ticketType.replyExternalAsDefault | bool |  Set external access level when replying the message |
| mergedTicketEntity.ticketType.tableRight.mask | string |   |
| mergedTicketEntity.ticketType.tableRight.reason | string |   |
| mergedTicketEntity.ticketType.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |
| mergedTicketEntity.activeStatusMonitorId | int32 |  Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| mergedTicketEntity.extraFields | object |  Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead.Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| mergedTicketEntity.customFields | object |  Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin.Custom fields combines user defined fields and extra fields into one bucket. The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of thiscombined collection. |
| mergedTicketEntity.tableRight.mask | string |   |
| mergedTicketEntity.tableRight.reason | string |   |
| mergedTicketEntity.fieldProperties | object |  Field property dictionary mapping field names to field access rights. |

```http
POST /api/v1/Ticket/Merge?secondaryTicketIds=259,696
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketId=399
POST /api/v1/Ticket/Merge?mergedTicketEntity.title=repellat
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdAt=10/21/2000 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.lastChanged=07/03/2006 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByOwner=10/30/2023 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.readByCustomer=06/30/2018 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByOwner=09/06/2001 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.firstReadByUser=06/28/2012 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.activate=12/30/2014 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.closedAt=04/02/2005 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.repliedAt=08/21/2023 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertTimeout=06/02/2016 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.deadline=10/14/2005 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.associateId=667
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.name=ipsa
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.personId=434
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.rank=745
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tooltip=expedita
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.groupIdx=305
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fullName=Borer, Bins and Haag
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.formalName=Hand-Pfeffer
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.deleted=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.ejUserId=946
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.userName=White Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.mask=id
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.tableRight.reason=mollitia
POST /api/v1/Ticket/Merge?mergedTicketEntity.createdBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.author=adipisci
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.associateId=185
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.name=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.personId=385
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.rank=274
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tooltip=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.type=AnonymousAssociate
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.groupIdx=777
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fullName=Lubowitz, Steuber and Cremin
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.formalName=Morissette, Greenholt and Turcotte
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.deleted=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.ejUserId=560
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.userName=Simonis, Murray and Willms
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.mask=eos
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.tableRight.reason=quis
POST /api/v1/Ticket/Merge?mergedTicketEntity.ownedBy.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.ticketCategoryId=540
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.parentId=209
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.name=sint
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fullname=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.categoryMaster=160
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.flags=AcceptWhenReplying
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.delegateMethod=Even
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.externalName=Hoeger, DuBuque and Osinski
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.closingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.msgClosingStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.assignmentLag=928
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.replyTemplate=934
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.notificationEmail=sigrid@franecki.info
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.ticketStatusId=89
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.name=voluptatem
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.noEmailReopen=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.mask=id
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.tableRight.reason=voluptas
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultTicketStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.ticketStatusId=917
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.name=excepturi
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.usedInQueue=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.mask=eos
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.tableRight.reason=dolorum
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.defaultMessageStatus.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.effectiveReplyTemplateId=673
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.mask=eaque
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.tableRight.reason=delectus
POST /api/v1/Ticket/Merge?mergedTicketEntity.category.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.slevel=External
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketPriorityId=311
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.name=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.status=Deleted
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.flags=AlertSchedule
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sortOrder=315
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketRead=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.changedOwner=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNewinfo=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketClosed=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketChangedPriority=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.ticketNew=Continue
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.deadline=764
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStart=12/30/2009 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.monStop=11/29/2018 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStart=09/18/2024 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tueStop=11/06/2005 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStart=06/14/2022 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.wedStop=12/01/2023 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStart=01/25/2025 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.thuStop=02/16/2021 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStart=08/19/2008 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.friStop=03/29/2003 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStart=12/16/2020 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.satStop=03/29/2010 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStart=10/03/2019 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.sunStop=10/23/2002 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.nonDates=ducimus,cum
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.escalationLevels=harum,et
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.mask=ex
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.tableRight.reason=nihil
POST /api/v1/Ticket/Merge?mergedTicketEntity.priority.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.baseStatus=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.ticketStatusId=753
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.name=tempore
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.status=Active
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.timeCounter=Externally
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.noEmailReopen=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.usedInQueue=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.mask=dolorem
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.tableRight.reason=cupiditate
POST /api/v1/Ticket/Merge?mergedTicketEntity.status.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.origin=AutoGenerated
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.position=molestias
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personId=185
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mrmrs=est
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.firstname=eum
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.lastname=sit
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.middleName=Langosh-Osinski
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.title=vero
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.description=corrupti
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.email=nemo
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fullName=Robel Inc and Sons
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.directPhone=555.388.8544
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.formalName=O'Hara, Quitzon and Gottlieb
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.countryId=95
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactId=450
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactName=Rippin-Herman
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.retired=31
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.rank=539
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeInterests=852
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactDepartment=
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactCountryId=220
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactOrgNr=677833
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.faxPhone=659-416-4298 x60045
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.mobilePhone=942-643-3883 x468
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactPhone=190-314-5727 x26740
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateName=Hoeger LLC
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.associateId=815
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.usePersonAddress=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFax=sit
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanafname=tempore
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.kanalname=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post1=qui
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post2=doloribus
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.post3=officia
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.emailName=Bailey-Halvorson
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.contactFullName=Mazie Morar
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.activeErpLinks=267
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.ticketPriorityId=811
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportLanguageId=832
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.supportAssociateId=629
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.categoryName=Glover Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.personNumber=1021232
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.mask=recusandae
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.tableRight.reason=aut
POST /api/v1/Ticket/Merge?mergedTicketEntity.person.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.secondaryPersons=excepturi,doloremque
POST /api/v1/Ticket/Merge?mergedTicketEntity.alertLevel=969
POST /api/v1/Ticket/Merge?mergedTicketEntity.connectId=972
POST /api/v1/Ticket/Merge?mergedTicketEntity.readStatus=Green
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToReply=854
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToReply=768
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeToClose=477
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeToClose=195
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentInternally=948
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentExternally=135
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpentQueue=21
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentInternally=561
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentExternally=230
POST /api/v1/Ticket/Merge?mergedTicketEntity.realTimeSpentQueue=732
POST /api/v1/Ticket/Merge?mergedTicketEntity.timeSpent=291
POST /api/v1/Ticket/Merge?mergedTicketEntity.hasAttachment=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.numReplies=628
POST /api/v1/Ticket/Merge?mergedTicketEntity.numMessages=154
POST /api/v1/Ticket/Merge?mergedTicketEntity.fromAddress=nemo
POST /api/v1/Ticket/Merge?mergedTicketEntity.messages=maiores,velit
POST /api/v1/Ticket/Merge?mergedTicketEntity.tags=temporibus,eos
POST /api/v1/Ticket/Merge?mergedTicketEntity.language=excepturi
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentiment=690
POST /api/v1/Ticket/Merge?mergedTicketEntity.sentimentConfidence=866
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryId=129
POST /api/v1/Ticket/Merge?mergedTicketEntity.suggestedCategoryName=VIP Customer
POST /api/v1/Ticket/Merge?mergedTicketEntity.origHumanCategoryId=867
POST /api/v1/Ticket/Merge?mergedTicketEntity.iconHint=facilis
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactName=Mohr-Bogisich
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleDate=10/11/2012 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleId=17
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.probability=985
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.title=maiores
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.amount=25896.242
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.currency=ut
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectName=O'Connell, Stracke and Cartwright
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateFullName=Norwood Boehm
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.description=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.status=Lost
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.weightedAmount=25542.1
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.projectId=752
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earningPercent=21326.87
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.earning=14845.758
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.contactId=932
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.associateId=65
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personId=250
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeId=806
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.saleTypeName=Wiza Group
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.personFullName=Kevon Gleason
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.completed=Completed
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.activeErpLinks=190
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.nextDueDate=06/24/2023 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.number=nemo
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.mask=molestias
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.tableRight.reason=fuga
POST /api/v1/Ticket/Merge?mergedTicketEntity.sale.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectId=487
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.name=expedita
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.description=consectetur
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRL=laudantium
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.type=aspernatur
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateId=583
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.associateFullName=Dr. Eduardo Clementina Mills Sr.
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.typeId=77
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.updated=05/15/2015 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.statusId=31
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.status=sapiente
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.textId=939
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishTo=05/27/2016 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.publishFrom=12/19/2010 03:40:58
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.isPublished=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.uRLName=Boyle-Bosco
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.projectNumber=930402
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.activeErpLinks=951
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.mask=tempora
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.tableRight.reason=sit
POST /api/v1/Ticket/Merge?mergedTicketEntity.project.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.formSubmissionId=306
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.emailAddress=libero
POST /api/v1/Ticket/Merge?mergedTicketEntity.formSubmission.status=EmailVerification
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.ticketTypeId=993
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.name=a
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.icon=quia
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketStatus=441
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.defaultTicketPriority=539
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.isDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.showInNew=True
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.excludeSignature=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.excludeEmailRecipients=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.externalAsDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.visibleForGroups=339,580
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.replyForwardNoSignature=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.replyExternalAsDefault=False
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.mask=et
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.tableRight.reason=non
POST /api/v1/Ticket/Merge?mergedTicketEntity.ticketType.fieldProperties=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.activeStatusMonitorId=447
POST /api/v1/Ticket/Merge?mergedTicketEntity.extraFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.customFields=An object of some kind
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.mask=culpa
POST /api/v1/Ticket/Merge?mergedTicketEntity.tableRight.reason=est
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
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  Use MDO List name "associate" to get list items. |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  Use MDO List name "ejcategory" to get list items. |
| Slevel | string | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  Use MDO List name "ticketpriority" to get list items. |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  Use MDO List name "ticketstatus" to get list items. |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  Use MDO List name "ticketstatus" to get list items. |
| Origin | string | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  Use MDO List name "person_new" to get list items. |
| SecondaryPersons | array | The secondary persons this ticket is connected to  Use MDO List name "person_new" to get list items. |
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
| Sale | Sale | The sale that this ticket is connected to  Use MDO List name "sale" to get list items. |
| Project | Project | The project that this ticket is connected to  Use MDO List name "project" to get list items. |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketType | Type of the Request  Use MDO List name "TicketType" to get list items. |
| ActiveStatusMonitorId | int32 | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
  "TicketId": 935,
  "Title": "provident",
  "CreatedAt": "2012-01-08T03:40:56.3672209+01:00",
  "LastChanged": "2018-08-05T03:40:56.3672209+02:00",
  "ReadByOwner": "2008-08-01T03:40:56.3672209+02:00",
  "ReadByCustomer": "2025-07-14T03:40:56.3672209+02:00",
  "FirstReadByOwner": "2024-07-26T03:40:56.3672209+02:00",
  "FirstReadByUser": "2022-03-11T03:40:56.3672209+01:00",
  "Activate": "2015-08-15T03:40:56.3672209+02:00",
  "ClosedAt": "2010-07-23T03:40:56.3672209+02:00",
  "RepliedAt": "2007-02-27T03:40:56.3672209+01:00",
  "AlertTimeout": "2017-01-13T03:40:56.3672209+01:00",
  "Deadline": "2007-09-10T03:40:56.3672209+02:00",
  "CreatedBy": null,
  "Author": "asperiores",
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
      "Position": "sunt",
      "PersonId": 440,
      "Mrmrs": "facere",
      "Firstname": "Robin",
      "Lastname": "Mante",
      "MiddleName": "Marks Group",
      "Title": "et",
      "Description": "Horizontal impactful analyzer",
      "Email": "lulu_spencer@bogisichhirthe.ca",
      "FullName": "Mrs. Coralie Zackery Gibson DVM",
      "DirectPhone": "069-009-5639",
      "FormalName": "Miller, Hermiston and Carroll",
      "CountryId": 576,
      "ContactId": 298,
      "ContactName": "Smith LLC",
      "Retired": 810,
      "Rank": 743,
      "ActiveInterests": 294,
      "ContactDepartment": "",
      "ContactCountryId": 405,
      "ContactOrgNr": "946459",
      "FaxPhone": "781-591-4579 x961",
      "MobilePhone": "(392)431-6216 x5752",
      "ContactPhone": "1-608-581-7762 x80550",
      "AssociateName": "Rempel, Mann and Rolfson",
      "AssociateId": 561,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "ea",
      "Kanalname": "facilis",
      "Post1": "cum",
      "Post2": "doloremque",
      "Post3": "necessitatibus",
      "EmailName": "ruby@gleason.co.uk",
      "ContactFullName": "Mr. Meghan Denesik",
      "ActiveErpLinks": 992,
      "TicketPriorityId": 274,
      "SupportLanguageId": 2,
      "SupportAssociateId": 202,
      "CategoryName": "VIP Customer",
      "PersonNumber": "688423",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    }
  ],
  "AlertLevel": 214,
  "ConnectId": 109,
  "ReadStatus": "Green",
  "TimeToReply": 20,
  "RealTimeToReply": 467,
  "TimeToClose": 526,
  "RealTimeToClose": 54,
  "TimeSpentInternally": 997,
  "TimeSpentExternally": 699,
  "TimeSpentQueue": 17,
  "RealTimeSpentInternally": 212,
  "RealTimeSpentExternally": 942,
  "RealTimeSpentQueue": 585,
  "TimeSpent": 814,
  "HasAttachment": false,
  "NumReplies": 747,
  "NumMessages": 237,
  "FromAddress": "sint",
  "Messages": [
    {
      "TicketMessageId": 416,
      "CreatedAt": "1999-01-16T03:40:56.3672209+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "deserunt",
      "PersonId": 461,
      "PersonFullName": "Hector Macejkovic",
      "ContactId": 163,
      "ContactName": "Bosco LLC",
      "ContactDepartment": "",
      "NumAttachments": 375,
      "EmailHeader": "leif.cassin@howe.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "pariatur",
      "Sentiment": 644,
      "SentimentConfidence": 623,
      "CreatedBy": 309,
      "ChangedAt": "2004-11-17T03:40:56.3828469+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 745,
      "Name": "Sauer-Reichert",
      "ToolTip": "Quidem eius nesciunt aut natus libero vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    },
    {
      "Id": 745,
      "Name": "Sauer-Reichert",
      "ToolTip": "Quidem eius nesciunt aut natus libero vitae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "Language": "recusandae",
  "Sentiment": 395,
  "SentimentConfidence": 913,
  "SuggestedCategoryId": 887,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 391,
  "IconHint": "delectus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 513,
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "consequuntur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  }
}
```