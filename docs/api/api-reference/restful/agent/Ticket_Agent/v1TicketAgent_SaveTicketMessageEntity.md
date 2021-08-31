---
title: SaveTicketMessageEntity
id: v1TicketAgent_SaveTicketMessageEntity
---

# SaveTicketMessageEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
```

Updates the existing TicketMessageEntity or creates a new TicketMessageEntity if the id parameter is empty








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



Carrier object for TicketMessageEntity.
Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 696,
  "Ticket": {
    "TicketId": 550,
    "Title": "autem",
    "CreatedAt": "1996-06-17T14:58:05.3595934+02:00",
    "LastChanged": "2015-08-19T14:58:05.3595934+02:00",
    "ReadByOwner": "2014-04-02T14:58:05.3595934+02:00",
    "ReadByCustomer": "1994-08-03T14:58:05.3595934+02:00",
    "FirstReadByUser": "1994-08-20T14:58:05.3595934+02:00",
    "Activate": "2009-04-08T14:58:05.3595934+02:00",
    "ClosedAt": "2006-06-07T14:58:05.3595934+02:00",
    "RepliedAt": "1996-11-16T14:58:05.3595934+01:00",
    "AlertTimeout": "2012-03-27T14:58:05.3595934+02:00",
    "Deadline": "2006-09-16T14:58:05.3595934+02:00",
    "CreatedBy": 716,
    "CreatedByName": "Sawayn-Walker",
    "Author": "alias",
    "OwnedBy": 6,
    "OwnedByName": "Schoen-Zemlak",
    "Category": 779,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 66,
    "PriorityName": "Weber LLC",
    "BaseStatus": "Active",
    "TicketStatus": 497,
    "TicketStatusDisplayValue": "enim",
    "Origin": "AutoGenerated",
    "CustId": 6,
    "PersonFirstname": "Candida",
    "PersonMiddleName": "Kshlerin-Marvin",
    "PersonLastname": "Keebler",
    "PersonFullname": "culpa",
    "AlertLevel": 662,
    "ConnectId": 322,
    "ReadStatus": "Green",
    "TimeToReply": 12,
    "RealTimeToReply": 39,
    "TimeToClose": 291,
    "RealTimeToClose": 663,
    "TimeSpentInternally": 611,
    "TimeSpentExternally": 668,
    "TimeSpentQueue": 45,
    "RealTimeSpentInternally": 187,
    "RealTimeSpentExternally": 424,
    "RealTimeSpentQueue": 132,
    "HasAttachment": false,
    "NumReplies": 274,
    "NumMessages": 19,
    "FromAddress": "sequi",
    "ContactId": 998,
    "ContactName": "Jacobi LLC",
    "OwnedByAssociateId": 62
  },
  "CreatedAt": "2009-10-09T14:58:05.3595934+02:00",
  "CreatedBy": {
    "AssociateId": 74,
    "Name": "Quitzon, Lang and Collins",
    "PersonId": 440,
    "Rank": 924,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 147,
    "FullName": "Federico Lakin",
    "FormalName": "Wyman Inc and Sons",
    "Deleted": false,
    "EjUserId": 197,
    "UserName": "Graham-Stanton"
  },
  "Author": "voluptatem",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "quam",
  "TimeSpent": 436,
  "Body": "sit",
  "HtmlBody": "quaerat",
  "EmailHeader": "treva.mayert@kovacek.co.uk",
  "DebugInfo": "reprehenderit",
  "MailSorter": "mollitia",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "saepe",
    "PersonId": 131,
    "Mrmrs": "dolor",
    "Firstname": "Helen",
    "Lastname": "Huels",
    "MiddleName": "Cormier-Ernser",
    "Title": "ducimus",
    "Description": "Proactive impactful forecast",
    "Email": "brianne.schmidt@jenkins.ca",
    "FullName": "Gustave Cassin",
    "DirectPhone": "1-826-436-2812 x316",
    "FormalName": "O'Conner, Sporer and Rau",
    "CountryId": 799,
    "ContactId": 132,
    "ContactName": "Wisoky-Swaniawski",
    "Retired": 617,
    "Rank": 481,
    "ActiveInterests": 281,
    "ContactDepartment": "",
    "ContactCountryId": 521,
    "ContactOrgNr": "499512",
    "FaxPhone": "1-255-832-4687",
    "MobilePhone": "411.680.3647",
    "ContactPhone": "(254)061-1010",
    "AssociateName": "Stroman-Barton",
    "AssociateId": 820,
    "UsePersonAddress": true,
    "ContactFax": "dolore",
    "Kanafname": "consequatur",
    "Kanalname": "dolorem",
    "Post1": "dolorem",
    "Post2": "nihil",
    "Post3": "assumenda",
    "EmailName": "else@kautzer.uk",
    "ContactFullName": "Ernestina Beahan III",
    "ActiveErpLinks": 332,
    "TicketPriorityId": 562,
    "SupportLanguageId": 288,
    "SupportAssociateId": 586,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "harum",
  "MessageHeaders": [
    {
      "Name": "Towne Inc and Sons",
      "Value": "saepe"
    },
    {
      "Name": "Towne Inc and Sons",
      "Value": "saepe"
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "dignissimos"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 404,
  "Ticket": {
    "TicketId": 936,
    "Title": "quos",
    "CreatedAt": "2010-02-10T14:58:05.3655933+01:00",
    "LastChanged": "2009-12-10T14:58:05.3655933+01:00",
    "ReadByOwner": "2015-12-19T14:58:05.3655933+01:00",
    "ReadByCustomer": "2014-11-20T14:58:05.3655933+01:00",
    "FirstReadByUser": "2021-04-19T14:58:05.3655933+02:00",
    "Activate": "2020-10-30T14:58:05.3655933+01:00",
    "ClosedAt": "2012-09-20T14:58:05.3655933+02:00",
    "RepliedAt": "1995-01-16T14:58:05.3655933+01:00",
    "AlertTimeout": "1999-06-17T14:58:05.3655933+02:00",
    "Deadline": "2009-06-03T14:58:05.3655933+02:00",
    "CreatedBy": 630,
    "CreatedByName": "Balistreri, Hodkiewicz and Veum",
    "Author": "fuga",
    "OwnedBy": 741,
    "OwnedByName": "Harber, Kassulke and Johns",
    "Category": 451,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 20,
    "PriorityName": "Veum, Mraz and Hegmann",
    "BaseStatus": "Active",
    "TicketStatus": 774,
    "TicketStatusDisplayValue": "rerum",
    "Origin": "AutoGenerated",
    "CustId": 985,
    "PersonFirstname": "Clifford",
    "PersonMiddleName": "Olson, Friesen and Greenholt",
    "PersonLastname": "Satterfield",
    "PersonFullname": "eaque",
    "AlertLevel": 750,
    "ConnectId": 677,
    "ReadStatus": "Green",
    "TimeToReply": 70,
    "RealTimeToReply": 302,
    "TimeToClose": 178,
    "RealTimeToClose": 132,
    "TimeSpentInternally": 907,
    "TimeSpentExternally": 665,
    "TimeSpentQueue": 955,
    "RealTimeSpentInternally": 448,
    "RealTimeSpentExternally": 67,
    "RealTimeSpentQueue": 4,
    "HasAttachment": false,
    "NumReplies": 499,
    "NumMessages": 231,
    "FromAddress": "sed",
    "ContactId": 707,
    "ContactName": "Becker-Padberg",
    "OwnedByAssociateId": 264,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 718
      }
    }
  },
  "CreatedAt": "2016-01-20T14:58:05.3655933+01:00",
  "CreatedBy": {
    "AssociateId": 965,
    "Name": "Pfannerstill-Lockman",
    "PersonId": 320,
    "Rank": 384,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 817,
    "FullName": "Irwin Emard",
    "FormalName": "Brekke, Jenkins and Dickinson",
    "Deleted": false,
    "EjUserId": 982,
    "UserName": "Deckow LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 486
      }
    }
  },
  "Author": "architecto",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "et",
  "TimeSpent": 461,
  "Body": "earum",
  "HtmlBody": "ut",
  "EmailHeader": "neha_gorczany@muellerhahn.ca",
  "DebugInfo": "voluptate",
  "MailSorter": "similique",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "sit",
    "PersonId": 416,
    "Mrmrs": "voluptatem",
    "Firstname": "Juvenal",
    "Lastname": "Hickle",
    "MiddleName": "Kozey-Skiles",
    "Title": "et",
    "Description": "Pre-emptive content-based policy",
    "Email": "winnifred.vandervort@corkery.us",
    "FullName": "Mireille Schowalter",
    "DirectPhone": "670-745-4048 x83763",
    "FormalName": "Ernser, O'Conner and Smitham",
    "CountryId": 384,
    "ContactId": 578,
    "ContactName": "Goodwin, Carroll and Grant",
    "Retired": 634,
    "Rank": 706,
    "ActiveInterests": 559,
    "ContactDepartment": "",
    "ContactCountryId": 57,
    "ContactOrgNr": "858578",
    "FaxPhone": "1-575-651-0661 x0341",
    "MobilePhone": "721.273.2748",
    "ContactPhone": "(778)233-5628 x615",
    "AssociateName": "Satterfield-O'Keefe",
    "AssociateId": 902,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "molestias",
    "Kanalname": "soluta",
    "Post1": "sint",
    "Post2": "esse",
    "Post3": "quia",
    "EmailName": "bradly_carter@douglas.uk",
    "ContactFullName": "Lilly Sawayn",
    "ActiveErpLinks": 818,
    "TicketPriorityId": 878,
    "SupportLanguageId": 472,
    "SupportAssociateId": 120,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 106
      }
    }
  },
  "SearchTitle": "sit",
  "MessageHeaders": [
    {
      "Name": "Grant Inc and Sons",
      "Value": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    },
    {
      "Name": "Grant Inc and Sons",
      "Value": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "quis"
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
      "FieldLength": 947
    }
  }
}
```