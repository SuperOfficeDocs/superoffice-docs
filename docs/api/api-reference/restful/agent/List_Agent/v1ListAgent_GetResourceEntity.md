---
title: POST Agents/List/GetResourceEntity
id: v1ListAgent_GetResourceEntity
---

# POST Agents/List/GetResourceEntity

```http
POST /api/v1/Agents/List/GetResourceEntity
```

Gets a ResourceEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| resourceEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetResourceEntity?resourceEntityId=866
POST /api/v1/Agents/List/GetResourceEntity?$select=name,department,category/id
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


## Response: object

The resource entity contains resource information



Carrier object for ResourceEntity.
Services for the ResourceEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ResourceId | int32 | Primary key |
| Name | string | Initials, also login name, possibly database user name |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the resource is deleted. |
| IsLocation | bool | If true the resource is a location |
| LocationAddress | string | Address of location, if this is a resource that is a location |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/GetResourceEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ResourceId": 432,
  "Name": "Marks-Christiansen",
  "Rank": 154,
  "Tooltip": "veniam",
  "Deleted": false,
  "IsLocation": false,
  "LocationAddress": "libero",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "monetize B2C markets"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 345
    }
  }
}
```