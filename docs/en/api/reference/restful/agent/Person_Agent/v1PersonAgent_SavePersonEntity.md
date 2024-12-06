---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
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
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | Integer | The form id of the form that created the person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 210,
  "Firstname": "Waylon",
  "MiddleName": "Schowalter, Bogan and Moen",
  "Lastname": "Durgan",
  "Mrmrs": "sint",
  "Title": "tenetur",
  "UpdatedDate": "2015-05-12T10:17:55.7696734+02:00",
  "CreatedDate": "2011-11-10T10:17:55.7696734+01:00",
  "BirthDate": "2000-03-25T10:17:55.7696734+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aperiam",
      "StrippedValue": "doloremque",
      "Description": "Up-sized needs-based definition"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "doloremque",
      "Description": "Up-sized needs-based definition"
    }
  ],
  "Description": "Optional full-range portal",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "cum",
      "StrippedValue": "in",
      "Description": "Front-line regional framework"
    },
    {
      "Value": "cum",
      "StrippedValue": "in",
      "Description": "Front-line regional framework"
    }
  ],
  "Faxes": [
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Polarised background project"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Polarised background project"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "est",
      "Description": "Secured background solution"
    },
    {
      "Value": "sed",
      "StrippedValue": "est",
      "Description": "Secured background solution"
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "impedit",
      "Description": "Team-oriented static portal"
    },
    {
      "Value": "qui",
      "StrippedValue": "impedit",
      "Description": "Team-oriented static portal"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Function-based holistic capability"
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Function-based holistic capability"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 435,
      "Name": "Price-Littel",
      "ToolTip": "Esse rerum rerum ut repellat.",
      "Deleted": false,
      "Rank": 980,
      "Type": "id",
      "ColorBlock": 174,
      "IconHint": "temporibus",
      "Selected": false,
      "LastChanged": "1998-02-25T10:17:55.7696734+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "ratione",
      "Hidden": false,
      "FullName": "Lorna Skiles"
    }
  ],
  "PersonNumber": "465551",
  "FullName": "Lauretta Simonis",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "dolor",
      "Description": "Proactive bottom-line frame"
    },
    {
      "Value": "quia",
      "StrippedValue": "dolor",
      "Description": "Proactive bottom-line frame"
    }
  ],
  "FormalName": "Senger, Ferry and Koss",
  "Address": null,
  "Post3": "unde",
  "Post2": "placeat",
  "Post1": "dignissimos",
  "Kanalname": "doloremque",
  "Kanafname": "quae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "maxime",
  "ActiveInterests": 264,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 776,
  "DbiKey": "molestiae",
  "DbiLastModified": "2008-04-09T10:17:55.7852996+02:00",
  "DbiLastSyncronized": "2017-01-12T10:17:55.7852996+01:00",
  "SentInfo": 128,
  "ShowContactTickets": 465,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nostrum",
      "StrippedValue": "facilis",
      "Description": "Organized grid-enabled firmware"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "facilis",
      "Description": "Organized grid-enabled firmware"
    }
  ],
  "InternetPhones": [
    {
      "Value": "pariatur",
      "StrippedValue": "incidunt",
      "Description": "Self-enabling grid-enabled moderator"
    },
    {
      "Value": "pariatur",
      "StrippedValue": "incidunt",
      "Description": "Self-enabling grid-enabled moderator"
    }
  ],
  "Source": 605,
  "ActiveErpLinks": 257,
  "ShipmentTypes": [
    {
      "Id": 21,
      "Name": "Haag-Kuphal",
      "ToolTip": "Rerum ratione aspernatur ad non et officiis inventore.",
      "Deleted": true,
      "Rank": 782,
      "Type": "non",
      "ColorBlock": 74,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2013-12-15T10:17:55.7852996+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Prof. Claudie Feil"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 765,
      "Comment": "est",
      "Registered": "2024-07-14T10:17:55.7852996+02:00",
      "RegisteredAssociateId": 166,
      "Updated": "2013-05-23T10:17:55.7852996+02:00",
      "UpdatedAssociateId": 712,
      "LegalBaseId": 397,
      "LegalBaseKey": "nemo",
      "LegalBaseName": "Wyman Group",
      "ConsentPurposeId": 470,
      "ConsentPurposeKey": "atque",
      "ConsentPurposeName": "Ebert Group",
      "ConsentSourceId": 73,
      "ConsentSourceKey": "vel",
      "ConsentSourceName": "West-Lang"
    }
  ],
  "BounceEmails": [
    "marjorie_boyer@vonrueden.biz",
    "lina.simonis@nader.com"
  ],
  "ActiveStatusMonitorId": 323,
  "CreatedByFormId": 348,
  "UserDefinedFields": {
    "SuperOffice:1": "528385992",
    "SuperOffice:2": "Ms. Soledad Ashtyn Beier"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "excepturi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 991,
  "Firstname": "Liliana",
  "MiddleName": "Gaylord-Windler",
  "Lastname": "Gutmann",
  "Mrmrs": "ea",
  "Title": "dolores",
  "UpdatedDate": "2005-12-17T10:17:55.7852996+01:00",
  "CreatedDate": "2006-03-17T10:17:55.7852996+01:00",
  "BirthDate": "2022-01-30T10:17:55.7852996+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "nihil",
      "Description": "Open-source grid-enabled neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "nihil",
      "Description": "Open-source grid-enabled neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "Description": "Reactive hybrid Graphic Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ex",
      "StrippedValue": "in",
      "Description": "Extended heuristic data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "in",
      "Description": "Extended heuristic data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "autem",
      "Description": "Adaptive cohesive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "autem",
      "Description": "Adaptive cohesive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "doloribus",
      "Description": "Persevering assymetric product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "doloribus",
      "Description": "Persevering assymetric product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "facere",
      "StrippedValue": "reprehenderit",
      "Description": "Configurable demand-driven encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 984
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "reprehenderit",
      "Description": "Configurable demand-driven encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 984
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "facere",
      "StrippedValue": "qui",
      "Description": "Reactive bifurcated software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "qui",
      "Description": "Reactive bifurcated software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 662
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 3,
      "Name": "Harvey, Krajcik and Waelchi",
      "ToolTip": "Quibusdam quis minus tempore et ut alias.",
      "Deleted": false,
      "Rank": 87,
      "Type": "tenetur",
      "ColorBlock": 241,
      "IconHint": "nesciunt",
      "Selected": false,
      "LastChanged": "2019-09-21T10:17:55.7852996+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "cum",
      "Hidden": true,
      "FullName": "Miss Abraham Herzog DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "PersonNumber": "979580",
  "FullName": "Camila O'Conner",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "officia",
      "Description": "Focused systemic matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "officia",
      "Description": "Focused systemic matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "FormalName": "Heidenreich Inc and Sons",
  "Address": null,
  "Post3": "accusamus",
  "Post2": "perspiciatis",
  "Post1": "iusto",
  "Kanalname": "aut",
  "Kanafname": "dolor",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "provident",
  "ActiveInterests": 337,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 599,
  "DbiKey": "et",
  "DbiLastModified": "2023-01-26T10:17:55.7852996+01:00",
  "DbiLastSyncronized": "2001-12-22T10:17:55.7852996+01:00",
  "SentInfo": 751,
  "ShowContactTickets": 224,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "earum",
      "StrippedValue": "nesciunt",
      "Description": "Enterprise-wide bandwidth-monitored ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "nesciunt",
      "Description": "Enterprise-wide bandwidth-monitored ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "deleniti",
      "Description": "Function-based maximized complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "deleniti",
      "Description": "Function-based maximized complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "Source": 231,
  "ActiveErpLinks": 405,
  "ShipmentTypes": [
    {
      "Id": 148,
      "Name": "O'Reilly Inc and Sons",
      "ToolTip": "Minima aut id quia veniam facere nihil dolores.",
      "Deleted": true,
      "Rank": 443,
      "Type": "qui",
      "ColorBlock": 550,
      "IconHint": "blanditiis",
      "Selected": true,
      "LastChanged": "2022-01-28T10:17:55.7852996+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Montana Jacobs",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 330,
      "Comment": "harum",
      "Registered": "2024-01-25T10:17:55.7852996+01:00",
      "RegisteredAssociateId": 797,
      "Updated": "2009-05-28T10:17:55.7852996+02:00",
      "UpdatedAssociateId": 731,
      "LegalBaseId": 257,
      "LegalBaseKey": "tempora",
      "LegalBaseName": "Fay Inc and Sons",
      "ConsentPurposeId": 849,
      "ConsentPurposeKey": "sint",
      "ConsentPurposeName": "Okuneva LLC",
      "ConsentSourceId": 902,
      "ConsentSourceKey": "ab",
      "ConsentSourceName": "Emmerich, Abshire and Adams",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "BounceEmails": [
    "kenya_thiel@rohanbogisich.co.uk",
    "josianne.stracke@faheysporer.us"
  ],
  "ActiveStatusMonitorId": 864,
  "CreatedByFormId": 774,
  "UserDefinedFields": {
    "SuperOffice:1": "Dasia Gottlieb MD",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "numquam",
    "CustomFields2": "quo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 436
    }
  }
}
```