---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
generated: true
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=938
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 907,
  "Firstname": "Ernestina",
  "MiddleName": "Connelly, Satterfield and Cartwright",
  "Lastname": "Legros",
  "Mrmrs": "sint",
  "Title": "architecto",
  "UpdatedDate": "2023-01-14T12:01:28.040925+01:00",
  "CreatedDate": "2021-12-24T12:01:28.040925+01:00",
  "BirthDate": "2023-07-18T12:01:28.040925+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "accusamus",
      "StrippedValue": "ullam",
      "Description": "Quality-focused zero defect policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 10
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "ullam",
      "Description": "Quality-focused zero defect policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 10
        }
      }
    }
  ],
  "Description": "Programmable holistic matrices",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eum",
      "StrippedValue": "inventore",
      "Description": "Profit-focused tertiary flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "inventore",
      "Description": "Profit-focused tertiary flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Public-key exuding function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Public-key exuding function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Visionary explicit neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Visionary explicit neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ea",
      "StrippedValue": "quo",
      "Description": "Assimilated static parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "quo",
      "Description": "Assimilated static parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Expanded cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "reprehenderit",
      "Description": "Expanded cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 927
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
      "Id": 75,
      "Name": "Volkman Inc and Sons",
      "ToolTip": "Culpa qui qui incidunt et.",
      "Deleted": false,
      "Rank": 960,
      "Type": "saepe",
      "ColorBlock": 346,
      "IconHint": "fugiat",
      "Selected": true,
      "LastChanged": "2008-03-12T12:01:28.040925+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Dale Yoshiko Kerluke Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "PersonNumber": "582857",
  "FullName": "Mozelle Doyle",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "Grass-roots fresh-thinking Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "est",
      "Description": "Grass-roots fresh-thinking Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 749
        }
      }
    }
  ],
  "FormalName": "O'Reilly, Gulgowski and Braun",
  "Address": null,
  "Post3": "soluta",
  "Post2": "molestias",
  "Post1": "dolores",
  "Kanalname": "quia",
  "Kanafname": "esse",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "reiciendis",
  "ActiveInterests": 619,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 577,
  "DbiKey": "eligendi",
  "DbiLastModified": "2005-12-29T12:01:28.040925+01:00",
  "DbiLastSyncronized": "2020-05-04T12:01:28.040925+02:00",
  "SentInfo": 622,
  "ShowContactTickets": 363,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "dolore",
      "Description": "Balanced dedicated access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "dolore",
      "Description": "Balanced dedicated access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 982
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "non",
      "StrippedValue": "temporibus",
      "Description": "Intuitive next generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "temporibus",
      "Description": "Intuitive next generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "Source": 695,
  "ActiveErpLinks": 722,
  "ShipmentTypes": [
    {
      "Id": 900,
      "Name": "Medhurst LLC",
      "ToolTip": "Dicta consequatur sint accusamus totam.",
      "Deleted": false,
      "Rank": 457,
      "Type": "voluptate",
      "ColorBlock": 427,
      "IconHint": "cum",
      "Selected": true,
      "LastChanged": "2002-02-07T12:01:28.040925+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Melany Grimes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 342,
      "Comment": "laborum",
      "Registered": "2002-11-19T12:01:28.040925+01:00",
      "RegisteredAssociateId": 468,
      "Updated": "2008-10-15T12:01:28.040925+02:00",
      "UpdatedAssociateId": 656,
      "LegalBaseId": 671,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Durgan, Feeney and Collier",
      "ConsentPurposeId": 610,
      "ConsentPurposeKey": "dolorum",
      "ConsentPurposeName": "Jenkins, Davis and Deckow",
      "ConsentSourceId": 354,
      "ConsentSourceKey": "laborum",
      "ConsentSourceName": "Rosenbaum LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "BounceEmails": [
    "coralie@greenholt.biz",
    "asia@roberts.info"
  ],
  "ActiveStatusMonitorId": 474,
  "CreatedByFormId": 124,
  "UserDefinedFields": {
    "SuperOffice:1": "Alexis Javonte Ledner MD",
    "SuperOffice:2": "1039853235"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "possimus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 537
    }
  }
}
```