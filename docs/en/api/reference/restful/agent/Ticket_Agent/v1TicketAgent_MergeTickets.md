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
POST /api/v1/Agents/Ticket/MergeTickets
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MergedTicketEntity": null,
  "SecondaryTicketIds": [
    425,
    121
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 272,
  "Title": "quis",
  "CreatedAt": "1997-08-15T10:30:24.9048294+02:00",
  "LastChanged": "2016-07-09T10:30:24.9048294+02:00",
  "ReadByOwner": "2005-06-19T10:30:24.9048294+02:00",
  "ReadByCustomer": "2014-12-07T10:30:24.9048294+01:00",
  "FirstReadByOwner": "2019-06-07T10:30:24.9048294+02:00",
  "FirstReadByUser": "2019-06-27T10:30:24.9048294+02:00",
  "Activate": "1999-07-31T10:30:24.9048294+02:00",
  "ClosedAt": "2023-04-23T10:30:24.9048294+02:00",
  "RepliedAt": "2013-01-14T10:30:24.9048294+01:00",
  "AlertTimeout": "2002-04-01T10:30:24.9048294+02:00",
  "Deadline": "2012-08-14T10:30:24.9048294+02:00",
  "CreatedBy": null,
  "Author": "facilis",
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
      "Position": "ut",
      "PersonId": 995,
      "Mrmrs": "ad",
      "Firstname": "Candace",
      "Lastname": "Runolfsdottir",
      "MiddleName": "Collier, Gaylord and Ledner",
      "Title": "expedita",
      "Description": "Upgradable solution-oriented access",
      "Email": "mitchell@koelpin.ca",
      "FullName": "Heath Goyette",
      "DirectPhone": "(514)097-4692 x6861",
      "FormalName": "Cummings, Wuckert and Wisoky",
      "CountryId": 64,
      "ContactId": 710,
      "ContactName": "Orn Group",
      "Retired": 212,
      "Rank": 62,
      "ActiveInterests": 182,
      "ContactDepartment": "",
      "ContactCountryId": 149,
      "ContactOrgNr": "733061",
      "FaxPhone": "955.881.3208 x18083",
      "MobilePhone": "(189)832-0864",
      "ContactPhone": "609-420-5306 x1231",
      "AssociateName": "Schmitt, Ziemann and Kub",
      "AssociateId": 497,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "sapiente",
      "Kanalname": "voluptatem",
      "Post1": "quos",
      "Post2": "quod",
      "Post3": "aut",
      "EmailName": "caroline_vandervort@johns.us",
      "ContactFullName": "Justice Kulas",
      "ActiveErpLinks": 91,
      "TicketPriorityId": 836,
      "SupportLanguageId": 605,
      "SupportAssociateId": 144,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "AlertLevel": 415,
  "ConnectId": 219,
  "ReadStatus": "Green",
  "TimeToReply": 27,
  "RealTimeToReply": 462,
  "TimeToClose": 855,
  "RealTimeToClose": 704,
  "TimeSpentInternally": 648,
  "TimeSpentExternally": 499,
  "TimeSpentQueue": 518,
  "RealTimeSpentInternally": 426,
  "RealTimeSpentExternally": 996,
  "RealTimeSpentQueue": 179,
  "TimeSpent": 733,
  "HasAttachment": false,
  "NumReplies": 203,
  "NumMessages": 540,
  "FromAddress": "molestiae",
  "Messages": [
    {
      "TicketMessageId": 170,
      "CreatedAt": "2010-02-11T10:30:24.9048294+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "quasi",
      "PersonId": 729,
      "PersonFullName": "Perry Orn",
      "ContactId": 829,
      "ContactName": "Heidenreich-Wuckert",
      "ContactDepartment": "",
      "NumAttachments": 88,
      "EmailHeader": "malachi_hills@hahnfisher.info",
      "MessageHeaders": [
        {},
        {}
      ],
      "Language": "ut",
      "Sentiment": 907,
      "SentimentConfidence": 22,
      "CreatedBy": 373,
      "ChangedAt": "2016-11-17T10:30:24.9048294+01:00",
      "Badge": "Comment",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 781
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 786,
      "Name": "Nienow-Kuphal",
      "ToolTip": "Illum inventore temporibus commodi explicabo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    },
    {
      "Id": 786,
      "Name": "Nienow-Kuphal",
      "ToolTip": "Illum inventore temporibus commodi explicabo.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "Language": "explicabo",
  "Sentiment": 904,
  "SentimentConfidence": 492,
  "SuggestedCategoryId": 2,
  "SuggestedCategoryName": "VIP Customer",
  "OrigHumanCategoryId": 684,
  "IconHint": "possimus",
  "Sale": null,
  "Project": null,
  "FormSubmission": null,
  "TicketType": null,
  "ActiveStatusMonitorId": 619,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 639
    }
  }
}
```