---
title: GET Contact/{id}/Simple
id: v1ContactEntity_Simple
---

# GET Contact/{id}/Simple

```http
GET /api/v1/Contact/{id}/Simple
```

A simple Contact object.

This is a simpler, smaller variation of the full ContactEntity. Calls the Contact agent service GetContact.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Contact to return. **Required** |



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
| 200 | ContactEntity found. |
| 404 | Not Found. |

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
GET /api/v1/Contact/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 95,
  "Name": "Leuschke LLC",
  "OrgNr": "1730983",
  "Department": "",
  "URL": "http://www.example.com/",
  "City": "omnis",
  "DirectPhone": "(553)184-7456 x105",
  "AssociateId": 37,
  "CountryId": 719,
  "EmailAddress": "hortense.okeefe@pacochabernier.biz",
  "Kananame": "ut",
  "EmailAddressName": "willy_bins@osinskimonahan.name",
  "URLName": "http://www.example.com/",
  "AssociateFullName": "Eloise Feil",
  "BusinessName": "Information Technology",
  "CategoryName": "VIP Customer",
  "CountryName": "Sokovia",
  "Address": {
    "Wgs84Latitude": 24476.54,
    "Wgs84Longitude": 29055.314,
    "LocalizedAddress": [
      [
        {
          "Name": "Jacobi-Kunze",
          "Value": "voluptatibus",
          "Tooltip": "odit",
          "Label": "quo",
          "ValueLength": 506,
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
              "FieldLength": 559
            }
          }
        }
      ],
      [
        {
          "Name": "Gislason, West and Bartoletti",
          "Value": "quae",
          "Tooltip": "beatae",
          "Label": "quas",
          "ValueLength": 175,
          "AddressType": "qui",
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
              "FieldLength": 23
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 194
      }
    }
  },
  "FormattedAddress": "sapiente",
  "FullName": "Andres Gerlach",
  "IsOwnerContact": false,
  "ActiveErpLinks": 654,
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
      "FieldLength": 415
    }
  }
}
```