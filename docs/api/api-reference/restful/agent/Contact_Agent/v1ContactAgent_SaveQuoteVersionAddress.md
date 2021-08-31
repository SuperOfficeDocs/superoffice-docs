---
title: SaveQuoteVersionAddress
id: v1ContactAgent_SaveQuoteVersionAddress
---

# SaveQuoteVersionAddress

```http
POST /api/v1/Agents/Contact/SaveQuoteVersionAddress
```

Save a custom quote version address.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/SaveQuoteVersionAddress?$select=name,department,category/id
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

QuoteVersionId, Address, AddressType, CountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| AddressType | string |  |
| CountryId | int32 |  |


## Response: object

Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.



Carrier object for Address.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Wgs84Latitude | double | Latitude (that's north/south), decimal degrees, relative to WGS 84 ellipsoid. SuperOffice ASA is at 59.91892. This value needs no further grid reference or other qualifying information. |
| Wgs84Longitude | double | Longitude (that's East/west), decimal degrees, relative to WGS 84 ellipsoid. SuperOffice ASA is at 10.73159. This value needs no further grid reference or other qualifying information. |
| LocalizedAddress | array | LocalizedFieldArray is a list of LocalizedFieldList objects. Used to store localized information such as formatted address data. |
| Street |  | Street address (company street, person address, delivery address). LocalizedAddress changes override this property, so you do not have to change both Localized and this. |
| Postal |  | Postal address (company postal, billing address). LocalizedAddress changes override this property, so you do not have to change both Localized and this. |
| Formatted | string | Read-only formatted address multi-line string. Combines street and postal into one string. e.g.: &lt;c&gt;"Postboks 123,\nBrugata 123,\n1234 OSLO\n"&lt;/c&gt; or &lt;c&gt;"Postbox 123,\nBridgelane 123,\nWest Tooting,\nEast Shire ES2 W31\n"&lt;/c&gt;. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/SaveQuoteVersionAddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 131,
  "Address": {
    "Wgs84Latitude": 22853.128,
    "Wgs84Longitude": 28826.532,
    "LocalizedAddress": [
      [
        {
          "Name": "Rutherford-Pacocha",
          "Value": "quibusdam",
          "Tooltip": "laudantium",
          "Label": "mollitia",
          "ValueLength": 456,
          "AddressType": "ut",
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
              "FieldLength": 587
            }
          }
        }
      ],
      [
        {
          "Name": "Tromp-Deckow",
          "Value": "ex",
          "Tooltip": "voluptatem",
          "Label": "enim",
          "ValueLength": 279,
          "AddressType": "nostrum",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "reintermediate strategic solutions"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 105
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "nisi"
  },
  "AddressType": "ContactPostalAddress",
  "CountryId": 985
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Wgs84Latitude": 7841.268,
  "Wgs84Longitude": 6775.708,
  "LocalizedAddress": [
    [
      {
        "Name": "Osinski-Hudson",
        "Value": "qui",
        "Tooltip": "et",
        "Label": "adipisci",
        "ValueLength": 133,
        "AddressType": "est",
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
            "FieldLength": 561
          }
        }
      }
    ],
    [
      {
        "Name": "Brekke, Kuvalis and Cruickshank",
        "Value": "et",
        "Tooltip": "aut",
        "Label": "et",
        "ValueLength": 215,
        "AddressType": "vitae",
        "TableRight": {
          "Mask": "Delete",
          "Reason": ""
        },
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "seize real-time mindshare"
            },
            "FieldType": "System.String",
            "FieldLength": 947
          }
        }
      }
    ]
  ],
  "Street": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "accusamus",
    "Address2": "quis",
    "Address3": "consequatur",
    "City": "aliquam",
    "County": "nisi",
    "State": "molestiae",
    "Zipcode": "impedit",
    "Formatted": "velit"
  },
  "Postal": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "deserunt",
    "Address2": "eligendi",
    "Address3": "nisi",
    "City": "sed",
    "County": "ut",
    "State": "consequuntur",
    "Zipcode": "sint",
    "Formatted": "facere"
  },
  "Formatted": "molestiae",
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
      "FieldType": "System.Int32",
      "FieldLength": 487
    }
  }
}
```