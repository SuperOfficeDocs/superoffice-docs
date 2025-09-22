---
title: POST Agents/Person/GetUtmParameters
uid: v1PersonAgent_GetUtmParameters
generated: true
content_type: reference
---

# POST Agents/Person/GetUtmParameters

```http
POST /api/v1/Agents/Person/GetUtmParameters
```

Get all UTM parameters for a given person.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetUtmParameters?$select=name,department,category/id
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
| PersonId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UtmParameters

| Property Name | Type |  Description |
|----------------|------|--------------|
| UtmParametersId | int32 | Primary key |
| CreatedContactId | int32 | Id of the created contact |
| CreatedPersonId | int32 | Id of the created person |
| FormSubmissionId | int32 | Id of the form submission |
| FirstTouchSource | string | First touch UTM source |
| FirstTouchMedium | string | First touch UTM medium |
| FirstTouchCampaign | string | First touch UTM campaign |
| FirstTouchTerm | string | First touch UTM term |
| FirstTouchContent | string | First touch UTM content |
| FirstTouchReferrerDomain | string | First touch UTM referrer domain |
| FirstTouchWhen | date-time | First touch date |
| Source | string | UTM source |
| Medium | string | UTM medium |
| Campaign | string | UTM campaign |
| Term | string | UTM term |
| Content | string | UTM content |
| ReferrerDomain | string | UTM referrer domain |
| When | date-time | Date of the visit or form submission |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Updated when  in UTC. |
| UpdatedAssociateId | int32 | Updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/GetUtmParameters
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 862
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UtmParametersId": 475,
  "CreatedContactId": 492,
  "CreatedPersonId": 971,
  "FormSubmissionId": 142,
  "FirstTouchSource": "quasi",
  "FirstTouchMedium": "impedit",
  "FirstTouchCampaign": "eos",
  "FirstTouchTerm": "dolorem",
  "FirstTouchContent": "nisi",
  "FirstTouchReferrerDomain": "illum",
  "FirstTouchWhen": "2023-03-22T11:24:48.3595217+01:00",
  "Source": "id",
  "Medium": "est",
  "Campaign": "nesciunt",
  "Term": "alias",
  "Content": "velit",
  "ReferrerDomain": "voluptas",
  "When": "2018-05-17T11:24:48.3595217+02:00",
  "Registered": "2020-12-21T11:24:48.3595217+01:00",
  "RegisteredAssociateId": 671,
  "Updated": "2005-09-08T11:24:48.3595217+02:00",
  "UpdatedAssociateId": 541,
  "UpdatedCount": 446,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 799
    }
  }
}
```