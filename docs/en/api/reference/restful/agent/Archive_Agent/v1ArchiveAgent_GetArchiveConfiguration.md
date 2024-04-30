---
title: POST Agents/Archive/GetArchiveConfiguration
uid: v1ArchiveAgent_GetArchiveConfiguration
generated: true
---

# POST Agents/Archive/GetArchiveConfiguration

```http
POST /api/v1/Agents/Archive/GetArchiveConfiguration
```

Get the configuration for one archive.


The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveConfiguration?$select=name,department,category/id
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

GuiName, ProviderName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | String |  |
| ProviderName | String |  |

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
POST /api/v1/Agents/Archive/GetArchiveConfiguration
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Crist, O'Reilly and Harvey",
  "ProviderName": "Lesch, Donnelly and Balistreri"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Huels-Rowe",
      "DisplayTooltip": "a",
      "DisplayType": "incidunt",
      "CanOrderBy": false,
      "Name": "Schneider, Corkery and Ebert",
      "CanRestrictBy": true,
      "RestrictionType": "necessitatibus",
      "RestrictionListName": "Parker-Reichert",
      "IsVisible": false,
      "ExtraInfo": "eius",
      "Width": "perferendis",
      "IconHint": "id",
      "HeadingIconHint": "ipsa"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 508,
      "Name": "Wiza, Thiel and Kuhn",
      "ToolTip": "Quis eos fugiat incidunt id.",
      "Deleted": true,
      "Rank": 653,
      "Type": "voluptatem",
      "ColorBlock": 768,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2001-11-09T11:44:32.7755279+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "aspernatur",
      "Hidden": true,
      "FullName": "Mr. Travon Santos Konopelski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Bode LLC",
      "Direction": "ASC"
    },
    {
      "Name": "Bode LLC",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "sit",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 307
    }
  }
}
```