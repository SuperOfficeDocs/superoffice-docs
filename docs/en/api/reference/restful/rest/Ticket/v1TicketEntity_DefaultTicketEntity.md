---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
---

# GET Ticket/default

```http
GET /api/v1/Ticket/default
```

Set default values into a new TicketEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Ticket agent service CreateDefaultTicketEntity.







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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 129,
  "Title": "at",
  "CreatedAt": "2001-10-16T03:51:34.04818+02:00",
  "LastChanged": "2018-12-21T03:51:34.04818+01:00",
  "ReadByOwner": "2013-12-26T03:51:34.04818+01:00",
  "ReadByCustomer": "2018-01-09T03:51:34.04818+01:00",
  "FirstReadByOwner": "2015-07-06T03:51:34.04818+02:00",
  "FirstReadByUser": "1996-07-16T03:51:34.04818+02:00",
  "Activate": "2011-01-15T03:51:34.04818+01:00",
  "ClosedAt": "1996-08-07T03:51:34.04818+02:00",
  "RepliedAt": "2009-12-05T03:51:34.04818+01:00",
  "AlertTimeout": "2012-02-18T03:51:34.04818+01:00",
  "Deadline": "2010-04-22T03:51:34.04818+02:00",
  "CreatedBy": null,
  "Author": "consectetur",
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
      "Position": "perferendis",
      "PersonId": 51,
      "Mrmrs": "et",
      "Firstname": "Raul",
      "Lastname": "Bradtke",
      "MiddleName": "Cummings-Hoppe",
      "Title": "odio",
      "Description": "Inverse stable knowledge user",
      "Email": "buck@beier.ca",
      "FullName": "Kitty Koepp",
      "DirectPhone": "1-606-836-6011 x51490",
      "FormalName": "Corwin, Beahan and Ward",
      "CountryId": 611,
      "ContactId": 663,
      "ContactName": "Stoltenberg, Spinka and Blanda",
      "Retired": 745,
      "Rank": 154,
      "ActiveInterests": 733,
      "ContactDepartment": "",
      "ContactCountryId": 371,
      "ContactOrgNr": "1169628",
      "FaxPhone": "1-164-744-6505 x131",
      "MobilePhone": "359-844-7010 x26729",
      "ContactPhone": "646.252.1432",
      "AssociateName": "Crist Group",
      "AssociateId": 952,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "voluptas",
      "Kanalname": "aut",
      "Post1": "dolorum",
      "Post2": "distinctio",
      "Post3": "et",
      "EmailName": "enola@mann.biz",
      "ContactFullName": "Tracey Gardner Reilly MD",
      "ActiveErpLinks": 224,
      "TicketPriorityId": 140,
      "SupportLanguageId": 649,
      "SupportAssociateId": 272,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "AlertLevel": 513,
  "ConnectId": 390,
  "ReadStatus": "Green",
  "TimeToReply": 519,
  "RealTimeToReply": 968,
  "TimeToClose": 995,
  "RealTimeToClose": 126,
  "TimeSpentInternally": 410,
  "TimeSpentExternally": 666,
  "TimeSpentQueue": 298,
  "RealTimeSpentInternally": 855,
  "RealTimeSpentExternally": 412,
  "RealTimeSpentQueue": 395,
  "HasAttachment": false,
  "NumReplies": 146,
  "NumMessages": 831,
  "FromAddress": "a",
  "Messages": [
    {
      "TicketMessageId": 1002,
      "CreatedAt": "2011-02-14T03:51:34.052187+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "consequuntur",
      "PersonId": 929,
      "PersonFullName": "Prof. Michele Jayden Lynch Sr.",
      "ContactId": 23,
      "ContactName": "Marvin, Stehr and Stroman",
      "ContactDepartment": "",
      "NumAttachments": 554,
      "EmailHeader": "litzy@grady.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "recusandae",
      "Sentiment": 90,
      "SentimentConfidence": 777,
      "CreatedBy": 167,
      "ChangedAt": "1999-01-17T03:51:34.052187+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 586,
      "Name": "Glover-Langosh",
      "ToolTip": "Eligendi eum repellat architecto a odio quisquam amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Id": 586,
      "Name": "Glover-Langosh",
      "ToolTip": "Eligendi eum repellat architecto a odio quisquam amet.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "Language": "harum",
  "Sentiment": 158,
  "SentimentConfidence": 217,
  "SuggestedCategoryId": 139,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 698,
  "IconHint": "modi",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "totam",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 622
    }
  }
}
```