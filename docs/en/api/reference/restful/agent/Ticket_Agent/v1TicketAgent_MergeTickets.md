---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
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

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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

## Sample request

```http!
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    911,
    221
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 185,
  "Title": "aut",
  "CreatedAt": "2014-05-17T16:54:56.5477682+02:00",
  "LastChanged": "2015-08-10T16:54:56.5477682+02:00",
  "ReadByOwner": "2003-12-02T16:54:56.5477682+01:00",
  "ReadByCustomer": "2016-04-05T16:54:56.5477682+02:00",
  "FirstReadByOwner": "2006-11-02T16:54:56.5477682+01:00",
  "FirstReadByUser": "2020-05-30T16:54:56.5477682+02:00",
  "Activate": "2018-02-19T16:54:56.5477682+01:00",
  "ClosedAt": "2021-10-21T16:54:56.5477682+02:00",
  "RepliedAt": "2006-12-28T16:54:56.5477682+01:00",
  "AlertTimeout": "2015-05-02T16:54:56.5477682+02:00",
  "Deadline": "2020-11-23T16:54:56.5477682+01:00",
  "CreatedBy": null,
  "Author": "ea",
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
      "Position": "tempora",
      "PersonId": 608,
      "Mrmrs": "eius",
      "Firstname": "Zane",
      "Lastname": "Mante",
      "MiddleName": "Von Group",
      "Title": "voluptas",
      "Description": "Organized multi-tasking superstructure",
      "Email": "lorena@ullrichjenkins.name",
      "FullName": "Prof. Jadyn Xander Wuckert II",
      "DirectPhone": "498-573-6742 x986",
      "FormalName": "Oberbrunner, Satterfield and Turner",
      "CountryId": 172,
      "ContactId": 300,
      "ContactName": "Kihn, Maggio and Waters",
      "Retired": 270,
      "Rank": 702,
      "ActiveInterests": 460,
      "ContactDepartment": "",
      "ContactCountryId": 338,
      "ContactOrgNr": "531689",
      "FaxPhone": "1-006-815-0272 x577",
      "MobilePhone": "039.923.6957 x8398",
      "ContactPhone": "343-875-4167 x51784",
      "AssociateName": "Jerde-Hirthe",
      "AssociateId": 903,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "voluptatem",
      "Kanalname": "quidem",
      "Post1": "voluptatem",
      "Post2": "quam",
      "Post3": "qui",
      "EmailName": "tamia_considine@cummings.info",
      "ContactFullName": "Trudie Halvorson",
      "ActiveErpLinks": 254,
      "TicketPriorityId": 192,
      "SupportLanguageId": 296,
      "SupportAssociateId": 691,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 928
        }
      }
    }
  ],
  "AlertLevel": 509,
  "ConnectId": 125,
  "ReadStatus": "Green",
  "TimeToReply": 938,
  "RealTimeToReply": 954,
  "TimeToClose": 424,
  "RealTimeToClose": 377,
  "TimeSpentInternally": 112,
  "TimeSpentExternally": 719,
  "TimeSpentQueue": 679,
  "RealTimeSpentInternally": 728,
  "RealTimeSpentExternally": 734,
  "RealTimeSpentQueue": 814,
  "TimeSpent": 522,
  "HasAttachment": false,
  "NumReplies": 600,
  "NumMessages": 890,
  "FromAddress": "non",
  "Messages": [
    {
      "TicketMessageId": 422,
      "CreatedAt": "2012-11-27T16:54:56.5507845+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "tenetur",
      "PersonId": 883,
      "PersonFullName": "William Barton",
      "ContactId": 93,
      "ContactName": "Beier, Durgan and Kessler",
      "ContactDepartment": "",
      "NumAttachments": 703,
      "EmailHeader": "destin@rippin.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "exercitationem",
      "Sentiment": 609,
      "SentimentConfidence": 583,
      "CreatedBy": 909,
      "ChangedAt": "2012-12-07T16:54:56.5517766+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 332,
      "Name": "Schuster, Bradtke and Smith",
      "ToolTip": "Magnam assumenda id eum necessitatibus est omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    },
    {
      "Id": 332,
      "Name": "Schuster, Bradtke and Smith",
      "ToolTip": "Magnam assumenda id eum necessitatibus est omnis.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "Language": "necessitatibus",
  "Sentiment": 3,
  "SentimentConfidence": 351,
  "SuggestedCategoryId": 13,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 719,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 170,
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "amet"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  }
}
```