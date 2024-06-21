---
title: Troubleshooting
uid: sharepoint-troubleshooting
description: Troubleshooting SharePoint Documents
author: Bergfrid Dias
date: 01.15.2024
keywords: SharePoint, document, Microsoft Entra, ME-ID, AAD
topic: howto
envir: cloud
client: online
---

# Troubleshooting

## I get "Sorry, you don't have access" when I try to open a document from CRM​

Most likely you are member of a user group in SuperOffice CRM and not in the corresponding Microsoft Entra (formerly AAD) domain group that gives access to that document in SharePoint. For instance, the document you try to open has visible for Sales, but you are not a member of that group SharePoint. You need to contact your IT-Department to sort that out.​

## Why does my document end up in the folder AAA when I set visible for BBB? ​

Your SuperOffice for SharePoint has been configured with Folder structure = User Group. The documents you create will end up in the folder that is your primary group in SuperOffice, not the one you choose for Visible for. ​

 Ensure that your folder structure aligns with your desired document organization strategy.

## When I delete templates in SuperOffice CRM, they don't get deleted in SharePoint​

Yes, this is true and by design. Deleting templates in SuperOffice CRM is a so called "soft delete". That means they are only marked as deleted, and not actually deleted from SuperOffice CRM or from SharePoint. We have in our backlog to mark templates in SharePoint as "deleted" somehow, but for now they will remain as “ordinary” templates in SharePoint.​

## Why do I get an error when creating PDF or picture?​

This is due to the fact that you try to create an empty file. SharePoint does not allow us to store an empty "document". You must drag and drop a file to the dialog before saving.​

Same reason as 1, but you can add a new template (it can be a blank one, but cannot be an empty (0 kb)) in CRM Admin​ if you like.

## Sharing links when creating or updating document

When creating or updating document from CRM, the user will be given access to the document trough a sharing link, regardless of group membership​.

The reason for this is that we suspect there will be user groups in CRM that are not mapped to SharePoint. The user can be member of, for instance, Sales in CRM, but not any corresponding group in SharePoint. Creating a document and setting Visible for Sales will cause the user to not be able to access the document, both for editing and for updating meta-data.​

These links will not be removed when the document properties are updated later.​

## Revoke permissions of the "SuperOffice Document Library" enterprise application

SuperOffice integration uses an application called **SuperOffice Document Library**, which requires several permissions to be able to integrate SuperOffice CRM Online with SharePoint site. It is possible to change these permissions using **PowerShell**.

**Azure Cloud Shell** is a web-based command-line interface (CLI) that allows you to manage and interact with Azure services resources.​

The Microsoft Graph PowerShell module provides cmdlets for working with the Microsoft Graph API. Its **Get-MgServicePrincipal** cmdlet is used to alter the existing permissions.​

### Preparation

1. Install the Microsoft Graph PowerShell module in your Azure Cloud Shell session.

    Run `Install-Module -Name Microsoft.Graph`

2. Find the object ID for the enterprise application (required to change permissions via PowerShell).

    Go to **Microsoft Admin Center** > **Applications** > **Enterprise Applications** > **SuperOffice Document Library**.

### Example: remove only "Sites.FullControl.All"

```powershell
$permissionsToRemove = @("Sites.FullControl.All")
$grant = Get-MgServicePrincipalOauth2PermissionGrant -ServicePrincipalId [your Object Id]
$grant.Scope

$permissionsToRemove = $permissionsToRemove | % { $_.ToLower() }
$newPermissions = $grant.Scope.Split(" ") | ? { -not $permissionsToRemove.Contains($_.ToLower()) }
$newScope = $newPermissions -join " "
Update-MgOauth2PermissionGrant -OAuth2PermissionGrantId $grant.Id -Scope $newScope

$grant = Get-MgServicePrincipalOauth2PermissionGrant -ServicePrincipalId [your Object Id]
$grant.Scope
```

### Example: remove multiple permissions

To remove more than one permission at once, specify each separated by a comma.

```powershell
$permissionsToRemove = @("User.Read", "Sites.FullControl.All")
```

## How to retrieve document URLs in SuperOffice SharePoint v2

To retrieve document URLs in SuperOffice SharePoint v2, it's recommended to use the [Microsoft Graph API][1] for access instead of SOExternalref for greater reliability and compatibility across DocPlugin versions.

Fetching an ExtRef and assuming it has any meaningful value that can be interpreted by anyone other than the DocPlugin is incorrect code. While you may get lucky, the code will still be incorrect.

The Document table contains both ExtRef and ExtUrl values. The choice between the two depends on the specific file.

For the most effective approach, you should first determine whether a document's preferred method for opening is a stream or a URL using `DocumentAgent.GetDocumentProperties()`. If the value is a URL, you can request the URL (typically, but not guaranteed, stored in the ExtUrl column) , using `DocumentAgent.GetDocumentUrl()`.

For detailed guidance and references, consult SuperOffice's documentation:

* [GetDocumentProperties API Reference][2]
* [GetDocumentUrl API Reference][3]

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/graph/api/overview
[2]: ../../../api/reference/restful/rest/Document/v1DocumentEntity_GetDocumentProperties.md
[3]: ../../../api/reference/restful/rest/Document/v1DocumentEntity_GetDocumentUrl.md
