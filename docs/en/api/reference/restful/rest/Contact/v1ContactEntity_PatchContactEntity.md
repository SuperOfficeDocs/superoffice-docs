---
title: PATCH Contact/{id}
uid: v1ContactEntity_PatchContactEntity
generated: true
---

# PATCH Contact/{id}

```http
PATCH /api/v1/Contact/{id}
```

Update a ContactEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IContactAgent} service SaveContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Contact/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ContactEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity  updated. |
| 404 | ContactEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nobis",
    "value": {}
  },
  {
    "op": "add",
    "path": "nobis",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 750,
  "Name": "Spencer, Schaefer and Lockman",
  "Department": "",
  "OrgNr": "670786",
  "Number1": "1366707",
  "Number2": "1095507",
  "UpdatedDate": "2007-09-01T16:55:29.4763416+02:00",
  "CreatedDate": "2009-05-06T16:55:29.4763416+02:00",
  "Emails": [
    {
      "Value": "soluta",
      "StrippedValue": "quam",
      "Description": "Grass-roots local approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "quam",
      "Description": "Grass-roots local approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 98,
      "Name": "Collier-Dicki",
      "ToolTip": "Quia praesentium voluptas.",
      "Deleted": false,
      "Rank": 718,
      "Type": "eum",
      "ColorBlock": 723,
      "IconHint": "magni",
      "Selected": true,
      "LastChanged": "2002-09-01T16:55:29.4763416+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "in",
      "Hidden": true,
      "FullName": "Lina McClure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "deserunt",
      "Description": "Right-sized responsive help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 413
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "deserunt",
      "Description": "Right-sized responsive help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 413
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "suscipit",
      "Description": "Customer-focused radical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "suscipit",
      "Description": "Customer-focused radical model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "ab",
      "Description": "User-friendly regional support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "ab",
      "Description": "User-friendly regional support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "Description": "Horizontal client-server capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "adipisci",
      "PersonId": 113,
      "Mrmrs": "corporis",
      "Firstname": "Elvera",
      "Lastname": "Adams",
      "MiddleName": "Tillman Inc and Sons",
      "Title": "provident",
      "Description": "Centralized 6th generation forecast",
      "Email": "wilbert@lakin.com",
      "FullName": "Marcelo Stanton",
      "DirectPhone": "(825)868-9967 x210",
      "FormalName": "Hand Inc and Sons",
      "CountryId": 133,
      "ContactId": 515,
      "ContactName": "Treutel-Shanahan",
      "Retired": 594,
      "Rank": 851,
      "ActiveInterests": 945,
      "ContactDepartment": "",
      "ContactCountryId": 394,
      "ContactOrgNr": "1102516",
      "FaxPhone": "1-473-957-4632 x81439",
      "MobilePhone": "915.636.5452 x2238",
      "ContactPhone": "(606)543-6575 x289",
      "AssociateName": "Hagenes Inc and Sons",
      "AssociateId": 979,
      "UsePersonAddress": false,
      "ContactFax": "perspiciatis",
      "Kanafname": "iste",
      "Kanalname": "hic",
      "Post1": "voluptatum",
      "Post2": "ipsum",
      "Post3": "earum",
      "EmailName": "mazie.strosin@towne.name",
      "ContactFullName": "Tre Cassin",
      "ActiveErpLinks": 616,
      "TicketPriorityId": 1000,
      "SupportLanguageId": 484,
      "SupportAssociateId": 201,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "distinctio",
  "Xstop": false,
  "ActiveInterests": 610,
  "GroupId": 962,
  "ActiveStatusMonitorId": 720,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 550,
  "DbiAgentId": 919,
  "DbiLastSyncronized": "2007-09-22T16:55:29.482322+02:00",
  "DbiKey": "sit",
  "DbiLastModified": "2013-02-11T16:55:29.482322+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 58,
  "ActiveErpLinks": 784,
  "BounceEmails": [
    "pauline@kovacekcronin.name",
    "delores_dibbert@feeney.biz"
  ],
  "Domains": [
    "accusamus",
    "assumenda"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Haven Thiel MD"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 588
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```