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
| TicketId | Integer |  |

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
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 52
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 259,
  "Title": "eius",
  "CreatedAt": "1996-10-07T17:37:19.3442424+02:00",
  "LastChanged": "2003-10-31T17:37:19.3442424+01:00",
  "ReadByOwner": "2019-09-24T17:37:19.3442424+02:00",
  "ReadByCustomer": "1996-11-06T17:37:19.3442424+01:00",
  "FirstReadByOwner": "2008-04-17T17:37:19.3442424+02:00",
  "FirstReadByUser": "2010-04-11T17:37:19.3442424+02:00",
  "Activate": "1998-11-26T17:37:19.3442424+01:00",
  "ClosedAt": "2003-03-09T17:37:19.3442424+01:00",
  "RepliedAt": "2011-06-22T17:37:19.3442424+02:00",
  "AlertTimeout": "1997-03-26T17:37:19.3442424+01:00",
  "Deadline": "2018-11-20T17:37:19.3442424+01:00",
  "CreatedBy": null,
  "Author": "et",
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
      "Position": "eos",
      "PersonId": 544,
      "Mrmrs": "vero",
      "Firstname": "Taryn",
      "Lastname": "Rogahn",
      "MiddleName": "Bernhard-Reynolds",
      "Title": "optio",
      "Description": "Decentralized bandwidth-monitored strategy",
      "Email": "breanna@rauswift.co.uk",
      "FullName": "Mr. Billie Reinger",
      "DirectPhone": "350.589.9752",
      "FormalName": "Crooks-Bednar",
      "CountryId": 538,
      "ContactId": 663,
      "ContactName": "Willms, Kutch and Morar",
      "Retired": 635,
      "Rank": 405,
      "ActiveInterests": 328,
      "ContactDepartment": "",
      "ContactCountryId": 241,
      "ContactOrgNr": "523466",
      "FaxPhone": "480-676-6061 x104",
      "MobilePhone": "809.521.2322",
      "ContactPhone": "829-647-2538 x8138",
      "AssociateName": "Wilderman-Mueller",
      "AssociateId": 29,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "consequatur",
      "Kanalname": "minima",
      "Post1": "tenetur",
      "Post2": "dolorem",
      "Post3": "ut",
      "EmailName": "oleta_halvorson@stoltenberg.us",
      "ContactFullName": "Ms. Beau Littel",
      "ActiveErpLinks": 586,
      "TicketPriorityId": 45,
      "SupportLanguageId": 660,
      "SupportAssociateId": 120,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    }
  ],
  "AlertLevel": 74,
  "ConnectId": 322,
  "ReadStatus": "Green",
  "TimeToReply": 84,
  "RealTimeToReply": 157,
  "TimeToClose": 236,
  "RealTimeToClose": 900,
  "TimeSpentInternally": 720,
  "TimeSpentExternally": 523,
  "TimeSpentQueue": 435,
  "RealTimeSpentInternally": 814,
  "RealTimeSpentExternally": 246,
  "RealTimeSpentQueue": 454,
  "HasAttachment": true,
  "NumReplies": 567,
  "NumMessages": 191,
  "FromAddress": "sunt",
  "Messages": [
    {
      "TicketMessageId": 713,
      "CreatedAt": "2011-10-25T17:37:19.3482417+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "commodi",
      "PersonId": 964,
      "PersonFullName": "Guadalupe Hegmann",
      "ContactId": 84,
      "ContactName": "Klocko-Koss",
      "ContactDepartment": "",
      "NumAttachments": 498,
      "EmailHeader": "muhammad.lang@hoeger.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "est",
      "Sentiment": 372,
      "SentimentConfidence": 704,
      "CreatedBy": 500,
      "ChangedAt": "2010-02-02T17:37:19.3482417+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 692
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 777,
      "Name": "Block Inc and Sons",
      "ToolTip": "Sed dolores facere quia architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    },
    {
      "Id": 777,
      "Name": "Block Inc and Sons",
      "ToolTip": "Sed dolores facere quia architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 571
        }
      }
    }
  ],
  "Language": "maxime",
  "Sentiment": 828,
  "SentimentConfidence": 260,
  "SuggestedCategoryId": 324,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 948,
  "IconHint": "maxime",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 561
    }
  }
}
```