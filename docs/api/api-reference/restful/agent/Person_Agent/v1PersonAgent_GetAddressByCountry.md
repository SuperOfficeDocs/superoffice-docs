---
title: GetAddressByCountry
id: v1PersonAgent_GetAddressByCountry
---

# GetAddressByCountry

```http
POST /api/v1/Agents/Person/GetAddressByCountry
```

Gets the person's localized address.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetAddressByCountry?$select=name,department,category/id
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

PersonId, CountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
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
POST /api/v1/Agents/Person/GetAddressByCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 598,
  "CountryId": 854
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Wgs84Latitude": 5070.812,
  "Wgs84Longitude": 20032.528,
  "LocalizedAddress": [
    [
      {
        "Name": "Krajcik, Hayes and Cruickshank",
        "Value": "incidunt",
        "Tooltip": "consequatur",
        "Label": "non",
        "ValueLength": 690,
        "AddressType": "autem",
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
            "FieldLength": 240
          }
        }
      }
    ],
    [
      {
        "Name": "Krajcik, Collier and Wisozk",
        "Value": "voluptatum",
        "Tooltip": "aperiam",
        "Label": "id",
        "ValueLength": 176,
        "AddressType": "perferendis",
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
            "FieldLength": 643
          }
        }
      }
    ]
  ],
  "Street": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "et",
    "Address2": "mollitia",
    "Address3": "aperiam",
    "City": "odio",
    "County": "reprehenderit",
    "State": "nesciunt",
    "Zipcode": "inventore",
    "Formatted": "neque"
  },
  "Postal": {
    "AtypeIdx": "ContactPostalAddress",
    "Address1": "et",
    "Address2": "rerum",
    "Address3": "repellendus",
    "City": "quas",
    "County": "tempore",
    "State": "iste",
    "Zipcode": "harum",
    "Formatted": "officiis"
  },
  "Formatted": "harum",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "deploy 24/365 synergies"
      },
      "FieldType": "System.Int32",
      "FieldLength": 200
    }
  }
}
```