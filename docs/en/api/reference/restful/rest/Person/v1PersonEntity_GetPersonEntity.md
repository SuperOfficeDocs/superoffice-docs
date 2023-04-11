---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.


Calls the Person agent service GetPersonEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the PersonEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Person/{id}?$select=name,department,category/id
GET /api/v1/Person/{id}?fk=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

PersonEntity found.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 304 | PersonEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: PersonEntityWithLinks

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 11 May 1997 15:29:29 G5T

{
  "PersonId": 255,
  "Firstname": "Dominique",
  "MiddleName": "Schaefer, Lesch and Steuber",
  "Lastname": "Mann",
  "Mrmrs": "ut",
  "Title": "adipisci",
  "UpdatedDate": "1997-05-11T15:29:29.8401974+02:00",
  "CreatedDate": "2015-12-19T15:29:29.8401974+01:00",
  "BirthDate": "2019-01-17T15:29:29.8401974+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "temporibus",
      "StrippedValue": "magnam",
      "Description": "Enhanced dedicated productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "magnam",
      "Description": "Enhanced dedicated productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 888
        }
      }
    }
  ],
  "Description": "Diverse fault-tolerant implementation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "sint",
      "Description": "Persevering high-level definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "sint",
      "Description": "Persevering high-level definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Virtual cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "sit",
      "Description": "Virtual cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "earum",
      "Description": "Assimilated solution-oriented leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "earum",
      "Description": "Assimilated solution-oriented leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "alias",
      "StrippedValue": "quo",
      "Description": "Object-based impactful standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "quo",
      "Description": "Object-based impactful standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "assumenda",
      "Description": "Multi-lateral national infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "assumenda",
      "Description": "Multi-lateral national infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
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
      "Id": 422,
      "Name": "Funk, McKenzie and Beer",
      "ToolTip": "Enim at id quidem officia.",
      "Deleted": false,
      "Rank": 792,
      "Type": "in",
      "ColorBlock": 265,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2001-01-03T15:29:29.842695+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "impedit",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Gerard Friesen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 819
        }
      }
    }
  ],
  "PersonNumber": "1033266",
  "FullName": "Dr. Melyssa Bradford Fahey",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "debitis",
      "Description": "Pre-emptive 4th generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "debitis",
      "Description": "Pre-emptive 4th generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    }
  ],
  "FormalName": "D'Amore-Keebler",
  "Address": null,
  "Post3": "illum",
  "Post2": "optio",
  "Post1": "quia",
  "Kanalname": "cum",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dicta",
  "ActiveInterests": 361,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 109,
  "DbiKey": "quas",
  "DbiLastModified": "2020-12-26T15:29:29.8461972+01:00",
  "DbiLastSyncronized": "2009-09-12T15:29:29.8461972+02:00",
  "SentInfo": 138,
  "ShowContactTickets": 688,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Profit-focused high-level array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 544
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quia",
      "Description": "Profit-focused high-level array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 544
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "ullam",
      "Description": "Operative modular migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "ullam",
      "Description": "Operative modular migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "Source": 954,
  "ActiveErpLinks": 632,
  "ShipmentTypes": [
    {
      "Id": 304,
      "Name": "Schroeder Inc and Sons",
      "ToolTip": "Molestias cumque at.",
      "Deleted": true,
      "Rank": 49,
      "Type": "rerum",
      "ColorBlock": 977,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2021-07-15T15:29:29.8466981+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Dillon Welch II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 573,
      "Comment": "qui",
      "Registered": "2018-03-17T15:29:29.8466981+01:00",
      "RegisteredAssociateId": 980,
      "Updated": "2004-04-05T15:29:29.8466981+02:00",
      "UpdatedAssociateId": 571,
      "LegalBaseId": 15,
      "LegalBaseKey": "consequuntur",
      "LegalBaseName": "Stroman-Welch",
      "ConsentPurposeId": 249,
      "ConsentPurposeKey": "nisi",
      "ConsentPurposeName": "Johnston Inc and Sons",
      "ConsentSourceId": 343,
      "ConsentSourceKey": "sint",
      "ConsentSourceName": "Kessler-Dare",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "BounceEmails": [
    "lamont.schaden@shields.name",
    "luther_metz@wilderman.us"
  ],
  "ActiveStatusMonitorId": 380,
  "UserDefinedFields": {
    "SuperOffice:1": "Jayme Torp",
    "SuperOffice:2": "Tamia Upton"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "at"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 778
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```