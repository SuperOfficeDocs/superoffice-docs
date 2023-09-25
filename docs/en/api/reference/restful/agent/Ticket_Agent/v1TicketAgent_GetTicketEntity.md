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
POST /api/v1/Agents/Ticket/GetTicketEntity?ticketEntityId=163
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
POST /api/v1/Agents/Ticket/GetTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 66,
  "Title": "sit",
  "CreatedAt": "2019-09-19T03:24:48.4247716+02:00",
  "LastChanged": "1999-06-14T03:24:48.4247716+02:00",
  "ReadByOwner": "1998-02-15T03:24:48.4247716+01:00",
  "ReadByCustomer": "2002-02-01T03:24:48.4247716+01:00",
  "FirstReadByOwner": "2010-01-10T03:24:48.4247716+01:00",
  "FirstReadByUser": "2017-03-23T03:24:48.4247716+01:00",
  "Activate": "2003-10-02T03:24:48.4247716+02:00",
  "ClosedAt": "2003-05-25T03:24:48.4247716+02:00",
  "RepliedAt": "2002-07-22T03:24:48.4247716+02:00",
  "AlertTimeout": "2002-04-21T03:24:48.4247716+02:00",
  "Deadline": "2012-05-29T03:24:48.4247716+02:00",
  "CreatedBy": null,
  "Author": "nemo",
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
      "Position": "odit",
      "PersonId": 447,
      "Mrmrs": "similique",
      "Firstname": "Dessie",
      "Lastname": "Boyer",
      "MiddleName": "Halvorson-Turcotte",
      "Title": "fuga",
      "Description": "Synchronised well-modulated encryption",
      "Email": "mauricio_lockman@bradtke.uk",
      "FullName": "Toby Sawayn",
      "DirectPhone": "(687)037-2638 x8153",
      "FormalName": "Rippin Inc and Sons",
      "CountryId": 479,
      "ContactId": 286,
      "ContactName": "Schimmel LLC",
      "Retired": 483,
      "Rank": 808,
      "ActiveInterests": 685,
      "ContactDepartment": "",
      "ContactCountryId": 453,
      "ContactOrgNr": "833947",
      "FaxPhone": "234-574-8619 x492",
      "MobilePhone": "(966)130-3697",
      "ContactPhone": "(883)436-2713 x15979",
      "AssociateName": "Hayes, Conroy and Prohaska",
      "AssociateId": 464,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "nihil",
      "Kanalname": "doloremque",
      "Post1": "fugiat",
      "Post2": "quod",
      "Post3": "ut",
      "EmailName": "arnulfo@jasthermiston.co.uk",
      "ContactFullName": "Christophe Bartell",
      "ActiveErpLinks": 266,
      "TicketPriorityId": 32,
      "SupportLanguageId": 382,
      "SupportAssociateId": 126,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "AlertLevel": 668,
  "ConnectId": 529,
  "ReadStatus": "Green",
  "TimeToReply": 110,
  "RealTimeToReply": 77,
  "TimeToClose": 677,
  "RealTimeToClose": 993,
  "TimeSpentInternally": 409,
  "TimeSpentExternally": 856,
  "TimeSpentQueue": 736,
  "RealTimeSpentInternally": 93,
  "RealTimeSpentExternally": 732,
  "RealTimeSpentQueue": 217,
  "TimeSpent": 572,
  "HasAttachment": true,
  "NumReplies": 495,
  "NumMessages": 774,
  "FromAddress": "tempora",
  "Messages": [
    {
      "TicketMessageId": 346,
      "CreatedAt": "2022-11-30T03:24:48.4247716+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "veniam",
      "PersonId": 453,
      "PersonFullName": "Mr. Michelle Homenick",
      "ContactId": 88,
      "ContactName": "Pollich, Batz and Schimmel",
      "ContactDepartment": "",
      "NumAttachments": 670,
      "EmailHeader": "emilia@monahan.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "voluptatem",
      "Sentiment": 633,
      "SentimentConfidence": 623,
      "CreatedBy": 970,
      "ChangedAt": "2008-10-20T03:24:48.4247716+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 95
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 553,
      "Name": "Kris-Murray",
      "ToolTip": "Quasi laudantium tempore enim dolorem ea nihil quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    },
    {
      "Id": 553,
      "Name": "Kris-Murray",
      "ToolTip": "Quasi laudantium tempore enim dolorem ea nihil quae.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 622
        }
      }
    }
  ],
  "Language": "temporibus",
  "Sentiment": 464,
  "SentimentConfidence": 36,
  "SuggestedCategoryId": 599,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 370,
  "IconHint": "temporibus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 509
    }
  }
}
```