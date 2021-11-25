---
title: GET TicketMessage/{id}
id: v1TicketMessageEntity_GetTicketMessageEntity
---

# GET TicketMessage/{id}

```http
GET /api/v1/TicketMessage/{id}
```

Gets a TicketMessageEntity object.

Calls the Ticket agent service GetTicketMessageEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketMessageEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/TicketMessage/{id}?$select=name,department,category/id
GET /api/v1/TicketMessage/{id}?fk=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request).



TicketMessageEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TicketMessageEntity found. |
| 404 | Not Found. |

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
GET /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 TicketMessageEntity found.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 438,
  "Ticket": {
    "TicketId": 919,
    "Title": "soluta",
    "CreatedAt": "2001-09-05T18:25:51.2499438+02:00",
    "LastChanged": "1997-02-11T18:25:51.2499438+01:00",
    "ReadByOwner": "2009-11-22T18:25:51.2499438+01:00",
    "ReadByCustomer": "2013-08-02T18:25:51.2499438+02:00",
    "FirstReadByUser": "2006-04-27T18:25:51.2499438+02:00",
    "Activate": "2000-12-01T18:25:51.2499438+01:00",
    "ClosedAt": "2003-08-14T18:25:51.2499438+02:00",
    "RepliedAt": "2004-05-03T18:25:51.2499438+02:00",
    "AlertTimeout": "2003-12-26T18:25:51.2499438+01:00",
    "Deadline": "2020-09-15T18:25:51.2499438+02:00",
    "CreatedBy": 20,
    "CreatedByName": "Kautzer Inc and Sons",
    "Author": "reiciendis",
    "OwnedBy": 289,
    "OwnedByName": "O'Hara Inc and Sons",
    "Category": 889,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 663,
    "PriorityName": "Herman-Luettgen",
    "BaseStatus": "Active",
    "TicketStatus": 948,
    "TicketStatusDisplayValue": "voluptatem",
    "Origin": "AutoGenerated",
    "CustId": 794,
    "PersonFirstname": "Landen",
    "PersonMiddleName": "Torphy LLC",
    "PersonLastname": "Schoen",
    "PersonFullname": "asperiores",
    "AlertLevel": 982,
    "ConnectId": 761,
    "ReadStatus": "Green",
    "TimeToReply": 368,
    "RealTimeToReply": 722,
    "TimeToClose": 206,
    "RealTimeToClose": 448,
    "TimeSpentInternally": 415,
    "TimeSpentExternally": 228,
    "TimeSpentQueue": 860,
    "RealTimeSpentInternally": 51,
    "RealTimeSpentExternally": 552,
    "RealTimeSpentQueue": 126,
    "HasAttachment": true,
    "NumReplies": 846,
    "NumMessages": 794,
    "FromAddress": "et",
    "ContactId": 11,
    "ContactName": "Anderson, McClure and Reichel",
    "OwnedByAssociateId": 768,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 572
      }
    }
  },
  "CreatedAt": "2014-06-16T18:25:51.2519398+02:00",
  "CreatedBy": {
    "AssociateId": 390,
    "Name": "Dach, Graham and Halvorson",
    "PersonId": 674,
    "Rank": 348,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 226,
    "FullName": "Buford Will",
    "FormalName": "Shanahan LLC",
    "Deleted": true,
    "EjUserId": 529,
    "UserName": "Hettinger, Gleichner and Gislason",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 399
      }
    }
  },
  "Author": "iure",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "debitis",
  "TimeSpent": 143,
  "Body": "rerum",
  "HtmlBody": "ut",
  "EmailHeader": "laura.beer@gutkowski.info",
  "DebugInfo": "harum",
  "MailSorter": "ut",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "dolorem",
    "PersonId": 909,
    "Mrmrs": "est",
    "Firstname": "Gaetano",
    "Lastname": "Fay",
    "MiddleName": "Goldner-Hackett",
    "Title": "necessitatibus",
    "Description": "Automated content-based algorithm",
    "Email": "blanca@west.us",
    "FullName": "Delores Haag",
    "DirectPhone": "800-163-3812 x026",
    "FormalName": "Labadie Inc and Sons",
    "CountryId": 474,
    "ContactId": 321,
    "ContactName": "Quigley Group",
    "Retired": 254,
    "Rank": 541,
    "ActiveInterests": 11,
    "ContactDepartment": "",
    "ContactCountryId": 506,
    "ContactOrgNr": "1487456",
    "FaxPhone": "465.566.3114 x888",
    "MobilePhone": "(886)373-2750 x53640",
    "ContactPhone": "(284)364-4505",
    "AssociateName": "Schultz Inc and Sons",
    "AssociateId": 820,
    "UsePersonAddress": true,
    "ContactFax": "ipsa",
    "Kanafname": "in",
    "Kanalname": "aspernatur",
    "Post1": "facilis",
    "Post2": "ut",
    "Post3": "voluptatem",
    "EmailName": "zula.wolff@emard.name",
    "ContactFullName": "Kaitlin Dietrich",
    "ActiveErpLinks": 451,
    "TicketPriorityId": 504,
    "SupportLanguageId": 135,
    "SupportAssociateId": 401,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 557
      }
    }
  },
  "SearchTitle": "est",
  "MessageHeaders": [
    {
      "Name": "Howell, Herman and Treutel",
      "Value": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    },
    {
      "Name": "Howell, Herman and Treutel",
      "Value": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "sapiente",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "nostrum"
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
      "FieldLength": 127
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```