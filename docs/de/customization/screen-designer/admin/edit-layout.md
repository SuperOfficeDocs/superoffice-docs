---
uid: help-de-screen-designer-edit-layout
title: Hauptkartenlayout bearbeiten
description: In dieser Anleitung lernen Sie, wie Sie ein Layout bearbeiten können.
keywords: Ansichtsdesigner, Layout, Feld, Registerkarten-Layout
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
redirect_from:
  - /de/ui/screen-designer/learn/elements
  - /de/customization/screen-designer/edit-layout
---

# Hauptkartenlayout bearbeiten

[!include[Anforderung](../../../includes/req-dev-tools.md)]

Wenn Sie ein [neues Layout erstellt haben][6], müssen Sie es anzupassen. Personalisieren Sie das Layout für die Hauptkarten und Archive, um die Informationsbedürfnisse Ihrer Organisation zu erfüllen.

## Überlegungen

Bevor Sie ein Layout anpassen, sollten Sie festlegen, wer die vorgesehenen Benutzer sind.

* Was benötigen sie sofort zur Hand?
* Benötigen sie alle Standardfelder und Registerkarten oder sollten Sie etwas entfernen?
* Benötigen sie zusätzliche Registerkarten?
* Was ist die logische Reihenfolge der Felder?

> [!NOTE]
> Sie können das **Standardlayout** bearbeiten, jedoch nicht die Standardeinstellungen für Steuerelemente und Sie können das Layout nicht einer Benutzergruppe oder Typ neu zuweisen.

Sehen Sie sich dieses Video an, um herauszufinden, wie Sie mit dem Ansichtsdesigner Ihre Anzeigen in SuperOffice CRM konfigurieren, oder folgen Sie der Schritt-für-Schritt-Anleitung unten (Videolänge - 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## <a id="edit"></a>Kartenlayout bearbeiten

1. Öffnen Sie den Ansichtsdesigner.

1. Wählen Sie oben einen Bildschirm oder Dialog aus, den Sie anpassen möchten.

1. Wählen Sie in der Liste links ein Layout aus.

1. Klicken Sie unter der Vorschau auf **Layout bearbeiten**.

1. Im Bildschirm **Kartenlayout bearbeiten** arbeiten Sie sich durch die Registerkarten der Ansicht.

    * [Ein Feld hinzufügen, bearbeiten, verschieben oder entfernen][1]
    * [Link oder Schaltfläche hinzufügen][2]
    * [Informationen in logische Gruppen organisieren][4]
    * [Eine Registerkarte hinzufügen, entfernen oder wiederherstellen][3]
    * [Die Anzahl der Spalten in einer Registerkarte ändern][5]<a id="columns"></a>

![Entfernen, hinzufügen und verschieben Sie die verschiedenen Felder im Layout -screenshot][img3]

## <a id="save"></a>Speichern, veröffentlichen oder abbrechen

Nachdem Sie ein Layout bearbeitet haben, klicken Sie auf eine der folgenden Schaltflächen:

| Schaltfläche | Beschreibung |
|---|---|
| Entwurf speichern | Speichert eine unveröffentlichte Version des Layouts, die Sie später weiter bearbeiten oder von jemandem überprüfen lassen können. |
| Speichern + Veröffentlichen | Wendet das Layout auf die ausgewählten Benutzergruppen **oder** Verkaufs-/Projekt-/Anfrage-/Folgeaufgabentyp an. |
| Abbrechen | Verwirft alle Änderungen. |

## <a id="undo-changes"></a>Änderungen rückgängig machen

Wenn Sie zu einer früheren Version der Ansicht zurückkehren müssen, können Sie die folgenden Optionen im **Aufgaben**-Menü aufrufen:

* **Auf werkseitige Einstellung zurücksetzen**: Diese Option verwirft alle Änderungen und setzt das Layout auf die Standardversion von SuperOffice zurück.

* **Registerkarten wiederherstellen**: Diese Option stellt alle zuvor entfernten Registerkarten wieder her.

* **Entwurf verwerfen**: Diese Option verwirft alle ungespeicherten Änderungen und setzt das Layout auf die zuletzt veröffentlichte Version zurück.

## <a id="delete"></a>Layout löschen

Wenn ein benutzergruppenbasiertes Layout gelöscht wird, sehen die Benutzer in dieser Gruppe das Standardlayout (Systemlayout).

Um ein Layout zu löschen:

1. Wählen Sie das Layout in der **Layouts**-Liste aus.
1. Klicken Sie auf **Löschen**.

## Verwandte Themen

* [Arbeiten mit Bereichsregisterkarten (Archive)][7]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: add-button.md
[3]: working-with-tabs.md
[4]: working-with-tabs.md#label
[5]: working-with-tabs.md#columns
[6]: add-layout.md
[7]: working-with-archives.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/customization/edit-the-screen-layout-of-companies-and-contacts.png
