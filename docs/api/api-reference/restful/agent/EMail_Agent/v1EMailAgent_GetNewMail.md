---
title: GetNewMail
id: v1EMailAgent_GetNewMail
---

# GetNewMail

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Folders": [
    897,
    733
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ServerId": 411,
    "MessageId": "ex",
    "Subject": "suscipit",
    "From": {
      "ContactId": 984,
      "ContactName": "Schuppe, Schiller and Reichert",
      "PersonId": 446,
      "PersonName": "Breitenberg-Bergstrom",
      "AssociateId": 124,
      "Address": "asperiores",
      "EmailId": 421,
      "DuplicatePersonIds": [
        952,
        905
      ],
      "Name": "Trantow, Kiehn and King",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    "To": [
      {
        "ContactId": 239,
        "ContactName": "Wunsch-O'Reilly",
        "PersonId": 238,
        "PersonName": "Cassin, Boehm and Rath",
        "AssociateId": 797,
        "Address": "qui",
        "EmailId": 535,
        "DuplicatePersonIds": [
          968,
          306
        ],
        "Name": "Jerde, Hyatt and Lockman",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 549
          }
        }
      }
    ],
    "Sent": "2008-05-16T14:58:04.0694658+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 824,
    "EMailSOInfo": {
      "DocumentId": 517,
      "AppointmentId": 993,
      "ProjectId": 906,
      "SaleId": 955,
      "Archived": false,
      "ArchivedAt": "2004-11-29T14:58:04.0694658+01:00",
      "ArchivedBy": 468,
      "ArchivedDisplayName": "Funk-Robel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 942
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
        "FieldType": "System.String",
        "FieldLength": 371
      }
    }
  }
]
```