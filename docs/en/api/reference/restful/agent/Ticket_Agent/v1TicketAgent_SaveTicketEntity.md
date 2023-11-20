---
title: POST Agents/Ticket/SaveTicketEntity
uid: v1TicketAgent_SaveTicketEntity
generated: true
---

# POST Agents/Ticket/SaveTicketEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketEntity
```

Updates the existing TicketEntity or creates a new TicketEntity if the id parameter is empty








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

## Request Body: entity 

The TicketEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer | The primary key (auto-incremented) |
| Title | String | The title of the ticket. |
| CreatedAt | String | When the ticket was created. |
| LastChanged | String | The last time the ticket was modified. |
| ReadByOwner | String | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | String | The datetime for when the ticket was read by the customer. |
| FirstReadByOwner | String | The datetime for when the ticket first was read by the current owner. |
| FirstReadByUser | String | The datetime for when the ticket first was read by a user. |
| Activate | String | When the ticket should be activated, if it is postponed. |
| ClosedAt | String | When the ticket was closed. |
| RepliedAt | String | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | String | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | String | Deadline for ticket. |
| CreatedBy | Associate | The associate who created this ticket |
| Author | String | A string representing the author of the ticket (same as author of first message). |
| OwnedBy | Associate | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category | TicketCategoryEntity | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | String | The securitylevel of the ticket. |
| Priority | TicketPriorityEntity | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | String | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status | TicketStatusEntity | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | String | What is the origin of this ticket |
| Person | Person | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| SecondaryPersons | Array | The secondary persons this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
| AlertLevel | Integer | The alert level for the ticket. Matches the level value of the ticket_alert table. |
| ConnectId | Integer | If a ticket is connected to another ticket, this field is set to the id of the &amp;apos;master&amp;apos; ticket. |
| ReadStatus | String | Whether the owner has read the ticket or not (red, yellow, green). |
| TimeToReply | Integer | The time (minutes) between when the ticket was created and when it was replied to. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToReply | Integer | Same as time_to_reply, but not calculated based on priority. |
| TimeToClose | Integer | The time (minutes) between when the ticket was created and when it was closed. Calculated based on priority&amp;apos;s timeframe. |
| RealTimeToClose | Integer | Same as time_to_close, but not calculated based on priority. |
| TimeSpentInternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in an open status (configurable), not including current state |
| TimeSpentExternally | Integer | The total time (seconds) within the priority's office hours the ticket has been in a external waiting status (configurable), not including current state |
| TimeSpentQueue | Integer | The total time (seconds) within the priority's office hours the ticket has been in a queue status, not including current state |
| RealTimeSpentInternally | Integer | The total time (seconds) within 24x7 the ticket has been in an open status (configurable), not including current state |
| RealTimeSpentExternally | Integer | The total time (seconds) within 24x7 the ticket has been in a external waiting status (configurable), not including current state |
| RealTimeSpentQueue | Integer | The total time (seconds) within 24x7 hours the ticket has been in a queue status, not including current state |
| TimeSpent | Integer | The total time (minutes). Aggregated time spent from ticket&amp;apos;s messages. Read-only for external use. |
| HasAttachment | Boolean | Boolean indicating if this ticket has one or more attachments. |
| NumReplies | Integer | The number of replies (messages) to the customer for this request. |
| NumMessages | Integer | The total number of messages for this request. |
| FromAddress | String | The from-address used when this ticket got created, e.g. by email |
| Messages | Array | TicketMessageId,CreatedAt,SLevel and Important for all the messages connected to this ticket. For message body see the TicketMessageEntity or the TicketMessage archive. |
| Tags | Array | An array containing the tags assigned to this request |
| Language | String | The language of the first external message |
| Sentiment | Integer | The sentiment index of the last external message |
| SentimentConfidence | Integer | The sentiment confidence of the last external message |
| SuggestedCategoryId | Integer | Suggestion for categorization, based on the text of the message (AI) |
| SuggestedCategoryName | String | Suggested category from AI |
| OrigHumanCategoryId | Integer | Will contain the category id selected by the user, when having the choice of using the suggested category or manually selecting a category |
| IconHint | String | Icon representing ticket's state |
| Sale | Sale | The sale that this ticket is connected to  <para>Use MDO List name "sale" to get list items.</para> |
| Project | Project | The project that this ticket is connected to  <para>Use MDO List name "project" to get list items.</para> |
| FormSubmission | TicketFormSubmission | The form submission that this ticket is connected to |
| TicketType | TicketTypeEntity | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketId": 335,
  "Title": "reprehenderit",
  "CreatedAt": "2019-09-26T13:38:14.2021893+02:00",
  "LastChanged": "1998-09-23T13:38:14.2021893+02:00",
  "ReadByOwner": "1998-02-28T13:38:14.2021893+01:00",
  "ReadByCustomer": "2018-02-12T13:38:14.2021893+01:00",
  "FirstReadByOwner": "2007-06-28T13:38:14.2021893+02:00",
  "FirstReadByUser": "2007-04-05T13:38:14.2021893+02:00",
  "Activate": "2006-04-10T13:38:14.2021893+02:00",
  "ClosedAt": "2008-01-04T13:38:14.2021893+01:00",
  "RepliedAt": "2021-09-16T13:38:14.2021893+02:00",
  "AlertTimeout": "2007-04-10T13:38:14.2021893+02:00",
  "Deadline": "1998-07-12T13:38:14.2021893+02:00",
  "CreatedBy": null,
  "Author": "rerum",
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
      "Position": "nulla",
      "PersonId": 890,
      "Mrmrs": "tempora",
      "Firstname": "Haylee",
      "Lastname": "Schiller",
      "MiddleName": "Eichmann Inc and Sons",
      "Title": "officiis",
      "Description": "Multi-layered executive forecast",
      "Email": "blair@koss.biz",
      "FullName": "Dax Kuhn",
      "DirectPhone": "313-305-8630",
      "FormalName": "Batz Inc and Sons",
      "CountryId": 254,
      "ContactId": 615,
      "ContactName": "Sauer, Nader and Steuber",
      "Retired": 144,
      "Rank": 688,
      "ActiveInterests": 376,
      "ContactDepartment": "",
      "ContactCountryId": 1002,
      "ContactOrgNr": "522504",
      "FaxPhone": "(665)933-6888 x1520",
      "MobilePhone": "(518)805-5456 x47486",
      "ContactPhone": "(595)754-4753",
      "AssociateName": "Cormier-Frami",
      "AssociateId": 260,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "at",
      "Kanalname": "doloremque",
      "Post1": "tempora",
      "Post2": "praesentium",
      "Post3": "odit",
      "EmailName": "jevon@wymanheller.info",
      "ContactFullName": "Josie Boyle",
      "ActiveErpLinks": 992,
      "TicketPriorityId": 346,
      "SupportLanguageId": 871,
      "SupportAssociateId": 159,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 490,
  "ConnectId": 918,
  "ReadStatus": "Green",
  "TimeToReply": 227,
  "RealTimeToReply": 307,
  "TimeToClose": 483,
  "RealTimeToClose": 80,
  "TimeSpentInternally": 589,
  "TimeSpentExternally": 300,
  "TimeSpentQueue": 216,
  "RealTimeSpentInternally": 337,
  "RealTimeSpentExternally": 348,
  "RealTimeSpentQueue": 191,
  "TimeSpent": 202,
  "HasAttachment": false,
  "NumReplies": 749,
  "NumMessages": 111,
  "FromAddress": "fuga",
  "Messages": [
    {
      "TicketMessageId": 233,
      "CreatedAt": "1999-07-25T13:38:14.2021893+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "ut",
      "PersonId": 975,
      "PersonFullName": "Mr. Crawford Wuckert",
      "ContactId": 846,
      "ContactName": "Satterfield, Sawayn and Rowe",
      "ContactDepartment": "",
      "NumAttachments": 691,
      "EmailHeader": "johnathon_hansen@lemke.us",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "debitis",
      "Sentiment": 681,
      "SentimentConfidence": 449,
      "CreatedBy": 552,
      "ChangedAt": "2018-02-09T13:38:14.2021893+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 978,
      "Name": "Johnson-Ziemann",
      "ToolTip": "Earum impedit ut."
    },
    {
      "Id": 978,
      "Name": "Johnson-Ziemann",
      "ToolTip": "Earum impedit ut."
    }
  ],
  "Language": "aspernatur",
  "Sentiment": 499,
  "SentimentConfidence": 862,
  "SuggestedCategoryId": 237,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 525,
  "IconHint": "exercitationem",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "occaecati"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 785,
  "Title": "laudantium",
  "CreatedAt": "2014-07-14T13:38:14.2021893+02:00",
  "LastChanged": "2002-06-28T13:38:14.2021893+02:00",
  "ReadByOwner": "2012-12-02T13:38:14.2021893+01:00",
  "ReadByCustomer": "2000-09-24T13:38:14.2021893+02:00",
  "FirstReadByOwner": "2016-02-18T13:38:14.2021893+01:00",
  "FirstReadByUser": "2008-08-22T13:38:14.2021893+02:00",
  "Activate": "2002-12-18T13:38:14.2021893+01:00",
  "ClosedAt": "2012-09-04T13:38:14.2021893+02:00",
  "RepliedAt": "1997-07-16T13:38:14.2021893+02:00",
  "AlertTimeout": "2022-01-04T13:38:14.2021893+01:00",
  "Deadline": "2010-09-24T13:38:14.2021893+02:00",
  "CreatedBy": null,
  "Author": "quasi",
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
      "Position": "at",
      "PersonId": 876,
      "Mrmrs": "sint",
      "Firstname": "Zella",
      "Lastname": "Shields",
      "MiddleName": "Cormier Group",
      "Title": "dignissimos",
      "Description": "Virtual solution-oriented Graphic Interface",
      "Email": "leonor.kihn@schumm.name",
      "FullName": "Mr. Lionel Dovie McGlynn",
      "DirectPhone": "1-712-776-6343 x4052",
      "FormalName": "Cassin, Huel and Franecki",
      "CountryId": 205,
      "ContactId": 521,
      "ContactName": "Carter, Ortiz and Feil",
      "Retired": 338,
      "Rank": 300,
      "ActiveInterests": 403,
      "ContactDepartment": "",
      "ContactCountryId": 734,
      "ContactOrgNr": "511414",
      "FaxPhone": "212.149.8107 x24438",
      "MobilePhone": "1-808-242-4520 x63116",
      "ContactPhone": "(682)298-6554",
      "AssociateName": "Kiehn-Hettinger",
      "AssociateId": 215,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "similique",
      "Kanalname": "nostrum",
      "Post1": "adipisci",
      "Post2": "voluptas",
      "Post3": "modi",
      "EmailName": "kristina_reichert@lindgrenharris.us",
      "ContactFullName": "Ms. Raheem Marcelo Vandervort PhD",
      "ActiveErpLinks": 381,
      "TicketPriorityId": 746,
      "SupportLanguageId": 424,
      "SupportAssociateId": 313,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 125
        }
      }
    }
  ],
  "AlertLevel": 647,
  "ConnectId": 332,
  "ReadStatus": "Green",
  "TimeToReply": 422,
  "RealTimeToReply": 782,
  "TimeToClose": 43,
  "RealTimeToClose": 691,
  "TimeSpentInternally": 130,
  "TimeSpentExternally": 469,
  "TimeSpentQueue": 82,
  "RealTimeSpentInternally": 60,
  "RealTimeSpentExternally": 611,
  "RealTimeSpentQueue": 712,
  "TimeSpent": 288,
  "HasAttachment": false,
  "NumReplies": 792,
  "NumMessages": 596,
  "FromAddress": "aut",
  "Messages": [
    {
      "TicketMessageId": 333,
      "CreatedAt": "2008-03-23T13:38:14.2021893+01:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quos",
      "PersonId": 710,
      "PersonFullName": "Dr. Catalina Gutkowski V",
      "ContactId": 714,
      "ContactName": "Rutherford, Ernser and Schiller",
      "ContactDepartment": "",
      "NumAttachments": 298,
      "EmailHeader": "erica@legros.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "impedit",
      "Sentiment": 339,
      "SentimentConfidence": 206,
      "CreatedBy": 175,
      "ChangedAt": "2022-01-27T13:38:14.2021893+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 629,
      "Name": "McDermott-Daugherty",
      "ToolTip": "Ut nobis alias.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    },
    {
      "Id": 629,
      "Name": "McDermott-Daugherty",
      "ToolTip": "Ut nobis alias.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "Language": "recusandae",
  "Sentiment": 673,
  "SentimentConfidence": 735,
  "SuggestedCategoryId": 481,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 784,
  "IconHint": "qui",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 393
    }
  }
}
```