---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
generated: true
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 363
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 525,
  "Firstname": "Deondre",
  "MiddleName": "Rodriguez Inc and Sons",
  "Lastname": "Kuvalis",
  "Mrmrs": "at",
  "Title": "id",
  "UpdatedDate": "2010-07-19T16:54:55.7742846+02:00",
  "CreatedDate": "2020-05-13T16:54:55.7742846+02:00",
  "BirthDate": "2013-05-25T16:54:55.7742846+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "sed",
      "Description": "Adaptive needs-based secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "sed",
      "Description": "Adaptive needs-based secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 70
        }
      }
    }
  ],
  "Description": "Synchronised eco-centric circuit",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dicta",
      "StrippedValue": "itaque",
      "Description": "Fully-configurable heuristic support",
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
      "Value": "dicta",
      "StrippedValue": "itaque",
      "Description": "Fully-configurable heuristic support",
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
  "Faxes": [
    {
      "Value": "eius",
      "StrippedValue": "at",
      "Description": "Intuitive directional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "at",
      "Description": "Intuitive directional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "consequatur",
      "Description": "Inverse coherent attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 775
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "consequatur",
      "Description": "Inverse coherent attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 775
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "ipsum",
      "Description": "Enhanced national data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ipsum",
      "Description": "Enhanced national data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "iste",
      "Description": "Face to face systematic focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 218
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "iste",
      "Description": "Face to face systematic focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 218
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
      "Id": 934,
      "Name": "Kovacek Group",
      "ToolTip": "Et aut.",
      "Deleted": true,
      "Rank": 788,
      "Type": "repudiandae",
      "ColorBlock": 896,
      "IconHint": "voluptate",
      "Selected": false,
      "LastChanged": "2000-01-16T16:54:55.7773055+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "minus",
      "Hidden": false,
      "FullName": "Santina Nader",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    }
  ],
  "PersonNumber": "763448",
  "FullName": "Mr. Brittany Bayer Jr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "possimus",
      "StrippedValue": "non",
      "Description": "Monitored incremental data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "non",
      "Description": "Monitored incremental data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 963
        }
      }
    }
  ],
  "FormalName": "Crist, Lang and Kohler",
  "Address": null,
  "Post3": "ut",
  "Post2": "incidunt",
  "Post1": "et",
  "Kanalname": "animi",
  "Kanafname": "quam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 528,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 679,
  "DbiKey": "recusandae",
  "DbiLastModified": "2012-12-15T16:54:55.7783021+01:00",
  "DbiLastSyncronized": "2021-04-30T16:54:55.7783021+02:00",
  "SentInfo": 973,
  "ShowContactTickets": 803,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "qui",
      "Description": "Organic incremental core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "qui",
      "Description": "Organic incremental core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "libero",
      "StrippedValue": "maiores",
      "Description": "Cloned client-driven leverage",
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
      "Value": "libero",
      "StrippedValue": "maiores",
      "Description": "Cloned client-driven leverage",
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
  "Source": 796,
  "ActiveErpLinks": 40,
  "ShipmentTypes": [
    {
      "Id": 202,
      "Name": "Kreiger Inc and Sons",
      "ToolTip": "Dicta at ipsa.",
      "Deleted": false,
      "Rank": 2,
      "Type": "molestias",
      "ColorBlock": 35,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2009-07-27T16:54:55.779301+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "sunt",
      "Hidden": false,
      "FullName": "Miss Claudia Marisa Bergnaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 670
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 6,
      "Comment": "corporis",
      "Registered": "2016-08-13T16:54:55.779301+02:00",
      "RegisteredAssociateId": 419,
      "Updated": "2023-07-19T16:54:55.779301+02:00",
      "UpdatedAssociateId": 101,
      "LegalBaseId": 445,
      "LegalBaseKey": "optio",
      "LegalBaseName": "Denesik, McGlynn and Koch",
      "ConsentPurposeId": 491,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Boyer, Toy and Effertz",
      "ConsentSourceId": 773,
      "ConsentSourceKey": "repudiandae",
      "ConsentSourceName": "Goodwin-Lakin",
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
  "BounceEmails": [
    "bertram.russel@trantow.us",
    "adalberto@schaeferhermiston.name"
  ],
  "ActiveStatusMonitorId": 692,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "927712100"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 218
    }
  }
}
```