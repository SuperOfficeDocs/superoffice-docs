---
uid: help-de-company-merge
title: Firmen zusammenführen
description: Halten Sie Ihre Kundendatenbank sauber und effizient, indem Sie doppelte Firmen zusammenführen oder Einträge kombinieren, wenn eine Firma eine andere übernimmt.
keywords: Firmen zusammenführen, Firmen verwalten, identische Personen zusammenführen, Firma
author: Bergfrid Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Firmen zusammenführen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Halten Sie Ihre Kundendatenbank sauber und effizient, indem Sie doppelte Firmen zusammenführen oder Einträge kombinieren, wenn eine Firma eine andere übernimmt. Personen, Aktivitäten, Rechnungen, registrierte Domänen und andere Details werden verschoben oder zusammengeführt, und die Quellfirma wird gelöscht.

## Schritte

1. Klicken Sie auf die Schaltfläche **Aufgabe** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in der oberen rechten Ecke der Firmenkarte.
    Wählen Sie **Firmen verwalten** > **Firmen zusammenführen** aus dem Menü.
    Das Dialogfeld **Firmen zusammenführen** wird geöffnet, wobei die Quellfirma unter **Von** angezeigt wird.

2. Wählen Sie im Abschnitt **In Firma** die Ziel-Firma aus, in die Sie zusammenführen möchten. Um **Von** und **In** Firmen zu wechseln, klicken Sie auf die Pfeil-Schaltfläche <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

    > [!CAUTION]
    > Stellen Sie sicher, dass Sie die richtigen Firmen sowohl im Feld **Von** als auch im Feld **In** auswählen, bevor Sie fortfahren.

3. Wählen Sie unter **Personen- und Firmendetails** eine oder beide der folgenden Optionen aus:

    * **Identische Personen zusammenführen:** Personen mit exakt demselben Vor-, Mittel- (Zweite Vor-), und Nachnamen werden zusammengeführt.
    * **Leere Felder durch Werte aus der Quellfirma ersetzen:** Leere Felder in der Zielfirma werden mit Daten aus der Quellfirma aktualisiert.

4. Klicken Sie auf **Zusammenführen**. Folgendes geschieht:

    * Personen (und damit verbundene Anfragen) werden verschoben oder zusammengeführt.
    * Aktivitäten werden verschoben.
    * Projekt- und statische Selektionszugehörigkeiten folgen der Zielfirma.
    * Leere Felder werden aktualisiert, wenn Sie **Leere Felder ersetzen...** ausgewählt haben.
    * Die Quellfirma wird gelöscht.

![Dialogfeld Firmen zusammenführen mit Feldern zur Auswahl von Quell- und Zielfirma, Optionen zum Zusammenführen identischer Personen, Ersetzen leerer Felder und einer Zusammenfassung der durchzuführenden Aktionen -screenshot][img4]

> [!TIP]
> Sie können auch Firmen in dynamischen und statischen Selektionen zusammenführen.

## Verwandte Inhalte

* [Personen zusammenführen][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img4]: ../../../media/loc/en/company/merge-companies.png
