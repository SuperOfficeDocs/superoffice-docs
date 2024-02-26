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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "et",
    "value": {}
  },
  {
    "op": "add",
    "path": "et",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 883,
  "Name": "Runolfsdottir Group",
  "Department": "",
  "OrgNr": "839988",
  "Number1": "1060805",
  "Number2": "1118406",
  "UpdatedDate": "2009-05-19T10:30:31.9168095+02:00",
  "CreatedDate": "2005-05-31T10:30:31.9168095+02:00",
  "Emails": [
    {
      "Value": "beatae",
      "StrippedValue": "accusantium",
      "Description": "Profit-focused national collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "accusantium",
      "Description": "Profit-focused national collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 56,
      "Name": "Kshlerin, Jakubowski and Hauck",
      "ToolTip": "Minus enim.",
      "Deleted": true,
      "Rank": 559,
      "Type": "itaque",
      "ColorBlock": 724,
      "IconHint": "aspernatur",
      "Selected": true,
      "LastChanged": "2002-06-18T10:30:31.9168095+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iure",
      "StyleHint": "harum",
      "Hidden": true,
      "FullName": "Gabrielle Amara Heidenreich PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Enhanced global attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Enhanced global attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "et",
      "Description": "Multi-lateral multi-tasking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "et",
      "Description": "Multi-lateral multi-tasking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "recusandae",
      "StrippedValue": "accusantium",
      "Description": "Quality-focused fresh-thinking encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "accusantium",
      "Description": "Quality-focused fresh-thinking encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    }
  ],
  "Description": "Synchronised mobile hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nulla",
      "PersonId": 8,
      "Mrmrs": "cupiditate",
      "Firstname": "Angie",
      "Lastname": "Rutherford",
      "MiddleName": "Gaylord LLC",
      "Title": "hic",
      "Description": "Future-proofed system-worthy interface",
      "Email": "linnea_abernathy@lynch.us",
      "FullName": "Heather Boyle V",
      "DirectPhone": "053.338.2015",
      "FormalName": "Weber-Windler",
      "CountryId": 386,
      "ContactId": 593,
      "ContactName": "Hintz, Lynch and Marvin",
      "Retired": 923,
      "Rank": 86,
      "ActiveInterests": 885,
      "ContactDepartment": "brand world-class convergence",
      "ContactCountryId": 727,
      "ContactOrgNr": "1454479",
      "FaxPhone": "1-976-654-6554",
      "MobilePhone": "376.549.5569 x3419",
      "ContactPhone": "228.742.4649",
      "AssociateName": "Stokes, Kshlerin and Bogisich",
      "AssociateId": 353,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "et",
      "Kanalname": "omnis",
      "Post1": "repudiandae",
      "Post2": "recusandae",
      "Post3": "nihil",
      "EmailName": "piper@welchjacobi.ca",
      "ContactFullName": "Herminio O'Conner",
      "ActiveErpLinks": 297,
      "TicketPriorityId": 787,
      "SupportLanguageId": 833,
      "SupportAssociateId": 656,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 495,
  "GroupId": 186,
  "ActiveStatusMonitorId": 166,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 788,
  "DbiAgentId": 954,
  "DbiLastSyncronized": "2012-07-18T10:30:31.9168095+02:00",
  "DbiKey": "ullam",
  "DbiLastModified": "2022-02-10T10:30:31.9168095+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 636,
  "ActiveErpLinks": 843,
  "BounceEmails": [
    "trisha_runolfsdottir@brekke.ca",
    "geraldine@bashirianstiedemann.com"
  ],
  "Domains": [
    "voluptatem",
    "architecto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "eaque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 10
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```