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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 610
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 510,
  "Title": "eos",
  "CreatedAt": "2000-06-23T03:31:27.3874142+02:00",
  "LastChanged": "2003-10-18T03:31:27.3874142+02:00",
  "ReadByOwner": "2010-07-14T03:31:27.3874142+02:00",
  "ReadByCustomer": "2014-01-22T03:31:27.3874142+01:00",
  "FirstReadByOwner": "2007-07-29T03:31:27.3874142+02:00",
  "FirstReadByUser": "1998-06-20T03:31:27.3874142+02:00",
  "Activate": "2012-01-15T03:31:27.3874142+01:00",
  "ClosedAt": "2014-12-21T03:31:27.3874142+01:00",
  "RepliedAt": "2018-04-09T03:31:27.3874142+02:00",
  "AlertTimeout": "2001-05-10T03:31:27.3874142+02:00",
  "Deadline": "2000-03-28T03:31:27.3874142+02:00",
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
      "Position": "corporis",
      "PersonId": 560,
      "Mrmrs": "debitis",
      "Firstname": "Clarissa",
      "Lastname": "Graham",
      "MiddleName": "Feil-Wintheiser",
      "Title": "repudiandae",
      "Description": "Enterprise-wide intangible capacity",
      "Email": "kelley.kassulke@turnerboyle.us",
      "FullName": "Trevion Blick",
      "DirectPhone": "914.712.7682",
      "FormalName": "Ullrich, Stoltenberg and Quigley",
      "CountryId": 116,
      "ContactId": 174,
      "ContactName": "Heller LLC",
      "Retired": 687,
      "Rank": 51,
      "ActiveInterests": 660,
      "ContactDepartment": "",
      "ContactCountryId": 685,
      "ContactOrgNr": "1573533",
      "FaxPhone": "708.360.7871",
      "MobilePhone": "470-462-3622 x8290",
      "ContactPhone": "1-531-392-6070 x167",
      "AssociateName": "Strosin LLC",
      "AssociateId": 796,
      "UsePersonAddress": false,
      "ContactFax": "nihil",
      "Kanafname": "illum",
      "Kanalname": "ea",
      "Post1": "deserunt",
      "Post2": "eius",
      "Post3": "dicta",
      "EmailName": "shanie.nikolaus@bashirian.com",
      "ContactFullName": "Gwendolyn Wisozk",
      "ActiveErpLinks": 579,
      "TicketPriorityId": 5,
      "SupportLanguageId": 355,
      "SupportAssociateId": 39,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "AlertLevel": 668,
  "ConnectId": 289,
  "ReadStatus": "Green",
  "TimeToReply": 20,
  "RealTimeToReply": 502,
  "TimeToClose": 950,
  "RealTimeToClose": 36,
  "TimeSpentInternally": 532,
  "TimeSpentExternally": 1002,
  "TimeSpentQueue": 175,
  "RealTimeSpentInternally": 448,
  "RealTimeSpentExternally": 893,
  "RealTimeSpentQueue": 493,
  "HasAttachment": false,
  "NumReplies": 854,
  "NumMessages": 91,
  "FromAddress": "est",
  "Messages": [
    {
      "TicketMessageId": 631,
      "CreatedAt": "1999-11-26T03:31:27.4030353+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ex",
      "PersonId": 502,
      "PersonFullName": "Terry Lang",
      "ContactId": 173,
      "ContactName": "Hansen, Shields and Kuhic",
      "ContactDepartment": "",
      "NumAttachments": 373,
      "EmailHeader": "urban@schambergerjohnson.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "odio",
      "Sentiment": 114,
      "SentimentConfidence": 327,
      "CreatedBy": 159,
      "ChangedAt": "2008-12-23T03:31:27.4030353+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 236,
      "Name": "Hettinger-Thiel",
      "ToolTip": "Odit est distinctio aut expedita ipsa atque harum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    },
    {
      "Id": 236,
      "Name": "Hettinger-Thiel",
      "ToolTip": "Odit est distinctio aut expedita ipsa atque harum.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "Language": "velit",
  "Sentiment": 607,
  "SentimentConfidence": 504,
  "SuggestedCategoryId": 837,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 894,
  "IconHint": "harum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "a",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 171
    }
  }
}
```