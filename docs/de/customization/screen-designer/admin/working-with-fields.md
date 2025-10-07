---
uid: help-de-screen-designer-fields
title: Arbeiten mit Feldern
description: So fügen Sie Felder in einem Layout mit dem Ansichtsdesigner in Einstellungen und Verwaltung hinzu, verschieben und löschen sie.
keywords: Feld hinzufügen, neues Feld, Feld verschieben, Feld entfernen, Feld ausblenden, Layout bearbeiten, Feldeinstellungen
author: Bergfrid Dias
date: 10.09.2025
version: 10
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: de
index: true
redirect_from: /de/customization/screen-designer/working-with-fields
---

# Arbeiten mit Feldern

[!include[Anforderung](../../../includes/req-dev-tools.md)]

Beschriftungen und Felder repräsentieren die wesentlichen Inhalte einer Ansicht. Ob Sie ein neues Layout erstellen oder ein bestehendes ändern, beginnen Sie, indem Sie auf **Layout bearbeiten** klicken. [Zeigen Sie mir die detaillierten Schritte.][1] Wenn Sie fertig sind, **speichern oder veröffentlichen** Sie das Layout.

> [!TIP]
> Möglicherweise möchten Sie [Registerkarten hinzufügen oder entfernen][2], bevor Sie die Felder optimieren.

![Ansichtsdesigner, Firmenkarte, Standard-Feldlayout -screenshot][img1]

Die Liste der Felder auf einem Bildschirm enthält alle Standardfelder von SuperOffice für diesen Bereich sowie alle benutzerdefinierten Felder (sowohl benutzerdefinierte als auch zusätzliche).

## <a id="add"></a>Feld hinzufügen

Jedes Feld kann an mehreren Stellen erscheinen, wenn es relevant ist.

1. Wählen Sie die Registerkarten aus, in den Sie das Feld einfügen möchten.

1. Stellen Sie sicher, dass der Abschnitt **Felder** ausgewählt ist.

1. Suchen Sie das gewünschte Feld in der **Felder**-Liste.

    > [!TIP]
    > Verwenden Sie die Filterfunktion, um bestimmte Felder zu finden.

1. Ziehen Sie das Feld aus der Liste in einen gestrichelten Bereich des ausgewählten Registerkarten.

    ![Kästchen mit gestrichelten Linien -screenshot][img6]

    Um ein Feld auf allen Registerkarten sichtbar zu machen, platzieren Sie das Feld in der Kopf- oder Fußzeile der Hauptkarte.

## <a id="settings"></a>Feld-Einstellungen bearbeiten

Bearbeiten Sie die Feldformatierung (z. B. Schriftgröße), um die Sichtbarkeit zu verbessern.

1. Wählen Sie die Registerkarten aus, der das Feld enthält.

1. Klicken Sie auf das Feld in der Vorschau.

1. Bearbeiten Sie im Abschnitt **Einstellungen** die Feldformatierung. Die verfügbaren Einstellungen hängen vom ausgewählten Feldtyp ab.

    * Wählen Sie **Fett** oder *Kursiv*, um den Schriftstil zu ändern
    * Wechseln Sie zwischen links- und rechtsbündigen Werten
    * Wählen Sie zwischen kleiner, normaler und großer Schrift

Beispielhafte Formatierungen finden Sie im Screenshot im Abschnitt über das [Hinzufügen einer Überschrift oder Trennlinie][3].

## <a id="move"></a>Feld verschieben

Fügen Sie wichtige benutzerdefinierte Felder zur Hauptkarte (der linken Registerkarte) hinzu, um einfachen Zugriff zu gewährleisten. Verschieben Sie weniger wichtige Felder auf sekundäre Registerkarten, anstatt sie zu entfernen.

**Schritte:**

1. Wählen Sie die Registerkarte aus, die das Feld enthält.

1. Klicken Sie auf **=** links neben dem Feldlabel und ziehen Sie das Feld an eine neue Position.

    > [!TIP]
    > Um ein Feld zu einer andere Registerkarte zu verschieben, ziehen Sie es auf die neue Registerkarte, warten Sie, bis die Vorschau aktualisiert wird, und legen Sie das Feld dann in einen gestrichelten Bereich der neue Registerkarte ab.

## <a id="delete"></a>Feld löschen (verbergen)

Um Unordnung zu reduzieren, blenden Sie Felder aus, die nie verwendet werden. Entfernte Felder wirken sich nur auf das aus, was in der Benutzeroberfläche angezeigt wird, und ändern die Datenbank oder Tabellenwerte in keiner Weise.

* Um ein Feld zu entfernen, bewegen Sie den Mauszeiger über ein Feld und klicken Sie auf das rote, eingekreiste X.

* Um das Feld wiederherzustellen, [fügen Sie das Feld einfach wieder hinzu](#add).

> [!NOTE]
> Obligatorische Felder können nicht gelöscht werden. Sie können jedoch ein obligatorisches Feld in eine andere Registerkarten verschieben.

## Verwandte Themen

* [Spaltenanzahl in einer Registerkarte ändern][4]
* [Bezeichnungen und Trennelemente hinzufügen][3]
* [Links und Schaltflächen hinzufügen][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label
[4]: working-with-tabs.md#columns
[5]: add-button.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/customization/screendesigner-field-place.png
