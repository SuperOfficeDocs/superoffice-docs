---
uid: help-en-parameter-examples
title: Parameter examples
description: Parameter examples
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Examples of the use of parameters

The following gives you examples of how to use the parameters.

## Example with a central ODBC database with Data Source Name SuperOffice, not Travel:

<table>
<tbody>
<tr>
<td><p>INI file</p></td>
<td><p>Parameters</p></td>
</tr>
<tr>
<td>SuperOffice.ini</td>
<td><p>[SuperOffice]</p>
<p>Archivepath=\\Server\SuperOffice\SO-ARC</p>
<p>Datapath=ODBC:SuperOffice</p></td>
</tr>
</tbody>
</table>

## Example with a central ODBC database, Data Source Name Saleserver, document archive and templates in different locations and Travel installed with a local ODBC database (MSDE or Sybase):

<table>
<tbody>
<tr>
<td><p>INI file</p></td>
<td><p>Parameters</p></td>
</tr>
<tr>
<td>SuperOffice.ini</td>
<td><p>[SuperOffice]</p>
<p>Archivepath=\\Server2\SuperOffice\SO-ARC</p>
<p>Datapath=ODBC:Saleserver</p>
<p>Templatepath=\\Server3\COMMON\TEMPLATE</p></td>
</tr>
<tr>
<td>SOUSER.INI</td>
<td><p>[SuperOffice]</p>
<p>Travel=TRUE</p>
<p>Local-archivepath=C:\"username"\AppData\Local\SuperOffice\So-Local</p>
<p>Local-datapath=ODBC:SuperOfficeLocal</p></td>
</tr>
</tbody>
</table>

> [!TIP]
> You can find the latest information about, among other things, settings in **SuperOffice.ini** and **SOUSER.INI** at <a href="https://docs.superoffice.com/onsite/travel/index.md" target="_blank">https://docs.superoffice.com/onsite/travel/index.md</a>.
