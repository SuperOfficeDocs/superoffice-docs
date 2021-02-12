---
title: netserver_patterns
description: SuperOffice NetServer patterns
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# Common patterns

A pattern can be defined as a general repeatable solution to a commonly occurring problem. The pattern is not a finished design or piece of code. It’s a description or a template for how to solve a problem that can be used in many different situations.

## Why SuperOffice uses patterns

Patterns can speed up the development process by providing tested, proven development paradigms. Reusing these patterns helps to prevent subtle issues that can cause major problems and improves code readability for coders and architects familiar with the patterns. Also, patterns allow developers to communicate using well-known, well-understood names for software interactions.

Common design patterns can be improved over time making them more robust than ad-hoc designs. Furthermore .Net has a good infrastructure for dynamically composing your code – loading, using reflection to parse and inspect and invoke.

## Plugin pattern

These patterns interact with the main application to provide a certain, very specific function on-demand. The NetServer application provides services that can be used by the plugin. The plugins are dependent on the services provided by the NetServer and do not usually work by themselves. Many of the big functionality areas in NetServer such as Lists, Archives, Tooltips, GUI Configuration, and Search Operators are implemented using plugins.

* A public interface of the class is defined with an attribute that in effect says, "I am a plugin of this type".
* Write the required class with the necessary attributes.
* Write a Factory that locates any class that implements the given interface and is marked with its attributes.

As a result, you can add implementation without changing the NetServer code, which will be picked up automatically by the NetServer.

Another advantage is that the Factory scans assemblies on startup, so the overhead is concentrated there and the rest of the time there is minimal extra cost.

### Example using the Tooltip provider plugin

![ALT][img1]

Tooltips are nice, especially when they show a lot of information. But such tools can be expensive and it is impossible to pre-calculate all of them in advance. Instead, we may use a tooltip hint.

The following image is a tooltip hint for the `person_id` 123.

When the tooltip needs to be displayed, the tooltip service is called with the tooltip-hint as the parameter. The tooltip providers – plugins, do the translation of the hint to the actual tooltip. The `TooltipProviderFactory` will call all the plugins that declare that they support the given hint in sequence.

If you create your own provider, it can do anything and add it to the tooltip. This will be reflected in all instances of the Person tooltips in the whole application.

```csharp
using SuperOffice.CRM.Tooltips;
using SuperOffice.CRM.Rows;
//TooltipPlugin is the Attribute used to indicate that the class is a
//Tooltip Provider Plugin. The class needs to implement the
//SuperOffice.CRM>Tooltips.ITooltipProviderPlugin interface.
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

This example shows how a tooltip provider plugin is used to calculate total sales for a person. The tooltip hint for a person is "person\_id", but you don't have to know that since the `PersonTooltipProvider` declares a string constant, `PersonKey`, for this purpose. We simply refer to it in our attribute, thereby saying, "Whatever the key for person tooltips is, I represent the same thing".

The class inherits from `TooltipPluginBase`, which is mostly concerned with parsing incoming keys. The `TryGetIntHint` method will return, as an int, the value part of a tooltip hint for the given key. This is a simple way to get the person ID as an int.

Then we fetch all sales made by this person. However, if a custom query were used to fetch fewer fields it would be better in terms of performance, but this one-line method works and is extremely simple. Note the use of the GetFromIdx... method, which corresponds to an index in the database, this is will ensure avoidance of potentially expensive table scans for large tables.

If the number of sales is greater than zero, we calculate the total amount (ignoring things like currency) and return a formatted string. If not, we simply return a string saying "no sales". These strings will be appended to the tooltip under construction by the tooltip system and returned to the Browser for display.

All that remains is to tell NetServer about our DLL using the config file:

```xml
<Factory>
  <DynamicLoad>
    <add key="MyPlugin" value="C:\NetServer\Server\Feature SIX\bin\Debug\MyPlugin.dll" />
  </DynamicLoad>
</Factory>
```

NetServer will load the assembly. The TooltipProviderFactory will scan it for compatible plugins, and pick it up. Whenever a tooltip request comes in with the key that our plugin has declared, it will be called and is then running in process, authenticated, with all of NetServer available.

## Factory pattern

**Factory** is the location in the code at which objects are constructed. The intent of employing this pattern is to isolate the creation of objects from their usage. This allows the new derived types to be introduced into the code with no change to the code that uses the base objects. The use of these patterns makes it possible to interchange the classes without changing the code that uses them even at runtime. However, employment of this pattern incurs the risk of unnecessary complexity and extra work in the initial writing of code.

The NetServer implementation of the Factory patterns consists of an Interface named `IPrivateFactory` that is located in the `SuperOffice.Factory` namespace. The Factory hides the details about the settings from the user. Some of the factory patterns exposed through the NetServer include `ConnectionFactory` that is mostly seen by the user compared to the `AddressFactory`, which is used mostly within the NetServer code.

Since the user mostly views the `ConnectionFactory` during the corse of the next few sections, Factory patterns will be explained in terms of the `ConnectionFactory`. Depending on the service mode setup, the `ConnectionFactory` will give back different objects.

For example, `ConnectionFactory.GetConnection` returns an `SoConnection`. This could be configured in a way such that it would return another sub-class of `SoConnection`.

The Factory pattern requires that you replace our standard class with your class, which means you have to make all SuperOffice functions plus your own functions, – this means extra bit of work. This makes the Plugin pattern simpler than the Factory pattern because you only have to provide the functionality in your own plugin. Once the sub-class is ready, the user needs to set it up in the config file. When it has been set up, the Factory would automatically return the user-defined class instead of the standard class, since the Factory looks in the config file to check whether the standard class has been replaced with the user’s own implementation. The config file points to the assembly, which contains the user’s custom class or plugin. For Example:

```XML
<Factory>
  <DynamicLoad>
    <add key="MyFactory" value="C:\NetServer\Server\Feature SIX\bin\Debug\ MyFactory.dll" />
  </DynamicLoad>
</Factory>
```

Below is an example of the use of the get ConnectionFactory.

```csharp
using SuperOffice.Data;
using SuperOffice.Data.SQL;
//Create a DataSet of the Contact table          
ContactTableInfo conTableInfo = TablesInfo.GetContactTableInfo();
//SQL Statement
Select newSelect = S.NewSelect();
newSelect.ReturnFields.Add(conTableInfo.Name,
conTableInfo.Department);
newSelect.Restriction = conTableInfo.ContactId.In(S.Parameter(10));
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("SAM", "sam"))
{
  if (mySession == null) return;
  //Establish a Connection with the Database
  SoConnection newConn = ConnectionFactory.GetConnection();
  SoCommand newComm = newConn.CreateCommand();
  newComm.SqlCommand = newSelect;
  newConn.Open();
  SoDataReader newReader = newComm.ExecuteReader();
  //Retrieve the Date
  while (newReader.Read())
  {
    string conName = newReader.GetString(0);
  }
  //Close Reader and Dispose of the Session
  newReader.Close();
  mySession.Dispose();
}
```

For us to use the `ConnectionFactory`, the `SuperOffice.Data` namespace has been called. After a `DataSet` of the `Contact` table has been created using OSQL statements.

[OSQL description and example][1]

To use the connection, we create an instance of the `SoConnection` using the `ConnectionFactory`, `GetConnection` method.

The `newConn` variable may contain an `SoConnection` object, or it may contain a sub-class of `SoConnection`. The factory controls what sort of object is returned. The factory is configured using the *app.config* file.

<!-- Referenced links -->
[1]: ../osql/index.md

<!-- Referenced images -->
[img1]: media/image001.jpg