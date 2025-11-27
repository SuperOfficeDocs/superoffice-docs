---
uid: help-en-automation-script-create
title: Create or edit a script
description: Create a script
keywords: script, macro
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /en/automation/crmscript/learn/create-folder
  - /en/automation/crmscript/learn/create-script
language: en
index: true
---

# Create or edit a script

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Select **CRMScript** and do one of the following:
    * To create a new macro: Click **New macro**.
    * To edit an existing macro: Click the macro name.

1. In the **Information** tab, edit or enter data about the script:

    * **Folder**: Select the folder you want to save the script in.
    * **Name**
    * **Description**
    * **Include name**: A unique name for the script, used to include this script in another script.
    * **Key**: The key is used with the "action=parse" function on the customer pages so that you can run scripts and set up script-based functionality in SuperOffice Customer Centre. The key prevents arbitrary scripts from being run from the customer pages.
    * **Show result of running script as HTML**

1. In the **Script** tab, you can enter the script itself.

1. (optional) Click **Stage** to stage script. This allows you to test the changes by yourself.

1. (optional) Click **Execute script** to run the script. The result displays in the **Result** tab.

1. Click **OK**.

## <a id="folder"></a>Macro/script folder properties

Script and macro folders are used to organize your custom scripts and macros.

### Create folder

1. Click **New folder** at the top of the screen.
2. In the **Folder** field, select a parent folder in the list.
3. Enter a descriptive name for the folder in the **Name** field.
4. Click **OK**. The new folder is created.

### Edit folder

You can edit both the name of a folder and the details you entered when creating it.

1. Go to the required folder.
2. Click the name of the folder.
3. Amend the fields.
4. Click **OK**. The changes are saved.

### Delete folder

When you delete a folder, all its contents (such as selections, FAQ entries, reply templates, tables, scripts, and macros) are also deleted from SuperOffice.

1. Go to the required folder.
2. Click the name of the folder.
3. Click **Delete**.
4. Click **OK** to confirm. The folder and its contents are removed from SuperOffice.

## Related content

* [About CRMScript][1]
* [Debug scripts][2]
* [Trace scripts][3]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml
[2]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[3]: ../../../../en/automation/crmscript/debugging/using-trace.md

<!-- Referenced images -->
