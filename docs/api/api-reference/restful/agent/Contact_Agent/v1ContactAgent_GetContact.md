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
POST /api/v1/Agents/Contact/GetContact?contactId=635
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 60,
  "Name": "Okuneva, Jewess and Heidenreich",
  "OrgNr": "834908",
  "Department": "",
  "URL": "http://www.example.com/",
  "City": "maxime",
  "DirectPhone": "355.574.0470",
  "AssociateId": 237,
  "CountryId": 688,
  "EmailAddress": "ervin.raynor@rohan.com",
  "Kananame": "ad",
  "EmailAddressName": "larue@crona.biz",
  "URLName": "http://www.example.com/",
  "AssociateFullName": "Triston Armstrong",
  "BusinessName": "Information Technology",
  "CategoryName": "VIP Customer",
  "CountryName": "Sokovia",
  "Address": {
    "Wgs84Latitude": 20913.182,
    "Wgs84Longitude": 19346.182,
    "LocalizedAddress": [
      [
        {
          "Name": "Bins, Bradtke and Glover",
          "Value": "aut",
          "Tooltip": "qui",
          "Label": "dolorem",
          "ValueLength": 164,
          "AddressType": "dicta",
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
              "FieldLength": 866
            }
          }
        }
      ],
      [
        {
          "Name": "Breitenberg, Hansen and Lebsack",
          "Value": "saepe",
          "Tooltip": "consectetur",
          "Label": "sed",
          "ValueLength": 446,
          "AddressType": "libero",
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
              "FieldLength": 480
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "accusamus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 279
      }
    }
  },
  "FormattedAddress": "omnis",
  "FullName": "Miss Jerrold Bosco",
  "IsOwnerContact": false,
  "ActiveErpLinks": 831,
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
      "FieldLength": 99
    }
  }
}
```