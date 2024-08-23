---
title: POST Agents/Person/GetSalesRep
uid: v1PersonAgent_GetSalesRep
generated: true
---

# POST Agents/Person/GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.


If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Emard, Donnelly and Kling",
  "PersonFirstname": "Brisa",
  "PersonLastname": "Reilly",
  "EmailAddress": "malcolm_gorczany@beahan.info",
  "PhoneNumber": "1159203"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 657,
  "Firstname": "Peyton",
  "MiddleName": "Nienow LLC",
  "Lastname": "Kassulke",
  "Mrmrs": "deleniti",
  "Title": "sapiente",
  "UpdatedDate": "2012-07-24T13:28:23.1481055+02:00",
  "CreatedDate": "2020-03-28T13:28:23.1481055+01:00",
  "BirthDate": "2022-07-07T13:28:23.1481055+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Customizable coherent encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "saepe",
      "Description": "Customizable coherent encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "Description": "Focused content-based project",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Advanced reciprocal open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "aut",
      "Description": "Advanced reciprocal open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "possimus",
      "StrippedValue": "nobis",
      "Description": "Horizontal asynchronous protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "nobis",
      "Description": "Horizontal asynchronous protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "id",
      "StrippedValue": "dicta",
      "Description": "Operative well-modulated process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "dicta",
      "Description": "Operative well-modulated process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "molestias",
      "Description": "Stand-alone modular info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "molestias",
      "Description": "Stand-alone modular info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 970
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "error",
      "StrippedValue": "sit",
      "Description": "Future-proofed radical algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "sit",
      "Description": "Future-proofed radical algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 76
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
      "Id": 689,
      "Name": "Hartmann, Braun and Feeney",
      "ToolTip": "Voluptas mollitia assumenda.",
      "Deleted": false,
      "Rank": 930,
      "Type": "dicta",
      "ColorBlock": 533,
      "IconHint": "corporis",
      "Selected": true,
      "LastChanged": "2003-09-29T13:28:23.1481055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "laboriosam",
      "Hidden": true,
      "FullName": "Nels Bernard Friesen MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    }
  ],
  "PersonNumber": "826907",
  "FullName": "Caesar Schmitt",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "animi",
      "Description": "Exclusive next generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "animi",
      "Description": "Exclusive next generation concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "FormalName": "Heaney Inc and Sons",
  "Address": null,
  "Post3": "deleniti",
  "Post2": "qui",
  "Post1": "quisquam",
  "Kanalname": "dolorum",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 193,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 843,
  "DbiKey": "voluptatem",
  "DbiLastModified": "2010-07-13T13:28:23.1637276+02:00",
  "DbiLastSyncronized": "2008-06-18T13:28:23.1637276+02:00",
  "SentInfo": 292,
  "ShowContactTickets": 356,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "asperiores",
      "StrippedValue": "voluptas",
      "Description": "Horizontal dynamic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "voluptas",
      "Description": "Horizontal dynamic matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 417
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "saepe",
      "StrippedValue": "distinctio",
      "Description": "User-centric bandwidth-monitored customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "distinctio",
      "Description": "User-centric bandwidth-monitored customer loyalty",
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
  "Source": 9,
  "ActiveErpLinks": 331,
  "ShipmentTypes": [
    {
      "Id": 472,
      "Name": "Schroeder, Hauck and Mraz",
      "ToolTip": "Dignissimos qui libero.",
      "Deleted": false,
      "Rank": 759,
      "Type": "omnis",
      "ColorBlock": 122,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "2000-10-19T13:28:23.1637276+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Ms. Emmalee Alejandrin Gaylord",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 404
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 455,
      "Comment": "repudiandae",
      "Registered": "2015-04-10T13:28:23.1637276+02:00",
      "RegisteredAssociateId": 909,
      "Updated": "1997-08-11T13:28:23.1637276+02:00",
      "UpdatedAssociateId": 204,
      "LegalBaseId": 747,
      "LegalBaseKey": "dicta",
      "LegalBaseName": "Kovacek-Fritsch",
      "ConsentPurposeId": 919,
      "ConsentPurposeKey": "quos",
      "ConsentPurposeName": "Miller-Howe",
      "ConsentSourceId": 322,
      "ConsentSourceKey": "totam",
      "ConsentSourceName": "Muller, Wuckert and Ziemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "BounceEmails": [
    "emmie@rohan.us",
    "forest@towne.name"
  ],
  "ActiveStatusMonitorId": 829,
  "CreatedByFormId": 213,
  "UserDefinedFields": {
    "SuperOffice:1": "Delta Becker",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "accusamus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 397
    }
  }
}
```