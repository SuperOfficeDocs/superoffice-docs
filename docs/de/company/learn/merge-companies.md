---
uid: help-de-company-merge
title: Firmen zusammenführen
description: "Um mit Kunden und Personen effizient arbeiten zu können, ist es wichtig, eine aufgeräumte Umgebung zu haben. Das bedeutet, dass Sie unbenutzte Firmen und Personen löschen und doppelte Firmen und Personen zusammenführen."
keywords: Firma
author: SuperOffice
date: 08.27.2024
version: 10.3.8
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Firmen zusammenführen

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Sie können Duplikate der Datenbankeinträge von Firmen zusammenführen. Dabei werden die Personen und Aktivitäten in die Zielfirma verschoben und die Quellfirma wird gelöscht.

Wenn zwei Firmen in Ihrer Kundendatenbank fusioniert wurden oder eine Firma von einer anderen gekauft wurde, können Sie diese zu einer Firma zusammenführen. Personen (und damit verbundene Anfragen), Rechnungen und erfasste Domäne bleiben für beide Firmen erhalten.

## Schritte

[!include[Go to company](../../learn/includes/goto-company.md)]

1. Wählen Sie von ![Symbol][img3] der Schaltfläche **Aufgabe** die Option **Firmen verwalten** aus und klicken Sie auf **Firmen zusammenführen**.
    Das Dialogfeld **Firmen zusammenführen** wird geöffnet. Die Quellfirma wird unter **Von** angezeigt.

1. Wählen Sie unter **In Firma** die Firma aus, die mit den Informationen der ersten Firma aktualisiert werden soll. Beginnen Sie mit der Eingabe in das Feld Suche nach einer Firma. Um **Von** und **In** Firmen zu wechseln, müssen Sie auf die Pfeil-Schaltfläche klicken

    > [!Caution]
    > Stellen Sie sicher, dass im Dialogfeld Firmen zusammenführen die richtige Firma im Feld Von UND im Feld An ausgewählt wurde.

1. Unter **Personen- und Firmendetails** stehen folgende Optionen zur Verfügung:

    * Identische Personen zusammenführen. Wenn diese Option ausgewählt wurde, werden Personen mit identischen Namen zusammengeführt.

        Um die Personen zusammenzuführen, müssen alle Namen, Zweite Vornamen und Nachname – GENAU übereinstimmen.

    * **Ersetzen Sie leere Felder in \[target company\] mit Werten von \[source company\]**. Wenn diese Option ausgewählt wurde, werden leere Datenfelder in der Firma **An** mit Daten aus der Firma **Von** aktualisiert.

1. Klicken Sie auf **Zusammenführen**. Daraufhin geschieht Folgendes:

    * Die Firmen werden zusammengeführt.
    * Die Personen werden verschoben oder zusammengeführt.
    * Alle Aktivitäten werden verschoben.
    * Projektzugehörigkeiten und Zugehörigkeiten statischer Selektionen werden zusammen mit der Firma verschoben.
    * Wenn Sie die Option **Leere Felder bei &lt;target company&gt; durch Werte von &lt;source company&gt; ersetzen** gewählt haben, werden alle Details zusammengeführt.
    * Die Quellfirma wird gelöscht.

![Dialogfeld Firmen zusammenführen -screenshot][img4]

> [!TIP]
> Sie können auch Firmen in dynamischen und statischen Selektionen zusammenführen.

## Verwandte Themen

* [Personen zusammenführen][2]

<!-- Referenced links -->
[2]: ../../contact/learn/merge-contacts.md

<!-- Referenced images -->
[img3]: ../../../media/icons/btn-menu.png
[img4]: ../../../media/loc/en/company/merge-companies.png
