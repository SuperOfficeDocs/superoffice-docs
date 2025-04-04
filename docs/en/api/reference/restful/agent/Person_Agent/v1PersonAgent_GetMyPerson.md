---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
generated: true
---

# POST Agents/Person/GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 553,
  "Firstname": "Yasmine",
  "MiddleName": "Emmerich Group",
  "Lastname": "Sipes",
  "Mrmrs": "dolorum",
  "Title": "facilis",
  "UpdatedDate": "2003-06-28T13:14:00.783693+02:00",
  "CreatedDate": "2017-12-03T13:14:00.783693+01:00",
  "BirthDate": "2009-12-13T13:14:00.783693+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "deserunt",
      "Description": "Devolved systemic flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 516
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "deserunt",
      "Description": "Devolved systemic flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 516
        }
      }
    }
  ],
  "Description": "Virtual optimizing migration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "nulla",
      "Description": "Ameliorated stable time-frame",
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
      "Value": "voluptatibus",
      "StrippedValue": "nulla",
      "Description": "Ameliorated stable time-frame",
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
  "Faxes": [
    {
      "Value": "maxime",
      "StrippedValue": "repellat",
      "Description": "Switchable homogeneous middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "repellat",
      "Description": "Switchable homogeneous middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "quas",
      "Description": "Reduced executive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quas",
      "Description": "Reduced executive frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "numquam",
      "Description": "Expanded systemic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "numquam",
      "Description": "Expanded systemic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 445
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nam",
      "StrippedValue": "laborum",
      "Description": "Programmable bifurcated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "laborum",
      "Description": "Programmable bifurcated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
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
      "Id": 451,
      "Name": "Will-Von",
      "ToolTip": "Praesentium omnis autem dolor.",
      "Deleted": false,
      "Rank": 174,
      "Type": "rerum",
      "ColorBlock": 58,
      "IconHint": "temporibus",
      "Selected": false,
      "LastChanged": "2014-11-19T13:14:00.783693+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quaerat",
      "StyleHint": "blanditiis",
      "Hidden": false,
      "FullName": "Queenie Block",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 386
        }
      }
    }
  ],
  "PersonNumber": "940516",
  "FullName": "Mack Crona",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "nemo",
      "StrippedValue": "consequatur",
      "Description": "Assimilated homogeneous system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "consequatur",
      "Description": "Assimilated homogeneous system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "FormalName": "Kris LLC",
  "Address": null,
  "Post3": "commodi",
  "Post2": "occaecati",
  "Post1": "deleniti",
  "Kanalname": "ab",
  "Kanafname": "quo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "atque",
  "ActiveInterests": 839,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 775,
  "DbiKey": "eligendi",
  "DbiLastModified": "2023-02-25T13:14:00.783693+01:00",
  "DbiLastSyncronized": "2016-04-05T13:14:00.783693+02:00",
  "SentInfo": 935,
  "ShowContactTickets": 289,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "consequatur",
      "StrippedValue": "est",
      "Description": "Grass-roots composite encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "est",
      "Description": "Grass-roots composite encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "laborum",
      "StrippedValue": "consequuntur",
      "Description": "Horizontal neutral groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "consequuntur",
      "Description": "Horizontal neutral groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 862
        }
      }
    }
  ],
  "Source": 367,
  "ActiveErpLinks": 370,
  "ShipmentTypes": [
    {
      "Id": 694,
      "Name": "O'Connell, Nader and Williamson",
      "ToolTip": "Temporibus eius.",
      "Deleted": false,
      "Rank": 585,
      "Type": "rerum",
      "ColorBlock": 145,
      "IconHint": "blanditiis",
      "Selected": true,
      "LastChanged": "2009-01-06T13:14:00.7982016+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Marquise Collins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 976,
      "Comment": "corporis",
      "Registered": "2007-03-17T13:14:00.7982016+01:00",
      "RegisteredAssociateId": 915,
      "Updated": "2011-08-03T13:14:00.7982016+02:00",
      "UpdatedAssociateId": 307,
      "LegalBaseId": 10,
      "LegalBaseKey": "aliquid",
      "LegalBaseName": "Gutkowski LLC",
      "ConsentPurposeId": 654,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Tillman-Ryan",
      "ConsentSourceId": 159,
      "ConsentSourceKey": "dolore",
      "ConsentSourceName": "Zieme, Lang and Sanford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 802
        }
      }
    }
  ],
  "BounceEmails": [
    "johnathan.harber@cartersatterfield.us",
    "joe.mayer@spencergoyette.us"
  ],
  "ActiveStatusMonitorId": 989,
  "CreatedByFormId": 805,
  "UserDefinedFields": {
    "SuperOffice:1": "Sabryna Prohaska",
    "SuperOffice:2": "Prof. Amari Mayer"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 252
    }
  }
}
```