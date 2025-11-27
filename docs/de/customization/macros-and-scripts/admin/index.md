---
uid: help-de-crmscript
title: CRMScript
description: CRMScript ist eine Funktion, mit der Sie Aufgaben in SuperOffice automatisieren oder das Verhalten ändern können.
keywords: CRMScript
author: digitaldiina
date: 11.26.2025
version: 11.6
content_type: concept
category: automation
topic: CRMScript
audience: settings
audience_tooltip: Settings and maintenance
redirect_from:
  - /de/automation/crmscript/learn/macro-script
  - /de/automation/crmscript/learn/screen/index
  - /de/automation/crmscript/learn/index
language: de
index: true
---

# CRMScript

CRMScript ist eine Funktion, mit der Sie Aufgaben in SuperOffice automatisieren oder das Verhalten ändern können. Automatisierte Aufgaben und Prozesse sparen Zeit, sodass Sie und Ihre Kollegen produktiver arbeiten können.

Die verschiedenen Tools, Makros und Skripte, Auslöser und geplante Aufgaben, haben unterschiedliche Fähigkeiten und werden für unterschiedliche Zwecke verwendet. Im Folgenden finden Sie eine Einführung in das flexible und leistungsstarke eingebettete Skripting-Tool - CRMScript.

## Zugriff auf CRMScript

Um auf die Funktionen in CRMScript zuzugreifen, öffnen Sie SuperOffice Einstellungen und Verwaltung und klicken Sie im Navigator auf <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript**.

Auslöser sind Skripts, die bei bestimmten Ereignissen im System ausgeführt werden, beispielsweise wenn ein neuer Verkauf erstellt oder eine Anfrage geschlossen wird. Auslöser können im Hintergrund auf das Geschehen reagieren oder den Vorgang blockieren und dem Benutzer eine Erklärung anzeigen.

## Über Makros

Makros sind die benutzerfreundliche Version von Skripts: Sie benötigen keine umfangreichen Kenntnisse über Skripterstellung oder CRMScript, um Makros zu erstellen.

Mit Makros können Sie Aktionen in SuperOffice anpassen und automatisieren. Zum Einrichten von Makros steht Ihnen ein benutzerfreundlicher Assistent zur Verfügung.

Makros haben in SuperOffice mehrere Funktionen. Sie können Makros mit bestimmten [Auslösern][2] im System (wie Eskalationen oder neuen Nachrichten auf Anfragen in SuperOffice) verknüpfen oder auch Schaltflächen in definierten Ansichten zuweisen, sodass Benutzer mit einem einfachen Klick auf eine Schaltfläche eine ganze Reihe häufig verwendeter Aktionen ausführen können. Dies sorgt für eine schnellere Anfragenverwaltung und Benutzer vermeiden unnötiges Klicken.

Beispiele für die Verwendung von Makros:

* Als Aufgabe/Funktion in einem Menüpunkt (z. B. in der **Aufgabe** in der Anzeige Anfrage)
* Wenn eine Anfrage über die Warnstufen für die Priorität eskaliert wird
* Als geplante Aufgabe
* Wenn sie durch einen E-Mail-Filter aktiviert werden
* Wenn ein Empfänger auf einen getrackten Link in einem Mailing klickt

### Was ist der Unterschied zwischen einem Skript und einem Makro?

Ein Makro ist eine Reihe vordefinierter Aktionen, die in einem bestimmten Ordner ausgeführt werden und für deren Einrichtung keine Programmierkenntnisse erforderlich sind.

Ein Skript ist ein kleines Programm, mit dem bestimmte Aufgaben durchgeführt werden. Zum Schreiben eines Skripts sind Programmierkenntnisse erforderlich.

## Registerkarten

* [Makros und Skripts][8] – Hier können Sie Makros und Skripts zur Automatisierung und zeitgesteuerten Ausführung von Aufgaben in SuperOffice erstellen.
* [Auslöser][2] – Hier können Sie definieren, dass ein bestimmtes Ereignis im System eine oder mehrere vordefinierte Aktionen auslösen soll.
* [Geplante Aufgaben][3] – Hier können Sie festlegen, dass ein Skript oder ein Makro zu bestimmten Zeiten ausgeführt werden soll.
* [Debugsitzungen][4] – Hier können Sie Fehler in Skripts und Makros ausfindig machen und beheben.
* [Ablaufverfolgung][5] – Hier können Sie die Ausführung eines Skripts oder Makros in allen Einzelheiten aufzeichnen und in einem Protokoll speichern.

## Registerkarte Makros und Skripte

Auf der Registerkarte **Makros und Skripte** auf **CRMScript** finden Sie eine Liste der Skripte und Makros im System, die in Ordnern gruppiert sind. Klicken Sie auf ein Skript oder Makro in der Liste, damit sie es anzeigen, bearbeiten oder ausführen können.

So wechseln Sie zur Registerkarte **Makros und Skripts**:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicken Sie auf **CRMScript** und wählen Sie die Registerkarte **Makros und Skripts** aus.

Die Registerkarte **Makros und Skripts** enthält die folgenden Schaltflächen: **Neues Skript**, **Neues Makro**, **Neuer Ordner** und **Suche**.

### Skript-Anzeige

Wenn Sie auf der Registerkarte **Makros und Skripts** auf ein Skript oder Makro klicken, wird die Ansicht **Skript** geöffnet. Zusätzlich zu den Informationen oben in der Ansicht finden Sie weitere Details zum Skript auf den Registerkarten **Beschreibung** und **Skript**.

**Optionen:**

| Schaltfläche | Beschreibung |
|---|---|
| Makros und Skripts | Wird verwendet, um zur Liste der Skripte und Makros zurückzukehren. |
| Skript bearbeiten | Wird verwendet, um das Skript oder Makro zu bearbeiten. |
| Skript ausführen | Wird verwendet, um das Skript oder Makro im Standardmodus auszuführen. |
| Skript debuggen | Wird verwendet, um die Ansicht **Debugger** zu öffnen und das ausgewählte Skript oder Makro im Debugmodus auszuführen. Das Skript stoppt in der ersten Zeile. Sie können eine [Sitzung debuggen][4] über die Registerkarte **Sitzungen debuggen** öffnen. |
| Skriptablauf verfolgen | Wird verwendet, um mit der [Ablaufverfolgung des Skripts oder Makros][5] zu starten. |

## Verwandte Inhalte

* [Ein Skript erstellen][8]
* [Ein Makro erstellen][9]
* [Ordner erstellen][10]
* [CRMScript-Sprache lernen][6]
* [CRMScript-API-Referenz][7]

<!-- Referenced links -->
[2]: trigger.md
[3]: schedule-task.md
[4]: ../../../../en/automation/crmscript/debugging/built-in-debugger.md
[5]: ../../../../en/automation/crmscript/debugging/using-trace.md
[6]: ../../../../en/automation/crmscript/overview/index.md
[7]: ../../../../en/automation/crmscript/reference/index.md
[8]: create-script.md
[9]: create-macro.md
[10]: create-script.md#folder
