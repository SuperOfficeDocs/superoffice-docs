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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 844,
  "Name": "Kemmer-Bednar",
  "Department": "",
  "OrgNr": "1128951",
  "Number1": "1140428",
  "Number2": "1125565",
  "UpdatedDate": "2022-04-13T11:22:37.6961082+02:00",
  "CreatedDate": "1998-03-02T11:22:37.6961082+01:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "error",
      "Description": "Cross-platform analyzing synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "error",
      "Description": "Cross-platform analyzing synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 899,
      "Name": "Conn LLC",
      "ToolTip": "Impedit totam.",
      "Deleted": true,
      "Rank": 994,
      "Type": "sequi",
      "ColorBlock": 346,
      "IconHint": "esse",
      "Selected": false,
      "LastChanged": "2010-01-31T11:22:37.6961082+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illo",
      "StyleHint": "exercitationem",
      "Hidden": true,
      "FullName": "Mrs. Lucienne Orie Reynolds Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "non",
      "Description": "Digitized disintermediate software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "non",
      "Description": "Digitized disintermediate software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 331
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "commodi",
      "StrippedValue": "quasi",
      "Description": "Persevering reciprocal throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "quasi",
      "Description": "Persevering reciprocal throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "dignissimos",
      "Description": "Compatible client-server utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "dignissimos",
      "Description": "Compatible client-server utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "Description": "Cross-group needs-based internet solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 251,
      "Mrmrs": "et",
      "Firstname": "Harry",
      "Lastname": "Kerluke",
      "MiddleName": "Jakubowski-Bernhard",
      "Title": "perspiciatis",
      "Description": "Re-contextualized needs-based alliance",
      "Email": "hassan.wolf@strackeschuster.name",
      "FullName": "Prof. Dock Littel",
      "DirectPhone": "(872)454-8272 x033",
      "FormalName": "Sawayn Inc and Sons",
      "CountryId": 741,
      "ContactId": 400,
      "ContactName": "Friesen-Schroeder",
      "Retired": 168,
      "Rank": 409,
      "ActiveInterests": 719,
      "ContactDepartment": "",
      "ContactCountryId": 649,
      "ContactOrgNr": "340757",
      "FaxPhone": "1-312-257-7099",
      "MobilePhone": "432.198.7104",
      "ContactPhone": "(302)837-5168 x1008",
      "AssociateName": "Murazik, O'Kon and Koelpin",
      "AssociateId": 145,
      "UsePersonAddress": false,
      "ContactFax": "repudiandae",
      "Kanafname": "iusto",
      "Kanalname": "voluptatem",
      "Post1": "expedita",
      "Post2": "molestiae",
      "Post3": "blanditiis",
      "EmailName": "hassie.huel@waelchi.name",
      "ContactFullName": "Tyrel Cole",
      "ActiveErpLinks": 516,
      "TicketPriorityId": 129,
      "SupportLanguageId": 490,
      "SupportAssociateId": 615,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "repudiandae",
  "Xstop": false,
  "ActiveInterests": 453,
  "GroupId": 361,
  "ActiveStatusMonitorId": 795,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 291,
  "DbiAgentId": 65,
  "DbiLastSyncronized": "2016-05-28T11:22:37.6961082+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2005-07-26T11:22:37.6961082+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 53,
  "ActiveErpLinks": 142,
  "BounceEmails": [
    "tina_mills@sawayn.uk",
    "keon_ortiz@trantowfisher.ca"
  ],
  "Domains": [
    "omnis",
    "earum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1445329401",
    "SuperOffice:2": "Mr. Tiffany Abbott V"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "corrupti",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 12
    }
  }
}
```