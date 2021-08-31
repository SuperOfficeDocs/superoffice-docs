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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 198,
  "Firstname": "Isadore",
  "MiddleName": "Rosenbaum Group",
  "Lastname": "Hoppe",
  "Mrmrs": "amet",
  "Title": "velit",
  "UpdatedDate": "1998-01-30T15:05:42.3146715+01:00",
  "CreatedDate": "2003-06-09T15:05:42.3146715+02:00",
  "BirthDate": "2017-09-23T15:05:42.3146715+02:00",
  "CreatedBy": {
    "AssociateId": 502,
    "Name": "Brown, Goodwin and McDermott",
    "PersonId": 213,
    "Rank": 405,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 232,
    "FullName": "Theodora Schumm",
    "FormalName": "Reilly-Hudson",
    "Deleted": true,
    "EjUserId": 566,
    "UserName": "Buckridge, Harber and Reichert"
  },
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "autem",
      "Description": "Self-enabling non-volatile structure"
    },
    {
      "Value": "fuga",
      "StrippedValue": "autem",
      "Description": "Self-enabling non-volatile structure"
    }
  ],
  "Description": "Multi-channelled systematic circuit",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "assumenda",
      "Description": "Customer-focused tertiary throughput"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "assumenda",
      "Description": "Customer-focused tertiary throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "rerum",
      "Description": "Streamlined actuating knowledge base"
    },
    {
      "Value": "maxime",
      "StrippedValue": "rerum",
      "Description": "Streamlined actuating knowledge base"
    }
  ],
  "MobilePhones": [
    {
      "Value": "laudantium",
      "StrippedValue": "quaerat",
      "Description": "Focused neutral algorithm"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "quaerat",
      "Description": "Focused neutral algorithm"
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Assimilated stable matrix"
    },
    {
      "Value": "aut",
      "StrippedValue": "et",
      "Description": "Assimilated stable matrix"
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "autem",
      "Description": "Reduced radical software"
    },
    {
      "Value": "in",
      "StrippedValue": "autem",
      "Description": "Reduced radical software"
    }
  ],
  "Position": {
    "Id": 18,
    "Value": "fuga",
    "Tooltip": "tempore"
  },
  "UpdatedBy": {
    "AssociateId": 26,
    "Name": "McDermott, Cruickshank and Lueilwitz",
    "PersonId": 795,
    "Rank": 488,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 963,
    "FullName": "Keira Kshlerin Sr.",
    "FormalName": "Herman, Hand and Buckridge",
    "Deleted": true,
    "EjUserId": 58,
    "UserName": "Dickens-Cummings"
  },
  "Contact": {
    "ContactId": 127,
    "Name": "Boehm-Gusikowski",
    "OrgNr": "749690",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "615-707-4077 x5272",
    "AssociateId": 633,
    "CountryId": 29,
    "EmailAddress": "jammie_vonrueden@parisianolson.uk",
    "Kananame": "voluptatibus",
    "EmailAddressName": "chyna.robel@ortizwilkinson.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Van Fahey",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "enim",
    "FullName": "Katarina Balistreri",
    "IsOwnerContact": false,
    "ActiveErpLinks": 368
  },
  "Country": {
    "CountryId": 555,
    "Name": "Rosenbaum, Schumm and Ortiz",
    "CurrencyId": 702,
    "EnglishName": "Doyle-Sawayn",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Function-based 24/7 workforce",
    "OrgNrText": "683495",
    "InterAreaPrefix": "quasi",
    "DialInPrefix": "commodi",
    "ZipPrefix": "aspernatur",
    "DomainName": "Welch Inc and Sons",
    "AddressLayoutId": 880,
    "DomesticAddressLayoutId": 455,
    "ForeignAddressLayoutId": 681,
    "Rank": 802,
    "Tooltip": "velit",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 372,
      "Name": "Daugherty-Grimes",
      "ToolTip": "Voluptatem modi saepe sint vel eum autem.",
      "Deleted": false,
      "Rank": 632,
      "Type": "qui",
      "ColorBlock": 436,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2018-08-15T15:05:42.3176673+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "beatae",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Shanelle Hettinger"
    }
  ],
  "PersonNumber": "1889969",
  "FullName": "Abner Lemke DVM",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "magnam",
      "Description": "Switchable local paradigm"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "magnam",
      "Description": "Switchable local paradigm"
    }
  ],
  "FormalName": "Beer, O'Keefe and Wilkinson",
  "Address": {
    "Wgs84Latitude": 19835.086,
    "Wgs84Longitude": 7675.166,
    "LocalizedAddress": [
      [
        {
          "Name": "Heidenreich, Abbott and Conn",
          "Value": "excepturi",
          "Tooltip": "ipsum",
          "Label": "unde",
          "ValueLength": 346,
          "AddressType": "non",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "seize virtual bandwidth"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 759
            }
          }
        }
      ],
      [
        {
          "Name": "Heller Group",
          "Value": "molestias",
          "Tooltip": "quaerat",
          "Label": "rerum",
          "ValueLength": 926,
          "AddressType": "maxime",
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
              "FieldLength": 913
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ab"
  },
  "Post3": "quasi",
  "Post2": "est",
  "Post1": "sunt",
  "Kanalname": "quos",
  "Kanafname": "reiciendis",
  "CorrespondingAssociate": {
    "AssociateId": 457,
    "Name": "Bartell-Wunsch",
    "PersonId": 199,
    "Rank": 652,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 85,
    "FullName": "Megane Mills",
    "FormalName": "Schmeler-Sauer",
    "Deleted": true,
    "EjUserId": 260,
    "UserName": "Will-Vandervort"
  },
  "Category": {
    "Id": 590,
    "Value": "neque",
    "Tooltip": "vitae"
  },
  "Business": {
    "Id": 848,
    "Value": "perferendis",
    "Tooltip": "sed"
  },
  "Associate": {
    "AssociateId": 766,
    "Name": "Wisozk, Konopelski and Braun",
    "PersonId": 715,
    "Rank": 179,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 916,
    "FullName": "Vernon Collins",
    "FormalName": "Kohler-Boehm",
    "Deleted": false,
    "EjUserId": 539,
    "UserName": "Hagenes, Champlin and Rogahn"
  },
  "Salutation": "et",
  "ActiveInterests": 662,
  "SupportAssociate": {
    "AssociateId": 868,
    "Name": "Buckridge Group",
    "PersonId": 146,
    "Rank": 838,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 861,
    "FullName": "Valentine Pouros",
    "FormalName": "Conroy LLC",
    "Deleted": true,
    "EjUserId": 844,
    "UserName": "Parker, Adams and Barrows"
  },
  "TicketPriority": {
    "Id": 373,
    "Value": "voluptas",
    "Tooltip": "voluptatum"
  },
  "CustomerLanguage": {
    "Id": 645,
    "Value": "quidem",
    "Tooltip": "ut"
  },
  "DbiAgentId": 604,
  "DbiKey": "nulla",
  "DbiLastModified": "1996-10-29T15:05:42.3196673+01:00",
  "DbiLastSyncronized": "2005-11-28T15:05:42.3196673+01:00",
  "SentInfo": 552,
  "ShowContactTickets": 973,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 319,
    "UserName": "Yundt, Kreiger and Skiles",
    "PersonId": 134,
    "Rank": 233,
    "Tooltip": "et",
    "UserGroupId": 745,
    "EjUserId": 116,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "sit",
      "quo"
    ],
    "CanLogon": false,
    "RoleName": "Bauch-Watsica",
    "RoleTooltip": "rerum",
    "UserGroupName": "Lakin Group",
    "UserGroupTooltip": "ut"
  },
  "ChatEmails": [
    {
      "Value": "modi",
      "StrippedValue": "asperiores",
      "Description": "Multi-lateral systemic synergy"
    },
    {
      "Value": "modi",
      "StrippedValue": "asperiores",
      "Description": "Multi-lateral systemic synergy"
    }
  ],
  "InternetPhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "necessitatibus",
      "Description": "Seamless modular utilisation"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "necessitatibus",
      "Description": "Seamless modular utilisation"
    }
  ],
  "Source": 11,
  "ActiveErpLinks": 15,
  "ShipmentTypes": [
    {
      "Id": 65,
      "Name": "Dietrich-Sipes",
      "ToolTip": "Temporibus aut aut beatae.",
      "Deleted": false,
      "Rank": 39,
      "Type": "quis",
      "ColorBlock": 837,
      "IconHint": "quisquam",
      "Selected": true,
      "LastChanged": "2000-03-09T15:05:42.3206764+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "placeat",
      "Hidden": false,
      "FullName": "Mr. Reggie Nikolaus"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 798,
      "Comment": "quo",
      "Registered": "2010-06-15T15:05:42.3206764+02:00",
      "RegisteredAssociateId": 955,
      "Updated": "2012-02-08T15:05:42.3206764+01:00",
      "UpdatedAssociateId": 933,
      "LegalBaseId": 96,
      "LegalBaseKey": "similique",
      "LegalBaseName": "Waters, Klocko and Eichmann",
      "ConsentPurposeId": 227,
      "ConsentPurposeKey": "hic",
      "ConsentPurposeName": "Donnelly, Zemlak and Daugherty",
      "ConsentSourceId": 566,
      "ConsentSourceKey": "cum",
      "ConsentSourceName": "Zieme, Ruecker and Morissette"
    }
  ],
  "BounceEmails": [
    "sarah@pagac.com",
    "abagail@bradtkeboehm.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1591807192",
    "SuperOffice:2": "327860447"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "sed"
  }
}
```

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 4,
  "Firstname": "Travis",
  "MiddleName": "Legros LLC",
  "Lastname": "Moore",
  "Mrmrs": "deleniti",
  "Title": "atque",
  "UpdatedDate": "1999-10-03T15:05:42.3296722+02:00",
  "CreatedDate": "2006-02-14T15:05:42.3296722+01:00",
  "BirthDate": "2015-05-20T15:05:42.3296722+02:00",
  "CreatedBy": {
    "AssociateId": 775,
    "Name": "Berge, Botsford and Koss",
    "PersonId": 76,
    "Rank": 24,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 470,
    "FullName": "Cristina Harris",
    "FormalName": "Hilpert Group",
    "Deleted": false,
    "EjUserId": 807,
    "UserName": "Von Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 138
      }
    }
  },
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "aliquam",
      "Description": "Advanced user-facing matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "aliquam",
      "Description": "Advanced user-facing matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Description": "Universal bifurcated groupware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "placeat",
      "Description": "Streamlined dedicated emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale wireless methodologies"
          },
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "placeat",
      "Description": "Streamlined dedicated emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "scale wireless methodologies"
          },
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Fundamental mission-critical monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Fundamental mission-critical monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ea",
      "StrippedValue": "quasi",
      "Description": "Focused solution-oriented interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quasi",
      "Description": "Focused solution-oriented interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 748
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "maiores",
      "StrippedValue": "aut",
      "Description": "Digitized scalable conglomeration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "aut",
      "Description": "Digitized scalable conglomeration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "facere",
      "Description": "Digitized scalable projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "facere",
      "Description": "Digitized scalable projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "Position": {
    "Id": 218,
    "Value": "at",
    "Tooltip": "atque",
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
  "UpdatedBy": {
    "AssociateId": 562,
    "Name": "Gutmann Inc and Sons",
    "PersonId": 340,
    "Rank": 205,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 197,
    "FullName": "Arnold Medhurst",
    "FormalName": "Turcotte LLC",
    "Deleted": true,
    "EjUserId": 545,
    "UserName": "Reichel-McKenzie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 665
      }
    }
  },
  "Contact": {
    "ContactId": 771,
    "Name": "Bartell, Grimes and Hane",
    "OrgNr": "996809",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "non",
    "DirectPhone": "573.833.5182",
    "AssociateId": 624,
    "CountryId": 719,
    "EmailAddress": "gerson.glover@macejkovic.co.uk",
    "Kananame": "omnis",
    "EmailAddressName": "keven.johnson@leannon.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Desiree Kshlerin IV",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "modi",
    "FullName": "Makayla Hessel I",
    "IsOwnerContact": false,
    "ActiveErpLinks": 740,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "Country": {
    "CountryId": 84,
    "Name": "Turner, Collier and Hamill",
    "CurrencyId": 357,
    "EnglishName": "Kiehn Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Stand-alone encompassing software",
    "OrgNrText": "1511042",
    "InterAreaPrefix": "aspernatur",
    "DialInPrefix": "ut",
    "ZipPrefix": "consequatur",
    "DomainName": "Jenkins LLC",
    "AddressLayoutId": 203,
    "DomesticAddressLayoutId": 142,
    "ForeignAddressLayoutId": 612,
    "Rank": 202,
    "Tooltip": "incidunt",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "strategize frictionless e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Interests": [
    {
      "Id": 658,
      "Name": "Schowalter-Waters",
      "ToolTip": "Iusto explicabo.",
      "Deleted": false,
      "Rank": 289,
      "Type": "nihil",
      "ColorBlock": 968,
      "IconHint": "ea",
      "Selected": true,
      "LastChanged": "2013-11-18T15:05:42.3316673+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nulla",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Melvina Crist",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 662
        }
      }
    }
  ],
  "PersonNumber": "647402",
  "FullName": "Layla Balistreri IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "adipisci",
      "StrippedValue": "autem",
      "Description": "Fully-configurable systematic interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "autem",
      "Description": "Fully-configurable systematic interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "FormalName": "Shanahan, Nikolaus and Kshlerin",
  "Address": {
    "Wgs84Latitude": 20913.182,
    "Wgs84Longitude": 24429.53,
    "LocalizedAddress": [
      [
        {
          "Name": "Ondricka, Nitzsche and O'Keefe",
          "Value": "dolorem",
          "Tooltip": "iusto",
          "Label": "et",
          "ValueLength": 846,
          "AddressType": "itaque",
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
              "FieldLength": 653
            }
          }
        }
      ],
      [
        {
          "Name": "Bergstrom, Hoppe and Connelly",
          "Value": "vel",
          "Tooltip": "maxime",
          "Label": "fugiat",
          "ValueLength": 401,
          "AddressType": "possimus",
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
              "FieldLength": 646
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  "Post3": "hic",
  "Post2": "consectetur",
  "Post1": "velit",
  "Kanalname": "exercitationem",
  "Kanafname": "aut",
  "CorrespondingAssociate": {
    "AssociateId": 714,
    "Name": "Leannon-Klein",
    "PersonId": 276,
    "Rank": 712,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 259,
    "FullName": "Mr. Sim Pouros",
    "FormalName": "Ratke, Connelly and Hayes",
    "Deleted": true,
    "EjUserId": 283,
    "UserName": "Champlin-Reichert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 804
      }
    }
  },
  "Category": {
    "Id": 558,
    "Value": "quam",
    "Tooltip": "corrupti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 38
      }
    }
  },
  "Business": {
    "Id": 493,
    "Value": "quis",
    "Tooltip": "nostrum",
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
  "Associate": {
    "AssociateId": 592,
    "Name": "Dooley LLC",
    "PersonId": 687,
    "Rank": 274,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 389,
    "FullName": "Rachael Hilll",
    "FormalName": "Stamm, Upton and Leannon",
    "Deleted": true,
    "EjUserId": 184,
    "UserName": "Miller, Crooks and Waters",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 321
      }
    }
  },
  "Salutation": "alias",
  "ActiveInterests": 992,
  "SupportAssociate": {
    "AssociateId": 907,
    "Name": "Hamill, Gaylord and Waelchi",
    "PersonId": 371,
    "Rank": 604,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 60,
    "FullName": "Garett Marquardt",
    "FormalName": "Fay, Casper and Thiel",
    "Deleted": false,
    "EjUserId": 412,
    "UserName": "Grimes, Crist and Purdy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 44
      }
    }
  },
  "TicketPriority": {
    "Id": 797,
    "Value": "tenetur",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 488
      }
    }
  },
  "CustomerLanguage": {
    "Id": 114,
    "Value": "voluptatum",
    "Tooltip": "odio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 90
      }
    }
  },
  "DbiAgentId": 789,
  "DbiKey": "quia",
  "DbiLastModified": "2009-05-21T15:05:42.3346746+02:00",
  "DbiLastSyncronized": "2018-12-15T15:05:42.3346746+01:00",
  "SentInfo": 442,
  "ShowContactTickets": 450,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 224,
    "UserName": "Nienow-Moore",
    "PersonId": 958,
    "Rank": 493,
    "Tooltip": "natus",
    "UserGroupId": 287,
    "EjUserId": 896,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ut",
      "sunt"
    ],
    "CanLogon": true,
    "RoleName": "Anderson, Stiedemann and Bayer",
    "RoleTooltip": "voluptas",
    "UserGroupName": "Carter Inc and Sons",
    "UserGroupTooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 366
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "vitae",
      "StrippedValue": "laboriosam",
      "Description": "Synergized bottom-line strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "laboriosam",
      "Description": "Synergized bottom-line strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "magni",
      "StrippedValue": "aut",
      "Description": "Optimized zero administration definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "aut",
      "Description": "Optimized zero administration definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    }
  ],
  "Source": 404,
  "ActiveErpLinks": 487,
  "ShipmentTypes": [
    {
      "Id": 896,
      "Name": "Larkin-Little",
      "ToolTip": "Pariatur voluptatum est itaque provident nobis.",
      "Deleted": true,
      "Rank": 159,
      "Type": "eius",
      "ColorBlock": 2,
      "IconHint": "at",
      "Selected": true,
      "LastChanged": "1999-06-23T15:05:42.3356682+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Mara Kulas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 679,
      "Comment": "dignissimos",
      "Registered": "2007-01-05T15:05:42.3356682+01:00",
      "RegisteredAssociateId": 640,
      "Updated": "2012-10-02T15:05:42.3356682+02:00",
      "UpdatedAssociateId": 412,
      "LegalBaseId": 681,
      "LegalBaseKey": "voluptatem",
      "LegalBaseName": "Miller Inc and Sons",
      "ConsentPurposeId": 664,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "Beatty Group",
      "ConsentSourceId": 236,
      "ConsentSourceKey": "deserunt",
      "ConsentSourceName": "Reichel Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "BounceEmails": [
    "trinity.funk@russel.biz",
    "karina@oconnellbechtelar.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Imani Reynolds DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "minus"
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
      "FieldType": "System.String",
      "FieldLength": 348
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```