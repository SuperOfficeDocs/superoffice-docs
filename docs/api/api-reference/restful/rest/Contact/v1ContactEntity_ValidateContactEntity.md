---
title: POST Contact/Validate
id: v1ContactEntity_ValidateContactEntity
---

# POST Contact/Validate

```http
POST /api/v1/Contact/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: contactEntity  

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 630,
  "Name": "VonRueden Inc and Sons",
  "Department": "",
  "OrgNr": "1742390",
  "Number1": "794927",
  "Number2": "850310",
  "UpdatedDate": "1997-07-03T15:05:41.9860029+02:00",
  "CreatedDate": "2009-09-18T15:05:41.9860029+02:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Phased fresh-thinking intranet"
    },
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Phased fresh-thinking intranet"
    }
  ],
  "Interests": [
    {
      "Id": 580,
      "Name": "Ritchie Group",
      "ToolTip": "Omnis debitis.",
      "Deleted": true,
      "Rank": 714,
      "Type": "facere",
      "ColorBlock": 682,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "1999-01-07T15:05:41.9860029+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "delectus",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Cleveland Hickle"
    }
  ],
  "Urls": [
    {
      "Value": "laborum",
      "StrippedValue": "aut",
      "Description": "Synergized zero tolerance support"
    },
    {
      "Value": "laborum",
      "StrippedValue": "aut",
      "Description": "Synergized zero tolerance support"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Operative exuding time-frame"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "omnis",
      "Description": "Operative exuding time-frame"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "praesentium",
      "Description": "Front-line homogeneous knowledge user"
    },
    {
      "Value": "ut",
      "StrippedValue": "praesentium",
      "Description": "Front-line homogeneous knowledge user"
    }
  ],
  "Description": "Synergistic homogeneous matrix",
  "UpdatedBy": {
    "AssociateId": 938,
    "Name": "Cronin Group",
    "PersonId": 382,
    "Rank": 277,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 375,
    "FullName": "Giuseppe Parisian",
    "FormalName": "Lind, Reichel and Homenick",
    "Deleted": true,
    "EjUserId": 420,
    "UserName": "Beer Group"
  },
  "CreatedBy": {
    "AssociateId": 445,
    "Name": "Weissnat Inc and Sons",
    "PersonId": 148,
    "Rank": 49,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 129,
    "FullName": "Jaycee Bashirian V",
    "FormalName": "Dickinson, Tillman and Yost",
    "Deleted": true,
    "EjUserId": 947,
    "UserName": "Altenwerth-Yundt"
  },
  "Associate": {
    "AssociateId": 635,
    "Name": "Boehm Group",
    "PersonId": 588,
    "Rank": 98,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Richie Von DDS",
    "FormalName": "Christiansen Group",
    "Deleted": true,
    "EjUserId": 182,
    "UserName": "Smitham-Gibson"
  },
  "Business": {
    "Id": 201,
    "Value": "earum",
    "Tooltip": "consectetur"
  },
  "Category": {
    "Id": 610,
    "Value": "ut",
    "Tooltip": "dolores"
  },
  "Country": {
    "CountryId": 435,
    "Name": "Haag Group",
    "CurrencyId": 65,
    "EnglishName": "Stark LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Right-sized national toolset",
    "OrgNrText": "1811032",
    "InterAreaPrefix": "repudiandae",
    "DialInPrefix": "facere",
    "ZipPrefix": "veritatis",
    "DomainName": "Klocko-Klein",
    "AddressLayoutId": 151,
    "DomesticAddressLayoutId": 373,
    "ForeignAddressLayoutId": 94,
    "Rank": 219,
    "Tooltip": "optio",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 897,
      "Mrmrs": "doloremque",
      "Firstname": "Gordon",
      "Lastname": "Ondricka",
      "MiddleName": "D'Amore-Bergstrom",
      "Title": "ut",
      "Description": "Organic responsive capacity",
      "Email": "devon@dach.info",
      "FullName": "Corbin Lynch",
      "DirectPhone": "(808)771-1625 x0473",
      "FormalName": "West LLC",
      "CountryId": 794,
      "ContactId": 201,
      "ContactName": "Treutel LLC",
      "Retired": 989,
      "Rank": 77,
      "ActiveInterests": 832,
      "ContactDepartment": "",
      "ContactCountryId": 810,
      "ContactOrgNr": "851739",
      "FaxPhone": "467.335.4216 x374",
      "MobilePhone": "1-261-767-2704 x621",
      "ContactPhone": "(053)356-1354 x86325",
      "AssociateName": "Murphy-Beahan",
      "AssociateId": 178,
      "UsePersonAddress": true,
      "ContactFax": "beatae",
      "Kanafname": "perferendis",
      "Kanalname": "nemo",
      "Post1": "nam",
      "Post2": "quia",
      "Post3": "aspernatur",
      "EmailName": "margarete@mertz.name",
      "ContactFullName": "Norris Green",
      "ActiveErpLinks": 844,
      "TicketPriorityId": 113,
      "SupportLanguageId": 667,
      "SupportAssociateId": 840,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "consequatur",
  "Xstop": true,
  "ActiveInterests": 521,
  "GroupId": 919,
  "ActiveStatusMonitorId": 732,
  "SupportAssociate": {
    "AssociateId": 143,
    "Name": "Anderson-Will",
    "PersonId": 552,
    "Rank": 328,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 551,
    "FullName": "Emily Upton",
    "FormalName": "Friesen, Robel and Abernathy",
    "Deleted": false,
    "EjUserId": 116,
    "UserName": "Sanford, Jenkins and Dietrich"
  },
  "TicketPriority": {
    "Id": 9,
    "Value": "voluptate",
    "Tooltip": "a"
  },
  "CustomerLanguage": {
    "Id": 894,
    "Value": "blanditiis",
    "Tooltip": "ea"
  },
  "Deleted": 850,
  "DbiAgentId": 959,
  "DbiLastSyncronized": "1999-07-16T15:05:41.990003+02:00",
  "DbiKey": "ipsam",
  "DbiLastModified": "2020-05-27T15:05:41.990003+02:00",
  "SupportPerson": {
    "Position": "et",
    "PersonId": 998,
    "Mrmrs": "quod",
    "Firstname": "Bruce",
    "Lastname": "Schimmel",
    "MiddleName": "Wunsch, Schaden and Osinski",
    "Title": "incidunt",
    "Description": "Intuitive contextually-based time-frame",
    "Email": "hulda.yundt@corwin.uk",
    "FullName": "Mr. Kamille Volkman",
    "DirectPhone": "(830)680-1704",
    "FormalName": "Daniel, O'Connell and Dickinson",
    "CountryId": 173,
    "ContactId": 223,
    "ContactName": "Fadel Group",
    "Retired": 171,
    "Rank": 897,
    "ActiveInterests": 229,
    "ContactDepartment": "",
    "ContactCountryId": 659,
    "ContactOrgNr": "1227477",
    "FaxPhone": "(052)557-6035 x22301",
    "MobilePhone": "(817)482-1777 x6160",
    "ContactPhone": "301-117-7228 x175",
    "AssociateName": "Walker, Jewess and Buckridge",
    "AssociateId": 725,
    "UsePersonAddress": false,
    "ContactFax": "occaecati",
    "Kanafname": "voluptate",
    "Kanalname": "eligendi",
    "Post1": "deleniti",
    "Post2": "illum",
    "Post3": "sed",
    "EmailName": "donavon@wiegand.com",
    "ContactFullName": "Adah Toy",
    "ActiveErpLinks": 171,
    "TicketPriorityId": 875,
    "SupportLanguageId": 523,
    "SupportAssociateId": 547,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 26488.568,
    "Wgs84Longitude": 15334.662,
    "LocalizedAddress": [
      [
        {
          "Name": "Schamberger-White",
          "Value": "et",
          "Tooltip": "quia",
          "Label": "et",
          "ValueLength": 855,
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
              "FieldType": "System.Int32",
              "FieldLength": 162
            }
          }
        }
      ],
      [
        {
          "Name": "Prosacco-Luettgen",
          "Value": "quae",
          "Tooltip": "magnam",
          "Label": "porro",
          "ValueLength": 659,
          "AddressType": "facilis",
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
              "FieldLength": 693
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "qui"
  },
  "Source": 506,
  "ActiveErpLinks": 96,
  "BounceEmails": [
    "lamont@boyle.name",
    "eli@collierjones.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Anibal Rodriguez",
    "SuperOffice:2": "Mitchell Koepp"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "laborum"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "delectus",
  "2": "rerum"
}
```