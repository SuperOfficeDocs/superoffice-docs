---
title: SaveConsentPerson
id: v1PersonAgent_SaveConsentPerson
---

# SaveConsentPerson

```http
POST /api/v1/Agents/Person/SaveConsentPerson
```

Updates the existing ConsentPerson or creates a new ConsentPerson if the id parameter is empty








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

## Request Body: entity  

The ConsentPerson to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | ConsentPerson ID |
| ConsentSource |  | The consent source |
| LegalBase |  | The legal base |
| PersonId | int32 | Person ID |
| ConsentPurpose |  | The consent purpose |
| Comment | string | Comment regarding this specific consent |


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
POST /api/v1/Agents/Person/SaveConsentPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 905,
  "ConsentSource": {
    "ConsentSourceId": 890,
    "Name": "Frami LLC",
    "Tooltip": "optio",
    "Rank": 330,
    "Key": "quaerat",
    "MailTemplateId": 793,
    "Deleted": false
  },
  "LegalBase": {
    "LegalBaseId": 749,
    "Name": "O'Keefe-Hills",
    "Tooltip": "architecto",
    "Rank": 441,
    "Key": "ea",
    "Deleted": true
  },
  "PersonId": 534,
  "ConsentPurpose": {
    "ConsentPurposeId": 126,
    "Name": "Beahan, Johns and Buckridge",
    "ConsentText": "est",
    "FormText": "consectetur",
    "Key": "ut",
    "Tooltip": "animi",
    "Active": 251,
    "UpdatedDate": "2021-03-16T14:58:04.6514607+01:00",
    "UpdatedBy": {},
    "Deleted": true,
    "Rank": 863,
    "PrivacyStatementDesc": "iure",
    "PrivacyStatementUrl": "http://www.example.com/"
  },
  "Comment": "qui"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 875,
  "ConsentSource": {
    "ConsentSourceId": 111,
    "Name": "Reichert Inc and Sons",
    "Tooltip": "eius",
    "Rank": 277,
    "Key": "deleniti",
    "MailTemplateId": 90,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 181
      }
    }
  },
  "LegalBase": {
    "LegalBaseId": 669,
    "Name": "Harris, Schowalter and Tremblay",
    "Tooltip": "corrupti",
    "Rank": 112,
    "Key": "perferendis",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 838
      }
    }
  },
  "PersonId": 815,
  "ConsentPurpose": {
    "ConsentPurposeId": 650,
    "Name": "Konopelski LLC",
    "ConsentText": "repudiandae",
    "FormText": "sit",
    "Key": "hic",
    "Tooltip": "et",
    "Active": 381,
    "UpdatedDate": "2002-08-15T14:58:04.6524598+02:00",
    "UpdatedBy": {},
    "Deleted": false,
    "Rank": 135,
    "PrivacyStatementDesc": "deserunt",
    "PrivacyStatementUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 897
      }
    }
  },
  "Comment": "eos",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "embrace dot-com e-tailers"
      },
      "FieldType": "System.Int32",
      "FieldLength": 645
    }
  }
}
```