---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
---

# POST Agents/Ticket/GetForRmUi

```http
POST /api/v1/Agents/Ticket/GetForRmUi
```

Get a ticket entity, adapted to the specific needs of the Request Management UI.


WARNING: This endpoint is not guaranteed to be stable/compatible between versions






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetForRmUi?$select=name,department,category/id
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

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 153
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 549,
  "Title": "at",
  "CreatedAt": "2003-03-19T11:10:28.2566936+01:00",
  "LastChanged": "2018-11-29T11:10:28.2566936+01:00",
  "ReadByOwner": "2002-02-26T11:10:28.2566936+01:00",
  "ReadByCustomer": "1999-03-21T11:10:28.2566936+01:00",
  "FirstReadByUser": "2017-05-11T11:10:28.2566936+02:00",
  "Activate": "2013-01-28T11:10:28.2566936+01:00",
  "ClosedAt": "2019-10-05T11:10:28.2566936+02:00",
  "RepliedAt": "2012-11-21T11:10:28.2566936+01:00",
  "AlertTimeout": "2006-02-07T11:10:28.2566936+01:00",
  "Deadline": "2009-09-18T11:10:28.2566936+02:00",
  "CreatedBy": null,
  "Author": "quia",
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
      "Position": "consequatur",
      "PersonId": 640,
      "Mrmrs": "dolorem",
      "Firstname": "Ellis",
      "Lastname": "Dare",
      "MiddleName": "Nicolas-Reichel",
      "Title": "voluptatem",
      "Description": "Ameliorated contextually-based solution",
      "Email": "casper@murphypagac.biz",
      "FullName": "Godfrey Parisian",
      "DirectPhone": "1-865-555-1005",
      "FormalName": "Klocko-Rogahn",
      "CountryId": 562,
      "ContactId": 231,
      "ContactName": "Grimes-Cremin",
      "Retired": 318,
      "Rank": 713,
      "ActiveInterests": 492,
      "ContactDepartment": "",
      "ContactCountryId": 827,
      "ContactOrgNr": "1353899",
      "FaxPhone": "691.689.4224 x0977",
      "MobilePhone": "(813)080-7871 x66196",
      "ContactPhone": "170.818.9998 x316",
      "AssociateName": "Bednar Inc and Sons",
      "AssociateId": 924,
      "UsePersonAddress": false,
      "ContactFax": "vero",
      "Kanafname": "quibusdam",
      "Kanalname": "consequatur",
      "Post1": "dolor",
      "Post2": "optio",
      "Post3": "sapiente",
      "EmailName": "noelia@berge.co.uk",
      "ContactFullName": "Hipolito Monahan",
      "ActiveErpLinks": 400,
      "TicketPriorityId": 386,
      "SupportLanguageId": 360,
      "SupportAssociateId": 104,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "AlertLevel": 631,
  "ConnectId": 476,
  "ReadStatus": "Green",
  "TimeToReply": 643,
  "RealTimeToReply": 939,
  "TimeToClose": 931,
  "RealTimeToClose": 210,
  "TimeSpentInternally": 463,
  "TimeSpentExternally": 414,
  "TimeSpentQueue": 169,
  "RealTimeSpentInternally": 255,
  "RealTimeSpentExternally": 100,
  "RealTimeSpentQueue": 313,
  "HasAttachment": false,
  "NumReplies": 80,
  "NumMessages": 787,
  "FromAddress": "delectus",
  "Messages": [
    {
      "TicketMessageId": 856,
      "CreatedAt": "2000-03-21T11:10:28.2616931+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "eos",
      "PersonId": 635,
      "PersonFullName": "Kraig Hirthe",
      "ContactId": 939,
      "ContactName": "Flatley-Green",
      "ContactDepartment": "",
      "NumAttachments": 826,
      "EmailHeader": "elfrieda@dooleybode.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "odio",
      "Sentiment": 190,
      "SentimentConfidence": 183,
      "CreatedBy": 482,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 499,
      "Name": "Huels, Pfeffer and Ferry",
      "ToolTip": "Laborum deleniti voluptatem omnis dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    },
    {
      "Id": 499,
      "Name": "Huels, Pfeffer and Ferry",
      "ToolTip": "Laborum deleniti voluptatem omnis dolor.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "Language": "cumque",
  "Sentiment": 937,
  "SentimentConfidence": 460,
  "SuggestedCategoryId": 435,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 252,
  "IconHint": "totam",
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "fuga"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "quasi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 473
    }
  }
}
```