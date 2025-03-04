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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "ut",
    "value": {}
  },
  {
    "op": "add",
    "path": "ut",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 786,
  "Name": "Kutch-Howell",
  "Department": "",
  "OrgNr": "1016268",
  "Number1": "1183769",
  "Number2": "1749777",
  "UpdatedDate": "2012-04-16T14:13:48.5539074+02:00",
  "CreatedDate": "2019-03-26T14:13:48.5539074+01:00",
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "laborum",
      "Description": "Compatible dedicated policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 41
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "laborum",
      "Description": "Compatible dedicated policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 41
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 43,
      "Name": "Pfannerstill-Botsford",
      "ToolTip": "Est temporibus totam ipsa aliquam.",
      "Deleted": false,
      "Rank": 912,
      "Type": "mollitia",
      "ColorBlock": 689,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2004-01-19T14:13:48.5539074+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "reiciendis",
      "Hidden": false,
      "FullName": "Nova Mario Luettgen III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "quidem",
      "Description": "Open-architected didactic approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "quidem",
      "Description": "Open-architected didactic approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 906
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "recusandae",
      "Description": "Vision-oriented value-added software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "recusandae",
      "Description": "Vision-oriented value-added software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "voluptatem",
      "Description": "Object-based user-facing projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "voluptatem",
      "Description": "Object-based user-facing projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "Description": "Adaptive 3rd generation neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 173,
      "Mrmrs": "inventore",
      "Firstname": "Morgan",
      "Lastname": "Cummerata",
      "MiddleName": "Daugherty Inc and Sons",
      "Title": "aut",
      "Description": "Profit-focused encompassing database",
      "Email": "hayley@schultz.uk",
      "FullName": "Allison Shields MD",
      "DirectPhone": "1-749-786-1775",
      "FormalName": "Buckridge, Gibson and Homenick",
      "CountryId": 729,
      "ContactId": 141,
      "ContactName": "Morissette Group",
      "Retired": 813,
      "Rank": 287,
      "ActiveInterests": 544,
      "ContactDepartment": "",
      "ContactCountryId": 917,
      "ContactOrgNr": "1597246",
      "FaxPhone": "266-986-6285 x6513",
      "MobilePhone": "512.679.1869 x9576",
      "ContactPhone": "(359)377-9348",
      "AssociateName": "Jast, Breitenberg and Labadie",
      "AssociateId": 673,
      "UsePersonAddress": true,
      "ContactFax": "culpa",
      "Kanafname": "ipsum",
      "Kanalname": "illo",
      "Post1": "sed",
      "Post2": "tenetur",
      "Post3": "enim",
      "EmailName": "mara.kerluke@dibbertschiller.name",
      "ContactFullName": "Mr. Marilie Eduardo Stiedemann I",
      "ActiveErpLinks": 1002,
      "TicketPriorityId": 432,
      "SupportLanguageId": 426,
      "SupportAssociateId": 652,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1016781",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": false,
  "ActiveInterests": 466,
  "GroupId": 515,
  "ActiveStatusMonitorId": 890,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 632,
  "DbiAgentId": 308,
  "DbiLastSyncronized": "2018-05-26T14:13:48.5539074+02:00",
  "DbiKey": "ipsum",
  "DbiLastModified": "2021-04-04T14:13:48.5539074+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 310,
  "ActiveErpLinks": 812,
  "BounceEmails": [
    "olin_stiedemann@kemmer.us",
    "beverly@bins.com"
  ],
  "Domains": [
    "neque",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Allison Mayert",
    "SuperOffice:2": "Lavinia Lemke"
  },
  "ExtraFields": {
    "ExtraFields1": "laudantium",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 836
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```