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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "maxime",
    "value": {}
  },
  {
    "op": "add",
    "path": "maxime",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 555,
  "Title": "exercitationem",
  "CreatedAt": "2001-04-23T10:18:00.7699763+02:00",
  "LastChanged": "2001-01-21T10:18:00.7699763+01:00",
  "ReadByOwner": "2019-12-05T10:18:00.7699763+01:00",
  "ReadByCustomer": "2016-04-28T10:18:00.7699763+02:00",
  "FirstReadByOwner": "2019-12-29T10:18:00.7699763+01:00",
  "FirstReadByUser": "2016-08-27T10:18:00.7699763+02:00",
  "Activate": "2003-08-28T10:18:00.7699763+02:00",
  "ClosedAt": "2007-01-27T10:18:00.7699763+01:00",
  "RepliedAt": "2016-10-21T10:18:00.7699763+02:00",
  "AlertTimeout": "2009-11-04T10:18:00.7699763+01:00",
  "Deadline": "2021-06-12T10:18:00.7699763+02:00",
  "CreatedBy": null,
  "Author": "qui",
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
      "Position": "dolore",
      "PersonId": 822,
      "Mrmrs": "sed",
      "Firstname": "Hannah",
      "Lastname": "Gottlieb",
      "MiddleName": "Lehner-Wuckert",
      "Title": "ratione",
      "Description": "Digitized coherent throughput",
      "Email": "cynthia_bernhard@kertzmann.us",
      "FullName": "Mr. Gregorio Bartell",
      "DirectPhone": "280.211.7421 x362",
      "FormalName": "Moen-Labadie",
      "CountryId": 455,
      "ContactId": 801,
      "ContactName": "Gutmann Group",
      "Retired": 768,
      "Rank": 411,
      "ActiveInterests": 538,
      "ContactDepartment": "",
      "ContactCountryId": 842,
      "ContactOrgNr": "1282748",
      "FaxPhone": "316.171.2342 x59673",
      "MobilePhone": "520.959.0945 x17006",
      "ContactPhone": "(659)763-8861",
      "AssociateName": "Nitzsche Inc and Sons",
      "AssociateId": 998,
      "UsePersonAddress": false,
      "ContactFax": "tempora",
      "Kanafname": "nihil",
      "Kanalname": "qui",
      "Post1": "culpa",
      "Post2": "et",
      "Post3": "laudantium",
      "EmailName": "erna@stoltenberghirthe.biz",
      "ContactFullName": "Barbara Nikolaus",
      "ActiveErpLinks": 815,
      "TicketPriorityId": 614,
      "SupportLanguageId": 284,
      "SupportAssociateId": 414,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 306
        }
      }
    }
  ],
  "AlertLevel": 876,
  "ConnectId": 855,
  "ReadStatus": "Green",
  "TimeToReply": 462,
  "RealTimeToReply": 507,
  "TimeToClose": 56,
  "RealTimeToClose": 885,
  "TimeSpentInternally": 282,
  "TimeSpentExternally": 276,
  "TimeSpentQueue": 426,
  "RealTimeSpentInternally": 289,
  "RealTimeSpentExternally": 482,
  "RealTimeSpentQueue": 199,
  "TimeSpent": 808,
  "HasAttachment": false,
  "NumReplies": 393,
  "NumMessages": 897,
  "FromAddress": "quisquam",
  "Messages": [
    {
      "TicketMessageId": 761,
      "CreatedAt": "2008-01-07T10:18:00.7699763+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "iusto",
      "PersonId": 840,
      "PersonFullName": "Reva Quentin Brakus V",
      "ContactId": 713,
      "ContactName": "Bradtke, Wiza and Wisozk",
      "ContactDepartment": "",
      "NumAttachments": 475,
      "EmailHeader": "noemi@baumbachward.com",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "recusandae",
      "Sentiment": 443,
      "SentimentConfidence": 144,
      "CreatedBy": 421,
      "ChangedAt": "2017-06-29T10:18:00.7699763+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 332,
      "Name": "Johns Group",
      "ToolTip": "Possimus similique ad neque dolor quia cupiditate consequatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    },
    {
      "Id": 332,
      "Name": "Johns Group",
      "ToolTip": "Possimus similique ad neque dolor quia cupiditate consequatur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Language": "nisi",
  "Sentiment": 568,
  "SentimentConfidence": 194,
  "SuggestedCategoryId": 600,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 71,
  "IconHint": "corrupti",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 397,
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 430
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```