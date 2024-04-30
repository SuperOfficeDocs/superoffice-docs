---
title: POST Agents/Ticket/SplitTicket
uid: v1TicketAgent_SplitTicket
generated: true
---

# POST Agents/Ticket/SplitTicket

```http
POST /api/v1/Agents/Ticket/SplitTicket
```

Save new ticket and move/copy data from existing ticket in a single request.


Specified messages will be moved.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SplitTicket?$select=name,department,category/id
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

SourceTicketEntityId, SourceTicketEntityStatusId, SourceTicketEntityActivate, TransferMessageIds, NewTicketEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketEntityId | Integer |  |
| SourceTicketEntityStatusId | Integer |  |
| SourceTicketEntityActivate | String |  |
| TransferMessageIds | Array |  |
| NewTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |

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
POST /api/v1/Agents/Ticket/SplitTicket
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceTicketEntityId": 395,
  "SourceTicketEntityStatusId": 576,
  "SourceTicketEntityActivate": "2016-01-15T11:16:09.9292814+01:00",
  "TransferMessageIds": [
    689,
    345
  ],
  "NewTicketEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 858,
  "Title": "veritatis",
  "CreatedAt": "2018-12-27T11:16:09.9292814+01:00",
  "LastChanged": "2001-01-14T11:16:09.9292814+01:00",
  "ReadByOwner": "1997-10-16T11:16:09.9292814+02:00",
  "ReadByCustomer": "2021-05-01T11:16:09.9292814+02:00",
  "FirstReadByOwner": "2024-04-29T11:16:09.9292814+02:00",
  "FirstReadByUser": "2015-07-17T11:16:09.9292814+02:00",
  "Activate": "2013-04-18T11:16:09.9292814+02:00",
  "ClosedAt": "2005-02-27T11:16:09.9292814+01:00",
  "RepliedAt": "2008-05-14T11:16:09.9292814+02:00",
  "AlertTimeout": "2021-06-19T11:16:09.9292814+02:00",
  "Deadline": "2013-01-02T11:16:09.9292814+01:00",
  "CreatedBy": null,
  "Author": "quis",
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
      "Position": "quia",
      "PersonId": 595,
      "Mrmrs": "nesciunt",
      "Firstname": "Jameson",
      "Lastname": "Emmerich",
      "MiddleName": "Koelpin LLC",
      "Title": "quaerat",
      "Description": "Reverse-engineered fresh-thinking project",
      "Email": "ophelia.farrell@handlehner.name",
      "FullName": "Ramon Stoltenberg",
      "DirectPhone": "116-810-5023 x9266",
      "FormalName": "Rohan-Bayer",
      "CountryId": 475,
      "ContactId": 235,
      "ContactName": "Satterfield-Gutkowski",
      "Retired": 815,
      "Rank": 565,
      "ActiveInterests": 230,
      "ContactDepartment": "",
      "ContactCountryId": 606,
      "ContactOrgNr": "1181504",
      "FaxPhone": "(466)652-8683 x412",
      "MobilePhone": "538.914.2540 x15851",
      "ContactPhone": "305-939-7887 x09949",
      "AssociateName": "Brekke-Crona",
      "AssociateId": 302,
      "UsePersonAddress": false,
      "ContactFax": "vitae",
      "Kanafname": "commodi",
      "Kanalname": "itaque",
      "Post1": "quo",
      "Post2": "quam",
      "Post3": "laborum",
      "EmailName": "dorris_wolf@legros.com",
      "ContactFullName": "Ella Kuhlman",
      "ActiveErpLinks": 687,
      "TicketPriorityId": 376,
      "SupportLanguageId": 356,
      "SupportAssociateId": 251,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    }
  ],
  "AlertLevel": 659,
  "ConnectId": 236,
  "ReadStatus": "Green",
  "TimeToReply": 438,
  "RealTimeToReply": 423,
  "TimeToClose": 858,
  "RealTimeToClose": 429,
  "TimeSpentInternally": 673,
  "TimeSpentExternally": 381,
  "TimeSpentQueue": 528,
  "RealTimeSpentInternally": 731,
  "RealTimeSpentExternally": 981,
  "RealTimeSpentQueue": 942,
  "TimeSpent": 669,
  "HasAttachment": true,
  "NumReplies": 655,
  "NumMessages": 89,
  "FromAddress": "laborum",
  "Messages": [
    {
      "TicketMessageId": 812,
      "CreatedAt": "2012-04-26T11:16:09.9449069+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "expedita",
      "PersonId": 156,
      "PersonFullName": "Abagail Crooks",
      "ContactId": 894,
      "ContactName": "Ward Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 158,
      "EmailHeader": "crawford@okunevamills.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "numquam",
      "Sentiment": 11,
      "SentimentConfidence": 283,
      "CreatedBy": 977,
      "ChangedAt": "2000-10-14T11:16:09.9449069+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 667,
      "Name": "Douglas LLC",
      "ToolTip": "Enim quia explicabo laudantium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 340
        }
      }
    },
    {
      "Id": 667,
      "Name": "Douglas LLC",
      "ToolTip": "Enim quia explicabo laudantium.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 340
        }
      }
    }
  ],
  "Language": "quis",
  "Sentiment": 164,
  "SentimentConfidence": 624,
  "SuggestedCategoryId": 228,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 818,
  "IconHint": "a",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 792,
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 285
    }
  }
}
```