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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 5478,
        "EntityName": "sale",
        "saleId": 5478,
        "contactId": 4075,
        "name": "Hills, Gutkowski and Considine"
      },
      "value2": {
        "PrimaryKey": 4356,
        "EntityName": "sale",
        "saleId": 4356,
        "contactId": 5901,
        "name": "Langosh, Dicki and Wunsch"
      }
    }
  },
  {
    "op": "add",
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 5478,
        "EntityName": "sale",
        "saleId": 5478,
        "contactId": 4075,
        "name": "Hills, Gutkowski and Considine"
      },
      "value2": {
        "PrimaryKey": 4356,
        "EntityName": "sale",
        "saleId": 4356,
        "contactId": 5901,
        "name": "Langosh, Dicki and Wunsch"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TicketMessageEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 298,
  "Ticket": {
    "TicketId": 421,
    "Title": "explicabo",
    "CreatedAt": "2011-11-12T18:25:51.2669395+01:00",
    "LastChanged": "2005-04-25T18:25:51.2669395+02:00",
    "ReadByOwner": "1995-01-13T18:25:51.2669395+01:00",
    "ReadByCustomer": "2002-05-29T18:25:51.2669395+02:00",
    "FirstReadByUser": "2016-06-25T18:25:51.2669395+02:00",
    "Activate": "2015-01-02T18:25:51.2669395+01:00",
    "ClosedAt": "2015-03-07T18:25:51.2669395+01:00",
    "RepliedAt": "2020-08-12T18:25:51.2669395+02:00",
    "AlertTimeout": "2003-10-25T18:25:51.2669395+02:00",
    "Deadline": "1996-12-01T18:25:51.2669395+01:00",
    "CreatedBy": 209,
    "CreatedByName": "Hills, Ferry and Stracke",
    "Author": "ab",
    "OwnedBy": 709,
    "OwnedByName": "Rau LLC",
    "Category": 101,
    "CategoryName": "VIP Customer",
    "CategoryFullname": "VIP Customer",
    "Slevel": "External",
    "Priority": 403,
    "PriorityName": "Bradtke Inc and Sons",
    "BaseStatus": "Active",
    "TicketStatus": 490,
    "TicketStatusDisplayValue": "nesciunt",
    "Origin": "AutoGenerated",
    "CustId": 491,
    "PersonFirstname": "Salvador",
    "PersonMiddleName": "Bernier Group",
    "PersonLastname": "Parker",
    "PersonFullname": "quibusdam",
    "AlertLevel": 70,
    "ConnectId": 24,
    "ReadStatus": "Green",
    "TimeToReply": 120,
    "RealTimeToReply": 331,
    "TimeToClose": 549,
    "RealTimeToClose": 230,
    "TimeSpentInternally": 128,
    "TimeSpentExternally": 858,
    "TimeSpentQueue": 210,
    "RealTimeSpentInternally": 411,
    "RealTimeSpentExternally": 591,
    "RealTimeSpentQueue": 189,
    "HasAttachment": false,
    "NumReplies": 579,
    "NumMessages": 269,
    "FromAddress": "culpa",
    "ContactId": 520,
    "ContactName": "Cremin Inc and Sons",
    "OwnedByAssociateId": 559,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 467
      }
    }
  },
  "CreatedAt": "2008-01-05T18:25:51.267911+01:00",
  "CreatedBy": {
    "AssociateId": 128,
    "Name": "O'Keefe, Hickle and Wilderman",
    "PersonId": 438,
    "Rank": 650,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 73,
    "FullName": "Sarai Wiza",
    "FormalName": "Goyette LLC",
    "Deleted": false,
    "EjUserId": 778,
    "UserName": "Graham, Sporer and Abshire",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate turn-key schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 258
      }
    }
  },
  "Author": "dicta",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "et",
  "TimeSpent": 554,
  "Body": "quidem",
  "HtmlBody": "eos",
  "EmailHeader": "easter@labadieswaniawski.com",
  "DebugInfo": "voluptatem",
  "MailSorter": "laudantium",
  "MessageCategory": "Bounce",
  "Person": {
    "Position": "atque",
    "PersonId": 222,
    "Mrmrs": "repellendus",
    "Firstname": "Floyd",
    "Lastname": "Douglas",
    "MiddleName": "Schiller Group",
    "Title": "qui",
    "Description": "Balanced zero defect knowledge base",
    "Email": "watson@rempel.name",
    "FullName": "Mr. Colton Macejkovic",
    "DirectPhone": "723.451.7155",
    "FormalName": "Raynor-Gorczany",
    "CountryId": 194,
    "ContactId": 845,
    "ContactName": "Williamson-Anderson",
    "Retired": 58,
    "Rank": 556,
    "ActiveInterests": 585,
    "ContactDepartment": "",
    "ContactCountryId": 311,
    "ContactOrgNr": "285605",
    "FaxPhone": "(412)330-6358",
    "MobilePhone": "(217)873-8526 x44500",
    "ContactPhone": "1-072-832-4568",
    "AssociateName": "Farrell LLC",
    "AssociateId": 1000,
    "UsePersonAddress": false,
    "ContactFax": "recusandae",
    "Kanafname": "et",
    "Kanalname": "numquam",
    "Post1": "cumque",
    "Post2": "nisi",
    "Post3": "hic",
    "EmailName": "adonis@okunevahilpert.us",
    "ContactFullName": "Meredith Nikolaus",
    "ActiveErpLinks": 306,
    "TicketPriorityId": 928,
    "SupportLanguageId": 524,
    "SupportAssociateId": 72,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "SearchTitle": "id",
  "MessageHeaders": [
    {
      "Name": "Gaylord Group",
      "Value": "similique",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    },
    {
      "Name": "Gaylord Group",
      "Value": "similique",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    }
  ],
  "Important": true,
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "quasi"
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
      "FieldLength": 217
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```