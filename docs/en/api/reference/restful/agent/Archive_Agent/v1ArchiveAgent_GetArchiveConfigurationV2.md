---
title: POST Agents/Archive/GetArchiveConfigurationV2
uid: v1ArchiveAgent_GetArchiveConfigurationV2
generated: true
---

# POST Agents/Archive/GetArchiveConfigurationV2

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2
```

Get the configuration for one archive.


The configuration is keyed by a combination of archive provider name (plus optional context), gui name, and optional table binding. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2?$select=name,department,category/id
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

GuiName, ProviderName, Context, OwnerKeys 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | String |  |
| ProviderName | String |  |
| Context | String |  |
| OwnerKeys | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ArchiveConfiguration

| Property Name | Type |  Description |
|----------------|------|--------------|
| ArchiveColumnInfo | array |  |
| ArchiveEntityInfo | array |  |
| ArchiveOrderByInfo | array |  |
| OwnerKeys | string | The actual ownership information for the configuration that was retrieved |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetArchiveConfigurationV2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Monahan, Feeney and Grady",
  "ProviderName": "Blanda, Gleason and Mitchell",
  "Context": "aliquid",
  "OwnerKeys": "dignissimos"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Hane-Daugherty",
      "DisplayTooltip": "sint",
      "DisplayType": "voluptatum",
      "CanOrderBy": false,
      "Name": "Shields-Smith",
      "CanRestrictBy": true,
      "RestrictionType": "id",
      "RestrictionListName": "Harber, Hermiston and Ondricka",
      "IsVisible": false,
      "ExtraInfo": "eius",
      "Width": "praesentium",
      "IconHint": "illo",
      "HeadingIconHint": "consequatur"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 683,
      "Name": "Lakin-Lehner",
      "ToolTip": "Quo mollitia sunt.",
      "Deleted": false,
      "Rank": 62,
      "Type": "sapiente",
      "ColorBlock": 848,
      "IconHint": "pariatur",
      "Selected": false,
      "LastChanged": "2020-06-06T11:16:08.7097813+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Ms. Billie Daniel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 826
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Daniel Inc and Sons",
      "Direction": "ASC"
    },
    {
      "Name": "Daniel Inc and Sons",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "in",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 590
    }
  }
}
```