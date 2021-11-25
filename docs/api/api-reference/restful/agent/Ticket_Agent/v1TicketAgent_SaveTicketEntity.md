---
title: POST Agents/Ticket/SaveTicketEntity
id: v1TicketAgent_SaveTicketEntity
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
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The ticket entity is used for representing a service ticket



Carrier object for TicketEntity.
Services for the TicketEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| CreatedAt | date-time | When the ticket was created. |
| LastChanged | date-time | The last time the ticket was modified. |
| ReadByOwner | date-time | The datetime for when the ticket last was read by the owner. |
| ReadByCustomer | date-time | The datetime for when the ticket was read by the customer. |
| FirstReadByUser | date-time | The datetime for when the ticket first was read by a user. |
| Activate | date-time | When the ticket should be activated, if it is postponed. |
| ClosedAt | date-time | When the ticket was closed. |
| RepliedAt | date-time | The datetime for when the ticket was replied to. I.e. the first external message added to the ticket. |
| AlertTimeout | date-time | The datetime for when the ticket should jump to the next alert_level. |
| Deadline | date-time | Deadline for ticket. |
| CreatedBy |  | The associate who created this ticket |
| Author | string | A string representing the author of the ticket (same as author of first message). |
| OwnedBy |  | The associate who owns this ticket. Setting the id to 0 will make the ticket unassigned. Setting the id to 2147483647 (MaxInt) will make it automatically assigned according to the ticket category assignment rules.  <para>Use MDO List name "associate" to get list items.</para> |
| Category |  | The ticket category entity which this ticket is connected to  <para>Use MDO List name "ejcategory" to get list items.</para> |
| Slevel | string | The securitylevel of the ticket. |
| Priority |  | The ticket priority entity which this ticket is connected to  <para>Use MDO List name "ticketpriority" to get list items.</para> |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Status |  | The ticket status entity which this ticket is connected to  <para>Use MDO List name "ticketstatus" to get list items.</para> |
| Origin | string | What is the origin of this ticket |
| Person |  | The primary person that this ticket is connected to  <para>Use MDO List name "person_new" to get list items.</para> |
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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/SaveTicketEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TicketId": 744,
  "Title": "sequi",
  "CreatedAt": "2014-03-13T18:28:50.2834467+01:00",
  "LastChanged": "2014-11-20T18:28:50.2834467+01:00",
  "ReadByOwner": "2013-10-30T18:28:50.2834467+01:00",
  "ReadByCustomer": "2001-04-20T18:28:50.2834467+02:00",
  "FirstReadByUser": "2018-01-09T18:28:50.2834467+01:00",
  "Activate": "2004-03-21T18:28:50.2834467+01:00",
  "ClosedAt": "1994-08-18T18:28:50.2834467+02:00",
  "RepliedAt": "2004-09-28T18:28:50.2834467+02:00",
  "AlertTimeout": "1995-06-12T18:28:50.2834467+02:00",
  "Deadline": "1997-03-21T18:28:50.2834467+01:00",
  "CreatedBy": {
    "AssociateId": 328,
    "Name": "Pfannerstill-Runte",
    "PersonId": 74,
    "Rank": 968,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 53,
    "FullName": "Minerva Funk",
    "FormalName": "Schroeder LLC",
    "Deleted": false,
    "EjUserId": 519,
    "UserName": "Crona, Tillman and Sauer"
  },
  "Author": "qui",
  "OwnedBy": {
    "AssociateId": 651,
    "Name": "Hickle, Tromp and Beier",
    "PersonId": 93,
    "Rank": 634,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 4,
    "FullName": "Mr. Terence McGlynn",
    "FormalName": "Wilkinson LLC",
    "Deleted": true,
    "EjUserId": 495,
    "UserName": "Lynch, Abbott and Fay"
  },
  "Category": {
    "TicketCategoryId": 942,
    "ParentId": 804,
    "Name": "Krajcik, Treutel and Schowalter",
    "Fullname": "perspiciatis",
    "CategoryMaster": 21,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Miller-Lueilwitz",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 421,
    "ReplyTemplate": 992,
    "NotificationEmail": "carol@prohaska.info",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "ducimus",
      "ExtraFields2": "reprehenderit"
    },
    "CustomFields": {
      "CustomFields1": "ipsa",
      "CustomFields2": "sunt"
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 135,
    "Name": "Gaylord, Erdman and Cremin",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 78,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 399,
    "MonStart": "2003-07-12T18:28:50.2844503+02:00",
    "MonStop": "2004-06-05T18:28:50.2844503+02:00",
    "TueStart": "2019-11-15T18:28:50.2844503+01:00",
    "TueStop": "1999-10-13T18:28:50.2844503+02:00",
    "WedStart": "2019-05-08T18:28:50.2844503+02:00",
    "WedStop": "1998-11-10T18:28:50.2844503+01:00",
    "ThuStart": "2017-03-14T18:28:50.2844503+01:00",
    "ThuStop": "2015-05-14T18:28:50.2844503+02:00",
    "FriStart": "2007-03-07T18:28:50.2844503+01:00",
    "FriStop": "2021-07-08T18:28:50.2844503+02:00",
    "SatStart": "2006-11-16T18:28:50.2844503+01:00",
    "SatStop": "2009-07-18T18:28:50.2844503+02:00",
    "SunStart": "2005-04-19T18:28:50.2844503+02:00",
    "SunStop": "2004-09-29T18:28:50.2844503+02:00",
    "NonDates": [
      "reiciendis",
      "doloremque"
    ],
    "EscalationLevels": [
      {},
      {}
    ]
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 470,
    "Name": "Maggio-Graham",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": true,
    "UsedInQueue": false
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "inventore",
    "PersonId": 709,
    "Mrmrs": "aut",
    "Firstname": "Mina",
    "Lastname": "Zulauf",
    "MiddleName": "Wuckert, Ziemann and Streich",
    "Title": "quisquam",
    "Description": "Realigned cohesive matrix",
    "Email": "rodolfo@littlebrown.biz",
    "FullName": "Kendrick Eichmann",
    "DirectPhone": "037-206-5528 x76788",
    "FormalName": "Hartmann Inc and Sons",
    "CountryId": 794,
    "ContactId": 508,
    "ContactName": "Sporer, Block and Okuneva",
    "Retired": 511,
    "Rank": 188,
    "ActiveInterests": 634,
    "ContactDepartment": "",
    "ContactCountryId": 504,
    "ContactOrgNr": "922087",
    "FaxPhone": "1-405-516-8030",
    "MobilePhone": "(262)045-0266 x682",
    "ContactPhone": "(167)141-5561",
    "AssociateName": "Greenfelder, Gislason and Stehr",
    "AssociateId": 639,
    "UsePersonAddress": true,
    "ContactFax": "fugit",
    "Kanafname": "quis",
    "Kanalname": "eveniet",
    "Post1": "voluptatem",
    "Post2": "esse",
    "Post3": "ullam",
    "EmailName": "friedrich_bode@hintzaltenwerth.name",
    "ContactFullName": "Dr. Shakira Witting",
    "ActiveErpLinks": 855,
    "TicketPriorityId": 593,
    "SupportLanguageId": 66,
    "SupportAssociateId": 190,
    "CategoryName": "VIP Customer"
  },
  "SecondaryPersons": [
    {
      "Position": "magnam",
      "PersonId": 375,
      "Mrmrs": "est",
      "Firstname": "Lina",
      "Lastname": "Bogisich",
      "MiddleName": "Connelly-Towne",
      "Title": "magnam",
      "Description": "Persistent optimal algorithm",
      "Email": "miller@bradtke.us",
      "FullName": "Trycia Toy",
      "DirectPhone": "606-274-2788 x70158",
      "FormalName": "Franecki Group",
      "CountryId": 463,
      "ContactId": 931,
      "ContactName": "Harris, Hackett and Welch",
      "Retired": 783,
      "Rank": 254,
      "ActiveInterests": 538,
      "ContactDepartment": "",
      "ContactCountryId": 736,
      "ContactOrgNr": "1415406",
      "FaxPhone": "1-438-533-2313",
      "MobilePhone": "710.561.0064 x803",
      "ContactPhone": "645.860.0345 x6538",
      "AssociateName": "Morar, Bosco and Reichel",
      "AssociateId": 340,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "eligendi",
      "Kanalname": "sit",
      "Post1": "voluptas",
      "Post2": "eum",
      "Post3": "ipsam",
      "EmailName": "presley_turner@howell.uk",
      "ContactFullName": "Marcelo Kuhn",
      "ActiveErpLinks": 806,
      "TicketPriorityId": 72,
      "SupportLanguageId": 781,
      "SupportAssociateId": 148,
      "CategoryName": "VIP Customer"
    }
  ],
  "AlertLevel": 162,
  "ConnectId": 160,
  "ReadStatus": "Green",
  "TimeToReply": 241,
  "RealTimeToReply": 748,
  "TimeToClose": 650,
  "RealTimeToClose": 270,
  "TimeSpentInternally": 15,
  "TimeSpentExternally": 727,
  "TimeSpentQueue": 869,
  "RealTimeSpentInternally": 153,
  "RealTimeSpentExternally": 413,
  "RealTimeSpentQueue": 412,
  "HasAttachment": true,
  "NumReplies": 637,
  "NumMessages": 701,
  "FromAddress": "odio",
  "Messages": [
    {
      "TicketMessageId": 45,
      "CreatedAt": "2006-01-02T18:28:50.3424417+01:00",
      "Slevel": "External",
      "Important": false,
      "Author": "cumque",
      "PersonId": 257,
      "PersonFullName": "Mrs. America Blick",
      "ContactId": 238,
      "ContactName": "Rowe, Lowe and Lind",
      "ContactDepartment": "",
      "NumAttachments": 595,
      "EmailHeader": "easter@welchlehner.ca",
      "MessageHeaders": [
        {},
        {}
      ]
    }
  ],
  "Tags": [
    {
      "Id": 181,
      "Name": "Feil, Becker and Vandervort",
      "ToolTip": "Et ut qui."
    },
    {
      "Id": 181,
      "Name": "Feil, Becker and Vandervort",
      "ToolTip": "Et ut qui."
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "accusantium",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "maiores"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketId": 193,
  "Title": "ut",
  "CreatedAt": "2000-08-18T18:28:50.3474422+02:00",
  "LastChanged": "1995-11-06T18:28:50.3474422+01:00",
  "ReadByOwner": "2015-10-04T18:28:50.3474422+02:00",
  "ReadByCustomer": "2017-11-08T18:28:50.3474422+01:00",
  "FirstReadByUser": "1997-06-02T18:28:50.3474422+02:00",
  "Activate": "2018-09-27T18:28:50.3474422+02:00",
  "ClosedAt": "2004-04-28T18:28:50.3474422+02:00",
  "RepliedAt": "2003-09-14T18:28:50.3474422+02:00",
  "AlertTimeout": "2011-12-23T18:28:50.3474422+01:00",
  "Deadline": "1995-02-03T18:28:50.3474422+01:00",
  "CreatedBy": {
    "AssociateId": 223,
    "Name": "Farrell, Kling and Hoppe",
    "PersonId": 597,
    "Rank": 409,
    "Tooltip": "dicta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 434,
    "FullName": "Jamir Conn",
    "FormalName": "Hauck, Brakus and Hand",
    "Deleted": true,
    "EjUserId": 41,
    "UserName": "Muller Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "drive ubiquitous content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 59
      }
    }
  },
  "Author": "cum",
  "OwnedBy": {
    "AssociateId": 764,
    "Name": "Schuppe Inc and Sons",
    "PersonId": 868,
    "Rank": 107,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 956,
    "FullName": "Mrs. Tatyana Kassulke",
    "FormalName": "Bogan-Dibbert",
    "Deleted": false,
    "EjUserId": 15,
    "UserName": "Gutmann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 733
      }
    }
  },
  "Category": {
    "TicketCategoryId": 362,
    "ParentId": 607,
    "Name": "Willms, Trantow and Barrows",
    "Fullname": "possimus",
    "CategoryMaster": 589,
    "Flags": "AcceptWhenReplying",
    "DelegateMethod": "Even",
    "ExternalName": "Kovacek, Zieme and Nicolas",
    "ClosingStatus": "Active",
    "MsgClosingStatus": "Active",
    "AssignmentLag": 243,
    "ReplyTemplate": 521,
    "NotificationEmail": "kristopher_grimes@gerlach.name",
    "DefaultTicketStatus": {},
    "DefaultMessageStatus": {},
    "ExtraFields": {
      "ExtraFields1": "odio",
      "ExtraFields2": "modi"
    },
    "CustomFields": {
      "CustomFields1": "dolores",
      "CustomFields2": "vitae"
    },
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "Slevel": "External",
  "Priority": {
    "TicketPriorityId": 160,
    "Name": "Carroll, Runolfsson and Goyette",
    "Status": "Deleted",
    "Flags": "AlertSchedule",
    "SortOrder": 684,
    "TicketRead": "Continue",
    "ChangedOwner": "Continue",
    "TicketNewinfo": "Continue",
    "TicketClosed": "Continue",
    "TicketChangedPriority": "Continue",
    "TicketNew": "Continue",
    "Deadline": 692,
    "MonStart": "2013-06-02T18:28:50.3484454+02:00",
    "MonStop": "1998-09-09T18:28:50.3484454+02:00",
    "TueStart": "2002-09-26T18:28:50.3484454+02:00",
    "TueStop": "1994-07-18T18:28:50.3484454+02:00",
    "WedStart": "1994-12-22T18:28:50.3484454+01:00",
    "WedStop": "2002-12-05T18:28:50.3484454+01:00",
    "ThuStart": "2011-05-23T18:28:50.3484454+02:00",
    "ThuStop": "2017-10-31T18:28:50.3484454+01:00",
    "FriStart": "2020-07-10T18:28:50.3484454+02:00",
    "FriStop": "2019-04-12T18:28:50.3484454+02:00",
    "SatStart": "2004-07-16T18:28:50.3484454+02:00",
    "SatStop": "2012-09-03T18:28:50.3484454+02:00",
    "SunStart": "2014-12-31T18:28:50.3484454+01:00",
    "SunStop": "2006-09-16T18:28:50.3484454+02:00",
    "NonDates": [
      "rerum",
      "odio"
    ],
    "EscalationLevels": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 179
      }
    }
  },
  "BaseStatus": "Active",
  "Status": {
    "TicketStatusId": 981,
    "Name": "Barrows, Gusikowski and Bosco",
    "Status": "Active",
    "TimeCounter": "Externally",
    "NoEmailReopen": true,
    "IsDefault": true,
    "UsedInQueue": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 521
      }
    }
  },
  "Origin": "AutoGenerated",
  "Person": {
    "Position": "aut",
    "PersonId": 776,
    "Mrmrs": "et",
    "Firstname": "Marcus",
    "Lastname": "Oberbrunner",
    "MiddleName": "Runolfsdottir, Champlin and Vandervort",
    "Title": "commodi",
    "Description": "Proactive bifurcated parallelism",
    "Email": "brendon_reichel@will.us",
    "FullName": "Doug Wiegand IV",
    "DirectPhone": "1-175-113-0510",
    "FormalName": "Harris-Bergstrom",
    "CountryId": 264,
    "ContactId": 176,
    "ContactName": "Cremin LLC",
    "Retired": 512,
    "Rank": 4,
    "ActiveInterests": 267,
    "ContactDepartment": "",
    "ContactCountryId": 641,
    "ContactOrgNr": "822494",
    "FaxPhone": "(154)476-1353 x36221",
    "MobilePhone": "(603)316-1007",
    "ContactPhone": "400-142-2131 x526",
    "AssociateName": "Ortiz Group",
    "AssociateId": 831,
    "UsePersonAddress": false,
    "ContactFax": "neque",
    "Kanafname": "debitis",
    "Kanalname": "rem",
    "Post1": "harum",
    "Post2": "facere",
    "Post3": "commodi",
    "EmailName": "jessyca@goyette.ca",
    "ContactFullName": "Randal Hodkiewicz Jr.",
    "ActiveErpLinks": 86,
    "TicketPriorityId": 691,
    "SupportLanguageId": 907,
    "SupportAssociateId": 102,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "SecondaryPersons": [
    {
      "Position": "iure",
      "PersonId": 275,
      "Mrmrs": "cumque",
      "Firstname": "Dakota",
      "Lastname": "Monahan",
      "MiddleName": "Lemke, Lebsack and Ullrich",
      "Title": "corrupti",
      "Description": "Reverse-engineered analyzing project",
      "Email": "gisselle@lakinhermiston.com",
      "FullName": "Alba Blanda",
      "DirectPhone": "112.388.1248",
      "FormalName": "Watsica Inc and Sons",
      "CountryId": 64,
      "ContactId": 57,
      "ContactName": "Balistreri-Padberg",
      "Retired": 908,
      "Rank": 466,
      "ActiveInterests": 518,
      "ContactDepartment": "",
      "ContactCountryId": 620,
      "ContactOrgNr": "1093554",
      "FaxPhone": "1-360-762-4403",
      "MobilePhone": "158-612-0611 x2480",
      "ContactPhone": "155.751.3554 x15173",
      "AssociateName": "Wolf, Murray and Schultz",
      "AssociateId": 866,
      "UsePersonAddress": true,
      "ContactFax": "placeat",
      "Kanafname": "perferendis",
      "Kanalname": "nihil",
      "Post1": "ratione",
      "Post2": "dolore",
      "Post3": "facere",
      "EmailName": "bret_treutel@stehr.info",
      "ContactFullName": "Ms. Damon Yost",
      "ActiveErpLinks": 724,
      "TicketPriorityId": 877,
      "SupportLanguageId": 840,
      "SupportAssociateId": 746,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    }
  ],
  "AlertLevel": 245,
  "ConnectId": 886,
  "ReadStatus": "Green",
  "TimeToReply": 864,
  "RealTimeToReply": 318,
  "TimeToClose": 797,
  "RealTimeToClose": 46,
  "TimeSpentInternally": 749,
  "TimeSpentExternally": 601,
  "TimeSpentQueue": 460,
  "RealTimeSpentInternally": 568,
  "RealTimeSpentExternally": 246,
  "RealTimeSpentQueue": 45,
  "HasAttachment": false,
  "NumReplies": 413,
  "NumMessages": 719,
  "FromAddress": "temporibus",
  "Messages": [
    {
      "TicketMessageId": 702,
      "CreatedAt": "2000-07-22T18:28:50.3514417+02:00",
      "Slevel": "External",
      "Important": true,
      "Author": "quos",
      "PersonId": 525,
      "PersonFullName": "Elaina O'Conner",
      "ContactId": 587,
      "ContactName": "O'Reilly LLC",
      "ContactDepartment": "",
      "NumAttachments": 41,
      "EmailHeader": "theo_aufderhar@krisschowalter.biz",
      "MessageHeaders": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    }
  ],
  "Tags": [
    {
      "Id": 945,
      "Name": "Koelpin, Cartwright and Deckow",
      "ToolTip": "Est ipsa id voluptatem qui quo.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    },
    {
      "Id": 945,
      "Name": "Koelpin, Cartwright and Deckow",
      "ToolTip": "Est ipsa id voluptatem qui quo.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "quos"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 700
    }
  }
}
```