---
title: POST TicketMessage
id: v1TicketMessageEntity_PostTicketMessageEntity
---

# POST TicketMessage

```http
POST /api/v1/TicketMessage
```

Creates a new TicketMessageEntity

Calls the Ticket agent service SaveTicketMessageEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/TicketMessage?$select=name,department,category/id
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

## Request Body: newEntity  

The TicketMessageEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjMessageId | int32 | The primary key (auto-incremented) |
| Ticket |  | The connected ticket |
| CreatedAt | date-time | When the message was posted. |
| CreatedBy |  | The associate who created this ticket message |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| Slevel | string | The securitylevel of the message. |
| Type | string | The type of the message (plaintext/html). |
| MessageId | string | The X-Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets. |
| TimeSpent | int32 | The time spent (minutes) for this message. |
| Body | string | The textbody for the message. |
| HtmlBody | string | The html body for the message (if any). |
| EmailHeader | string | The email header is saved in this field as raw text |
| DebugInfo | string | The debug info for the message. |
| MailSorter | string | The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&amp;apos;s change every time one changes the mail sorter. :-0 |
| MessageCategory | string | Defines what kind of message this is. |
| Person |  | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request).



TicketMessageEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjMessageId | int32 | The primary key (auto-incremented) |
| Ticket |  | The connected ticket |
| CreatedAt | date-time | When the message was posted. |
| CreatedBy |  | The associate who created this ticket message |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| Slevel | string | The securitylevel of the message. |
| Type | string | The type of the message (plaintext/html). |
| MessageId | string | The X-Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets. |
| TimeSpent | int32 | The time spent (minutes) for this message. |
| Body | string | The textbody for the message. |
| HtmlBody | string | The html body for the message (if any). |
| EmailHeader | string | The email header is saved in this field as raw text |
| DebugInfo | string | The debug info for the message. |
| MailSorter | string | The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&amp;apos;s change every time one changes the mail sorter. :-0 |
| MessageCategory | string | Defines what kind of message this is. |
| Person |  | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/TicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 849,
  "Ticket": {
    "TicketId": 734,
    "Title": "voluptatem",
    "CreatedAt": "2007-09-26T18:25:51.236941+02:00",
    "LastChanged": "2016-05-23T18:25:51.236941+02:00",
    "ReadByOwner": "1994-08-24T18:25:51.236941+02:00",
    "ReadByCustomer": "1999-03-21T18:25:51.236941+01:00",
    "FirstReadByUser": "1999-11-20T18:25:51.236941+01:00",
    "Activate": "2006-09-01T18:25:51.236941+02:00",
    "ClosedAt": "2014-07-23T18:25:51.236941+02:00",
    "RepliedAt": "2005-12-30T18:25:51.236941+01:00",
    "AlertTimeout": "2011-11-06T18:25:51.236941+01:00",
    "Deadline": "2013-12-13T18:25:51.236941+01:00",
    "CreatedBy": 352,
    "CreatedByName": "O'Conner-Olson",
    "Author": "totam",
    "OwnedBy": 324,
    "OwnedByName": "D'Amore LLC",
    "Category": 688,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 237,
    "PriorityName": "Jerde LLC",
    "BaseStatus": "Active",
    "TicketStatus": 745,
    "TicketStatusDisplayValue": "quidem",
    "Origin": "AutoGenerated",
    "CustId": 675,
    "PersonFirstname": "Sallie",
    "PersonMiddleName": "Greenholt Group",
    "PersonLastname": "Littel",
    "PersonFullname": "possimus",
    "AlertLevel": 849,
    "ConnectId": 190,
    "ReadStatus": "Green",
    "TimeToReply": 758,
    "RealTimeToReply": 726,
    "TimeToClose": 318,
    "RealTimeToClose": 547,
    "TimeSpentInternally": 807,
    "TimeSpentExternally": 949,
    "TimeSpentQueue": 416,
    "RealTimeSpentInternally": 988,
    "RealTimeSpentExternally": 584,
    "RealTimeSpentQueue": 726,
    "HasAttachment": false,
    "NumReplies": 798,
    "NumMessages": 636,
    "FromAddress": "delectus",
    "ContactId": 902,
    "ContactName": "Gleichner-Boyle",
    "OwnedByAssociateId": 526
  },
  "CreatedAt": "2012-02-28T18:25:51.2379116+01:00",
  "CreatedBy": {
    "AssociateId": 733,
    "Name": "Pagac-McCullough",
    "PersonId": 466,
    "Rank": 369,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 368,
    "FullName": "Holly Marks",
    "FormalName": "Lang Group",
    "Deleted": false,
    "EjUserId": 731,
    "UserName": "Hansen-Feil"
  },
  "Author": "sed",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "natus",
  "TimeSpent": 836,
  "Body": "sit",
  "HtmlBody": "placeat",
  "EmailHeader": "noemie.hessel@windlerheaney.ca",
  "DebugInfo": "et",
  "MailSorter": "ea",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "et",
    "PersonId": 705,
    "Mrmrs": "quia",
    "Firstname": "Karson",
    "Lastname": "Leuschke",
    "MiddleName": "Dietrich-Carroll",
    "Title": "nesciunt",
    "Description": "Organic incremental support",
    "Email": "crystal.strosin@marvin.co.uk",
    "FullName": "Brock Turner III",
    "DirectPhone": "1-813-776-4734 x48145",
    "FormalName": "Douglas-Blanda",
    "CountryId": 448,
    "ContactId": 431,
    "ContactName": "Cormier, Schaefer and Schuster",
    "Retired": 481,
    "Rank": 663,
    "ActiveInterests": 596,
    "ContactDepartment": "",
    "ContactCountryId": 701,
    "ContactOrgNr": "1289678",
    "FaxPhone": "152-822-6738 x7638",
    "MobilePhone": "215-804-8173 x431",
    "ContactPhone": "1-210-477-4260",
    "AssociateName": "Howe, Murray and Abshire",
    "AssociateId": 826,
    "UsePersonAddress": true,
    "ContactFax": "nihil",
    "Kanafname": "aliquam",
    "Kanalname": "sunt",
    "Post1": "ea",
    "Post2": "sit",
    "Post3": "dolores",
    "EmailName": "kayli@wiegand.com",
    "ContactFullName": "Nola Emmerich",
    "ActiveErpLinks": 569,
    "TicketPriorityId": 136,
    "SupportLanguageId": 899,
    "SupportAssociateId": 67,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "et",
  "MessageHeaders": [
    {
      "Name": "Pagac Group",
      "Value": "suscipit"
    },
    {
      "Name": "Pagac Group",
      "Value": "suscipit"
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "porro"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 65,
  "Ticket": {
    "TicketId": 780,
    "Title": "dolore",
    "CreatedAt": "2016-08-28T18:25:51.2429347+02:00",
    "LastChanged": "2011-04-01T18:25:51.2429347+02:00",
    "ReadByOwner": "2018-04-17T18:25:51.2429347+02:00",
    "ReadByCustomer": "2013-06-05T18:25:51.2429347+02:00",
    "FirstReadByUser": "2020-02-15T18:25:51.2429347+01:00",
    "Activate": "2014-01-11T18:25:51.2429347+01:00",
    "ClosedAt": "1998-07-28T18:25:51.2439399+02:00",
    "RepliedAt": "2008-03-03T18:25:51.2439399+01:00",
    "AlertTimeout": "2008-10-22T18:25:51.2439399+02:00",
    "Deadline": "2015-12-22T18:25:51.2439399+01:00",
    "CreatedBy": 558,
    "CreatedByName": "Sipes-Littel",
    "Author": "possimus",
    "OwnedBy": 85,
    "OwnedByName": "Bergstrom, Ondricka and Senger",
    "Category": 202,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 537,
    "PriorityName": "Nienow Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 536,
    "TicketStatusDisplayValue": "saepe",
    "Origin": "AutoGenerated",
    "CustId": 663,
    "PersonFirstname": "Clare",
    "PersonMiddleName": "Conn LLC",
    "PersonLastname": "Dicki",
    "PersonFullname": "corrupti",
    "AlertLevel": 538,
    "ConnectId": 269,
    "ReadStatus": "Green",
    "TimeToReply": 433,
    "RealTimeToReply": 902,
    "TimeToClose": 154,
    "RealTimeToClose": 899,
    "TimeSpentInternally": 364,
    "TimeSpentExternally": 259,
    "TimeSpentQueue": 892,
    "RealTimeSpentInternally": 334,
    "RealTimeSpentExternally": 261,
    "RealTimeSpentQueue": 714,
    "HasAttachment": false,
    "NumReplies": 425,
    "NumMessages": 993,
    "FromAddress": "mollitia",
    "ContactId": 186,
    "ContactName": "Abbott-Adams",
    "OwnedByAssociateId": 969,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 746
      }
    }
  },
  "CreatedAt": "2004-05-03T18:25:51.2439399+02:00",
  "CreatedBy": {
    "AssociateId": 444,
    "Name": "Harvey Group",
    "PersonId": 287,
    "Rank": 581,
    "Tooltip": "iste",
    "Type": "AnonymousAssociate",
    "GroupIdx": 69,
    "FullName": "Ward Robel",
    "FormalName": "McGlynn, Nitzsche and Schoen",
    "Deleted": false,
    "EjUserId": 43,
    "UserName": "Runolfsson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 93
      }
    }
  },
  "Author": "non",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "aspernatur",
  "TimeSpent": 410,
  "Body": "et",
  "HtmlBody": "iste",
  "EmailHeader": "weldon@jones.com",
  "DebugInfo": "sapiente",
  "MailSorter": "nobis",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "quia",
    "PersonId": 533,
    "Mrmrs": "omnis",
    "Firstname": "Loraine",
    "Lastname": "Swift",
    "MiddleName": "Wisozk LLC",
    "Title": "adipisci",
    "Description": "Compatible methodical database",
    "Email": "verner_maggio@abernathylittle.co.uk",
    "FullName": "Maggie Upton",
    "DirectPhone": "(883)773-3084 x3363",
    "FormalName": "Bernier-Bayer",
    "CountryId": 553,
    "ContactId": 783,
    "ContactName": "Shields LLC",
    "Retired": 263,
    "Rank": 868,
    "ActiveInterests": 424,
    "ContactDepartment": "",
    "ContactCountryId": 201,
    "ContactOrgNr": "947973",
    "FaxPhone": "107-883-4507",
    "MobilePhone": "(423)417-0340 x7777",
    "ContactPhone": "(653)112-2623",
    "AssociateName": "Shields-Jacobson",
    "AssociateId": 243,
    "UsePersonAddress": false,
    "ContactFax": "praesentium",
    "Kanafname": "aliquid",
    "Kanalname": "sit",
    "Post1": "sit",
    "Post2": "vero",
    "Post3": "distinctio",
    "EmailName": "claudia@corkerywunsch.co.uk",
    "ContactFullName": "Linwood Yundt",
    "ActiveErpLinks": 203,
    "TicketPriorityId": 949,
    "SupportLanguageId": 583,
    "SupportAssociateId": 357,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 139
      }
    }
  },
  "SearchTitle": "sapiente",
  "MessageHeaders": [
    {
      "Name": "D'Amore, Wiegand and Nitzsche",
      "Value": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    },
    {
      "Name": "D'Amore, Wiegand and Nitzsche",
      "Value": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "magnam"
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
      "FieldLength": 200
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```