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
| TicketType | TicketType | Type of the Request  <para>Use MDO List name "TicketType" to get list items.</para> |
| ActiveStatusMonitorId | Integer | Active status monitor identity for related contact. This is a read-only property and is ignored on Save |
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
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 827,
  "Title": "ad",
  "CreatedAt": "2014-01-30T12:01:28.3534468+01:00",
  "LastChanged": "2001-07-31T12:01:28.3534468+02:00",
  "ReadByOwner": "2022-11-08T12:01:28.3534468+01:00",
  "ReadByCustomer": "2018-04-26T12:01:28.3534468+02:00",
  "FirstReadByOwner": "2004-09-18T12:01:28.3534468+02:00",
  "FirstReadByUser": "2013-03-08T12:01:28.3534468+01:00",
  "Activate": "2023-11-20T12:01:28.3534468+01:00",
  "ClosedAt": "2014-01-09T12:01:28.3534468+01:00",
  "RepliedAt": "2001-05-22T12:01:28.3534468+02:00",
  "AlertTimeout": "2014-07-03T12:01:28.3534468+02:00",
  "Deadline": "1998-06-09T12:01:28.3534468+02:00",
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
      "PersonId": 97,
      "Mrmrs": "ipsa",
      "Firstname": "Audrey",
      "Lastname": "Becker",
      "MiddleName": "Hilll, Gerhold and Runte",
      "Title": "distinctio",
      "Description": "Streamlined eco-centric budgetary management",
      "Email": "jedediah.hintz@white.com",
      "FullName": "Adalberto Feeney PhD",
      "DirectPhone": "1-283-288-8611 x757",
      "FormalName": "Jenkins Inc and Sons",
      "CountryId": 852,
      "ContactId": 953,
      "ContactName": "Lockman-O'Reilly",
      "Retired": 424,
      "Rank": 680,
      "ActiveInterests": 15,
      "ContactDepartment": "",
      "ContactCountryId": 597,
      "ContactOrgNr": "506634",
      "FaxPhone": "1-434-249-7331",
      "MobilePhone": "(473)072-1425",
      "ContactPhone": "321.226.9392",
      "AssociateName": "Feil, Dietrich and Smith",
      "AssociateId": 209,
      "UsePersonAddress": false,
      "ContactFax": "ex",
      "Kanafname": "beatae",
      "Kanalname": "et",
      "Post1": "fugit",
      "Post2": "labore",
      "Post3": "sunt",
      "EmailName": "giovanny.thiel@streich.us",
      "ContactFullName": "Ericka Wolff",
      "ActiveErpLinks": 956,
      "TicketPriorityId": 611,
      "SupportLanguageId": 687,
      "SupportAssociateId": 297,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1502755"
    }
  ],
  "AlertLevel": 545,
  "ConnectId": 577,
  "ReadStatus": "Green",
  "TimeToReply": 530,
  "RealTimeToReply": 502,
  "TimeToClose": 761,
  "RealTimeToClose": 495,
  "TimeSpentInternally": 344,
  "TimeSpentExternally": 767,
  "TimeSpentQueue": 720,
  "RealTimeSpentInternally": 532,
  "RealTimeSpentExternally": 49,
  "RealTimeSpentQueue": 674,
  "TimeSpent": 554,
  "HasAttachment": true,
  "NumReplies": 333,
  "NumMessages": 42,
  "FromAddress": "quae",
  "Messages": [
    {
      "TicketMessageId": 696,
      "CreatedAt": "2015-01-04T12:01:28.3534468+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "explicabo",
      "PersonId": 708,
      "PersonFullName": "Ms. Muriel Ruecker",
      "ContactId": 389,
      "ContactName": "Murray-Bruen",
      "ContactDepartment": "",
      "NumAttachments": 245,
      "EmailHeader": "angelita_ratke@turcotte.name",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "necessitatibus",
      "Sentiment": 443,
      "SentimentConfidence": 192,
      "CreatedBy": 658,
      "ChangedAt": "2000-03-13T12:01:28.3534468+01:00",
      "Badge": "Comment"
    }
  ],
  "Tags": [
    {
      "Id": 128,
      "Name": "Macejkovic-Lockman",
      "ToolTip": "Corporis provident quos velit occaecati eligendi."
    },
    {
      "Id": 128,
      "Name": "Macejkovic-Lockman",
      "ToolTip": "Corporis provident quos velit occaecati eligendi."
    }
  ],
  "Language": "harum",
  "Sentiment": 661,
  "SentimentConfidence": 195,
  "SuggestedCategoryId": 959,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 878,
  "IconHint": "deleniti",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 434,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "commodi"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "aliquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 658,
  "Title": "aspernatur",
  "CreatedAt": "2009-08-26T12:01:28.3534468+02:00",
  "LastChanged": "2009-01-22T12:01:28.3534468+01:00",
  "ReadByOwner": "2015-06-15T12:01:28.3534468+02:00",
  "ReadByCustomer": "2002-09-20T12:01:28.3534468+02:00",
  "FirstReadByOwner": "2015-03-24T12:01:28.3534468+01:00",
  "FirstReadByUser": "2010-04-17T12:01:28.3534468+02:00",
  "Activate": "2024-11-11T12:01:28.3534468+01:00",
  "ClosedAt": "2016-07-09T12:01:28.3534468+02:00",
  "RepliedAt": "2008-04-23T12:01:28.3534468+02:00",
  "AlertTimeout": "2023-01-09T12:01:28.3534468+01:00",
  "Deadline": "2013-05-04T12:01:28.3534468+02:00",
  "CreatedBy": null,
  "Author": "sit",
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
      "Position": "voluptatibus",
      "PersonId": 651,
      "Mrmrs": "repellat",
      "Firstname": "Adelbert",
      "Lastname": "Tillman",
      "MiddleName": "Leffler Inc and Sons",
      "Title": "nostrum",
      "Description": "Multi-layered empowering project",
      "Email": "matilda@medhurstbernier.biz",
      "FullName": "Roxane Greenfelder",
      "DirectPhone": "481-077-3739 x127",
      "FormalName": "Balistreri, Heathcote and Simonis",
      "CountryId": 945,
      "ContactId": 714,
      "ContactName": "Steuber-Ruecker",
      "Retired": 886,
      "Rank": 986,
      "ActiveInterests": 354,
      "ContactDepartment": "",
      "ContactCountryId": 329,
      "ContactOrgNr": "1960287",
      "FaxPhone": "1-102-063-8321 x6854",
      "MobilePhone": "(219)851-0710",
      "ContactPhone": "(701)852-4784 x380",
      "AssociateName": "Wiza Inc and Sons",
      "AssociateId": 43,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "doloribus",
      "Kanalname": "corporis",
      "Post1": "expedita",
      "Post2": "eius",
      "Post3": "est",
      "EmailName": "polly_ohara@carroll.info",
      "ContactFullName": "Kendall Schowalter",
      "ActiveErpLinks": 319,
      "TicketPriorityId": 467,
      "SupportLanguageId": 613,
      "SupportAssociateId": 554,
      "CategoryName": "VIP Customer",
      "PersonNumber": "699073",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 684
        }
      }
    }
  ],
  "AlertLevel": 625,
  "ConnectId": 137,
  "ReadStatus": "Green",
  "TimeToReply": 838,
  "RealTimeToReply": 507,
  "TimeToClose": 4,
  "RealTimeToClose": 647,
  "TimeSpentInternally": 976,
  "TimeSpentExternally": 536,
  "TimeSpentQueue": 364,
  "RealTimeSpentInternally": 101,
  "RealTimeSpentExternally": 906,
  "RealTimeSpentQueue": 433,
  "TimeSpent": 501,
  "HasAttachment": true,
  "NumReplies": 572,
  "NumMessages": 440,
  "FromAddress": "maxime",
  "Messages": [
    {
      "TicketMessageId": 168,
      "CreatedAt": "2004-05-10T12:01:28.3534468+02:00",
      "Slevel": "External",
      "Important": false,
      "Author": "soluta",
      "PersonId": 526,
      "PersonFullName": "Miss Lindsay Trevor Erdman",
      "ContactId": 622,
      "ContactName": "Kozey, Sanford and Ankunding",
      "ContactDepartment": "",
      "NumAttachments": 363,
      "EmailHeader": "bonita_gerlach@hand.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "occaecati",
      "Sentiment": 353,
      "SentimentConfidence": 176,
      "CreatedBy": 274,
      "ChangedAt": "2009-01-16T12:01:28.3534468+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 834
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 965,
      "Name": "Wehner-Blick",
      "ToolTip": "Ad reprehenderit vel enim suscipit facere accusantium aliquid.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    },
    {
      "Id": 965,
      "Name": "Wehner-Blick",
      "ToolTip": "Ad reprehenderit vel enim suscipit facere accusantium aliquid.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Language": "itaque",
  "Sentiment": 216,
  "SentimentConfidence": 245,
  "SuggestedCategoryId": 261,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 465,
  "IconHint": "quos",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 865,
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "inventore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 390
    }
  }
}
```