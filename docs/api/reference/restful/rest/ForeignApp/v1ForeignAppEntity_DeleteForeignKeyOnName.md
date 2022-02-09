---
title: DEL ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{id}
id: v1ForeignAppEntity_DeleteForeignKeyOnName
---

# DEL ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{id}

```http
DELETE /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}/Key/{keyName}/{tableName}/{recordId}
```

Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified.

Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.




| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| keyName | string | The name of the foreign key to delete. **Required** |
| deviceIdentifier | string | The device identifier. Optional if device identifier is not used. **Required** |
| tableName | string | Table name, transformed to and from numeric table id by the service layer.&lt;p/&gt;Use an empty string to delete ALL keys that otherwise match; this may be dangerous and can take a long time if there are many items to delete. **Required** |
| recordId | int32 | Id of record that this key refers to. If the table name was blank, then this parameter must be 0. It can also be 0 to mean that the foreign key record was not bound to any particular record of the target table.&lt;p/&gt;Specifying a zero recordId will remove the recordId restriction and delete all keys that otherwise match. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |