---
title: POST Agents/Contact/SaveQuoteVersionAddress
id: v1ContactAgent_SaveQuoteVersionAddress
---

# POST Agents/Contact/SaveQuoteVersionAddress

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 728,
  "Address": {
    "Wgs84Latitude": 21768.764,
    "Wgs84Longitude": 15635.526,
    "LocalizedAddress": [
      [
        {
          "Name": "Nicolas-Stoltenberg",
          "Value": "fuga",
          "Tooltip": "rem",
          "Label": "totam",
          "ValueLength": 9,
          "AddressType": "accusantium",
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
              "FieldLength": 619
            }
          }
        }
      ],
      [
        {
          "Name": "Kessler, Keeling and Rolfson",
          "Value": "qui",
          "Tooltip": "et",
          "Label": "est",
          "ValueLength": 53,
          "AddressType": "sunt",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "scale collaborative solutions"
              },
              "FieldType": "System.String",
              "FieldLength": 156
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "nostrum"
  },
  "AddressType": "ContactPostalAddress",
  "CountryId": 758
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Wgs84Latitude": 13758.26,
  "Wgs84Longitude": 18399.714,
  "LocalizedAddress": [
    [
      {
        "Name": "Kub, Kirlin and Rau",
        "Value": "nulla",
        "Tooltip": "rerum",
        "Label": "doloribus",
        "ValueLength": 74,
        "AddressType": "distinctio",
        "TableRight": {
          "Mask": "Delete",
          "Reason": ""
        },
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "morph vertical solutions"
            },
            "FieldType": "System.Int32",
            "FieldLength": 795
          }
        }
      }
    ],
    [
      {
        "Name": "Zboncak Inc and Sons",
        "Value": "velit",
        "Tooltip": "fugiat",
        "Label": "est",
        "ValueLength": 51,
        "AddressType": "fuga",
        "TableRight": {
          "Mask": "Delete",
          "Reason": ""
        },
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "streamline strategic eyeballs"
            },
            "FieldType": "System.String",
            "FieldLength": 861
          }
        }
      }
    ]
  ],
  "Street": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "fugiat",
    "Address2": "quia",
    "Address3": "corrupti",
    "City": "aut",
    "County": "nesciunt",
    "State": "adipisci",
    "Zipcode": "praesentium",
    "Formatted": "aperiam"
  },
  "Postal": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "illo",
    "Address2": "eius",
    "Address3": "officia",
    "City": "rerum",
    "County": "quam",
    "State": "quia",
    "Zipcode": "veritatis",
    "Formatted": "recusandae"
  },
  "Formatted": "qui",
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
      "FieldLength": 110
    }
  }
}
```