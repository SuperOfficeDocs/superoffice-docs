---
uid: help-de-add-company-category
title: Firmenkategorie und Kategoriengruppe
description: Erstellen oder aktualisieren Sie Firmenkategorien, weisen Sie Kategoriengruppen zu und aktivieren Sie die Lead-Status-Verfolgung.
keywords: Firmenkategorie, Kategoriengruppe, Lead-Status, potenzieller Kunde, Listen
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
index: true
language: de
---

# Firmenkategorie und Kategoriengruppe

[!include[Muss Administrator sein](../../learn/includes/req-admin.md)]

Die Liste **Firma – Kategorie** definiert die Typen von Firmen in Ihrer Datenbank, wie *Kunde*, *Partner* oder *Lead*.
Jede Kategorie kann zu einer **Kategoriengruppe** gehören, die bestimmt, wie sie sich in Suchen, Automatisierungen und Lead-Management verhält.

Sie verwalten Firmenkategorien unter **Einstellungen und Verwaltung** unter **Listen** > **Firma – Kategorie**.

## Über Kategoriengruppen

Kategoriengruppen bieten eine Möglichkeit, Kategorien nach Zweck zu klassifizieren und unerwünschte Automatisierungsänderungen zu verhindern. Zum Beispiel soll eine Firma, die als *Kunde* gekennzeichnet ist, niemals automatisch wieder zu einer *Lead* werden, nur weil ein Formular abgesendet wird.

| Kategoriengruppe | Beschreibung |
|---|---|
| Kunde | Wird verwendet für bestehende Kunden, wie *Kunde A*, *Kunde B* oder *VIP-Kunde*. |
| Verloren | Wird verwendet für ehemalige Kunden oder verlorene Chancen. |
| Partner | Wird verwendet für Wiederverkäufer, Integratoren oder Geschäftspartner. |
| Potenzieller Kunde | Wird verwendet für Leads oder Interessenten, die noch keine Kunden geworden sind. Nur diese Gruppe kann den **Lead-Status** aktiviert haben. |
| Andere | Wird verwendet für jede andere Art von Firma. |

## Hinzufügen einer Firmenkategorie

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie im Dropdown-Menü **Firma – Kategorie**. Der Tab **Elemente** zeigt alle bestehenden Kategorien an.

1. Klicken Sie **Hinzufügen**, um den Dialog **Listelement bearbeiten** zu öffnen.

1. Geben Sie im Feld **Name** einen Namen für die Kategorie ein. *(Pflichtfeld)*

    Dieser Name erscheint im Feld **Kategorie** auf der Firmen-Seite.

1. Wählen Sie im Dropdown-Menü **Kategoriengruppe** die passende Gruppe.

    Die Gruppe bestimmt, wie sich die Kategorie in Suchvorgängen und Automatisierungen verhält, ist jedoch für Endnutzer nicht sichtbar.

    * Um den Lead-Status später zu aktivieren, wählen Sie **Potenzieller Kunde**.

1. *(Optional)* Geben Sie eine Beschreibung ein, um zu erläutern, wie die Kategorie verwendet werden soll.

1. *(Optional)* Aktivieren Sie **Lead-Status für diese Kategorie aktivieren**, wenn anwendbar.

1. Klicken Sie **OK**, um die neue Kategorie zu speichern, oder **Abbrechen**, um Ihre Änderungen zu verwerfen.

![Bearbeiten einer Firmenkategorie in der Liste Firma – Kategorie, wobei die Gruppe Potenzieller Kunde ausgewählt ist und die Option zur Aktivierung des Lead-Status für die Kategorie angezeigt wird. -screenshot][img1]

## Bearbeiten oder löschen von Firmenkategorien

> [!NOTE]
> Die Bearbeitung oder Löschung von Kategorien, die verwendet werden, kann zu inkonsistenten Daten führen.
> Die Änderung einer Kategoriengruppe oder Deaktivierung des Lead-Status kann Firmen und Kontakte mit Lead-Informationen hinterlassen, die nicht mehr aktualisiert werden können.
> Überprüfen Sie die Nutzung der Kategorie sorgfältig, bevor Sie Änderungen vornehmen.

1. Öffnen Sie die Liste **Firma – Kategorie**.

1. Zum Bearbeiten:

    1. Doppelklicken Sie eine Kategorie, um sie zu öffnen.
    1. Aktualisieren Sie **Name**, **Kategoriengruppe** oder die Option **Lead-Status**.
    1. Klicken Sie **OK**, um zu speichern.

1. Zum Löschen:

    1. Wählen Sie die Kategorie in der Liste aus.
    1. Klicken Sie **Löschen**.

## Gelöschte Firmenkategorien wiederherstellen

1. Öffnen Sie die Liste **Firma – Kategorie**.

1. Wählen Sie **Gelöschte Elemente und Überschriften anzeigen**.

1. Suchen Sie die gelöschte Kategorie, doppelklicken Sie sie und klicken Sie **Wiederherstellen**.

1. Klicken Sie **OK**.

## Verwandte Inhalte

* [Kategorien für potenzielle Kunden][2]
* [Lead-Status für Firmenkategorien aktivieren][1]
* [Lead-Status verwalten][3]
* [Benutzergruppen-Filterung][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
