---
uid: help-de-automation-script-create
title: Skript erstellen oder bearbeiten
description: Ein Skript erstellen
keywords: Skript, Makro
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: howto
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /de/automation/crmscript/learn/create-folder
  - /de/automation/crmscript/learn/create-script
language: de
index: true
---

# Skript erstellen oder bearbeiten

## Steps

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Wählen Sie **CRMScript** aus, und führen Sie einen der folgenden Schritte aus:
    * So erstellen Sie ein neues Makro: Klicken Sie auf **Neues Makro**.
    * So bearbeiten Sie ein vorhandenes Makro: Klicken Sie auf den Namen des Makros.

1. In der Registerkarte **Informationen** bearbeiten oder geben Sie Daten über das Skript ein:

    * **Ordner**: Wählen Sie den Ordner aus, in dem Sie das Skript speichern möchten.
    * **Name**
    * **Beschreibung**
    * **Include-Name**: Ein eindeutiger Name für das Skript, der verwendet wird, um dieses Skript in ein anderes Skript einzuschließen.
    * **Schlüssel**: Der Schlüssel wird mit der Funktion "action=parse" auf den Kundenseiten verwendet, damit Sie Skripte ausführen und skriptbasierte Funktionen im SuperOffice Kundenzentrum einrichten können. Er verhindert, dass auf den Kundenseiten die falschen Skripts ausgeführt werden.
    * **Ergebnisse des ausgeführten Skripts in HTML anzeigen**

1. In der Registerkarte **Skript** können Sie das Skript selbst eingeben.

1. (optional) Klicken Sie auf **Bereitstellen**, um das Skript bereitzustellen. Dies ermöglicht es Ihnen, die Änderungen selbst zu testen.

1. (optional) Klicken Sie auf **Skript ausführen**, um das Skript auszuführen. Das Ergebnis wird in der Registerkarte **Ergebnis** angezeigt.

1. Klicken Sie auf **OK**.

## <a id="folder"></a>Eigenschaften des Makro-/Skriptordners

Skript- und Makroordner werden zum Organisieren von benutzerdefinierten Skripts und Makros verwendet.

### Ordner erstellen

1. Klicken Sie auf **Neuer Ordner** oben in der Anzeige.
2. Wählen Sie im Feld **Ordner** einen übergeordneten Ordner in der Liste aus.
3. Geben Sie einen aussagekräftigen Namen für den Ordner in das Feld **Name** ein.
4. Klicken Sie auf **OK**. Der neue Ordner wird erstellt.

### Ordner bearbeiten

Sie können sowohl den Namen eines Ordners als auch die bei der Erstellung eingegebenen Details bearbeiten.

1. Wechseln Sie zum gewünschten Ordner.
2. Klicken Sie auf den Namen des Ordners.
3. Verbessern Sie die Felder.
4. Klicken Sie auf **OK**. Die Änderungen werden gespeichert.

### Ordner löschen

Wenn Sie einen Ordner löschen, wird der gesamte Inhalt (wie Selektionen, FAQ-Einträge, Antwortvorlagen, Tabellen, Skripts und Makros) ebenfalls aus SuperOffice entfernt.

1. Wechseln Sie zum gewünschten Ordner.
2. Klicken Sie auf den Namen des Ordners.
3. Klicken Sie auf **Löschen**.
4. Klicken Sie zur Bestätigung auf **OK**. Der Ordner wird mit seinem Inhalt aus SuperOffice entfernt.

## Verwandte Inhalte

* [Über CRMScript][1]
* [Skripts debuggen][2]
* [Skripts verfolgen][3]

<!-- Referenced links -->
[1]: ../../../../en/automation/crmscript/index.yml
[2]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[3]: ../../../../en/automation/crmscript/debugging/using-trace.md

<!-- Referenced images -->
