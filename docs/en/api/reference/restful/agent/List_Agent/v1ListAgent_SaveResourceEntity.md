---
title: POST Agents/List/SaveResourceEntity
uid: v1ListAgent_SaveResourceEntity
generated: true
---

# POST Agents/List/SaveResourceEntity

```http
POST /api/v1/Agents/List/SaveResourceEntity
```

Updates the existing ResourceEntity or creates a new ResourceEntity if the id parameter is empty








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

## Request Body: entity 

The ResourceEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceId | Integer | Primary key |
| Name | String | Initials, also login name, possibly database user name |
| Rank | Integer | Rank order |
| Tooltip | String | Tooltip or other description |
| Deleted | Boolean | If true, the resource is deleted. |
| IsLocation | Boolean | If true the resource is a location |
| LocationAddress | String | Address of location, if this is a resource that is a location |

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
POST /api/v1/Agents/List/SaveResourceEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 830,
  "Name": "Langosh-Price",
  "Rank": 782,
  "Tooltip": "illum",
  "Deleted": true,
  "IsLocation": false,
  "LocationAddress": "quaerat"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 42,
  "Name": "Sipes, Pagac and West",
  "Rank": 802,
  "Tooltip": "consectetur",
  "Deleted": false,
  "IsLocation": true,
  "LocationAddress": "in",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 781
    }
  }
}
```