---
uid: help-en-service-screen-properties
title: Screen properties
description: Screen properties
author: SuperOffice RnD
date: 06.29.2022
keywords: screen
content_type: reference
language: en
---

# Screen properties

Here you can edit the properties of a screen. You can create a script to precalculate variables, possibly based on CGI variables that the screen obtains via a URL, or on a form entry in the current screen or another screen.

## Properties

* **Folder:** If you have organized the screens into a folder structure, click <i class="ph ph-caret-down" aria-label="Chevron"></i> and select a folder.
* **Name**: A descriptive name for the screen.
* **ID string**: A string which uniquely identifies this screen, so that it can be referenced in URL's
* **Authentication key**: It is possible to run a custom-defined screen without being logged in as an user. To do this, you must supply an authentication key.
* **Warn on navigate**: Warn when the user navigates away from a page which contains unsaved data.
* **Use auto-save**: Activate the [autosave function][1].

## Scripts

* **Loading script (before setFromCgi)**: This script is run before the screen elements are assigned their values
* **Loading script (after setFromCgi)**: This script is run after the screen elements are assigned their values
* **Load script (run after everything else)**: This script is run at the end, after code and scripts for any buttons have been run.
* **Hidden variables**: The variables defined here are saved when the screen is submitted, so the next screen has access to them.

<!-- Referenced links -->
[1]: ../../../request/learn/create.md
