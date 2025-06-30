---
uid: help-de-automation-script-tracing
title: Ablaufverfolgung
description: Ablaufverfolgung
author: Bergfrid Dias
date: 12.20.2023
version: 10.2.11
keywords: CRMScript, Ablaufverfolgung, debug, verfolgen
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Ablaufverfolgung

Mit der Ablaufverfolgung können Sie die Ausführung eines Skripts oder Makros in allen Einzelheiten aufzeichnen und in einem Protokoll speichern. Die Ausführung wird jedes Mal aufgezeichnet, wenn das Skript oder Makro benutzt wird.

Sie können die Skriptausführung untersuchen, indem Sie in der Aufzeichnung vor- bzw. zurückspulen. Angezeigt wird eine vollständige Liste der Aufzeichnungen zur Skriptausführung mit der Angabe, von wem das Skript ausgeführt wurde. Sie erhalten Aufschluss über das Skriptverhalten und können alle Variablen zu jedem beliebigen Zeitpunkt sehen.

## Ablaufverfolgungen anzeigen

Die Registerkarte **Ablaufverfolgung** enthält eine Liste aller verfügbaren Ablaufverfolgungen. Klicken Sie in der Liste auf eine Ablaufverfolgung, um die Details anzuzeigen.

## Skript verfolgen

1. Führen Sie eine der folgenden Aktionen aus:

    * Öffnen Sie ein Skript oder Makro im **Debugger** und klicken Sie auf **Skript verfolgen**.
    * Öffnen Sie ein Skript oder Makro auf der Registerkarte **Makros und Skripte** und klicken Sie auf **Skript verfolgen**.

1. Geben Sie eine **Beschreibung** des Traces ein, um die Identifizierung zu erleichtern.
1. Optional, setzen Sie **Benutzerfilter** falls Sie eine benutzerspezifische Verfolgung wünschen.
1. Optional, geben Sie Benachrichtigungs- und Speichereigenschaften an. Siehe [Liste der Felder](#fields) unten.
1. Wählen Sie **Aktiviert**, um die Verfolgung zu aktivieren.
1. Klicken Sie **OK**, wenn Sie fertig sind.

## Alle aktivierte Ablaufverfolgung ein-/ausschalten

1. Gehen Sie zu **CRMScript** > **Sitzungen debuggen**.
2. Klicken Sie auf **Ablaufverfolgungsskripte starten**, um die Skripte in der Liste zu verfolgen.
    Klicken Sie auf **Ablaufverfolgungsskripte stoppen**, um die Verfolgung zu pausieren.

## Ablaufverfolgung bearbeiten

1. Klicken Sie in der Liste auf eine Ablaufverfolgung, um sie zu öffnen.
2. Klicken Sie auf **Ablaufverfolgung bearbeiten**.
3. Aktualisieren Sie die Felder wie benötigt.
4. Klicken Sie **OK**, wenn Sie fertig sind.

![CRMScript verfolgen -screenshot][img4]

### <a id="fields"></a>Feld

| Feld | Beschreibung |
|---|---|
| Beschreibung | Eine Erklärung der Ablaufverfolgung, um die Identifizierung zu erleichtern. |
| Benutzerfilter | Beschränkt die Verfolgung auf einen bestimmten Benutzer. |
| Auflösung der Ablaufverfolgung | Die Erfassungshäufigkeit für das Ablaufverfolgungsprotokoll. 1 - Speichern bei jeder Ausführung des Skripts; 5 - Speichern bei jeder fünften Ausführung; und so weiter. |
| Ablaufverfolgungen speichern | Wie lange eine Ablaufverfolgung aufbewahrt werden soll, bevor die gelöscht wird. |
| Aktiviert | Aktiviert die Ablaufverfolgung. |
| Benachrichtigen | Ob Benachrichtigungs-E-Mails gesendet werden sollen. |
| Maximale Anzahl der Benachrichtigungen | Begrenzt die Anzahl der gesendeten E-Mails. |
| Benachrichtigungs-E-Mail | Wo die Benachrichtigungen gesendet werden sollen. |
| Nur speichern, wenn es eine unbehandelte Ausnahme gibt | Beschränkt die Verfolgung auf Ausnahmen. |

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/automation/trace.png
