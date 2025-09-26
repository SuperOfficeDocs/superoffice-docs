---
uid: help-de-flow-split
title: Ablaufsteuerung - Aufteilen
description: Ablaufsteuerung - Aufteilen
keywords: Marketing, Flow, Ablaufsteuerung, Aufteilen, Zweig, Pfad, differenzierenm, alle anderen
author: Bergfrid Dias
date: 09.26.2025
version: 10.5
content_type: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Ablaufsteuerung - Aufteilen

Ein Aufteilung-Schritt teilt die Teilnehmer des Flow in 2 oder mehr Zweige auf, basierend auf einer oder mehreren Bedingungen. Dadurch können Sie alternative Pfade verwenden und Teilnehmer je nach Kontaktdaten oder Engagement unterschiedlich behandeln.

Sie können differenzieren basierend auf:

* Firmas-/Kontaktdaten
* Formularübermittlung
* Formulardaten
* Link-Klick (überwachte)
* Mitgliedschaft in einem Projekt
* Mitgliedschaft in einer statischen Selektion

## Wie es funktioniert

Wenn der Teilnehmer die Aufteilung erreicht, wird zuerst die Schrittkriterien für den **linksten** Zweig ausgewertet. Sie können nur einem Pfad folgen. Wenn eine Übereinstimmung besteht, bewegen sie sich zum nächsten Schritt dieses Zweigs. Dann wird die nächste Zweigbedingung überprüft, und so weiter. Alle Aufteilungen haben einen Zweig für alle, die keine der Bedingungen erfüllen.

## Schritte

1. Ziehen Sie das **Aufteilung**-Feld aus dem Schrittmendü und lassen Sie es in einen verfügbaren Steckplatz im Diagramm fallen.
2. Geben Sie einen beschreibenden **Titel** ein.

    > [!TIP]
    > Ein beschreibender Titel und Zweigbezeichnungen erleichtern das Lesen des Flow.

3. Wählen Sie aus, worauf die Aufteilung basieren soll. Einige Optionen erfordern, dass Sie hier zusätzliche Details angeben.
4. Benennen Sie den neuen Zweig.
5. Legen Sie zweigspezifische Kriterien fest. Die Optionen hängen davon ab, worauf die Aufteilung basiert.
6. Fügen Sie bei Bedarf weitere Zweige hinzu und wiederholen Sie die Schritte 4-5.
7. Wählen Sie aus, ob Teilnehmer, die keine Kriterien erfüllen, den Flow verlassen sollen.
8. Fügen Sie weiterhin Schritte zu jedem Zweig hinzu.

Alle anderen gehen weiter:

![Marketing-Automatisierung: Flow aufteilen basierend auf Persondaten -screenshot][img1]

Alle anderen beenden:

![Marketing-Automatisierung: Flow aufteilen basierend auf Persondaten -screenshot][img2]

> [!NOTE]
> Sie können den Zweig **Alle anderen** nicht löschen.

### Aufteilung basierend auf Persondaten

Wenn Sie die Teilnehmer basierend auf Persondaten aufteilen möchten, können Sie aus den Person- und Firmenkriterien aus **Kontakt suchen** auswählen.

* Für jeden Zweig [wählen Sie Werte für das Kriterium][11] in den verschiedenen Feldern auf der Linie aus (ähnlich wie in der Suchanzeige). Klicken Sie auf **Hinzufügen**, um weitere Kriterien einzufügen.

![Marketing-Automatisierung: Flow aufteilen basierend auf Firmendaten -screenshot][img3]

### Aufteilung basierend auf Link-Klick

Wenn ausgewählt, erscheint ein Feld zur Angabe, welches E-Mail angezeigt wird.

* E-Mail: Wählen Sie **Beliebige E-Mail** oder eine bestimmte Aussendung aus.
* Wählen Sie für jeden Zweig aus, auf welchen [verfolgten Link][7] der Teilnehmer klicken muss, um in diesen Zweig zu gelangen.

![Marketing-Automatisierung: Flow aufteilen basierend auf Link-Klick -screenshot][img4]

### Aufteilung basierend auf Formularübermittlung Ja/Nein

Wenn ausgewählt, erscheint ein Feld zur Angabe, welches Formular angezeigt wird.

* Formular: Wählen Sie ein bestimmtes Formular aus.

![Marketing-Automatisierung: Flow aufteilen basierend auf Formularübermittlung -screenshot][img5]

> [!NOTE]
> Diese Aufteilung ist unabhängig davon, welche Formulardaten übermittelt wurden. Es gibt keine zweigspezifischen Einstellungen. Da es sich um einen Ja/Nein-Test handelt, können Sie keine weiteren Zweige hinzufügen.

### Aufteilung basierend auf Formulardaten

Diese Bedingung ist eine Variante der Aufteilung basierend auf der Übermittlung mit zusätzlichen Datenkriterien, die auf den Zweig angewendet werden.

Wenn ausgewählt, erscheint ein Feld zur Angabe, welches Formular angezeigt wird.

* Formular: Wählen Sie ein bestimmtes Formular aus.
* Für jeden Zweig wählen Sie Werte für das Kriterium in den verschiedenen Feldern auf der Linie aus (ähnlich wie in der Suchane).

![Marketing-Automatisierung: Flow aufteilen basierend auf Formulardaten (Kontaktieren Sie mich) -screenshot][img6]

> [!NOTE]
> In diesem Szenario bedeutet **alle anderen**, dass sowohl Teilnehmer, die das Formular nicht absenden, als auch Absender, die die zusätzlichen Kriterien auf keinem der anderen Zweige erfüllen.

### Aufteilung basierend auf Projektmitgliedschaft

* Für jeden Zweig wählen Sie aus, welchem Projekt der Teilnehmer angehören muss.

![Marketing-Automatisierung: Flow aufteilen basierend auf Projektmitgliedschaft -screenshot][img7]

### Aufteilung basierend auf statischer Selektion

Ähnlich wie bei der Aufteilung basierend auf Projektmitgliedschaft.

## Erfolgskriterien als vorzeitige Beendigungsbedingung verwendet

Erfolgskriterien können auch als vorzeitige Beendigungsbedingung im Flow verwendet werden und eliminieren die Notwendigkeit für Zweige. Bevor eine Aktion für einen Teilnehmer in einem Flowschritt ausgeführt wird, wird der Status des Teilnehmers neu bewertet. Diese Neubewertung berücksichtigt die Erfolgskriterien. Wenn ein Teilnehmer die Erfolgskriterien erfüllt, wird sein Status auf *Mit Erfolg abgeschlossen* aktualisiert, oder er bleibt *Aktiv*, wenn er den Flow abschließen soll. Am Abgeschlossenschritt erhalten Teilnehmer, die die Erfolgskriterien erfüllt haben, den Status *Mit Erfolg abgeschlossen*.

<!-- Referenced links -->
[7]: ../../tracked-links/learn/index.md
[11]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/split-flow-contact-data-no-exit.png
[img2]: ../../../../media/loc/en/marketing/split-flow-contact-data-yes-exit.png
[img3]: ../../../../media/loc/en/marketing/split-flow-company-data-dropdown.png
[img4]: ../../../../media/loc/en/marketing/split-flow-link-clicked.png
[img5]: ../../../../media/loc/en/marketing/split-flow-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/split-flow-form-data-contact-me.png
[img7]: ../../../../media/loc/en/marketing/split-flow-project-member.png
