---
title: Void addAction(String button, String script, Bool doCheck)
path: /EJScript/Global functions/Void addAction(String button, String script, Bool doCheck)
intellisense: 1
langref: 1
sortOrder: 9495
keywords: addAction(String,String,Bool)
---

Adds an action to the Screen definition associated with this script (i.e. when the script is the load script for a Screen). An action is essentially a connection between a button with a given name, and a script. When a button in the screen is pressed, the list of actions are checked, and the action with the matching button name (e.g. "ok", "cancel", "addSomething") will be found and the script will be executed.


* **button:** The name of the associated button, such as "ok".
* **script:** The script code to execute for this action.
* **doCheck:** If this parameter is True, then the contents of all input elements will be checked for validity before the action is executed. Normally, this field should be True for buttons which submit the form, and False for buttons which add lines to grids, etc.


