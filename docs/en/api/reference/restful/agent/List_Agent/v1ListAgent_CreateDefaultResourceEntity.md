---
title: POST Agents/List/CreateDefaultResourceEntity
uid: v1ListAgent_CreateDefaultResourceEntity
generated: true
---

# POST Agents/List/CreateDefaultResourceEntity

```http
POST /api/v1/Agents/List/CreateDefaultResourceEntity
```

Set default values into a new ResourceEntity.


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

### Response body: ResourceEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the resource is deleted. |
| IsLocation | bool | If true the resource is a location |
| LocationAddress | string | Address of location, if this is a resource that is a location |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/CreateDefaultResourceEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 229,
  "Name": "Williamson Inc and Sons",
  "Rank": 903,
  "Tooltip": "minus",
  "Deleted": true,
  "IsLocation": false,
  "LocationAddress": "omnis",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 760
    }
  }
}
```