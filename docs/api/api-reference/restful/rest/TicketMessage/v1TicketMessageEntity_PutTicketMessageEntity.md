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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
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
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 795,
  "Ticket": {
    "TicketId": 10,
    "Title": "explicabo",
    "CreatedAt": "2006-02-27T15:05:42.9366324+01:00",
    "LastChanged": "2015-10-22T15:05:42.9366324+02:00",
    "ReadByOwner": "1999-06-12T15:05:42.9366324+02:00",
    "ReadByCustomer": "1996-11-28T15:05:42.9366324+01:00",
    "FirstReadByUser": "2011-07-26T15:05:42.9366324+02:00",
    "Activate": "1994-07-22T15:05:42.9366324+02:00",
    "ClosedAt": "1999-10-21T15:05:42.9366324+02:00",
    "RepliedAt": "2000-07-09T15:05:42.9366324+02:00",
    "AlertTimeout": "2017-08-31T15:05:42.9366324+02:00",
    "Deadline": "2016-08-07T15:05:42.9366324+02:00",
    "CreatedBy": 438,
    "CreatedByName": "Rosenbaum-Abshire",
    "Author": "temporibus",
    "OwnedBy": 161,
    "OwnedByName": "Blick LLC",
    "Category": 618,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 444,
    "PriorityName": "Tillman-Hauck",
    "BaseStatus": "Active",
    "TicketStatus": 806,
    "TicketStatusDisplayValue": "doloribus",
    "Origin": "AutoGenerated",
    "CustId": 354,
    "PersonFirstname": "Izaiah",
    "PersonMiddleName": "Beatty-Maggio",
    "PersonLastname": "Schiller",
    "PersonFullname": "similique",
    "AlertLevel": 819,
    "ConnectId": 231,
    "ReadStatus": "Green",
    "TimeToReply": 556,
    "RealTimeToReply": 988,
    "TimeToClose": 839,
    "RealTimeToClose": 428,
    "TimeSpentInternally": 964,
    "TimeSpentExternally": 431,
    "TimeSpentQueue": 226,
    "RealTimeSpentInternally": 427,
    "RealTimeSpentExternally": 853,
    "RealTimeSpentQueue": 505,
    "HasAttachment": false,
    "NumReplies": 477,
    "NumMessages": 479,
    "FromAddress": "est",
    "ContactId": 350,
    "ContactName": "Bartell LLC",
    "OwnedByAssociateId": 996
  },
  "CreatedAt": "2020-02-19T15:05:42.9366324+01:00",
  "CreatedBy": {
    "AssociateId": 159,
    "Name": "Boehm-Dicki",
    "PersonId": 183,
    "Rank": 957,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Chelsey Turcotte",
    "FormalName": "Kling LLC",
    "Deleted": true,
    "EjUserId": 377,
    "UserName": "Mayert Inc and Sons"
  },
  "Author": "tempora",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "veritatis",
  "TimeSpent": 794,
  "Body": "laborum",
  "HtmlBody": "quis",
  "EmailHeader": "madyson@lehnerromaguera.com",
  "DebugInfo": "rem",
  "MailSorter": "molestiae",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "tempore",
    "PersonId": 298,
    "Mrmrs": "delectus",
    "Firstname": "Emerson",
    "Lastname": "Reichert",
    "MiddleName": "O'Keefe-Harber",
    "Title": "voluptas",
    "Description": "Ameliorated context-sensitive monitoring",
    "Email": "art@monahan.com",
    "FullName": "Tyree Frami",
    "DirectPhone": "871-556-7746 x6404",
    "FormalName": "Beatty, Tillman and Bauch",
    "CountryId": 823,
    "ContactId": 895,
    "ContactName": "Hackett-Borer",
    "Retired": 22,
    "Rank": 698,
    "ActiveInterests": 579,
    "ContactDepartment": "",
    "ContactCountryId": 878,
    "ContactOrgNr": "1017805",
    "FaxPhone": "323.373.0658 x1784",
    "MobilePhone": "717.727.1325 x718",
    "ContactPhone": "(483)782-1607",
    "AssociateName": "Senger, Herman and Cummings",
    "AssociateId": 993,
    "UsePersonAddress": true,
    "ContactFax": "quia",
    "Kanafname": "dolores",
    "Kanalname": "architecto",
    "Post1": "iste",
    "Post2": "itaque",
    "Post3": "reiciendis",
    "EmailName": "orlo@conroy.ca",
    "ContactFullName": "Dr. Reilly Weber",
    "ActiveErpLinks": 956,
    "TicketPriorityId": 206,
    "SupportLanguageId": 368,
    "SupportAssociateId": 54,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "a",
  "MessageHeaders": [
    {
      "Name": "Kozey LLC",
      "Value": "ea"
    },
    {
      "Name": "Kozey LLC",
      "Value": "ea"
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "quo"
  }
}
```

```http_
HTTP/1.1 200 TicketMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 966,
  "Ticket": {
    "TicketId": 933,
    "Title": "pariatur",
    "CreatedAt": "2014-12-14T15:05:42.9426324+01:00",
    "LastChanged": "1997-10-25T15:05:42.9426324+02:00",
    "ReadByOwner": "2006-08-21T15:05:42.9426324+02:00",
    "ReadByCustomer": "2000-04-17T15:05:42.9426324+02:00",
    "FirstReadByUser": "2017-04-27T15:05:42.9426324+02:00",
    "Activate": "2004-08-09T15:05:42.9426324+02:00",
    "ClosedAt": "1999-01-03T15:05:42.9426324+01:00",
    "RepliedAt": "2010-04-06T15:05:42.9426324+02:00",
    "AlertTimeout": "2006-04-04T15:05:42.9426324+02:00",
    "Deadline": "2014-09-18T15:05:42.9426324+02:00",
    "CreatedBy": 220,
    "CreatedByName": "Carroll-Kunze",
    "Author": "molestias",
    "OwnedBy": 12,
    "OwnedByName": "Goyette-Kihn",
    "Category": 69,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 278,
    "PriorityName": "Parisian, McDermott and Hegmann",
    "BaseStatus": "Active",
    "TicketStatus": 342,
    "TicketStatusDisplayValue": "repudiandae",
    "Origin": "AutoGenerated",
    "CustId": 689,
    "PersonFirstname": "Rigoberto",
    "PersonMiddleName": "Luettgen, Stanton and Hagenes",
    "PersonLastname": "Keeling",
    "PersonFullname": "sit",
    "AlertLevel": 930,
    "ConnectId": 361,
    "ReadStatus": "Green",
    "TimeToReply": 301,
    "RealTimeToReply": 700,
    "TimeToClose": 860,
    "RealTimeToClose": 148,
    "TimeSpentInternally": 485,
    "TimeSpentExternally": 970,
    "TimeSpentQueue": 384,
    "RealTimeSpentInternally": 493,
    "RealTimeSpentExternally": 651,
    "RealTimeSpentQueue": 313,
    "HasAttachment": false,
    "NumReplies": 20,
    "NumMessages": 596,
    "FromAddress": "aut",
    "ContactId": 575,
    "ContactName": "Trantow Inc and Sons",
    "OwnedByAssociateId": 202,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 286
      }
    }
  },
  "CreatedAt": "2001-12-27T15:05:42.9426324+01:00",
  "CreatedBy": {
    "AssociateId": 608,
    "Name": "Price-Bauch",
    "PersonId": 998,
    "Rank": 265,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 457,
    "FullName": "Molly Douglas",
    "FormalName": "Hilpert-Wuckert",
    "Deleted": true,
    "EjUserId": 141,
    "UserName": "Bechtelar-Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 861
      }
    }
  },
  "Author": "nostrum",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "accusamus",
  "TimeSpent": 940,
  "Body": "molestiae",
  "HtmlBody": "enim",
  "EmailHeader": "issac_beatty@corwindare.us",
  "DebugInfo": "nulla",
  "MailSorter": "dignissimos",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "et",
    "PersonId": 291,
    "Mrmrs": "incidunt",
    "Firstname": "Verlie",
    "Lastname": "Nitzsche",
    "MiddleName": "Kuhic-Deckow",
    "Title": "aut",
    "Description": "Face to face next generation superstructure",
    "Email": "alphonso.rutherford@bergegrimes.name",
    "FullName": "Erika Jenkins",
    "DirectPhone": "760-087-1855 x4342",
    "FormalName": "Dietrich, Gleichner and O'Reilly",
    "CountryId": 76,
    "ContactId": 356,
    "ContactName": "Goodwin-Rolfson",
    "Retired": 77,
    "Rank": 695,
    "ActiveInterests": 301,
    "ContactDepartment": "",
    "ContactCountryId": 644,
    "ContactOrgNr": "1874984",
    "FaxPhone": "073-773-1011 x62047",
    "MobilePhone": "1-330-672-0148",
    "ContactPhone": "258-405-7441",
    "AssociateName": "Shanahan-Schmidt",
    "AssociateId": 100,
    "UsePersonAddress": false,
    "ContactFax": "eius",
    "Kanafname": "aut",
    "Kanalname": "officia",
    "Post1": "repellat",
    "Post2": "nostrum",
    "Post3": "dolore",
    "EmailName": "queen_dare@vonhodkiewicz.info",
    "ContactFullName": "Camille Murphy",
    "ActiveErpLinks": 761,
    "TicketPriorityId": 658,
    "SupportLanguageId": 227,
    "SupportAssociateId": 990,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 526
      }
    }
  },
  "SearchTitle": "id",
  "MessageHeaders": [
    {
      "Name": "Gutmann Group",
      "Value": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Name": "Gutmann Group",
      "Value": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "amet",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "eaque"
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
      "FieldLength": 589
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```