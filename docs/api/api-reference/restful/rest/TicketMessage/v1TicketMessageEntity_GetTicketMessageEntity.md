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
  "EjMessageId": 737,
  "Ticket": {
    "TicketId": 2,
    "Title": "corrupti",
    "CreatedAt": "2006-09-19T09:40:59.880065+02:00",
    "LastChanged": "2001-03-04T09:40:59.880065+01:00",
    "ReadByOwner": "1995-07-05T09:40:59.880065+02:00",
    "ReadByCustomer": "2002-06-14T09:40:59.880065+02:00",
    "FirstReadByUser": "2002-11-25T09:40:59.880065+01:00",
    "Activate": "2011-01-21T09:40:59.880065+01:00",
    "ClosedAt": "2008-08-10T09:40:59.880065+02:00",
    "RepliedAt": "2016-10-16T09:40:59.880065+02:00",
    "AlertTimeout": "2017-05-10T09:40:59.880065+02:00",
    "Deadline": "2011-09-20T09:40:59.880065+02:00",
    "CreatedBy": 815,
    "CreatedByName": "Lueilwitz-Herman",
    "Author": "nemo",
    "OwnedBy": 720,
    "OwnedByName": "Rippin-Towne",
    "Category": 150,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 229,
    "BaseStatus": "Active",
    "TicketStatus": 379,
    "Origin": "AutoGenerated",
    "CustId": 284,
    "CustFirstname": "Kenny",
    "CustMiddleName": "Pouros Group",
    "CustLastname": "Reichel",
    "AlertLevel": 925,
    "ConnectId": 459,
    "ReadStatus": "Green",
    "TimeToReply": 296,
    "RealTimeToReply": 293,
    "TimeToClose": 572,
    "RealTimeToClose": 856,
    "TimeSpentInternally": 446,
    "TimeSpentExternally": 180,
    "TimeSpentQueue": 707,
    "RealTimeSpentInternally": 931,
    "RealTimeSpentExternally": 956,
    "RealTimeSpentQueue": 590,
    "HasAttachment": false,
    "NumReplies": 950,
    "NumMessages": 931,
    "FromAddress": "fugiat",
    "CustFullname": "ad",
    "TicketStatusDisplayValue": "sed",
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
  "CreatedAt": "2012-10-14T09:40:59.880065+02:00",
  "CreatedBy": {
    "AssociateId": 156,
    "Name": "Trantow Group",
    "PersonId": 450,
    "Rank": 492,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Mr. Cale Moen",
    "FormalName": "Quitzon LLC",
    "Deleted": true,
    "EjUserId": 274,
    "UserName": "Pouros LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 613
      }
    }
  },
  "Author": "blanditiis",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "temporibus",
  "TimeSpent": 69,
  "Body": "cumque",
  "HtmlBody": "veniam",
  "EmailHeader": "jaycee.kulas@stark.uk",
  "DebugInfo": "recusandae",
  "MailSorter": "ut",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "dolorem",
    "PersonId": 234,
    "Mrmrs": "et",
    "Firstname": "Kyra",
    "Lastname": "Rice",
    "MiddleName": "Marquardt, Smith and Upton",
    "Title": "voluptas",
    "Description": "Virtual incremental extranet",
    "Email": "shayne_weber@pfefferrice.info",
    "FullName": "Kole Rau",
    "DirectPhone": "(556)843-2458 x5153",
    "FormalName": "Nitzsche LLC",
    "CountryId": 859,
    "ContactId": 350,
    "ContactName": "Cronin, Champlin and Streich",
    "Retired": 50,
    "Rank": 761,
    "ActiveInterests": 37,
    "ContactDepartment": "",
    "ContactCountryId": 209,
    "ContactOrgNr": "855832",
    "FaxPhone": "(070)201-8136 x868",
    "MobilePhone": "720-402-6274",
    "ContactPhone": "(651)430-1145 x241",
    "AssociateName": "Kshlerin LLC",
    "AssociateId": 707,
    "UsePersonAddress": false,
    "ContactFax": "consectetur",
    "Kanafname": "necessitatibus",
    "Kanalname": "delectus",
    "Post1": "aut",
    "Post2": "laboriosam",
    "Post3": "nobis",
    "EmailName": "alene_schroeder@legros.biz",
    "ContactFullName": "Nadia Stamm",
    "ActiveErpLinks": 623,
    "TicketPriorityId": 469,
    "SupportLanguageId": 630,
    "SupportAssociateId": 554,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 611
      }
    }
  },
  "SearchTitle": "quasi",
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "qui"
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
      "FieldLength": 806
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```