---
title: POST Agents/Archive/GetArchiveConfigurationWithContext
id: v1ArchiveAgent_GetArchiveConfigurationWithContext
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
| GuiName | string |  |
| ProviderName | string |  |
| Context | string |  |


## Response: object

This service is used to store and fetch the configuration of an archive. The configuration consists of entities and columns; entities correspond to archive provider entities and the checkboxes you see in the bottom of standard archives. Column configuration includes both what columns should be visible, what order they are in (left to right), and whether the archive rows should be sorted by one or more columns.&lt;para/&gt;Note that desired columns can be set through the selectable mdo list called archiveColumns:&amp;lt;perovider name&amp;gt;, and entities can be set through the selectable mdo list archiveEntities:&amp;lt;provider name&amp;gt;. You can also use the SetChosenEntities and SetChosenColumns method of this service. The selectable mdo list implementation is suitable for data binding using mdo list controls.



Carrier object for ArchiveConfiguration.
Services for the ArchiveConfiguration Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">Archive Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ArchiveColumnInfo | array |  |
| ArchiveEntityInfo | array |  |
| ArchiveOrderByInfo | array |  |
| OwnerKeys | string | The actual ownership information for the configuration that was retrieved |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/GetArchiveConfigurationWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Thompson Group",
  "ProviderName": "Bartoletti, Simonis and Fay",
  "Context": "accusantium"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Walsh LLC",
      "DisplayTooltip": "et",
      "DisplayType": "ut",
      "CanOrderBy": false,
      "Name": "Braun-Feest",
      "CanRestrictBy": true,
      "RestrictionType": "saepe",
      "RestrictionListName": "Schaden-Effertz",
      "IsVisible": false,
      "ExtraInfo": "et",
      "Width": "quaerat",
      "IconHint": "quia",
      "HeadingIconHint": "quis"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 393,
      "Name": "Buckridge-Mueller",
      "ToolTip": "Eos nihil quod ea.",
      "Deleted": false,
      "Rank": 143,
      "Type": "doloremque",
      "ColorBlock": 799,
      "IconHint": "provident",
      "Selected": true,
      "LastChanged": "2020-07-10T18:28:48.0948495+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quidem",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Catherine Hickle",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "Funk-Pfeffer",
      "Direction": "ASC"
    },
    {
      "Name": "Funk-Pfeffer",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "voluptate",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 41
    }
  }
}
```