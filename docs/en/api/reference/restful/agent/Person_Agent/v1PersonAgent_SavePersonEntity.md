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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 905,
  "Firstname": "Irwin",
  "MiddleName": "Bosco Group",
  "Lastname": "Bogan",
  "Mrmrs": "omnis",
  "Title": "quia",
  "UpdatedDate": "2023-05-04T13:13:23.3989026+02:00",
  "CreatedDate": "2024-03-08T13:13:23.3989026+01:00",
  "BirthDate": "2017-06-22T13:13:23.3989026+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptate",
      "StrippedValue": "ipsum",
      "Description": "Robust bifurcated Graphic Interface"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "ipsum",
      "Description": "Robust bifurcated Graphic Interface"
    }
  ],
  "Description": "Advanced heuristic algorithm",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "officiis",
      "StrippedValue": "explicabo",
      "Description": "Switchable upward-trending website"
    },
    {
      "Value": "officiis",
      "StrippedValue": "explicabo",
      "Description": "Switchable upward-trending website"
    }
  ],
  "Faxes": [
    {
      "Value": "atque",
      "StrippedValue": "et",
      "Description": "Fully-configurable bottom-line concept"
    },
    {
      "Value": "atque",
      "StrippedValue": "et",
      "Description": "Fully-configurable bottom-line concept"
    }
  ],
  "MobilePhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "debitis",
      "Description": "Digitized interactive encryption"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "debitis",
      "Description": "Digitized interactive encryption"
    }
  ],
  "OfficePhones": [
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Down-sized assymetric local area network"
    },
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Down-sized assymetric local area network"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quidem",
      "StrippedValue": "natus",
      "Description": "Virtual executive moratorium"
    },
    {
      "Value": "quidem",
      "StrippedValue": "natus",
      "Description": "Virtual executive moratorium"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 283,
      "Name": "Lakin-Cartwright",
      "ToolTip": "Et doloribus cupiditate dolor repudiandae suscipit quia.",
      "Deleted": false,
      "Rank": 231,
      "Type": "voluptatibus",
      "ColorBlock": 64,
      "IconHint": "consectetur",
      "Selected": true,
      "LastChanged": "2014-04-08T13:13:23.3989026+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Mrs. Jesus Fadel III"
    }
  ],
  "PersonNumber": "1415443",
  "FullName": "Malachi Ondricka",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "quo",
      "Description": "Total well-modulated paradigm"
    },
    {
      "Value": "hic",
      "StrippedValue": "quo",
      "Description": "Total well-modulated paradigm"
    }
  ],
  "FormalName": "Kerluke-Harber",
  "Address": null,
  "Post3": "debitis",
  "Post2": "ipsa",
  "Post1": "voluptatum",
  "Kanalname": "dolorem",
  "Kanafname": "eos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequatur",
  "ActiveInterests": 441,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 797,
  "DbiKey": "quas",
  "DbiLastModified": "2015-07-29T13:13:23.3989026+02:00",
  "DbiLastSyncronized": "2019-02-12T13:13:23.3989026+01:00",
  "SentInfo": 245,
  "ShowContactTickets": 844,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vel",
      "StrippedValue": "qui",
      "Description": "Phased tangible emulation"
    },
    {
      "Value": "vel",
      "StrippedValue": "qui",
      "Description": "Phased tangible emulation"
    }
  ],
  "InternetPhones": [
    {
      "Value": "debitis",
      "StrippedValue": "dolores",
      "Description": "Multi-tiered composite standardization"
    },
    {
      "Value": "debitis",
      "StrippedValue": "dolores",
      "Description": "Multi-tiered composite standardization"
    }
  ],
  "Source": 935,
  "ActiveErpLinks": 876,
  "ShipmentTypes": [
    {
      "Id": 283,
      "Name": "Goodwin, Brekke and Stokes",
      "ToolTip": "Occaecati quasi ea suscipit cum et.",
      "Deleted": false,
      "Rank": 717,
      "Type": "nostrum",
      "ColorBlock": 565,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2004-05-17T13:13:23.3989026+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "temporibus",
      "Hidden": true,
      "FullName": "Fredy Thora Kassulke DVM"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 764,
      "Comment": "praesentium",
      "Registered": "2010-12-07T13:13:23.3989026+01:00",
      "RegisteredAssociateId": 546,
      "Updated": "2000-05-01T13:13:23.3989026+02:00",
      "UpdatedAssociateId": 602,
      "LegalBaseId": 482,
      "LegalBaseKey": "illo",
      "LegalBaseName": "Auer Group",
      "ConsentPurposeId": 470,
      "ConsentPurposeKey": "nulla",
      "ConsentPurposeName": "Hagenes LLC",
      "ConsentSourceId": 450,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Lowe-Walsh"
    }
  ],
  "BounceEmails": [
    "simeon_bradtke@sauer.uk",
    "devonte@kovacek.biz"
  ],
  "ActiveStatusMonitorId": 428,
  "CreatedByFormId": 192,
  "UserDefinedFields": {
    "SuperOffice:1": "Derick Barton",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "facere"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 886,
  "Firstname": "Joshua",
  "MiddleName": "Eichmann Inc and Sons",
  "Lastname": "Mann",
  "Mrmrs": "dolorem",
  "Title": "quia",
  "UpdatedDate": "2019-07-16T13:13:23.414523+02:00",
  "CreatedDate": "2023-09-08T13:13:23.414523+02:00",
  "BirthDate": "2017-02-05T13:13:23.414523+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "odit",
      "StrippedValue": "et",
      "Description": "Function-based multi-tasking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "et",
      "Description": "Function-based multi-tasking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    }
  ],
  "Description": "Down-sized national projection",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "corporis",
      "Description": "Enhanced non-volatile matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "corporis",
      "Description": "Enhanced non-volatile matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "magnam",
      "Description": "Automated scalable methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "magnam",
      "Description": "Automated scalable methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "earum",
      "Description": "Polarised next generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "earum",
      "Description": "Polarised next generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 465
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "non",
      "Description": "Organized demand-driven moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "non",
      "Description": "Organized demand-driven moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sunt",
      "StrippedValue": "veritatis",
      "Description": "Persevering value-added success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "veritatis",
      "Description": "Persevering value-added success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 431
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
      "Id": 475,
      "Name": "Collier Inc and Sons",
      "ToolTip": "Dolorum velit animi voluptatem.",
      "Deleted": false,
      "Rank": 834,
      "Type": "consequuntur",
      "ColorBlock": 218,
      "IconHint": "laboriosam",
      "Selected": false,
      "LastChanged": "2010-10-15T13:13:23.414523+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "distinctio",
      "Hidden": true,
      "FullName": "Khalil Lockman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    }
  ],
  "PersonNumber": "1154481",
  "FullName": "Janiya Ferry",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "accusamus",
      "StrippedValue": "modi",
      "Description": "Persistent bottom-line attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "modi",
      "Description": "Persistent bottom-line attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    }
  ],
  "FormalName": "Koepp-Brown",
  "Address": null,
  "Post3": "officiis",
  "Post2": "repudiandae",
  "Post1": "id",
  "Kanalname": "quam",
  "Kanafname": "nam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "natus",
  "ActiveInterests": 398,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 575,
  "DbiKey": "corrupti",
  "DbiLastModified": "2025-01-04T13:13:23.414523+01:00",
  "DbiLastSyncronized": "2003-02-04T13:13:23.414523+01:00",
  "SentInfo": 454,
  "ShowContactTickets": 659,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "optio",
      "StrippedValue": "consequuntur",
      "Description": "Front-line heuristic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "consequuntur",
      "Description": "Front-line heuristic groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 285
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "facere",
      "Description": "Upgradable solution-oriented matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "facere",
      "Description": "Upgradable solution-oriented matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 531
        }
      }
    }
  ],
  "Source": 688,
  "ActiveErpLinks": 833,
  "ShipmentTypes": [
    {
      "Id": 75,
      "Name": "Mante, Schumm and Moore",
      "ToolTip": "Qui iusto omnis enim architecto qui vitae.",
      "Deleted": true,
      "Rank": 743,
      "Type": "quod",
      "ColorBlock": 188,
      "IconHint": "sint",
      "Selected": true,
      "LastChanged": "2007-07-21T13:13:23.414523+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "a",
      "Hidden": true,
      "FullName": "Ms. Bianka Frederique Kilback PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 342
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 410,
      "Comment": "quis",
      "Registered": "2018-05-02T13:13:23.414523+02:00",
      "RegisteredAssociateId": 709,
      "Updated": "2018-01-28T13:13:23.414523+01:00",
      "UpdatedAssociateId": 526,
      "LegalBaseId": 703,
      "LegalBaseKey": "quibusdam",
      "LegalBaseName": "Weber Group",
      "ConsentPurposeId": 850,
      "ConsentPurposeKey": "perferendis",
      "ConsentPurposeName": "Sauer LLC",
      "ConsentSourceId": 541,
      "ConsentSourceKey": "quisquam",
      "ConsentSourceName": "Yost Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 537
        }
      }
    }
  ],
  "BounceEmails": [
    "carolyn@herzog.uk",
    "trystan@goldner.us"
  ],
  "ActiveStatusMonitorId": 218,
  "CreatedByFormId": 946,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Amy Roob",
    "SuperOffice:2": "727879156"
  },
  "ExtraFields": {
    "ExtraFields1": "delectus",
    "ExtraFields2": "corrupti"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 732
    }
  }
}
```