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
  "TicketId": 228,
  "Title": "optio",
  "CreatedAt": "2007-09-26T03:41:54.2150791+02:00",
  "LastChanged": "2023-11-29T03:41:54.2150791+01:00",
  "ReadByOwner": "2011-03-21T03:41:54.2150791+01:00",
  "ReadByCustomer": "2006-10-08T03:41:54.2150791+02:00",
  "FirstReadByOwner": "2016-10-06T03:41:54.2150791+02:00",
  "FirstReadByUser": "2009-09-01T03:41:54.2150791+02:00",
  "Activate": "1999-07-31T03:41:54.2150791+02:00",
  "ClosedAt": "2005-05-25T03:41:54.2150791+02:00",
  "RepliedAt": "2004-03-18T03:41:54.2150791+01:00",
  "AlertTimeout": "2018-09-16T03:41:54.2150791+02:00",
  "Deadline": "1998-08-04T03:41:54.2150791+02:00",
  "CreatedBy": null,
  "Author": "exercitationem",
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
      "PersonId": 937,
      "Mrmrs": "et",
      "Firstname": "Logan",
      "Lastname": "Marquardt",
      "MiddleName": "Wilderman LLC",
      "Title": "fugiat",
      "Description": "Focused bandwidth-monitored customer loyalty",
      "Email": "timmothy_harvey@labadie.biz",
      "FullName": "Breana Mueller",
      "DirectPhone": "267-674-3183 x324",
      "FormalName": "Reinger Group",
      "CountryId": 753,
      "ContactId": 683,
      "ContactName": "Hayes, Nikolaus and Crist",
      "Retired": 584,
      "Rank": 623,
      "ActiveInterests": 845,
      "ContactDepartment": "",
      "ContactCountryId": 280,
      "ContactOrgNr": "1074617",
      "FaxPhone": "1-067-274-9013",
      "MobilePhone": "1-252-295-4315 x57113",
      "ContactPhone": "050.161.8806 x2138",
      "AssociateName": "Corwin-Gerlach",
      "AssociateId": 592,
      "UsePersonAddress": false,
      "ContactFax": "ab",
      "Kanafname": "veniam",
      "Kanalname": "iusto",
      "Post1": "quia",
      "Post2": "eligendi",
      "Post3": "aliquid",
      "EmailName": "jedediah@upton.co.uk",
      "ContactFullName": "Denis Beatty",
      "ActiveErpLinks": 839,
      "TicketPriorityId": 349,
      "SupportLanguageId": 78,
      "SupportAssociateId": 356,
      "CategoryName": "VIP Customer",
      "PersonNumber": "62632",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 399
        }
      }
    }
  ],
  "AlertLevel": 852,
  "ConnectId": 578,
  "ReadStatus": "Green",
  "TimeToReply": 471,
  "RealTimeToReply": 756,
  "TimeToClose": 521,
  "RealTimeToClose": 984,
  "TimeSpentInternally": 518,
  "TimeSpentExternally": 438,
  "TimeSpentQueue": 761,
  "RealTimeSpentInternally": 786,
  "RealTimeSpentExternally": 708,
  "RealTimeSpentQueue": 986,
  "TimeSpent": 171,
  "HasAttachment": true,
  "NumReplies": 852,
  "NumMessages": 657,
  "FromAddress": "eaque",
  "Messages": [
    {
      "TicketMessageId": 312,
      "CreatedAt": "2002-05-30T03:41:54.2150791+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ex",
      "PersonId": 937,
      "PersonFullName": "Mr. Pearl Benton Donnelly",
      "ContactId": 333,
      "ContactName": "Lehner, Green and Cole",
      "ContactDepartment": "",
      "NumAttachments": 192,
      "EmailHeader": "jaylen@runolfsdottir.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "eius",
      "Sentiment": 26,
      "SentimentConfidence": 79,
      "CreatedBy": 625,
      "ChangedAt": "2002-03-16T03:41:54.2150791+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 275,
      "Name": "Lesch, Collier and Parker",
      "ToolTip": "Fuga voluptas tempore asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Id": 275,
      "Name": "Lesch, Collier and Parker",
      "ToolTip": "Fuga voluptas tempore asperiores.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "Language": "eaque",
  "Sentiment": 587,
  "SentimentConfidence": 54,
  "SuggestedCategoryId": 451,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 219,
  "IconHint": "at",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 32,
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 997
    }
  }
}
```