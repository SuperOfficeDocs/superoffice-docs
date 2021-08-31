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
Accept-Language: en
```

```http_
HTTP/1.1 200 TicketMessageEntity found.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 371,
  "Ticket": {
    "TicketId": 44,
    "Title": "vero",
    "CreatedAt": "2015-11-26T15:05:42.931633+01:00",
    "LastChanged": "2016-08-10T15:05:42.931633+02:00",
    "ReadByOwner": "1999-03-04T15:05:42.931633+01:00",
    "ReadByCustomer": "2012-09-29T15:05:42.931633+02:00",
    "FirstReadByUser": "2005-07-04T15:05:42.931633+02:00",
    "Activate": "2002-02-14T15:05:42.931633+01:00",
    "ClosedAt": "2002-06-26T15:05:42.931633+02:00",
    "RepliedAt": "2002-04-06T15:05:42.931633+02:00",
    "AlertTimeout": "2014-02-04T15:05:42.931633+01:00",
    "Deadline": "2020-12-04T15:05:42.931633+01:00",
    "CreatedBy": 241,
    "CreatedByName": "Schaden Inc and Sons",
    "Author": "officiis",
    "OwnedBy": 915,
    "OwnedByName": "O'Hara Inc and Sons",
    "Category": 809,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 128,
    "PriorityName": "Metz-Greenfelder",
    "BaseStatus": "Active",
    "TicketStatus": 542,
    "TicketStatusDisplayValue": "quam",
    "Origin": "AutoGenerated",
    "CustId": 222,
    "PersonFirstname": "Kelley",
    "PersonMiddleName": "Aufderhar, Johnson and Emmerich",
    "PersonLastname": "Hintz",
    "PersonFullname": "sint",
    "AlertLevel": 57,
    "ConnectId": 968,
    "ReadStatus": "Green",
    "TimeToReply": 272,
    "RealTimeToReply": 991,
    "TimeToClose": 273,
    "RealTimeToClose": 205,
    "TimeSpentInternally": 122,
    "TimeSpentExternally": 345,
    "TimeSpentQueue": 632,
    "RealTimeSpentInternally": 129,
    "RealTimeSpentExternally": 298,
    "RealTimeSpentQueue": 391,
    "HasAttachment": false,
    "NumReplies": 50,
    "NumMessages": 345,
    "FromAddress": "esse",
    "ContactId": 729,
    "ContactName": "Pouros Inc and Sons",
    "OwnedByAssociateId": 181,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 762
      }
    }
  },
  "CreatedAt": "1998-10-03T15:05:42.9326325+02:00",
  "CreatedBy": {
    "AssociateId": 49,
    "Name": "O'Kon, Leuschke and Ebert",
    "PersonId": 738,
    "Rank": 182,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 419,
    "FullName": "Ashton Tromp",
    "FormalName": "Tromp Inc and Sons",
    "Deleted": false,
    "EjUserId": 833,
    "UserName": "Turcotte, Padberg and Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 225
      }
    }
  },
  "Author": "temporibus",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "excepturi",
  "TimeSpent": 368,
  "Body": "natus",
  "HtmlBody": "officia",
  "EmailHeader": "madaline@durgancrooks.com",
  "DebugInfo": "in",
  "MailSorter": "autem",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "similique",
    "PersonId": 275,
    "Mrmrs": "a",
    "Firstname": "Travon",
    "Lastname": "Hills",
    "MiddleName": "Stehr-Toy",
    "Title": "excepturi",
    "Description": "Face to face 6th generation forecast",
    "Email": "isabel_reichert@nienow.biz",
    "FullName": "Daniella Pouros IV",
    "DirectPhone": "723.384.2874",
    "FormalName": "Prohaska-Connelly",
    "CountryId": 121,
    "ContactId": 699,
    "ContactName": "Connelly-Greenfelder",
    "Retired": 156,
    "Rank": 807,
    "ActiveInterests": 616,
    "ContactDepartment": "",
    "ContactCountryId": 587,
    "ContactOrgNr": "1456343",
    "FaxPhone": "1-375-062-7205",
    "MobilePhone": "(034)055-2214",
    "ContactPhone": "010-846-4257 x45133",
    "AssociateName": "Senger, Dickens and Stamm",
    "AssociateId": 884,
    "UsePersonAddress": true,
    "ContactFax": "ratione",
    "Kanafname": "itaque",
    "Kanalname": "impedit",
    "Post1": "saepe",
    "Post2": "adipisci",
    "Post3": "eum",
    "EmailName": "ruth.wisozk@prosacco.info",
    "ContactFullName": "Herta Mueller",
    "ActiveErpLinks": 748,
    "TicketPriorityId": 395,
    "SupportLanguageId": 700,
    "SupportAssociateId": 229,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 279
      }
    }
  },
  "SearchTitle": "id",
  "MessageHeaders": [
    {
      "Name": "Beer, Wuckert and Zieme",
      "Value": "repellat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    },
    {
      "Name": "Beer, Wuckert and Zieme",
      "Value": "repellat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "Important": false,
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "cumque"
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
      "FieldLength": 194
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```