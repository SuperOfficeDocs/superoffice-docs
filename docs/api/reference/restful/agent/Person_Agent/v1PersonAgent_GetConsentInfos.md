---
title: POST Agents/Person/GetConsentInfos
uid: v1PersonAgent_GetConsentInfos
---

# POST Agents/Person/GetConsentInfos

```http
POST /api/v1/Agents/Person/GetConsentInfos
```

Get all consent information for a given person.

May include withdrawn consents (check

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetConsentInfos?$select=name,department,category/id
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

PersonId

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/GetConsentInfos
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 342
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConsentPersonId": 128,
    "Comment": "a",
    "Registered": "2016-02-17T11:10:27.4824584+01:00",
    "RegisteredAssociateId": 147,
    "Updated": "2006-09-23T11:10:27.4824584+02:00",
    "UpdatedAssociateId": 197,
    "LegalBaseId": 729,
    "LegalBaseKey": "sit",
    "LegalBaseName": "Bogisich-Schuppe",
    "ConsentPurposeId": 52,
    "ConsentPurposeKey": "molestiae",
    "ConsentPurposeName": "Hudson, Stiedemann and Halvorson",
    "ConsentSourceId": 195,
    "ConsentSourceKey": "quos",
    "ConsentSourceName": "Deckow-Kemmer",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 479
      }
    }
  }
]
```
