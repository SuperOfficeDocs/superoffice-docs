---
title: GetConsentPerson
id: v1PersonAgent_GetConsentPerson
---

# GetConsentPerson

```http
POST /api/v1/Agents/Person/GetConsentPerson
```

Gets a ConsentPerson object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| consentPersonId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetConsentPerson?consentPersonId=467
POST /api/v1/Agents/Person/GetConsentPerson?$select=name,department,category/id
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

Carrier object for ConsentPerson.
Services for the ConsentPerson Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | ConsentPerson ID |
| ConsentSource |  | The consent source |
| LegalBase |  | The legal base |
| PersonId | int32 | Person ID |
| ConsentPurpose |  | The consent purpose |
| Comment | string | Comment regarding this specific consent |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetConsentPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 600,
  "ConsentSource": {
    "ConsentSourceId": 235,
    "Name": "Goyette-Dach",
    "Tooltip": "pariatur",
    "Rank": 143,
    "Key": "qui",
    "MailTemplateId": 142,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 585
      }
    }
  },
  "LegalBase": {
    "LegalBaseId": 965,
    "Name": "Medhurst, Ledner and Turner",
    "Tooltip": "minima",
    "Rank": 744,
    "Key": "consectetur",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 758
      }
    }
  },
  "PersonId": 369,
  "ConsentPurpose": {
    "ConsentPurposeId": 450,
    "Name": "Conroy-White",
    "ConsentText": "dicta",
    "FormText": "soluta",
    "Key": "omnis",
    "Tooltip": "ut",
    "Active": 690,
    "UpdatedDate": "1999-08-25T14:58:04.6134598+02:00",
    "UpdatedBy": {},
    "Deleted": false,
    "Rank": 309,
    "PrivacyStatementDesc": "eveniet",
    "PrivacyStatementUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 50
      }
    }
  },
  "Comment": "sequi",
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
      "FieldLength": 12
    }
  }
}
```