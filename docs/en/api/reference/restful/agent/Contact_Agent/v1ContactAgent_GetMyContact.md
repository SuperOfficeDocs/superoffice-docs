---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 609,
  "Name": "Kling, Sauer and Olson",
  "Department": "",
  "OrgNr": "1802772",
  "Number1": "1290950",
  "Number2": "1493630",
  "UpdatedDate": "2004-08-13T12:15:18.529758+02:00",
  "CreatedDate": "2001-11-15T12:15:18.529758+01:00",
  "Emails": [
    {
      "Value": "aspernatur",
      "StrippedValue": "ut",
      "Description": "Cross-group global functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "ut",
      "Description": "Cross-group global functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 158,
      "Name": "Steuber, Schimmel and Baumbach",
      "ToolTip": "Voluptatibus sapiente et harum.",
      "Deleted": false,
      "Rank": 468,
      "Type": "natus",
      "ColorBlock": 926,
      "IconHint": "repudiandae",
      "Selected": false,
      "LastChanged": "2018-06-15T12:15:18.529758+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quisquam",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Prof. Magnolia Mosciski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "eius",
      "Description": "Right-sized motivating local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "eius",
      "Description": "Right-sized motivating local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Synchronised assymetric core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "qui",
      "Description": "Synchronised assymetric core",
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
  "Faxes": [
    {
      "Value": "illum",
      "StrippedValue": "ab",
      "Description": "Operative object-oriented standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "ab",
      "Description": "Operative object-oriented standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 134
        }
      }
    }
  ],
  "Description": "Ameliorated heuristic internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 359,
      "Mrmrs": "in",
      "Firstname": "Nicola",
      "Lastname": "Denesik",
      "MiddleName": "Gusikowski, Mayer and Rau",
      "Title": "sunt",
      "Description": "Integrated assymetric neural-net",
      "Email": "laurence.anderson@mayerbashirian.ca",
      "FullName": "Mr. Carroll Amara Champlin",
      "DirectPhone": "287-681-5705 x66835",
      "FormalName": "Cartwright, Schamberger and Harvey",
      "CountryId": 423,
      "ContactId": 906,
      "ContactName": "Schmidt-Towne",
      "Retired": 760,
      "Rank": 410,
      "ActiveInterests": 853,
      "ContactDepartment": "reinvent enterprise infomediaries",
      "ContactCountryId": 693,
      "ContactOrgNr": "904041",
      "FaxPhone": "1-665-254-3500",
      "MobilePhone": "(165)436-8024 x54943",
      "ContactPhone": "(806)218-9372",
      "AssociateName": "Veum Inc and Sons",
      "AssociateId": 439,
      "UsePersonAddress": true,
      "ContactFax": "harum",
      "Kanafname": "maxime",
      "Kanalname": "cum",
      "Post1": "sapiente",
      "Post2": "ducimus",
      "Post3": "numquam",
      "EmailName": "serenity@emardcorkery.biz",
      "ContactFullName": "Miss Savannah Gleichner",
      "ActiveErpLinks": 174,
      "TicketPriorityId": 873,
      "SupportLanguageId": 126,
      "SupportAssociateId": 151,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptatum",
  "Xstop": false,
  "ActiveInterests": 614,
  "GroupId": 495,
  "ActiveStatusMonitorId": 587,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 506,
  "DbiAgentId": 665,
  "DbiLastSyncronized": "2009-11-04T12:15:18.5337594+01:00",
  "DbiKey": "sunt",
  "DbiLastModified": "2011-03-09T12:15:18.5337594+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 242,
  "ActiveErpLinks": 710,
  "BounceEmails": [
    "hollis.price@lesch.co.uk",
    "ettie_kreiger@lindgren.uk"
  ],
  "Domains": [
    "aspernatur",
    "quasi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Toy Annabell Jacobi",
    "SuperOffice:2": "1159785436"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "voluptatum"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "atque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 302
    }
  }
}
```