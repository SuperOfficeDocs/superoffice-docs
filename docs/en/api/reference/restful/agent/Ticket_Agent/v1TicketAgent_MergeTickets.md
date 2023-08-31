---
title: POST Agents/Ticket/MergeTickets
uid: v1TicketAgent_MergeTickets
generated: true
---

# POST Agents/Ticket/MergeTickets

```http
POST /api/v1/Agents/Ticket/MergeTickets
```

Merge one or more tickets into one primary ticket







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/MergeTickets?$select=name,department,category/id
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

MergedTicketEntity, SecondaryTicketIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MergedTicketEntity | TicketEntity | The ticket entity is used for representing a service ticket <para /> Carrier object for TicketEntity. Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| SecondaryTicketIds | Array |  |

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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    692,
    14
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 61,
  "Title": "repellendus",
  "CreatedAt": "2016-11-03T03:31:27.6697456+01:00",
  "LastChanged": "2001-12-28T03:31:27.6697456+01:00",
  "ReadByOwner": "2011-06-01T03:31:27.6697456+02:00",
  "ReadByCustomer": "2018-06-14T03:31:27.6697456+02:00",
  "FirstReadByOwner": "2005-12-20T03:31:27.6697456+01:00",
  "FirstReadByUser": "2004-11-18T03:31:27.6697456+01:00",
  "Activate": "2007-04-14T03:31:27.6697456+02:00",
  "ClosedAt": "1997-03-21T03:31:27.6697456+01:00",
  "RepliedAt": "2004-08-27T03:31:27.6697456+02:00",
  "AlertTimeout": "2007-06-28T03:31:27.6697456+02:00",
  "Deadline": "2014-12-12T03:31:27.6697456+01:00",
  "CreatedBy": null,
  "Author": "dolorem",
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
      "Position": "voluptatem",
      "PersonId": 731,
      "Mrmrs": "ea",
      "Firstname": "Bette",
      "Lastname": "Dickinson",
      "MiddleName": "Monahan Inc and Sons",
      "Title": "at",
      "Description": "Secured logistical emulation",
      "Email": "kenyon_okon@runolfsson.biz",
      "FullName": "Reagan Swift",
      "DirectPhone": "139.007.3244 x32762",
      "FormalName": "Strosin-Mertz",
      "CountryId": 17,
      "ContactId": 229,
      "ContactName": "Hirthe, Schaefer and Conn",
      "Retired": 876,
      "Rank": 152,
      "ActiveInterests": 271,
      "ContactDepartment": "",
      "ContactCountryId": 76,
      "ContactOrgNr": "732746",
      "FaxPhone": "257.078.7681 x212",
      "MobilePhone": "1-920-483-9007",
      "ContactPhone": "672-320-7513 x16283",
      "AssociateName": "Cruickshank, Cole and Cole",
      "AssociateId": 248,
      "UsePersonAddress": true,
      "ContactFax": "ex",
      "Kanafname": "expedita",
      "Kanalname": "quibusdam",
      "Post1": "vero",
      "Post2": "est",
      "Post3": "qui",
      "EmailName": "rebeka@quigleybartell.co.uk",
      "ContactFullName": "Ally Glover",
      "ActiveErpLinks": 946,
      "TicketPriorityId": 429,
      "SupportLanguageId": 414,
      "SupportAssociateId": 45,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "AlertLevel": 864,
  "ConnectId": 853,
  "ReadStatus": "Green",
  "TimeToReply": 839,
  "RealTimeToReply": 932,
  "TimeToClose": 552,
  "RealTimeToClose": 405,
  "TimeSpentInternally": 790,
  "TimeSpentExternally": 561,
  "TimeSpentQueue": 317,
  "RealTimeSpentInternally": 517,
  "RealTimeSpentExternally": 791,
  "RealTimeSpentQueue": 877,
  "HasAttachment": true,
  "NumReplies": 473,
  "NumMessages": 705,
  "FromAddress": "et",
  "Messages": [
    {
      "TicketMessageId": 118,
      "CreatedAt": "2019-12-29T03:31:27.6697456+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "rerum",
      "PersonId": 839,
      "PersonFullName": "Leopoldo Fay IV",
      "ContactId": 912,
      "ContactName": "Weber, Medhurst and Bednar",
      "ContactDepartment": "",
      "NumAttachments": 431,
      "EmailHeader": "jeff@walsh.ca",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "magni",
      "Sentiment": 847,
      "SentimentConfidence": 895,
      "CreatedBy": 610,
      "ChangedAt": "2005-12-20T03:31:27.6697456+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 341,
      "Name": "Stark-Mante",
      "ToolTip": "Cumque fugiat consequuntur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 733
        }
      }
    },
    {
      "Id": 341,
      "Name": "Stark-Mante",
      "ToolTip": "Cumque fugiat consequuntur.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 733
        }
      }
    }
  ],
  "Language": "at",
  "Sentiment": 580,
  "SentimentConfidence": 810,
  "SuggestedCategoryId": 658,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 162,
  "IconHint": "eum",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "repellendus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 725
    }
  }
}
```