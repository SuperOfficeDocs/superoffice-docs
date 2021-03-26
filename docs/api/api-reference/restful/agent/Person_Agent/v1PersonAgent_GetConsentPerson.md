---
title: POST Agents/Person/GetConsentPerson
id: v1PersonAgent_GetConsentPerson
---

# POST Agents/Person/GetConsentPerson

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
POST /api/v1/Agents/Person/GetConsentPerson?consentPersonId=635
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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 859,
  "ConsentSource": {
    "ConsentSourceId": 23,
    "Name": "Wehner LLC",
    "Tooltip": "cum",
    "Rank": 426,
    "Key": "aut",
    "MailTemplateId": 529,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 796
      }
    }
  },
  "LegalBase": {
    "LegalBaseId": 448,
    "Name": "Bartoletti-Fay",
    "Tooltip": "et",
    "Rank": 870,
    "Key": "molestiae",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 542
      }
    }
  },
  "PersonId": 448,
  "ConsentPurpose": {
    "ConsentPurposeId": 861,
    "Name": "Strosin-Brown",
    "ConsentText": "pariatur",
    "FormText": "iusto",
    "Key": "vero",
    "Tooltip": "nihil",
    "Active": 623,
    "UpdatedDate": "2002-07-17T16:48:29.995925+02:00",
    "UpdatedBy": {},
    "Deleted": false,
    "Rank": 970,
    "PrivacyStatementDesc": "dolorum",
    "PrivacyStatementUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 441
      }
    }
  },
  "Comment": "nobis",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "enable sexy mindshare"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 767
    }
  }
}
```