---
title: POST Agents/Ticket/GetForRmUi
uid: v1TicketAgent_GetForRmUi
generated: true
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
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/GetForRmUi
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketId": 828
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 460,
  "Title": "nobis",
  "CreatedAt": "2004-10-24T13:38:14.2334357+02:00",
  "LastChanged": "1999-12-20T13:38:14.2334357+01:00",
  "ReadByOwner": "2006-07-20T13:38:14.2334357+02:00",
  "ReadByCustomer": "2017-07-13T13:38:14.2334357+02:00",
  "FirstReadByOwner": "2008-10-03T13:38:14.2334357+02:00",
  "FirstReadByUser": "2014-10-10T13:38:14.2334357+02:00",
  "Activate": "1998-01-03T13:38:14.2334357+01:00",
  "ClosedAt": "2014-08-19T13:38:14.2334357+02:00",
  "RepliedAt": "2017-03-05T13:38:14.2334357+01:00",
  "AlertTimeout": "2000-12-07T13:38:14.2334357+01:00",
  "Deadline": "2022-04-25T13:38:14.2334357+02:00",
  "CreatedBy": null,
  "Author": "quo",
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
      "Position": "iste",
      "PersonId": 449,
      "Mrmrs": "et",
      "Firstname": "Christophe",
      "Lastname": "Beatty",
      "MiddleName": "Bruen-Gerhold",
      "Title": "doloremque",
      "Description": "Face to face incremental installation",
      "Email": "mossie.hauck@schoen.us",
      "FullName": "Kiara Davin Hoeger III",
      "DirectPhone": "(289)770-8584",
      "FormalName": "Schneider, Berge and Schaefer",
      "CountryId": 905,
      "ContactId": 861,
      "ContactName": "Botsford-Stehr",
      "Retired": 398,
      "Rank": 530,
      "ActiveInterests": 421,
      "ContactDepartment": "",
      "ContactCountryId": 109,
      "ContactOrgNr": "1453879",
      "FaxPhone": "(852)648-0549",
      "MobilePhone": "(156)292-1547",
      "ContactPhone": "(217)549-0590 x78683",
      "AssociateName": "Pfeffer, Cormier and Turcotte",
      "AssociateId": 934,
      "UsePersonAddress": true,
      "ContactFax": "sed",
      "Kanafname": "unde",
      "Kanalname": "placeat",
      "Post1": "perspiciatis",
      "Post2": "est",
      "Post3": "omnis",
      "EmailName": "sterling@hettingerlakin.uk",
      "ContactFullName": "Prof. Brenden Murl Spencer Sr.",
      "ActiveErpLinks": 25,
      "TicketPriorityId": 941,
      "SupportLanguageId": 676,
      "SupportAssociateId": 850,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "AlertLevel": 833,
  "ConnectId": 929,
  "ReadStatus": "Green",
  "TimeToReply": 404,
  "RealTimeToReply": 604,
  "TimeToClose": 453,
  "RealTimeToClose": 441,
  "TimeSpentInternally": 71,
  "TimeSpentExternally": 224,
  "TimeSpentQueue": 165,
  "RealTimeSpentInternally": 8,
  "RealTimeSpentExternally": 651,
  "RealTimeSpentQueue": 201,
  "TimeSpent": 226,
  "HasAttachment": true,
  "NumReplies": 929,
  "NumMessages": 4,
  "FromAddress": "sint",
  "Messages": [
    {
      "TicketMessageId": 337,
      "CreatedAt": "2008-04-03T13:38:14.2334357+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "aut",
      "PersonId": 916,
      "PersonFullName": "Camryn Laron Ziemann Sr.",
      "ContactId": 132,
      "ContactName": "Watsica-Stoltenberg",
      "ContactDepartment": "",
      "NumAttachments": 65,
      "EmailHeader": "raymond.yundt@pfannerstill.co.uk",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "molestiae",
      "Sentiment": 387,
      "SentimentConfidence": 756,
      "CreatedBy": 954,
      "ChangedAt": "1999-03-04T13:38:14.2334357+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 676,
      "Name": "Bashirian, Kihn and Kilback",
      "ToolTip": "Provident incidunt mollitia voluptates tempora natus rerum amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    },
    {
      "Id": 676,
      "Name": "Bashirian, Kihn and Kilback",
      "ToolTip": "Provident incidunt mollitia voluptates tempora natus rerum amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    }
  ],
  "Language": "ipsam",
  "Sentiment": 636,
  "SentimentConfidence": 48,
  "SuggestedCategoryId": 225,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 571,
  "IconHint": "ut",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "repellendus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 425
    }
  }
}
```