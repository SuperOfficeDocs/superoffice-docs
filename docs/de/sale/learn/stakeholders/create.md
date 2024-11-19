---
uid: help-de-stakeholder-create
title: Beteiligte hinzufügen
description: Wie man einen Verkauf mit einem Beteiligten (Firma oder Person) in SuperOffice verknüpft.
keywords: Verkauf, Beteiligt, Interessent
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Beteiligte hinzufügen

Beim Hinzufügen von Beteiligte zu einem Verkauf können Sie entweder Rollen einzeln zuweisen, wenn Sie Firmen/Personen hinzufügen, die Rollen nach dem Hinzufügen aller Beteiligte zuweisen oder eine Kombination beider Methoden verwenden.

Eine Firma/Person kann mehrfach als Interessent hinzugefügt werden, vorausgesetzt, es werden jeweils unterschiedliche Rollen festgelegt.

## Schritte

1. Öffnen Sie den Verkauf (siehe [Suchansicht verwenden][1]) und gehen Sie zur Bereichsregisterkarte **Beteiligte**.

1. Klicken Sie auf **Hinzufügen** unter der Bereichsregisterkarte. Der Dialog **Beteiligte hinzufügen/bearbeiten** öffnet sich.

1. Klicken Sie auf die **Firma/Person**-Liste, um Beteiligte hinzuzufügen. Sie haben folgende Möglichkeiten:

    * **Suchen**: Geben Sie mindestens zwei Zeichen ein, um nach einer Person oder einer Firma zu suchen.

    * **Verlauf/Favoriten**: Wählen Sie aus der Verlaufsliste oder Favoriten.

      ![Dialog Beteiligte hinzufügen/bearbeiten, Verlauf -screenshot][img5]

    * **Benutzergruppe**: Klicken Sie auf ![Icon][img2], um Mitarbeiter nach Gruppe zu durchsuchen.

      ![Dialog Beteiligte hinzufügen/bearbeiten, Gruppe -screenshot][img6]

    * **Firma**: Klicken Sie auf ![Icon][img3], um Personen nach Firma zu durchsuchen oder eine Firma als Interessent hinzuzufügen.

      ![Dialog Beteiligte hinzufügen/bearbeiten, Firma -screenshot][img7]

1. **Rollen zuweisen**: Wählen Sie einen Beteiligte aus und weisen Sie eine Rolle zu. Um dieselbe Rolle mehreren Beteiligte gleichzeitig zuzuweisen, verwenden Sie **Alle auswählen** oder halten Sie **Strg/Shift** gedrückt, während Sie auswählen.

    ![Dialog Beteiligte hinzufügen/bearbeiten, Rolle -screenshot][img8]

    Optional: Fügen Sie einen Kommentar hinzu, um die Rolle des Beteiligte genauer zu beschreiben.

1. Klicken Sie auf **Speichern**.

## Fehlerbehebung

* **Fehlende Bereichsregisterkarte**: Wenn die Bereichsregisterkarte Beteiligte nicht sichtbar ist, stellen Sie sicher, dass diese [Vertriebstyp][4] in den Einstellungen und Verwaltung aktiviert ist.

* **Fehlende Person**: Wenn ein Interessent nicht aufgeführt ist, müssen Sie zuerst [die Person erstellen][3].

* **Fehlende Rollen**: [Rollen][5] werden in den Einstellungen und Verwaltung definiert.

## Tipps

* **Beteiligte über Firmen- oder Auswahlbildschirme hinzufügen**

    Sie können auch [Beteiligte über die Bereichsregisterkarte][2] hinzufügen, die Personen in den Ansichten Firma und Selektion enthalten.

* **Kommentare hinzufügen**

    Wenn ein Kommentar hinzugefügt wird, erscheint ein ![Icon][img1] Büroklammer-Symbol neben der Spalte **Verkaufsrolle** in der **Beteiligte**-Bereichsregisterkarte. Bewegen Sie den Mauszeiger über die Büroklammer, um das Tooltip mit dem Kommentar anzuzeigen.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: ../../../project/learn/project-members/add.md
[3]: ../../../contact/learn/create.md
[4]: ../../../admin/lists/learn/sale-type.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/binders.png
[img2]: ../../../../../common/icons/associate-group.png
[img3]: ../../../../../common/icons/singlecolour/contact.png
[img5]: ../../../../media/loc/en/sale/add-stakeholders-from-history.png
[img6]: ../../../../media/loc/en/sale/add-stakeholders-from-group.png
[img7]: ../../../../media/loc/en/sale/add-stakeholders-from-company.png
[img8]: ../../../../media/loc/en/sale/set-stakeholder-role.png
