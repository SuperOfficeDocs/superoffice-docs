---
uid: help-de-flow-participants
title: Flowteilnehmer
description: Flowteilnehmer
keywords: Marketing, Flow, Teilnehmer, Teilnehmerstatus, Mit Erfolg abgeschlossen, Abbruch, Einschreibung
author: Bergfrid Dias
date: 05.31.2024
version: 10.3.5
topic: howto
language: de
audience: person
audience_tooltip: SuperOffice Marketing
---

# Flowteilnehmer

## Schritte

Um die Liste der Teilnehmer für einen bestimmten Flow anzuzeigen:

1. Gehen Sie zu **Marketing** > **Flows**.
1. Klicken Sie, um einen Flow auszuwählen.
1. Wählen Sie die Registerkarte **Teilnehmer** aus.
1. Wählen Sie optional aus, wie die Liste gruppiert werden soll.

![Die Liste der Flowteilnehmer -screenshot][img1]

Verwenden Sie das Zahnrad (<i class="ph ph-gear" aria-hidden="true"></i>) im Kopf der Liste, um die Spalten anzupassen.

![Die Liste der Flowteilnehmer, Spalten anpassen -screenshot][img2]

## Teilnehmerstatus

| Status | Beschreibung |
|---|---|
| Aktiv | Teilnehmer ist im Flow aktiv. |
| Abgeschlossen | Teilnehmer hat alle Schritte im Flow abgeschlossen. |
| Mit Erfolg abgeschlossen | Teilnehmer hat den Flow abgeschlossen und das Erfolgskriterium erfüllt. In die Erfolgsrate des Flow einbezogen. |
| Abbruch | Teilnehmer ist ausgeschieden, immer mit einem angegebenen Ausscheidungsgrund. |
| Abbruch | Teilnehmer wird den Flow nicht abschließen, weil ein Administrator den Flow beendet hat. |

## <a id="logic"></a>Einschreibung und Fortschritt im Flow

Vor jedem Schritt überprüft SuperOffice CRM, ob der Teilnehmer fortschreiten kann.

Für alle Schritttypen:

1. Ist der Status des Teilnehmers *Aktiv*?
1. Erfüllt der Teilnehmer das definierte Erfolgskriterium?
1. Ist der Person als ehemaliger Mitarbeiter markiert?
1. Ist der Person in die Ausschlussliste aufgenommen?

Zusätzlich für E-Mail-Schritt:

1. Ist die Einwilligung des Teilnehmers gültig?
1. Ist der Person für den Flow-Abonnementtyp registriert?
1. Hat der Person eine registrierte E-Mail-Adresse?
1. Ist die E-Mail-Adresse bereits im Flow aktiv?
1. Ist die E-Mail-Adresse entsperrt?

Zusätzlich für SMS-Schritt:

1. Hat der Person eine registrierte Mobiltelefonnummer für SMS?

### Wie wirken sich Erfolgskriterien auf die Einschreibung aus?

* Persone, die bereits die Erfolgskriterien erfüllen, werden dennoch dem Flow hinzugefügt und als Erfolge gezählt. Ihr Fortschritt durch die Flussschritte hängt von der Konfiguration ab.

* Persone, die die Erfolgskriterien nach Abgeschlossen eines Flow erfüllen, werden nicht in die Erfolgsrate des Flow einbezogen, da dies nach ihrer aktiven Teilnahme erfolgt ist.

### Welchem Zweig folgt ein Teilnehmer?

In einer Aufteilung folgen Teilnehmer dem ersten (linken) Zweig, in dem sie die angegebenen Bedingungen erfüllen.

## Aufgaben

* Zur Selektion hinzufügen: Fügt den Teilnehmer einer statischen Selektion hinzu.
* Zum Flow hinzufügen: Gibt an, dass dieser Person zur Einschreibung in einen anderen Flow vorgeschlagen wird.
* Aus dem Flow entfernen: Entfernt alle Aufzeichnungen über die Teilnahme des Persons am aktuellen Flow.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png
