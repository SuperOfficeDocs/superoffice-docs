---
title: POST Person/Validate
id: v1PersonEntity_ValidatePersonEntity
---

# POST Person/Validate

```http
POST /api/v1/Person/Validate
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

## Request Body: personEntity  

Entity to be checked for errors. 

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


## Sample Request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 309,
  "Firstname": "Sidney",
  "MiddleName": "Sawayn, Baumbach and Zemlak",
  "Lastname": "Bashirian",
  "Mrmrs": "quae",
  "Title": "libero",
  "UpdatedDate": "2010-02-09T18:25:50.7315958+01:00",
  "CreatedDate": "1996-07-23T18:25:50.7315958+02:00",
  "BirthDate": "2017-12-24T18:25:50.7315958+01:00",
  "CreatedBy": {
    "AssociateId": 885,
    "Name": "Kohler-Dickinson",
    "PersonId": 263,
    "Rank": 450,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 594,
    "FullName": "Kattie Lind Jr.",
    "FormalName": "Krajcik-Pollich",
    "Deleted": false,
    "EjUserId": 567,
    "UserName": "Bode-Sporer"
  },
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "explicabo",
      "Description": "Polarised reciprocal migration"
    },
    {
      "Value": "maiores",
      "StrippedValue": "explicabo",
      "Description": "Polarised reciprocal migration"
    }
  ],
  "Description": "Enterprise-wide multi-tasking approach",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "excepturi",
      "Description": "Reduced zero tolerance Graphical User Interface"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "excepturi",
      "Description": "Reduced zero tolerance Graphical User Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "hic",
      "StrippedValue": "voluptatem",
      "Description": "Profit-focused human-resource hierarchy"
    },
    {
      "Value": "hic",
      "StrippedValue": "voluptatem",
      "Description": "Profit-focused human-resource hierarchy"
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "possimus",
      "Description": "Centralized systemic encoding"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "possimus",
      "Description": "Centralized systemic encoding"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eaque",
      "StrippedValue": "atque",
      "Description": "Cross-platform clear-thinking service-desk"
    },
    {
      "Value": "eaque",
      "StrippedValue": "atque",
      "Description": "Cross-platform clear-thinking service-desk"
    }
  ],
  "OtherPhones": [
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Business-focused contextually-based info-mediaries"
    },
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Business-focused contextually-based info-mediaries"
    }
  ],
  "Position": {
    "Id": 61,
    "Value": "delectus",
    "Tooltip": "deserunt"
  },
  "UpdatedBy": {
    "AssociateId": 147,
    "Name": "Cole, Marquardt and Cummings",
    "PersonId": 337,
    "Rank": 578,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 63,
    "FullName": "Lamont Douglas",
    "FormalName": "Abernathy Group",
    "Deleted": true,
    "EjUserId": 32,
    "UserName": "Sipes-McGlynn"
  },
  "Contact": {
    "ContactId": 500,
    "Name": "Trantow Inc and Sons",
    "OrgNr": "835294",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quo",
    "DirectPhone": "746-384-0144 x1258",
    "AssociateId": 337,
    "CountryId": 867,
    "EmailAddress": "jared@bins.us",
    "Kananame": "iste",
    "EmailAddressName": "tania@welch.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dereck Klocko",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "odit",
    "FullName": "Mac Bins",
    "IsOwnerContact": true,
    "ActiveErpLinks": 939
  },
  "Country": {
    "CountryId": 884,
    "Name": "Hagenes LLC",
    "CurrencyId": 259,
    "EnglishName": "Yundt-Towne",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Realigned 4th generation installation",
    "OrgNrText": "1457155",
    "InterAreaPrefix": "atque",
    "DialInPrefix": "neque",
    "ZipPrefix": "sit",
    "DomainName": "Considine, Huel and Fahey",
    "AddressLayoutId": 852,
    "DomesticAddressLayoutId": 486,
    "ForeignAddressLayoutId": 987,
    "Rank": 209,
    "Tooltip": "tempora",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 565,
      "Name": "Moore-Collins",
      "ToolTip": "Voluptatem ducimus.",
      "Deleted": true,
      "Rank": 171,
      "Type": "est",
      "ColorBlock": 56,
      "IconHint": "veniam",
      "Selected": true,
      "LastChanged": "1997-06-09T18:25:50.7375945+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "eum",
      "Hidden": true,
      "FullName": "Anabel Prosacco"
    }
  ],
  "PersonNumber": "1281452",
  "FullName": "Jairo Ullrich",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "aut",
      "Description": "Diverse hybrid middleware"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "aut",
      "Description": "Diverse hybrid middleware"
    }
  ],
  "FormalName": "Goodwin Group",
  "Address": {
    "Wgs84Latitude": 24244.624,
    "Wgs84Longitude": 20696.935999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Bosco LLC",
          "Value": "soluta",
          "Tooltip": "consequatur",
          "Label": "illo",
          "ValueLength": 847,
          "AddressType": "vero",
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
              "FieldLength": 988
            }
          }
        }
      ],
      [
        {
          "Name": "Treutel Inc and Sons",
          "Value": "reprehenderit",
          "Tooltip": "aut",
          "Label": "nobis",
          "ValueLength": 116,
          "AddressType": "delectus",
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
              "FieldLength": 703
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "saepe"
  },
  "Post3": "ipsam",
  "Post2": "non",
  "Post1": "vel",
  "Kanalname": "dolorum",
  "Kanafname": "ullam",
  "CorrespondingAssociate": {
    "AssociateId": 160,
    "Name": "Schimmel Inc and Sons",
    "PersonId": 732,
    "Rank": 878,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 653,
    "FullName": "Leone Ullrich I",
    "FormalName": "Bosco Group",
    "Deleted": false,
    "EjUserId": 923,
    "UserName": "Gusikowski, Nitzsche and Kautzer"
  },
  "Category": {
    "Id": 531,
    "Value": "hic",
    "Tooltip": "vitae"
  },
  "Business": {
    "Id": 247,
    "Value": "et",
    "Tooltip": "enim"
  },
  "Associate": {
    "AssociateId": 388,
    "Name": "Carroll, Dach and Schumm",
    "PersonId": 599,
    "Rank": 59,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 483,
    "FullName": "Celestine Jaskolski",
    "FormalName": "Parisian-Mills",
    "Deleted": true,
    "EjUserId": 541,
    "UserName": "Schoen, Zulauf and Langworth"
  },
  "Salutation": "ut",
  "ActiveInterests": 85,
  "SupportAssociate": {
    "AssociateId": 784,
    "Name": "Mann, Vandervort and Carter",
    "PersonId": 221,
    "Rank": 953,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 132,
    "FullName": "Thad Collins",
    "FormalName": "Doyle, Stanton and Nienow",
    "Deleted": false,
    "EjUserId": 775,
    "UserName": "Leuschke LLC"
  },
  "TicketPriority": {
    "Id": 404,
    "Value": "et",
    "Tooltip": "corrupti"
  },
  "CustomerLanguage": {
    "Id": 507,
    "Value": "odio",
    "Tooltip": "et"
  },
  "DbiAgentId": 736,
  "DbiKey": "quia",
  "DbiLastModified": "2016-12-25T18:25:50.7698838+01:00",
  "DbiLastSyncronized": "2007-02-15T18:25:50.7698838+01:00",
  "SentInfo": 887,
  "ShowContactTickets": 263,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 876,
    "UserName": "Heller, Lockman and Parisian",
    "PersonId": 158,
    "Rank": 405,
    "Tooltip": "id",
    "UserGroupId": 152,
    "EjUserId": 881,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ab",
      "sed"
    ],
    "CanLogon": true,
    "RoleName": "Morissette Inc and Sons",
    "RoleTooltip": "autem",
    "UserGroupName": "Stiedemann LLC",
    "UserGroupTooltip": "amet"
  },
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "enim",
      "Description": "Reverse-engineered needs-based toolset"
    },
    {
      "Value": "est",
      "StrippedValue": "enim",
      "Description": "Reverse-engineered needs-based toolset"
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "at",
      "Description": "Versatile encompassing infrastructure"
    },
    {
      "Value": "est",
      "StrippedValue": "at",
      "Description": "Versatile encompassing infrastructure"
    }
  ],
  "Source": 655,
  "ActiveErpLinks": 901,
  "ShipmentTypes": [
    {
      "Id": 239,
      "Name": "Schroeder-Jenkins",
      "ToolTip": "Sunt quidem perferendis enim ut recusandae.",
      "Deleted": true,
      "Rank": 84,
      "Type": "quos",
      "ColorBlock": 912,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2017-11-23T18:25:50.7698838+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "asperiores",
      "Hidden": false,
      "FullName": "Laurel Lindgren"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 314,
      "Comment": "enim",
      "Registered": "1998-12-18T18:25:50.7698838+01:00",
      "RegisteredAssociateId": 811,
      "Updated": "1997-06-23T18:25:50.7698838+02:00",
      "UpdatedAssociateId": 896,
      "LegalBaseId": 300,
      "LegalBaseKey": "est",
      "LegalBaseName": "Rogahn-Bechtelar",
      "ConsentPurposeId": 9,
      "ConsentPurposeKey": "atque",
      "ConsentPurposeName": "Murazik, Blick and Towne",
      "ConsentSourceId": 503,
      "ConsentSourceKey": "ullam",
      "ConsentSourceName": "Jakubowski-Labadie"
    }
  ],
  "BounceEmails": [
    "grace@schuppetowne.info",
    "augustus_windler@boyle.info"
  ],
  "ActiveStatusMonitorId": 195,
  "UserDefinedFields": {
    "SuperOffice:1": "Ethelyn Boyer",
    "SuperOffice:2": "1720190929"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "consequatur"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "porro"
}
```