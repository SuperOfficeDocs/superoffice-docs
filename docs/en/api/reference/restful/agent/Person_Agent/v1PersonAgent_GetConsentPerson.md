---
title: POST Agents/Person/GetConsentPerson
uid: v1PersonAgent_GetConsentPerson
generated: true
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
POST /api/v1/Agents/Person/GetConsentPerson?consentPersonId=767
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
POST /api/v1/Agents/Person/GetConsentPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ConsentPersonId": 831,
  "ConsentSource": null,
  "LegalBase": null,
  "PersonId": 626,
  "ConsentPurpose": null,
  "Comment": "voluptatem",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 124
    }
  }
}
```