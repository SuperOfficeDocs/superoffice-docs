---
title: GetConsentInfos
id: v1PersonAgent_GetConsentInfos
---

# GetConsentInfos

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

## Sample Request

```http!
POST /api/v1/Agents/Person/GetConsentInfos
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 684
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ConsentPersonId": 235,
    "Comment": "vero",
    "Registered": "1996-01-28T14:58:04.8124601+01:00",
    "RegisteredAssociateId": 783,
    "Updated": "2019-08-02T14:58:04.8124601+02:00",
    "UpdatedAssociateId": 1000,
    "LegalBaseId": 44,
    "LegalBaseKey": "mollitia",
    "LegalBaseName": "Hodkiewicz, Koss and Ferry",
    "ConsentPurposeId": 754,
    "ConsentPurposeKey": "esse",
    "ConsentPurposeName": "Lubowitz-Rolfson",
    "ConsentSourceId": 515,
    "ConsentSourceKey": "molestias",
    "ConsentSourceName": "Erdman LLC",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "disintermediate turn-key applications"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 737
      }
    }
  }
]
```