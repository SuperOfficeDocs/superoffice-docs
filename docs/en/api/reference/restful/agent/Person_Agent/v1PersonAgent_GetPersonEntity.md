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
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=740
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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 82,
  "Firstname": "Tamara",
  "MiddleName": "Leannon, Brown and Stoltenberg",
  "Lastname": "Sporer",
  "Mrmrs": "in",
  "Title": "quia",
  "UpdatedDate": "2004-06-09T23:03:56.4206251+02:00",
  "CreatedDate": "2013-09-04T23:03:56.4206251+02:00",
  "BirthDate": "2011-01-06T23:03:56.4206251+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Object-based assymetric structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Object-based assymetric structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 137
        }
      }
    }
  ],
  "Description": "Front-line bottom-line superstructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "ea",
      "Description": "Object-based coherent secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "ea",
      "Description": "Object-based coherent secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 649
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "expedita",
      "StrippedValue": "aut",
      "Description": "Upgradable national paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "aut",
      "Description": "Upgradable national paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 310
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "officia",
      "StrippedValue": "omnis",
      "Description": "Advanced cohesive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "omnis",
      "Description": "Advanced cohesive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Face to face 4th generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "et",
      "Description": "Face to face 4th generation help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "corrupti",
      "Description": "Team-oriented scalable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "corrupti",
      "Description": "Team-oriented scalable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 7
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
      "Id": 308,
      "Name": "Kutch Inc and Sons",
      "ToolTip": "Illo at ab id ipsam deserunt dolorum.",
      "Deleted": false,
      "Rank": 667,
      "Type": "repellat",
      "ColorBlock": 638,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2024-01-03T23:03:56.4241234+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "corrupti",
      "Hidden": false,
      "FullName": "Miss Shane Hilll",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 720
        }
      }
    }
  ],
  "PersonNumber": "1666544",
  "FullName": "Miss Brandy Jacobi DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "dolores",
      "StrippedValue": "similique",
      "Description": "Integrated uniform analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "similique",
      "Description": "Integrated uniform analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "FormalName": "Friesen, Jaskolski and Marvin",
  "Address": null,
  "Post3": "repudiandae",
  "Post2": "omnis",
  "Post1": "vero",
  "Kanalname": "officia",
  "Kanafname": "dolores",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 892,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 498,
  "DbiKey": "nihil",
  "DbiLastModified": "2020-08-05T23:03:56.4271235+02:00",
  "DbiLastSyncronized": "2009-04-11T23:03:56.4271235+02:00",
  "SentInfo": 298,
  "ShowContactTickets": 591,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quasi",
      "StrippedValue": "consequatur",
      "Description": "Implemented national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 910
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "consequatur",
      "Description": "Implemented national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 910
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "quia",
      "Description": "Reduced static neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1000
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "quia",
      "Description": "Reduced static neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1000
        }
      }
    }
  ],
  "Source": 843,
  "ActiveErpLinks": 690,
  "ShipmentTypes": [
    {
      "Id": 639,
      "Name": "Reilly LLC",
      "ToolTip": "Qui repudiandae consequatur recusandae possimus.",
      "Deleted": false,
      "Rank": 719,
      "Type": "dolorem",
      "ColorBlock": 421,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2007-07-16T23:03:56.4276239+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "labore",
      "Hidden": false,
      "FullName": "Imani Nigel Treutel III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 393,
      "Comment": "nulla",
      "Registered": "2011-05-24T23:03:56.4276239+02:00",
      "RegisteredAssociateId": 863,
      "Updated": "2018-08-20T23:03:56.4276239+02:00",
      "UpdatedAssociateId": 581,
      "LegalBaseId": 488,
      "LegalBaseKey": "eum",
      "LegalBaseName": "Hessel, Romaguera and Homenick",
      "ConsentPurposeId": 736,
      "ConsentPurposeKey": "dignissimos",
      "ConsentPurposeName": "Schiller-Hickle",
      "ConsentSourceId": 270,
      "ConsentSourceKey": "blanditiis",
      "ConsentSourceName": "Hudson, Raynor and Fahey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    }
  ],
  "BounceEmails": [
    "lonny@runolfsdottir.uk",
    "jamison_beier@pfeffer.co.uk"
  ],
  "ActiveStatusMonitorId": 56,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Flavie Waters"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "nostrum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 591
    }
  }
}
```