---
title: POST Agents/Person/SavePersonEntity
id: v1PersonAgent_SavePersonEntity
---

# POST Agents/Person/SavePersonEntity

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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 853,
  "Firstname": "Zackary",
  "MiddleName": "Marks-Stracke",
  "Lastname": "Blick",
  "Mrmrs": "eum",
  "Title": "est",
  "UpdatedDate": "2009-02-18T18:28:49.5490875+01:00",
  "CreatedDate": "2011-03-26T18:28:49.5490875+01:00",
  "BirthDate": "1995-08-13T18:28:49.5490875+02:00",
  "CreatedBy": {
    "AssociateId": 309,
    "Name": "Vandervort, Sipes and Zboncak",
    "PersonId": 351,
    "Rank": 339,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 635,
    "FullName": "Kendra Heidenreich II",
    "FormalName": "Ledner, Zulauf and Bins",
    "Deleted": false,
    "EjUserId": 18,
    "UserName": "Towne, Kuvalis and Murphy"
  },
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "totam",
      "Description": "Compatible well-modulated Graphic Interface"
    },
    {
      "Value": "est",
      "StrippedValue": "totam",
      "Description": "Compatible well-modulated Graphic Interface"
    }
  ],
  "Description": "Synergistic secondary knowledge base",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aut",
      "StrippedValue": "cum",
      "Description": "Self-enabling neutral protocol"
    },
    {
      "Value": "aut",
      "StrippedValue": "cum",
      "Description": "Self-enabling neutral protocol"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "ullam",
      "Description": "Re-contextualized web-enabled moratorium"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ullam",
      "Description": "Re-contextualized web-enabled moratorium"
    }
  ],
  "MobilePhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "possimus",
      "Description": "User-centric encompassing solution"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "possimus",
      "Description": "User-centric encompassing solution"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sed",
      "StrippedValue": "cumque",
      "Description": "User-friendly intermediate task-force"
    },
    {
      "Value": "sed",
      "StrippedValue": "cumque",
      "Description": "User-friendly intermediate task-force"
    }
  ],
  "OtherPhones": [
    {
      "Value": "labore",
      "StrippedValue": "maxime",
      "Description": "Seamless system-worthy software"
    },
    {
      "Value": "labore",
      "StrippedValue": "maxime",
      "Description": "Seamless system-worthy software"
    }
  ],
  "Position": {
    "Id": 428,
    "Value": "qui",
    "Tooltip": "voluptatem"
  },
  "UpdatedBy": {
    "AssociateId": 150,
    "Name": "Ritchie-Grant",
    "PersonId": 197,
    "Rank": 920,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 279,
    "FullName": "Mr. Seamus Fadel",
    "FormalName": "Klocko-Tromp",
    "Deleted": true,
    "EjUserId": 977,
    "UserName": "Corkery, Thiel and Ziemann"
  },
  "Contact": {
    "ContactId": 529,
    "Name": "Lubowitz, West and Blick",
    "OrgNr": "1562891",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "recusandae",
    "DirectPhone": "145-827-4602 x2275",
    "AssociateId": 304,
    "CountryId": 388,
    "EmailAddress": "jammie.wisoky@gleichner.com",
    "Kananame": "rerum",
    "EmailAddressName": "florida_donnelly@abernathy.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Pearlie Yost",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consectetur",
    "FullName": "Gillian Swaniawski",
    "IsOwnerContact": false,
    "ActiveErpLinks": 292
  },
  "Country": {
    "CountryId": 709,
    "Name": "Howell, Rutherford and Kertzmann",
    "CurrencyId": 212,
    "EnglishName": "Mayert, Wisoky and Kirlin",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Up-sized assymetric hub",
    "OrgNrText": "1257250",
    "InterAreaPrefix": "sequi",
    "DialInPrefix": "consequatur",
    "ZipPrefix": "ut",
    "DomainName": "Mraz LLC",
    "AddressLayoutId": 205,
    "DomesticAddressLayoutId": 595,
    "ForeignAddressLayoutId": 542,
    "Rank": 751,
    "Tooltip": "fuga",
    "Deleted": false
  },
  "Interests": [
    {
      "Id": 398,
      "Name": "Waelchi-Moen",
      "ToolTip": "Qui qui non maiores sit nihil sed.",
      "Deleted": false,
      "Rank": 107,
      "Type": "laboriosam",
      "ColorBlock": 388,
      "IconHint": "vel",
      "Selected": true,
      "LastChanged": "2005-05-29T18:28:49.5540876+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deserunt",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Keyon Sporer"
    }
  ],
  "PersonNumber": "1659203",
  "FullName": "Eusebio Ortiz",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "optio",
      "StrippedValue": "sunt",
      "Description": "Exclusive solution-oriented service-desk"
    },
    {
      "Value": "optio",
      "StrippedValue": "sunt",
      "Description": "Exclusive solution-oriented service-desk"
    }
  ],
  "FormalName": "Treutel, Senger and Johnson",
  "Address": {
    "Wgs84Latitude": 5976.538,
    "Wgs84Longitude": 8004.236,
    "LocalizedAddress": [
      [
        {
          "Name": "Pollich Group",
          "Value": "dolor",
          "Tooltip": "eaque",
          "Label": "repellat",
          "ValueLength": 901,
          "AddressType": "perferendis",
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
              "FieldLength": 131
            }
          }
        }
      ],
      [
        {
          "Name": "Lueilwitz-Schneider",
          "Value": "commodi",
          "Tooltip": "laborum",
          "Label": "et",
          "ValueLength": 758,
          "AddressType": "impedit",
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
              "FieldLength": 301
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "eveniet"
  },
  "Post3": "adipisci",
  "Post2": "libero",
  "Post1": "quibusdam",
  "Kanalname": "natus",
  "Kanafname": "molestias",
  "CorrespondingAssociate": {
    "AssociateId": 494,
    "Name": "Bashirian, Pouros and Sporer",
    "PersonId": 636,
    "Rank": 452,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 830,
    "FullName": "Astrid Goyette",
    "FormalName": "Grant-Olson",
    "Deleted": true,
    "EjUserId": 635,
    "UserName": "Schmidt Inc and Sons"
  },
  "Category": {
    "Id": 574,
    "Value": "rerum",
    "Tooltip": "eos"
  },
  "Business": {
    "Id": 137,
    "Value": "error",
    "Tooltip": "illo"
  },
  "Associate": {
    "AssociateId": 773,
    "Name": "Gislason, Lang and Pacocha",
    "PersonId": 546,
    "Rank": 597,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 973,
    "FullName": "Antoinette O'Hara",
    "FormalName": "Conn Inc and Sons",
    "Deleted": false,
    "EjUserId": 139,
    "UserName": "Walsh LLC"
  },
  "Salutation": "ducimus",
  "ActiveInterests": 165,
  "SupportAssociate": {
    "AssociateId": 76,
    "Name": "Koelpin LLC",
    "PersonId": 317,
    "Rank": 362,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 66,
    "FullName": "Agustina Breitenberg",
    "FormalName": "Carroll-Paucek",
    "Deleted": false,
    "EjUserId": 956,
    "UserName": "Bernier Group"
  },
  "TicketPriority": {
    "Id": 894,
    "Value": "ad",
    "Tooltip": "vitae"
  },
  "CustomerLanguage": {
    "Id": 696,
    "Value": "esse",
    "Tooltip": "nostrum"
  },
  "DbiAgentId": 30,
  "DbiKey": "ut",
  "DbiLastModified": "2005-07-04T18:28:49.5560874+02:00",
  "DbiLastSyncronized": "2008-06-11T18:28:49.5560874+02:00",
  "SentInfo": 134,
  "ShowContactTickets": 248,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 398,
    "UserName": "Rogahn Inc and Sons",
    "PersonId": 589,
    "Rank": 753,
    "Tooltip": "rerum",
    "UserGroupId": 91,
    "EjUserId": 21,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "cupiditate",
      "vel"
    ],
    "CanLogon": true,
    "RoleName": "Bergnaum Inc and Sons",
    "RoleTooltip": "incidunt",
    "UserGroupName": "Harvey-Nienow",
    "UserGroupTooltip": "est"
  },
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Pre-emptive intermediate model"
    },
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Pre-emptive intermediate model"
    }
  ],
  "InternetPhones": [
    {
      "Value": "facilis",
      "StrippedValue": "sit",
      "Description": "Persistent foreground interface"
    },
    {
      "Value": "facilis",
      "StrippedValue": "sit",
      "Description": "Persistent foreground interface"
    }
  ],
  "Source": 880,
  "ActiveErpLinks": 140,
  "ShipmentTypes": [
    {
      "Id": 606,
      "Name": "Swift-Botsford",
      "ToolTip": "Commodi iusto hic esse molestiae rerum.",
      "Deleted": false,
      "Rank": 594,
      "Type": "officiis",
      "ColorBlock": 111,
      "IconHint": "vel",
      "Selected": true,
      "LastChanged": "1996-10-04T18:28:49.5560874+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "architecto",
      "StyleHint": "doloribus",
      "Hidden": true,
      "FullName": "Ahmad Langworth"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 378,
      "Comment": "nam",
      "Registered": "2003-09-03T18:28:49.5560874+02:00",
      "RegisteredAssociateId": 622,
      "Updated": "2019-05-02T18:28:49.5560874+02:00",
      "UpdatedAssociateId": 62,
      "LegalBaseId": 931,
      "LegalBaseKey": "omnis",
      "LegalBaseName": "Willms Group",
      "ConsentPurposeId": 810,
      "ConsentPurposeKey": "velit",
      "ConsentPurposeName": "Trantow-Leuschke",
      "ConsentSourceId": 917,
      "ConsentSourceKey": "voluptates",
      "ConsentSourceName": "McGlynn, Boyle and Willms"
    }
  ],
  "BounceEmails": [
    "juwan.torp@hills.ca",
    "norene.champlin@ortizweissnat.us"
  ],
  "ActiveStatusMonitorId": 99,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1012975150"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "rerum"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 838,
  "Firstname": "Ozella",
  "MiddleName": "Wunsch-Altenwerth",
  "Lastname": "Harber",
  "Mrmrs": "est",
  "Title": "sed",
  "UpdatedDate": "2007-07-09T18:28:49.5650876+02:00",
  "CreatedDate": "2001-09-02T18:28:49.5650876+02:00",
  "BirthDate": "2020-04-20T18:28:49.5650876+02:00",
  "CreatedBy": {
    "AssociateId": 394,
    "Name": "Hammes, Veum and Bruen",
    "PersonId": 198,
    "Rank": 226,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 890,
    "FullName": "Lelah Littel",
    "FormalName": "Cremin, Toy and Cremin",
    "Deleted": false,
    "EjUserId": 396,
    "UserName": "Jakubowski, Konopelski and Aufderhar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 145
      }
    }
  },
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented context-sensitive benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented context-sensitive benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Description": "Business-focused mission-critical knowledge base",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quo",
      "StrippedValue": "ea",
      "Description": "Seamless value-added hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 346
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "ea",
      "Description": "Seamless value-added hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 346
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "maiores",
      "StrippedValue": "corporis",
      "Description": "Configurable contextually-based leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "corporis",
      "Description": "Configurable contextually-based leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "optio",
      "StrippedValue": "velit",
      "Description": "Visionary executive infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "velit",
      "Description": "Visionary executive infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "laudantium",
      "StrippedValue": "occaecati",
      "Description": "Multi-layered solution-oriented complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "occaecati",
      "Description": "Multi-layered solution-oriented complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "ullam",
      "Description": "Multi-tiered disintermediate utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "ullam",
      "Description": "Multi-tiered disintermediate utilisation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 877
        }
      }
    }
  ],
  "Position": {
    "Id": 146,
    "Value": "deserunt",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh scalable e-business"
        },
        "FieldType": "System.String",
        "FieldLength": 887
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 167,
    "Name": "Ziemann, McDermott and Roob",
    "PersonId": 757,
    "Rank": 885,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 250,
    "FullName": "Mrs. Dolly Parker",
    "FormalName": "Daugherty, Wintheiser and Gutmann",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Hamill, Senger and Walsh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 432
      }
    }
  },
  "Contact": {
    "ContactId": 943,
    "Name": "Bode, Boyle and Corkery",
    "OrgNr": "1279273",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "modi",
    "DirectPhone": "1-526-124-6021 x3152",
    "AssociateId": 228,
    "CountryId": 222,
    "EmailAddress": "cecil_gusikowski@oconner.us",
    "Kananame": "dolorem",
    "EmailAddressName": "connie.homenick@klockoroberts.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Graham Gorczany",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officia",
    "FullName": "Oswald Herman",
    "IsOwnerContact": false,
    "ActiveErpLinks": 214,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 813
      }
    }
  },
  "Country": {
    "CountryId": 920,
    "Name": "Mraz, Hane and Beer",
    "CurrencyId": 922,
    "EnglishName": "Yost-Gutkowski",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Intuitive upward-trending approach",
    "OrgNrText": "1074422",
    "InterAreaPrefix": "ut",
    "DialInPrefix": "et",
    "ZipPrefix": "perferendis",
    "DomainName": "Shields-Welch",
    "AddressLayoutId": 515,
    "DomesticAddressLayoutId": 583,
    "ForeignAddressLayoutId": 286,
    "Rank": 521,
    "Tooltip": "cumque",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 134
      }
    }
  },
  "Interests": [
    {
      "Id": 287,
      "Name": "Ruecker-Bechtelar",
      "ToolTip": "Dolorem sequi rerum explicabo.",
      "Deleted": false,
      "Rank": 237,
      "Type": "assumenda",
      "ColorBlock": 315,
      "IconHint": "ab",
      "Selected": true,
      "LastChanged": "2004-06-28T18:28:49.5670875+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "sunt",
      "Hidden": false,
      "FullName": "Miss Ollie Jacobi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 696
        }
      }
    }
  ],
  "PersonNumber": "715210",
  "FullName": "Christelle Grant",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "minus",
      "Description": "Business-focused directional application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "minus",
      "Description": "Business-focused directional application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 654
        }
      }
    }
  ],
  "FormalName": "Bernier-Hilpert",
  "Address": {
    "Wgs84Latitude": 6543.7919999999995,
    "Wgs84Longitude": 30666.19,
    "LocalizedAddress": [
      [
        {
          "Name": "Rath LLC",
          "Value": "et",
          "Tooltip": "cum",
          "Label": "sed",
          "ValueLength": 182,
          "AddressType": "dolores",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "enhance ubiquitous interfaces"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 138
            }
          }
        }
      ],
      [
        {
          "Name": "Rogahn-Simonis",
          "Value": "quaerat",
          "Tooltip": "quasi",
          "Label": "sit",
          "ValueLength": 625,
          "AddressType": "dolor",
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
              "FieldLength": 895
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 373
      }
    }
  },
  "Post3": "eius",
  "Post2": "neque",
  "Post1": "temporibus",
  "Kanalname": "quo",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": {
    "AssociateId": 842,
    "Name": "Shanahan, Muller and Hills",
    "PersonId": 231,
    "Rank": 606,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 952,
    "FullName": "Presley Conroy",
    "FormalName": "Kassulke, Braun and Erdman",
    "Deleted": false,
    "EjUserId": 434,
    "UserName": "Crona-Stokes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 118
      }
    }
  },
  "Category": {
    "Id": 912,
    "Value": "reprehenderit",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 613
      }
    }
  },
  "Business": {
    "Id": 659,
    "Value": "cupiditate",
    "Tooltip": "in",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 423
      }
    }
  },
  "Associate": {
    "AssociateId": 970,
    "Name": "Weber-Kuhic",
    "PersonId": 315,
    "Rank": 687,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 369,
    "FullName": "Beaulah Hilll",
    "FormalName": "Harber, Bruen and Powlowski",
    "Deleted": false,
    "EjUserId": 961,
    "UserName": "Quigley, Hintz and Cormier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 251
      }
    }
  },
  "Salutation": "deserunt",
  "ActiveInterests": 857,
  "SupportAssociate": {
    "AssociateId": 539,
    "Name": "Legros Inc and Sons",
    "PersonId": 792,
    "Rank": 624,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 709,
    "FullName": "Alfredo Johnson",
    "FormalName": "Koepp LLC",
    "Deleted": true,
    "EjUserId": 990,
    "UserName": "Schneider Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 715
      }
    }
  },
  "TicketPriority": {
    "Id": 596,
    "Value": "earum",
    "Tooltip": "ut",
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
  },
  "CustomerLanguage": {
    "Id": 832,
    "Value": "in",
    "Tooltip": "architecto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  },
  "DbiAgentId": 254,
  "DbiKey": "tempore",
  "DbiLastModified": "1995-11-01T18:28:49.5700873+01:00",
  "DbiLastSyncronized": "1998-04-19T18:28:49.5700873+02:00",
  "SentInfo": 531,
  "ShowContactTickets": 554,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 263,
    "UserName": "Schaden-Wiza",
    "PersonId": 433,
    "Rank": 429,
    "Tooltip": "quia",
    "UserGroupId": 197,
    "EjUserId": 354,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "aperiam",
      "saepe"
    ],
    "CanLogon": true,
    "RoleName": "Kling Inc and Sons",
    "RoleTooltip": "a",
    "UserGroupName": "Kshlerin, Swift and Mohr",
    "UserGroupTooltip": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 409
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "debitis",
      "StrippedValue": "quia",
      "Description": "Operative solution-oriented flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 9
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "quia",
      "Description": "Operative solution-oriented flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 9
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ex",
      "StrippedValue": "veniam",
      "Description": "Down-sized zero defect application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "veniam",
      "Description": "Down-sized zero defect application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "Source": 620,
  "ActiveErpLinks": 525,
  "ShipmentTypes": [
    {
      "Id": 351,
      "Name": "Veum LLC",
      "ToolTip": "Autem id veniam omnis rerum.",
      "Deleted": false,
      "Rank": 116,
      "Type": "aspernatur",
      "ColorBlock": 362,
      "IconHint": "dolor",
      "Selected": true,
      "LastChanged": "2017-09-24T18:28:49.5700873+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "magni",
      "Hidden": true,
      "FullName": "Lorenz O'Hara",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 3
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 979,
      "Comment": "sed",
      "Registered": "1999-04-28T18:28:49.5700873+02:00",
      "RegisteredAssociateId": 514,
      "Updated": "1996-11-05T18:28:49.5700873+01:00",
      "UpdatedAssociateId": 970,
      "LegalBaseId": 821,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Hansen, Jast and Stokes",
      "ConsentPurposeId": 169,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "O'Hara, Becker and Heidenreich",
      "ConsentSourceId": 284,
      "ConsentSourceKey": "sunt",
      "ConsentSourceName": "Toy Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    }
  ],
  "BounceEmails": [
    "neal@stehr.us",
    "marilou_feil@mann.biz"
  ],
  "ActiveStatusMonitorId": 721,
  "UserDefinedFields": {
    "SuperOffice:1": "Odie Rath",
    "SuperOffice:2": "Maude Bogan"
  },
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "eligendi"
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
      "FieldLength": 805
    }
  }
}
```