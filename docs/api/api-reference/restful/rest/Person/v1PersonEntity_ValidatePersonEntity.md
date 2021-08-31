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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 797,
  "Firstname": "Frankie",
  "MiddleName": "Auer-Collins",
  "Lastname": "Kirlin",
  "Mrmrs": "ex",
  "Title": "enim",
  "UpdatedDate": "2004-12-26T15:05:42.4106686+01:00",
  "CreatedDate": "2017-12-20T15:05:42.4106686+01:00",
  "BirthDate": "2004-03-14T15:05:42.4106686+01:00",
  "CreatedBy": {
    "AssociateId": 322,
    "Name": "Daugherty-Mosciski",
    "PersonId": 619,
    "Rank": 768,
    "Tooltip": "ipsum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Miss Ramon Shields",
    "FormalName": "Gaylord Inc and Sons",
    "Deleted": false,
    "EjUserId": 337,
    "UserName": "Ryan, Jacobs and Wilderman"
  },
  "Emails": [
    {
      "Value": "officiis",
      "StrippedValue": "adipisci",
      "Description": "Focused assymetric analyzer"
    },
    {
      "Value": "officiis",
      "StrippedValue": "adipisci",
      "Description": "Focused assymetric analyzer"
    }
  ],
  "Description": "Decentralized tertiary process improvement",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nemo",
      "StrippedValue": "dicta",
      "Description": "Universal stable alliance"
    },
    {
      "Value": "nemo",
      "StrippedValue": "dicta",
      "Description": "Universal stable alliance"
    }
  ],
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Enterprise-wide eco-centric migration"
    },
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Enterprise-wide eco-centric migration"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Extended client-server standardization"
    },
    {
      "Value": "aut",
      "StrippedValue": "esse",
      "Description": "Extended client-server standardization"
    }
  ],
  "OfficePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "maxime",
      "Description": "Re-contextualized local matrices"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "maxime",
      "Description": "Re-contextualized local matrices"
    }
  ],
  "OtherPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "eos",
      "Description": "Ameliorated stable process improvement"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "eos",
      "Description": "Ameliorated stable process improvement"
    }
  ],
  "Position": {
    "Id": 12,
    "Value": "hic",
    "Tooltip": "dolores"
  },
  "UpdatedBy": {
    "AssociateId": 915,
    "Name": "O'Keefe-Halvorson",
    "PersonId": 806,
    "Rank": 645,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 985,
    "FullName": "Murphy Mraz",
    "FormalName": "Brekke-Connelly",
    "Deleted": false,
    "EjUserId": 677,
    "UserName": "Dickens-Gleason"
  },
  "Contact": {
    "ContactId": 451,
    "Name": "Rolfson Inc and Sons",
    "OrgNr": "496438",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "perspiciatis",
    "DirectPhone": "(247)212-1101 x070",
    "AssociateId": 134,
    "CountryId": 845,
    "EmailAddress": "ilene_murazik@willms.biz",
    "Kananame": "laudantium",
    "EmailAddressName": "steve.langosh@blockquitzon.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lester Gerhold",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatem",
    "FullName": "Selena Quigley",
    "IsOwnerContact": false,
    "ActiveErpLinks": 244
  },
  "Country": {
    "CountryId": 28,
    "Name": "Mertz Group",
    "CurrencyId": 622,
    "EnglishName": "Russel Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Reverse-engineered contextually-based function",
    "OrgNrText": "1140677",
    "InterAreaPrefix": "unde",
    "DialInPrefix": "sunt",
    "ZipPrefix": "aut",
    "DomainName": "Ondricka-Boehm",
    "AddressLayoutId": 298,
    "DomesticAddressLayoutId": 660,
    "ForeignAddressLayoutId": 584,
    "Rank": 519,
    "Tooltip": "cum",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 826,
      "Name": "Klein, Kassulke and Hettinger",
      "ToolTip": "Ut accusamus nihil veniam quae maxime.",
      "Deleted": false,
      "Rank": 324,
      "Type": "vel",
      "ColorBlock": 20,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2007-07-03T15:05:42.4126686+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "voluptates",
      "Hidden": false,
      "FullName": "Vincenzo Wehner"
    }
  ],
  "PersonNumber": "448364",
  "FullName": "Aurelie Nikolaus",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ad",
      "StrippedValue": "culpa",
      "Description": "Upgradable systemic architecture"
    },
    {
      "Value": "ad",
      "StrippedValue": "culpa",
      "Description": "Upgradable systemic architecture"
    }
  ],
  "FormalName": "Tillman, Zemlak and Rowe",
  "Address": {
    "Wgs84Latitude": 25551.502,
    "Wgs84Longitude": 26501.104,
    "LocalizedAddress": [
      [
        {
          "Name": "Lindgren-Bednar",
          "Value": "est",
          "Tooltip": "labore",
          "Label": "sint",
          "ValueLength": 788,
          "AddressType": "consequatur",
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
              "FieldLength": 33
            }
          }
        }
      ],
      [
        {
          "Name": "Abshire-Torp",
          "Value": "cumque",
          "Tooltip": "quo",
          "Label": "laudantium",
          "ValueLength": 438,
          "AddressType": "accusantium",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "drive efficient interfaces"
              },
              "FieldType": "System.String",
              "FieldLength": 36
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "labore"
  },
  "Post3": "iste",
  "Post2": "tempora",
  "Post1": "alias",
  "Kanalname": "eveniet",
  "Kanafname": "ut",
  "CorrespondingAssociate": {
    "AssociateId": 962,
    "Name": "Schroeder-Willms",
    "PersonId": 621,
    "Rank": 843,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 25,
    "FullName": "Lou Kuhic",
    "FormalName": "Metz Group",
    "Deleted": false,
    "EjUserId": 577,
    "UserName": "Stark-Wehner"
  },
  "Category": {
    "Id": 999,
    "Value": "voluptas",
    "Tooltip": "eum"
  },
  "Business": {
    "Id": 215,
    "Value": "eos",
    "Tooltip": "tenetur"
  },
  "Associate": {
    "AssociateId": 539,
    "Name": "Schimmel-Muller",
    "PersonId": 813,
    "Rank": 339,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 39,
    "FullName": "Mr. Hayley Kertzmann",
    "FormalName": "Bernhard-Graham",
    "Deleted": false,
    "EjUserId": 718,
    "UserName": "Weber Inc and Sons"
  },
  "Salutation": "exercitationem",
  "ActiveInterests": 965,
  "SupportAssociate": {
    "AssociateId": 422,
    "Name": "Hintz Inc and Sons",
    "PersonId": 630,
    "Rank": 235,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 265,
    "FullName": "Miss King Schaefer",
    "FormalName": "Purdy-Jenkins",
    "Deleted": false,
    "EjUserId": 815,
    "UserName": "Yost, Lehner and Hane"
  },
  "TicketPriority": {
    "Id": 924,
    "Value": "molestiae",
    "Tooltip": "nihil"
  },
  "CustomerLanguage": {
    "Id": 418,
    "Value": "aliquam",
    "Tooltip": "et"
  },
  "DbiAgentId": 664,
  "DbiKey": "nostrum",
  "DbiLastModified": "2000-12-14T15:05:42.4156669+01:00",
  "DbiLastSyncronized": "1996-04-03T15:05:42.4156669+02:00",
  "SentInfo": 91,
  "ShowContactTickets": 806,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 573,
    "UserName": "Dare-Moen",
    "PersonId": 376,
    "Rank": 713,
    "Tooltip": "adipisci",
    "UserGroupId": 460,
    "EjUserId": 523,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "in",
      "necessitatibus"
    ],
    "CanLogon": false,
    "RoleName": "Von-Prohaska",
    "RoleTooltip": "aut",
    "UserGroupName": "Beatty Inc and Sons",
    "UserGroupTooltip": "adipisci"
  },
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "hic",
      "Description": "Multi-tiered scalable ability"
    },
    {
      "Value": "qui",
      "StrippedValue": "hic",
      "Description": "Multi-tiered scalable ability"
    }
  ],
  "InternetPhones": [
    {
      "Value": "esse",
      "StrippedValue": "voluptatem",
      "Description": "Fully-configurable value-added conglomeration"
    },
    {
      "Value": "esse",
      "StrippedValue": "voluptatem",
      "Description": "Fully-configurable value-added conglomeration"
    }
  ],
  "Source": 835,
  "ActiveErpLinks": 228,
  "ShipmentTypes": [
    {
      "Id": 960,
      "Name": "Swift-Goldner",
      "ToolTip": "Nobis quas.",
      "Deleted": false,
      "Rank": 306,
      "Type": "iure",
      "ColorBlock": 245,
      "IconHint": "unde",
      "Selected": true,
      "LastChanged": "2017-01-18T15:05:42.4156669+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "dignissimos",
      "Hidden": false,
      "FullName": "Alfredo Marks"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 740,
      "Comment": "error",
      "Registered": "2002-05-19T15:05:42.4156669+02:00",
      "RegisteredAssociateId": 573,
      "Updated": "2017-12-02T15:05:42.4156669+01:00",
      "UpdatedAssociateId": 977,
      "LegalBaseId": 488,
      "LegalBaseKey": "aut",
      "LegalBaseName": "Lubowitz Inc and Sons",
      "ConsentPurposeId": 764,
      "ConsentPurposeKey": "tempora",
      "ConsentPurposeName": "Okuneva, Oberbrunner and Kozey",
      "ConsentSourceId": 424,
      "ConsentSourceKey": "voluptatibus",
      "ConsentSourceName": "Torp, Wuckert and Roberts"
    }
  ],
  "BounceEmails": [
    "haylie.gerlach@kochgutmann.ca",
    "bo@zulauf.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1117143808",
    "SuperOffice:2": "1600756691"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "natus"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "officia",
  "2": "non"
}
```