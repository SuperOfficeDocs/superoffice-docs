---
title: POST Agents/Contact/AddPerson
uid: v1ContactAgent_AddPerson
generated: true
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
```


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

## Request Body: request 

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| NewPersonEntity | PersonEntity |  |

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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 535,
  "NewPersonEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 409,
  "Firstname": "Pietro",
  "MiddleName": "Prosacco, Hoppe and Koss",
  "Lastname": "Weissnat",
  "Mrmrs": "totam",
  "Title": "repudiandae",
  "UpdatedDate": "2010-07-02T11:44:33.1348307+02:00",
  "CreatedDate": "2009-10-21T11:44:33.1348307+02:00",
  "BirthDate": "2020-03-31T11:44:33.1348307+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "inventore",
      "StrippedValue": "quo",
      "Description": "Inverse well-modulated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "quo",
      "Description": "Inverse well-modulated internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Description": "Programmable dynamic internet solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "architecto",
      "StrippedValue": "dolorum",
      "Description": "Ameliorated human-resource throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "dolorum",
      "Description": "Ameliorated human-resource throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 754
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "id",
      "StrippedValue": "animi",
      "Description": "Networked bi-directional initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "animi",
      "Description": "Networked bi-directional initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ut",
      "StrippedValue": "porro",
      "Description": "Diverse reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "porro",
      "Description": "Diverse reciprocal ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "ea",
      "Description": "Virtual empowering firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "ea",
      "Description": "Virtual empowering firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "ut",
      "Description": "Assimilated discrete collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ut",
      "Description": "Assimilated discrete collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
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
      "Id": 64,
      "Name": "Rodriguez, Lakin and Hudson",
      "ToolTip": "Quis pariatur veniam.",
      "Deleted": true,
      "Rank": 135,
      "Type": "error",
      "ColorBlock": 568,
      "IconHint": "magnam",
      "Selected": false,
      "LastChanged": "2007-05-16T11:44:33.1348307+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Garland Russel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    }
  ],
  "PersonNumber": "365562",
  "FullName": "Rebeka Streich",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "iure",
      "StrippedValue": "dolores",
      "Description": "Reactive fresh-thinking attitude",
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
      "Value": "iure",
      "StrippedValue": "dolores",
      "Description": "Reactive fresh-thinking attitude",
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
  "FormalName": "Jacobs, O'Conner and Koelpin",
  "Address": null,
  "Post3": "cum",
  "Post2": "voluptatem",
  "Post1": "totam",
  "Kanalname": "esse",
  "Kanafname": "dolorum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sint",
  "ActiveInterests": 929,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 600,
  "DbiKey": "voluptate",
  "DbiLastModified": "2017-08-31T11:44:33.1348307+02:00",
  "DbiLastSyncronized": "2000-08-02T11:44:33.1348307+02:00",
  "SentInfo": 485,
  "ShowContactTickets": 27,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nemo",
      "StrippedValue": "deserunt",
      "Description": "Horizontal logistical protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "deserunt",
      "Description": "Horizontal logistical protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 956
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "cum",
      "Description": "Seamless static info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "cum",
      "Description": "Seamless static info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    }
  ],
  "Source": 334,
  "ActiveErpLinks": 115,
  "ShipmentTypes": [
    {
      "Id": 231,
      "Name": "Lehner, Conroy and Bartoletti",
      "ToolTip": "Possimus cupiditate dolor aliquam accusantium.",
      "Deleted": true,
      "Rank": 225,
      "Type": "quia",
      "ColorBlock": 858,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2015-04-15T11:44:33.1348307+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officiis",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Mr. Willy Manuel Rutherford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 426,
      "Comment": "quasi",
      "Registered": "2012-03-12T11:44:33.1348307+01:00",
      "RegisteredAssociateId": 937,
      "Updated": "2012-11-29T11:44:33.1348307+01:00",
      "UpdatedAssociateId": 981,
      "LegalBaseId": 188,
      "LegalBaseKey": "saepe",
      "LegalBaseName": "Lynch LLC",
      "ConsentPurposeId": 928,
      "ConsentPurposeKey": "necessitatibus",
      "ConsentPurposeName": "Pacocha LLC",
      "ConsentSourceId": 763,
      "ConsentSourceKey": "natus",
      "ConsentSourceName": "Mueller LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "BounceEmails": [
    "winifred@carter.us",
    "alden@mills.uk"
  ],
  "ActiveStatusMonitorId": 534,
  "UserDefinedFields": {
    "SuperOffice:1": "Deshawn Nienow",
    "SuperOffice:2": "Arvilla Beahan"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "perspiciatis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 203
    }
  }
}
```