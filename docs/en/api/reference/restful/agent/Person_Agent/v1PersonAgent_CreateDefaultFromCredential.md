---
title: POST Agents/Person/CreateDefaultFromCredential
uid: v1PersonAgent_CreateDefaultFromCredential
generated: true
---

# POST Agents/Person/CreateDefaultFromCredential

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultFromCredential?$select=name,department,category/id
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

ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| CredentialType | String |  |
| CredentialValue | String |  |
| CredentialDisplayValue | String |  |

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
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 963,
  "CredentialType": "ex",
  "CredentialValue": "et",
  "CredentialDisplayValue": "rem"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 876,
  "Firstname": "Trenton",
  "MiddleName": "Nienow LLC",
  "Lastname": "D'Amore",
  "Mrmrs": "unde",
  "Title": "quod",
  "UpdatedDate": "2008-01-05T14:23:47.0505119+01:00",
  "CreatedDate": "2013-03-11T14:23:47.0505119+01:00",
  "BirthDate": "2005-12-01T14:23:47.0505119+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ratione",
      "StrippedValue": "eveniet",
      "Description": "User-friendly exuding extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 348
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "eveniet",
      "Description": "User-friendly exuding extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 348
        }
      }
    }
  ],
  "Description": "Robust discrete infrastructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quos",
      "StrippedValue": "eum",
      "Description": "Progressive impactful throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 446
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "eum",
      "Description": "Progressive impactful throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 446
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "nisi",
      "Description": "Phased real-time neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "nisi",
      "Description": "Phased real-time neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Phased fresh-thinking projection",
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
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Phased fresh-thinking projection",
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
      "Value": "fugiat",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered needs-based emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "voluptas",
      "Description": "Multi-layered needs-based emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "facilis",
      "Description": "Programmable demand-driven algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "facilis",
      "Description": "Programmable demand-driven algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
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
      "Id": 236,
      "Name": "Farrell-Krajcik",
      "ToolTip": "At recusandae omnis quaerat occaecati facere sequi.",
      "Deleted": true,
      "Rank": 876,
      "Type": "est",
      "ColorBlock": 340,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2017-12-24T14:23:47.0505119+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tenetur",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Dee Bruen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "PersonNumber": "1797547",
  "FullName": "Ford Bechtelar",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "consequuntur",
      "Description": "Robust background initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "consequuntur",
      "Description": "Robust background initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    }
  ],
  "FormalName": "Gorczany, Franecki and Block",
  "Address": null,
  "Post3": "esse",
  "Post2": "aut",
  "Post1": "voluptatem",
  "Kanalname": "dicta",
  "Kanafname": "amet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "perferendis",
  "ActiveInterests": 839,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 420,
  "DbiKey": "eveniet",
  "DbiLastModified": "2006-06-19T14:23:47.0505119+02:00",
  "DbiLastSyncronized": "2003-02-26T14:23:47.0505119+01:00",
  "SentInfo": 641,
  "ShowContactTickets": 66,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "autem",
      "Description": "Self-enabling encompassing website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "autem",
      "Description": "Self-enabling encompassing website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "aliquid",
      "Description": "Enhanced intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "aliquid",
      "Description": "Enhanced intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    }
  ],
  "Source": 98,
  "ActiveErpLinks": 535,
  "ShipmentTypes": [
    {
      "Id": 204,
      "Name": "Connelly Group",
      "ToolTip": "Placeat laborum molestias nam.",
      "Deleted": false,
      "Rank": 695,
      "Type": "incidunt",
      "ColorBlock": 11,
      "IconHint": "labore",
      "Selected": false,
      "LastChanged": "2020-02-01T14:23:47.0505119+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illo",
      "StyleHint": "tenetur",
      "Hidden": true,
      "FullName": "Hardy Yost",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 594,
      "Comment": "reiciendis",
      "Registered": "2005-01-17T14:23:47.0505119+01:00",
      "RegisteredAssociateId": 907,
      "Updated": "2023-10-28T14:23:47.0505119+02:00",
      "UpdatedAssociateId": 919,
      "LegalBaseId": 875,
      "LegalBaseKey": "incidunt",
      "LegalBaseName": "Feeney, O'Connell and Reichert",
      "ConsentPurposeId": 835,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Hickle Group",
      "ConsentSourceId": 863,
      "ConsentSourceKey": "error",
      "ConsentSourceName": "Barton-Pollich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    }
  ],
  "BounceEmails": [
    "thad.stracke@bernier.ca",
    "lilyan@senger.uk"
  ],
  "ActiveStatusMonitorId": 741,
  "UserDefinedFields": {
    "SuperOffice:1": "Hermina Feeney",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "quisquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 800
    }
  }
}
```