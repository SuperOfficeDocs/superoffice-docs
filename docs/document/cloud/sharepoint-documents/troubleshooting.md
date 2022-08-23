---
title: Troubleshooting
uid: sharepoint-troubleshooting
description: Troubleshooting SharePoint Documents
author: Bergfrid Dias
so.date: 06.20.2022
keywords: SharePoint, document
so.topic: howto
so.envir: cloud
so.client: online
---

# Troubleshooting

## Why do I get a “Sorry, you don't have access” when I try to open a document from CRM?​

Most likely you are member of a user group in SuperOffice CRM and not in the corresponding AAD (domain) group that gives access to that document in SharePoint. For instance, the document you try to open has visible for Sales, but you are not a member of that group SharePoint. You need to contact your IT-Department to sort that out. ​

## Why does my document end up in the folder AAA when I set visible for BBB? ​

Your SuperOffice for Sharepoint has been configured with Folder structure = User Group. The documents you create will end up in the folder that is your primary group in SuperOffice, not the one you choose for Visible for. ​

## When I delete templates in SuperOffice CRM, the don’t get deleted in SharePoint​

Yes, this is true and by design. Deleting templates in SuperOffice CRM is a so called “soft delete”. That means they are only marked as deleted, not actually delete from SuperOffice CRM or from SharePoint. We have in our backlog to mark templates in SharePoint as “deleted” somehow, but for now they will remain as “ordinary” templates in SharePoint. ​

## Why do I get an error when creating  PDF or picture?​

This is due to the fact that you try to create an empty file. SharePoint does not allow us to store an empty “document”. You must drag and drop a file to the dialog before saving. ​

Same reason as 1, but you can add a new template (it can be a blank one, but cannot be an empty (0 kb)) in CRM Admin​ if you like.

## When creating or updating document from CRM. The user will be given access to the document trough a sharing link, regardless of group membership. ​

The reason for this is that we suspect there will user groups in CRM that are not mapped to SharePoint. The user can be member of, for instance, Sales in CRM, but not any corresponding group in SharePoint. Creating a document and setting visible for Sales will cause the user to not be able to access the document, both for editing and for updating meta-data. ​

These links will not be removed when the document properties are updated later. ​


<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/
