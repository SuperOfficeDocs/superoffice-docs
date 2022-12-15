---
title: Parser code
uid: blogic_parser_code
description: Parser code
author:
so.date:
keywords:
so.topic: reference
---

# Parser code

This element lets you **display HTML text**, including data from the database as parser variables.
The database query is defined using a [line-based query syntax][1].

The body fields contain the HTML text to use for the element.

The results from the query will be stored in the parser as the name of the queried fields, for example, "ticket.title", "ticket.id", "customer.display_name".

> [!TIP]
> Try using `%PARSER_TREE%` to view all the available values.

This component also supports ajax.

## Example

```ajax
<script language='JavaScript' src='/JavaScript/ajax.js'></script>
<script language='JavaScript' src='/JavaScript/xml.js'></script>
<script>

function `fetchStuff()` {
  var message = "<someCommand ejScriptIncludeId='testAjax'>\n";
  message += "  <someNode>100</someNode>\n";
  message += "  <someNode>200</someNode>\n";
  message += "</someCommand>\n";

  ajax_addRequest("myTestControl", "EjScript", message)
}

function EjScript_processResponse(p_xmlNode) {
  var name = getAttribute(p_xmlNode, "name");
  var elem = document.getElementById("myTestField");
  elem.value = name + ": ";

  for (var i = 0; i < getLength(p_xmlNode.childNodes); i++) {
      if (getNodeName(getChild(p_xmlNode, i)) == "result")
        elem.value = elem.value + getText(getChild(p_xmlNode, i)) + " ";
  }
}
</script>

<input type="text" name="myTestField" id="myTestField" value="">
<input type="submit" name="testScript"  id="testScript" value="testScriptonClick=" fetchStuff(); return false;">
```

The function `EjScript_processResponse(p_xmlNode)` is called by the ajax framework, and if you have several such ajax based controls, you can test for a name match in the xml so you know what control to update.

The name is what you used in `ajax_addRequest("myTestControl", "EjScript", message)`.

A CRMScript is run by the ajax application on the server, you select which script in the XML request.

The CRMScript may do something like this:

```crmscript
#setLanguageLevel 2;

print("  <result>\n");
print("Number of nodes: " + getVariable("nodes.length"));
print("  </result>\n");

for (Integer i = 0; i < getVariable("nodes.length").toInteger(); i++) {
  print("  <result>\n");
  print("Node " + i.toString() + ": " + getVariable("nodes." + i.toString() + ".name") + "-" + getVariab("nodes." + i.toString() + ".value"));
  print("  </result>\n");
}
```

<!-- Referenced links -->
[1]: ../custom-screens/blogic-query-syntax.md
