---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 928,
  "Firstname": "Stella",
  "MiddleName": "Gutmann Group",
  "Lastname": "Jacobi",
  "Mrmrs": "eum",
  "Title": "sint",
  "UpdatedDate": "2017-04-04T17:37:18.3732436+02:00",
  "CreatedDate": "1999-04-05T17:37:18.3732436+02:00",
  "BirthDate": "2017-02-11T17:37:18.3732436+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "occaecati",
      "Description": "Intuitive global support"
    },
    {
      "Value": "et",
      "StrippedValue": "occaecati",
      "Description": "Intuitive global support"
    }
  ],
  "Description": "User-centric heuristic info-mediaries",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ullam",
      "StrippedValue": "distinctio",
      "Description": "Implemented methodical pricing structure"
    },
    {
      "Value": "ullam",
      "StrippedValue": "distinctio",
      "Description": "Implemented methodical pricing structure"
    }
  ],
  "Faxes": [
    {
      "Value": "praesentium",
      "StrippedValue": "quasi",
      "Description": "Adaptive disintermediate circuit"
    },
    {
      "Value": "praesentium",
      "StrippedValue": "quasi",
      "Description": "Adaptive disintermediate circuit"
    }
  ],
  "MobilePhones": [
    {
      "Value": "inventore",
      "StrippedValue": "et",
      "Description": "Virtual dedicated functionalities"
    },
    {
      "Value": "inventore",
      "StrippedValue": "et",
      "Description": "Virtual dedicated functionalities"
    }
  ],
  "OfficePhones": [
    {
      "Value": "illum",
      "StrippedValue": "nesciunt",
      "Description": "Enterprise-wide content-based Graphic Interface"
    },
    {
      "Value": "illum",
      "StrippedValue": "nesciunt",
      "Description": "Enterprise-wide content-based Graphic Interface"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Reduced attitude-oriented website"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ut",
      "Description": "Reduced attitude-oriented website"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 673,
      "Name": "Metz-Goodwin",
      "ToolTip": "Placeat dolorem labore harum blanditiis quo.",
      "Deleted": true,
      "Rank": 669,
      "Type": "qui",
      "ColorBlock": 545,
      "IconHint": "corrupti",
      "Selected": true,
      "LastChanged": "2005-01-23T17:37:18.3762443+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "praesentium",
      "Hidden": false,
      "FullName": "Miss Neil Marisa Fritsch"
    }
  ],
  "PersonNumber": "1717243",
  "FullName": "Wava Sipes",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "praesentium",
      "Description": "Configurable impactful customer loyalty"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "praesentium",
      "Description": "Configurable impactful customer loyalty"
    }
  ],
  "FormalName": "Hand Inc and Sons",
  "Address": null,
  "Post3": "ipsum",
  "Post2": "voluptatem",
  "Post1": "et",
  "Kanalname": "velit",
  "Kanafname": "amet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rem",
  "ActiveInterests": 1001,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 212,
  "DbiKey": "dolores",
  "DbiLastModified": "2021-11-30T17:37:18.3792434+01:00",
  "DbiLastSyncronized": "2000-02-29T17:37:18.3792434+01:00",
  "SentInfo": 418,
  "ShowContactTickets": 511,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "quaerat",
      "Description": "Function-based interactive algorithm"
    },
    {
      "Value": "et",
      "StrippedValue": "quaerat",
      "Description": "Function-based interactive algorithm"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quos",
      "StrippedValue": "accusantium",
      "Description": "Triple-buffered demand-driven instruction set"
    },
    {
      "Value": "quos",
      "StrippedValue": "accusantium",
      "Description": "Triple-buffered demand-driven instruction set"
    }
  ],
  "Source": 404,
  "ActiveErpLinks": 997,
  "ShipmentTypes": [
    {
      "Id": 938,
      "Name": "Cole, King and Yundt",
      "ToolTip": "Expedita voluptatibus quo voluptatem perferendis.",
      "Deleted": false,
      "Rank": 273,
      "Type": "sunt",
      "ColorBlock": 913,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "2012-11-19T17:37:18.3792434+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "perspiciatis",
      "Hidden": false,
      "FullName": "Grayson Powlowski"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 488,
      "Comment": "temporibus",
      "Registered": "2009-11-01T17:37:18.3792434+01:00",
      "RegisteredAssociateId": 99,
      "Updated": "1998-07-03T17:37:18.3792434+02:00",
      "UpdatedAssociateId": 776,
      "LegalBaseId": 436,
      "LegalBaseKey": "veniam",
      "LegalBaseName": "Conn-Blanda",
      "ConsentPurposeId": 174,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Swift, Swift and Ullrich",
      "ConsentSourceId": 306,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Jakubowski-Pollich"
    }
  ],
  "BounceEmails": [
    "christy@lakinlubowitz.co.uk",
    "destin_gottlieb@huels.co.uk"
  ],
  "ActiveStatusMonitorId": 943,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dannie Dach"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "itaque"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "numquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 522,
  "Firstname": "Emily",
  "MiddleName": "Toy Group",
  "Lastname": "White",
  "Mrmrs": "soluta",
  "Title": "et",
  "UpdatedDate": "1998-06-16T17:37:18.3892422+02:00",
  "CreatedDate": "2007-11-25T17:37:18.3892422+01:00",
  "BirthDate": "2020-07-26T17:37:18.3892422+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quis",
      "StrippedValue": "dicta",
      "Description": "Secured responsive orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "dicta",
      "Description": "Secured responsive orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 453
        }
      }
    }
  ],
  "Description": "Automated multimedia definition",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aut",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented 24/7 solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "perferendis",
      "Description": "Vision-oriented 24/7 solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quod",
      "StrippedValue": "autem",
      "Description": "Multi-lateral dynamic access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "autem",
      "Description": "Multi-lateral dynamic access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Upgradable cohesive toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Upgradable cohesive toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 18
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "rem",
      "StrippedValue": "dignissimos",
      "Description": "Configurable intermediate framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "dignissimos",
      "Description": "Configurable intermediate framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "dignissimos",
      "Description": "Adaptive homogeneous success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "dignissimos",
      "Description": "Adaptive homogeneous success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
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
      "Id": 592,
      "Name": "Predovic-Glover",
      "ToolTip": "Et ea et et dolorem itaque dicta.",
      "Deleted": false,
      "Rank": 672,
      "Type": "quod",
      "ColorBlock": 197,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2015-07-14T17:37:18.3912416+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "fuga",
      "Hidden": false,
      "FullName": "Beulah Huel MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 762
        }
      }
    }
  ],
  "PersonNumber": "844652",
  "FullName": "Miss Lulu Monahan",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "natus",
      "StrippedValue": "quod",
      "Description": "Sharable coherent budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "quod",
      "Description": "Sharable coherent budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "FormalName": "Bashirian Group",
  "Address": null,
  "Post3": "est",
  "Post2": "ipsam",
  "Post1": "sit",
  "Kanalname": "corrupti",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sed",
  "ActiveInterests": 308,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 388,
  "DbiKey": "inventore",
  "DbiLastModified": "2020-11-20T17:37:18.394242+01:00",
  "DbiLastSyncronized": "2015-12-22T17:37:18.394242+01:00",
  "SentInfo": 58,
  "ShowContactTickets": 911,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "maxime",
      "StrippedValue": "aut",
      "Description": "Mandatory exuding process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "aut",
      "Description": "Mandatory exuding process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 578
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "magnam",
      "StrippedValue": "perferendis",
      "Description": "Advanced secondary secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "perferendis",
      "Description": "Advanced secondary secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "Source": 570,
  "ActiveErpLinks": 598,
  "ShipmentTypes": [
    {
      "Id": 447,
      "Name": "Baumbach, Ritchie and McClure",
      "ToolTip": "Voluptatem ex et doloribus voluptatibus et eligendi.",
      "Deleted": true,
      "Rank": 962,
      "Type": "quas",
      "ColorBlock": 122,
      "IconHint": "porro",
      "Selected": false,
      "LastChanged": "2014-06-18T17:37:18.3952416+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "aliquid",
      "Hidden": false,
      "FullName": "Katarina Kertzmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 963,
      "Comment": "voluptas",
      "Registered": "2000-10-02T17:37:18.3952416+02:00",
      "RegisteredAssociateId": 948,
      "Updated": "2014-03-31T17:37:18.3952416+02:00",
      "UpdatedAssociateId": 56,
      "LegalBaseId": 655,
      "LegalBaseKey": "facere",
      "LegalBaseName": "Ryan, Thompson and Baumbach",
      "ConsentPurposeId": 117,
      "ConsentPurposeKey": "exercitationem",
      "ConsentPurposeName": "Heaney-Feest",
      "ConsentSourceId": 911,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Hilll-Stracke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "BounceEmails": [
    "lelia.larson@rodriguezkertzmann.co.uk",
    "susanna@anderson.name"
  ],
  "ActiveStatusMonitorId": 33,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Mya Lynch",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "occaecati"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 514
    }
  }
}
```