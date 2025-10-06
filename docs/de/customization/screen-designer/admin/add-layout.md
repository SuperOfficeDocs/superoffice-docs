---
uid: help-de-screen-designer-add-layout
title: Layout hinzufügen
description: Wie man ein neues Layout für eine Benutzergruppe hinzufügt.
keywords: Ansichtsdesigner, Layout hinzufügen, Layout, Hauptkarte, Ansichtslayout
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from: /de/ui/screen-designer/learn/add-new-layout
---

# Layout hinzufügen

[!include[Anforderung](../../../includes/req-dev-tools.md)]

Egal, ob Sie eine personalisierte Ansicht für eine ausgewählte Benutzergruppe hinzufügen oder ein Layout optimieren, das für bestimmte Projekte, Verkäufe, Anfragen, Folgeaufgaben oder Dokumentvorlagen ausgelegt ist – beginnen Sie damit, ein neues Layout für einen Bildschirm im Ansichtsdesigner hinzuzufügen.

Mit benutzerdefinierten Ansichtslayouts für jedes Ihrer Teams wird das Auffinden von Kundendaten einfacher als je zuvor. Die relevantesten Daten sind immer verfügbar und sichtbar. Entfernen, verschieben oder verbergen Sie irrelevante oder weniger wichtige Daten, um die Ansichten zu entrümpeln. Fügen Sie benutzerdefinierte Archive mit den relevantesten Daten für Ihre Teams hinzu. Das Ergebnis ist eine übersichtlicherer und aufgeräumterer Ansicht, mit dem Ihre Teams arbeiten können.

Sehen Sie sich dieses Video an und erfahren Sie, wie Sie ein neues Layout hinzufügen, oder folgen Sie der Schritt-für-Schritt-Anleitung unten (das Video startet bei 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

## Neues Layout erstellen

1. Öffnen Sie den Ansichtsdesigner (in **Einstellungen und Verwaltung**).

1. Wählen Sie oben eine Ansicht oder einen Dialog aus, den Sie anpassen möchten.

1. Wählen Sie **Hauptkarten**.

    Um ein Layout für ein Archiv zu erstellen, siehe [Arbeiten mit Bereichsregisterkarten][2].

1. [Wählen Sie die Zuweisungsmethode][6] (falls nicht festgelegt): Klicken Sie auf den Text neben **Layouts zuweisen zu** und wählen Sie Gruppe, Typ, oder Dokumentvorlage.

1. Klicken Sie auf **Hinzufügen** unter **Layouts**.

    ![Klicken Sie auf Hinzufügen, um ein neues Layout zu erstellen -screenshot][img1]

1. Wählen Sie im Dialogfeld **Neues Layout hinzufügen** ein Layout aus der Liste **Neu erstellen auf Basis von** aus.

1. Geben Sie einen Namen und eine Beschreibung für das neue Layout ein.

    ![Geben Sie den richtigen Namen und die Benutzergruppen ein, die dieses Layout verwenden -screenshot][img2]

1. Klicken Sie auf das Feld **Zuweisen zu** und weisen Sie das neue Layout einer oder mehreren Benutzergruppen **oder** Verkaufs-/Projekt-/Anfrage-/Folgeaufgabentypen **oder** Dokumentvorlagen zu.

    > [!NOTE]
    > Es werden nur Gruppen/Typen/Vorlagen angezeigt, die derzeit das Standardlayout verwenden.

1. Klicken Sie auf **OK**.

    Das neue Layout wird zur Liste **Layouts** mit dem Status Entwurf hinzugefügt, was bedeutet, dass es für keine Benutzer sichtbar ist. Die Vorschau wird auf der rechten Seite der Ansicht angezeigt.

## Neues Ansichtslayout anpassen

1. Wählen Sie das neue Layout in der Liste **Layouts** aus und klicken Sie auf die Schaltfläche **Layout bearbeiten**.

2. Arbeiten Sie sich durch die Registerkarten im Layout.

    * [Ein Feld hinzufügen, bearbeiten, verschieben oder entfernen][1]
    * [Kobling oder Schaltfläche hinzufügen][5]
    * [Registerkarte hinzufügen, entfernen oder wiederherstellen][3]
    * [Bereichsregisterkarte (Archiv) hinzufügen oder entfernen][2]

3. Wenn Sie fertig sind, speichern oder veröffentlichen Sie das Layout.

## Verwandte Themen

* [Wie konfiguriere ich, auf welche Informationen die Benutzer unserer Firma in SuperOffice CRM zugreifen können?][15]
* [Wie erstelle ich eine neue Benutzergruppe in SuperOffice CRM?][16]
* [Layout löschen][4]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: working-with-archives.md
[3]: working-with-tabs.md
[4]: edit-layout.md#delete
[5]: add-button.md
[6]: assign-layout.md
[15]: ../../../admin/user-management/learn/role/index.md
[16]: ../../../admin/user-management/learn/user-groups.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/customization/add-new-screen-layout.png
