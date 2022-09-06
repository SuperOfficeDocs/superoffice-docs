---
title: PATCH Ticket/{id}
uid: v1TicketEntity_PatchTicketEntity
---

# PATCH Ticket/{id}

```http
PATCH /api/v1/Ticket/{id}
```

Update a TicketEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```

JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.

Calls the {SuperOffice.CRM.Services.ITicketAgent} service SaveTicketEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketEntity  id to update. **Required** |

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Ticket/{id}?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations).

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |

## Response

TicketEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity  updated. |
| 404 | TicketEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TicketEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "voluptate",
    "value": {}
  },
  {
    "op": "add",
    "path": "voluptate",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 492,
  "Title": "aliquid",
  "CreatedAt": "2000-04-18T11:10:53.6052146+02:00",
  "LastChanged": "2020-07-10T11:10:53.6052146+02:00",
  "ReadByOwner": "2015-05-16T11:10:53.6052146+02:00",
  "ReadByCustomer": "2018-01-23T11:10:53.6052146+01:00",
  "FirstReadByUser": "2019-04-02T11:10:53.6052146+02:00",
  "Activate": "2015-03-03T11:10:53.6052146+01:00",
  "ClosedAt": "2010-11-19T11:10:53.6052146+01:00",
  "RepliedAt": "2018-09-17T11:10:53.6052146+02:00",
  "AlertTimeout": "2011-10-04T11:10:53.6052146+02:00",
  "Deadline": "2010-03-07T11:10:53.6052146+01:00",
  "CreatedBy": null,
  "Author": "dignissimos",
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
      "PersonId": 654,
      "Mrmrs": "sed",
      "Firstname": "Mozell",
      "Lastname": "Mertz",
      "MiddleName": "Boehm Group",
      "Title": "voluptas",
      "Description": "Cloned non-volatile hierarchy",
      "Email": "tristin@zemlak.uk",
      "FullName": "Prof. Jonas Forest Bartell",
      "DirectPhone": "(168)343-9459 x359",
      "FormalName": "Howe LLC",
      "CountryId": 589,
      "ContactId": 1001,
      "ContactName": "Baumbach Inc and Sons",
      "Retired": 635,
      "Rank": 743,
      "ActiveInterests": 400,
      "ContactDepartment": "",
      "ContactCountryId": 524,
      "ContactOrgNr": "1687794",
      "FaxPhone": "873.789.7060",
      "MobilePhone": "143.554.7961 x08634",
      "ContactPhone": "1-600-173-6378",
      "AssociateName": "Donnelly, Senger and McKenzie",
      "AssociateId": 326,
      "UsePersonAddress": false,
      "ContactFax": "occaecati",
      "Kanafname": "quia",
      "Kanalname": "ut",
      "Post1": "consequatur",
      "Post2": "eos",
      "Post3": "qui",
      "EmailName": "cornelius_nitzsche@gleichnergorczany.name",
      "ContactFullName": "Katrina Gleichner",
      "ActiveErpLinks": 209,
      "TicketPriorityId": 108,
      "SupportLanguageId": 362,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 142
        }
      }
    }
  ],
  "AlertLevel": 694,
  "ConnectId": 161,
  "ReadStatus": "Green",
  "TimeToReply": 78,
  "RealTimeToReply": 679,
  "TimeToClose": 525,
  "RealTimeToClose": 225,
  "TimeSpentInternally": 832,
  "TimeSpentExternally": 910,
  "TimeSpentQueue": 381,
  "RealTimeSpentInternally": 276,
  "RealTimeSpentExternally": 758,
  "RealTimeSpentQueue": 382,
  "HasAttachment": true,
  "NumReplies": 640,
  "NumMessages": 822,
  "FromAddress": "voluptatem",
  "Messages": [
    {
      "TicketMessageId": 993,
      "CreatedAt": "2002-06-24T11:10:53.6102126+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "alias",
      "PersonId": 932,
      "PersonFullName": "Hazle Gerlach",
      "ContactId": 46,
      "ContactName": "Gerlach Group",
      "ContactDepartment": "",
      "NumAttachments": 528,
      "EmailHeader": "carmelo.reichel@stiedemann.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "fuga",
      "Sentiment": 341,
      "SentimentConfidence": 688,
      "CreatedBy": 663,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 469,
      "Name": "Ritchie-Ferry",
      "ToolTip": "Eum quidem consequuntur voluptatibus aspernatur in harum magni.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    },
    {
      "Id": 469,
      "Name": "Ritchie-Ferry",
      "ToolTip": "Eum quidem consequuntur voluptatibus aspernatur in harum magni.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "Language": "accusantium",
  "Sentiment": 73,
  "SentimentConfidence": 805,
  "SuggestedCategoryId": 684,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 262,
  "IconHint": "sapiente",
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "rerum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 472
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```
