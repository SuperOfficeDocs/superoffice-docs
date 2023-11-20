---
title: POST Agents/Audience/GetMyConfigParameters
uid: v1AudienceAgent_GetMyConfigParameters
generated: true
---

# POST Agents/Audience/GetMyConfigParameters

```http
POST /api/v1/Agents/Audience/GetMyConfigParameters
```

Gets the Audience configuration parameters belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetMyConfigParameters?$select=name,department,category/id
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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The id of the Audience layout this configuration setting belongs to |
| Name | string | The name of the configuration parameter |
| Value | string | The value of the configuration parameter |
| CreatedDate | date-time | The date and time the configuration parameter was created  in UTC. |
| UpdatedDate | date-time | The date and time the configuration parameter was last updated  in UTC. |
| CreatedBy | string | Name of the person that created the configuration parameter |
| UpdatedBy | string | Name of the person that last updated the configuration parameter |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Audience/GetMyConfigParameters
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
    "AudienceLayoutId": 622,
    "Name": "Roob Inc and Sons",
    "Value": "ut",
    "CreatedDate": "2016-07-06T13:38:13.0771703+02:00",
    "UpdatedDate": "2020-02-19T13:38:13.0771703+01:00",
    "CreatedBy": "ut",
    "UpdatedBy": "nihil",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 638
      }
    }
  }
]
```