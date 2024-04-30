---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
generated: true
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
GET /api/v1/Person/{id}?fk=True
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
Last-Modified: Wed, 07 Apr 1999 11:16:13 G4T

{
  "PersonId": 848,
  "Firstname": "Jimmie",
  "MiddleName": "Kerluke-Bernhard",
  "Lastname": "Schuster",
  "Mrmrs": "dignissimos",
  "Title": "voluptates",
  "UpdatedDate": "1999-04-07T11:16:13.9644573+02:00",
  "CreatedDate": "2022-02-28T11:16:13.9644573+01:00",
  "BirthDate": "2012-06-05T11:16:13.9644573+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "officiis",
      "Description": "Monitored value-added task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "officiis",
      "Description": "Monitored value-added task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Description": "Profound human-resource migration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "totam",
      "StrippedValue": "perspiciatis",
      "Description": "Streamlined eco-centric local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "perspiciatis",
      "Description": "Streamlined eco-centric local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "provident",
      "Description": "Synchronised interactive analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "provident",
      "Description": "Synchronised interactive analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "id",
      "Description": "Quality-focused optimizing pricing structure",
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
      "Value": "corrupti",
      "StrippedValue": "id",
      "Description": "Quality-focused optimizing pricing structure",
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
  "OfficePhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "saepe",
      "Description": "Ergonomic object-oriented model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "saepe",
      "Description": "Ergonomic object-oriented model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "magni",
      "Description": "Total 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "magni",
      "Description": "Total 4th generation circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
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
      "Id": 488,
      "Name": "Daniel-Kautzer",
      "ToolTip": "Necessitatibus quia consequuntur eos quia voluptatum et.",
      "Deleted": false,
      "Rank": 834,
      "Type": "qui",
      "ColorBlock": 877,
      "IconHint": "amet",
      "Selected": true,
      "LastChanged": "2004-10-13T11:16:13.9644573+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "architecto",
      "Hidden": true,
      "FullName": "Sedrick Reynolds",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 622
        }
      }
    }
  ],
  "PersonNumber": "1221950",
  "FullName": "Cody Grant",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "dolore",
      "Description": "Digitized systematic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "dolore",
      "Description": "Digitized systematic customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    }
  ],
  "FormalName": "Bashirian, Casper and Russel",
  "Address": null,
  "Post3": "illum",
  "Post2": "fugiat",
  "Post1": "eveniet",
  "Kanalname": "est",
  "Kanafname": "sequi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eum",
  "ActiveInterests": 276,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 909,
  "DbiKey": "a",
  "DbiLastModified": "2012-07-25T11:16:13.9644573+02:00",
  "DbiLastSyncronized": "2000-12-02T11:16:13.9644573+01:00",
  "SentInfo": 324,
  "ShowContactTickets": 414,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Optional maximized pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Optional maximized pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 992
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quos",
      "StrippedValue": "nisi",
      "Description": "De-engineered 3rd generation support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "nisi",
      "Description": "De-engineered 3rd generation support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 841
        }
      }
    }
  ],
  "Source": 291,
  "ActiveErpLinks": 58,
  "ShipmentTypes": [
    {
      "Id": 545,
      "Name": "Towne Group",
      "ToolTip": "Eos possimus nam.",
      "Deleted": false,
      "Rank": 247,
      "Type": "qui",
      "ColorBlock": 119,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2005-02-05T11:16:13.9644573+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Micah Cormier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 72,
      "Comment": "esse",
      "Registered": "2021-01-17T11:16:13.9644573+01:00",
      "RegisteredAssociateId": 511,
      "Updated": "2001-06-16T11:16:13.9644573+02:00",
      "UpdatedAssociateId": 407,
      "LegalBaseId": 978,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Hayes Inc and Sons",
      "ConsentPurposeId": 86,
      "ConsentPurposeKey": "modi",
      "ConsentPurposeName": "King Inc and Sons",
      "ConsentSourceId": 404,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Goldner, Hoppe and Hamill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "BounceEmails": [
    "frederic.howe@hirthe.name",
    "garland.koch@stracke.uk"
  ],
  "ActiveStatusMonitorId": 582,
  "UserDefinedFields": {
    "SuperOffice:1": "Tillman Kemmer",
    "SuperOffice:2": "Connie Hessel"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "veniam"
  },
  "CustomFields": {
    "CustomFields1": "aliquid",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 422
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```