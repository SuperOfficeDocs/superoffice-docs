---
title: PUT Person/{id}
id: v1PersonEntity_PutPersonEntity
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
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

## Request Body: entity  

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The Person Service. The service implements all services working with the Person object.



PersonEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 715,
  "Firstname": "Linwood",
  "MiddleName": "Stiedemann-Keebler",
  "Lastname": "Parker",
  "Mrmrs": "labore",
  "Title": "qui",
  "UpdatedDate": "2009-03-24T09:40:59.3336654+01:00",
  "CreatedDate": "1994-05-22T09:40:59.3336654+02:00",
  "BirthDate": "2018-03-05T09:40:59.3336654+01:00",
  "CreatedBy": {
    "AssociateId": 296,
    "Name": "Stehr-Schuppe",
    "PersonId": 494,
    "Rank": 679,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 986,
    "FullName": "Minerva Kautzer I",
    "FormalName": "Windler-Hodkiewicz",
    "Deleted": true,
    "EjUserId": 509,
    "UserName": "Ebert, Rau and O'Reilly"
  },
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "eligendi",
      "Description": "Ameliorated reciprocal orchestration"
    },
    {
      "Value": "commodi",
      "StrippedValue": "eligendi",
      "Description": "Ameliorated reciprocal orchestration"
    }
  ],
  "Description": "Reactive directional concept",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "id",
      "Description": "Enhanced even-keeled analyzer"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "id",
      "Description": "Enhanced even-keeled analyzer"
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "voluptas",
      "Description": "Customer-focused 24 hour initiative"
    },
    {
      "Value": "eos",
      "StrippedValue": "voluptas",
      "Description": "Customer-focused 24 hour initiative"
    }
  ],
  "MobilePhones": [
    {
      "Value": "ad",
      "StrippedValue": "sit",
      "Description": "Upgradable bifurcated superstructure"
    },
    {
      "Value": "ad",
      "StrippedValue": "sit",
      "Description": "Upgradable bifurcated superstructure"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "blanditiis",
      "Description": "Seamless zero defect standardization"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "blanditiis",
      "Description": "Seamless zero defect standardization"
    }
  ],
  "OtherPhones": [
    {
      "Value": "accusamus",
      "StrippedValue": "nulla",
      "Description": "Open-architected fresh-thinking Graphic Interface"
    },
    {
      "Value": "accusamus",
      "StrippedValue": "nulla",
      "Description": "Open-architected fresh-thinking Graphic Interface"
    }
  ],
  "Position": {
    "Id": 668,
    "Value": "facilis",
    "Tooltip": "sequi"
  },
  "UpdatedBy": {
    "AssociateId": 784,
    "Name": "Mayer-Bailey",
    "PersonId": 87,
    "Rank": 228,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 502,
    "FullName": "Julia Herman",
    "FormalName": "Carroll Inc and Sons",
    "Deleted": false,
    "EjUserId": 839,
    "UserName": "Keeling LLC"
  },
  "Contact": {
    "ContactId": 193,
    "Name": "Gleason LLC",
    "OrgNr": "1104717",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "unde",
    "DirectPhone": "106.330.7320 x708",
    "AssociateId": 934,
    "CountryId": 750,
    "EmailAddress": "isidro@dibbert.info",
    "Kananame": "maxime",
    "EmailAddressName": "landen.hackett@mitchellmills.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Tamara Schultz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "culpa",
    "FullName": "Myrtis Effertz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 484
  },
  "Country": {
    "CountryId": 52,
    "Name": "McDermott-Collier",
    "CurrencyId": 209,
    "EnglishName": "Mosciski-Yundt",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Devolved disintermediate support",
    "OrgNrText": "1406800",
    "InterAreaPrefix": "quaerat",
    "DialInPrefix": "assumenda",
    "ZipPrefix": "est",
    "DomainName": "Rolfson LLC",
    "AddressLayoutId": 979,
    "DomesticAddressLayoutId": 672,
    "ForeignAddressLayoutId": 800,
    "Rank": 79,
    "Tooltip": "tempora",
    "Deleted": false
  },
  "Interests": [
    {
      "Id": 744,
      "Name": "Wiza-Wunsch",
      "ToolTip": "Ipsam in sed blanditiis.",
      "Deleted": true,
      "Rank": 977,
      "Type": "et",
      "ColorBlock": 430,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2016-08-06T09:40:59.3376656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "itaque",
      "Hidden": false,
      "FullName": "Mariah Renner"
    }
  ],
  "PersonNumber": "793570",
  "FullName": "Ethan Christiansen",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "soluta",
      "Description": "Implemented grid-enabled standardization"
    },
    {
      "Value": "quod",
      "StrippedValue": "soluta",
      "Description": "Implemented grid-enabled standardization"
    }
  ],
  "FormalName": "Hagenes, Walsh and Rau",
  "Address": {
    "Wgs84Latitude": 5804.168,
    "Wgs84Longitude": 4234.034,
    "LocalizedAddress": [
      [
        {
          "Name": "Cummerata LLC",
          "Value": "voluptates",
          "Tooltip": "sapiente",
          "Label": "aut",
          "ValueLength": 865,
          "AddressType": "nemo",
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
              "FieldLength": 994
            }
          }
        }
      ],
      [
        {
          "Name": "Oberbrunner, Lind and Zieme",
          "Value": "enim",
          "Tooltip": "autem",
          "Label": "voluptate",
          "ValueLength": 811,
          "AddressType": "voluptas",
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
              "FieldLength": 452
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "modi"
  },
  "Post3": "et",
  "Post2": "et",
  "Post1": "deleniti",
  "Kanalname": "quod",
  "Kanafname": "eum",
  "CorrespondingAssociate": {
    "AssociateId": 498,
    "Name": "Watsica Group",
    "PersonId": 540,
    "Rank": 595,
    "Tooltip": "explicabo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 295,
    "FullName": "Ms. Kaylee Lang",
    "FormalName": "Boyle LLC",
    "Deleted": false,
    "EjUserId": 40,
    "UserName": "Shanahan-Smith"
  },
  "Category": {
    "Id": 992,
    "Value": "animi",
    "Tooltip": "temporibus"
  },
  "Business": {
    "Id": 369,
    "Value": "temporibus",
    "Tooltip": "ab"
  },
  "Associate": {
    "AssociateId": 65,
    "Name": "Hahn-Kerluke",
    "PersonId": 833,
    "Rank": 851,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 110,
    "FullName": "Rodger Breitenberg",
    "FormalName": "Swift, Fisher and Kirlin",
    "Deleted": false,
    "EjUserId": 838,
    "UserName": "Prosacco-Torphy"
  },
  "Salutation": "distinctio",
  "ActiveInterests": 201,
  "SupportAssociate": {
    "AssociateId": 165,
    "Name": "Hammes-Schmitt",
    "PersonId": 836,
    "Rank": 906,
    "Tooltip": "possimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 383,
    "FullName": "Clyde Ritchie",
    "FormalName": "Schinner Group",
    "Deleted": true,
    "EjUserId": 642,
    "UserName": "Mayert, Cremin and O'Reilly"
  },
  "TicketPriority": {
    "Id": 889,
    "Value": "unde",
    "Tooltip": "velit"
  },
  "CustomerLanguage": {
    "Id": 955,
    "Value": "ut",
    "Tooltip": "in"
  },
  "DbiAgentId": 653,
  "DbiKey": "libero",
  "DbiLastModified": "2007-10-06T09:40:59.3396656+02:00",
  "DbiLastSyncronized": "2003-12-27T09:40:59.3396656+01:00",
  "SentInfo": 201,
  "ShowContactTickets": 191,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 855,
    "UserName": "Baumbach Inc and Sons",
    "PersonId": 899,
    "Rank": 43,
    "Tooltip": "sint",
    "UserGroupId": 42,
    "EjUserId": 695,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "quis",
      "quae"
    ],
    "CanLogon": true,
    "RoleName": "Wunsch-Funk",
    "RoleTooltip": "quos",
    "UserGroupName": "Satterfield-Rau",
    "UserGroupTooltip": "ea"
  },
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Enterprise-wide stable hierarchy"
    },
    {
      "Value": "et",
      "StrippedValue": "corporis",
      "Description": "Enterprise-wide stable hierarchy"
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "dolorum",
      "Description": "Optional grid-enabled installation"
    },
    {
      "Value": "est",
      "StrippedValue": "dolorum",
      "Description": "Optional grid-enabled installation"
    }
  ],
  "Source": 204,
  "ActiveErpLinks": 898,
  "ShipmentTypes": [
    {
      "Id": 915,
      "Name": "Parisian Group",
      "ToolTip": "Sunt consectetur ipsum.",
      "Deleted": true,
      "Rank": 650,
      "Type": "enim",
      "ColorBlock": 713,
      "IconHint": "corporis",
      "Selected": true,
      "LastChanged": "2017-10-10T09:40:59.3396656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Ricky Schimmel"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 775,
      "Comment": "aut",
      "Registered": "1997-03-30T09:40:59.3406654+02:00",
      "RegisteredAssociateId": 915,
      "Updated": "2006-06-28T09:40:59.3406654+02:00",
      "UpdatedAssociateId": 749,
      "LegalBaseId": 718,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Barton-Goodwin",
      "ConsentPurposeId": 114,
      "ConsentPurposeKey": "enim",
      "ConsentPurposeName": "Goyette-McGlynn",
      "ConsentSourceId": 893,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Russel Inc and Sons"
    }
  ],
  "BounceEmails": [
    "unique@zboncak.com",
    "rosetta.langworth@emard.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Betsy Stroman",
    "SuperOffice:2": "Georgianna Larkin"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "aperiam"
  }
}
```

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 678,
  "Firstname": "Keaton",
  "MiddleName": "Koch-Renner",
  "Lastname": "Hayes",
  "Mrmrs": "et",
  "Title": "ipsam",
  "UpdatedDate": "2000-01-26T09:40:59.3506657+01:00",
  "CreatedDate": "2020-12-17T09:40:59.3506657+01:00",
  "BirthDate": "2001-01-28T09:40:59.3506657+01:00",
  "CreatedBy": {
    "AssociateId": 889,
    "Name": "Emard-Botsford",
    "PersonId": 619,
    "Rank": 401,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 601,
    "FullName": "Danial Mayert IV",
    "FormalName": "VonRueden LLC",
    "Deleted": false,
    "EjUserId": 957,
    "UserName": "Bergnaum-Herman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 617
      }
    }
  },
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "voluptate",
      "Description": "Cross-platform 24/7 core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "voluptate",
      "Description": "Cross-platform 24/7 core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 740
        }
      }
    }
  ],
  "Description": "Multi-layered next generation knowledge user",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "atque",
      "StrippedValue": "velit",
      "Description": "Enterprise-wide bottom-line software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "velit",
      "Description": "Enterprise-wide bottom-line software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "provident",
      "Description": "Triple-buffered client-driven paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "provident",
      "Description": "Triple-buffered client-driven paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 304
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "rem",
      "StrippedValue": "doloribus",
      "Description": "Optional disintermediate database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement best-of-breed users"
          },
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "doloribus",
      "Description": "Optional disintermediate database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement best-of-breed users"
          },
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "laudantium",
      "Description": "Virtual explicit knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "laudantium",
      "Description": "Virtual explicit knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "libero",
      "StrippedValue": "error",
      "Description": "Right-sized next generation toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "error",
      "Description": "Right-sized next generation toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    }
  ],
  "Position": {
    "Id": 43,
    "Value": "mollitia",
    "Tooltip": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 414
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 840,
    "Name": "Ondricka, Hayes and Harris",
    "PersonId": 566,
    "Rank": 541,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Vincenzo Howell",
    "FormalName": "Murphy Inc and Sons",
    "Deleted": false,
    "EjUserId": 367,
    "UserName": "Kemmer Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 802
      }
    }
  },
  "Contact": {
    "ContactId": 905,
    "Name": "Kerluke, Hane and Fadel",
    "OrgNr": "1722173",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "521-131-0440",
    "AssociateId": 856,
    "CountryId": 397,
    "EmailAddress": "nadia_hintz@wolf.biz",
    "Kananame": "voluptatem",
    "EmailAddressName": "magnolia_dach@lebsack.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Linwood McDermott V",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eum",
    "FullName": "Brett Blanda PhD",
    "IsOwnerContact": true,
    "ActiveErpLinks": 721,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Country": {
    "CountryId": 529,
    "Name": "Lakin-Johnston",
    "CurrencyId": 626,
    "EnglishName": "Altenwerth, Zboncak and Langosh",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Fundamental neutral internet solution",
    "OrgNrText": "685318",
    "InterAreaPrefix": "omnis",
    "DialInPrefix": "quas",
    "ZipPrefix": "incidunt",
    "DomainName": "Grady, Bartell and Harber",
    "AddressLayoutId": 210,
    "DomesticAddressLayoutId": 167,
    "ForeignAddressLayoutId": 904,
    "Rank": 885,
    "Tooltip": "est",
    "Deleted": false,
    "TableRight": {},
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
  },
  "Interests": [
    {
      "Id": 588,
      "Name": "Bailey LLC",
      "ToolTip": "Et deserunt fugit quis.",
      "Deleted": false,
      "Rank": 630,
      "Type": "aut",
      "ColorBlock": 831,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "1998-08-07T09:40:59.3546656+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "distinctio",
      "StyleHint": "iste",
      "Hidden": true,
      "FullName": "Jaeden Turner Sr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 897
        }
      }
    }
  ],
  "PersonNumber": "1216593",
  "FullName": "Jackie Leuschke",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "expedita",
      "Description": "Profound logistical interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "expedita",
      "Description": "Profound logistical interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    }
  ],
  "FormalName": "Wuckert, Schamberger and Lindgren",
  "Address": {
    "Wgs84Latitude": 12492.124,
    "Wgs84Longitude": 952.736,
    "LocalizedAddress": [
      [
        {
          "Name": "Schowalter, Welch and Kovacek",
          "Value": "adipisci",
          "Tooltip": "facere",
          "Label": "cumque",
          "ValueLength": 353,
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
              "FieldLength": 445
            }
          }
        }
      ],
      [
        {
          "Name": "Tromp LLC",
          "Value": "itaque",
          "Tooltip": "quasi",
          "Label": "soluta",
          "ValueLength": 942,
          "AddressType": "eos",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "strategize cross-media initiatives"
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
    "Formatted": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 692
      }
    }
  },
  "Post3": "ipsum",
  "Post2": "quod",
  "Post1": "qui",
  "Kanalname": "voluptas",
  "Kanafname": "nemo",
  "CorrespondingAssociate": {
    "AssociateId": 175,
    "Name": "McLaughlin LLC",
    "PersonId": 911,
    "Rank": 695,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 606,
    "FullName": "Uriel Ferry V",
    "FormalName": "Gerlach, Bogan and Johnston",
    "Deleted": true,
    "EjUserId": 997,
    "UserName": "Roob-Runolfsdottir",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 353
      }
    }
  },
  "Category": {
    "Id": 201,
    "Value": "omnis",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 152
      }
    }
  },
  "Business": {
    "Id": 456,
    "Value": "aut",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 513
      }
    }
  },
  "Associate": {
    "AssociateId": 732,
    "Name": "Russel, Windler and Jenkins",
    "PersonId": 498,
    "Rank": 679,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 420,
    "FullName": "Grayson Barrows DDS",
    "FormalName": "Moore-Murphy",
    "Deleted": true,
    "EjUserId": 959,
    "UserName": "O'Keefe-Spinka",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 385
      }
    }
  },
  "Salutation": "ipsum",
  "ActiveInterests": 906,
  "SupportAssociate": {
    "AssociateId": 668,
    "Name": "Donnelly-Parisian",
    "PersonId": 662,
    "Rank": 182,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 59,
    "FullName": "Ona Crona",
    "FormalName": "McClure, Ullrich and Bednar",
    "Deleted": false,
    "EjUserId": 317,
    "UserName": "Krajcik, Hickle and Gutkowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize revolutionary eyeballs"
        },
        "FieldType": "System.Int32",
        "FieldLength": 606
      }
    }
  },
  "TicketPriority": {
    "Id": 114,
    "Value": "aut",
    "Tooltip": "reiciendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 369
      }
    }
  },
  "CustomerLanguage": {
    "Id": 617,
    "Value": "autem",
    "Tooltip": "tenetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 95
      }
    }
  },
  "DbiAgentId": 977,
  "DbiKey": "facere",
  "DbiLastModified": "2001-10-22T09:40:59.3566655+02:00",
  "DbiLastSyncronized": "1994-01-02T09:40:59.3566655+01:00",
  "SentInfo": 409,
  "ShowContactTickets": 430,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 140,
    "UserName": "Larson-McDermott",
    "PersonId": 92,
    "Rank": 367,
    "Tooltip": "modi",
    "UserGroupId": 946,
    "EjUserId": 605,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "est",
      "vero"
    ],
    "CanLogon": true,
    "RoleName": "Price Group",
    "RoleTooltip": "error",
    "UserGroupName": "Mueller-McClure",
    "UserGroupTooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 405
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "rem",
      "StrippedValue": "cum",
      "Description": "Streamlined high-level complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "cum",
      "Description": "Streamlined high-level complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Organized eco-centric framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "nobis",
      "Description": "Organized eco-centric framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "Source": 410,
  "ActiveErpLinks": 330,
  "ShipmentTypes": [
    {
      "Id": 739,
      "Name": "Windler, Wehner and Adams",
      "ToolTip": "Consequuntur nostrum.",
      "Deleted": true,
      "Rank": 543,
      "Type": "quam",
      "ColorBlock": 125,
      "IconHint": "assumenda",
      "Selected": true,
      "LastChanged": "2017-06-30T09:40:59.3566655+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "fuga",
      "Hidden": false,
      "FullName": "Dayna Tremblay",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 751
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 437,
      "Comment": "beatae",
      "Registered": "2019-06-07T09:40:59.3576655+02:00",
      "RegisteredAssociateId": 477,
      "Updated": "1995-07-03T09:40:59.3576655+02:00",
      "UpdatedAssociateId": 50,
      "LegalBaseId": 498,
      "LegalBaseKey": "est",
      "LegalBaseName": "Glover-Denesik",
      "ConsentPurposeId": 207,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Kilback Inc and Sons",
      "ConsentSourceId": 604,
      "ConsentSourceKey": "minima",
      "ConsentSourceName": "Carter, Schoen and Prosacco",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 43
        }
      }
    }
  ],
  "BounceEmails": [
    "helena@lind.ca",
    "fern@cristreichel.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Esperanza Kessler",
    "SuperOffice:2": "Miss Kayli Kihn"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "quaerat",
    "CustomFields2": "consectetur"
  },
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
      "FieldLength": 13
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```