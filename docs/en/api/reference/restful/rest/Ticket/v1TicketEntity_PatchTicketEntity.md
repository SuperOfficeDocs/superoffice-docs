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


## Response: 

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
| FirstReadByOwner | date-time | The datetime for when the ticket first was read by the current owner. |
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
    "path": "illo",
    "value": {}
  },
  {
    "op": "add",
    "path": "illo",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 905,
  "Title": "qui",
  "CreatedAt": "2021-10-23T02:49:51.5988104+02:00",
  "LastChanged": "2004-10-23T02:49:51.5988104+02:00",
  "ReadByOwner": "2014-08-20T02:49:51.5988104+02:00",
  "ReadByCustomer": "2012-04-11T02:49:51.5988104+02:00",
  "FirstReadByOwner": "2017-01-31T02:49:51.5988104+01:00",
  "FirstReadByUser": "2007-09-22T02:49:51.5988104+02:00",
  "Activate": "2018-07-30T02:49:51.5988104+02:00",
  "ClosedAt": "2013-04-02T02:49:51.5988104+02:00",
  "RepliedAt": "2018-08-16T02:49:51.5988104+02:00",
  "AlertTimeout": "2006-01-10T02:49:51.5988104+01:00",
  "Deadline": "2006-04-06T02:49:51.5988104+02:00",
  "CreatedBy": null,
  "Author": "est",
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
      "PersonId": 828,
      "Mrmrs": "tenetur",
      "Firstname": "Abelardo",
      "Lastname": "Feest",
      "MiddleName": "Koepp Group",
      "Title": "est",
      "Description": "Networked eco-centric hierarchy",
      "Email": "eda_satterfield@haley.name",
      "FullName": "Brad Toy",
      "DirectPhone": "(933)551-9784 x84059",
      "FormalName": "Jerde, O'Conner and Turcotte",
      "CountryId": 818,
      "ContactId": 456,
      "ContactName": "Goyette, Lebsack and Kovacek",
      "Retired": 203,
      "Rank": 737,
      "ActiveInterests": 968,
      "ContactDepartment": "",
      "ContactCountryId": 48,
      "ContactOrgNr": "1176258",
      "FaxPhone": "(387)865-8013 x26700",
      "MobilePhone": "1-370-771-2269",
      "ContactPhone": "(719)415-6557 x1344",
      "AssociateName": "Deckow, Bartell and Goldner",
      "AssociateId": 624,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "enim",
      "Kanalname": "et",
      "Post1": "eius",
      "Post2": "non",
      "Post3": "iure",
      "EmailName": "regan@stokes.com",
      "ContactFullName": "Prof. Lyda Dillon Bednar Sr.",
      "ActiveErpLinks": 557,
      "TicketPriorityId": 645,
      "SupportLanguageId": 572,
      "SupportAssociateId": 746,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    }
  ],
  "AlertLevel": 354,
  "ConnectId": 523,
  "ReadStatus": "Green",
  "TimeToReply": 1002,
  "RealTimeToReply": 250,
  "TimeToClose": 135,
  "RealTimeToClose": 979,
  "TimeSpentInternally": 415,
  "TimeSpentExternally": 602,
  "TimeSpentQueue": 124,
  "RealTimeSpentInternally": 254,
  "RealTimeSpentExternally": 406,
  "RealTimeSpentQueue": 301,
  "HasAttachment": true,
  "NumReplies": 369,
  "NumMessages": 686,
  "FromAddress": "eum",
  "Messages": [
    {
      "TicketMessageId": 686,
      "CreatedAt": "2008-08-07T02:49:51.6144373+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "iste",
      "PersonId": 835,
      "PersonFullName": "Kody Schiller",
      "ContactId": 847,
      "ContactName": "O'Conner, Morar and Yundt",
      "ContactDepartment": "",
      "NumAttachments": 947,
      "EmailHeader": "denis.dietrich@marvinjerde.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptate",
      "Sentiment": 590,
      "SentimentConfidence": 378,
      "CreatedBy": 615,
      "ChangedAt": "2021-12-02T02:49:51.6144373+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 799,
      "Name": "Farrell, Kuhn and Brakus",
      "ToolTip": "Quisquam ipsa ut deleniti vitae quos sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    },
    {
      "Id": 799,
      "Name": "Farrell, Kuhn and Brakus",
      "ToolTip": "Quisquam ipsa ut deleniti vitae quos sit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    }
  ],
  "Language": "vel",
  "Sentiment": 76,
  "SentimentConfidence": 757,
  "SuggestedCategoryId": 218,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 632,
  "IconHint": "a",
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 154
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```