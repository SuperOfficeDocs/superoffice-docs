---
title: GET Person/{id}/Consent
uid: v1PersonEntity_GetConsentInfos
generated: true
---

# GET Person/{id}/Consent

```http
GET /api/v1/Person/{personId}/Consent
```

Get all consent information for a given person.


May include withdrawn consents (check





| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to get consents for **Required** |



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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConsentPersonId | int32 | Primary key |
| Comment | string | Comment regarding this specific consent |
| Registered | date-time | When this consent record was created  in UTC. |
| RegisteredAssociateId | int32 | The ID of the associate who created this record |
| Updated | date-time | When this consent record was last updated  in UTC. |
| UpdatedAssociateId | int32 | The ID of the associate who last updated this record |
| LegalBaseId | int32 | Primary key for the LegalBase associated with this consent |
| LegalBaseKey | string | Key for the LegalBase associated with this consent |
| LegalBaseName | string | Name of the LegalBase associated with this consent |
| ConsentPurposeId | int32 | Primary key for the ConsentPurpose associated with this consent |
| ConsentPurposeKey | string | Key of the ConsentPurpose associated with this consent |
| ConsentPurposeName | string | Name of the ConsentPurpose associated with this consent |
| ConsentSourceId | int32 | Primary key for the ConsentSource associated with this consent |
| ConsentSourceKey | string | Key of the ConsentSource associated with this consent |
| ConsentSourceName | string | Name of the ConsentSource associated with this consent |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Person/{personId}/Consent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConsentPersonId": 688,
    "Comment": "recusandae",
    "Registered": "2000-05-10T13:38:17.5149376+02:00",
    "RegisteredAssociateId": 853,
    "Updated": "2014-02-14T13:38:17.5149376+01:00",
    "UpdatedAssociateId": 808,
    "LegalBaseId": 364,
    "LegalBaseKey": "eius",
    "LegalBaseName": "Goodwin, Borer and Grady",
    "ConsentPurposeId": 978,
    "ConsentPurposeKey": "voluptatem",
    "ConsentPurposeName": "Mayert LLC",
    "ConsentSourceId": 767,
    "ConsentSourceKey": "ea",
    "ConsentSourceName": "Nienow, Jakubowski and Oberbrunner",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 956
      }
    }
  }
]
```