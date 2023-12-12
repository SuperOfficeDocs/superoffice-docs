---
uid: help-de-email-filter
title: E-Mail-Filter
description: E-Mail-Filter
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: E-Mail
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# E-Mail-Filter

Mit einem E-Mail-Filter können Sie den Inhalt eingehender E-Mails analysieren und auf der Grundlage des Inhalts eine Anfrage erzeugen.

Zudem können Sie komplexe Regeln für die Verarbeitung der E-Mails von bestimmten Absendern hinzufügen. E-Mail-Filter werden häufig in Verbindung mit Internetformularen verwendet, die von der Firma veröffentlicht wurden und die eine E-Mail-Mitteilung mit einem festen Format generieren, die in SuperOffice Service importiert wird.

## Beispiel für eingehende E-Mails aus Web-Formularen

Sie können beispielsweise mithilfe fester Ausdrücke Informationen aus einem Web-Formular extrahieren, das von einem Kunden ausgefüllt wurde. Die Daten aus dem Formular werden anhand eines definierten Regelsatzes in die Kundendatenbank eingetragen. Die aus der E-Mail bzw. dem Formular erzeugte Anfrage wird dann in eine bestimmte Kategorie eingeordnet und ein Bearbeiter wird ausgewählt. Danach wird die Anfrage abgeschlossen und der Kunde erhält auf Grundlage einer Antwortvorlage eine angepasste Empfangsbestätigung. Es gibt also zahlreiche Optionen für die automatische Bearbeitung eingehender E-Mails.

* Eine über ein Web-Formular erhaltene E-Mail verfügt normalerweise über eine Standardabsenderadresse. Sie können diese Adresse durch die E-Mail-Adresse des Kunden ersetzen.

* Sie können die Kundentelefonnummer mit den Informationen in der Kundendatenbank abgleichen und die Anfrage auf dieser Basis dem entsprechenden Kunden zuordnen.

* Adressdaten können bei einer Adressänderung überschrieben werden.

* Sie können eine Empfangsbestätigung mit abgestimmten Informationen senden, wenn der Kunde mehr Informationen über ein bestimmtes Produkt wünscht, und die Anfrage der entsprechenden Unterkategorie und dem entsprechenden Bearbeiter zuordnen.

## Spalten in der Filterliste

Die Registerkarte **E-Mail-Filter** enthält eine Liste der vorhandenen E-Mail-Filter. Diese Liste enthält folgende Spalten:

| Spalte | Beschreibung |
|---|---|
| Beschreibung | Eine Beschreibung des E-Mail-Filters. |
| Priorität | Die Priorität des E-Mail-Filters. Pro E-Mail wird nur ein Filter aktiviert. Wenn mehrere Filter Suchkriterien für eingehende E-Mails enthalten, die einer eingehenden E-Mail entsprechen, wird der Filter mit der höchsten Priorität aktiviert. |
| E-Mail-Adressen | Die Adresse(n) des Postfachs, das gefiltert wird. |
| Suchzeichenfolge | Die vom E-Mail-Filter verwendete Suchzeichenfolge. |

## Eigenschaften für erstellte Anfragen

* **Eigentümer festlegen**: Wenn Sie diese Option aktivieren, können Sie wählen, welchem Benutzer mit diesem Filter verarbeitete E-Mails zugewiesen werden.

* **Kategorie festlegen**: Wenn Sie diese Option aktivieren und eine Kategorie auswählen, werden mit diesem Filter verarbeitete E-Mails in der angegebenen Kategorie abgelegt.

* **Anfragetyp**: Wenn Sie hier diese Option aktivieren und einen Typ auswählen, wird die von diesem Filter verarbeitete E-Mail dem angegebenen [Anfragetyp][3] zugeordnet. (Nur im Pilot verfügbar.)

* **Priorität festlegen**: Wenn Sie diese Option aktivieren und eine Priorität auswählen, wird die angegebene Priorität mit diesem Filter verarbeiteten E-Mails zugewiesen.

* **Zugriffsstufe festlegen**: Wenn Sie diese Option aktivieren und eine Zugriffsstufe im Listenfeld auswählen, wird die angegebene Zugriffsstufe mit diesem Filter verarbeiteten E-Mails zugewiesen. Bei Auswahl von **Extern** kann im SuperOffice Kundenzentrum auf die erzeugte Anfrage zugegriffen werden.

* **Nachrichten formatieren**: Wenn Sie diese Option aktivieren und eine Antwortvorlage auswählen, wird die Nachricht in der Anfrage entsprechend der ausgewählten Vorlage unter Berücksichtigung der von den regulären Ausdrücken gelieferten Werte formatiert. Diese Option können Sie zum Darstellen eines Formulars verwenden, das per E-Mail gesendet wird und wesentlich übersichtlicher ist. Die Mitteilung ersetzt die ursprüngliche E-Mail.

* **Anfrage abschließen**: Wenn Sie diese Option aktivieren, wird die Anfrage unverzüglich abgeschlossen und ihr wird der Status **Geschlossen** zugewiesen.

* **Absenderadresse ignorieren**: Wenn Sie diese Option aktivieren, ignoriert SuperOffice Service die ursprüngliche Absenderadresse. Die Anfrage wird dann nicht mit einer Person verknüpft, es sei denn, eine Verknüpfung mit einer Person wird durch andere Regeln des E-Mail-Filters erstellt.

* **E-Mail blockieren**: Wenn diese Option aktiviert ist, wird die E-Mail nicht in SuperOffice Service importiert. Stattdessen wird sie der Liste auf der Registerkarte **Blockierte E-Mails** hinzugefügt.

* **E-Mail endgültig löschen**: Wenn diese Option aktiviert ist, wird die E-Mail dauerhaft gelöscht.

    > [!NOTE]
    > E-Mails, die endgültig gelöscht wurden, können nicht wiederhergestellt werden.

* **Weiterleiten an**: Wenn Sie diese Option aktivieren und eine E-Mail-Adresse eingeben, wird die E-Mail an diese Adresse weitergeleitet.

* **Fehlerinformationen in Nachricht aufnehmen**: Wenn Sie diese Option aktivieren, enthält die Mitteilung Fehlerinformationen, anhand derer Sie überprüfen können, ob der E-Mail-Filter ordnungsgemäß funktioniert.

* **E-Mail als nicht zustellbar kennzeichnen**: Wenn Sie diese Option aktivieren, werden von diesem Filter verarbeitete E-Mail-Nachrichten als nicht zustellbar gekennzeichnet. Dies kann für E-Mails relevant sein, die vom Postmaster, vom Mailer-Daemon usw. stammen.

## Was möchten Sie jetzt tun?

* [E-Mail-Filter erstellen][1]
* [E-Mail-Filter löschen][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->
