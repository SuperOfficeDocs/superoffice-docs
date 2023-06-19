---
uid: help-de-automation-script-tracing
title: Ablaufverfolgung
description: Ablaufverfolgung
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript, Ablaufverfolgung, Debug
so.topic: howto
so.user: admin
language: de
---

# Ablaufverfolgung

Mit der Ablaufverfolgung können Sie die Ausführung eines Skripts oder Makros in allen Einzelheiten aufzeichnen und in einem Protokoll speichern. Die Ausführung wird jedes Mal aufgezeichnet, wenn das Skript oder Makro benutzt wird.

Sie können die Skriptausführung untersuchen, indem Sie in der Aufzeichnung vor- bzw. zurückspulen. Angezeigt wird eine vollständige Liste der Aufzeichnungen zur Skriptausführung mit der Angabe, von wem das Skript ausgeführt wurde. Sie erhalten Aufschluss über das Skriptverhalten und können alle Variablen zu jedem beliebigen Zeitpunkt sehen.

## Ablaufverfolgungen anzeigen

Die Registerkarte **Ablaufverfolgung** enthält eine Liste aller verfügbaren Ablaufverfolgungen. Klicken Sie in der Liste auf eine Ablaufverfolgung, um die Details anzuzeigen.

## Ablaufverfolgungen starten

* Wechseln Sie zu **CRMScript** &gt; **Sitzungen debuggen**, und klicken Sie auf das ![Symbol][img1] **Ablaufverfolgungsskripte starten**, um die Ablaufverfolgung der Skripts in der Liste zu starten.
* Öffnen Sie ein Skript oder Makro im **Debugger** und klicken Sie auf ![Symbol][img2] **Skript verfolgen**.
* Öffnen Sie ein Skript oder Makro auf der Registerkarte **Makros und Skripte** und klicken Sie auf ![Symbol][img2] **Skript verfolgen**.

## Ablaufverfolgungen bearbeiten

1. Klicken Sie in der Liste **Ablaufverfolgung** auf eine Ablaufverfolgung, um sie zu öffnen.

2. Klicken Sie auf das ![Symbol][img3] **Ablaufverfolgung bearbeiten**. Daraufhin wird die Ansicht **Ablaufverfolgung bearbeiten** angezeigt.

3. Füllen Sie die folgenden Felder aus:

    * **Beschreibung**: Geben Sie eine Beschreibung für die Ablaufverfolgung ein, sodass diese leichter zu identifizieren ist.
    * **Benutzerfilter**: Um das Skript für einen bestimmten Benutzer zu verfolgen, wählen Sie den Benutzer aus der Liste aus.
    * **Auflösung der Ablaufverfolgung**: Geben Sie die Erfassungshäufigkeit für das Ablaufverfolgungsprotokoll ein.
        Beispiel: Geben Sie 1 ein, damit jeder vom Skript ausgeführte Befehl protokolliert wird. Geben Sie 5 ein, damit jeder 5\. vom Skript ausgeführte Befehl protokolliert wird.
    * **Ablaufverfolgungen speichern**: Wählen Sie aus, wie lange die Ablaufprotokolle aufbewahrt werden sollen.
    * **Aktiviert**: Wählen Sie diese Option, wenn Sie die Ablaufverfolgung aktivieren wollen.

4. Klicken Sie, sobald Sie fertig sind, auf **OK**.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img2]: ../../../../media/icons/btn-script-trace-small.png
[img3]: ../../../../media/icons/edit.png
