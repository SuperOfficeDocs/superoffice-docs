---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
---

# POST Agents/Ticket/SplitTicketMessage

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage
```

Create new ticket and move/copy data from existing ticket in addition update old message and save new message in a single request.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicketMessage?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

SourceTicketMessage, NewTicketEntity, NewTicketMessage, TransferAttachmentsIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketMessage | TicketMessageEntity | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| NewTicketMessage | TicketMessageEntity | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| TransferAttachmentsIds | Array |  |

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
POST /api/v1/Agents/Ticket/SplitTicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SourceTicketMessage": null,
  "NewTicketEntity": null,
  "NewTicketMessage": null,
  "TransferAttachmentsIds": [
    703,
    186
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 345,
  "Title": "voluptate",
  "CreatedAt": "2003-03-24T15:29:23.2007919+01:00",
  "LastChanged": "2017-05-20T15:29:23.2007919+02:00",
  "ReadByOwner": "2010-01-02T15:29:23.2007919+01:00",
  "ReadByCustomer": "2018-01-03T15:29:23.2007919+01:00",
  "FirstReadByOwner": "2005-08-10T15:29:23.2007919+02:00",
  "FirstReadByUser": "2014-08-17T15:29:23.2007919+02:00",
  "Activate": "2009-02-25T15:29:23.2007919+01:00",
  "ClosedAt": "1998-01-24T15:29:23.2007919+01:00",
  "RepliedAt": "2018-01-24T15:29:23.2007919+01:00",
  "AlertTimeout": "1997-02-24T15:29:23.2007919+01:00",
  "Deadline": "2001-11-17T15:29:23.2007919+01:00",
  "CreatedBy": null,
  "Author": "non",
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
      "Position": "ullam",
      "PersonId": 753,
      "Mrmrs": "aut",
      "Firstname": "Robin",
      "Lastname": "Breitenberg",
      "MiddleName": "Braun-Franecki",
      "Title": "occaecati",
      "Description": "Mandatory holistic projection",
      "Email": "iliana.luettgen@damore.ca",
      "FullName": "Hershel Hilpert",
      "DirectPhone": "120.746.8056 x291",
      "FormalName": "Frami-Thompson",
      "CountryId": 126,
      "ContactId": 149,
      "ContactName": "Gorczany, McGlynn and Kessler",
      "Retired": 238,
      "Rank": 463,
      "ActiveInterests": 311,
      "ContactDepartment": "",
      "ContactCountryId": 687,
      "ContactOrgNr": "1306602",
      "FaxPhone": "708-970-4124",
      "MobilePhone": "1-585-792-9565 x33331",
      "ContactPhone": "633-415-3052 x8746",
      "AssociateName": "Schroeder, Connelly and Lynch",
      "AssociateId": 789,
      "UsePersonAddress": true,
      "ContactFax": "nisi",
      "Kanafname": "quos",
      "Kanalname": "soluta",
      "Post1": "quam",
      "Post2": "incidunt",
      "Post3": "impedit",
      "EmailName": "penelope.simonis@fay.name",
      "ContactFullName": "Eunice Treutel",
      "ActiveErpLinks": 283,
      "TicketPriorityId": 298,
      "SupportLanguageId": 637,
      "SupportAssociateId": 571,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 710
        }
      }
    }
  ],
  "AlertLevel": 372,
  "ConnectId": 345,
  "ReadStatus": "Green",
  "TimeToReply": 490,
  "RealTimeToReply": 135,
  "TimeToClose": 121,
  "RealTimeToClose": 191,
  "TimeSpentInternally": 471,
  "TimeSpentExternally": 873,
  "TimeSpentQueue": 329,
  "RealTimeSpentInternally": 254,
  "RealTimeSpentExternally": 680,
  "RealTimeSpentQueue": 756,
  "HasAttachment": false,
  "NumReplies": 664,
  "NumMessages": 364,
  "FromAddress": "reiciendis",
  "Messages": [
    {
      "TicketMessageId": 330,
      "CreatedAt": "2010-11-27T15:29:23.2052905+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "modi",
      "PersonId": 992,
      "PersonFullName": "Dr. Hudson Hartmann IV",
      "ContactId": 495,
      "ContactName": "Crona Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 625,
      "EmailHeader": "abby@yostmcclure.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "necessitatibus",
      "Sentiment": 736,
      "SentimentConfidence": 955,
      "CreatedBy": 253,
      "ChangedAt": "1999-01-29T15:29:23.2057908+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 423,
      "Name": "Sauer Inc and Sons",
      "ToolTip": "Ad qui repellendus quam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    },
    {
      "Id": 423,
      "Name": "Sauer Inc and Sons",
      "ToolTip": "Ad qui repellendus quam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    }
  ],
  "Language": "officia",
  "Sentiment": 473,
  "SentimentConfidence": 755,
  "SuggestedCategoryId": 318,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 307,
  "IconHint": "non",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "cumque",
    "CustomFields2": "magni"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 249
    }
  }
}
```