---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
generated: true
content_type: reference
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
POST /api/v1/Agents/Ticket/SplitTicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceTicketMessage": null,
  "NewTicketEntity": null,
  "NewTicketMessage": null,
  "TransferAttachmentsIds": [
    806,
    298
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 952,
  "Title": "voluptatem",
  "CreatedAt": "1999-07-23T11:24:48.7657551+02:00",
  "LastChanged": "2010-09-15T11:24:48.7657551+02:00",
  "ReadByOwner": "2016-04-04T11:24:48.7657551+02:00",
  "ReadByCustomer": "1998-07-30T11:24:48.7657551+02:00",
  "FirstReadByOwner": "2022-01-29T11:24:48.7657551+01:00",
  "FirstReadByUser": "2018-06-21T11:24:48.7657551+02:00",
  "Activate": "2014-10-08T11:24:48.7657551+02:00",
  "ClosedAt": "2004-10-10T11:24:48.7657551+02:00",
  "RepliedAt": "2009-06-06T11:24:48.7657551+02:00",
  "AlertTimeout": "2016-10-11T11:24:48.7657551+02:00",
  "Deadline": "2018-05-08T11:24:48.7657551+02:00",
  "CreatedBy": null,
  "Author": "tenetur",
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
      "Position": "aut",
      "PersonId": 236,
      "Mrmrs": "aliquam",
      "Firstname": "Arvid",
      "Lastname": "Gerhold",
      "MiddleName": "McLaughlin Group",
      "Title": "excepturi",
      "Description": "Self-enabling needs-based software",
      "Email": "carlo.oconner@herman.com",
      "FullName": "Angelo Kuhlman",
      "DirectPhone": "1-614-220-5024",
      "FormalName": "Hessel-Kuhn",
      "CountryId": 542,
      "ContactId": 737,
      "ContactName": "Green, Hickle and Reynolds",
      "Retired": 462,
      "Rank": 842,
      "ActiveInterests": 282,
      "ContactDepartment": "",
      "ContactCountryId": 503,
      "ContactOrgNr": "1582920",
      "FaxPhone": "280-077-5988 x183",
      "MobilePhone": "343.561.6827",
      "ContactPhone": "(862)154-6654",
      "AssociateName": "Jacobson, Thiel and Tromp",
      "AssociateId": 634,
      "UsePersonAddress": true,
      "ContactFax": "sequi",
      "Kanafname": "dolor",
      "Kanalname": "consectetur",
      "Post1": "vel",
      "Post2": "vero",
      "Post3": "perferendis",
      "EmailName": "morgan@dach.ca",
      "ContactFullName": "Mr. Jazmin Reese Schiller Jr.",
      "ActiveErpLinks": 459,
      "TicketPriorityId": 1000,
      "SupportLanguageId": 902,
      "SupportAssociateId": 475,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1189378",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 82
        }
      }
    }
  ],
  "AlertLevel": 435,
  "ConnectId": 28,
  "ReadStatus": "Green",
  "TimeToReply": 518,
  "RealTimeToReply": 791,
  "TimeToClose": 65,
  "RealTimeToClose": 18,
  "TimeSpentInternally": 588,
  "TimeSpentExternally": 782,
  "TimeSpentQueue": 123,
  "RealTimeSpentInternally": 969,
  "RealTimeSpentExternally": 693,
  "RealTimeSpentQueue": 871,
  "TimeSpent": 526,
  "HasAttachment": false,
  "NumReplies": 209,
  "NumMessages": 275,
  "FromAddress": "assumenda",
  "Messages": [
    {
      "TicketMessageId": 628,
      "CreatedAt": "2009-11-23T11:24:48.7657551+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "nesciunt",
      "PersonId": 721,
      "PersonFullName": "Jeanie Boyer",
      "ContactId": 164,
      "ContactName": "Kshlerin LLC",
      "ContactDepartment": "",
      "NumAttachments": 45,
      "EmailHeader": "letitia_ebert@ziemannferry.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "iure",
      "Sentiment": 213,
      "SentimentConfidence": 537,
      "CreatedBy": 397,
      "ChangedAt": "2010-11-12T11:24:48.7657551+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 759
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 480,
      "Name": "Ortiz Inc and Sons",
      "ToolTip": "Ad assumenda officia consectetur voluptates quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    },
    {
      "Id": 480,
      "Name": "Ortiz Inc and Sons",
      "ToolTip": "Ad assumenda officia consectetur voluptates quidem.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    }
  ],
  "Language": "id",
  "Sentiment": 122,
  "SentimentConfidence": 345,
  "SuggestedCategoryId": 392,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 630,
  "IconHint": "ea",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 988,
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "nam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 49
    }
  }
}
```