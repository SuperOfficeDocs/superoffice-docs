---
title: POST Agents/Ticket/SaveTicketEntityWithNotify
uid: v1TicketAgent_SaveTicketEntityWithNotify
generated: true
content_type: reference
---

# POST Agents/Ticket/SaveTicketEntityWithNotify

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
```

Saves a ticket and performs any user notifications


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify?$select=name,department,category/id
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

NewEntity, Notify 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NewEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| Notify | Boolean |  |

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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "NewEntity": null,
  "Notify": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 914,
  "Title": "voluptates",
  "CreatedAt": "2019-01-21T02:30:47.9288127+01:00",
  "LastChanged": "2016-09-13T02:30:47.9288127+02:00",
  "ReadByOwner": "2018-10-28T02:30:47.9288127+01:00",
  "ReadByCustomer": "2014-02-13T02:30:47.9288127+01:00",
  "FirstReadByOwner": "2021-07-03T02:30:47.9288127+02:00",
  "FirstReadByUser": "2013-07-03T02:30:47.9288127+02:00",
  "Activate": "2000-09-07T02:30:47.9288127+02:00",
  "ClosedAt": "2005-02-24T02:30:47.9288127+01:00",
  "RepliedAt": "2005-09-17T02:30:47.9288127+02:00",
  "AlertTimeout": "2004-01-20T02:30:47.9288127+01:00",
  "Deadline": "2004-04-19T02:30:47.9288127+02:00",
  "CreatedBy": null,
  "Author": "ut",
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
      "Position": "mollitia",
      "PersonId": 389,
      "Mrmrs": "aut",
      "Firstname": "Jennifer",
      "Lastname": "Shields",
      "MiddleName": "Reichel LLC",
      "Title": "harum",
      "Description": "Multi-tiered web-enabled ability",
      "Email": "murray@homenickwehner.ca",
      "FullName": "Margot Olson",
      "DirectPhone": "227.172.0642 x01544",
      "FormalName": "Hoppe, Rau and Feeney",
      "CountryId": 953,
      "ContactId": 757,
      "ContactName": "Fritsch Inc and Sons",
      "Retired": 474,
      "Rank": 490,
      "ActiveInterests": 999,
      "ContactDepartment": "",
      "ContactCountryId": 623,
      "ContactOrgNr": "1474406",
      "FaxPhone": "726.035.3531",
      "MobilePhone": "(426)103-9691 x5858",
      "ContactPhone": "586-181-7789",
      "AssociateName": "Fritsch-Hamill",
      "AssociateId": 937,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "architecto",
      "Kanalname": "et",
      "Post1": "earum",
      "Post2": "dignissimos",
      "Post3": "deleniti",
      "EmailName": "tabitha.yost@zboncakstiedemann.name",
      "ContactFullName": "Ms. Lisette Stracke",
      "ActiveErpLinks": 448,
      "TicketPriorityId": 112,
      "SupportLanguageId": 968,
      "SupportAssociateId": 404,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1114255",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    }
  ],
  "AlertLevel": 75,
  "ConnectId": 640,
  "ReadStatus": "Green",
  "TimeToReply": 956,
  "RealTimeToReply": 481,
  "TimeToClose": 468,
  "RealTimeToClose": 781,
  "TimeSpentInternally": 105,
  "TimeSpentExternally": 554,
  "TimeSpentQueue": 334,
  "RealTimeSpentInternally": 424,
  "RealTimeSpentExternally": 558,
  "RealTimeSpentQueue": 166,
  "TimeSpent": 774,
  "HasAttachment": true,
  "NumReplies": 364,
  "NumMessages": 483,
  "FromAddress": "asperiores",
  "Messages": [
    {
      "TicketMessageId": 713,
      "CreatedAt": "2013-03-21T02:30:47.9288127+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "suscipit",
      "PersonId": 124,
      "PersonFullName": "Prof. Ila Gislason",
      "ContactId": 259,
      "ContactName": "Cremin, Skiles and Oberbrunner",
      "ContactDepartment": "",
      "NumAttachments": 792,
      "EmailHeader": "chance@price.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "neque",
      "Sentiment": 716,
      "SentimentConfidence": 437,
      "CreatedBy": 526,
      "ChangedAt": "2020-12-13T02:30:47.9288127+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 913,
      "Name": "Auer, Shanahan and Bernhard",
      "ToolTip": "Itaque velit ipsum labore similique exercitationem quis aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    },
    {
      "Id": 913,
      "Name": "Auer, Shanahan and Bernhard",
      "ToolTip": "Itaque velit ipsum labore similique exercitationem quis aut.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "Language": "qui",
  "Sentiment": 994,
  "SentimentConfidence": 89,
  "SuggestedCategoryId": 468,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 421,
  "IconHint": "eligendi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 682,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 134
    }
  }
}
```