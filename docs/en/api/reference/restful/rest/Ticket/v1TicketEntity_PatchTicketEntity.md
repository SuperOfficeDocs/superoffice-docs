---
title: PATCH Ticket/{id}
uid: v1TicketEntity_PatchTicketEntity
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "id",
    "value": {}
  },
  {
    "op": "add",
    "path": "id",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 TicketEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "TicketId": 406,
  "Title": "sit",
  "CreatedAt": "2004-06-09T11:24:53.6249318+02:00",
  "LastChanged": "2022-07-27T11:24:53.6249318+02:00",
  "ReadByOwner": "2000-02-13T11:24:53.6249318+01:00",
  "ReadByCustomer": "1998-09-04T11:24:53.6249318+02:00",
  "FirstReadByOwner": "2008-03-04T11:24:53.6249318+01:00",
  "FirstReadByUser": "2002-01-11T11:24:53.6249318+01:00",
  "Activate": "2005-11-12T11:24:53.6249318+01:00",
  "ClosedAt": "2001-01-04T11:24:53.6249318+01:00",
  "RepliedAt": "2022-07-14T11:24:53.6249318+02:00",
  "AlertTimeout": "2017-03-21T11:24:53.6249318+01:00",
  "Deadline": "2001-11-22T11:24:53.6249318+01:00",
  "CreatedBy": null,
  "Author": "consequatur",
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
      "Position": "possimus",
      "PersonId": 529,
      "Mrmrs": "vel",
      "Firstname": "Liliane",
      "Lastname": "Greenholt",
      "MiddleName": "Kulas-Wolff",
      "Title": "quas",
      "Description": "Networked 24/7 flexibility",
      "Email": "darrick@metz.biz",
      "FullName": "Carolyn Smitham",
      "DirectPhone": "797.442.0214 x6691",
      "FormalName": "Cummings, Abbott and Wolf",
      "CountryId": 740,
      "ContactId": 140,
      "ContactName": "Morar LLC",
      "Retired": 896,
      "Rank": 743,
      "ActiveInterests": 283,
      "ContactDepartment": "",
      "ContactCountryId": 485,
      "ContactOrgNr": "713463",
      "FaxPhone": "486.107.1395",
      "MobilePhone": "(566)000-2818 x397",
      "ContactPhone": "296.739.9045",
      "AssociateName": "Carter LLC",
      "AssociateId": 505,
      "UsePersonAddress": true,
      "ContactFax": "dolore",
      "Kanafname": "veniam",
      "Kanalname": "porro",
      "Post1": "omnis",
      "Post2": "mollitia",
      "Post3": "laudantium",
      "EmailName": "kraig.renner@herman.com",
      "ContactFullName": "Vivian Rau DDS",
      "ActiveErpLinks": 420,
      "TicketPriorityId": 931,
      "SupportLanguageId": 626,
      "SupportAssociateId": 659,
      "CategoryName": "VIP Customer",
      "PersonNumber": "451210",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 488
        }
      }
    }
  ],
  "AlertLevel": 72,
  "ConnectId": 269,
  "ReadStatus": "Green",
  "TimeToReply": 216,
  "RealTimeToReply": 340,
  "TimeToClose": 147,
  "RealTimeToClose": 9,
  "TimeSpentInternally": 115,
  "TimeSpentExternally": 638,
  "TimeSpentQueue": 898,
  "RealTimeSpentInternally": 399,
  "RealTimeSpentExternally": 277,
  "RealTimeSpentQueue": 300,
  "TimeSpent": 709,
  "HasAttachment": false,
  "NumReplies": 908,
  "NumMessages": 424,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 512,
      "CreatedAt": "2002-04-18T11:24:53.6249318+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "beatae",
      "PersonId": 974,
      "PersonFullName": "Stevie O'Reilly",
      "ContactId": 7,
      "ContactName": "Durgan, Prosacco and Nolan",
      "ContactDepartment": "",
      "NumAttachments": 706,
      "EmailHeader": "triston.wehner@altenwerthmcglynn.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "et",
      "Sentiment": 89,
      "SentimentConfidence": 72,
      "CreatedBy": 518,
      "ChangedAt": "2013-10-25T11:24:53.6249318+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 857
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 318,
      "Name": "Rempel, Feest and Runolfsson",
      "ToolTip": "Blanditiis a voluptas nobis voluptatum impedit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    },
    {
      "Id": 318,
      "Name": "Rempel, Feest and Runolfsson",
      "ToolTip": "Blanditiis a voluptas nobis voluptatum impedit.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "Language": "illo",
  "Sentiment": 4,
  "SentimentConfidence": 203,
  "SuggestedCategoryId": 480,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 714,
  "IconHint": "tempora",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 503,
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "blanditiis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 718
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```