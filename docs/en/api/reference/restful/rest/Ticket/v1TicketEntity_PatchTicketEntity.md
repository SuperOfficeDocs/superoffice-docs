---
title: PATCH Ticket/{id}
uid: v1TicketEntity_PatchTicketEntity
generated: true
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

## Request Body: changes 

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
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Ticket/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "sit",
    "value": {}
  },
  {
    "op": "add",
    "path": "sit",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 657,
  "Title": "neque",
  "CreatedAt": "2013-11-14T11:44:42.6170062+01:00",
  "LastChanged": "2023-10-29T11:44:42.6170062+01:00",
  "ReadByOwner": "2002-04-12T11:44:42.6170062+02:00",
  "ReadByCustomer": "2014-02-03T11:44:42.6170062+01:00",
  "FirstReadByOwner": "2017-07-03T11:44:42.6170062+02:00",
  "FirstReadByUser": "2007-06-14T11:44:42.6170062+02:00",
  "Activate": "2009-12-01T11:44:42.6170062+01:00",
  "ClosedAt": "1998-06-18T11:44:42.6170062+02:00",
  "RepliedAt": "2006-04-02T11:44:42.6170062+02:00",
  "AlertTimeout": "2022-07-07T11:44:42.6170062+02:00",
  "Deadline": "2023-06-30T11:44:42.6170062+02:00",
  "CreatedBy": null,
  "Author": "ipsam",
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
      "Position": "aspernatur",
      "PersonId": 346,
      "Mrmrs": "aut",
      "Firstname": "Reva",
      "Lastname": "Nicolas",
      "MiddleName": "O'Reilly-Kertzmann",
      "Title": "deserunt",
      "Description": "Stand-alone global moderator",
      "Email": "casandra_waelchi@stokes.biz",
      "FullName": "Dr. Jessika Ariane Lesch",
      "DirectPhone": "411-383-9055",
      "FormalName": "Wilderman LLC",
      "CountryId": 573,
      "ContactId": 534,
      "ContactName": "Conroy Inc and Sons",
      "Retired": 739,
      "Rank": 194,
      "ActiveInterests": 812,
      "ContactDepartment": "",
      "ContactCountryId": 99,
      "ContactOrgNr": "569395",
      "FaxPhone": "812.807.5198 x9886",
      "MobilePhone": "837-414-9153 x48121",
      "ContactPhone": "339-332-2748",
      "AssociateName": "Brekke-Shields",
      "AssociateId": 211,
      "UsePersonAddress": true,
      "ContactFax": "veritatis",
      "Kanafname": "deserunt",
      "Kanalname": "magnam",
      "Post1": "delectus",
      "Post2": "ea",
      "Post3": "facere",
      "EmailName": "jazmyn.legros@runolfsson.com",
      "ContactFullName": "Miss Geo Wilkinson",
      "ActiveErpLinks": 38,
      "TicketPriorityId": 562,
      "SupportLanguageId": 602,
      "SupportAssociateId": 44,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "AlertLevel": 846,
  "ConnectId": 660,
  "ReadStatus": "Green",
  "TimeToReply": 658,
  "RealTimeToReply": 698,
  "TimeToClose": 137,
  "RealTimeToClose": 763,
  "TimeSpentInternally": 227,
  "TimeSpentExternally": 818,
  "TimeSpentQueue": 114,
  "RealTimeSpentInternally": 26,
  "RealTimeSpentExternally": 165,
  "RealTimeSpentQueue": 219,
  "TimeSpent": 639,
  "HasAttachment": true,
  "NumReplies": 741,
  "NumMessages": 248,
  "FromAddress": "enim",
  "Messages": [
    {
      "TicketMessageId": 3,
      "CreatedAt": "2014-11-23T11:44:42.632629+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "neque",
      "PersonId": 944,
      "PersonFullName": "Teagan Rath",
      "ContactId": 988,
      "ContactName": "Thiel, Nikolaus and Koelpin",
      "ContactDepartment": "scale bricks-and-clicks experiences",
      "NumAttachments": 803,
      "EmailHeader": "marcia@murazik.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "praesentium",
      "Sentiment": 369,
      "SentimentConfidence": 999,
      "CreatedBy": 997,
      "ChangedAt": "1999-05-07T11:44:42.632629+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 639,
      "Name": "Abbott-Quitzon",
      "ToolTip": "Eligendi maxime delectus ipsa omnis architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    },
    {
      "Id": 639,
      "Name": "Abbott-Quitzon",
      "ToolTip": "Eligendi maxime delectus ipsa omnis architecto.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 181,
  "SentimentConfidence": 135,
  "SuggestedCategoryId": 784,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 430,
  "IconHint": "reprehenderit",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 819,
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 616
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```