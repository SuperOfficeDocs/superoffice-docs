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

## Sample request

```http!
POST /api/v1/Agents/Person/CreateDefaultFromCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 495,
  "CredentialType": "dolores",
  "CredentialValue": "delectus",
  "CredentialDisplayValue": "eum"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 25,
  "Firstname": "Tito",
  "MiddleName": "O'Conner, Haley and Hahn",
  "Lastname": "Haag",
  "Mrmrs": "veritatis",
  "Title": "vero",
  "UpdatedDate": "2002-11-05T13:38:13.8272279+01:00",
  "CreatedDate": "2023-01-20T13:38:13.8272279+01:00",
  "BirthDate": "2016-06-20T13:38:13.8272279+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Future-proofed methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 421
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "aut",
      "Description": "Future-proofed methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 421
        }
      }
    }
  ],
  "Description": "Progressive dynamic strategy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "fuga",
      "Description": "Reactive 24/7 orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "fuga",
      "Description": "Reactive 24/7 orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tenetur",
      "StrippedValue": "inventore",
      "Description": "Customer-focused optimal array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "inventore",
      "Description": "Customer-focused optimal array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "atque",
      "StrippedValue": "repellendus",
      "Description": "Organized 5th generation leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "repellendus",
      "Description": "Organized 5th generation leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ducimus",
      "StrippedValue": "incidunt",
      "Description": "De-engineered intermediate capability",
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
      "Value": "ducimus",
      "StrippedValue": "incidunt",
      "Description": "De-engineered intermediate capability",
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
  "OtherPhones": [
    {
      "Value": "est",
      "StrippedValue": "perspiciatis",
      "Description": "Cloned global synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "perspiciatis",
      "Description": "Cloned global synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
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
      "Id": 21,
      "Name": "Bayer-Harber",
      "ToolTip": "Facilis et nemo.",
      "Deleted": false,
      "Rank": 694,
      "Type": "dolorem",
      "ColorBlock": 319,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2023-04-13T13:38:13.8272279+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iusto",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Kariane Kub IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "PersonNumber": "411168",
  "FullName": "Mr. Pete Marianna Kertzmann III",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "qui",
      "Description": "Down-sized object-oriented complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 904
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "qui",
      "Description": "Down-sized object-oriented complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 904
        }
      }
    }
  ],
  "FormalName": "Gislason, Berge and Crona",
  "Address": null,
  "Post3": "aliquid",
  "Post2": "eligendi",
  "Post1": "qui",
  "Kanalname": "tempore",
  "Kanafname": "quod",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "provident",
  "ActiveInterests": 971,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 665,
  "DbiKey": "omnis",
  "DbiLastModified": "2012-03-27T13:38:13.8272279+02:00",
  "DbiLastSyncronized": "2020-11-13T13:38:13.8272279+01:00",
  "SentInfo": 96,
  "ShowContactTickets": 682,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "pariatur",
      "StrippedValue": "nobis",
      "Description": "Stand-alone user-facing capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "nobis",
      "Description": "Stand-alone user-facing capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 656
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "cupiditate",
      "Description": "Persistent bi-directional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "cupiditate",
      "Description": "Persistent bi-directional service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "Source": 39,
  "ActiveErpLinks": 195,
  "ShipmentTypes": [
    {
      "Id": 609,
      "Name": "Lebsack-Tremblay",
      "ToolTip": "Aut sed eaque fugit adipisci.",
      "Deleted": false,
      "Rank": 114,
      "Type": "ut",
      "ColorBlock": 603,
      "IconHint": "recusandae",
      "Selected": false,
      "LastChanged": "1998-04-23T13:38:13.8272279+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "pariatur",
      "StyleHint": "tenetur",
      "Hidden": false,
      "FullName": "Rosalyn Wintheiser PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 191,
      "Comment": "numquam",
      "Registered": "2019-08-09T13:38:13.8272279+02:00",
      "RegisteredAssociateId": 661,
      "Updated": "2015-06-22T13:38:13.8272279+02:00",
      "UpdatedAssociateId": 1001,
      "LegalBaseId": 568,
      "LegalBaseKey": "minus",
      "LegalBaseName": "Gutkowski, Johnston and Gusikowski",
      "ConsentPurposeId": 711,
      "ConsentPurposeKey": "quo",
      "ConsentPurposeName": "Johnston Group",
      "ConsentSourceId": 76,
      "ConsentSourceKey": "repellendus",
      "ConsentSourceName": "Schulist-Hills",
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
  "BounceEmails": [
    "eugenia@gislason.ca",
    "miracle@littlesmith.name"
  ],
  "ActiveStatusMonitorId": 428,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Favian Garett Baumbach DDS",
    "SuperOffice:2": "1355329402"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "sapiente",
    "CustomFields2": "velit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 610
    }
  }
}
```