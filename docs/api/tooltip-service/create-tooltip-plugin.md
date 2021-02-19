---
title: create_tooltip_plugin      
description: How to extending the Tooltip service using plugins
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto
---

# How to extending the Tooltip service using plugins

The tooltip service can be extended using a plugin to include data that we want in our own application apart from the ones that have been provided by NetServer.

Below is an example of a plugin that is developed to enhance the person tooltip that is provided by NetServer. For more information on plugins, see the [agent patterns][1].

## Code

```csharp
using SuperOffice.CRM.Tooltips;
using SuperOffice.CRM.Rows;

// TooltipPlugin is the Attribute used to indicate that the class is a //Tooltip Provider Plugin. 
// The class need to implement the SuperOffice.CRM>Tooltips.ITooltipProviderPlugin interface.
[TooltipPlugin( "TotalSales:Person", PersonTooltipPlugin.PersonKey)]

//All plugins should implement the IPlugin interface. In the case of
//the example below TooltipPluginBase inherits from the IPlugin interface
public class DemoTotalPersonSaleTooltipPlugin : TooltipPluginBase
{
  protected override string InnerGetTooltip()
  {
    int personId;
    //Gets the value part of the tooltip
    if( base.TryGetIntHint(PersonTooltipPlugin.PersonKey, out personId ) )
    {
      SaleRows sales = SaleRows.GetFromIdxPersonId( personId );
      if( sales.Count > 0 )
      {
        double totalSales = 0.0;

        //Fetches all Sales per Person
        foreach( SaleRow sale in sales )
          totalSales += sale.Amount;

        return string.Format( "Total sales: {0}<br/> Average sale: {1}<br/> Number of sales: {2}", totalSales, totalSales / sales.Count, sales.Count );
      }
      else
        return "This person has no sales";
    }
    else
      return string.Empty;
  }
}
```

## Walk-through

![01][img1]

This example shows how a tooltip provider plugin is used to calculate total sales for a person. The tooltip hint for person is "person\_id". We don't have to know the tooltip hint, because the `PersonTooltipProvider` declares a string constant named `PersonKey`, for this purpose. We simply refer to it in our attribute, thereby saying, "Whatever the key for person tooltips is, I represent the same thing". If you want to return tooltips for your own tables, you can use your own key string here.

The class inherits from `TooltipPluginBase`, which is mostly concerned with parsing incoming keys. The `TryGetIntHint` method will return, as an int, the value part of a tooltip hint for the given key. This is a simple way to get the person id as an int.

Then we fetch all sales made by this person. However, if a custom query were used to fetch fewer fields it would be better in terms of performance, but this one-line method works and is extremely simple.

> [!NOTE]
> The `GetFromIdx` method corresponds to an index in the database. Using it will ensure the avoidance of potentially expensive table scans for large tables.

If the number of sales is greater than zero, we calculate the total amount (ignoring things like currency) and return a formatted string. If not, we simply return a string saying *no sales*. These strings will be appended to the tooltip under construction by the tooltip system and returned to the browser for display.

## Configure NetServer to use the plugin

All that remains is to tell NetServer about our DLL using the config file:

```XML
<Factory>
  <DynamicLoad>
    <add key="MyPlugin" value="C:\NetServer\Server\bin\Debug\MyPlugin.dll" />
  </DynamicLoad>
</Factory>
```

NetServer will load the assembly. The `TooltipProviderFactory` will scan it for compatible plugins, and pick it up. Whenever a tooltip request comes in with the key that our plugin has declared, it will be called and is then running in process, authenticated, with all of NetServer available.

<!-- Referenced links -->
[1]: ../services/agents/agent-pattern.md

<!-- Referenced images -->
[img1]: media/image001.jpg
