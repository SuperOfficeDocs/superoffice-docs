---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=533
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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

### Response body: ContactEntity

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 32,
  "Name": "Von Inc and Sons",
  "Department": "",
  "OrgNr": "880933",
  "Number1": "615919",
  "Number2": "931850",
  "UpdatedDate": "2009-06-17T23:03:55.3166381+02:00",
  "CreatedDate": "2020-12-05T23:03:55.3166381+01:00",
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "molestias",
      "Description": "Robust maximized standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "molestias",
      "Description": "Robust maximized standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 3,
      "Name": "Huel-Douglas",
      "ToolTip": "Autem doloribus.",
      "Deleted": false,
      "Rank": 275,
      "Type": "voluptates",
      "ColorBlock": 496,
      "IconHint": "illo",
      "Selected": false,
      "LastChanged": "2020-12-23T23:03:55.3171394+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Prof. Dora Modesto Crist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iusto",
      "StrippedValue": "aliquid",
      "Description": "Object-based well-modulated knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "aliquid",
      "Description": "Object-based well-modulated knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "iste",
      "Description": "User-friendly bi-directional help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "iste",
      "Description": "User-friendly bi-directional help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Open-architected upward-trending framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Open-architected upward-trending framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    }
  ],
  "Description": "Customer-focused high-level infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ratione",
      "PersonId": 131,
      "Mrmrs": "beatae",
      "Firstname": "Phoebe",
      "Lastname": "Beer",
      "MiddleName": "Gibson-Rempel",
      "Title": "ipsam",
      "Description": "Persistent executive solution",
      "Email": "pascale.dubuque@roobferry.com",
      "FullName": "Lavinia Mitchell",
      "DirectPhone": "854.835.3525",
      "FormalName": "Strosin, Howe and Jacobi",
      "CountryId": 500,
      "ContactId": 351,
      "ContactName": "Christiansen, Murazik and Klein",
      "Retired": 767,
      "Rank": 743,
      "ActiveInterests": 946,
      "ContactDepartment": "",
      "ContactCountryId": 468,
      "ContactOrgNr": "719821",
      "FaxPhone": "006.192.0941",
      "MobilePhone": "845.027.4857 x42269",
      "ContactPhone": "871.666.6060",
      "AssociateName": "Torphy, Hilpert and Sawayn",
      "AssociateId": 801,
      "UsePersonAddress": false,
      "ContactFax": "maxime",
      "Kanafname": "asperiores",
      "Kanalname": "dolores",
      "Post1": "sed",
      "Post2": "atque",
      "Post3": "omnis",
      "EmailName": "meredith@blick.uk",
      "ContactFullName": "Ambrose Sanford II",
      "ActiveErpLinks": 30,
      "TicketPriorityId": 643,
      "SupportLanguageId": 651,
      "SupportAssociateId": 215,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 303
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "in",
  "Xstop": true,
  "ActiveInterests": 224,
  "GroupId": 985,
  "ActiveStatusMonitorId": 899,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 815,
  "DbiAgentId": 604,
  "DbiLastSyncronized": "1998-07-18T23:03:55.3211377+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "2017-10-19T23:03:55.3211377+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 623,
  "ActiveErpLinks": 995,
  "BounceEmails": [
    "donato@carrollrodriguez.uk",
    "arlie@greenholtfay.uk"
  ],
  "Domains": [
    "neque",
    "sit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Odie Haley PhD",
    "SuperOffice:2": "Ora Schumm"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "mollitia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 961
    }
  }
}
```