---
title: POST Agents/Targets/CreateDefaultTargetRevision
uid: v1TargetsAgent_CreateDefaultTargetRevision
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Targets/CreateDefaultTargetRevision
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "LogEvent": "Create",
  "Who": null,
  "When": "2014-03-16T14:19:04.2192297+01:00",
  "Changes": [
    {
      "FieldIdentifier": "nam",
      "ValueChangeFrom": 26836.442,
      "ValueChangeTo": 18208.54,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    },
    {
      "FieldIdentifier": "nam",
      "ValueChangeFrom": 26836.442,
      "ValueChangeTo": 18208.54,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 776
    }
  }
}
```