---
title: GET Ticket/default
uid: v1TicketEntity_DefaultTicketEntity
generated: true
content_type: reference
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
GET /api/v1/Ticket/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 659,
  "Title": "eum",
  "CreatedAt": "2011-03-01T11:24:53.5936832+01:00",
  "LastChanged": "2023-08-11T11:24:53.5936832+02:00",
  "ReadByOwner": "2014-07-23T11:24:53.5936832+02:00",
  "ReadByCustomer": "2006-09-22T11:24:53.5936832+02:00",
  "FirstReadByOwner": "2016-09-20T11:24:53.5936832+02:00",
  "FirstReadByUser": "2004-06-21T11:24:53.5936832+02:00",
  "Activate": "2015-09-03T11:24:53.5936832+02:00",
  "ClosedAt": "2021-07-11T11:24:53.5936832+02:00",
  "RepliedAt": "2010-09-01T11:24:53.5936832+02:00",
  "AlertTimeout": "2014-07-13T11:24:53.5936832+02:00",
  "Deadline": "2012-09-16T11:24:53.5936832+02:00",
  "CreatedBy": null,
  "Author": "unde",
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
      "PersonId": 369,
      "Mrmrs": "delectus",
      "Firstname": "Berry",
      "Lastname": "Murray",
      "MiddleName": "Hyatt, Sipes and Stehr",
      "Title": "voluptatibus",
      "Description": "Open-architected assymetric time-frame",
      "Email": "kaela@russelkuvalis.info",
      "FullName": "Forrest Judah Hayes Jr.",
      "DirectPhone": "1-341-392-3096 x36286",
      "FormalName": "Littel-Orn",
      "CountryId": 317,
      "ContactId": 89,
      "ContactName": "Marquardt-White",
      "Retired": 676,
      "Rank": 213,
      "ActiveInterests": 782,
      "ContactDepartment": "",
      "ContactCountryId": 378,
      "ContactOrgNr": "948028",
      "FaxPhone": "(214)105-0564",
      "MobilePhone": "390.489.4154 x98139",
      "ContactPhone": "302-465-3360",
      "AssociateName": "Braun, Wintheiser and Kuhlman",
      "AssociateId": 505,
      "UsePersonAddress": false,
      "ContactFax": "cupiditate",
      "Kanafname": "placeat",
      "Kanalname": "aut",
      "Post1": "commodi",
      "Post2": "explicabo",
      "Post3": "distinctio",
      "EmailName": "hershel_braun@hesselaltenwerth.ca",
      "ContactFullName": "Mrs. Alize Alexys Rutherford III",
      "ActiveErpLinks": 202,
      "TicketPriorityId": 157,
      "SupportLanguageId": 617,
      "SupportAssociateId": 17,
      "CategoryName": "VIP Customer",
      "PersonNumber": "879076",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "AlertLevel": 122,
  "ConnectId": 744,
  "ReadStatus": "Green",
  "TimeToReply": 31,
  "RealTimeToReply": 978,
  "TimeToClose": 296,
  "RealTimeToClose": 269,
  "TimeSpentInternally": 308,
  "TimeSpentExternally": 522,
  "TimeSpentQueue": 265,
  "RealTimeSpentInternally": 711,
  "RealTimeSpentExternally": 423,
  "RealTimeSpentQueue": 288,
  "TimeSpent": 613,
  "HasAttachment": true,
  "NumReplies": 876,
  "NumMessages": 120,
  "FromAddress": "modi",
  "Messages": [
    {
      "TicketMessageId": 912,
      "CreatedAt": "2010-07-18T11:24:53.5936832+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quo",
      "PersonId": 159,
      "PersonFullName": "Prof. Alice Luettgen PhD",
      "ContactId": 984,
      "ContactName": "Waelchi, Stokes and Jewess",
      "ContactDepartment": "",
      "NumAttachments": 970,
      "EmailHeader": "sigurd@berniermertz.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ea",
      "Sentiment": 87,
      "SentimentConfidence": 149,
      "CreatedBy": 25,
      "ChangedAt": "1998-08-17T11:24:53.5936832+02:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 309,
      "Name": "Hudson, Mitchell and Beer",
      "ToolTip": "Sequi deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 739
        }
      }
    },
    {
      "Id": 309,
      "Name": "Hudson, Mitchell and Beer",
      "ToolTip": "Sequi deleniti.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 739
        }
      }
    }
  ],
  "Language": "repellendus",
  "Sentiment": 844,
  "SentimentConfidence": 110,
  "SuggestedCategoryId": 858,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 178,
  "IconHint": "aliquam",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 608,
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "fugiat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 785
    }
  }
}
```