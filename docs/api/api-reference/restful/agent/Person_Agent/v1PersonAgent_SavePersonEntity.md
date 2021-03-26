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
  "PersonId": 892,
  "Firstname": "Flavie",
  "MiddleName": "Bergstrom-Tromp",
  "Lastname": "Schaefer",
  "Mrmrs": "ea",
  "Title": "quia",
  "UpdatedDate": "2000-11-01T16:48:30.0139248+01:00",
  "CreatedDate": "2000-01-09T16:48:30.0139248+01:00",
  "BirthDate": "1996-05-27T16:48:30.0139248+02:00",
  "CreatedBy": {
    "AssociateId": 543,
    "Name": "Jones, Boyer and Kuhn",
    "PersonId": 267,
    "Rank": 137,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 361,
    "FullName": "Alaina Stracke",
    "FormalName": "Jast, Paucek and Rogahn",
    "Deleted": true,
    "EjUserId": 36,
    "UserName": "Boehm, Gorczany and Purdy"
  },
  "Emails": [
    {
      "Value": "magni",
      "StrippedValue": "voluptatibus",
      "Description": "Streamlined scalable model"
    },
    {
      "Value": "magni",
      "StrippedValue": "voluptatibus",
      "Description": "Streamlined scalable model"
    }
  ],
  "Description": "Exclusive client-driven flexibility",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "at",
      "Description": "Integrated regional service-desk"
    },
    {
      "Value": "ut",
      "StrippedValue": "at",
      "Description": "Integrated regional service-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "sequi",
      "Description": "Synergized upward-trending Graphical User Interface"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "sequi",
      "Description": "Synergized upward-trending Graphical User Interface"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "blanditiis",
      "Description": "Re-engineered contextually-based hub"
    },
    {
      "Value": "et",
      "StrippedValue": "blanditiis",
      "Description": "Re-engineered contextually-based hub"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "ea",
      "Description": "Optional bottom-line open system"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "ea",
      "Description": "Optional bottom-line open system"
    }
  ],
  "OtherPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "minus",
      "Description": "Public-key content-based approach"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "minus",
      "Description": "Public-key content-based approach"
    }
  ],
  "Position": {
    "Id": 511,
    "Value": "eveniet",
    "Tooltip": "dolore"
  },
  "UpdatedBy": {
    "AssociateId": 841,
    "Name": "Lueilwitz, Jast and Christiansen",
    "PersonId": 255,
    "Rank": 792,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 70,
    "FullName": "Hoyt Bradtke",
    "FormalName": "Goyette Inc and Sons",
    "Deleted": false,
    "EjUserId": 493,
    "UserName": "Nader, Conn and Kirlin"
  },
  "Contact": {
    "ContactId": 729,
    "Name": "Johnston Inc and Sons",
    "OrgNr": "1027487",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "soluta",
    "DirectPhone": "435.726.0657 x782",
    "AssociateId": 299,
    "CountryId": 588,
    "EmailAddress": "patrick@blanda.co.uk",
    "Kananame": "cumque",
    "EmailAddressName": "rhiannon@quigley.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Fletcher Davis III",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "earum",
    "FullName": "Jolie Kassulke",
    "IsOwnerContact": false,
    "ActiveErpLinks": 219
  },
  "Country": {
    "CountryId": 387,
    "Name": "Baumbach Inc and Sons",
    "CurrencyId": 645,
    "EnglishName": "Thiel, Casper and Mitchell",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Persistent leading edge capacity",
    "OrgNrText": "1024615",
    "InterAreaPrefix": "debitis",
    "DialInPrefix": "quis",
    "ZipPrefix": "sunt",
    "DomainName": "Baumbach, O'Connell and Hirthe",
    "AddressLayoutId": 500,
    "DomesticAddressLayoutId": 631,
    "ForeignAddressLayoutId": 536,
    "Rank": 67,
    "Tooltip": "aut",
    "Deleted": false
  },
  "Interests": [
    {
      "Id": 364,
      "Name": "Stiedemann-Auer",
      "ToolTip": "Sunt esse porro accusantium laboriosam qui blanditiis.",
      "Deleted": false,
      "Rank": 659,
      "Type": "et",
      "ColorBlock": 116,
      "IconHint": "veritatis",
      "Selected": true,
      "LastChanged": "2015-01-17T16:48:30.0169243+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellendus",
      "StyleHint": "nisi",
      "Hidden": true,
      "FullName": "Owen Ankunding"
    }
  ],
  "PersonNumber": "1083407",
  "FullName": "Mitchell Auer",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "minima",
      "Description": "Organic zero tolerance portal"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "minima",
      "Description": "Organic zero tolerance portal"
    }
  ],
  "FormalName": "McDermott-Cole",
  "Address": {
    "Wgs84Latitude": 22520.924,
    "Wgs84Longitude": 9282.908,
    "LocalizedAddress": [
      [
        {
          "Name": "Johnson Inc and Sons",
          "Value": "accusamus",
          "Tooltip": "a",
          "Label": "laborum",
          "ValueLength": 678,
          "AddressType": "et",
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
              "FieldLength": 735
            }
          }
        }
      ],
      [
        {
          "Name": "Koch-Kutch",
          "Value": "vero",
          "Tooltip": "possimus",
          "Label": "expedita",
          "ValueLength": 406,
          "AddressType": "at",
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
              "FieldLength": 850
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "deleniti"
  },
  "Post3": "libero",
  "Post2": "accusantium",
  "Post1": "culpa",
  "Kanalname": "ea",
  "Kanafname": "et",
  "CorrespondingAssociate": {
    "AssociateId": 245,
    "Name": "Mayer Group",
    "PersonId": 633,
    "Rank": 259,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 76,
    "FullName": "Bridie Pouros",
    "FormalName": "Nicolas-Rosenbaum",
    "Deleted": false,
    "EjUserId": 255,
    "UserName": "Conroy, Towne and Ullrich"
  },
  "Category": {
    "Id": 28,
    "Value": "aut",
    "Tooltip": "modi"
  },
  "Business": {
    "Id": 477,
    "Value": "minima",
    "Tooltip": "aliquid"
  },
  "Associate": {
    "AssociateId": 90,
    "Name": "Cronin, Schultz and Goodwin",
    "PersonId": 905,
    "Rank": 668,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 289,
    "FullName": "Tyreek Rau",
    "FormalName": "Parker, Huel and Larson",
    "Deleted": false,
    "EjUserId": 709,
    "UserName": "Kuphal-Wolff"
  },
  "Salutation": "adipisci",
  "ActiveInterests": 245,
  "SupportAssociate": {
    "AssociateId": 974,
    "Name": "Bartoletti, Halvorson and Jacobson",
    "PersonId": 283,
    "Rank": 797,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 396,
    "FullName": "Jaylon Auer",
    "FormalName": "Gislason-Kilback",
    "Deleted": false,
    "EjUserId": 621,
    "UserName": "Howell-Cruickshank"
  },
  "TicketPriority": {
    "Id": 856,
    "Value": "vitae",
    "Tooltip": "dolorum"
  },
  "CustomerLanguage": {
    "Id": 573,
    "Value": "qui",
    "Tooltip": "dolorem"
  },
  "DbiAgentId": 624,
  "DbiKey": "non",
  "DbiLastModified": "1997-07-11T16:48:30.0189241+02:00",
  "DbiLastSyncronized": "2003-03-19T16:48:30.0189241+01:00",
  "SentInfo": 379,
  "ShowContactTickets": 751,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 632,
    "UserName": "Ortiz, Bins and Grant",
    "PersonId": 575,
    "Rank": 39,
    "Tooltip": "sed",
    "UserGroupId": 187,
    "EjUserId": 56,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "deserunt",
      "consequatur"
    ],
    "CanLogon": false,
    "RoleName": "Feest-Orn",
    "RoleTooltip": "modi",
    "UserGroupName": "Koelpin Inc and Sons",
    "UserGroupTooltip": "velit"
  },
  "ChatEmails": [
    {
      "Value": "dicta",
      "StrippedValue": "id",
      "Description": "Centralized zero defect methodology"
    },
    {
      "Value": "dicta",
      "StrippedValue": "id",
      "Description": "Centralized zero defect methodology"
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Exclusive impactful open system"
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Exclusive impactful open system"
    }
  ],
  "Source": 983,
  "ActiveErpLinks": 453,
  "ShipmentTypes": [
    {
      "Id": 717,
      "Name": "Mann-Breitenberg",
      "ToolTip": "Dolor sed.",
      "Deleted": false,
      "Rank": 168,
      "Type": "vitae",
      "ColorBlock": 347,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "1994-06-10T16:48:30.0189241+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "omnis",
      "Hidden": true,
      "FullName": "Wilson Gerhold"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 104,
      "Comment": "tempora",
      "Registered": "2012-07-30T16:48:30.0189241+02:00",
      "RegisteredAssociateId": 165,
      "Updated": "2014-09-17T16:48:30.0189241+02:00",
      "UpdatedAssociateId": 728,
      "LegalBaseId": 970,
      "LegalBaseKey": "est",
      "LegalBaseName": "Ward-Leffler",
      "ConsentPurposeId": 466,
      "ConsentPurposeKey": "enim",
      "ConsentPurposeName": "Schmidt, Kertzmann and Ward",
      "ConsentSourceId": 905,
      "ConsentSourceKey": "error",
      "ConsentSourceName": "Grant Group"
    }
  ],
  "BounceEmails": [
    "brennan.kautzer@collins.us",
    "gunner@schneider.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Suzanne Gorczany",
    "SuperOffice:2": "543580063"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "fugiat"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 567,
  "Firstname": "Jacey",
  "MiddleName": "Windler-Schroeder",
  "Lastname": "Kohler",
  "Mrmrs": "officiis",
  "Title": "quidem",
  "UpdatedDate": "2003-08-09T16:48:30.0269242+02:00",
  "CreatedDate": "1994-11-18T16:48:30.0269242+01:00",
  "BirthDate": "1997-11-07T16:48:30.0269242+01:00",
  "CreatedBy": {
    "AssociateId": 623,
    "Name": "Harber-Wisozk",
    "PersonId": 315,
    "Rank": 122,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 981,
    "FullName": "Arnold Quitzon",
    "FormalName": "Prosacco, Bailey and Lesch",
    "Deleted": true,
    "EjUserId": 279,
    "UserName": "Schultz-Barrows",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 564
      }
    }
  },
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "voluptas",
      "Description": "Automated fresh-thinking standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "voluptas",
      "Description": "Automated fresh-thinking standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    }
  ],
  "Description": "Assimilated eco-centric time-frame",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aut",
      "StrippedValue": "maiores",
      "Description": "Synergized attitude-oriented infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "maiores",
      "Description": "Synergized attitude-oriented infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "natus",
      "StrippedValue": "deserunt",
      "Description": "Digitized assymetric application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "deserunt",
      "Description": "Digitized assymetric application",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "eius",
      "Description": "Intuitive coherent archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 326
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "eius",
      "Description": "Intuitive coherent archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 326
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Expanded 3rd generation implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "et",
      "Description": "Expanded 3rd generation implementation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ipsa",
      "StrippedValue": "enim",
      "Description": "Digitized global definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 93
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "enim",
      "Description": "Digitized global definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 93
        }
      }
    }
  ],
  "Position": {
    "Id": 28,
    "Value": "perspiciatis",
    "Tooltip": "distinctio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 181
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 141,
    "Name": "Baumbach, Moen and Bogan",
    "PersonId": 670,
    "Rank": 322,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 986,
    "FullName": "Wanda Mann",
    "FormalName": "Erdman-Volkman",
    "Deleted": true,
    "EjUserId": 10,
    "UserName": "Hyatt-Leannon",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 928
      }
    }
  },
  "Contact": {
    "ContactId": 518,
    "Name": "Littel LLC",
    "OrgNr": "794681",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "doloribus",
    "DirectPhone": "861.404.8255 x0714",
    "AssociateId": 749,
    "CountryId": 569,
    "EmailAddress": "eulalia@morissette.biz",
    "Kananame": "voluptatem",
    "EmailAddressName": "domingo_ledner@olson.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Curt West IV",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "itaque",
    "FullName": "Tiara Aufderhar",
    "IsOwnerContact": true,
    "ActiveErpLinks": 873,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Country": {
    "CountryId": 196,
    "Name": "Labadie, Turcotte and Hilpert",
    "CurrencyId": 266,
    "EnglishName": "Wiegand-Balistreri",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Horizontal background collaboration",
    "OrgNrText": "1022897",
    "InterAreaPrefix": "et",
    "DialInPrefix": "voluptatem",
    "ZipPrefix": "minima",
    "DomainName": "Mraz-Schimmel",
    "AddressLayoutId": 782,
    "DomesticAddressLayoutId": 844,
    "ForeignAddressLayoutId": 32,
    "Rank": 599,
    "Tooltip": "totam",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 58
      }
    }
  },
  "Interests": [
    {
      "Id": 333,
      "Name": "Crist LLC",
      "ToolTip": "Ex qui ut.",
      "Deleted": false,
      "Rank": 121,
      "Type": "placeat",
      "ColorBlock": 325,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "2018-05-15T16:48:30.0299252+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempore",
      "StyleHint": "dicta",
      "Hidden": false,
      "FullName": "Molly Beier",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "PersonNumber": "1633335",
  "FullName": "Violette Durgan",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "eligendi",
      "Description": "Expanded neutral neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose magnetic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "eligendi",
      "Description": "Expanded neutral neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose magnetic web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "FormalName": "Collier LLC",
  "Address": {
    "Wgs84Latitude": 30396.665999999997,
    "Wgs84Longitude": 23727.514,
    "LocalizedAddress": [
      [
        {
          "Name": "Kassulke Inc and Sons",
          "Value": "est",
          "Tooltip": "repellendus",
          "Label": "tempora",
          "ValueLength": 148,
          "AddressType": "sed",
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
              "FieldLength": 512
            }
          }
        }
      ],
      [
        {
          "Name": "Schuster Group",
          "Value": "qui",
          "Tooltip": "quidem",
          "Label": "quaerat",
          "ValueLength": 371,
          "AddressType": "fugiat",
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
              "FieldLength": 340
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "consectetur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 520
      }
    }
  },
  "Post3": "amet",
  "Post2": "officia",
  "Post1": "tempora",
  "Kanalname": "praesentium",
  "Kanafname": "fuga",
  "CorrespondingAssociate": {
    "AssociateId": 386,
    "Name": "Tillman Group",
    "PersonId": 34,
    "Rank": 357,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 416,
    "FullName": "Gladyce Wolf",
    "FormalName": "Thiel Inc and Sons",
    "Deleted": false,
    "EjUserId": 252,
    "UserName": "Cummings-Bashirian",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 832
      }
    }
  },
  "Category": {
    "Id": 212,
    "Value": "quae",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace real-time infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "Business": {
    "Id": 295,
    "Value": "nihil",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 59
      }
    }
  },
  "Associate": {
    "AssociateId": 210,
    "Name": "Quitzon LLC",
    "PersonId": 685,
    "Rank": 275,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 713,
    "FullName": "Juliana Collins",
    "FormalName": "Pouros, Denesik and Veum",
    "Deleted": false,
    "EjUserId": 570,
    "UserName": "Gibson-Kautzer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 252
      }
    }
  },
  "Salutation": "a",
  "ActiveInterests": 208,
  "SupportAssociate": {
    "AssociateId": 15,
    "Name": "Glover LLC",
    "PersonId": 775,
    "Rank": 4,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 350,
    "FullName": "Elijah Mertz",
    "FormalName": "Jast, Gorczany and Gibson",
    "Deleted": true,
    "EjUserId": 487,
    "UserName": "Sanford Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 797
      }
    }
  },
  "TicketPriority": {
    "Id": 780,
    "Value": "sint",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 575
      }
    }
  },
  "CustomerLanguage": {
    "Id": 409,
    "Value": "et",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 652
      }
    }
  },
  "DbiAgentId": 999,
  "DbiKey": "nam",
  "DbiLastModified": "2008-05-10T16:48:30.0319244+02:00",
  "DbiLastSyncronized": "2000-10-03T16:48:30.0319244+02:00",
  "SentInfo": 515,
  "ShowContactTickets": 17,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 460,
    "UserName": "Kautzer, Turner and Watsica",
    "PersonId": 775,
    "Rank": 95,
    "Tooltip": "modi",
    "UserGroupId": 764,
    "EjUserId": 418,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "et",
      "ut"
    ],
    "CanLogon": true,
    "RoleName": "Robel Inc and Sons",
    "RoleTooltip": "nam",
    "UserGroupName": "Ward, Bruen and Reichel",
    "UserGroupTooltip": "eos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 407
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "laboriosam",
      "StrippedValue": "necessitatibus",
      "Description": "Total multi-tasking info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "necessitatibus",
      "Description": "Total multi-tasking info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 597
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "minus",
      "Description": "Reverse-engineered real-time Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "minus",
      "Description": "Reverse-engineered real-time Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    }
  ],
  "Source": 299,
  "ActiveErpLinks": 794,
  "ShipmentTypes": [
    {
      "Id": 1001,
      "Name": "Schamberger-Eichmann",
      "ToolTip": "Tenetur nulla repudiandae.",
      "Deleted": false,
      "Rank": 13,
      "Type": "in",
      "ColorBlock": 371,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "2006-10-19T16:48:30.0329195+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Marielle Yost",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 378,
      "Comment": "excepturi",
      "Registered": "2020-01-20T16:48:30.0329195+01:00",
      "RegisteredAssociateId": 81,
      "Updated": "1996-11-11T16:48:30.0329195+01:00",
      "UpdatedAssociateId": 402,
      "LegalBaseId": 881,
      "LegalBaseKey": "quos",
      "LegalBaseName": "Lesch Group",
      "ConsentPurposeId": 661,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Howe Inc and Sons",
      "ConsentSourceId": 29,
      "ConsentSourceKey": "eius",
      "ConsentSourceName": "Mertz, Torphy and Reichel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "BounceEmails": [
    "kris.pollich@hodkiewicz.ca",
    "marina@smith.com"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "sequi"
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
      "FieldLength": 967
    }
  }
}
```