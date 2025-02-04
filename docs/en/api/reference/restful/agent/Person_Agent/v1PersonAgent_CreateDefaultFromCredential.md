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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 266,
  "CredentialType": "ad",
  "CredentialValue": "qui",
  "CredentialDisplayValue": "doloremque"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 435,
  "Firstname": "Rodger",
  "MiddleName": "Luettgen-Ryan",
  "Lastname": "Bechtelar",
  "Mrmrs": "voluptatem",
  "Title": "voluptate",
  "UpdatedDate": "2003-11-02T13:13:23.5238729+01:00",
  "CreatedDate": "2022-01-08T13:13:23.5238729+01:00",
  "BirthDate": "1999-03-07T13:13:23.5238729+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "eligendi",
      "Description": "Stand-alone value-added projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "eligendi",
      "Description": "Stand-alone value-added projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Description": "Devolved discrete migration",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "officiis",
      "StrippedValue": "voluptate",
      "Description": "Reverse-engineered mobile website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "voluptate",
      "Description": "Reverse-engineered mobile website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 414
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "adipisci",
      "StrippedValue": "quo",
      "Description": "Stand-alone interactive forecast",
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
      "Value": "adipisci",
      "StrippedValue": "quo",
      "Description": "Stand-alone interactive forecast",
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
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "velit",
      "Description": "Virtual didactic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "velit",
      "Description": "Virtual didactic help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "veritatis",
      "Description": "Automated transitional focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "veritatis",
      "Description": "Automated transitional focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "repudiandae",
      "Description": "User-centric methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "repudiandae",
      "Description": "User-centric methodical throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
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
      "Id": 665,
      "Name": "Grimes Inc and Sons",
      "ToolTip": "Nulla a.",
      "Deleted": false,
      "Rank": 877,
      "Type": "et",
      "ColorBlock": 687,
      "IconHint": "repellendus",
      "Selected": false,
      "LastChanged": "2005-03-21T13:13:23.5238729+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "occaecati",
      "StyleHint": "totam",
      "Hidden": true,
      "FullName": "Carolyne Connelly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 357
        }
      }
    }
  ],
  "PersonNumber": "874411",
  "FullName": "Howard Cronin",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "similique",
      "StrippedValue": "sed",
      "Description": "Exclusive foreground functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "sed",
      "Description": "Exclusive foreground functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    }
  ],
  "FormalName": "Kuphal-Lindgren",
  "Address": null,
  "Post3": "doloribus",
  "Post2": "ut",
  "Post1": "rerum",
  "Kanalname": "similique",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "delectus",
  "ActiveInterests": 620,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 253,
  "DbiKey": "minus",
  "DbiLastModified": "2017-03-20T13:13:23.5238729+01:00",
  "DbiLastSyncronized": "2002-05-09T13:13:23.5238729+02:00",
  "SentInfo": 353,
  "ShowContactTickets": 163,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "voluptatum",
      "Description": "Team-oriented reciprocal protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "voluptatum",
      "Description": "Team-oriented reciprocal protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "officia",
      "Description": "Face to face didactic extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "officia",
      "Description": "Face to face didactic extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 170
        }
      }
    }
  ],
  "Source": 907,
  "ActiveErpLinks": 849,
  "ShipmentTypes": [
    {
      "Id": 113,
      "Name": "Heller, Cartwright and White",
      "ToolTip": "Qui accusantium eos.",
      "Deleted": false,
      "Rank": 909,
      "Type": "dolores",
      "ColorBlock": 853,
      "IconHint": "magnam",
      "Selected": true,
      "LastChanged": "2007-09-03T13:13:23.5238729+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Jaren Edd Cummings DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 550,
      "Comment": "voluptatem",
      "Registered": "2018-11-11T13:13:23.5238729+01:00",
      "RegisteredAssociateId": 376,
      "Updated": "2003-06-12T13:13:23.5238729+02:00",
      "UpdatedAssociateId": 588,
      "LegalBaseId": 398,
      "LegalBaseKey": "ab",
      "LegalBaseName": "Grimes-Harber",
      "ConsentPurposeId": 421,
      "ConsentPurposeKey": "quo",
      "ConsentPurposeName": "Morar Group",
      "ConsentSourceId": 56,
      "ConsentSourceKey": "atque",
      "ConsentSourceName": "Corkery, Runolfsson and Barton",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 846
        }
      }
    }
  ],
  "BounceEmails": [
    "vivianne_schumm@stiedemannborer.co.uk",
    "jany@jaskolski.info"
  ],
  "ActiveStatusMonitorId": 556,
  "CreatedByFormId": 765,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Delbert Gutmann"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "reiciendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 29
    }
  }
}
```