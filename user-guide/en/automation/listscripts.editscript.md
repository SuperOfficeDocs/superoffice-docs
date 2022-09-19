---
uid: help-en-blogic-listscripts-editscript
title: blogic listScripts editScript
description: blogic listScripts editScript
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create a script

In the **Edit script** screen you can edit or create a script. Documentation and examples of the use of CRMScript (EJScript) is available [here][1].

To create or edit a script:

1. In SuperOffice Service: Select ![icon][img1] **System settings** &gt; **System design** &gt; **CRMScript** and go to the **Macros and scripts** tab.
    In SuperOffice Settings and maintenance: Click **CRMScript** in the navigator and go to the **Macros and scripts** tab.
2. Do one of the following:
    * To create a new script: Click **New script**.
    * To edit an existing script: Click the script name. See [View a script/macro][2].
3. In the **Information** tab, edit or enter data about the script:
    * **Folder**: Select the folder in which you want to save the script.
    * **Name**: The name of the script
    * **Description**: A description of the script.
    * **Include name**: This is the unique name for this script, which you may use to include the script in another script, using the "include" function.
    * **Key**: The key is used with the "action=parse" function on the customer pages so that you can run scripts and set up script-based functionality in SuperOffice Customer Centre. The key prevents arbitrary scripts from being run from the customer pages.
    * **Show result of running script as HTML**: Select this option to show the result of the script as HTML.
4. In the **Script** tab, you can enter the script itself.
5. (optional) Click **Stage** to stage script. This allows you to test the changes by yourself.
6. (optional) Click **Execute script** to run the script. The result displays in the **Result** tab.
7. Click **OK**.

<!-- Referenced links -->
[1]: ../../../docs/automation/crmscript/index.yml
[2]: View-script-macro.md

<!-- Referenced images -->
[img1]: ../../media/icons/globalmenu-settings-small.png
