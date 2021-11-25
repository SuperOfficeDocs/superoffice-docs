---
title: POST Agents/Person/SaveConsentPerson
id: v1PersonAgent_SaveConsentPerson
---

# POST Agents/Person/SaveConsentPerson

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
  "ConsentPersonId": 849,
  "ConsentSource": {
    "ConsentSourceId": 25,
    "Name": "Kihn-McKenzie",
    "Tooltip": "nemo",
    "Rank": 794,
    "Key": "nam",
    "MailTemplateId": 678,
    "Deleted": true
  },
  "LegalBase": {
    "LegalBaseId": 579,
    "Name": "Langworth LLC",
    "Tooltip": "illo",
    "Rank": 252,
    "Key": "quod",
    "Deleted": false
  },
  "PersonId": 376,
  "ConsentPurpose": {
    "ConsentPurposeId": 932,
    "Name": "Walter, Huel and Hansen",
    "ConsentText": "ut",
    "FormText": "quis",
    "Key": "et",
    "Tooltip": "expedita",
    "Active": 934,
    "UpdatedDate": "2017-04-05T18:28:49.5300874+02:00",
    "UpdatedBy": {},
    "Deleted": false,
    "Rank": 726,
    "PrivacyStatementDesc": "aut",
    "PrivacyStatementUrl": "http://www.example.com/"
  },
  "Comment": "accusamus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 721,
  "ConsentSource": {
    "ConsentSourceId": 440,
    "Name": "Medhurst Group",
    "Tooltip": "perspiciatis",
    "Rank": 982,
    "Key": "tempora",
    "MailTemplateId": 494,
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 851
      }
    }
  },
  "LegalBase": {
    "LegalBaseId": 236,
    "Name": "Bahringer Inc and Sons",
    "Tooltip": "fugit",
    "Rank": 125,
    "Key": "sed",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 142
      }
    }
  },
  "PersonId": 191,
  "ConsentPurpose": {
    "ConsentPurposeId": 394,
    "Name": "Torp, Herman and Hoeger",
    "ConsentText": "officiis",
    "FormText": "in",
    "Key": "ut",
    "Tooltip": "qui",
    "Active": 98,
    "UpdatedDate": "2011-12-05T18:28:49.5310874+01:00",
    "UpdatedBy": {},
    "Deleted": false,
    "Rank": 271,
    "PrivacyStatementDesc": "fuga",
    "PrivacyStatementUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 709
      }
    }
  },
  "Comment": "id",
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
      "FieldLength": 786
    }
  }
}
```