---
title: PATCH TicketMessage/{id}
id: v1TicketMessageEntity_PatchTicketMessageEntity
---

# PATCH TicketMessage/{id}

```http
PATCH /api/v1/TicketMessage/{id}
```

Update a TicketMessageEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ITicketAgent} service SaveTicketMessageEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketMessageEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/TicketMessage/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request).



TicketMessageEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TicketMessageEntity  updated. |
| 404 | TicketMessageEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TicketMessageEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 5739,
        "EntityName": "person",
        "personId": 5739,
        "fullName": "Judy Nolan"
      },
      "value2": {
        "PrimaryKey": 7773,
        "EntityName": "person",
        "personId": 7773,
        "fullName": "Theron Padberg"
      }
    }
  },
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 5739,
        "EntityName": "person",
        "personId": 5739,
        "fullName": "Judy Nolan"
      },
      "value2": {
        "PrimaryKey": 7773,
        "EntityName": "person",
        "personId": 7773,
        "fullName": "Theron Padberg"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketMessageEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 683,
  "Ticket": {
    "TicketId": 523,
    "Title": "eos",
    "CreatedAt": "2004-01-26T15:05:42.9486326+01:00",
    "LastChanged": "2015-03-04T15:05:42.9486326+01:00",
    "ReadByOwner": "2005-10-31T15:05:42.9486326+01:00",
    "ReadByCustomer": "2021-08-10T15:05:42.9486326+02:00",
    "FirstReadByUser": "2006-03-23T15:05:42.9486326+01:00",
    "Activate": "1995-02-27T15:05:42.9486326+01:00",
    "ClosedAt": "1999-02-07T15:05:42.9486326+01:00",
    "RepliedAt": "1999-11-09T15:05:42.9486326+01:00",
    "AlertTimeout": "1997-05-20T15:05:42.9486326+02:00",
    "Deadline": "2020-04-05T15:05:42.9486326+02:00",
    "CreatedBy": 901,
    "CreatedByName": "Ratke-Pouros",
    "Author": "quia",
    "OwnedBy": 699,
    "OwnedByName": "Rau, Towne and Brakus",
    "Category": 836,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 966,
    "PriorityName": "Abshire-Carter",
    "BaseStatus": "Active",
    "TicketStatus": 154,
    "TicketStatusDisplayValue": "ipsa",
    "Origin": "AutoGenerated",
    "CustId": 122,
    "PersonFirstname": "Dayana",
    "PersonMiddleName": "Skiles-Klein",
    "PersonLastname": "Nikolaus",
    "PersonFullname": "eveniet",
    "AlertLevel": 4,
    "ConnectId": 314,
    "ReadStatus": "Green",
    "TimeToReply": 899,
    "RealTimeToReply": 298,
    "TimeToClose": 411,
    "RealTimeToClose": 597,
    "TimeSpentInternally": 91,
    "TimeSpentExternally": 236,
    "TimeSpentQueue": 922,
    "RealTimeSpentInternally": 989,
    "RealTimeSpentExternally": 773,
    "RealTimeSpentQueue": 806,
    "HasAttachment": false,
    "NumReplies": 762,
    "NumMessages": 810,
    "FromAddress": "laborum",
    "ContactId": 600,
    "ContactName": "Stanton-Jacobs",
    "OwnedByAssociateId": 645,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 310
      }
    }
  },
  "CreatedAt": "2008-09-19T15:05:42.9496324+02:00",
  "CreatedBy": {
    "AssociateId": 300,
    "Name": "Ortiz-Beer",
    "PersonId": 947,
    "Rank": 819,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 566,
    "FullName": "Zaria Jast",
    "FormalName": "Dickens Inc and Sons",
    "Deleted": true,
    "EjUserId": 273,
    "UserName": "Hettinger LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 43
      }
    }
  },
  "Author": "ab",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "necessitatibus",
  "TimeSpent": 227,
  "Body": "quia",
  "HtmlBody": "expedita",
  "EmailHeader": "toby@yost.uk",
  "DebugInfo": "rerum",
  "MailSorter": "ratione",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "velit",
    "PersonId": 164,
    "Mrmrs": "quae",
    "Firstname": "Tyrell",
    "Lastname": "Zemlak",
    "MiddleName": "Langworth, Simonis and Armstrong",
    "Title": "assumenda",
    "Description": "Face to face bandwidth-monitored hardware",
    "Email": "iliana_grant@legros.uk",
    "FullName": "Alfredo Kuhn",
    "DirectPhone": "1-178-322-3261 x111",
    "FormalName": "Conroy LLC",
    "CountryId": 915,
    "ContactId": 289,
    "ContactName": "McDermott Group",
    "Retired": 15,
    "Rank": 536,
    "ActiveInterests": 505,
    "ContactDepartment": "",
    "ContactCountryId": 859,
    "ContactOrgNr": "1262763",
    "FaxPhone": "620-445-6852 x487",
    "MobilePhone": "(426)113-5417 x8512",
    "ContactPhone": "635.670.7165",
    "AssociateName": "Kozey-Kub",
    "AssociateId": 337,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "ea",
    "Kanalname": "labore",
    "Post1": "optio",
    "Post2": "exercitationem",
    "Post3": "velit",
    "EmailName": "claude@shieldskemmer.us",
    "ContactFullName": "Rosemary Swift",
    "ActiveErpLinks": 893,
    "TicketPriorityId": 190,
    "SupportLanguageId": 38,
    "SupportAssociateId": 606,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "integrate sexy systems"
        },
        "FieldType": "System.String",
        "FieldLength": 74
      }
    }
  },
  "SearchTitle": "voluptatem",
  "MessageHeaders": [
    {
      "Name": "Emmerich Group",
      "Value": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    },
    {
      "Name": "Emmerich Group",
      "Value": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "quia"
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
      "FieldLength": 953
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```