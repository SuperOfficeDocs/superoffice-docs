---
uid: crmscript_ref_Ticket_getValue_String_colName
title: Ticket.getValue(String colName)
intellisense: Ticket.getValue
keywords: getValue(String)
so.topic: reference
---


Get the value of given column name as a String




## Parameters


 - colName: The name of the wanted column.

## Values

Possible values are the extrafields on the ticket and the following:


 - id
 - title
 - category: the id
 - ownedBy: (owned\_by), the id of the user who owns the ticket
 - slevel: the security level of the ticket, 1 is internal, 2 is external
 - priority: the id
 - status: 1 = active, 2 = closed, 3 = postponed, 4 = deleted, 5 = composed
 - ticketStatus
 - custId: the id of the primary customer
 - createdBy: the id of the user who posted the ticket, 1 if the ticket is posted into the system
 - author
 - activate: the datetime when the ticket was activated
 - createdAt: (created\_at), the datetime when the ticket was created
 - closedAt: (closed\_at), the datetime when the ticket was closed
 - repliedAt: (replied\_at), the datetime when the ticket first was replied at
 - origCategory: the original category
 - origPriority: the original priority
 - isInEscalation
 - displayFilter
 - filterId
 - filterAddress
 - readStatus
 - deadline
 - readByOwner
 - firstReadByUser
 - firstReadByOwner


Returns a string representation of the wanted value


