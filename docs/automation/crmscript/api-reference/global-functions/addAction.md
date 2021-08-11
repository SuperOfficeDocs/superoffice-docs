---
title: addAction
description: Void addAction(String button, String script, Bool doCheck)
intellisense: Void.addAction
langref: 1
keywords: addAction(String,String,Bool)
so.topic: reference
---

# addAction(String button, String script, Bool doCheck)

Adds an action to the Screen definition associated with this script (i.e. when the script is the load script for a Screen). An action is essentially a connection between a button with a given name and a script. When a button in the screen is pressed, the list of actions is checked, and the action with the matching button name (e.g. "ok", "cancel", "addSomething") will be found and the script will be executed.

* **button:** The name of the associated button, such as "ok".
* **script:** The script code to execute for this action.
* **doCheck:** If this parameter is True, then the contents of all input elements will be checked for validity before the action is executed. Normally, this field should be True for buttons that submit the form, and False for buttons that add lines to grids, etc.
