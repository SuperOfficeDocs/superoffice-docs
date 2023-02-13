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
  "TicketId": 654
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 768,
  "Title": "similique",
  "CreatedAt": "2002-02-27T11:22:39.4456956+01:00",
  "LastChanged": "2013-03-15T11:22:39.4456956+01:00",
  "ReadByOwner": "2005-12-13T11:22:39.4456956+01:00",
  "ReadByCustomer": "2003-09-27T11:22:39.4456956+02:00",
  "FirstReadByOwner": "2016-03-23T11:22:39.4456956+01:00",
  "FirstReadByUser": "2000-08-29T11:22:39.4456956+02:00",
  "Activate": "2020-04-11T11:22:39.4456956+02:00",
  "ClosedAt": "2006-05-28T11:22:39.4456956+02:00",
  "RepliedAt": "2003-01-01T11:22:39.4456956+01:00",
  "AlertTimeout": "2008-01-14T11:22:39.4456956+01:00",
  "Deadline": "2007-06-05T11:22:39.4456956+02:00",
  "CreatedBy": null,
  "Author": "delectus",
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
      "Position": "praesentium",
      "PersonId": 415,
      "Mrmrs": "itaque",
      "Firstname": "Greta",
      "Lastname": "Witting",
      "MiddleName": "Walsh, Bednar and Bergstrom",
      "Title": "qui",
      "Description": "Implemented 4th generation definition",
      "Email": "brock@cummings.us",
      "FullName": "Hal Bartoletti",
      "DirectPhone": "765.851.3555 x907",
      "FormalName": "Carroll Group",
      "CountryId": 393,
      "ContactId": 847,
      "ContactName": "Hegmann, Beer and Kris",
      "Retired": 779,
      "Rank": 436,
      "ActiveInterests": 432,
      "ContactDepartment": "",
      "ContactCountryId": 217,
      "ContactOrgNr": "950797",
      "FaxPhone": "1-189-487-2893 x90850",
      "MobilePhone": "084-704-7867",
      "ContactPhone": "181-291-3661 x891",
      "AssociateName": "O'Connell Group",
      "AssociateId": 420,
      "UsePersonAddress": true,
      "ContactFax": "officia",
      "Kanafname": "aperiam",
      "Kanalname": "qui",
      "Post1": "consequatur",
      "Post2": "aut",
      "Post3": "et",
      "EmailName": "gilda@crist.info",
      "ContactFullName": "Candido Austen Auer Sr.",
      "ActiveErpLinks": 459,
      "TicketPriorityId": 729,
      "SupportLanguageId": 548,
      "SupportAssociateId": 674,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "AlertLevel": 429,
  "ConnectId": 248,
  "ReadStatus": "Green",
  "TimeToReply": 606,
  "RealTimeToReply": 855,
  "TimeToClose": 184,
  "RealTimeToClose": 483,
  "TimeSpentInternally": 143,
  "TimeSpentExternally": 449,
  "TimeSpentQueue": 620,
  "RealTimeSpentInternally": 870,
  "RealTimeSpentExternally": 482,
  "RealTimeSpentQueue": 183,
  "HasAttachment": false,
  "NumReplies": 391,
  "NumMessages": 27,
  "FromAddress": "id",
  "Messages": [
    {
      "TicketMessageId": 179,
      "CreatedAt": "2015-02-08T11:22:39.4456956+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "qui",
      "PersonId": 707,
      "PersonFullName": "Sigmund Smith",
      "ContactId": 862,
      "ContactName": "Anderson, Von and Hahn",
      "ContactDepartment": "",
      "NumAttachments": 633,
      "EmailHeader": "ervin.conn@homenick.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 411,
      "SentimentConfidence": 728,
      "CreatedBy": 998,
      "ChangedAt": "2005-02-26T11:22:39.4456956+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 428
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 698,
      "Name": "Cole-Flatley",
      "ToolTip": "Omnis sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    },
    {
      "Id": 698,
      "Name": "Cole-Flatley",
      "ToolTip": "Omnis sed.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 842
        }
      }
    }
  ],
  "Language": "hic",
  "Sentiment": 457,
  "SentimentConfidence": 972,
  "SuggestedCategoryId": 71,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 694,
  "IconHint": "asperiores",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "quidem",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 914
    }
  }
}
```