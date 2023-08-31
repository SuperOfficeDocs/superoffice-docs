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
POST /api/v1/Agents/Ticket/SaveTicketEntityWithNotify
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "NewEntity": null,
  "Notify": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 13,
  "Title": "eius",
  "CreatedAt": "2015-04-23T03:31:27.4186541+02:00",
  "LastChanged": "2013-11-18T03:31:27.4186541+01:00",
  "ReadByOwner": "1999-01-05T03:31:27.4186541+01:00",
  "ReadByCustomer": "2006-01-21T03:31:27.4186541+01:00",
  "FirstReadByOwner": "2015-04-22T03:31:27.4186541+02:00",
  "FirstReadByUser": "2013-04-24T03:31:27.4186541+02:00",
  "Activate": "2011-10-04T03:31:27.4186541+02:00",
  "ClosedAt": "1999-08-17T03:31:27.4186541+02:00",
  "RepliedAt": "2005-06-16T03:31:27.4186541+02:00",
  "AlertTimeout": "2008-09-15T03:31:27.4186541+02:00",
  "Deadline": "2001-04-20T03:31:27.4186541+02:00",
  "CreatedBy": null,
  "Author": "dolorum",
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
      "Position": "ipsum",
      "PersonId": 326,
      "Mrmrs": "rerum",
      "Firstname": "Asa",
      "Lastname": "Fritsch",
      "MiddleName": "Fadel LLC",
      "Title": "magni",
      "Description": "Function-based motivating synergy",
      "Email": "kevin@kulas.com",
      "FullName": "Alexandrea Juliana Kshlerin I",
      "DirectPhone": "218.415.3136",
      "FormalName": "Kuhic-Abbott",
      "CountryId": 413,
      "ContactId": 400,
      "ContactName": "Zieme Group",
      "Retired": 465,
      "Rank": 536,
      "ActiveInterests": 119,
      "ContactDepartment": "",
      "ContactCountryId": 913,
      "ContactOrgNr": "682748",
      "FaxPhone": "437-515-1241",
      "MobilePhone": "(872)399-0407",
      "ContactPhone": "635.671.7439",
      "AssociateName": "Romaguera-Jenkins",
      "AssociateId": 826,
      "UsePersonAddress": false,
      "ContactFax": "ad",
      "Kanafname": "aperiam",
      "Kanalname": "earum",
      "Post1": "temporibus",
      "Post2": "eum",
      "Post3": "perspiciatis",
      "EmailName": "emmet.morar@wintheiser.com",
      "ContactFullName": "Isai O'Kon",
      "ActiveErpLinks": 238,
      "TicketPriorityId": 698,
      "SupportLanguageId": 497,
      "SupportAssociateId": 662,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    }
  ],
  "AlertLevel": 44,
  "ConnectId": 966,
  "ReadStatus": "Green",
  "TimeToReply": 823,
  "RealTimeToReply": 898,
  "TimeToClose": 854,
  "RealTimeToClose": 963,
  "TimeSpentInternally": 167,
  "TimeSpentExternally": 126,
  "TimeSpentQueue": 322,
  "RealTimeSpentInternally": 274,
  "RealTimeSpentExternally": 662,
  "RealTimeSpentQueue": 937,
  "HasAttachment": true,
  "NumReplies": 893,
  "NumMessages": 436,
  "FromAddress": "tempore",
  "Messages": [
    {
      "TicketMessageId": 728,
      "CreatedAt": "2008-08-28T03:31:27.4186541+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ratione",
      "PersonId": 743,
      "PersonFullName": "Mr. Leone Kari Wuckert",
      "ContactId": 755,
      "ContactName": "Rohan Inc and Sons",
      "ContactDepartment": "",
      "NumAttachments": 668,
      "EmailHeader": "angelo.jast@greenfelderschowalter.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "corrupti",
      "Sentiment": 910,
      "SentimentConfidence": 877,
      "CreatedBy": 186,
      "ChangedAt": "2020-12-25T03:31:27.4186541+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 255
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 854,
      "Name": "Boyer Inc and Sons",
      "ToolTip": "A eveniet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    },
    {
      "Id": 854,
      "Name": "Boyer Inc and Sons",
      "ToolTip": "A eveniet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "Language": "commodi",
  "Sentiment": 878,
  "SentimentConfidence": 689,
  "SuggestedCategoryId": 869,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 818,
  "IconHint": "rerum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "iusto"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 76
    }
  }
}
```