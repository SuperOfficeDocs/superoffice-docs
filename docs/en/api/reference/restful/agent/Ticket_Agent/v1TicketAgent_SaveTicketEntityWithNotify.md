---
title: POST Agents/Ticket/SaveTicketEntityWithNotify
uid: v1TicketAgent_SaveTicketEntityWithNotify
generated: true
---

# POST Agents/Ticket/SaveTicketEntityWithNotify

```http
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
```

Saves a ticket and performs any user notifications







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
  "TicketId": 82,
  "Title": "veniam",
  "CreatedAt": "2015-01-28T14:13:41.4851827+01:00",
  "LastChanged": "2015-11-21T14:13:41.4851827+01:00",
  "ReadByOwner": "2009-09-11T14:13:41.4851827+02:00",
  "ReadByCustomer": "2005-10-19T14:13:41.4851827+02:00",
  "FirstReadByOwner": "2016-02-27T14:13:41.4851827+01:00",
  "FirstReadByUser": "1997-12-24T14:13:41.4851827+01:00",
  "Activate": "2000-05-02T14:13:41.4851827+02:00",
  "ClosedAt": "2010-08-22T14:13:41.4851827+02:00",
  "RepliedAt": "2011-10-21T14:13:41.4851827+02:00",
  "AlertTimeout": "2010-04-12T14:13:41.4851827+02:00",
  "Deadline": "2016-11-06T14:13:41.4851827+01:00",
  "CreatedBy": null,
  "Author": "ipsum",
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
      "Position": "consequuntur",
      "PersonId": 40,
      "Mrmrs": "ipsa",
      "Firstname": "Hayley",
      "Lastname": "Bechtelar",
      "MiddleName": "Marvin, Gulgowski and Harris",
      "Title": "autem",
      "Description": "Face to face regional instruction set",
      "Email": "mervin@schummdickinson.com",
      "FullName": "Mr. Kade Moen DVM",
      "DirectPhone": "1-921-594-9261",
      "FormalName": "Cremin, Hahn and Pfeffer",
      "CountryId": 798,
      "ContactId": 416,
      "ContactName": "Blick, Price and Parker",
      "Retired": 872,
      "Rank": 409,
      "ActiveInterests": 999,
      "ContactDepartment": "",
      "ContactCountryId": 371,
      "ContactOrgNr": "777917",
      "FaxPhone": "066-521-4660",
      "MobilePhone": "635.600.4923",
      "ContactPhone": "309.655.7723 x2825",
      "AssociateName": "Monahan-Weber",
      "AssociateId": 24,
      "UsePersonAddress": false,
      "ContactFax": "delectus",
      "Kanafname": "pariatur",
      "Kanalname": "harum",
      "Post1": "deleniti",
      "Post2": "et",
      "Post3": "accusantium",
      "EmailName": "serenity@franeckigulgowski.com",
      "ContactFullName": "Ms. Raven Jaqueline Tillman",
      "ActiveErpLinks": 261,
      "TicketPriorityId": 615,
      "SupportLanguageId": 819,
      "SupportAssociateId": 559,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1209662",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 647
        }
      }
    }
  ],
  "AlertLevel": 105,
  "ConnectId": 511,
  "ReadStatus": "Green",
  "TimeToReply": 641,
  "RealTimeToReply": 896,
  "TimeToClose": 598,
  "RealTimeToClose": 836,
  "TimeSpentInternally": 893,
  "TimeSpentExternally": 123,
  "TimeSpentQueue": 54,
  "RealTimeSpentInternally": 132,
  "RealTimeSpentExternally": 557,
  "RealTimeSpentQueue": 831,
  "TimeSpent": 81,
  "HasAttachment": false,
  "NumReplies": 135,
  "NumMessages": 720,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 890,
      "CreatedAt": "2004-06-03T14:13:41.4851827+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "in",
      "PersonId": 557,
      "PersonFullName": "Colin Thompson III",
      "ContactId": 129,
      "ContactName": "Connelly, Hilll and Miller",
      "ContactDepartment": "",
      "NumAttachments": 636,
      "EmailHeader": "ivy@wiza.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "autem",
      "Sentiment": 332,
      "SentimentConfidence": 646,
      "CreatedBy": 871,
      "ChangedAt": "2005-01-28T14:13:41.4851827+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 257,
      "Name": "Wuckert, West and Skiles",
      "ToolTip": "In modi quo vitae eos sit nihil placeat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    },
    {
      "Id": 257,
      "Name": "Wuckert, West and Skiles",
      "ToolTip": "In modi quo vitae eos sit nihil placeat.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    }
  ],
  "Language": "libero",
  "Sentiment": 852,
  "SentimentConfidence": 120,
  "SuggestedCategoryId": 481,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 761,
  "IconHint": "deleniti",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 470,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "earum"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 302
    }
  }
}
```