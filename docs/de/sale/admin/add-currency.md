---
uid: help-de-currency-add
title: Währung
description: Objekte zur Liste Währung hinzufügen
keywords: Währung, Liste Allgemein – Währung
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: sale
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /de/admin/lists/learn/adding-items-to-currency-list
  - /de/admin/lists/learn/currency
language: de
---

# Währung

In der Ansicht Verkauf in SuperOffice CRM werden der Verkaufsbetrag, die Kosten und der Ertrag für den Verkauf angegeben. Die Währung, in der die Beträge angezeigt werden, hängt von Ihrer Angabe in [Einstellungen][2] ab, wo Sie Ihre eigene Währung und eine Basiswährung aus einer Liste in der Ansicht Listen auswählen können.

## Währung hinzufügen

1. Wählen Sie <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listen** im Navigator.

1. Wählen Sie **Allgemein – Währung** aus dem Dropdown-Menü. Die Registerkarte **Objekte** zeigt alle vorhandenen Währungen an.

1. Klicken Sie auf **Hinzufügen**, um das Dialogfeld **Listenobjekte bearbeiten** zu öffnen.

1. Geben Sie den gewünschten Namen im Feld **Name** ein. *(Pflichtfeld)*

1. Geben Sie den Wechselkurs für die betreffende Währung in das Feld **Kurs** ein.

    > [!NOTE]
    > Dies ist der Kurs im Verhältnis zur Basiswährung. Die Basiswährung ist die Währung, in welcher der Kurs auf 1 festgelegt ist. Wenn die Basiswährung EUR ist, wird der Kurs für die anderen Währungen im Verhältnis zu dieser Währung entsprechend der angegebenen Einheit berechnet (siehe den folgenden Punkt). 1 GBP entspricht zum Beispiel laut Tageskurs 1,562 EUR und 100 NOK entsprechen 12,677 EUR. Diese Berechnung wird angezeigt, nachdem Sie den Wechselkurs und die Einheit angegeben haben.

1. Geben Sie die Einheit, die im Verhältnis zur Basiswährung verwendet werden soll, in das Feld **Einheit** ein. Die Standardeinheit könnte zum Beispiel 100 für die norwegische Krone und 1 für das Britische Pfund sein.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für die Währung ein.

1. Klicken Sie auf **Speichern**. Die Währung wird als separates Objekt zur Liste **Objekte** hinzugefügt. Wiederholen Sie diesen Vorgang, wenn Sie weitere Währungen hinzufügen möchten.

## Standardwährung ändern

Um die Standardwährung zu ändern, öffnen Sie die Ansicht **Einstellungen** und gehen Sie zu Registerkarte **Globale Einstellungen** > **System** > **Basiswährung**.

## Verwendung von Währungen aktivieren

Um Verkäufe in einer anderen Währung erfassen zu können, öffnen Sie die Ansicht **Einstellungen** und gehen Sie zu Registerkarte **Einstellungen** > **System** > **Unterschiedliche Währungen zulassen**.

<!-- Referenced links -->
[2]: ../../admin/preferences/index.md
