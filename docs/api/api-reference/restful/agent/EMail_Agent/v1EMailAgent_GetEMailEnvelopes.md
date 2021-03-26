---
title: POST Agents/EMail/GetEMailEnvelopes
id: v1EMailAgent_GetEMailEnvelopes
---

# POST Agents/EMail/GetEMailEnvelopes

```http
POST /api/v1/Agents/EMail/GetEMailEnvelopes
```

Retrieve a set of e-mail envelopes



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailEnvelopes?$select=name,department,category/id
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

ConnectionInfo, MessageServerIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| MessageServerIds | array |  |


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
POST /api/v1/Agents/EMail/GetEMailEnvelopes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Cremin-Wilkinson",
    "UserName": "Kunze, Stracke and Durgan",
    "Password": "rerum",
    "Folder": "et",
    "UseSSL": false
  },
  "MessageServerIds": [
    581,
    90
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ServerId": 861,
    "MessageId": "a",
    "Subject": "doloremque",
    "From": {
      "ContactId": 793,
      "ContactName": "Christiansen-Goodwin",
      "PersonId": 132,
      "PersonName": "Stracke, Schaefer and White",
      "AssociateId": 692,
      "Address": "minus",
      "EmailId": 646,
      "DuplicatePersonIds": [
        846,
        585
      ],
      "Name": "Champlin Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 627
        }
      }
    },
    "To": [
      {
        "ContactId": 168,
        "ContactName": "Parisian-Schulist",
        "PersonId": 302,
        "PersonName": "Franecki-Howell",
        "AssociateId": 997,
        "Address": "ad",
        "EmailId": 272,
        "DuplicatePersonIds": [
          402,
          679
        ],
        "Name": "Greenfelder LLC",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 118
          }
        }
      }
    ],
    "Sent": "2015-06-01T16:48:29.6119307+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 82,
    "EMailSOInfo": {
      "DocumentId": 849,
      "AppointmentId": 468,
      "ProjectId": 913,
      "SaleId": 734,
      "Archived": true,
      "ArchivedAt": "2019-10-29T16:48:29.6119307+01:00",
      "ArchivedBy": 140,
      "ArchivedDisplayName": "Cummerata LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 656
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
        "FieldLength": 460
      }
    }
  }
]
```