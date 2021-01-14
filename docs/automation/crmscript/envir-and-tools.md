---
title: How do I create and run CRMScripts?
uid: crmscript_howto
SortOrder: 30
---

To use CRMScripts in your SuperOffice environment, you need a subscription to Expander Services.

## Creating CRMScripts

### Which editors can I use?

You can use whatever code editor you prefer. For example, Visual Studio Code. You can even use Notepad.

However, we recommend using the built-in editor in the SuperOffice admin client. This will give you coding assistance and **syntax highlighting**. You also have easy access to run and debug the script as you develop it.

## Running CRMScripts

> [!WARN]
> CRMScript is extremely powerful. Unless you are cautious, scripting could potentially damage the data in your system. Know what you are doing and always test in a closed environment first.

**Pre-requisites:**

* An administrator account for the tenant or installation
* An Expander Services license

### Where does CRMScript run?

You need to run your scripts in an environment that has a CRMScript **interpreter**.
For SuperOffice CRM Online, this is available in the Sales and Service admin clients.

**In Sales:**

1. Open the Admin client by selecting **Settings and maintenance** from the hamburger menu.
2. Select **CRMScript** from the left menu.

**In Service:**

1. Click the cogwheel in the upper-right corner.
2. Click **System design** and then click **CRMScript**.

### How to add a script

> [!TIP]
> Create a new folder to group your scripts.

1. Click **New script**.
2. At the **Information** tab, name your script, add a description.
3. Enter a label to uniquely identify it when included in other scripts.
4. Select the **Script** tab. Then type or paste your script.
5. Click **OK** to save and **Execute script** to run it.

> [!TIP]
> If you don't see the **New script** button, you probably lack a valid license for Expander Services.

### How do I get a sandbox?

You need to [!include[register as a developer](./includes/link-register-dev.md)] as a developer to get access to our online development environment.

This signs you up for a developer user account and creates a test tenant in the SuperOffice Online Development (SOD) environment.

## Expander Services

Expander Services is our name for a set of tools that allow you to customize your CRM solution and to integrate other applications with SuperOffice. These tools extend beyond the standard configuration options offered to you out-of-the-box in the **Settings and maintenance** module.

Expander Services is a **subscription-based** license available to all customers. It doesn’t matter if you run SuperOffice CRM in the cloud or have it installed on your premises.

When you subscribe to Expander Services, you get access to the following tools:

* CRMScript
* Extra tables: Add new tables to the database and increase your flexibility
* Custom screens: Create new screens in Service to support your specific processes
* SuperOffice APIs: Create customizations by using developers' tools
