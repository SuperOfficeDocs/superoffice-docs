---
uid: help-de-contact-merge
title: Personen zusammenführen
description: Lernen Sie, wie Sie doppelte Personen in SuperOffice CRM zusammenführen, um Aktivitäten, Verkäufe und Projektmitgliedschaften zu konsolidieren. Enthält eine Schritt-für-Schritt-Anleitung zur Verwendung des Dialogfelds Personen zusammenführen.
keywords: Personen zusammenführen, Personen verwalten, doppelte Einträge, Duplikat, ausgeschiedenen Mitarbeiter, Zusammenführen von Personen, Person
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Personen zusammenführen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Wenn dieselbe Person unter verschiedenen Namen oder Firmen in SuperOffice CRM erfasst wurde (z. B. "Jonathan Clark" und "Jonathon Clarke"), können Sie ihre Datensätze zusammenführen, um Aktivitäten, Verkäufe und Projektmitgliedschaften zu konsolidieren.

> [!NOTE]
> Sie können keine Personen (SuperOffice-Benutzer) in Ihrer eigenen Firma zusammenführen. Sie können jedoch eine Person aus einer anderen Firma mit einer Person in Ihrer eigenen Firma zusammenführen.

## Schritte

1. Öffnen Sie das Dialogfeld **Personen zusammenführen**:

    * In der **Ansicht Person**: Wechseln Sie zur gewünschten Person, klicken Sie auf <i class="ph ph-dots-three-circle-vertical" aria-label="Aufgabe-Schaltfläche"></i> und wählen Sie **Personen verwalten** > **Personen zusammenführen** aus dem Menü.

    * In der **Ansicht Firma**: Wechseln Sie zur Bereichsregisterkarte **Personen**, wählen Sie eine oder zwei Personen aus, klicken Sie mit der rechten Maustaste und wählen Sie **Personen verwalten** > **Personen zusammenführen**.

1. Falls Sie nur eine Person ausgewählt haben, wählen Sie unter **An** eine zweite Person aus. Beginnen Sie mit der Eingabe, um nach der Person zu suchen. Um die Personen unter **Von** und **An** zu tauschen, klicken Sie auf die Pfeil-Schaltfläche <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

1. Wählen Sie unter **Aktion an \[Firma\] nach dem Zusammenführen** eine der folgenden Optionen:

    * **\[Quellperson\] löschen:** Löscht die Quellperson nach dem Zusammenführen (nützlich bei doppelten Einträgen).
    * **Als ausgeschiedenen Mitarbeiter kennzeichnen:** Markiert die Quellperson als ausgeschiedenen Mitarbeiter (wenn die Person Jobs gewechselt hat).

1. Wählen Sie unter **Aktion für alle vorhandenen Aktivitäten und Verkäufe** eine der folgenden Optionen:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

1. Klicken Sie auf **Zusammenführen**. Folgendes passiert:

    * Alle Details werden zusammengeführt.
    * Aktivitäten und Verkäufe bleiben mit der Zielperson verknüpft oder werden je nach gewählter Option verschoben.
    * Zugehörigkeiten Projekt- und statische Selektionen folgen der Zielperson.
    * Die festgelegte Aktion (Löschen oder als ausgeschiedenen Mitarbeiter kennzeichnen) wird auf die Quellperson angewendet.

![Dialogfeld 'Personen zusammenführen' mit Optionen zur Handhabung doppelter Einträge und Auswahl von Nachbearbeitungsaktionen. -screenshot][img4]

## Verwandte Inhalte

* [Firmen zusammenführen][1]
* [Gelöschte Firmen und Personen wiederherstellen][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img4]: ../../../media/loc/en/contact/merge-contacts.png
