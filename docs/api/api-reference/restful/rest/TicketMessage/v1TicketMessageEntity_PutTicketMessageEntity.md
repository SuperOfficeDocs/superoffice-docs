---
title: PUT TicketMessage/{id}
id: v1TicketMessageEntity_PutTicketMessageEntity
---

# PUT TicketMessage/{id}

```http
PUT /api/v1/TicketMessage/{id}
```

Updates the existing TicketMessageEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketMessageEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/TicketMessage/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request).



TicketMessageEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TicketMessageEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 336,
  "Ticket": {
    "TicketId": 860,
    "Title": "qui",
    "CreatedAt": "2021-02-19T09:40:59.8820643+01:00",
    "LastChanged": "2020-06-02T09:40:59.8820643+02:00",
    "ReadByOwner": "2010-12-08T09:40:59.8820643+01:00",
    "ReadByCustomer": "2011-10-13T09:40:59.8820643+02:00",
    "FirstReadByUser": "2000-08-22T09:40:59.8820643+02:00",
    "Activate": "2009-09-21T09:40:59.8820643+02:00",
    "ClosedAt": "2016-04-10T09:40:59.8820643+02:00",
    "RepliedAt": "2009-11-28T09:40:59.8820643+01:00",
    "AlertTimeout": "1994-12-27T09:40:59.8820643+01:00",
    "Deadline": "2018-02-13T09:40:59.8820643+01:00",
    "CreatedBy": 363,
    "CreatedByName": "Kris, Morar and Lueilwitz",
    "Author": "labore",
    "OwnedBy": 722,
    "OwnedByName": "Rath-Nitzsche",
    "Category": 972,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 425,
    "BaseStatus": "Active",
    "TicketStatus": 661,
    "Origin": "AutoGenerated",
    "CustId": 826,
    "CustFirstname": "Eulalia",
    "CustMiddleName": "Ledner, Kreiger and O'Kon",
    "CustLastname": "Will",
    "AlertLevel": 69,
    "ConnectId": 222,
    "ReadStatus": "Green",
    "TimeToReply": 975,
    "RealTimeToReply": 340,
    "TimeToClose": 391,
    "RealTimeToClose": 639,
    "TimeSpentInternally": 779,
    "TimeSpentExternally": 774,
    "TimeSpentQueue": 329,
    "RealTimeSpentInternally": 957,
    "RealTimeSpentExternally": 55,
    "RealTimeSpentQueue": 481,
    "HasAttachment": true,
    "NumReplies": 250,
    "NumMessages": 914,
    "FromAddress": "et",
    "CustFullname": "labore",
    "TicketStatusDisplayValue": "aperiam"
  },
  "CreatedAt": "2007-01-01T09:40:59.883065+01:00",
  "CreatedBy": {
    "AssociateId": 954,
    "Name": "Bosco Group",
    "PersonId": 358,
    "Rank": 76,
    "Tooltip": "officia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 74,
    "FullName": "Kassandra Hartmann",
    "FormalName": "Gislason, Homenick and Bruen",
    "Deleted": true,
    "EjUserId": 866,
    "UserName": "Deckow LLC"
  },
  "Author": "dolor",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "alias",
  "TimeSpent": 914,
  "Body": "esse",
  "HtmlBody": "aperiam",
  "EmailHeader": "granville_frami@goyetteprosacco.ca",
  "DebugInfo": "architecto",
  "MailSorter": "tenetur",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "sapiente",
    "PersonId": 498,
    "Mrmrs": "et",
    "Firstname": "Cassidy",
    "Lastname": "Ernser",
    "MiddleName": "Harvey, Kshlerin and Glover",
    "Title": "laboriosam",
    "Description": "Seamless multimedia complexity",
    "Email": "nina_okeefe@naderlowe.ca",
    "FullName": "Jessy Schiller Sr.",
    "DirectPhone": "330-265-4467 x2513",
    "FormalName": "Johns, Harris and Goodwin",
    "CountryId": 503,
    "ContactId": 58,
    "ContactName": "Bergstrom-Hahn",
    "Retired": 327,
    "Rank": 301,
    "ActiveInterests": 149,
    "ContactDepartment": "",
    "ContactCountryId": 412,
    "ContactOrgNr": "1019458",
    "FaxPhone": "1-301-802-6511 x6873",
    "MobilePhone": "225-172-2023",
    "ContactPhone": "(685)305-5175",
    "AssociateName": "Kohler, Shanahan and Dare",
    "AssociateId": 645,
    "UsePersonAddress": false,
    "ContactFax": "officiis",
    "Kanafname": "quasi",
    "Kanalname": "et",
    "Post1": "quo",
    "Post2": "est",
    "Post3": "nostrum",
    "EmailName": "arno_wisozk@adamsleuschke.info",
    "ContactFullName": "Mossie Champlin",
    "ActiveErpLinks": 113,
    "TicketPriorityId": 413,
    "SupportLanguageId": 744,
    "SupportAssociateId": 528,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "quia",
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "iste"
  }
}
```

```http_
HTTP/1.1 200 TicketMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 626,
  "Ticket": {
    "TicketId": 83,
    "Title": "enim",
    "CreatedAt": "2011-08-21T09:40:59.8880644+02:00",
    "LastChanged": "2005-10-30T09:40:59.8880644+01:00",
    "ReadByOwner": "2006-08-24T09:40:59.8880644+02:00",
    "ReadByCustomer": "1999-08-20T09:40:59.8880644+02:00",
    "FirstReadByUser": "2003-08-30T09:40:59.8880644+02:00",
    "Activate": "2013-04-06T09:40:59.8880644+02:00",
    "ClosedAt": "2006-07-17T09:40:59.8880644+02:00",
    "RepliedAt": "2005-12-23T09:40:59.8880644+01:00",
    "AlertTimeout": "1993-12-16T09:40:59.8880644+01:00",
    "Deadline": "1998-05-23T09:40:59.8880644+02:00",
    "CreatedBy": 613,
    "CreatedByName": "Schulist LLC",
    "Author": "voluptates",
    "OwnedBy": 972,
    "OwnedByName": "Marvin LLC",
    "Category": 487,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 206,
    "BaseStatus": "Active",
    "TicketStatus": 147,
    "Origin": "AutoGenerated",
    "CustId": 576,
    "CustFirstname": "Dulce",
    "CustMiddleName": "Willms Group",
    "CustLastname": "Weissnat",
    "AlertLevel": 300,
    "ConnectId": 288,
    "ReadStatus": "Green",
    "TimeToReply": 699,
    "RealTimeToReply": 934,
    "TimeToClose": 818,
    "RealTimeToClose": 56,
    "TimeSpentInternally": 141,
    "TimeSpentExternally": 737,
    "TimeSpentQueue": 80,
    "RealTimeSpentInternally": 891,
    "RealTimeSpentExternally": 844,
    "RealTimeSpentQueue": 417,
    "HasAttachment": true,
    "NumReplies": 864,
    "NumMessages": 2,
    "FromAddress": "et",
    "CustFullname": "deserunt",
    "TicketStatusDisplayValue": "dignissimos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 75
      }
    }
  },
  "CreatedAt": "2003-08-11T09:40:59.8880644+02:00",
  "CreatedBy": {
    "AssociateId": 409,
    "Name": "Gerhold, Hackett and Barton",
    "PersonId": 968,
    "Rank": 670,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 354,
    "FullName": "Cara Wolf",
    "FormalName": "Waelchi-Jakubowski",
    "Deleted": true,
    "EjUserId": 363,
    "UserName": "Reichel LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deploy scalable solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 856
      }
    }
  },
  "Author": "doloribus",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "est",
  "TimeSpent": 424,
  "Body": "assumenda",
  "HtmlBody": "officiis",
  "EmailHeader": "kacie.langworth@schuster.co.uk",
  "DebugInfo": "esse",
  "MailSorter": "repellat",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "aperiam",
    "PersonId": 144,
    "Mrmrs": "et",
    "Firstname": "Toni",
    "Lastname": "Pouros",
    "MiddleName": "Bashirian Inc and Sons",
    "Title": "perferendis",
    "Description": "Cross-platform zero defect flexibility",
    "Email": "imogene@muellerkub.us",
    "FullName": "Alfonzo Beer III",
    "DirectPhone": "353-204-3725 x2388",
    "FormalName": "Langworth LLC",
    "CountryId": 275,
    "ContactId": 23,
    "ContactName": "Prohaska, Reichert and Greenfelder",
    "Retired": 58,
    "Rank": 80,
    "ActiveInterests": 780,
    "ContactDepartment": "",
    "ContactCountryId": 512,
    "ContactOrgNr": "1471042",
    "FaxPhone": "062-407-6006",
    "MobilePhone": "(666)066-2766",
    "ContactPhone": "586-322-2570",
    "AssociateName": "Moore-Dietrich",
    "AssociateId": 663,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "autem",
    "Kanalname": "perferendis",
    "Post1": "voluptate",
    "Post2": "in",
    "Post3": "aut",
    "EmailName": "chase@wilkinson.com",
    "ContactFullName": "Mr. Emily Stokes",
    "ActiveErpLinks": 678,
    "TicketPriorityId": 554,
    "SupportLanguageId": 453,
    "SupportAssociateId": 750,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 222
      }
    }
  },
  "SearchTitle": "ut",
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "voluptatem"
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
      "FieldLength": 244
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```