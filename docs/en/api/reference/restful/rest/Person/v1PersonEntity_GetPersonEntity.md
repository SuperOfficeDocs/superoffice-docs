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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
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
Last-Modified: Sun, 12 Sep 1999 14:19:10 G9T

{
  "PersonId": 395,
  "Firstname": "Nona",
  "MiddleName": "Feil-Yundt",
  "Lastname": "Eichmann",
  "Mrmrs": "ipsum",
  "Title": "et",
  "UpdatedDate": "1999-09-12T14:19:10.4123484+02:00",
  "CreatedDate": "2014-04-24T14:19:10.4123484+02:00",
  "BirthDate": "1999-09-23T14:19:10.4123484+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "qui",
      "Description": "Right-sized tangible customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "qui",
      "Description": "Right-sized tangible customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Description": "Up-sized systematic matrices",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dignissimos",
      "StrippedValue": "ipsa",
      "Description": "Phased heuristic paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "ipsa",
      "Description": "Phased heuristic paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "iste",
      "StrippedValue": "ea",
      "Description": "Phased transitional secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "ea",
      "Description": "Phased transitional secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "vero",
      "StrippedValue": "sit",
      "Description": "Triple-buffered cohesive strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "sit",
      "Description": "Triple-buffered cohesive strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 826
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "aut",
      "Description": "Cross-platform clear-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "aut",
      "Description": "Cross-platform clear-thinking complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "minus",
      "StrippedValue": "fuga",
      "Description": "Down-sized zero administration synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "fuga",
      "Description": "Down-sized zero administration synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 419
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
      "Id": 413,
      "Name": "Rice Inc and Sons",
      "ToolTip": "Ratione ut.",
      "Deleted": false,
      "Rank": 445,
      "Type": "ut",
      "ColorBlock": 721,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "1996-04-25T14:19:10.4123484+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sequi",
      "StyleHint": "minima",
      "Hidden": true,
      "FullName": "Dr. Lenora Kirlin IV",
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
  "PersonNumber": "936776",
  "FullName": "Miss Alexandrea Eichmann MD",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "suscipit",
      "Description": "Distributed secondary artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "suscipit",
      "Description": "Distributed secondary artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    }
  ],
  "FormalName": "Kreiger, Ferry and Franecki",
  "Address": null,
  "Post3": "esse",
  "Post2": "excepturi",
  "Post1": "ipsam",
  "Kanalname": "sunt",
  "Kanafname": "eos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "earum",
  "ActiveInterests": 78,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 518,
  "DbiKey": "illo",
  "DbiLastModified": "2000-08-26T14:19:10.4123484+02:00",
  "DbiLastSyncronized": "2011-10-12T14:19:10.4123484+02:00",
  "SentInfo": 378,
  "ShowContactTickets": 468,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "repellat",
      "StrippedValue": "at",
      "Description": "Compatible object-oriented methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "at",
      "Description": "Compatible object-oriented methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Enhanced bifurcated database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "consequatur",
      "Description": "Enhanced bifurcated database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Source": 483,
  "ActiveErpLinks": 886,
  "ShipmentTypes": [
    {
      "Id": 430,
      "Name": "Anderson, Sporer and West",
      "ToolTip": "Exercitationem et.",
      "Deleted": false,
      "Rank": 639,
      "Type": "quia",
      "ColorBlock": 150,
      "IconHint": "consequatur",
      "Selected": false,
      "LastChanged": "1998-03-20T14:19:10.4123484+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "molestias",
      "Hidden": false,
      "FullName": "Shemar Kutch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 938,
      "Comment": "accusantium",
      "Registered": "1998-11-28T14:19:10.4123484+01:00",
      "RegisteredAssociateId": 354,
      "Updated": "2017-02-05T14:19:10.4123484+01:00",
      "UpdatedAssociateId": 458,
      "LegalBaseId": 146,
      "LegalBaseKey": "minus",
      "LegalBaseName": "Ebert Inc and Sons",
      "ConsentPurposeId": 328,
      "ConsentPurposeKey": "autem",
      "ConsentPurposeName": "Stracke-Rowe",
      "ConsentSourceId": 682,
      "ConsentSourceKey": "voluptas",
      "ConsentSourceName": "Johnston-Weimann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "BounceEmails": [
    "rossie@beier.co.uk",
    "timmy@king.us"
  ],
  "ActiveStatusMonitorId": 802,
  "UserDefinedFields": {
    "SuperOffice:1": "Chloe Tillman",
    "SuperOffice:2": "Zula Parker"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 975
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```