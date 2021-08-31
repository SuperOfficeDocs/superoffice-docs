---
title: SavePersonEntity
id: v1PersonAgent_SavePersonEntity
---

# SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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



| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 989,
  "Firstname": "Bailee",
  "MiddleName": "Gislason LLC",
  "Lastname": "Wiegand",
  "Mrmrs": "doloribus",
  "Title": "a",
  "UpdatedDate": "2007-01-30T14:58:04.6284605+01:00",
  "CreatedDate": "2004-01-06T14:58:04.6284605+01:00",
  "BirthDate": "2016-02-05T14:58:04.6284605+01:00",
  "CreatedBy": {
    "AssociateId": 63,
    "Name": "Sipes LLC",
    "PersonId": 425,
    "Rank": 197,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 848,
    "FullName": "Malinda Mayert MD",
    "FormalName": "Corwin-Kohler",
    "Deleted": true,
    "EjUserId": 625,
    "UserName": "Legros LLC"
  },
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "nulla",
      "Description": "Organized methodical access"
    },
    {
      "Value": "animi",
      "StrippedValue": "nulla",
      "Description": "Organized methodical access"
    }
  ],
  "Description": "Open-source analyzing orchestration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "enim",
      "Description": "Visionary multi-state utilisation"
    },
    {
      "Value": "sed",
      "StrippedValue": "enim",
      "Description": "Visionary multi-state utilisation"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "aliquam",
      "Description": "Virtual methodical approach"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "aliquam",
      "Description": "Virtual methodical approach"
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "placeat",
      "Description": "Public-key transitional functionalities"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "placeat",
      "Description": "Public-key transitional functionalities"
    }
  ],
  "OfficePhones": [
    {
      "Value": "similique",
      "StrippedValue": "incidunt",
      "Description": "Right-sized logistical middleware"
    },
    {
      "Value": "similique",
      "StrippedValue": "incidunt",
      "Description": "Right-sized logistical middleware"
    }
  ],
  "OtherPhones": [
    {
      "Value": "porro",
      "StrippedValue": "est",
      "Description": "Object-based secondary emulation"
    },
    {
      "Value": "porro",
      "StrippedValue": "est",
      "Description": "Object-based secondary emulation"
    }
  ],
  "Position": {
    "Id": 445,
    "Value": "quo",
    "Tooltip": "dolorum"
  },
  "UpdatedBy": {
    "AssociateId": 649,
    "Name": "Kuvalis, Nader and O'Conner",
    "PersonId": 626,
    "Rank": 273,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 175,
    "FullName": "Gisselle Schiller",
    "FormalName": "Mueller-Nader",
    "Deleted": false,
    "EjUserId": 84,
    "UserName": "Blanda LLC"
  },
  "Contact": {
    "ContactId": 347,
    "Name": "Funk LLC",
    "OrgNr": "1264231",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "expedita",
    "DirectPhone": "202-618-4547",
    "AssociateId": 354,
    "CountryId": 104,
    "EmailAddress": "rodger.quigley@okunevaschowalter.us",
    "Kananame": "quaerat",
    "EmailAddressName": "eldora.dooley@dachcorkery.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Guy Kohler",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Juston Rowe",
    "IsOwnerContact": true,
    "ActiveErpLinks": 704
  },
  "Country": {
    "CountryId": 79,
    "Name": "Reynolds-Goldner",
    "CurrencyId": 4,
    "EnglishName": "Ruecker LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Configurable real-time help-desk",
    "OrgNrText": "180433",
    "InterAreaPrefix": "dolore",
    "DialInPrefix": "sint",
    "ZipPrefix": "commodi",
    "DomainName": "Lowe, Goodwin and Klocko",
    "AddressLayoutId": 8,
    "DomesticAddressLayoutId": 816,
    "ForeignAddressLayoutId": 947,
    "Rank": 638,
    "Tooltip": "suscipit",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 178,
      "Name": "DuBuque-Breitenberg",
      "ToolTip": "Minima cupiditate enim.",
      "Deleted": true,
      "Rank": 98,
      "Type": "sapiente",
      "ColorBlock": 71,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2012-01-03T14:58:04.6304622+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Jeanie Corwin"
    }
  ],
  "PersonNumber": "818608",
  "FullName": "Jacynthe Bednar",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "User-centric bifurcated toolset"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "User-centric bifurcated toolset"
    }
  ],
  "FormalName": "Flatley-Padberg",
  "Address": {
    "Wgs84Latitude": 8305.1,
    "Wgs84Longitude": 16713.622,
    "LocalizedAddress": [
      [
        {
          "Name": "DuBuque-Bode",
          "Value": "tenetur",
          "Tooltip": "provident",
          "Label": "pariatur",
          "ValueLength": 237,
          "AddressType": "consectetur",
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
              "FieldLength": 817
            }
          }
        }
      ],
      [
        {
          "Name": "Kuhic Inc and Sons",
          "Value": "sit",
          "Tooltip": "sed",
          "Label": "ea",
          "ValueLength": 963,
          "AddressType": "alias",
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
              "FieldLength": 598
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "assumenda"
  },
  "Post3": "laudantium",
  "Post2": "rerum",
  "Post1": "illum",
  "Kanalname": "expedita",
  "Kanafname": "doloribus",
  "CorrespondingAssociate": {
    "AssociateId": 730,
    "Name": "Pfeffer, Kassulke and Kessler",
    "PersonId": 777,
    "Rank": 491,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 757,
    "FullName": "Mr. Keven Kub",
    "FormalName": "Ondricka, Reinger and Bednar",
    "Deleted": false,
    "EjUserId": 397,
    "UserName": "Harber, Barrows and Hagenes"
  },
  "Category": {
    "Id": 772,
    "Value": "aspernatur",
    "Tooltip": "sed"
  },
  "Business": {
    "Id": 808,
    "Value": "id",
    "Tooltip": "incidunt"
  },
  "Associate": {
    "AssociateId": 260,
    "Name": "Considine LLC",
    "PersonId": 360,
    "Rank": 465,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 15,
    "FullName": "Drew Labadie",
    "FormalName": "Homenick-Cremin",
    "Deleted": true,
    "EjUserId": 602,
    "UserName": "Medhurst-Vandervort"
  },
  "Salutation": "distinctio",
  "ActiveInterests": 119,
  "SupportAssociate": {
    "AssociateId": 673,
    "Name": "Hudson-Bechtelar",
    "PersonId": 987,
    "Rank": 491,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 339,
    "FullName": "Kaitlin Larson II",
    "FormalName": "Gutkowski, Leuschke and Jaskolski",
    "Deleted": false,
    "EjUserId": 17,
    "UserName": "Kuhn, Ullrich and Nienow"
  },
  "TicketPriority": {
    "Id": 273,
    "Value": "omnis",
    "Tooltip": "corporis"
  },
  "CustomerLanguage": {
    "Id": 822,
    "Value": "rerum",
    "Tooltip": "accusantium"
  },
  "DbiAgentId": 775,
  "DbiKey": "quasi",
  "DbiLastModified": "1999-08-22T14:58:04.633464+02:00",
  "DbiLastSyncronized": "2010-01-27T14:58:04.633464+01:00",
  "SentInfo": 150,
  "ShowContactTickets": 805,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 507,
    "UserName": "Fay Group",
    "PersonId": 634,
    "Rank": 975,
    "Tooltip": "dolores",
    "UserGroupId": 56,
    "EjUserId": 503,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ullam",
      "blanditiis"
    ],
    "CanLogon": false,
    "RoleName": "Weber, Wehner and Gislason",
    "RoleTooltip": "hic",
    "UserGroupName": "Heaney Group",
    "UserGroupTooltip": "molestias"
  },
  "ChatEmails": [
    {
      "Value": "incidunt",
      "StrippedValue": "maiores",
      "Description": "Optimized composite matrix"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "maiores",
      "Description": "Optimized composite matrix"
    }
  ],
  "InternetPhones": [
    {
      "Value": "id",
      "StrippedValue": "molestiae",
      "Description": "Inverse logistical alliance"
    },
    {
      "Value": "id",
      "StrippedValue": "molestiae",
      "Description": "Inverse logistical alliance"
    }
  ],
  "Source": 169,
  "ActiveErpLinks": 767,
  "ShipmentTypes": [
    {
      "Id": 822,
      "Name": "Abernathy Group",
      "ToolTip": "Ut ipsam accusantium corrupti non.",
      "Deleted": false,
      "Rank": 249,
      "Type": "sequi",
      "ColorBlock": 891,
      "IconHint": "eos",
      "Selected": true,
      "LastChanged": "2016-02-15T14:58:04.633464+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "eos",
      "Hidden": true,
      "FullName": "Claudine Reichel"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 350,
      "Comment": "occaecati",
      "Registered": "2011-11-18T14:58:04.634462+01:00",
      "RegisteredAssociateId": 225,
      "Updated": "1999-08-24T14:58:04.634462+02:00",
      "UpdatedAssociateId": 188,
      "LegalBaseId": 196,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Veum, Crooks and Volkman",
      "ConsentPurposeId": 713,
      "ConsentPurposeKey": "sit",
      "ConsentPurposeName": "Heller, Keeling and McClure",
      "ConsentSourceId": 518,
      "ConsentSourceKey": "ad",
      "ConsentSourceName": "Smitham Inc and Sons"
    }
  ],
  "BounceEmails": [
    "elmer@mante.uk",
    "vivienne_wisoky@haley.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kaycee Bauch",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "et"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 549,
  "Firstname": "Tiara",
  "MiddleName": "O'Reilly, Runolfsdottir and Langosh",
  "Lastname": "Doyle",
  "Mrmrs": "omnis",
  "Title": "repudiandae",
  "UpdatedDate": "2009-03-07T14:58:04.6424622+01:00",
  "CreatedDate": "2010-01-31T14:58:04.6424622+01:00",
  "BirthDate": "2019-09-29T14:58:04.6424622+02:00",
  "CreatedBy": {
    "AssociateId": 663,
    "Name": "Quigley-Langworth",
    "PersonId": 830,
    "Rank": 30,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Winona O'Connell",
    "FormalName": "Eichmann-Kerluke",
    "Deleted": false,
    "EjUserId": 735,
    "UserName": "Gusikowski, Langworth and Haley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 218
      }
    }
  },
  "Emails": [
    {
      "Value": "vero",
      "StrippedValue": "magni",
      "Description": "Cross-group asynchronous time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "magni",
      "Description": "Cross-group asynchronous time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 108
        }
      }
    }
  ],
  "Description": "User-friendly grid-enabled conglomeration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "maxime",
      "Description": "Seamless systemic matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver e-business interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 556
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "maxime",
      "Description": "Seamless systemic matrix",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver e-business interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 556
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "commodi",
      "StrippedValue": "porro",
      "Description": "Polarised 3rd generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "porro",
      "Description": "Polarised 3rd generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quis",
      "StrippedValue": "cupiditate",
      "Description": "Fundamental systematic encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "cupiditate",
      "Description": "Fundamental systematic encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "aliquid",
      "Description": "Intuitive value-added throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "aliquid",
      "Description": "Intuitive value-added throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "nulla",
      "Description": "Enterprise-wide stable complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 485
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "nulla",
      "Description": "Enterprise-wide stable complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 485
        }
      }
    }
  ],
  "Position": {
    "Id": 918,
    "Value": "in",
    "Tooltip": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 930
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 140,
    "Name": "Miller-Herman",
    "PersonId": 565,
    "Rank": 701,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 985,
    "FullName": "Manuela Hand",
    "FormalName": "Kris LLC",
    "Deleted": true,
    "EjUserId": 489,
    "UserName": "Kling-Klocko",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 530
      }
    }
  },
  "Contact": {
    "ContactId": 784,
    "Name": "Rutherford Inc and Sons",
    "OrgNr": "720628",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "in",
    "DirectPhone": "(128)245-5656 x7550",
    "AssociateId": 765,
    "CountryId": 192,
    "EmailAddress": "ana@konopelskipfeffer.com",
    "Kananame": "dolorem",
    "EmailAddressName": "hortense.klein@schultz.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jennyfer Gibson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "incidunt",
    "FullName": "Aubree Torphy PhD",
    "IsOwnerContact": false,
    "ActiveErpLinks": 722,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 703
      }
    }
  },
  "Country": {
    "CountryId": 678,
    "Name": "Hessel-Swaniawski",
    "CurrencyId": 853,
    "EnglishName": "Brekke-Altenwerth",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Visionary assymetric capability",
    "OrgNrText": "599061",
    "InterAreaPrefix": "consequuntur",
    "DialInPrefix": "illum",
    "ZipPrefix": "adipisci",
    "DomainName": "Bins, Sipes and Marquardt",
    "AddressLayoutId": 963,
    "DomesticAddressLayoutId": 89,
    "ForeignAddressLayoutId": 967,
    "Rank": 548,
    "Tooltip": "non",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage bricks-and-clicks schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 928
      }
    }
  },
  "Interests": [
    {
      "Id": 944,
      "Name": "Adams, Nienow and Kris",
      "ToolTip": "Odit vitae impedit.",
      "Deleted": false,
      "Rank": 807,
      "Type": "ex",
      "ColorBlock": 905,
      "IconHint": "sint",
      "Selected": true,
      "LastChanged": "2004-06-10T14:58:04.6444635+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Ms. Arlo Kohler",
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
    }
  ],
  "PersonNumber": "339296",
  "FullName": "Scot Bradtke",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "vel",
      "Description": "Virtual optimal software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "vel",
      "Description": "Virtual optimal software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "FormalName": "Braun Group",
  "Address": {
    "Wgs84Latitude": 7179.994,
    "Wgs84Longitude": 16462.902,
    "LocalizedAddress": [
      [
        {
          "Name": "Zemlak Group",
          "Value": "in",
          "Tooltip": "non",
          "Label": "et",
          "ValueLength": 624,
          "AddressType": "soluta",
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
              "FieldLength": 39
            }
          }
        }
      ],
      [
        {
          "Name": "Hermiston LLC",
          "Value": "voluptates",
          "Tooltip": "tempore",
          "Label": "at",
          "ValueLength": 781,
          "AddressType": "expedita",
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
              "FieldLength": 108
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 834
      }
    }
  },
  "Post3": "aliquid",
  "Post2": "neque",
  "Post1": "culpa",
  "Kanalname": "voluptatem",
  "Kanafname": "et",
  "CorrespondingAssociate": {
    "AssociateId": 679,
    "Name": "Abernathy, Rolfson and Bode",
    "PersonId": 620,
    "Rank": 450,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 607,
    "FullName": "Florencio Ferry PhD",
    "FormalName": "Hahn, Labadie and Bogan",
    "Deleted": true,
    "EjUserId": 849,
    "UserName": "Johnson-Pollich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 514
      }
    }
  },
  "Category": {
    "Id": 816,
    "Value": "mollitia",
    "Tooltip": "perspiciatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 949
      }
    }
  },
  "Business": {
    "Id": 966,
    "Value": "fuga",
    "Tooltip": "exercitationem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 433
      }
    }
  },
  "Associate": {
    "AssociateId": 997,
    "Name": "Hand, Ruecker and Gleichner",
    "PersonId": 676,
    "Rank": 179,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 453,
    "FullName": "Thelma Leannon",
    "FormalName": "Weber-Block",
    "Deleted": false,
    "EjUserId": 155,
    "UserName": "Miller-Cronin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 351
      }
    }
  },
  "Salutation": "praesentium",
  "ActiveInterests": 412,
  "SupportAssociate": {
    "AssociateId": 553,
    "Name": "Feeney, Koelpin and Hyatt",
    "PersonId": 565,
    "Rank": 156,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 925,
    "FullName": "Jarvis Wuckert",
    "FormalName": "Larson-Nader",
    "Deleted": true,
    "EjUserId": 505,
    "UserName": "Prohaska Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 832
      }
    }
  },
  "TicketPriority": {
    "Id": 838,
    "Value": "blanditiis",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 668
      }
    }
  },
  "CustomerLanguage": {
    "Id": 348,
    "Value": "pariatur",
    "Tooltip": "a",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 685
      }
    }
  },
  "DbiAgentId": 231,
  "DbiKey": "quia",
  "DbiLastModified": "2016-10-16T14:58:04.6474607+02:00",
  "DbiLastSyncronized": "2018-05-06T14:58:04.6474607+02:00",
  "SentInfo": 349,
  "ShowContactTickets": 351,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 979,
    "UserName": "Quitzon LLC",
    "PersonId": 688,
    "Rank": 200,
    "Tooltip": "similique",
    "UserGroupId": 729,
    "EjUserId": 809,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "dicta",
      "veniam"
    ],
    "CanLogon": false,
    "RoleName": "Corwin Inc and Sons",
    "RoleTooltip": "occaecati",
    "UserGroupName": "Sawayn-Wilderman",
    "UserGroupTooltip": "voluptate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 660
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "laborum",
      "Description": "Down-sized exuding throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "laborum",
      "Description": "Down-sized exuding throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "perferendis",
      "Description": "Reverse-engineered methodical initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "perferendis",
      "Description": "Reverse-engineered methodical initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 972
        }
      }
    }
  ],
  "Source": 48,
  "ActiveErpLinks": 567,
  "ShipmentTypes": [
    {
      "Id": 787,
      "Name": "Little-Rosenbaum",
      "ToolTip": "Minima reprehenderit.",
      "Deleted": true,
      "Rank": 862,
      "Type": "culpa",
      "ColorBlock": 625,
      "IconHint": "rem",
      "Selected": false,
      "LastChanged": "1997-02-11T14:58:04.6484614+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatibus",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Emelie Franecki",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 224,
      "Comment": "autem",
      "Registered": "2014-09-07T14:58:04.6494606+02:00",
      "RegisteredAssociateId": 64,
      "Updated": "1998-01-17T14:58:04.6494606+01:00",
      "UpdatedAssociateId": 829,
      "LegalBaseId": 784,
      "LegalBaseKey": "amet",
      "LegalBaseName": "Hodkiewicz LLC",
      "ConsentPurposeId": 889,
      "ConsentPurposeKey": "neque",
      "ConsentPurposeName": "Hudson, Ullrich and Champlin",
      "ConsentSourceId": 985,
      "ConsentSourceKey": "molestiae",
      "ConsentSourceName": "Kreiger, Runolfsdottir and Wintheiser",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer transparent models"
          },
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "BounceEmails": [
    "jacquelyn@hane.name",
    "mossie.pfannerstill@brown.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Julio Parker",
    "SuperOffice:2": "Tate Ryan"
  },
  "ExtraFields": {
    "ExtraFields1": "eveniet",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "voluptates"
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
      "FieldLength": 833
    }
  }
}
```