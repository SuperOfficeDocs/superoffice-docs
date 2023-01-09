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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
    252,
    104
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 873,
  "Title": "quia",
  "CreatedAt": "2021-02-16T17:37:19.4209778+01:00",
  "LastChanged": "2019-05-17T17:37:19.4209778+02:00",
  "ReadByOwner": "2002-08-22T17:37:19.4209778+02:00",
  "ReadByCustomer": "2010-02-11T17:37:19.4209778+01:00",
  "FirstReadByOwner": "2009-10-27T17:37:19.4209778+01:00",
  "FirstReadByUser": "2019-03-10T17:37:19.4209778+01:00",
  "Activate": "2017-01-24T17:37:19.4209778+01:00",
  "ClosedAt": "2014-03-22T17:37:19.4209778+01:00",
  "RepliedAt": "2017-02-05T17:37:19.4209778+01:00",
  "AlertTimeout": "2006-08-19T17:37:19.4209778+02:00",
  "Deadline": "2022-04-12T17:37:19.4209778+02:00",
  "CreatedBy": null,
  "Author": "omnis",
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
      "Position": "suscipit",
      "PersonId": 726,
      "Mrmrs": "iusto",
      "Firstname": "Shaylee",
      "Lastname": "Treutel",
      "MiddleName": "Lynch, Homenick and Shanahan",
      "Title": "inventore",
      "Description": "Quality-focused 4th generation adapter",
      "Email": "tyrel@heaney.ca",
      "FullName": "Ms. Nikita Kuhlman",
      "DirectPhone": "(657)027-1941",
      "FormalName": "Windler Group",
      "CountryId": 634,
      "ContactId": 623,
      "ContactName": "Stoltenberg, Lang and Mertz",
      "Retired": 881,
      "Rank": 96,
      "ActiveInterests": 451,
      "ContactDepartment": "",
      "ContactCountryId": 379,
      "ContactOrgNr": "192136",
      "FaxPhone": "788.862.9427 x874",
      "MobilePhone": "1-218-347-7477 x54888",
      "ContactPhone": "652.069.4995",
      "AssociateName": "Steuber-Hermann",
      "AssociateId": 139,
      "UsePersonAddress": false,
      "ContactFax": "ipsum",
      "Kanafname": "necessitatibus",
      "Kanalname": "nihil",
      "Post1": "voluptatem",
      "Post2": "natus",
      "Post3": "laudantium",
      "EmailName": "noemi@doyle.info",
      "ContactFullName": "Izaiah Kozey",
      "ActiveErpLinks": 873,
      "TicketPriorityId": 337,
      "SupportLanguageId": 856,
      "SupportAssociateId": 656,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "AlertLevel": 633,
  "ConnectId": 489,
  "ReadStatus": "Green",
  "TimeToReply": 25,
  "RealTimeToReply": 11,
  "TimeToClose": 272,
  "RealTimeToClose": 979,
  "TimeSpentInternally": 465,
  "TimeSpentExternally": 6,
  "TimeSpentQueue": 419,
  "RealTimeSpentInternally": 865,
  "RealTimeSpentExternally": 496,
  "RealTimeSpentQueue": 721,
  "HasAttachment": false,
  "NumReplies": 499,
  "NumMessages": 190,
  "FromAddress": "excepturi",
  "Messages": [
    {
      "TicketMessageId": 554,
      "CreatedAt": "2009-11-14T17:37:19.4259767+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "commodi",
      "PersonId": 428,
      "PersonFullName": "Mrs. Dejon Hiram Romaguera",
      "ContactId": 240,
      "ContactName": "Schmeler-Gaylord",
      "ContactDepartment": "",
      "NumAttachments": 673,
      "EmailHeader": "jamey_hermann@yundt.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "dicta",
      "Sentiment": 761,
      "SentimentConfidence": 154,
      "CreatedBy": 501,
      "ChangedAt": "2016-05-09T17:37:19.4259767+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 465
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 130,
      "Name": "Wolff Inc and Sons",
      "ToolTip": "Nam provident dolorem omnis mollitia nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    },
    {
      "Id": 130,
      "Name": "Wolff Inc and Sons",
      "ToolTip": "Nam provident dolorem omnis mollitia nam.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 582
        }
      }
    }
  ],
  "Language": "debitis",
  "Sentiment": 777,
  "SentimentConfidence": 760,
  "SuggestedCategoryId": 894,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 44,
  "IconHint": "occaecati",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "modi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 268
    }
  }
}
```