---
title: POST Agents/Person/SaveConsentPerson
uid: v1PersonAgent_SaveConsentPerson
generated: true
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
| ConsentPersonId | Integer | ConsentPerson ID |
| ConsentSource | ConsentSource | The consent source |
| LegalBase | LegalBase | The legal base |
| PersonId | Integer | Person ID |
| ConsentPurpose | ConsentPurpose | The consent purpose |
| Comment | String | Comment regarding this specific consent |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ConsentPerson

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | ConsentPerson ID |
| ConsentSource | ConsentSource | The consent source |
| LegalBase | LegalBase | The legal base |
| PersonId | int32 | Person ID |
| ConsentPurpose | ConsentPurpose | The consent purpose |
| Comment | string | Comment regarding this specific consent |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SaveConsentPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 105,
  "ConsentSource": null,
  "LegalBase": null,
  "PersonId": 196,
  "ConsentPurpose": null,
  "Comment": "qui"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 534,
  "ConsentSource": null,
  "LegalBase": null,
  "PersonId": 90,
  "ConsentPurpose": null,
  "Comment": "nihil",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 520
    }
  }
}
```