---
title: GET Person/{id}/UtmParameters
uid: v1PersonEntity_GetUtmParameters
generated: true
content_type: reference
---

# GET Person/{id}/UtmParameters

```http
GET /api/v1/Person/{personId}/UtmParameters
```

Get all UTM parameters for a given person.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to get UTM parameters for **Required** |



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
GET /api/v1/Person/{personId}/UtmParameters
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UtmParametersId": 900,
  "CreatedContactId": 539,
  "CreatedPersonId": 642,
  "FormSubmissionId": 152,
  "FirstTouchSource": "voluptatem",
  "FirstTouchMedium": "perspiciatis",
  "FirstTouchCampaign": "eos",
  "FirstTouchTerm": "beatae",
  "FirstTouchContent": "tenetur",
  "FirstTouchReferrerDomain": "temporibus",
  "FirstTouchWhen": "2021-10-16T03:40:55.9136545+02:00",
  "Source": "est",
  "Medium": "est",
  "Campaign": "aut",
  "Term": "fugiat",
  "Content": "aliquid",
  "ReferrerDomain": "aut",
  "When": "2016-05-20T03:40:55.9136545+02:00",
  "Registered": "2018-01-25T03:40:55.9136545+01:00",
  "RegisteredAssociateId": 339,
  "Updated": "2017-03-04T03:40:55.9136545+01:00",
  "UpdatedAssociateId": 284,
  "UpdatedCount": 88,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 936
    }
  }
}
```