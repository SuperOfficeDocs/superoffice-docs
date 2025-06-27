---
uid: help-de-sale-stage-add
title: Verkaufsstufe hinzufügen
description: Erfahren Sie, wie Sie eine neue Verkaufsstufe in SuperOffice CRM hinzufügen. Definieren Sie Wahrscheinlichkeiten und verwalten Sie Stufen für unterschiedliche Verkaufstypen.
keywords: Verkaufsstufe hinzufügen, neue Verkaufsstufe, Verkauf - Stufe Liste, Verkaufsstufe, Stufe, Verkauf
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
content_type: howto
license: salesessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
---

# Verkaufsstufe

[!include[Must be admin](../../learn/includes/req-admin.md)]

Das Feld **Stufe** auf der Verkaufskarte zeigt die Phase eines Verkaufs an, z. B. "Offen", "Verkauft" oder "Verloren". Diese Stufen sind in der Liste **Verkauf - Stufe** vordefiniert, die Sie in Einstellungen und Verwaltung unter **Listen** verwalten können.

Stufen können mit [Verkaufstypen][1] verknüpft werden, sodass nur bestimmte Stufen für jeden Typ verfügbar sind. Falls kein Verkaufsleitfaden definiert ist, bleibt das Feld **Stufe** auf der Verkaufskarte sichtbar, sodass Benutzer die aktuelle Verkaufsstufe einsehen und aktualisieren können.

## Verkaufsstufe hinzufügen

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **Verkauf - Stufe** aus dem Dropdown-Menü. Die Registerkarte **Objekte** zeigt alle bestehenden Stufen an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.

1. Geben Sie im Feld **Name** den Namen der neuen Stufe ein. *(Pflichtfeld)*

    Dieser Name wird im Feld **Stufe** in der Verkaufsansicht angezeigt.

1. Geben Sie im Feld **Chance** die Wahrscheinlichkeit eines erfolgreichen Verkaufs in dieser Stufe als Prozentsatz an.

    Diese Angabe wird neben der Stufe in der Verkaufsansicht angezeigt.

1. *(Optional)* Fügen Sie im Feld **Beschreibung** eine Erklärung zur Stufe hinzu.

1. Klicken Sie auf **Speichern**, um die Änderungen zu übernehmen, oder auf **Abbrechen**, um sie zu verwerfen.

## Verkaufsstufe bearbeiten oder löschen

1. Folgen Sie den Schritten 1–2 in **Verkaufsstufe hinzufügen**, um die Liste **Verkauf - Stufe** zu öffnen.

1. Zum Bearbeiten:
   1. Doppelklicken Sie auf die gewünschte Stufe, um das Dialogfeld **Listenobjekt bearbeiten** zu öffnen.
   1. Aktualisieren Sie die Felder nach Bedarf und klicken Sie auf **Speichern**.

1. Zum Löschen:
   1. Wählen Sie die Stufe in der Liste aus und klicken Sie auf **Löschen**.

    > [!CAUTION]
    > Das Löschen einer Stufe entfernt sie aus allen verknüpften Verkaufstypen und Verkaufsleitfäden. Stellen Sie sicher, dass sie nicht aktiv verwendet wird, bevor Sie sie löschen.

## Gelöschte Verkaufsstufe wiederherstellen

Falls eine Verkaufsstufe gelöscht wurde, kann sie aus der Liste **Verkauf - Stufe** wiederhergestellt werden. Eine Wiederherstellung stellt jedoch nicht automatisch die Verknüpfungen mit Verkaufstypen oder Verkaufsleitfäden wieder her. Diese müssen manuell neu zugewiesen werden.

Die Schritte zur Wiederherstellung sind ähnlich wie bei [der Wiederherstellung eines gelöschten Verkaufstyps][2].

## Verwandte Inhalte

* [Verkaufstypen hinzufügen oder aktualisieren][1]
* [Verkaufsleitfaden erstellen][3]
* [Verkaufsleitfaden bearbeiten][4]
* [Zur nächsten Stufe wechseln][5]

<!-- Referenced links -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
