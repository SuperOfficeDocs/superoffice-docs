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
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

TicketEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | TicketEntity  updated. |
| 404 | TicketEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TicketEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TicketEntityWithLinks

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
| TableRight | RecurrenceInfo |  |
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
    "path": "dolore",
    "value": {}
  },
  {
    "op": "add",
    "path": "dolore",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 245,
  "Title": "ea",
  "CreatedAt": "2003-07-12T17:37:39.308305+02:00",
  "LastChanged": "1999-08-13T17:37:39.308305+02:00",
  "ReadByOwner": "2003-10-04T17:37:39.308305+02:00",
  "ReadByCustomer": "2016-08-06T17:37:39.308305+02:00",
  "FirstReadByOwner": "2019-08-23T17:37:39.308305+02:00",
  "FirstReadByUser": "2019-11-04T17:37:39.308305+01:00",
  "Activate": "2017-07-31T17:37:39.308305+02:00",
  "ClosedAt": "2022-09-17T17:37:39.308305+02:00",
  "RepliedAt": "1995-11-15T17:37:39.308305+01:00",
  "AlertTimeout": "2002-10-24T17:37:39.308305+02:00",
  "Deadline": "1996-01-20T17:37:39.308305+01:00",
  "CreatedBy": null,
  "Author": "voluptatem",
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
      "PersonId": 324,
      "Mrmrs": "rerum",
      "Firstname": "Mozell",
      "Lastname": "Kautzer",
      "MiddleName": "Schimmel, Hudson and Brown",
      "Title": "sed",
      "Description": "Compatible national ability",
      "Email": "florencio@macejkovicchristiansen.uk",
      "FullName": "Miss Jackson Murazik DVM",
      "DirectPhone": "906-835-6645",
      "FormalName": "Kovacek-Leffler",
      "CountryId": 36,
      "ContactId": 807,
      "ContactName": "Toy, Cole and Littel",
      "Retired": 760,
      "Rank": 965,
      "ActiveInterests": 575,
      "ContactDepartment": "generate revolutionary convergence",
      "ContactCountryId": 415,
      "ContactOrgNr": "1325315",
      "FaxPhone": "919.171.8240 x75266",
      "MobilePhone": "315.724.0380 x0070",
      "ContactPhone": "(403)190-2461",
      "AssociateName": "Weimann-Ledner",
      "AssociateId": 756,
      "UsePersonAddress": true,
      "ContactFax": "earum",
      "Kanafname": "id",
      "Kanalname": "voluptate",
      "Post1": "iusto",
      "Post2": "et",
      "Post3": "et",
      "EmailName": "retha@ankundingkemmer.name",
      "ContactFullName": "Ms. Carroll Moriah Breitenberg MD",
      "ActiveErpLinks": 369,
      "TicketPriorityId": 602,
      "SupportLanguageId": 642,
      "SupportAssociateId": 585,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "AlertLevel": 141,
  "ConnectId": 255,
  "ReadStatus": "Green",
  "TimeToReply": 898,
  "RealTimeToReply": 945,
  "TimeToClose": 160,
  "RealTimeToClose": 434,
  "TimeSpentInternally": 713,
  "TimeSpentExternally": 746,
  "TimeSpentQueue": 370,
  "RealTimeSpentInternally": 888,
  "RealTimeSpentExternally": 240,
  "RealTimeSpentQueue": 474,
  "HasAttachment": true,
  "NumReplies": 751,
  "NumMessages": 784,
  "FromAddress": "placeat",
  "Messages": [
    {
      "TicketMessageId": 228,
      "CreatedAt": "2013-07-13T17:37:39.3133507+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "corrupti",
      "PersonId": 312,
      "PersonFullName": "Jalon Hagenes",
      "ContactId": 606,
      "ContactName": "Dickens-Kessler",
      "ContactDepartment": "",
      "NumAttachments": 797,
      "EmailHeader": "stefan.veum@corkerykuhlman.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "unde",
      "Sentiment": 850,
      "SentimentConfidence": 832,
      "CreatedBy": 424,
      "ChangedAt": "2006-12-25T17:37:39.3133507+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 813,
      "Name": "Gislason Inc and Sons",
      "ToolTip": "Omnis aut in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    },
    {
      "Id": 813,
      "Name": "Gislason Inc and Sons",
      "ToolTip": "Omnis aut in.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Language": "ea",
  "Sentiment": 277,
  "SentimentConfidence": 138,
  "SuggestedCategoryId": 768,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 265,
  "IconHint": "dicta",
  "Sale": null,
  "Project": null,
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "eligendi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 522
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```