---
uid: help-de-email-filter-create
title: E-Mail-Filter erstellen
description: E-Mail-Filter erstellen
keywords: E-Mail, E-Mail-Filter, Filter
author: SuperOffice RnD
date: 07.17.2024
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# E-Mail-Filter erstellen

1. [!include[Go to email](../includes/goto-email.md)]

1. Wählen Sie die Registerkarte **E-Mail-Filter** aus.

1. Klicken Sie auf **Neuer E-Mail-Filter**. Es wird die Ansicht **Eigenschaften für E-Mail-Filter** angezeigt.

1. Auf der Registerkarte **Filter** können Sie angeben, welche E-Mails gefiltert werden sollen. Geben Sie dazu folgende Informationen ein:

    * **Beschreibung**: Geben Sie eine kurze Beschreibung des E-Mail-Filters ein.
    * **Priorität**: In dieser Dropdown-Liste wählen Sie die Priorität für den Filter aus. 100 ist der höchste und 1 der niedrigste Prioritätswert.
    * **Skript**: Hier können Sie ein [Skript oder Makro][1] auswählen, das von diesem Filter ausgeführt werden soll.

1. Wählen Sie aus, wofür der Filter angewendet werden soll:

    * **Alle eingehenden E-Mails**: Wenn Sie diese Option wählen, wird der E-Mail-Filter auf alle eingehenden E-Mails angewendet.
    * **E-Mail mit folgendem Inhalt**: Wenn Sie diese Option wählen, wird der E-Mail-Filter durch E-Mails ausgelöst, die den in den Feldern auf der rechten Seite angegebenen festen Ausdruck (regexp) enthalten. Sie können zwischen der E-Mail-Kopfzeile und/oder dem E-Mail-Text wählen.

1. Auf der Registerkarte **Reguläre Suchausdrücke** können Sie reguläre Ausdrücke zum Suchen von Text in E-Mails definieren und sie als Variablen speichern. Verwenden Sie das folgende Format, um den Wert eines regulären Ausdrucks einer Variable mit dem Namen myVariable zuzuweisen: myVariable = &lt;regexp&gt;.

1. In der Registerkarte **Verknüpfungen festlegen** legen Sie fest, wie eingehende E-Mails anhand ihres Inhalts mit einer Anfrage und/oder einer Person verknüpft werden:
    * **Verknüpfung mit Person, wenn**: Um die generierte Anforderung anhand der Informationen aus der E-Mail mit einer Person zu verknüpfen, müssen Sie eines der Personenfelder aus der Liste auswählen und dann einen regulären Ausdruck eingeben, der den Wert zurückgibt, der die Person identifiziert.
    * **Verknüpfung mit Anfrage, wenn**: Hier können Sie die E-Mail mit einer vorhandenen Anfrage verknüpfen. Dies erfolgt durch einen regulären Ausdruck, der Informationen aus der E-Mail extrahiert.

1. Auf der Registerkarte **Werte festlegen** können Sie je nach dem Inhalt der E-Mail Werte für Personen, Firmen und Anfragen hinzufügen oder ersetzen:
    1. Wählen Sie im Listenfeld links das erforderliche Feld für die Person, die Firma oder die Anfrage aus.

    2. Geben Sie im Feld auf der rechten Seite eines von Folgendem ein:
        * den regulären Ausdruck, der nach dem festzulegenden Wert sucht
        * einen festen Wert (muss mit dem Präfix = versehen werden)

    3. Wenn Sie das Kontrollkästchen **Ersetzen** aktivieren, wird der vorhandene Wert durch den gefundenen Wert ersetzt.

    4. Klicken Sie auf **Hinzufügen**, um den Wert hinzuzufügen.

        > [!TIP]
        > Zum Löschen eines Werts wählen Sie ihn aus und klicken auf <i class="ph ph-x-circle" aria-label="Remove icon"></i>.

1. Auf der Registerkarte **Eigenschaften festlegen** können Sie bestimmte Eigenschaften für Anfragen festlegen, die aus E-Mails erzeugt wurden, die dem aktuellen Filter entsprechen:

1. Auf der Registerkarte **E-Mail-Antwort** können Sie verschiedene E-Mails erstellen, die bei Auslösen des Filters gesendet werden. Sie können folgende Informationen eingeben:
    * **Antwortvorlage senden**: Hier wählen Sie die [Antwortvorlage][2] aus, die gesendet wird, wenn der Filter ausgelöst wird.
    * **... an Person**: Wenn Sie diese Option aktivieren, wird die ausgewählte Antwortvorlage zurück an die Person gesendet.
    * **... an**: Wenn Sie diese Option aktivieren, wird die ausgewählte Antwortvorlage an die E-Mail-Adresse gesendet, die im Feld auf der rechten Seite angegeben ist.
    * **FAQ-Einträge vorschlagen**: Wenn Sie diese Option aktivieren, schlägt das System die Option [FAQ-Einträge anhand des Textes vorschlagen][3] in der eingehenden E-Mail vor. Die vorgeschlagenen Einträge können als Vorlagenvariablen in der gewählten Antwortvorlage verwendet werden. Außerdem können Sie festlegen, welcher Teil der FAQ-Hierarchie durchsucht werden soll, indem Sie den gewünschten Ordner festlegen.
    * **Automatische Antwort blockieren**: Wenn diese Option aktiviert ist, wird diese E-Mail nicht automatisch beantwortet.

1. Auf der Registerkarte **Postfächer** können Sie die Postfächer auswählen, die gefiltert werden.

1. Klicken Sie auf **OK**. Der E-Mail-Filter wird erstellt.

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/index.md
[2]: ../../../../request/reply-templates/learn/index.md
[3]: ../../../../request/reply-templates/learn/create.md#faq
