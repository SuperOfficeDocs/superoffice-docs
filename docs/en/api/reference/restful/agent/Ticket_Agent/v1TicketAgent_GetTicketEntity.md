---
title: POST Agents/Ticket/GetTicketEntity
uid: v1TicketAgent_GetTicketEntity
generated: true
---

# POST Agents/Ticket/GetTicketEntity

```http
POST /api/v1/Agents/Ticket/GetTicketEntity
```

Gets a TicketEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=45
POST /api/v1/Agents/Ticket/GetTicketEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 673,
  "Title": "beatae",
  "CreatedAt": "2004-02-27T03:31:27.3874142+01:00",
  "LastChanged": "2001-03-21T03:31:27.3874142+01:00",
  "ReadByOwner": "1996-06-16T03:31:27.3874142+02:00",
  "ReadByCustomer": "2023-08-15T03:31:27.3874142+02:00",
  "FirstReadByOwner": "1998-05-08T03:31:27.3874142+02:00",
  "FirstReadByUser": "2018-05-06T03:31:27.3874142+02:00",
  "Activate": "2019-05-27T03:31:27.3874142+02:00",
  "ClosedAt": "2007-10-26T03:31:27.3874142+02:00",
  "RepliedAt": "2004-03-15T03:31:27.3874142+01:00",
  "AlertTimeout": "1998-02-10T03:31:27.3874142+01:00",
  "Deadline": "2011-03-24T03:31:27.3874142+01:00",
  "CreatedBy": null,
  "Author": "quia",
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
      "Position": "et",
      "PersonId": 885,
      "Mrmrs": "vel",
      "Firstname": "Rhiannon",
      "Lastname": "Farrell",
      "MiddleName": "Runte, Simonis and Goyette",
      "Title": "fuga",
      "Description": "Re-engineered fault-tolerant intranet",
      "Email": "mac@hayes.uk",
      "FullName": "Arthur Purdy",
      "DirectPhone": "(659)304-8662 x588",
      "FormalName": "Jast Group",
      "CountryId": 684,
      "ContactId": 652,
      "ContactName": "Hermann, Kessler and Crist",
      "Retired": 579,
      "Rank": 109,
      "ActiveInterests": 825,
      "ContactDepartment": "",
      "ContactCountryId": 92,
      "ContactOrgNr": "1703990",
      "FaxPhone": "865-178-5917 x441",
      "MobilePhone": "228.581.2649",
      "ContactPhone": "840-951-1929 x670",
      "AssociateName": "Donnelly LLC",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "porro",
      "Kanafname": "suscipit",
      "Kanalname": "ut",
      "Post1": "nam",
      "Post2": "id",
      "Post3": "dicta",
      "EmailName": "haylee_mayer@simonis.uk",
      "ContactFullName": "Lucious Olson",
      "ActiveErpLinks": 481,
      "TicketPriorityId": 35,
      "SupportLanguageId": 327,
      "SupportAssociateId": 231,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    }
  ],
  "AlertLevel": 226,
  "ConnectId": 378,
  "ReadStatus": "Green",
  "TimeToReply": 7,
  "RealTimeToReply": 474,
  "TimeToClose": 310,
  "RealTimeToClose": 778,
  "TimeSpentInternally": 962,
  "TimeSpentExternally": 761,
  "TimeSpentQueue": 496,
  "RealTimeSpentInternally": 704,
  "RealTimeSpentExternally": 563,
  "RealTimeSpentQueue": 204,
  "HasAttachment": false,
  "NumReplies": 460,
  "NumMessages": 855,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 555,
      "CreatedAt": "2023-04-23T03:31:27.3874142+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quaerat",
      "PersonId": 609,
      "PersonFullName": "Amely Breitenberg DDS",
      "ContactId": 169,
      "ContactName": "Osinski, McClure and Moen",
      "ContactDepartment": "",
      "NumAttachments": 274,
      "EmailHeader": "davion.mertz@koelpinreynolds.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "excepturi",
      "Sentiment": 785,
      "SentimentConfidence": 561,
      "CreatedBy": 531,
      "ChangedAt": "2019-03-08T03:31:27.3874142+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 535,
      "Name": "Bosco-Cummerata",
      "ToolTip": "Consequatur sapiente.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Id": 535,
      "Name": "Bosco-Cummerata",
      "ToolTip": "Consequatur sapiente.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Language": "beatae",
  "Sentiment": 769,
  "SentimentConfidence": 490,
  "SuggestedCategoryId": 630,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 966,
  "IconHint": "expedita",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "vitae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 643
    }
  }
}
```