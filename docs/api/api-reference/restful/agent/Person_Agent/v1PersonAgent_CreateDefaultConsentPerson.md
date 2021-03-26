---
title: POST Agents/Person/CreateDefaultConsentPerson
id: v1PersonAgent_CreateDefaultConsentPerson
---

# POST Agents/Person/CreateDefaultConsentPerson

```http
POST /api/v1/Agents/Person/CreateDefaultConsentPerson
```

Set default values into a new ConsentPerson.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Person/CreateDefaultConsentPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 628,
  "ConsentSource": {
    "ConsentSourceId": 565,
    "Name": "Ruecker, Trantow and Nolan",
    "Tooltip": "et",
    "Rank": 745,
    "Key": "quas",
    "MailTemplateId": 902,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 956
      }
    }
  },
  "LegalBase": {
    "LegalBaseId": 99,
    "Name": "Metz, Reichert and Renner",
    "Tooltip": "dolore",
    "Rank": 304,
    "Key": "nemo",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 868
      }
    }
  },
  "PersonId": 484,
  "ConsentPurpose": {
    "ConsentPurposeId": 734,
    "Name": "Mayert, Brakus and Johnston",
    "ConsentText": "corrupti",
    "FormText": "saepe",
    "Key": "aliquam",
    "Tooltip": "reprehenderit",
    "Active": 487,
    "UpdatedDate": "2009-12-25T16:48:30.034924+01:00",
    "UpdatedBy": {},
    "Deleted": true,
    "Rank": 263,
    "PrivacyStatementDesc": "reprehenderit",
    "PrivacyStatementUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize customized infrastructures"
        },
        "FieldType": "System.String",
        "FieldLength": 461
      }
    }
  },
  "Comment": "laboriosam",
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
      "FieldLength": 419
    }
  }
}
```