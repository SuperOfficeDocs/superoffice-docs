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
  "EjMessageId": 705,
  "Ticket": {
    "TicketId": 414,
    "Title": "dolor",
    "CreatedAt": "2019-07-10T18:25:51.2539109+02:00",
    "LastChanged": "2012-03-11T18:25:51.2539109+01:00",
    "ReadByOwner": "2001-07-18T18:25:51.2539109+02:00",
    "ReadByCustomer": "2016-05-24T18:25:51.2539109+02:00",
    "FirstReadByUser": "1997-06-08T18:25:51.2539109+02:00",
    "Activate": "2004-10-16T18:25:51.2539109+02:00",
    "ClosedAt": "1994-11-16T18:25:51.2539109+01:00",
    "RepliedAt": "2015-04-16T18:25:51.2539109+02:00",
    "AlertTimeout": "1999-09-14T18:25:51.2539109+02:00",
    "Deadline": "2020-01-26T18:25:51.2539109+01:00",
    "CreatedBy": 724,
    "CreatedByName": "Jaskolski-Conn",
    "Author": "perspiciatis",
    "OwnedBy": 500,
    "OwnedByName": "Miller, Balistreri and Torphy",
    "Category": 268,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 478,
    "PriorityName": "Torp-Dickinson",
    "BaseStatus": "Active",
    "TicketStatus": 449,
    "TicketStatusDisplayValue": "laudantium",
    "Origin": "AutoGenerated",
    "CustId": 620,
    "PersonFirstname": "Favian",
    "PersonMiddleName": "Altenwerth, Emard and Keeling",
    "PersonLastname": "Shanahan",
    "PersonFullname": "ad",
    "AlertLevel": 360,
    "ConnectId": 480,
    "ReadStatus": "Green",
    "TimeToReply": 575,
    "RealTimeToReply": 773,
    "TimeToClose": 98,
    "RealTimeToClose": 23,
    "TimeSpentInternally": 43,
    "TimeSpentExternally": 986,
    "TimeSpentQueue": 467,
    "RealTimeSpentInternally": 24,
    "RealTimeSpentExternally": 814,
    "RealTimeSpentQueue": 245,
    "HasAttachment": false,
    "NumReplies": 822,
    "NumMessages": 146,
    "FromAddress": "maxime",
    "ContactId": 10,
    "ContactName": "Eichmann-Schimmel",
    "OwnedByAssociateId": 621
  },
  "CreatedAt": "2005-05-04T18:25:51.2539109+02:00",
  "CreatedBy": {
    "AssociateId": 869,
    "Name": "Beier, Cummings and Bins",
    "PersonId": 326,
    "Rank": 66,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 529,
    "FullName": "Maryjane Turner",
    "FormalName": "Schaefer, Dach and Renner",
    "Deleted": true,
    "EjUserId": 728,
    "UserName": "Baumbach-Hirthe"
  },
  "Author": "voluptatem",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "illum",
  "TimeSpent": 577,
  "Body": "error",
  "HtmlBody": "repudiandae",
  "EmailHeader": "reese.stehr@okuneva.com",
  "DebugInfo": "consequatur",
  "MailSorter": "blanditiis",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "eius",
    "PersonId": 264,
    "Mrmrs": "sit",
    "Firstname": "Sincere",
    "Lastname": "Cummerata",
    "MiddleName": "Marvin, Mitchell and Auer",
    "Title": "autem",
    "Description": "Implemented 4th generation access",
    "Email": "vincent_ryan@stracke.us",
    "FullName": "Quinn Hane",
    "DirectPhone": "(770)135-5525",
    "FormalName": "Wisoky Group",
    "CountryId": 884,
    "ContactId": 246,
    "ContactName": "Skiles-Rowe",
    "Retired": 286,
    "Rank": 28,
    "ActiveInterests": 131,
    "ContactDepartment": "",
    "ContactCountryId": 805,
    "ContactOrgNr": "507824",
    "FaxPhone": "(114)864-5806 x4877",
    "MobilePhone": "1-361-680-2524 x0421",
    "ContactPhone": "060-633-1376 x3774",
    "AssociateName": "Waters, Windler and Kunde",
    "AssociateId": 282,
    "UsePersonAddress": false,
    "ContactFax": "eligendi",
    "Kanafname": "qui",
    "Kanalname": "at",
    "Post1": "voluptatem",
    "Post2": "quisquam",
    "Post3": "ut",
    "EmailName": "gerda_shanahan@berge.us",
    "ContactFullName": "Derick Auer",
    "ActiveErpLinks": 564,
    "TicketPriorityId": 175,
    "SupportLanguageId": 435,
    "SupportAssociateId": 71,
    "CategoryName": "VIP Customer"
  },
  "SearchTitle": "omnis",
  "MessageHeaders": [
    {
      "Name": "Bahringer Inc and Sons",
      "Value": "fugit"
    },
    {
      "Name": "Bahringer Inc and Sons",
      "Value": "fugit"
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "eos"
  }
}
```

```http_
HTTP/1.1 200 TicketMessageEntity updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 520,
  "Ticket": {
    "TicketId": 408,
    "Title": "nisi",
    "CreatedAt": "2003-01-29T18:25:51.2599366+01:00",
    "LastChanged": "2001-11-25T18:25:51.2599366+01:00",
    "ReadByOwner": "2015-04-14T18:25:51.2599366+02:00",
    "ReadByCustomer": "2010-10-13T18:25:51.2599366+02:00",
    "FirstReadByUser": "1995-12-31T18:25:51.2599366+01:00",
    "Activate": "2016-02-04T18:25:51.2599366+01:00",
    "ClosedAt": "1999-02-04T18:25:51.2599366+01:00",
    "RepliedAt": "1998-10-31T18:25:51.2599366+01:00",
    "AlertTimeout": "2014-01-01T18:25:51.2599366+01:00",
    "Deadline": "2015-08-19T18:25:51.2599366+02:00",
    "CreatedBy": 276,
    "CreatedByName": "Beahan Group",
    "Author": "corporis",
    "OwnedBy": 735,
    "OwnedByName": "Sawayn-Gislason",
    "Category": 909,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 215,
    "PriorityName": "Dickinson-Bartoletti",
    "BaseStatus": "Active",
    "TicketStatus": 883,
    "TicketStatusDisplayValue": "dolorem",
    "Origin": "AutoGenerated",
    "CustId": 566,
    "PersonFirstname": "Darlene",
    "PersonMiddleName": "Mohr, Beahan and Medhurst",
    "PersonLastname": "Brown",
    "PersonFullname": "dignissimos",
    "AlertLevel": 868,
    "ConnectId": 798,
    "ReadStatus": "Green",
    "TimeToReply": 210,
    "RealTimeToReply": 97,
    "TimeToClose": 750,
    "RealTimeToClose": 464,
    "TimeSpentInternally": 492,
    "TimeSpentExternally": 901,
    "TimeSpentQueue": 915,
    "RealTimeSpentInternally": 761,
    "RealTimeSpentExternally": 48,
    "RealTimeSpentQueue": 623,
    "HasAttachment": false,
    "NumReplies": 439,
    "NumMessages": 116,
    "FromAddress": "eligendi",
    "ContactId": 214,
    "ContactName": "Stokes, Wilderman and Bartoletti",
    "OwnedByAssociateId": 463,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 325
      }
    }
  },
  "CreatedAt": "2018-10-26T18:25:51.2609399+02:00",
  "CreatedBy": {
    "AssociateId": 956,
    "Name": "Mraz, Konopelski and Hayes",
    "PersonId": 401,
    "Rank": 112,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 447,
    "FullName": "Sadie Wunsch",
    "FormalName": "Bernhard, White and Weissnat",
    "Deleted": true,
    "EjUserId": 289,
    "UserName": "Legros-Turcotte",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage ubiquitous deliverables"
        },
        "FieldType": "System.String",
        "FieldLength": 975
      }
    }
  },
  "Author": "recusandae",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "sed",
  "TimeSpent": 138,
  "Body": "veniam",
  "HtmlBody": "voluptas",
  "EmailHeader": "johnpaul.runolfsson@zulaufwitting.com",
  "DebugInfo": "quis",
  "MailSorter": "cupiditate",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "nihil",
    "PersonId": 809,
    "Mrmrs": "vel",
    "Firstname": "Nicola",
    "Lastname": "Kshlerin",
    "MiddleName": "Medhurst-Bartell",
    "Title": "excepturi",
    "Description": "Mandatory homogeneous algorithm",
    "Email": "tomasa.olson@willms.biz",
    "FullName": "Nayeli McDermott DVM",
    "DirectPhone": "365-306-4331 x4081",
    "FormalName": "Cummings-Gaylord",
    "CountryId": 912,
    "ContactId": 516,
    "ContactName": "Kessler, Koelpin and Von",
    "Retired": 109,
    "Rank": 778,
    "ActiveInterests": 77,
    "ContactDepartment": "",
    "ContactCountryId": 406,
    "ContactOrgNr": "735325",
    "FaxPhone": "146-234-0264 x2411",
    "MobilePhone": "(854)477-0018 x6450",
    "ContactPhone": "(127)534-2816 x15731",
    "AssociateName": "Robel, Wiza and Bogan",
    "AssociateId": 96,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "quibusdam",
    "Kanalname": "provident",
    "Post1": "sit",
    "Post2": "earum",
    "Post3": "corporis",
    "EmailName": "graciela.powlowski@ryandaniel.biz",
    "ContactFullName": "Guillermo Satterfield",
    "ActiveErpLinks": 725,
    "TicketPriorityId": 256,
    "SupportLanguageId": 283,
    "SupportAssociateId": 590,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 537
      }
    }
  },
  "SearchTitle": "recusandae",
  "MessageHeaders": [
    {
      "Name": "Fritsch-Mitchell",
      "Value": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    },
    {
      "Name": "Fritsch-Mitchell",
      "Value": "voluptas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "odit",
    "CustomFields2": "magni"
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
      "FieldLength": 871
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```