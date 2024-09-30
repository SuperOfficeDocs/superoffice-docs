---
uid: help-de-screen-designer-tabs
title: Arbeiten mit Tabs
description: How to add, organize, delete, and restore a tab in a layout and how to organize its information into logical groups using the Screen Designer in Settings and maintenance.
keywords: ui, screen, customization, tab layout, heading, label, divider
author: Bergfrid Dias
date: 09.30.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Arbeiten mit Tabs

[!include[Anforderung](../../../../../common/includes/req-dev-tools.md)]

Diese Anleitung geht davon aus, dass Sie bereits [das Layout bearbeiten][2]. Die folgenden Abschnitte erklären, wie Sie Tabs in SuperOffice CRM organisieren und anpassen, um die Benutzeroberfläche an die Bedürfnisse Ihrer Organisation anzupassen.

## Tab hinzufügen

Das Erstellen benutzerdefinierter Tabs ermöglicht es Ihnen, verwandte Felder gruppiert anzuzeigen, sodass die Informationen für Ihre Organisation sinnvoll strukturiert sind. Sie können beispielsweise Tabs erstellen, die speziellen Geschäftsbereichen gewidmet sind, um Informationen leichter auffindbar zu machen.

**Schritte:**

1. Klicken Sie auf **Hinzufügen**. Der Abschnitt **Tab-Layout** öffnet sich auf der linken Seite.

2. Ersetzen Sie unter Tab-Titel den Text „Neuer Tab“ durch den neuen Tab-Namen.

    Sie können auch auf ![icon][img1] klicken, um [den Tab-Namen in anderen Sprachen hinzuzufügen][3].

3. Wählen Sie die Anzahl der Spalten, die Sie im neuen Tab verwenden möchten.

## Tab umbenennen

Wenn Sie den Tab später umbenennen müssen, wählen Sie den Tab aus und gehen Sie zum **Tab-Layout**. Sie **können keine der Standard-Tabs umbenennen**.

## Tab entfernen

Um die Benutzeroberfläche zu optimieren, können Sie Tabs entfernen, die nicht mehr benötigt werden. Ein Layout muss jedoch mindestens einen Tab enthalten. Wenn nur ein Tab übrig bleibt, kann dieser nicht entfernt werden.

> [!NOTE]
> Wenn der Tab Pflichtfelder enthält, müssen Sie diese Felder auf einen anderen Tab verschieben, bevor Sie den aktuellen löschen.

**Schritte:**

1. Wählen Sie den Tab aus.
1. Klicken Sie auf **Aufgabe** und wählen Sie **Tab entfernen**.
1. Klicken Sie auf **OK**, um zu bestätigen und das Dialogfeld zu schließen.

## Tab wiederherstellen

Wenn Sie einen Tab entfernen und später feststellen, dass Sie ihn doch benötigen, können Sie ihn einfach wiederherstellen.

1. Öffnen Sie das Layout im Bearbeitungsmodus.
1. Klicken Sie auf **Aufgabe** und wählen Sie **Tabs wiederherstellen**.

> [!NOTE]
> Diese Aktion stellt **alle** zuvor entfernten Tabs wieder her.

## <a id="label"></a>Überschrift oder Trennlinie hinzufügen

Bezeichnungen und Trennlinien helfen dabei, Felder innerhalb einer Registerkarte zu organisieren und die Informationen übersichtlicher und leichter zugänglich zu machen. Verwenden Sie Bezeichnungen, um Überschriften zu erstellen, und Trennlinien, um Abschnitte innerhalb einer Spalte zu trennen.

1. Wählen Sie die Registerkarte aus, in dem Sie das Element hinzufügen möchten.
2. Klicken Sie auf den Abschnitt **Elemente**.
3. Um eine Überschrift hinzuzufügen, ziehen Sie das Element **Bezeichnung** in das Layout.

    * Ersetzen Sie im Abschnitt **Einstellungen** den Text "Neues Bezeichnung" durch den neuen Bezeichnungen-Namen. Optional können Sie auf die **A-Z**-Schaltfläche neben der Beschriftung klicken, um den Tab-Namen in anderen Sprachen hinzuzufügen.
    * Passen Sie die Schriftart bei Bedarf an.

4. Um eine horizontale Trennlinie hinzuzufügen, ziehen Sie das **Trennlinie**-Element in das Layout. Ändern Sie gegebenenfalls den Abstandhaltertyp.

![Ansichtsdesigner Felder und Elemente -screenshot][img2]

## <a id="columns"></a>Felder in Spalten gruppieren

Standardmäßig haben Tabs zwei Spalten, aber Sie können dies nach Bedarf anpassen. Jeder Tab kann 1, 2, 3 oder 4 Spalten haben, abhängig von der Menge an Informationen, die Sie anzeigen möchten.

> [!NOTE]
> Tabs mit spezifischen Funktionen, wie **ERP** und **Notiz**, unterstützen keine Spaltenanpassung. Gehen Sie zu **Einstellungen und Wartung** > **ERP**, um den Inhalt des ERP-Tabs zu konfigurieren.

**Schritte:**

1. Wählen Sie den Tab aus, in dem Sie die Spalten anpassen möchten.
1. Gehen Sie zum Abschnitt **Tab-Layout**.
1. Wählen Sie eine der vier Layout-Optionen.

Wenn die Anzahl der Spalten reduziert wird, werden die Felder aus den entfernten Spalten in die letzte verbleibende Spalte verschoben. Beispielsweise werden Felder aus der dritten Spalte in die untere Hälfte der zweiten Spalte verschoben, wenn Sie von drei auf zwei Spalten reduzieren.

Spalten werden vertikal gestapelt, wenn der Bildschirm zu klein ist, um sie horizontal anzuzeigen.

Wenn Sie einen breiten Bildschirm haben, können Sie mehr Spalten verwenden, um mehr Daten gleichzeitig anzuzeigen. Seien Sie jedoch vorsichtig: Die Verwendung von vier Spalten könnte die Sichtbarkeit einiger Felder verringern. Das Ausblenden von Feldlabels kann helfen, mehr Platz zu schaffen.

> [!TIP]
> Wenn ein Tab zu überladen wird, sollten Sie zusätzliche Tabs hinzufügen, um die Informationen besser zu organisieren.

## <a id="more"></a>Der Mehr-Tab

Der **Mehr**-Tab enthält automatisch alle [benutzerdefinierten Felder][3], sortiert nach Rang. Sie können diese Felder in diesem Tab konfigurieren und optional auch in anderen Ansichten hinzufügen.

[Benutzerdefinierte Felder][5] (udef) und [zusätzliche Felder][4] werden wie zuvor erstellt.

## Verwandte Themen

* [Arbeiten mit Feldern][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../media/loc/en/ui/field-settings.png
