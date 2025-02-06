---
uid: help-de-screen-designer-tabs
title: Arbeiten mit Registerkarten
description: So fügen Sie eine Registerkarte in einem Layout hinzu, organisieren, löschen und wiederherstellen sie und organisieren die Informationen in logische Gruppen mithilfe des Ansichtsdesigners in Einstellungen und Verwaltung.
keywords: Ansichtsdesigner,Layout, Registerkarten-Layout, Überschrift, Bezeichnung, Trennlinie
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Arbeiten mit Registerkarten

[!include[Anforderung](../../../../../common/includes/req-dev-tools.md)]

Diese Anleitung geht davon aus, dass Sie bereits [das Layout bearbeiten][2]. Die folgenden Abschnitte erklären, wie Sie Registerkarten in SuperOffice CRM organisieren und anpassen, um die Benutzeroberfläche an die Bedürfnisse Ihrer Organisation anzupassen.

## Registerkarte hinzufügen

Das Erstellen benutzerdefinierter Registerkarten ermöglicht es Ihnen, verwandte Felder gruppiert anzuzeigen, sodass die Informationen für Ihre Organisation sinnvoll strukturiert sind. Sie können beispielsweise Registerkarten erstellen, die speziellen Geschäftsbereichen gewidmet sind, um Informationen leichter auffindbar zu machen.

**Schritte:**

1. Klicken Sie auf **Hinzufügen**. Der Abschnitt **Registerkarten-Layout** öffnet sich auf der linken Seite.

2. Ersetzen Sie unter **Registerkartetitel** den Text "Neue Registerkarte" durch den neuen Namen für die Registerkarte.

    Sie können auch <i class="ph ph-translate" aria-label="Translate"></i> klicken, um den Titel in anderen Sprachen hinzuzufügen.

3. Wählen Sie die Anzahl der Spalten, die Sie in der neue Registerkarte verwenden möchten.

## Registerkarte umbenennen

Wenn Sie die Registerkarte später umbenennen müssen, wählen Sie die Registerkarte aus und gehen Sie zum **Registerkarten-Layout**. **Die Standardregisterkarten lassen sich nicht umbenennen.**

## Registerkarte entfernen

Um der Ansicht zu optimieren, können Sie Registerkarten entfernen, die nicht mehr benötigt werden. Ein Layout muss jedoch mindestens eine Registerkarte enthalten. Wenn nur eine Registerkarte übrig bleibt, kann diese nicht entfernt werden.

> [!NOTE]
> Wenn die Registerkarte obligatorische Felder enthält, müssen Sie diese Felder auf eine andere Registerkarte verschieben, bevor Sie die aktuelle löschen.

**Schritte:**

1. Wählen Sie die Registerkarten aus.
1. Klicken Sie auf **Aufgabe** und wählen Sie **Registerkarte entfernen**.
1. Klicken Sie auf **OK**, um zu bestätigen und das Dialogfeld zu schließen.

## Registerkarte wiederherstellen

Wenn Sie eine Registerkarten entfernen und später feststellen, dass Sie ihn doch benötigen, können Sie ihn einfach wiederherstellen.

1. Öffnen Sie das Layout im Bearbeitungsmodus.
1. Klicken Sie auf **Aufgabe** und wählen Sie **Registerkarten wiederherstellen**.

> [!NOTE]
> Diese Aktion stellt **alle** zuvor entfernten Registerkarten wieder her.

## <a id="label"></a>Überschrift oder Trennlinie hinzufügen

Bezeichnungen und Trennlinien helfen dabei, Felder innerhalb einer Registerkarte zu organisieren und die Informationen übersichtlicher und leichter zugänglich zu machen. Verwenden Sie Bezeichnungen, um Überschriften zu erstellen, und Trennlinien, um Abschnitte innerhalb einer Spalte zu trennen.

1. Wählen Sie die Registerkarte aus, in dem Sie das Element hinzufügen möchten.
2. Klicken Sie auf den Abschnitt **Elemente**.
3. Um eine Überschrift hinzuzufügen, ziehen Sie das Element **Bezeichnung** in das Layout.

    * Ersetzen Sie im Abschnitt **Einstellungen** den Text "Neues Bezeichnung" durch den neuen Bezeichnungen-Namen. Optional können Sie auf <i class="ph ph-translate" aria-label="Translate"></i> neben der Beschriftung klicken, um den Registerkarten-Namen in anderen Sprachen hinzuzufügen.
    * Passen Sie die Schriftart bei Bedarf an.

4. Um eine horizontale Trennlinie hinzuzufügen, ziehen Sie das **Trennlinie**-Element in das Layout. Ändern Sie gegebenenfalls den Abstandhaltertyp.

![Ansichtsdesigner Felder und Elemente -screenshot][img2]

## <a id="columns"></a>Felder in Spalten gruppieren

Standardmäßig haben Registerkarten zwei Spalten, aber Sie können dies nach Bedarf anpassen. Jede Registerkarte kann 1, 2, 3 oder 4 Spalten haben, abhängig von der Menge an Informationen, die Sie anzeigen möchten.

> [!NOTE]
> Registerkarten mit spezifischen Funktionen, wie **ERP** und **Notiz**, unterstützen keine Spaltenanpassung. Gehen Sie zu **Einstellungen und Verwaltung** > **ERP**, um den Inhalt des ERP-Registerkarten zu konfigurieren.

**Schritte:**

1. Wählen Sie die Registerkarte aus, in dem Sie die Spalten anpassen möchten.
1. Gehen Sie zum Abschnitt **Registerkarten-Layout**.
1. Wählen Sie eine der vier Layout-Optionen.

Wenn die Anzahl der Spalten reduziert wird, werden die Felder aus den entfernten Spalten in die letzte verbleibende Spalte verschoben. Beispielsweise werden Felder aus der dritten Spalte in die untere Hälfte der zweiten Spalte verschoben, wenn Sie von drei auf zwei Spalten reduzieren.

Spalten werden vertikal gestapelt, wenn der Bildschirm zu klein ist, um sie horizontal anzuzeigen.

Wenn Sie einen breiten Bildschirm haben, können Sie mehr Spalten verwenden, um mehr Daten gleichzeitig anzuzeigen. Seien Sie jedoch vorsichtig: Die Verwendung von vier Spalten könnte die Sichtbarkeit einiger Felder verringern. Das Ausblenden von Bezeichnungen kann helfen, mehr Platz zu schaffen.

> [!TIP]
> Wenn eine Registerkarten zu überladen wird, sollten Sie zusätzliche Registerkarten hinzufügen, um die Informationen besser zu organisieren.

## <a id="more"></a>Der Mehr-Tab

Der **Mehr**-Tab enthält automatisch alle [benutzerdefinierten Felder][3], sortiert nach Rang. Sie können diese Felder in dieser Registerkarten konfigurieren und optional auch in anderen Ansichten hinzufügen.

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
[img2]: ../../../../media/loc/en/ui/field-settings.png
