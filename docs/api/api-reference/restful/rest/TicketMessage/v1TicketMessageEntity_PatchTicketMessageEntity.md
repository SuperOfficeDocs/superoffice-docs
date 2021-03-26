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
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 1483,
        "EntityName": "sale",
        "saleId": 1483,
        "contactId": 5799,
        "name": "Leffler-Koepp"
      },
      "value2": {
        "PrimaryKey": 996,
        "EntityName": "sale",
        "saleId": 996,
        "contactId": 3393,
        "name": "Morissette-Frami"
      }
    }
  },
  {
    "op": "add",
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 1483,
        "EntityName": "sale",
        "saleId": 1483,
        "contactId": 5799,
        "name": "Leffler-Koepp"
      },
      "value2": {
        "PrimaryKey": 996,
        "EntityName": "sale",
        "saleId": 996,
        "contactId": 3393,
        "name": "Morissette-Frami"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketMessageEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 286,
  "Ticket": {
    "TicketId": 135,
    "Title": "beatae",
    "CreatedAt": "2019-05-25T09:40:59.8940642+02:00",
    "LastChanged": "2014-02-15T09:40:59.8940642+01:00",
    "ReadByOwner": "2014-10-16T09:40:59.8940642+02:00",
    "ReadByCustomer": "1994-12-20T09:40:59.8940642+01:00",
    "FirstReadByUser": "2003-08-12T09:40:59.8940642+02:00",
    "Activate": "2002-07-23T09:40:59.8940642+02:00",
    "ClosedAt": "2017-02-25T09:40:59.8940642+01:00",
    "RepliedAt": "2012-11-21T09:40:59.8940642+01:00",
    "AlertTimeout": "1996-08-26T09:40:59.8940642+02:00",
    "Deadline": "2014-02-13T09:40:59.8940642+01:00",
    "CreatedBy": 449,
    "CreatedByName": "Cartwright-Ruecker",
    "Author": "esse",
    "OwnedBy": 226,
    "OwnedByName": "Fay-Anderson",
    "Category": 560,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 675,
    "BaseStatus": "Active",
    "TicketStatus": 136,
    "Origin": "AutoGenerated",
    "CustId": 743,
    "CustFirstname": "Kasey",
    "CustMiddleName": "Schuppe, Waters and Padberg",
    "CustLastname": "Shanahan",
    "AlertLevel": 281,
    "ConnectId": 872,
    "ReadStatus": "Green",
    "TimeToReply": 669,
    "RealTimeToReply": 78,
    "TimeToClose": 230,
    "RealTimeToClose": 256,
    "TimeSpentInternally": 80,
    "TimeSpentExternally": 151,
    "TimeSpentQueue": 801,
    "RealTimeSpentInternally": 713,
    "RealTimeSpentExternally": 614,
    "RealTimeSpentQueue": 319,
    "HasAttachment": true,
    "NumReplies": 61,
    "NumMessages": 185,
    "FromAddress": "et",
    "CustFullname": "ut",
    "TicketStatusDisplayValue": "occaecati",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 826
      }
    }
  },
  "CreatedAt": "2000-07-06T09:40:59.8940642+02:00",
  "CreatedBy": {
    "AssociateId": 942,
    "Name": "Hickle-Block",
    "PersonId": 331,
    "Rank": 772,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 783,
    "FullName": "Cale Hyatt",
    "FormalName": "Watsica, Jast and Bruen",
    "Deleted": false,
    "EjUserId": 870,
    "UserName": "Kutch, Parker and Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 775
      }
    }
  },
  "Author": "possimus",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "magnam",
  "TimeSpent": 473,
  "Body": "voluptatum",
  "HtmlBody": "quisquam",
  "EmailHeader": "ronny@lindcummings.uk",
  "DebugInfo": "et",
  "MailSorter": "molestiae",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "ipsa",
    "PersonId": 626,
    "Mrmrs": "consequatur",
    "Firstname": "Denis",
    "Lastname": "Gerhold",
    "MiddleName": "Turcotte Inc and Sons",
    "Title": "repellat",
    "Description": "Mandatory assymetric circuit",
    "Email": "robyn@walsh.biz",
    "FullName": "Korey Balistreri",
    "DirectPhone": "(848)630-7656",
    "FormalName": "Balistreri, Frami and Emmerich",
    "CountryId": 58,
    "ContactId": 241,
    "ContactName": "Okuneva, Hane and Sporer",
    "Retired": 126,
    "Rank": 458,
    "ActiveInterests": 992,
    "ContactDepartment": "",
    "ContactCountryId": 892,
    "ContactOrgNr": "1094077",
    "FaxPhone": "(145)076-2621",
    "MobilePhone": "(016)345-7565 x1662",
    "ContactPhone": "144.875.6551",
    "AssociateName": "Rath Inc and Sons",
    "AssociateId": 495,
    "UsePersonAddress": false,
    "ContactFax": "delectus",
    "Kanafname": "sapiente",
    "Kanalname": "optio",
    "Post1": "voluptatem",
    "Post2": "ex",
    "Post3": "aut",
    "EmailName": "maegan_rippin@schamberger.info",
    "ContactFullName": "Elyse Haley Sr.",
    "ActiveErpLinks": 370,
    "TicketPriorityId": 568,
    "SupportLanguageId": 87,
    "SupportAssociateId": 275,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 158
      }
    }
  },
  "SearchTitle": "nostrum",
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
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
      "FieldLength": 711
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```