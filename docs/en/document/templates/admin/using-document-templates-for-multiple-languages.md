---
uid: help-en-using-document-templates-for-multiple-languages
title: Use document templates in multiple languages
description: Use document templates in multiple languages in the project and sales guides
keywords: document template, Preferred document language
author: SuperOffice Product and Engineering
date: 09.17.2025
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
deployment: onsite
language: en
redirect_from: 
  - /en/onsite/win-client/learn/using-document-templates-for-multiple-languages
---

# Use document templates in multiple languages

If your company has divisions in several countries, it may be useful to have the document templates in the project and sales guides available in several languages. First, you must place the document templates for the different languages in the correct folders, and then specify who is to use the different language versions.

## Add document templates for languages

1. Open Windows Explorer and go to the *\SuperOffice\SO_Arc\Template* folder.

2. Create a folder for each of the languages you want document templates for (see the following table). For example, *\SuperOffice\SO_Arc\Template\GE*.

3. Place document templates for the different languages in the appropriate language folders. Each document template must have exactly the same file name and file type as the main template. The main template is the document template in the main language you use in SuperOffice. You will find it in the **Document template** list in the **Lists** screen (double-click a document template in the list to see the file name/type).

> [!TIP]
> If the document template for the language in question is NOT in the language folder, the document template in the main language is used.

### Folder names for the different languages

[!include[Language codes](../../../globalization-and-localization/includes/table-legacy-language-codes.md)]

## Specify document languages for users

You now need to select the correct document languages for the users who are going to use the document templates in the different languages:

1. Open the **Preferences** screen, select **System** from the **View group** list box and select **Preferred document language**.

2. Click **Add** under the **Active settings** list.

3. Select **User** under **This setting will apply to**.

    > [!TIP]
    > If the divisions are using satellite databases, you can choose to specify document languages for databases. You can also select document languages for groups, but in that case, the group in question must be the primary group of the users you are setting the document language for.

4. Click the **Target** list and select the required user.

5. Select the language you require in the **Preferred document language** list.

6. Click **Save**.

7. Repeat steps 2-6 for each user you want to set the document language for.

## Related topics

* [All template variables][1] - Reference

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
