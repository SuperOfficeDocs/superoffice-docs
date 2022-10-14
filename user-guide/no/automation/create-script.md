---
uid: help-en-automation-script-create
title: Create a script
description: Create a script
author: SuperOffice RnD
so.date: 06.29.2022
keywords: script, macro
so.topic: howto
language: no
---

# Create a script

In the **Edit script** screen you can edit or create a script. Documentation and examples of the use of CRMScript (EJScript) is available [here][1].

To create or edit a script:

1. Go to the **Macros and scripts** tab:

    * In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator.
    * In SuperOffice Service: Select ![icon][img1] **System settings** > **System design** > **CRMScript**.

1. Do one of the following:
    * To create a new script: Click **New script**.
    * To edit an existing script: Click the script name.

1. In the **Information** tab, edit or enter data about the script:
    * **Folder**: Select the folder in which you want to save the script.
    * **Name**: The name of the script
    * **Description**: A description of the script.
    * **Include name**: This is the unique name for this script, which you may use to include the script in another script, using the "include" function.
    * **Key**: The key is used with the "action=parse" function on the customer pages so that you can run scripts and set up script-based functionality in SuperOffice Customer Centre. The key prevents arbitrary scripts from being run from the customer pages.
    * **Show result of running script as HTML**: Select this option to show the result of the script as HTML.

1. In the **Script** tab, you can enter the script itself.

1. (optional) Click **Stage** to stage script. This allows you to test the changes by yourself.

1. (optional) Click **Execute script** to run the script. The result displays in the **Result** tab.

1. Click **OK**.

<!-- Referenced links -->
[1]: ../../../docs/automation/crmscript/index.yml

<!-- Referenced images -->
[img1]: ../../media/icons/globalmenu-settings-small.png

