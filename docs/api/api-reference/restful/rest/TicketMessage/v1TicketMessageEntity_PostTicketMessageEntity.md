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
  "EjMessageId": 144,
  "Ticket": {
    "TicketId": 279,
    "Title": "vitae",
    "CreatedAt": "2010-03-14T15:05:42.8826593+01:00",
    "LastChanged": "1997-01-02T15:05:42.8826593+01:00",
    "ReadByOwner": "2014-01-01T15:05:42.8826593+01:00",
    "ReadByCustomer": "2003-10-02T15:05:42.8826593+02:00",
    "FirstReadByUser": "2017-03-25T15:05:42.8826593+01:00",
    "Activate": "2006-12-06T15:05:42.8826593+01:00",
    "ClosedAt": "2021-02-17T15:05:42.8826593+01:00",
    "RepliedAt": "2009-11-22T15:05:42.8826593+01:00",
    "AlertTimeout": "2000-10-04T15:05:42.8826593+02:00",
    "Deadline": "2019-12-04T15:05:42.8826593+01:00",
    "CreatedBy": 945,
    "CreatedByName": "Mayer-Wisozk",
    "Author": "earum",
    "OwnedBy": 711,
    "OwnedByName": "Pfeffer Inc and Sons",
    "Category": 85,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 390,
    "PriorityName": "Nicolas Group",
    "BaseStatus": "Active",
    "TicketStatus": 988,
    "TicketStatusDisplayValue": "alias",
    "Origin": "AutoGenerated",
    "CustId": 520,
    "PersonFirstname": "Austen",
    "PersonMiddleName": "Gaylord-Nienow",
    "PersonLastname": "Leuschke",
    "PersonFullname": "rem",
    "AlertLevel": 520,
    "ConnectId": 440,
    "ReadStatus": "Green",
    "TimeToReply": 15,
    "RealTimeToReply": 16,
    "TimeToClose": 546,
    "RealTimeToClose": 150,
    "TimeSpentInternally": 849,
    "TimeSpentExternally": 844,
    "TimeSpentQueue": 715,
    "RealTimeSpentInternally": 776,
    "RealTimeSpentExternally": 330,
    "RealTimeSpentQueue": 131,
    "HasAttachment": false,
    "NumReplies": 989,
    "NumMessages": 1000,
    "FromAddress": "excepturi",
    "ContactId": 157,
    "ContactName": "Jerde LLC",
    "OwnedByAssociateId": 34
  },
  "CreatedAt": "2004-02-08T15:05:42.8836577+01:00",
  "CreatedBy": {
    "AssociateId": 763,
    "Name": "Jones Inc and Sons",
    "PersonId": 68,
    "Rank": 713,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Roosevelt Durgan Sr.",
    "FormalName": "McClure-Kuhic",
    "Deleted": false,
    "EjUserId": 258,
    "UserName": "Ankunding Group"
  },
  "Author": "non",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "consequuntur",
  "TimeSpent": 385,
  "Body": "illo",
  "HtmlBody": "voluptate",
  "EmailHeader": "dena@carter.com",
  "DebugInfo": "quis",
  "MailSorter": "officia",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "temporibus",
    "PersonId": 95,
    "Mrmrs": "in",
    "Firstname": "Justina",
    "Lastname": "Langworth",
    "MiddleName": "Rowe LLC",
    "Title": "perspiciatis",
    "Description": "Networked cohesive knowledge user",
    "Email": "jefferey.west@boscokemmer.name",
    "FullName": "Laverne Koch",
    "DirectPhone": "111-510-4868 x8734",
    "FormalName": "Oberbrunner, Moen and Cruickshank",
    "CountryId": 233,
    "ContactId": 627,
    "ContactName": "Fahey-Kassulke",
    "Retired": 614,
    "Rank": 355,
    "ActiveInterests": 565,
    "ContactDepartment": "monetize synergistic schemas",
    "ContactCountryId": 191,
    "ContactOrgNr": "655476",
    "FaxPhone": "(305)883-8277 x41581",
    "MobilePhone": "363.708.6525 x0128",
    "ContactPhone": "1-464-170-5275 x3350",
    "AssociateName": "Willms Inc and Sons",
    "AssociateId": 130,
    "UsePersonAddress": false,
    "ContactFax": "ducimus",
    "Kanafname": "minima",
    "Kanalname": "quas",
    "Post1": "doloremque",
    "Post2": "quia",
    "Post3": "autem",
    "EmailName": "tom.beer@considineschneider.us",
    "ContactFullName": "Natasha Kunze",
    "ActiveErpLinks": 573,
    "TicketPriorityId": 193,
    "SupportLanguageId": 603,
    "SupportAssociateId": 500,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "ducimus",
  "MessageHeaders": [
    {
      "Name": "Nikolaus Group",
      "Value": "laboriosam"
    },
    {
      "Name": "Nikolaus Group",
      "Value": "laboriosam"
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "molestiae"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 391,
  "Ticket": {
    "TicketId": 741,
    "Title": "dolore",
    "CreatedAt": "1997-06-28T15:05:42.9106677+02:00",
    "LastChanged": "2014-01-18T15:05:42.9106677+01:00",
    "ReadByOwner": "2004-01-19T15:05:42.9106677+01:00",
    "ReadByCustomer": "1994-11-30T15:05:42.9106677+01:00",
    "FirstReadByUser": "1998-10-23T15:05:42.9106677+02:00",
    "Activate": "2009-12-10T15:05:42.9106677+01:00",
    "ClosedAt": "2017-02-08T15:05:42.9106677+01:00",
    "RepliedAt": "1998-03-29T15:05:42.9106677+02:00",
    "AlertTimeout": "2011-09-05T15:05:42.9106677+02:00",
    "Deadline": "1999-10-18T15:05:42.9106677+02:00",
    "CreatedBy": 821,
    "CreatedByName": "Wolff, Lang and Shanahan",
    "Author": "velit",
    "OwnedBy": 948,
    "OwnedByName": "Maggio, Dickinson and Schultz",
    "Category": 807,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 902,
    "PriorityName": "Ondricka, Wuckert and Rice",
    "BaseStatus": "Active",
    "TicketStatus": 892,
    "TicketStatusDisplayValue": "sed",
    "Origin": "AutoGenerated",
    "CustId": 811,
    "PersonFirstname": "Domenico",
    "PersonMiddleName": "Glover Inc and Sons",
    "PersonLastname": "Kunde",
    "PersonFullname": "et",
    "AlertLevel": 428,
    "ConnectId": 658,
    "ReadStatus": "Green",
    "TimeToReply": 914,
    "RealTimeToReply": 267,
    "TimeToClose": 372,
    "RealTimeToClose": 714,
    "TimeSpentInternally": 661,
    "TimeSpentExternally": 631,
    "TimeSpentQueue": 444,
    "RealTimeSpentInternally": 14,
    "RealTimeSpentExternally": 577,
    "RealTimeSpentQueue": 56,
    "HasAttachment": true,
    "NumReplies": 475,
    "NumMessages": 455,
    "FromAddress": "eveniet",
    "ContactId": 766,
    "ContactName": "Carter LLC",
    "OwnedByAssociateId": 910,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 703
      }
    }
  },
  "CreatedAt": "2006-05-29T15:05:42.9106677+02:00",
  "CreatedBy": {
    "AssociateId": 816,
    "Name": "Predovic Inc and Sons",
    "PersonId": 792,
    "Rank": 696,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 989,
    "FullName": "Eldora Gleason",
    "FormalName": "Harber LLC",
    "Deleted": true,
    "EjUserId": 545,
    "UserName": "Robel Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 733
      }
    }
  },
  "Author": "vel",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "qui",
  "TimeSpent": 580,
  "Body": "sequi",
  "HtmlBody": "quos",
  "EmailHeader": "oswald_herzog@hand.com",
  "DebugInfo": "et",
  "MailSorter": "architecto",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "tempora",
    "PersonId": 450,
    "Mrmrs": "omnis",
    "Firstname": "Carroll",
    "Lastname": "Welch",
    "MiddleName": "Kunze-Doyle",
    "Title": "consequatur",
    "Description": "Intuitive impactful solution",
    "Email": "linwood@fay.biz",
    "FullName": "Nils Thiel",
    "DirectPhone": "(480)126-3823",
    "FormalName": "Christiansen, Quigley and Huel",
    "CountryId": 684,
    "ContactId": 549,
    "ContactName": "Grady-McClure",
    "Retired": 44,
    "Rank": 314,
    "ActiveInterests": 925,
    "ContactDepartment": "",
    "ContactCountryId": 245,
    "ContactOrgNr": "977865",
    "FaxPhone": "726-045-8227 x12483",
    "MobilePhone": "1-188-864-2231",
    "ContactPhone": "645-783-7464 x23570",
    "AssociateName": "Quitzon-Davis",
    "AssociateId": 46,
    "UsePersonAddress": true,
    "ContactFax": "saepe",
    "Kanafname": "odit",
    "Kanalname": "ipsum",
    "Post1": "sunt",
    "Post2": "rerum",
    "Post3": "cum",
    "EmailName": "mustafa@robel.name",
    "ContactFullName": "Renee Pagac IV",
    "ActiveErpLinks": 712,
    "TicketPriorityId": 587,
    "SupportLanguageId": 886,
    "SupportAssociateId": 492,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize innovative interfaces"
        },
        "FieldType": "System.Int32",
        "FieldLength": 387
      }
    }
  },
  "SearchTitle": "est",
  "MessageHeaders": [
    {
      "Name": "Ritchie, Lesch and Lowe",
      "Value": "corrupti",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Name": "Ritchie, Lesch and Lowe",
      "Value": "corrupti",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "commodi"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "modi"
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
      "FieldType": "System.Int32",
      "FieldLength": 821
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```