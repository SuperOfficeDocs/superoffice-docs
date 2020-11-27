---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: tested_oracle            # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Tested Oracle versions  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite                # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tested Oracle versions

SuperOffice CRM has been officially tested on Oracle 11g, 12c, and 18c.

<table>
<thead>
  <th>Server</th>
  <th>Client</th>
  <th>Version</th>
  <th>ODBC driver</th>
</thead>
<tbody>
  <tr>
    <td>Oracle 18c</td>
    <td>Oracle 18c Client</td>
    <td>18.3.0.0.0</td>
    <td>*</td>
  </tr>
  <tr>
    <td>Oracle 12c</td>
    <td>Oracle 12c Client</td>
    <td> 12.1.0.1.0</td>
    <td>Oracle in OraClient 12home 12.01.00.01</td>
  </tr>
  <tr>
    <td>Oracle 11g Release 2</td>
    <td>Oracle 11g Client</td>
    <td> 11.2.0.1.0</td>
    <td>Oracle in Orahome11 v. 11.2.0.3.0 or 11.2.0.1.0</td>
  </tr>
  <tr>
    <td>Oracle 11g Release 1</td>
    <td>Oracle 11g Client</td>
    <td>11.1.0.7.0 or 11.1.0.6.0</td>
    <td>Oracle in Orahome11 v. 11.1.0.7.0 or 11.1.0.6.0</td>
  </tr>
</tbody>
</table>

For Oracle 12c and 11g, use driver file *SQORA32.DLL*.

## Oracle 18c compatibility \*

[!include[Oracle 18c caution](./includes/oracle-18c-drivers.md)]
