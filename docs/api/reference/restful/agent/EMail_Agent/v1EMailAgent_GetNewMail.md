---
title: POST Agents/EMail/GetNewMail
id: v1EMailAgent_GetNewMail
---

# POST Agents/EMail/GetNewMail

```http
POST /api/v1/Agents/EMail/GetNewMail
```

Get new email in folder(s) for current associate



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetNewMail?$select=name,department,category/id
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

## Request Body: request  

Folders 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Folders | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServerId | int32 | Unique id for the e-mail on the server |
| MessageId | string | Unique id of e-mails |
| Subject | string | Subject of the e-mail |
| From |  | Who did the e-mail originate from |
| To | array | To recipients of e-mail |
| Sent | date-time | When was the e-mail sent |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| Size | int32 | Total size of the e-mail |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetNewMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Folders": [
    728,
    562
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ServerId": 999,
    "MessageId": "reprehenderit",
    "Subject": "adipisci",
    "From": {
      "ContactId": 121,
      "ContactName": "Schowalter-Cassin",
      "PersonId": 2,
      "PersonName": "Barrows LLC",
      "AssociateId": 719,
      "Address": "autem",
      "EmailId": 245,
      "DuplicatePersonIds": [
        557,
        825
      ],
      "Name": "Metz Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    },
    "To": [
      {
        "ContactId": 810,
        "ContactName": "White Group",
        "PersonId": 412,
        "PersonName": "Dickinson Inc and Sons",
        "AssociateId": 262,
        "Address": "blanditiis",
        "EmailId": 411,
        "DuplicatePersonIds": [
          938,
          791
        ],
        "Name": "Towne Inc and Sons",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 701
          }
        }
      }
    ],
    "Sent": "1997-01-28T18:28:48.9819509+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 218,
    "EMailSOInfo": {
      "DocumentId": 222,
      "AppointmentId": 920,
      "ProjectId": 419,
      "SaleId": 814,
      "Archived": false,
      "ArchivedAt": "2015-11-30T18:28:48.9819509+01:00",
      "ArchivedBy": 506,
      "ArchivedDisplayName": "Bernhard, Hagenes and Hudson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 929
        }
      }
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
        "FieldLength": 835
      }
    }
  }
]
```