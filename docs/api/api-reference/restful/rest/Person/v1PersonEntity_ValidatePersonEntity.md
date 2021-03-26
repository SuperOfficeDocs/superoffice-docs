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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 326,
  "Firstname": "Sibyl",
  "MiddleName": "Kunde-Terry",
  "Lastname": "Gorczany",
  "Mrmrs": "et",
  "Title": "et",
  "UpdatedDate": "2010-10-17T09:40:59.3866657+02:00",
  "CreatedDate": "2008-07-30T09:40:59.3866657+02:00",
  "BirthDate": "1994-02-16T09:40:59.3866657+01:00",
  "CreatedBy": {
    "AssociateId": 881,
    "Name": "Brown, Mayert and Treutel",
    "PersonId": 995,
    "Rank": 283,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 620,
    "FullName": "Mikel Mertz",
    "FormalName": "Rogahn, Reichert and Botsford",
    "Deleted": true,
    "EjUserId": 461,
    "UserName": "Durgan, Greenfelder and Aufderhar"
  },
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "deleniti",
      "Description": "Cloned optimizing hierarchy"
    },
    {
      "Value": "qui",
      "StrippedValue": "deleniti",
      "Description": "Cloned optimizing hierarchy"
    }
  ],
  "Description": "Vision-oriented tertiary info-mediaries",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "ut",
      "Description": "Multi-lateral human-resource capacity"
    },
    {
      "Value": "dolores",
      "StrippedValue": "ut",
      "Description": "Multi-lateral human-resource capacity"
    }
  ],
  "Faxes": [
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Decentralized national middleware"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Decentralized national middleware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "sit",
      "Description": "Adaptive directional moratorium"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "sit",
      "Description": "Adaptive directional moratorium"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "beatae",
      "Description": "De-engineered scalable support"
    },
    {
      "Value": "sunt",
      "StrippedValue": "beatae",
      "Description": "De-engineered scalable support"
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "commodi",
      "Description": "Ergonomic intangible function"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "commodi",
      "Description": "Ergonomic intangible function"
    }
  ],
  "Position": {
    "Id": 254,
    "Value": "maxime",
    "Tooltip": "aut"
  },
  "UpdatedBy": {
    "AssociateId": 553,
    "Name": "Weimann, Donnelly and Erdman",
    "PersonId": 664,
    "Rank": 147,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 885,
    "FullName": "Skyla Dietrich",
    "FormalName": "Wuckert-Jakubowski",
    "Deleted": false,
    "EjUserId": 271,
    "UserName": "Paucek Inc and Sons"
  },
  "Contact": {
    "ContactId": 221,
    "Name": "Dooley Group",
    "OrgNr": "1067310",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "consequatur",
    "DirectPhone": "406-748-8308 x77174",
    "AssociateId": 48,
    "CountryId": 136,
    "EmailAddress": "roscoe@kozey.us",
    "Kananame": "nobis",
    "EmailAddressName": "fanny_ziemann@feilkunde.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sallie Koelpin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "molestiae",
    "FullName": "Angel Stehr",
    "IsOwnerContact": true,
    "ActiveErpLinks": 737
  },
  "Country": {
    "CountryId": 373,
    "Name": "Bayer-Hoeger",
    "CurrencyId": 403,
    "EnglishName": "Armstrong, Smitham and Wilkinson",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Customer-focused encompassing access",
    "OrgNrText": "1167727",
    "InterAreaPrefix": "accusamus",
    "DialInPrefix": "iste",
    "ZipPrefix": "accusantium",
    "DomainName": "Nienow-Hirthe",
    "AddressLayoutId": 144,
    "DomesticAddressLayoutId": 461,
    "ForeignAddressLayoutId": 609,
    "Rank": 584,
    "Tooltip": "aut",
    "Deleted": true
  },
  "Interests": [
    {
      "Id": 611,
      "Name": "Crooks-Lowe",
      "ToolTip": "Et rerum et rerum officiis reiciendis est.",
      "Deleted": true,
      "Rank": 358,
      "Type": "nisi",
      "ColorBlock": 121,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2004-04-28T09:40:59.3896658+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Stephon Walker"
    }
  ],
  "PersonNumber": "1081483",
  "FullName": "Sam Mraz",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "corrupti",
      "StrippedValue": "tempora",
      "Description": "Extended mission-critical project"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "tempora",
      "Description": "Extended mission-critical project"
    }
  ],
  "FormalName": "Mann LLC",
  "Address": {
    "Wgs84Latitude": 629.934,
    "Wgs84Longitude": 12880.74,
    "LocalizedAddress": [
      [
        {
          "Name": "Kuhic LLC",
          "Value": "esse",
          "Tooltip": "odit",
          "Label": "repudiandae",
          "ValueLength": 156,
          "AddressType": "ad",
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
              "FieldLength": 909
            }
          }
        }
      ],
      [
        {
          "Name": "Shanahan-Auer",
          "Value": "non",
          "Tooltip": "labore",
          "Label": "laboriosam",
          "ValueLength": 895,
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
              "FieldType": "System.String",
              "FieldLength": 307
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "vitae"
  },
  "Post3": "et",
  "Post2": "enim",
  "Post1": "eaque",
  "Kanalname": "facere",
  "Kanafname": "qui",
  "CorrespondingAssociate": {
    "AssociateId": 459,
    "Name": "Kub LLC",
    "PersonId": 696,
    "Rank": 196,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 994,
    "FullName": "Mr. Gavin Effertz",
    "FormalName": "Quitzon Inc and Sons",
    "Deleted": false,
    "EjUserId": 324,
    "UserName": "Torphy Group"
  },
  "Category": {
    "Id": 844,
    "Value": "blanditiis",
    "Tooltip": "in"
  },
  "Business": {
    "Id": 749,
    "Value": "saepe",
    "Tooltip": "corrupti"
  },
  "Associate": {
    "AssociateId": 841,
    "Name": "Kemmer, Dare and Rau",
    "PersonId": 174,
    "Rank": 684,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 747,
    "FullName": "Yvette Hickle",
    "FormalName": "Effertz-Eichmann",
    "Deleted": true,
    "EjUserId": 715,
    "UserName": "Kautzer-Frami"
  },
  "Salutation": "est",
  "ActiveInterests": 368,
  "SupportAssociate": {
    "AssociateId": 10,
    "Name": "Wehner Group",
    "PersonId": 647,
    "Rank": 68,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 245,
    "FullName": "Orie Thompson",
    "FormalName": "Corwin, Conroy and Mann",
    "Deleted": true,
    "EjUserId": 701,
    "UserName": "Borer LLC"
  },
  "TicketPriority": {
    "Id": 92,
    "Value": "amet",
    "Tooltip": "voluptas"
  },
  "CustomerLanguage": {
    "Id": 180,
    "Value": "inventore",
    "Tooltip": "illo"
  },
  "DbiAgentId": 827,
  "DbiKey": "impedit",
  "DbiLastModified": "1994-08-23T09:40:59.3916657+02:00",
  "DbiLastSyncronized": "2000-10-31T09:40:59.3916657+01:00",
  "SentInfo": 963,
  "ShowContactTickets": 455,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 80,
    "UserName": "Howe Inc and Sons",
    "PersonId": 905,
    "Rank": 437,
    "Tooltip": "ut",
    "UserGroupId": 565,
    "EjUserId": 322,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "repellat",
      "minima"
    ],
    "CanLogon": false,
    "RoleName": "Quitzon LLC",
    "RoleTooltip": "quod",
    "UserGroupName": "Ward-Lindgren",
    "UserGroupTooltip": "similique"
  },
  "ChatEmails": [
    {
      "Value": "quasi",
      "StrippedValue": "dolor",
      "Description": "Integrated mission-critical open system"
    },
    {
      "Value": "quasi",
      "StrippedValue": "dolor",
      "Description": "Integrated mission-critical open system"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "aspernatur",
      "Description": "Versatile eco-centric pricing structure"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "aspernatur",
      "Description": "Versatile eco-centric pricing structure"
    }
  ],
  "Source": 202,
  "ActiveErpLinks": 95,
  "ShipmentTypes": [
    {
      "Id": 616,
      "Name": "Donnelly-Kunde",
      "ToolTip": "Ipsam provident.",
      "Deleted": true,
      "Rank": 862,
      "Type": "ex",
      "ColorBlock": 343,
      "IconHint": "officia",
      "Selected": true,
      "LastChanged": "1998-02-20T09:40:59.3916657+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Theron Gerhold"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 404,
      "Comment": "atque",
      "Registered": "2015-06-03T09:40:59.3926654+02:00",
      "RegisteredAssociateId": 424,
      "Updated": "2017-04-27T09:40:59.3926654+02:00",
      "UpdatedAssociateId": 385,
      "LegalBaseId": 857,
      "LegalBaseKey": "facilis",
      "LegalBaseName": "Kilback, Hegmann and Cremin",
      "ConsentPurposeId": 517,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Hamill LLC",
      "ConsentSourceId": 253,
      "ConsentSourceKey": "velit",
      "ConsentSourceName": "Wisozk-Gaylord"
    }
  ],
  "BounceEmails": [
    "zachary@wehner.com",
    "trever.nader@hamill.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "924681185",
    "SuperOffice:2": "Jeromy Hammes"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "error",
    "CustomFields2": "ab"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "reprehenderit",
  "2": "aut"
}
```