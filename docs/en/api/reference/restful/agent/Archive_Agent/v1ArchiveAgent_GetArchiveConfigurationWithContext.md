---
title: POST Agents/Archive/GetArchiveConfigurationWithContext
uid: v1ArchiveAgent_GetArchiveConfigurationWithContext
generated: true
---

# POST Agents/Archive/GetArchiveConfigurationWithContext

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationWithContext
```

Get the configuration for one archive, with context parameter.


The configuration is keyed by a combination of archive provider name and gui name. The archive provider name must match an archive provider plugin; the gui name is an arbitrary string used to distinguish multiple occurrences of the same underlying provider in a gui.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveConfigurationWithContext?$select=name,department,category/id
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

GuiName, ProviderName, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | String |  |
| ProviderName | String |  |
| Context | String |  |

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
POST /api/v1/Agents/Archive/GetArchiveConfigurationWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Gislason LLC",
  "ProviderName": "Jones Inc and Sons",
  "Context": "libero"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Kunze Group",
      "DisplayTooltip": "nostrum",
      "DisplayType": "placeat",
      "CanOrderBy": true,
      "Name": "Pollich-Kris",
      "CanRestrictBy": false,
      "RestrictionType": "similique",
      "RestrictionListName": "Gorczany Group",
      "IsVisible": false,
      "ExtraInfo": "ipsam",
      "Width": "consequatur",
      "IconHint": "et",
      "HeadingIconHint": "sit"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 705,
      "Name": "Kilback, Johnson and Marvin",
      "ToolTip": "Sit error omnis nostrum expedita sed id.",
      "Deleted": false,
      "Rank": 26,
      "Type": "dolor",
      "ColorBlock": 911,
      "IconHint": "mollitia",
      "Selected": false,
      "LastChanged": "2021-04-05T13:13:59.5001938+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Dr. Gaetano Ole Orn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Mann, Cole and Nicolas",
      "Direction": "ASC"
    },
    {
      "Name": "Mann, Cole and Nicolas",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "corporis",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 965
    }
  }
}
```