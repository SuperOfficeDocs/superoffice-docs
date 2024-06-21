---
uid: crmscript-envir-tools
title: How do I create and run CRMScripts?
description: An overview of the CRMScript environment and the tools you need to create and run scripts.
keywords: CRMScript, interpreter, run script, execute script, CRMScript editor
author: Bergfrid Dias
date: 04.15.2024
topic: howto
---

# How do I create and run CRMScripts?

To use CRMScripts in your SuperOffice environment, you need a subscription to Development Tools (previously Expander Services).

## Creating CRMScripts

### Which editors can I use?

You can use whatever code editor you prefer. For example, Visual Studio Code. You can even use Notepad.

However, we recommend using the built-in editor in the SuperOffice admin client. This will give you coding assistance and **syntax highlighting**. You also have easy access to run and debug the script as you develop it.

## Running CRMScripts

> [!WARNING]
> CRMScript is extremely powerful. Unless you are cautious, scripting could potentially damage the data in your system. Know what you are doing and always test in a closed environment first.

**Pre-requisites:**

* An administrator account for the tenant or installation
* A Development Tools (previously Expander Services) license

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

You need to [register as a developer][2] to get access to our online development environment.

This signs you up for a developer user account and creates a test tenant in the SuperOffice Online Development (SOD) environment.

## Development Tools

**Expander Services** is our name for a set of development tools and development products that allow you to customize your CRM solution and to integrate other applications with SuperOffice. These tools extend beyond the standard configuration options offered to you out-of-the-box in the **Settings and maintenance** module.

Development Tools is a **subscription-based** license part of Expander Services and is available to all customers. It doesn’t matter if you run SuperOffice CRM in the cloud or have it installed on your premises.

[Read more][1]

<!-- Referenced links -->
[1]: ../../../admin/license/expander-services/tool-box.md
[2]: ../../../developer-portal/getting-started/get-access-to-sod.md
