---
title: POST Agents/Person/GetMyPerson
uid: v1PersonAgent_GetMyPerson
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 739,
  "Firstname": "Ellen",
  "MiddleName": "Crona Group",
  "Lastname": "Grimes",
  "Mrmrs": "cum",
  "Title": "accusantium",
  "UpdatedDate": "2019-05-22T15:29:22.2407696+02:00",
  "CreatedDate": "2014-01-03T15:29:22.2407696+01:00",
  "BirthDate": "2016-12-20T15:29:22.2407696+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aspernatur",
      "StrippedValue": "accusamus",
      "Description": "Persevering bifurcated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "accusamus",
      "Description": "Persevering bifurcated benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    }
  ],
  "Description": "Re-contextualized impactful superstructure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nihil",
      "StrippedValue": "necessitatibus",
      "Description": "Multi-layered 24 hour hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "necessitatibus",
      "Description": "Multi-layered 24 hour hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laborum",
      "StrippedValue": "quia",
      "Description": "Total client-driven protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "quia",
      "Description": "Total client-driven protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "esse",
      "Description": "Versatile 3rd generation function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "esse",
      "Description": "Versatile 3rd generation function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 541
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "et",
      "Description": "Extended neutral parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "et",
      "Description": "Extended neutral parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "quaerat",
      "Description": "Versatile background local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "quaerat",
      "Description": "Versatile background local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 380
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
      "Id": 867,
      "Name": "Altenwerth, Braun and Kutch",
      "ToolTip": "Reprehenderit modi nisi repellat quaerat.",
      "Deleted": false,
      "Rank": 150,
      "Type": "reiciendis",
      "ColorBlock": 489,
      "IconHint": "laborum",
      "Selected": false,
      "LastChanged": "2004-04-12T15:29:22.2427692+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Morton Lowe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 389
        }
      }
    }
  ],
  "PersonNumber": "1293524",
  "FullName": "Rafael Larkin",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "repellendus",
      "Description": "Cross-platform fresh-thinking contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 467
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "repellendus",
      "Description": "Cross-platform fresh-thinking contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 467
        }
      }
    }
  ],
  "FormalName": "Grimes, Jacobs and Nader",
  "Address": null,
  "Post3": "dolor",
  "Post2": "et",
  "Post1": "et",
  "Kanalname": "eveniet",
  "Kanafname": "est",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "temporibus",
  "ActiveInterests": 347,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 558,
  "DbiKey": "eligendi",
  "DbiLastModified": "2005-08-05T15:29:22.2462694+02:00",
  "DbiLastSyncronized": "2011-08-25T15:29:22.2462694+02:00",
  "SentInfo": 471,
  "ShowContactTickets": 357,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eligendi",
      "StrippedValue": "minus",
      "Description": "Object-based intangible moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "minus",
      "Description": "Object-based intangible moderator",
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
  "InternetPhones": [
    {
      "Value": "ea",
      "StrippedValue": "suscipit",
      "Description": "Managed responsive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "suscipit",
      "Description": "Managed responsive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "Source": 115,
  "ActiveErpLinks": 498,
  "ShipmentTypes": [
    {
      "Id": 803,
      "Name": "Brown LLC",
      "ToolTip": "Expedita asperiores perferendis nihil non ut debitis non.",
      "Deleted": true,
      "Rank": 81,
      "Type": "non",
      "ColorBlock": 322,
      "IconHint": "aliquid",
      "Selected": false,
      "LastChanged": "1997-01-14T15:29:22.2467684+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Alejandrin Jacobson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 876,
      "Comment": "voluptatum",
      "Registered": "1999-07-05T15:29:22.2467684+02:00",
      "RegisteredAssociateId": 310,
      "Updated": "2013-03-09T15:29:22.2467684+01:00",
      "UpdatedAssociateId": 652,
      "LegalBaseId": 575,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Abernathy Inc and Sons",
      "ConsentPurposeId": 811,
      "ConsentPurposeKey": "maxime",
      "ConsentPurposeName": "Purdy-Wilderman",
      "ConsentSourceId": 890,
      "ConsentSourceKey": "doloremque",
      "ConsentSourceName": "Nikolaus Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    }
  ],
  "BounceEmails": [
    "bud@kris.ca",
    "austin.jewess@simonissauer.biz"
  ],
  "ActiveStatusMonitorId": 874,
  "UserDefinedFields": {
    "SuperOffice:1": "Aleen Tremblay",
    "SuperOffice:2": "Wilfrid Renner"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "reprehenderit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 558
    }
  }
}
```