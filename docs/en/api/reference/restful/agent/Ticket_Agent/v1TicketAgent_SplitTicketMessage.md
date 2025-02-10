---
title: POST Agents/Ticket/SplitTicketMessage
uid: v1TicketAgent_SplitTicketMessage
generated: true
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceTicketMessage": null,
  "NewTicketEntity": null,
  "NewTicketMessage": null,
  "TransferAttachmentsIds": [
    480,
    862
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 53,
  "Title": "ut",
  "CreatedAt": "2015-03-25T12:01:28.5253326+01:00",
  "LastChanged": "2024-08-18T12:01:28.5253326+02:00",
  "ReadByOwner": "2024-10-06T12:01:28.5253326+02:00",
  "ReadByCustomer": "2010-10-20T12:01:28.5253326+02:00",
  "FirstReadByOwner": "2023-08-14T12:01:28.5253326+02:00",
  "FirstReadByUser": "2014-05-07T12:01:28.5253326+02:00",
  "Activate": "2023-10-17T12:01:28.5253326+02:00",
  "ClosedAt": "2012-03-02T12:01:28.5253326+01:00",
  "RepliedAt": "2016-12-12T12:01:28.5253326+01:00",
  "AlertTimeout": "2024-06-15T12:01:28.5253326+02:00",
  "Deadline": "2016-06-14T12:01:28.5253326+02:00",
  "CreatedBy": null,
  "Author": "accusantium",
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
      "Position": "ex",
      "PersonId": 488,
      "Mrmrs": "ut",
      "Firstname": "Johathan",
      "Lastname": "Feeney",
      "MiddleName": "Aufderhar-Douglas",
      "Title": "assumenda",
      "Description": "Upgradable systematic encryption",
      "Email": "thomas_farrell@krisbogisich.biz",
      "FullName": "Mrs. Renee Jayme Reilly Jr.",
      "DirectPhone": "013.736.3660",
      "FormalName": "Rath-Hackett",
      "CountryId": 53,
      "ContactId": 991,
      "ContactName": "Dare, Beer and Dickinson",
      "Retired": 498,
      "Rank": 288,
      "ActiveInterests": 52,
      "ContactDepartment": "",
      "ContactCountryId": 718,
      "ContactOrgNr": "591036",
      "FaxPhone": "(897)684-5285",
      "MobilePhone": "1-475-488-2950",
      "ContactPhone": "1-489-918-9168 x041",
      "AssociateName": "Blanda Inc and Sons",
      "AssociateId": 504,
      "UsePersonAddress": false,
      "ContactFax": "iure",
      "Kanafname": "temporibus",
      "Kanalname": "ut",
      "Post1": "quibusdam",
      "Post2": "quam",
      "Post3": "aut",
      "EmailName": "kyle@windler.ca",
      "ContactFullName": "Miss Yolanda Monahan DVM",
      "ActiveErpLinks": 284,
      "TicketPriorityId": 817,
      "SupportLanguageId": 680,
      "SupportAssociateId": 615,
      "CategoryName": "VIP Customer",
      "PersonNumber": "893924",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "AlertLevel": 652,
  "ConnectId": 271,
  "ReadStatus": "Green",
  "TimeToReply": 288,
  "RealTimeToReply": 182,
  "TimeToClose": 832,
  "RealTimeToClose": 346,
  "TimeSpentInternally": 63,
  "TimeSpentExternally": 898,
  "TimeSpentQueue": 46,
  "RealTimeSpentInternally": 249,
  "RealTimeSpentExternally": 177,
  "RealTimeSpentQueue": 975,
  "TimeSpent": 770,
  "HasAttachment": false,
  "NumReplies": 587,
  "NumMessages": 999,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 589,
      "CreatedAt": "2002-02-20T12:01:28.5253326+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "incidunt",
      "PersonId": 480,
      "PersonFullName": "Willis Rowe",
      "ContactId": 416,
      "ContactName": "Schuster, Kohler and Greenholt",
      "ContactDepartment": "",
      "NumAttachments": 337,
      "EmailHeader": "osvaldo@pacocha.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "tempore",
      "Sentiment": 524,
      "SentimentConfidence": 91,
      "CreatedBy": 869,
      "ChangedAt": "1998-04-18T12:01:28.5253326+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 513,
      "Name": "Keebler, Durgan and Ratke",
      "ToolTip": "Cumque aut repellat omnis omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "Id": 513,
      "Name": "Keebler, Durgan and Ratke",
      "ToolTip": "Cumque aut repellat omnis omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    }
  ],
  "Language": "est",
  "Sentiment": 612,
  "SentimentConfidence": 559,
  "SuggestedCategoryId": 80,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 190,
  "IconHint": "ipsam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 344,
  "ExtraFields": {
    "ExtraFields1": "sint",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "ducimus",
    "CustomFields2": "quo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 192
    }
  }
}
```