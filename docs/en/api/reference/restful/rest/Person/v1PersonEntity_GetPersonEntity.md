---
title: GET Person/{id}
uid: v1PersonEntity_GetPersonEntity
generated: true
content_type: reference
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
| CreatedByFormId | int32 | The form id of the form that created the person |
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 22 Mar 2023 11:24:53 G3T

{
  "PersonId": 73,
  "Firstname": "Leta",
  "MiddleName": "Rau-Grady",
  "Lastname": "Hills",
  "Mrmrs": "voluptatum",
  "Title": "possimus",
  "UpdatedDate": "2023-03-22T11:24:53.3908475+01:00",
  "CreatedDate": "2010-06-14T11:24:53.3908475+02:00",
  "BirthDate": "2003-03-07T11:24:53.3908475+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "sit",
      "Description": "Innovative 3rd generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "sit",
      "Description": "Innovative 3rd generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 806
        }
      }
    }
  ],
  "Description": "Assimilated executive budgetary management",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ratione",
      "StrippedValue": "ipsa",
      "Description": "Down-sized neutral workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "ipsa",
      "Description": "Down-sized neutral workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "assumenda",
      "StrippedValue": "qui",
      "Description": "Digitized stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "qui",
      "Description": "Digitized stable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 395
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "quidem",
      "Description": "Automated next generation instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "quidem",
      "Description": "Automated next generation instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "dolorem",
      "Description": "Fundamental clear-thinking pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "dolorem",
      "Description": "Fundamental clear-thinking pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "esse",
      "Description": "Organized intangible database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "esse",
      "Description": "Organized intangible database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
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
      "Id": 74,
      "Name": "Mante, Grady and Schulist",
      "ToolTip": "Expedita ea quia recusandae pariatur.",
      "Deleted": true,
      "Rank": 819,
      "Type": "deserunt",
      "ColorBlock": 594,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2005-05-29T11:24:53.3908475+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusamus",
      "StyleHint": "totam",
      "Hidden": false,
      "FullName": "Alena Schumm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 263
        }
      }
    }
  ],
  "PersonNumber": "1603622",
  "FullName": "Mrs. Bobbie Koss",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "laborum",
      "StrippedValue": "aut",
      "Description": "Programmable responsive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "aut",
      "Description": "Programmable responsive framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    }
  ],
  "FormalName": "Roberts-Nader",
  "Address": null,
  "Post3": "in",
  "Post2": "amet",
  "Post1": "at",
  "Kanalname": "nihil",
  "Kanafname": "quo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "excepturi",
  "ActiveInterests": 912,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 383,
  "DbiKey": "est",
  "DbiLastModified": "2018-08-30T11:24:53.3908475+02:00",
  "DbiLastSyncronized": "2023-07-02T11:24:53.3908475+02:00",
  "SentInfo": 621,
  "ShowContactTickets": 888,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "esse",
      "StrippedValue": "ut",
      "Description": "Grass-roots high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "ut",
      "Description": "Grass-roots high-level open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "officiis",
      "StrippedValue": "ducimus",
      "Description": "Public-key empowering middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "ducimus",
      "Description": "Public-key empowering middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    }
  ],
  "Source": 728,
  "ActiveErpLinks": 413,
  "ShipmentTypes": [
    {
      "Id": 211,
      "Name": "Cummerata-Gerlach",
      "ToolTip": "Odio illo sint rerum perferendis perferendis.",
      "Deleted": false,
      "Rank": 772,
      "Type": "architecto",
      "ColorBlock": 467,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2024-12-25T11:24:53.3908475+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Mr. Kellen Senger III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 772
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 108,
      "Comment": "est",
      "Registered": "2017-01-22T11:24:53.3908475+01:00",
      "RegisteredAssociateId": 52,
      "Updated": "2020-10-05T11:24:53.3908475+02:00",
      "UpdatedAssociateId": 830,
      "LegalBaseId": 115,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Rempel, Durgan and Bauch",
      "ConsentPurposeId": 905,
      "ConsentPurposeKey": "aliquam",
      "ConsentPurposeName": "Lesch-Ledner",
      "ConsentSourceId": 75,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Jacobson, Fadel and Bartoletti",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    }
  ],
  "BounceEmails": [
    "rodrick.mraz@bosco.uk",
    "william_jast@hoeger.uk"
  ],
  "ActiveStatusMonitorId": 187,
  "CreatedByFormId": 785,
  "UtmParameters": null,
  "LeadstatusId": 74,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Carlee Larson I",
    "SuperOffice:2": "2013823107"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "cupiditate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 271
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```