---
title: POST Agents/Contact/GetMyContacts
id: v1ContactAgent_GetMyContacts
---

# POST Agents/Contact/GetMyContacts

```http
POST /api/v1/Agents/Contact/GetMyContacts
```

Getting the contacts where the user currently logged in is set as contact owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContacts?$select=name,department,category/id
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| OrgNr | string | VAT number or similar |
| Department | string | Department |
| URL | string | The internet address to this contact |
| City | string | City corresponding to zip code |
| DirectPhone | string | The contacts phone |
| AssociateId | int32 | Our contact |
| CountryId | int32 | Country |
| EmailAddress | string | The contact email address |
| Kananame | string | Contact kana name, used in Japanese versions only |
| EmailAddressName | string | Visible field |
| URLName | string | Visible field |
| AssociateFullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| BusinessName | string | The business list item name |
| CategoryName | string | The category list item name |
| CountryName | string | Name of country in installed language |
| Address |  | Contact address as  a list of LocalizedFieldList objects. Used to store localized information such as formatted address data. Suitable for passing to an address control for display. |
| FormattedAddress | string | The contact's address, formatted with linebreaks and spaces into a single string. |
| FullName | string |  |
| IsOwnerContact | bool | Is the contact an owner contact.  This means that all persons on this contact can on only be internal users and not external users. |
| ActiveErpLinks | int32 | The number of active erp links |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/GetMyContacts
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactId": 191,
    "Name": "Howell, Hermiston and Moen",
    "OrgNr": "642933",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "incidunt",
    "DirectPhone": "1-887-511-7745",
    "AssociateId": 504,
    "CountryId": 505,
    "EmailAddress": "braulio@keeling.us",
    "Kananame": "aut",
    "EmailAddressName": "theresa@boehm.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Amari Mosciski I",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {
      "Wgs84Latitude": 7916.4839999999995,
      "Wgs84Longitude": 6164.5779999999995,
      "LocalizedAddress": [
        [
          {
            "Name": "Muller, Larkin and Brown",
            "Value": "nemo",
            "Tooltip": "vel",
            "Label": "porro",
            "ValueLength": 849,
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
                "FieldType": "System.Int32",
                "FieldLength": 612
              }
            }
          }
        ],
        [
          {
            "Name": "Steuber LLC",
            "Value": "architecto",
            "Tooltip": "autem",
            "Label": "ut",
            "ValueLength": 982,
            "AddressType": "non",
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
                "FieldLength": 613
              }
            }
          }
        ]
      ],
      "Street": {},
      "Postal": {},
      "Formatted": "porro",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 815
        }
      }
    },
    "FormattedAddress": "architecto",
    "FullName": "Golden Kunze DDS",
    "IsOwnerContact": false,
    "ActiveErpLinks": 722,
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
        "FieldLength": 552
      }
    }
  }
]
```