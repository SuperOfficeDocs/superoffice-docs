---
uid: help-en-using-document-templates-for-multiple-languages
title: using document templates for multiple languages
description: using document templates for multiple languages
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Use document templates in multiple languages in the project and sales guides

If your company has divisions in several countries, it may be useful to have the document templates in the project and sales guides available in several languages. Firstly, you must place the document templates for the different languages in the correct folders, and then specify who is to use the different language versions.

## Add document templates for languages

1. Open Windows Explorer and go to the **\\SuperOffice\\SO\-Arc\\Template** folder.

2. Create a folder for each of the languages you want document templates for (e.g. **\\SuperOffice\\SO\-Arc\\Template\\GE**). <!-- Fix reuse ID=a1 -->.

    <table data-cellspacing="0" style="width:100%; max-width:30.126%">
    
    <tbody>
    <tr>
    <td><p>Folder name</p></td>
    <td><p>Language</p></td>
    </tr>
    <tr>
    <td><p>NO</p></td>
    <td><p>Norwegian</p></td>
    </tr>
    <tr>
    <td><p>SP</p></td>
    <td><p>Spanish</p></td>
    </tr>
    <tr>
    <td><p>US</p></td>
    <td><p>English</p></td>
    </tr>
    <tr>
    <td><p>CZ</p></td>
    <td><p>Czech</p></td>
    </tr>
    <tr>
    <td><p>SW</p></td>
    <td><p>Swedish</p></td>
    </tr>
    <tr>
    <td><p>CN</p></td>
    <td><p>Chinese</p></td>
    </tr>
    <tr>
    <td><p>DA</p></td>
    <td><p>Danish</p></td>
    </tr>
    <tr>
    <td><p>JP</p></td>
    <td><p>Japanese</p></td>
    </tr>
    <tr>
    <td><p>GE</p></td>
    <td><p>German</p></td>
    </tr>
    <tr>
    <td><p>FI</p></td>
    <td><p>Finnish</p></td>
    </tr>
    <tr>
    <td><p>NL</p></td>
    <td><p>Dutch</p></td>
    </tr>
    <tr>
    <td><p>RU</p></td>
    <td><p>Russian</p></td>
    </tr>
    <tr>
    <td><p>FR</p></td>
    <td><p>French</p></td>
    </tr>
    <tr>
    <td><p>PL</p></td>
    <td><p>Polish</p></td>
    </tr>
    <tr>
    <td><p>IT</p></td>
    <td><p>Italian</p></td>
    </tr>
    </tbody>
    </table>

3. Place document templates for the different languages in the appropriate language folders. Each document template must have exactly the same file name and file type as the main template. The main template is the document template in the main language you use in SuperOffice. You will find it in the **Document template** list in the **Lists** screen (double-click a document template in the list to see the file name/type). See Add items to the Document - Template list

> [!TIP]
> If the document template for the language in question is NOT in the language folder, the document template in the main language is used.

## Specify document languages for users

You now need to select the correct document languages for the users who are going to use the document templates in the different languages:

1. Open the **Preferences** screen, select **System** from the **View group** list box and select **Preferred document language**.

2. Click **Add** under the **Active settings** list.

3. Select **User** under **This setting will apply to**.

    > [!TIP]
    > If the divisions are using satellite databases, you can choose to specify document languages for entire databases. You can also select document languages for entire groups, but in that case, the group in question must be the primary group of the users you are setting the document language for.

4. Click the **Target** list and select the required user.

5. Select the language you require in the **Preferred document language** list.

6. Click **Save**.

7. Repeat steps 2-6 for each user you want to set the document language for.
