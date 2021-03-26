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
    915,
    909
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ServerId": 660,
    "MessageId": "voluptas",
    "Subject": "molestias",
    "From": {
      "ContactId": 743,
      "ContactName": "Schimmel Group",
      "PersonId": 126,
      "PersonName": "Bosco Group",
      "AssociateId": 797,
      "Address": "non",
      "EmailId": 36,
      "DuplicatePersonIds": [
        151,
        999
      ],
      "Name": "Huel, Dare and Buckridge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 824
        }
      }
    },
    "To": [
      {
        "ContactId": 826,
        "ContactName": "Ankunding-Beier",
        "PersonId": 608,
        "PersonName": "Schulist, Jewess and Harris",
        "AssociateId": 824,
        "Address": "facere",
        "EmailId": 96,
        "DuplicatePersonIds": [
          800,
          2
        ],
        "Name": "Baumbach-Barton",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 790
          }
        }
      }
    ],
    "Sent": "2013-04-30T16:48:29.5239239+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 747,
    "EMailSOInfo": {
      "DocumentId": 409,
      "AppointmentId": 560,
      "ProjectId": 484,
      "SaleId": 462,
      "Archived": true,
      "ArchivedAt": "2010-09-20T16:48:29.5239239+02:00",
      "ArchivedBy": 878,
      "ArchivedDisplayName": "Gerlach, Jenkins and Rogahn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 137
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
        "FieldLength": 905
      }
    }
  }
]
```