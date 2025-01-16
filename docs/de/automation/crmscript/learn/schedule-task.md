---
uid: help-de-automation-schedule-task
title:  Geplante Aufgaben
description: Geplante Aufgaben
author: SuperOffice RnD
date: 06.29.2022
keywords: Makro, Skript, Zeitplan
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Geplante Aufgaben

Auf der Registerkarte **Geplante Aufgaben** können Sie festlegen, dass ein Skript oder ein Makro zu bestimmten Zeiten ausgeführt werden soll.

> [!TIP]
> Zeitaufwändige Aufgaben sollten zu Zeiten geplant werden, in denen nur wenige Personen SuperOffice verwenden.

Klicken Sie in der Liste auf eine Aufgabe, um deren Eigenschaften zu bearbeiten, also den Zeitpunkt der letzten Ausführung, die Ausführungszeit und die gesendeten/empfangenen Objekte.

## Eine neue geplante Aufgabe erstellen

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klicken Sie auf **CRMScript** und wählen Sie die Registerkarte **Geplante Aufgaben** aus.

1. Klicken Sie auf **Neue Aufgabe**.

1. Wählen Sie in der Liste **Häufigkeit** aus, wie oft die Aufgabe ausgeführt werden soll. Mit **Nach anderem Zeitplan ausführen** können Sie eine Aufgabe starten, nachdem eine andere Aufgabe abgeschlossen wurde. Mit dieser Option lassen sich Aufgaben miteinander verknüpfen.

1. Klicken Sie auf **OK**.

1. Füllen Sie die Felder auf der Registerkarte **Eigenschaften** aus:
    * **Name**: Geben Sie einen Namen für die Aufgabe ein.
    * **ejScript/CRMScript**: Wählen Sie das Skript oder das Makro, das für die Aufgabe verwendet werden soll.

1. Klicken Sie auf **Übernehmen** und wechseln Sie zur Registerkarte **Zeitplan**.

1. Wählen Sie **Jetzt starten**, um die Aufgabe auszuführen, sobald das nächste Mal auf geplante Aufgaben geprüft wird (normalerweise innerhalb 1 Minute).

1. Wählen Sie **Deaktivieren**, wenn die Aufgabe vorerst nicht aktiv sein soll.

1. Bearbeiten Sie den Zeitplan. Die verfügbaren Felder hängen von der ausgewählten Häufigkeit ab:

    * **Nie**: Die Aufgabe wird nicht ausgeführt, bis Sie **Jetzt starten** auswählen.
    * **Minutenintervall**: Die Aufgabe wird im ausgewählten Intervall (in Minuten) ausgeführt. Stellen Sie sicher, dass das Intervall länger ist, als die zum Ausführen der Aufgabe benötigte Zeit.
    * **Stündlich**: Die Aufgabe wird einmal pro Stunde ausgeführt, und zwar X Minuten nach der vollen Stunde.
    * **Wochenintervall**: Die Aufgabe wird wöchentlich ausgeführt. Geben Sie die Uhrzeit ein und an welchem (welchen) Tag(en) die Aufgabe ausgeführt werden soll.
    * **Monatsintervall**: Die Aufgabe wird monatlich ausgeführt. Geben Sie ein, an welchem Tag des Monats und in welchem (welchen) Monat(en) sie ausgeführt werden soll.
    * **Nach** Die Aufgabe wird am festgelegten Datum zur festgelegten Uhrzeit ausgeführt.
    * **Nach anderem Zeitplan ausführen**: Die Aufgabe wird ausgeführt, sobald die ausgewählte geplante Aufgabe abgeschlossen ist. Mit dieser Option lassen sich Aufgaben miteinander verknüpfen.

1. Legen Sie die **Sperrzeit in Minuten** fest, um zu verhindern, dass mehrere Aufgaben mit identischem Zeitplan gleichzeitig ausgeführt werden. Es empfiehlt sich, hier einen höheren Wert als die erwartete Ausführungsdauer für die Aufgabe einzustellen. Wenn Ihre Aufgabe mehr Zeit in Anspruch nimmt als hier angegeben, gilt sie als fehlgeschlagen, und eine neue Aufgabe aus demselben Zeitplan kann ausgeführt werden.

1. Stellen Sie **Minuten vor Neustart** ein. Mit dieser Einstellung legen Sie fest, wie lange es dauert, bis eine fehlgeschlagene (abgestürzte) Aufgabe erneut ausgeführt wird.

1. Klicken Sie auf **OK**. Die Aufgabe wird zur Liste hinzugefügt und der Status und die Uhrzeit der nächsten Ausführung der Aufgabe werden angezeigt.

## Zugehörige Inhalte

* [Beste Praktiken für CRMScript][1]

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/automation/crmscript/code-quality/best-practices.html
