---
title: POST Agents/Contact/GetContact
id: v1ContactAgent_GetContact
---

# POST Agents/Contact/GetContact

```http
POST /api/v1/Agents/Contact/GetContact
```

Gets a Contact object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContact?contactId=947
POST /api/v1/Agents/Contact/GetContact?$select=name,department,category/id
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

Carrier object for Contact.
Services for the Contact Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
POST /api/v1/Agents/Contact/GetContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 451,
  "Name": "O'Hara, Hirthe and Yundt",
  "OrgNr": "1651432",
  "Department": "",
  "URL": "http://www.example.com/",
  "City": "ipsam",
  "DirectPhone": "(330)274-1250 x0741",
  "AssociateId": 33,
  "CountryId": 342,
  "EmailAddress": "johnson_runte@schuster.biz",
  "Kananame": "reprehenderit",
  "EmailAddressName": "taya_weber@ullrichwunsch.us",
  "URLName": "http://www.example.com/",
  "AssociateFullName": "Geovanny Harris",
  "BusinessName": "Information Technology",
  "CategoryName": "VIP Customer",
  "CountryName": "Sokovia",
  "Address": {
    "Wgs84Latitude": 17381.164,
    "Wgs84Longitude": 29421.992,
    "LocalizedAddress": [
      [
        {
          "Name": "Ryan-Gislason",
          "Value": "consequatur",
          "Tooltip": "aspernatur",
          "Label": "a",
          "ValueLength": 522,
          "AddressType": "excepturi",
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
              "FieldLength": 161
            }
          }
        }
      ],
      [
        {
          "Name": "Pollich-Conroy",
          "Value": "quia",
          "Tooltip": "sequi",
          "Label": "voluptatibus",
          "ValueLength": 575,
          "AddressType": "consequatur",
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
              "FieldLength": 25
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "beatae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 135
      }
    }
  },
  "FormattedAddress": "qui",
  "FullName": "Helene Hyatt",
  "IsOwnerContact": true,
  "ActiveErpLinks": 86,
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
      "FieldLength": 798
    }
  }
}
```