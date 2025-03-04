---
title: POST Agents/Targets/CreateDefaultTargetRevision
uid: v1TargetsAgent_CreateDefaultTargetRevision
generated: true
---

# POST Agents/Targets/CreateDefaultTargetRevision

```http
POST /api/v1/Agents/Targets/CreateDefaultTargetRevision
```

Set default values into a new TargetRevision.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

### Response body: TargetRevision

| Property Name | Type |  Description |
|----------------|------|--------------|
| LogEvent | string | Log event class (create, edit, delete, lock, unlock... |
| Who | Associate | Who made the change |
| When | date-time | Registered when  in UTC. |
| Changes | array | Collection of changes |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Targets/CreateDefaultTargetRevision
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LogEvent": "Create",
  "Who": null,
  "When": "2006-07-03T14:13:41.3445898+02:00",
  "Changes": [
    {
      "FieldIdentifier": "nemo",
      "ValueChangeFrom": 9743.606,
      "ValueChangeTo": 24166.273999999998,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    },
    {
      "FieldIdentifier": "nemo",
      "ValueChangeFrom": 9743.606,
      "ValueChangeTo": 24166.273999999998,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 398
    }
  }
}
```