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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 747,
  "Firstname": "America",
  "MiddleName": "Farrell Inc and Sons",
  "Lastname": "Altenwerth",
  "Mrmrs": "repellat",
  "Title": "tempore",
  "UpdatedDate": "2000-06-17T18:25:50.6826299+02:00",
  "CreatedDate": "2000-04-03T18:25:50.6826299+02:00",
  "BirthDate": "2011-05-25T18:25:50.6826299+02:00",
  "CreatedBy": {
    "AssociateId": 171,
    "Name": "Romaguera-Wyman",
    "PersonId": 910,
    "Rank": 519,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 896,
    "FullName": "Garry Bogan",
    "FormalName": "Reichert Inc and Sons",
    "Deleted": true,
    "EjUserId": 155,
    "UserName": "Rice, Bergnaum and Wilkinson"
  },
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "at",
      "Description": "Optimized next generation help-desk"
    },
    {
      "Value": "velit",
      "StrippedValue": "at",
      "Description": "Optimized next generation help-desk"
    }
  ],
  "Description": "Face to face holistic access",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "eos",
      "Description": "User-centric radical artificial intelligence"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "eos",
      "Description": "User-centric radical artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "nesciunt",
      "Description": "Persevering systematic adapter"
    },
    {
      "Value": "est",
      "StrippedValue": "nesciunt",
      "Description": "Persevering systematic adapter"
    }
  ],
  "MobilePhones": [
    {
      "Value": "unde",
      "StrippedValue": "fuga",
      "Description": "Open-source upward-trending analyzer"
    },
    {
      "Value": "unde",
      "StrippedValue": "fuga",
      "Description": "Open-source upward-trending analyzer"
    }
  ],
  "OfficePhones": [
    {
      "Value": "numquam",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled 6th generation utilisation"
    },
    {
      "Value": "numquam",
      "StrippedValue": "nisi",
      "Description": "Multi-channelled 6th generation utilisation"
    }
  ],
  "OtherPhones": [
    {
      "Value": "cum",
      "StrippedValue": "nihil",
      "Description": "Pre-emptive bifurcated database"
    },
    {
      "Value": "cum",
      "StrippedValue": "nihil",
      "Description": "Pre-emptive bifurcated database"
    }
  ],
  "Position": {
    "Id": 710,
    "Value": "vitae",
    "Tooltip": "reprehenderit"
  },
  "UpdatedBy": {
    "AssociateId": 755,
    "Name": "Jewess-Cartwright",
    "PersonId": 990,
    "Rank": 824,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 163,
    "FullName": "Makenzie White",
    "FormalName": "Daniel LLC",
    "Deleted": true,
    "EjUserId": 841,
    "UserName": "Kuhlman, Quigley and Champlin"
  },
  "Contact": {
    "ContactId": 790,
    "Name": "Durgan, Reynolds and Windler",
    "OrgNr": "1470124",
    "Department": "recontextualize cross-media communities",
    "URL": "http://www.example.com/",
    "City": "quia",
    "DirectPhone": "803-461-2108 x448",
    "AssociateId": 745,
    "CountryId": 439,
    "EmailAddress": "edison_paucek@schummkihn.name",
    "Kananame": "eos",
    "EmailAddressName": "ansel_cruickshank@jewess.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Charlene Kulas",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quisquam",
    "FullName": "Sheila Moore",
    "IsOwnerContact": false,
    "ActiveErpLinks": 247
  },
  "Country": {
    "CountryId": 261,
    "Name": "Renner-Bahringer",
    "CurrencyId": 671,
    "EnglishName": "Jakubowski LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Monitored intermediate migration",
    "OrgNrText": "636877",
    "InterAreaPrefix": "distinctio",
    "DialInPrefix": "voluptatem",
    "ZipPrefix": "perferendis",
    "DomainName": "Littel LLC",
    "AddressLayoutId": 643,
    "DomesticAddressLayoutId": 251,
    "ForeignAddressLayoutId": 135,
    "Rank": 262,
    "Tooltip": "perferendis",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 198,
      "Name": "DuBuque, Kuhlman and Orn",
      "ToolTip": "Dignissimos et quae tenetur officiis error illo.",
      "Deleted": true,
      "Rank": 357,
      "Type": "sequi",
      "ColorBlock": 995,
      "IconHint": "laborum",
      "Selected": false,
      "LastChanged": "2012-08-25T18:25:50.6856302+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "cumque",
      "Hidden": false,
      "FullName": "Jaylon Towne"
    }
  ],
  "PersonNumber": "481994",
  "FullName": "Clint Franecki",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "omnis",
      "Description": "Configurable multi-state budgetary management"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "omnis",
      "Description": "Configurable multi-state budgetary management"
    }
  ],
  "FormalName": "Kuhn-Gottlieb",
  "Address": {
    "Wgs84Latitude": 8960.106,
    "Wgs84Longitude": 4914.112,
    "LocalizedAddress": [
      [
        {
          "Name": "Gleason, Schowalter and Jacobi",
          "Value": "vero",
          "Tooltip": "id",
          "Label": "delectus",
          "ValueLength": 391,
          "AddressType": "omnis",
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
              "FieldLength": 128
            }
          }
        }
      ],
      [
        {
          "Name": "O'Reilly-Dicki",
          "Value": "nemo",
          "Tooltip": "autem",
          "Label": "est",
          "ValueLength": 463,
          "AddressType": "quia",
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
              "FieldLength": 265
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "a"
  },
  "Post3": "suscipit",
  "Post2": "iure",
  "Post1": "impedit",
  "Kanalname": "temporibus",
  "Kanafname": "fugit",
  "CorrespondingAssociate": {
    "AssociateId": 338,
    "Name": "Nicolas Inc and Sons",
    "PersonId": 741,
    "Rank": 492,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 9,
    "FullName": "Lina Stracke",
    "FormalName": "Considine Group",
    "Deleted": true,
    "EjUserId": 181,
    "UserName": "Franecki-Jakubowski"
  },
  "Category": {
    "Id": 539,
    "Value": "eveniet",
    "Tooltip": "non"
  },
  "Business": {
    "Id": 848,
    "Value": "non",
    "Tooltip": "nulla"
  },
  "Associate": {
    "AssociateId": 588,
    "Name": "Kulas Inc and Sons",
    "PersonId": 126,
    "Rank": 572,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 127,
    "FullName": "Nona Yost",
    "FormalName": "Runolfsson LLC",
    "Deleted": false,
    "EjUserId": 243,
    "UserName": "Nolan, Hills and Herman"
  },
  "Salutation": "impedit",
  "ActiveInterests": 800,
  "SupportAssociate": {
    "AssociateId": 135,
    "Name": "Jewess, Legros and Nolan",
    "PersonId": 981,
    "Rank": 859,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 333,
    "FullName": "Aileen Auer",
    "FormalName": "Towne LLC",
    "Deleted": false,
    "EjUserId": 123,
    "UserName": "Ryan Inc and Sons"
  },
  "TicketPriority": {
    "Id": 806,
    "Value": "id",
    "Tooltip": "error"
  },
  "CustomerLanguage": {
    "Id": 145,
    "Value": "rem",
    "Tooltip": "mollitia"
  },
  "DbiAgentId": 788,
  "DbiKey": "doloribus",
  "DbiLastModified": "1999-02-04T18:25:50.6876298+01:00",
  "DbiLastSyncronized": "2001-02-24T18:25:50.6876298+01:00",
  "SentInfo": 221,
  "ShowContactTickets": 192,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 497,
    "UserName": "Senger, Schultz and Kemmer",
    "PersonId": 105,
    "Rank": 658,
    "Tooltip": "mollitia",
    "UserGroupId": 756,
    "EjUserId": 941,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "et",
      "rerum"
    ],
    "CanLogon": false,
    "RoleName": "Schimmel-Kovacek",
    "RoleTooltip": "quo",
    "UserGroupName": "Pollich, Bayer and Rippin",
    "UserGroupTooltip": "eligendi"
  },
  "ChatEmails": [
    {
      "Value": "ex",
      "StrippedValue": "non",
      "Description": "Intuitive zero administration knowledge base"
    },
    {
      "Value": "ex",
      "StrippedValue": "non",
      "Description": "Intuitive zero administration knowledge base"
    }
  ],
  "InternetPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "provident",
      "Description": "Proactive impactful focus group"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "provident",
      "Description": "Proactive impactful focus group"
    }
  ],
  "Source": 547,
  "ActiveErpLinks": 205,
  "ShipmentTypes": [
    {
      "Id": 536,
      "Name": "Aufderhar-Cole",
      "ToolTip": "Quae eveniet enim.",
      "Deleted": true,
      "Rank": 718,
      "Type": "dolor",
      "ColorBlock": 921,
      "IconHint": "assumenda",
      "Selected": false,
      "LastChanged": "2007-08-31T18:25:50.6876298+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "fuga",
      "Hidden": false,
      "FullName": "Layne Boyer"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 111,
      "Comment": "rerum",
      "Registered": "1996-11-24T18:25:50.6886294+01:00",
      "RegisteredAssociateId": 163,
      "Updated": "1995-08-20T18:25:50.6886294+02:00",
      "UpdatedAssociateId": 74,
      "LegalBaseId": 170,
      "LegalBaseKey": "sequi",
      "LegalBaseName": "Raynor-Kirlin",
      "ConsentPurposeId": 389,
      "ConsentPurposeKey": "blanditiis",
      "ConsentPurposeName": "Schaden, Pouros and Fisher",
      "ConsentSourceId": 779,
      "ConsentSourceKey": "ut",
      "ConsentSourceName": "Skiles Inc and Sons"
    }
  ],
  "BounceEmails": [
    "cade.mayert@cole.com",
    "velma@gibsonrosenbaum.biz"
  ],
  "ActiveStatusMonitorId": 614,
  "UserDefinedFields": {
    "SuperOffice:1": "Willa Bernhard V",
    "SuperOffice:2": "Twila O'Hara"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "voluptate"
  }
}
```

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 304,
  "Firstname": "Gerard",
  "MiddleName": "White Group",
  "Lastname": "Hoppe",
  "Mrmrs": "incidunt",
  "Title": "dolorem",
  "UpdatedDate": "1997-11-14T18:25:50.6966306+01:00",
  "CreatedDate": "1994-07-15T18:25:50.6966306+02:00",
  "BirthDate": "1997-12-22T18:25:50.6966306+01:00",
  "CreatedBy": {
    "AssociateId": 892,
    "Name": "Pfeffer LLC",
    "PersonId": 523,
    "Rank": 419,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 801,
    "FullName": "Deshaun Treutel",
    "FormalName": "Wilkinson LLC",
    "Deleted": true,
    "EjUserId": 749,
    "UserName": "O'Conner-Price",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 260
      }
    }
  },
  "Emails": [
    {
      "Value": "quis",
      "StrippedValue": "officiis",
      "Description": "Seamless bi-directional standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 510
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "officiis",
      "Description": "Seamless bi-directional standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 510
        }
      }
    }
  ],
  "Description": "Organized local model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "temporibus",
      "StrippedValue": "qui",
      "Description": "Fundamental needs-based task-force",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "qui",
      "Description": "Fundamental needs-based task-force",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Multi-lateral incremental benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quia",
      "Description": "Multi-lateral incremental benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "optio",
      "StrippedValue": "repudiandae",
      "Description": "Face to face even-keeled paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 113
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "repudiandae",
      "Description": "Face to face even-keeled paradigm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 113
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "unde",
      "StrippedValue": "est",
      "Description": "Configurable context-sensitive knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "est",
      "Description": "Configurable context-sensitive knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quo",
      "StrippedValue": "et",
      "Description": "Implemented assymetric website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "et",
      "Description": "Implemented assymetric website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    }
  ],
  "Position": {
    "Id": 740,
    "Value": "quia",
    "Tooltip": "esse",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 686,
    "Name": "Haag Group",
    "PersonId": 803,
    "Rank": 264,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 579,
    "FullName": "Pasquale Boyer",
    "FormalName": "Shields-Williamson",
    "Deleted": false,
    "EjUserId": 673,
    "UserName": "Nicolas, Klocko and Lindgren",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 809
      }
    }
  },
  "Contact": {
    "ContactId": 750,
    "Name": "Dickinson-Schowalter",
    "OrgNr": "634494",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sint",
    "DirectPhone": "347-025-4758 x5628",
    "AssociateId": 861,
    "CountryId": 733,
    "EmailAddress": "noel.connelly@hackett.ca",
    "Kananame": "modi",
    "EmailAddressName": "harvey@ward.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Americo Steuber",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptate",
    "FullName": "Abigale Keebler",
    "IsOwnerContact": true,
    "ActiveErpLinks": 62,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 237
      }
    }
  },
  "Country": {
    "CountryId": 952,
    "Name": "Streich-Bradtke",
    "CurrencyId": 956,
    "EnglishName": "Purdy-Botsford",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Polarised solution-oriented matrix",
    "OrgNrText": "1204753",
    "InterAreaPrefix": "et",
    "DialInPrefix": "ut",
    "ZipPrefix": "fugiat",
    "DomainName": "Jacobson Group",
    "AddressLayoutId": 879,
    "DomesticAddressLayoutId": 735,
    "ForeignAddressLayoutId": 352,
    "Rank": 545,
    "Tooltip": "excepturi",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 189
      }
    }
  },
  "Interests": [
    {
      "Id": 987,
      "Name": "Wyman Inc and Sons",
      "ToolTip": "Omnis non voluptatum praesentium dignissimos doloremque.",
      "Deleted": true,
      "Rank": 559,
      "Type": "natus",
      "ColorBlock": 1001,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2017-02-14T18:25:50.6996298+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugiat",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Hannah Ferry",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "drive rich partnerships"
          },
          "FieldType": "System.String",
          "FieldLength": 369
        }
      }
    }
  ],
  "PersonNumber": "747617",
  "FullName": "Brooklyn Cummings",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "nulla",
      "StrippedValue": "autem",
      "Description": "Advanced logistical instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "autem",
      "Description": "Advanced logistical instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    }
  ],
  "FormalName": "Cremin Inc and Sons",
  "Address": {
    "Wgs84Latitude": 13473.065999999999,
    "Wgs84Longitude": 31086.146,
    "LocalizedAddress": [
      [
        {
          "Name": "Hegmann Inc and Sons",
          "Value": "voluptas",
          "Tooltip": "eaque",
          "Label": "saepe",
          "ValueLength": 166,
          "AddressType": "omnis",
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
              "FieldLength": 890
            }
          }
        }
      ],
      [
        {
          "Name": "Quigley, Padberg and Wilkinson",
          "Value": "nam",
          "Tooltip": "vero",
          "Label": "ea",
          "ValueLength": 764,
          "AddressType": "numquam",
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
              "FieldLength": 18
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 901
      }
    }
  },
  "Post3": "ipsam",
  "Post2": "quia",
  "Post1": "occaecati",
  "Kanalname": "soluta",
  "Kanafname": "modi",
  "CorrespondingAssociate": {
    "AssociateId": 723,
    "Name": "Cassin Group",
    "PersonId": 626,
    "Rank": 598,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 424,
    "FullName": "Valentine Willms",
    "FormalName": "Monahan-Towne",
    "Deleted": true,
    "EjUserId": 854,
    "UserName": "Glover Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 556
      }
    }
  },
  "Category": {
    "Id": 350,
    "Value": "id",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 77
      }
    }
  },
  "Business": {
    "Id": 298,
    "Value": "recusandae",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline e-business applications"
        },
        "FieldType": "System.String",
        "FieldLength": 897
      }
    }
  },
  "Associate": {
    "AssociateId": 356,
    "Name": "Lakin-Turner",
    "PersonId": 274,
    "Rank": 610,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 821,
    "FullName": "Annie Hudson",
    "FormalName": "Swaniawski Group",
    "Deleted": true,
    "EjUserId": 754,
    "UserName": "Kreiger Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 957
      }
    }
  },
  "Salutation": "praesentium",
  "ActiveInterests": 311,
  "SupportAssociate": {
    "AssociateId": 126,
    "Name": "Rempel LLC",
    "PersonId": 503,
    "Rank": 660,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 336,
    "FullName": "Matilde Gaylord",
    "FormalName": "Waters, Kozey and Hahn",
    "Deleted": false,
    "EjUserId": 483,
    "UserName": "Towne LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 77
      }
    }
  },
  "TicketPriority": {
    "Id": 896,
    "Value": "amet",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower user-centric infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  },
  "CustomerLanguage": {
    "Id": 569,
    "Value": "veniam",
    "Tooltip": "molestias",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "strategize one-to-one web-readiness"
        },
        "FieldType": "System.String",
        "FieldLength": 763
      }
    }
  },
  "DbiAgentId": 73,
  "DbiKey": "saepe",
  "DbiLastModified": "2012-06-29T18:25:50.7016297+02:00",
  "DbiLastSyncronized": "2010-05-28T18:25:50.7016297+02:00",
  "SentInfo": 712,
  "ShowContactTickets": 346,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 823,
    "UserName": "Runolfsdottir-Lebsack",
    "PersonId": 114,
    "Rank": 103,
    "Tooltip": "quo",
    "UserGroupId": 546,
    "EjUserId": 958,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "iure",
      "ullam"
    ],
    "CanLogon": false,
    "RoleName": "Haley, Upton and Mohr",
    "RoleTooltip": "corporis",
    "UserGroupName": "Stark, Langosh and Jones",
    "UserGroupTooltip": "vero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 159
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Versatile radical hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Versatile radical hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "tenetur",
      "StrippedValue": "autem",
      "Description": "Cross-group regional capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer bricks-and-clicks web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "autem",
      "Description": "Cross-group regional capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer bricks-and-clicks web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "Source": 916,
  "ActiveErpLinks": 12,
  "ShipmentTypes": [
    {
      "Id": 690,
      "Name": "Ledner Group",
      "ToolTip": "Beatae recusandae perferendis est velit sequi.",
      "Deleted": false,
      "Rank": 77,
      "Type": "quas",
      "ColorBlock": 935,
      "IconHint": "quam",
      "Selected": false,
      "LastChanged": "1997-05-17T18:25:50.7026335+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Oral Hermann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 570
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 57,
      "Comment": "est",
      "Registered": "2012-02-28T18:25:50.7026335+01:00",
      "RegisteredAssociateId": 149,
      "Updated": "2001-12-23T18:25:50.7026335+01:00",
      "UpdatedAssociateId": 144,
      "LegalBaseId": 191,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Quigley, Nader and Hickle",
      "ConsentPurposeId": 436,
      "ConsentPurposeKey": "ullam",
      "ConsentPurposeName": "Dicki, Boyle and Yundt",
      "ConsentSourceId": 20,
      "ConsentSourceKey": "rerum",
      "ConsentSourceName": "Klocko Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 964
        }
      }
    }
  ],
  "BounceEmails": [
    "gisselle_reichert@boehm.info",
    "dulce@swifteichmann.us"
  ],
  "ActiveStatusMonitorId": 228,
  "UserDefinedFields": {
    "SuperOffice:1": "1065337281",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "labore"
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
      "FieldLength": 183
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```