---
title: POST Agents/Ticket/SaveTicketEntityWithNotify
uid: v1TicketAgent_SaveTicketEntityWithNotify
---

# POST Agents/Ticket/SaveTicketEntityWithNotify

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
```

Saves a ticket and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify?$select=name,department,category/id
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

NewEntity, Notify 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| Notify | Boolean |  |

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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "NewEntity": null,
  "Notify": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 53,
  "Title": "sint",
  "CreatedAt": "2008-12-03T14:19:04.4390755+01:00",
  "LastChanged": "2014-12-20T14:19:04.4390755+01:00",
  "ReadByOwner": "2018-08-08T14:19:04.4390755+02:00",
  "ReadByCustomer": "2003-03-25T14:19:04.4390755+01:00",
  "FirstReadByOwner": "2007-04-13T14:19:04.4390755+02:00",
  "FirstReadByUser": "2017-12-20T14:19:04.4390755+01:00",
  "Activate": "2017-07-29T14:19:04.4390755+02:00",
  "ClosedAt": "2003-03-18T14:19:04.4390755+01:00",
  "RepliedAt": "2003-10-24T14:19:04.4390755+02:00",
  "AlertTimeout": "2011-05-28T14:19:04.4390755+02:00",
  "Deadline": "2002-02-16T14:19:04.4390755+01:00",
  "CreatedBy": null,
  "Author": "ipsa",
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
      "Position": "ad",
      "PersonId": 514,
      "Mrmrs": "et",
      "Firstname": "Schuyler",
      "Lastname": "Heller",
      "MiddleName": "Bogan-Becker",
      "Title": "et",
      "Description": "Multi-layered web-enabled Graphic Interface",
      "Email": "victoria_blick@heathcotebayer.biz",
      "FullName": "Hildegard Kessler",
      "DirectPhone": "754-005-3413 x589",
      "FormalName": "Klein, Bogan and Kuhlman",
      "CountryId": 878,
      "ContactId": 829,
      "ContactName": "Macejkovic, Nienow and Kuphal",
      "Retired": 660,
      "Rank": 833,
      "ActiveInterests": 379,
      "ContactDepartment": "",
      "ContactCountryId": 167,
      "ContactOrgNr": "213979",
      "FaxPhone": "1-339-265-2690 x56574",
      "MobilePhone": "(445)555-8495 x834",
      "ContactPhone": "843-405-5405 x98938",
      "AssociateName": "Adams-Friesen",
      "AssociateId": 413,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "ut",
      "Kanalname": "vero",
      "Post1": "omnis",
      "Post2": "harum",
      "Post3": "et",
      "EmailName": "carmen@king.ca",
      "ContactFullName": "Cletus Lakin",
      "ActiveErpLinks": 790,
      "TicketPriorityId": 182,
      "SupportLanguageId": 706,
      "SupportAssociateId": 5,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 729
        }
      }
    }
  ],
  "AlertLevel": 966,
  "ConnectId": 137,
  "ReadStatus": "Green",
  "TimeToReply": 303,
  "RealTimeToReply": 441,
  "TimeToClose": 333,
  "RealTimeToClose": 404,
  "TimeSpentInternally": 941,
  "TimeSpentExternally": 552,
  "TimeSpentQueue": 525,
  "RealTimeSpentInternally": 956,
  "RealTimeSpentExternally": 988,
  "RealTimeSpentQueue": 832,
  "HasAttachment": false,
  "NumReplies": 223,
  "NumMessages": 953,
  "FromAddress": "reprehenderit",
  "Messages": [
    {
      "TicketMessageId": 954,
      "CreatedAt": "2001-02-09T14:19:04.4390755+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "unde",
      "PersonId": 782,
      "PersonFullName": "Amanda Pacocha",
      "ContactId": 540,
      "ContactName": "Mraz, Robel and Stroman",
      "ContactDepartment": "",
      "NumAttachments": 351,
      "EmailHeader": "vern@hettinger.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 811,
      "SentimentConfidence": 149,
      "CreatedBy": 318,
      "ChangedAt": "2014-05-26T14:19:04.4390755+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 157
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 343,
      "Name": "Blanda LLC",
      "ToolTip": "Atque sed ut in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    },
    {
      "Id": 343,
      "Name": "Blanda LLC",
      "ToolTip": "Atque sed ut in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "Language": "debitis",
  "Sentiment": 851,
  "SentimentConfidence": 294,
  "SuggestedCategoryId": 614,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 880,
  "IconHint": "repudiandae",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "recusandae",
    "ExtraFields2": "labore"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 607
    }
  }
}
```