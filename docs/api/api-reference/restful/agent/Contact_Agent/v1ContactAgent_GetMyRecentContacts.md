---
title: POST Agents/Contact/GetMyRecentContacts
id: v1ContactAgent_GetMyRecentContacts
---

# POST Agents/Contact/GetMyRecentContacts

```http
POST /api/v1/Agents/Contact/GetMyRecentContacts
```

Method that returns a set of initial contacts.

This could be the contacts in a favorites selection, the history list, the diary, or from all sources. If retrieved from the diary it will get appointments for the current and the next day.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyRecentContacts?$select=name,department,category/id
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

SourceType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceType | string |  |


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
POST /api/v1/Agents/Contact/GetMyRecentContacts
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceType": "All"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactId": 599,
    "Name": "Muller Inc and Sons",
    "OrgNr": "802298",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eos",
    "DirectPhone": "1-071-222-0787",
    "AssociateId": 863,
    "CountryId": 198,
    "EmailAddress": "dannie@riceswift.co.uk",
    "Kananame": "ipsum",
    "EmailAddressName": "araceli@heaney.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kasandra Gibson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {
      "Wgs84Latitude": 1776.9779999999998,
      "Wgs84Longitude": 19086.059999999998,
      "LocalizedAddress": [
        [
          {
            "Name": "Volkman, Feest and Nikolaus",
            "Value": "facere",
            "Tooltip": "consequatur",
            "Label": "quaerat",
            "ValueLength": 498,
            "AddressType": "veritatis",
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
                "FieldLength": 177
              }
            }
          }
        ],
        [
          {
            "Name": "Greenholt Group",
            "Value": "maiores",
            "Tooltip": "et",
            "Label": "voluptatem",
            "ValueLength": 93,
            "AddressType": "sit",
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
                "FieldLength": 993
              }
            }
          }
        ]
      ],
      "Street": {},
      "Postal": {},
      "Formatted": "eligendi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 892
        }
      }
    },
    "FormattedAddress": "in",
    "FullName": "Earnestine Turner",
    "IsOwnerContact": true,
    "ActiveErpLinks": 815,
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
        "FieldLength": 88
      }
    }
  }
]
```