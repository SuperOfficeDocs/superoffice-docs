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
  "ContactId": 250,
  "Name": "Little, Mraz and Schaden",
  "Department": "",
  "OrgNr": "912331",
  "Number1": "1214621",
  "Number2": "981090",
  "UpdatedDate": "2015-03-05T09:40:58.9903704+01:00",
  "CreatedDate": "2015-06-29T09:40:58.9903704+02:00",
  "Emails": [
    {
      "Value": "magni",
      "StrippedValue": "qui",
      "Description": "Assimilated tangible pricing structure"
    },
    {
      "Value": "magni",
      "StrippedValue": "qui",
      "Description": "Assimilated tangible pricing structure"
    }
  ],
  "Interests": [
    {
      "Id": 537,
      "Name": "Trantow-Beahan",
      "ToolTip": "Itaque eos doloremque qui quia.",
      "Deleted": false,
      "Rank": 436,
      "Type": "in",
      "ColorBlock": 349,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2015-08-09T09:40:58.9913709+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Toy Mante Jr."
    }
  ],
  "Urls": [
    {
      "Value": "ipsum",
      "StrippedValue": "voluptatum",
      "Description": "Distributed executive paradigm"
    },
    {
      "Value": "ipsum",
      "StrippedValue": "voluptatum",
      "Description": "Distributed executive paradigm"
    }
  ],
  "Phones": [
    {
      "Value": "expedita",
      "StrippedValue": "dolorem",
      "Description": "Re-contextualized needs-based analyzer"
    },
    {
      "Value": "expedita",
      "StrippedValue": "dolorem",
      "Description": "Re-contextualized needs-based analyzer"
    }
  ],
  "Faxes": [
    {
      "Value": "libero",
      "StrippedValue": "eligendi",
      "Description": "Programmable modular instruction set"
    },
    {
      "Value": "libero",
      "StrippedValue": "eligendi",
      "Description": "Programmable modular instruction set"
    }
  ],
  "Description": "Visionary 5th generation access",
  "UpdatedBy": {
    "AssociateId": 831,
    "Name": "Hahn-Dach",
    "PersonId": 344,
    "Rank": 12,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 78,
    "FullName": "Harmony Lockman",
    "FormalName": "Ferry Inc and Sons",
    "Deleted": false,
    "EjUserId": 157,
    "UserName": "Gleichner-Lowe"
  },
  "CreatedBy": {
    "AssociateId": 482,
    "Name": "Huel-Marvin",
    "PersonId": 540,
    "Rank": 676,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 551,
    "FullName": "Braden Morar",
    "FormalName": "Lowe-Baumbach",
    "Deleted": false,
    "EjUserId": 851,
    "UserName": "Rempel-Krajcik"
  },
  "Associate": {
    "AssociateId": 358,
    "Name": "Mante-Hirthe",
    "PersonId": 120,
    "Rank": 41,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 359,
    "FullName": "Orlando Klocko",
    "FormalName": "Bosco-Waelchi",
    "Deleted": false,
    "EjUserId": 805,
    "UserName": "Harvey-Johns"
  },
  "Business": {
    "Id": 434,
    "Value": "repudiandae",
    "Tooltip": "recusandae"
  },
  "Category": {
    "Id": 522,
    "Value": "sequi",
    "Tooltip": "nemo"
  },
  "Country": {
    "CountryId": 849,
    "Name": "Bins-Casper",
    "CurrencyId": 937,
    "EnglishName": "Donnelly, Johnson and Nicolas",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Balanced responsive challenge",
    "OrgNrText": "270637",
    "InterAreaPrefix": "sequi",
    "DialInPrefix": "praesentium",
    "ZipPrefix": "rerum",
    "DomainName": "Hackett LLC",
    "AddressLayoutId": 61,
    "DomesticAddressLayoutId": 925,
    "ForeignAddressLayoutId": 91,
    "Rank": 655,
    "Tooltip": "sit",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "enim",
      "PersonId": 447,
      "Mrmrs": "rerum",
      "Firstname": "Davonte",
      "Lastname": "Howe",
      "MiddleName": "Crona Inc and Sons",
      "Title": "eum",
      "Description": "Quality-focused directional middleware",
      "Email": "esther@welch.com",
      "FullName": "Mrs. Destiny Leuschke",
      "DirectPhone": "1-017-102-1246",
      "FormalName": "Kerluke Inc and Sons",
      "CountryId": 770,
      "ContactId": 74,
      "ContactName": "Bailey LLC",
      "Retired": 665,
      "Rank": 611,
      "ActiveInterests": 113,
      "ContactDepartment": "",
      "ContactCountryId": 661,
      "ContactOrgNr": "1571136",
      "FaxPhone": "1-324-207-0030",
      "MobilePhone": "1-821-581-4137",
      "ContactPhone": "180-758-0540",
      "AssociateName": "Wisozk-Sipes",
      "AssociateId": 823,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "suscipit",
      "Kanalname": "qui",
      "Post1": "asperiores",
      "Post2": "quaerat",
      "Post3": "accusantium",
      "EmailName": "emil@lynch.us",
      "ContactFullName": "Caesar Moore",
      "ActiveErpLinks": 265,
      "TicketPriorityId": 246,
      "SupportLanguageId": 197,
      "SupportAssociateId": 176,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "atque",
  "Xstop": true,
  "ActiveInterests": 573,
  "GroupId": 321,
  "ActiveStatusMonitorId": 315,
  "SupportAssociate": {
    "AssociateId": 763,
    "Name": "Upton Group",
    "PersonId": 847,
    "Rank": 65,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 934,
    "FullName": "Kennedy Block",
    "FormalName": "Von, Gaylord and Johnston",
    "Deleted": false,
    "EjUserId": 939,
    "UserName": "Kerluke-Pacocha"
  },
  "TicketPriority": {
    "Id": 138,
    "Value": "voluptate",
    "Tooltip": "neque"
  },
  "CustomerLanguage": {
    "Id": 958,
    "Value": "error",
    "Tooltip": "non"
  },
  "Deleted": 943,
  "DbiAgentId": 206,
  "DbiLastSyncronized": "2013-12-08T09:40:58.9943736+01:00",
  "DbiKey": "voluptate",
  "DbiLastModified": "2014-12-23T09:40:58.9943736+01:00",
  "SupportPerson": {
    "Position": "aliquid",
    "PersonId": 480,
    "Mrmrs": "quae",
    "Firstname": "Marina",
    "Lastname": "Heller",
    "MiddleName": "Carroll, Goldner and Conroy",
    "Title": "veritatis",
    "Description": "Public-key motivating monitoring",
    "Email": "ashlee.wilkinson@pourosturcotte.info",
    "FullName": "Ms. Carolanne Howe",
    "DirectPhone": "750-717-5155 x4560",
    "FormalName": "Schultz, Bechtelar and Kunze",
    "CountryId": 84,
    "ContactId": 893,
    "ContactName": "Harber Inc and Sons",
    "Retired": 771,
    "Rank": 455,
    "ActiveInterests": 748,
    "ContactDepartment": "",
    "ContactCountryId": 452,
    "ContactOrgNr": "1373598",
    "FaxPhone": "1-480-250-6770 x414",
    "MobilePhone": "(365)008-0043 x4423",
    "ContactPhone": "715-818-5672 x635",
    "AssociateName": "Spencer Group",
    "AssociateId": 114,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "consequatur",
    "Kanalname": "natus",
    "Post1": "laudantium",
    "Post2": "totam",
    "Post3": "optio",
    "EmailName": "rickey@johnson.name",
    "ContactFullName": "Emmett Harris",
    "ActiveErpLinks": 719,
    "TicketPriorityId": 715,
    "SupportLanguageId": 80,
    "SupportAssociateId": 863,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 24025.244,
    "Wgs84Longitude": 10627.394,
    "LocalizedAddress": [
      [
        {
          "Name": "Jaskolski-Strosin",
          "Value": "occaecati",
          "Tooltip": "minus",
          "Label": "nostrum",
          "ValueLength": 456,
          "AddressType": "optio",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "reintermediate interactive initiatives"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "streamline visionary paradigms"
              },
              "FieldType": "System.Int32",
              "FieldLength": 124
            }
          }
        }
      ],
      [
        {
          "Name": "Walsh, Schiller and Howell",
          "Value": "iure",
          "Tooltip": "molestias",
          "Label": "eius",
          "ValueLength": 182,
          "AddressType": "sunt",
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
              "FieldLength": 13
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "distinctio"
  },
  "Source": 221,
  "ActiveErpLinks": 878,
  "BounceEmails": [
    "margret@lindgren.info",
    "jacky_dooley@renner.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ted Barrows",
    "SuperOffice:2": "Teresa Hermann"
  },
  "ExtraFields": {
    "ExtraFields1": "fugiat",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "nihil"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "autem",
  "2": "delectus"
}
```