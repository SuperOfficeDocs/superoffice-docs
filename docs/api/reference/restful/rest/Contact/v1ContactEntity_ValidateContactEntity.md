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
| Domains | array | Web domains for this contact, ordered in array by rank |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 569,
  "Name": "Sanford Group",
  "Department": "",
  "OrgNr": "856894",
  "Number1": "737609",
  "Number2": "540197",
  "UpdatedDate": "2014-02-23T18:25:50.3655947+01:00",
  "CreatedDate": "1996-12-12T18:25:50.3655947+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "facilis",
      "Description": "Up-sized bi-directional infrastructure"
    },
    {
      "Value": "autem",
      "StrippedValue": "facilis",
      "Description": "Up-sized bi-directional infrastructure"
    }
  ],
  "Interests": [
    {
      "Id": 875,
      "Name": "Wolff LLC",
      "ToolTip": "Architecto consectetur aperiam.",
      "Deleted": false,
      "Rank": 267,
      "Type": "tempora",
      "ColorBlock": 41,
      "IconHint": "a",
      "Selected": true,
      "LastChanged": "2020-02-13T18:25:50.3655947+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Noble Bernhard IV"
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "dolores",
      "Description": "Pre-emptive global implementation"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "dolores",
      "Description": "Pre-emptive global implementation"
    }
  ],
  "Phones": [
    {
      "Value": "id",
      "StrippedValue": "enim",
      "Description": "Horizontal mission-critical utilisation"
    },
    {
      "Value": "id",
      "StrippedValue": "enim",
      "Description": "Horizontal mission-critical utilisation"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "velit",
      "Description": "Optional upward-trending customer loyalty"
    },
    {
      "Value": "sit",
      "StrippedValue": "velit",
      "Description": "Optional upward-trending customer loyalty"
    }
  ],
  "Description": "Open-source regional local area network",
  "UpdatedBy": {
    "AssociateId": 764,
    "Name": "Hyatt Group",
    "PersonId": 178,
    "Rank": 247,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 769,
    "FullName": "Victor Green",
    "FormalName": "Nienow-Jast",
    "Deleted": false,
    "EjUserId": 829,
    "UserName": "Kessler, Veum and Prosacco"
  },
  "CreatedBy": {
    "AssociateId": 830,
    "Name": "Weber-Cassin",
    "PersonId": 917,
    "Rank": 20,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 882,
    "FullName": "Chance Hills",
    "FormalName": "Bartell-Reichert",
    "Deleted": true,
    "EjUserId": 361,
    "UserName": "Boyer, Armstrong and Spinka"
  },
  "Associate": {
    "AssociateId": 309,
    "Name": "Trantow-Graham",
    "PersonId": 563,
    "Rank": 145,
    "Tooltip": "esse",
    "Type": "AnonymousAssociate",
    "GroupIdx": 348,
    "FullName": "Andres Hodkiewicz",
    "FormalName": "Schroeder, Beatty and Harber",
    "Deleted": false,
    "EjUserId": 12,
    "UserName": "Konopelski Group"
  },
  "Business": {
    "Id": 519,
    "Value": "inventore",
    "Tooltip": "vel"
  },
  "Category": {
    "Id": 38,
    "Value": "quam",
    "Tooltip": "illum"
  },
  "Country": {
    "CountryId": 689,
    "Name": "Flatley, Kilback and Feeney",
    "CurrencyId": 632,
    "EnglishName": "Bergnaum-Wuckert",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Team-oriented bi-directional artificial intelligence",
    "OrgNrText": "829304",
    "InterAreaPrefix": "amet",
    "DialInPrefix": "maiores",
    "ZipPrefix": "accusamus",
    "DomainName": "Schulist LLC",
    "AddressLayoutId": 523,
    "DomesticAddressLayoutId": 972,
    "ForeignAddressLayoutId": 779,
    "Rank": 231,
    "Tooltip": "voluptas",
    "Deleted": true
  },
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 590,
      "Mrmrs": "quis",
      "Firstname": "Gladys",
      "Lastname": "Miller",
      "MiddleName": "Schumm-Price",
      "Title": "rerum",
      "Description": "Enhanced maximized monitoring",
      "Email": "lauryn@daugherty.info",
      "FullName": "Shyanne Reynolds",
      "DirectPhone": "(564)431-2727 x46855",
      "FormalName": "Cummings-Harber",
      "CountryId": 514,
      "ContactId": 139,
      "ContactName": "Schaden-Streich",
      "Retired": 552,
      "Rank": 183,
      "ActiveInterests": 485,
      "ContactDepartment": "incubate clicks-and-mortar schemas",
      "ContactCountryId": 937,
      "ContactOrgNr": "804784",
      "FaxPhone": "(777)322-5327 x887",
      "MobilePhone": "1-555-035-2778 x288",
      "ContactPhone": "1-737-753-7657 x0241",
      "AssociateName": "Auer-Nienow",
      "AssociateId": 267,
      "UsePersonAddress": false,
      "ContactFax": "sapiente",
      "Kanafname": "dolor",
      "Kanalname": "quia",
      "Post1": "numquam",
      "Post2": "voluptatem",
      "Post3": "sunt",
      "EmailName": "eleanora@leffler.co.uk",
      "ContactFullName": "Freddie Ondricka",
      "ActiveErpLinks": 903,
      "TicketPriorityId": 922,
      "SupportLanguageId": 835,
      "SupportAssociateId": 31,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "veritatis",
  "Xstop": true,
  "ActiveInterests": 840,
  "GroupId": 290,
  "ActiveStatusMonitorId": 10,
  "SupportAssociate": {
    "AssociateId": 242,
    "Name": "Runolfsdottir LLC",
    "PersonId": 266,
    "Rank": 997,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 914,
    "FullName": "Maximus Rau",
    "FormalName": "Wolf-Marks",
    "Deleted": false,
    "EjUserId": 574,
    "UserName": "Lemke Group"
  },
  "TicketPriority": {
    "Id": 313,
    "Value": "veritatis",
    "Tooltip": "nisi"
  },
  "CustomerLanguage": {
    "Id": 846,
    "Value": "in",
    "Tooltip": "officia"
  },
  "Deleted": 185,
  "DbiAgentId": 673,
  "DbiLastSyncronized": "2019-09-10T18:25:50.3696258+02:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2017-09-11T18:25:50.3696258+02:00",
  "SupportPerson": {
    "Position": "dolorum",
    "PersonId": 985,
    "Mrmrs": "enim",
    "Firstname": "Brody",
    "Lastname": "Rohan",
    "MiddleName": "Erdman Inc and Sons",
    "Title": "magni",
    "Description": "Operative explicit project",
    "Email": "nick.ward@prosaccovonrueden.name",
    "FullName": "Diego Orn Jr.",
    "DirectPhone": "1-405-483-5808",
    "FormalName": "D'Amore-Ernser",
    "CountryId": 847,
    "ContactId": 284,
    "ContactName": "Koepp Inc and Sons",
    "Retired": 865,
    "Rank": 779,
    "ActiveInterests": 794,
    "ContactDepartment": "",
    "ContactCountryId": 919,
    "ContactOrgNr": "1209419",
    "FaxPhone": "416-735-0361 x4711",
    "MobilePhone": "767.361.7566 x1724",
    "ContactPhone": "1-152-383-2250",
    "AssociateName": "Schinner Inc and Sons",
    "AssociateId": 92,
    "UsePersonAddress": false,
    "ContactFax": "hic",
    "Kanafname": "maiores",
    "Kanalname": "rerum",
    "Post1": "similique",
    "Post2": "cupiditate",
    "Post3": "omnis",
    "EmailName": "caitlyn@schmidt.name",
    "ContactFullName": "Armand Spinka",
    "ActiveErpLinks": 571,
    "TicketPriorityId": 786,
    "SupportLanguageId": 155,
    "SupportAssociateId": 397,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 18575.218,
    "Wgs84Longitude": 16290.532,
    "LocalizedAddress": [
      [
        {
          "Name": "Hoeger LLC",
          "Value": "est",
          "Tooltip": "rerum",
          "Label": "modi",
          "ValueLength": 62,
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
              "FieldType": "System.String",
              "FieldLength": 378
            }
          }
        }
      ],
      [
        {
          "Name": "Flatley, Blick and Hirthe",
          "Value": "laboriosam",
          "Tooltip": "sed",
          "Label": "et",
          "ValueLength": 30,
          "AddressType": "officia",
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
              "FieldLength": 808
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "et"
  },
  "Source": 9,
  "ActiveErpLinks": 61,
  "BounceEmails": [
    "vern@kling.co.uk",
    "mohammed_sanford@heidenreichkiehn.name"
  ],
  "Domains": [
    "nemo",
    "consectetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "89978597",
    "SuperOffice:2": "Millie Farrell"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "amet"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "velit",
  "2": "dolores"
}
```