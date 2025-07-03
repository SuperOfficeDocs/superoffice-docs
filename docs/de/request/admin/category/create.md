---
uid: help-de-request-category-create
title: Anfragekategorie erstellen
description: Anfragekategorie erstellen
keywords: Anfragekategorie hinzufügen, Anfragekategorie erstellen, neue Anfragekategorie, Anfragekategorie, Kategorien-Registerkarte, Anfrage, Kategorie
author: Hanne Gunnarsson
date: 02.14.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: settings
audience_tooltip: Einstellungen und Verwaltung
language: de
redirect_from: /de/request/learn/category/create
---

# Anfragekategorie erstellen

1. Klicken Sie in Einstellungen und Verwaltung im Navigator auf die Schaltfläche **Anfragen** und wählen Sie die Registerkarte **Kategorien** aus.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie einen beschreibenden Namen für die Kategorie im Feld **Neue Kategorie** über den Registerkarten ein.

1. Geben Sie auf der Registerkarte **Eigenschaften** folgende Informationen ein:

    * **Intern oder extern**: Wenn Sie **Intern** aktivieren, ist die Kategorie im SuperOffice Kundenzentrum nicht sichtbar.

    * **Externer Name**: Geben Sie hier den Kategorienamen ein, der dem Kunden angezeigt wird. Dies ist ein Pflichtfeld, es sei denn, es handelt sich um eine interne Kategorie.

    * **Unterkategorie von**: Falls diese Kategorie einer übergeordneten Kategorie untergeordnet sein soll, wählen Sie die gewünschte Hauptkategorie aus.

    * **Kategorienadministrator**: Wählen Sie die Person aus, die für die Bearbeitung der Anfragen in dieser Kategorie verantwortlich ist. Auf der Registerkarte **Zuordnungsmethode** können Sie festlegen, dass Anfragen dem Kategorienadministrator zugeordnet werden, wenn keine anderen Mitglieder verfügbar sind. Normalerweise sollte diese Rolle von einem Abteilungsleiter übernommen werden.

        * **Kategorie in Statusübersicht anzeigen**: Falls aktiviert, wird diese Kategorie unter **Status** im **Dashboard** angezeigt.
        * **Nur Mitglieder haben Zugriff**: Falls aktiviert, haben nur Mitglieder der Kategorie Zugriff.
        * **Benachrichtigung über neue Anfragen an Mitglieder senden**: Falls aktiviert, werden alle Mitglieder über neue Anfragen benachrichtigt.

    * **Benachrichtigung über neue Anfragen an E-Mail-Adresse senden**: Geben Sie eine E-Mail-Adresse ein.

    * **Beim Antworten die Zuständigkeit übernehmen**: Falls aktiviert, wird der Benutzer, der antwortet, als Eigentümer der Anfrage festgelegt.

    * **Standardstatus für neue Anfragen**: Wählen Sie den Standardstatus für neue Anfragen aus. Diese Einstellung überschreibt [Benutzereinstellungen][1], es sei denn, Sie wählen **Benutzerdefiniert**.

    * **Standardstatus für neue Nachrichten**: Wählen Sie den Standardstatus für neue Nachrichten aus. Diese Einstellung überschreibt [Benutzereinstellungen][1], es sei denn, Sie wählen **Benutzerdefiniert**.

    * **Ausgehende E-Mails für diese Kategorie mit Antwortvorlage zusammenführen**: Wählen Sie die Antwortvorlage für Nachrichten an Kunden und andere Empfänger aus, die bei Anfragen, die dieser Kategorie angehören, verwendet werden soll. Dies kann eine speziell für diese Kategorie erstellte Antwortvorlage sein, um allen Antworten einer Kategorie (wie Support oder Buchhaltung) ein einheitliches Erscheinungsbild zu verleihen.

        * Aktivieren Sie die Option **Auf Unterkategorien anwenden**, wenn die ausgewählte Antwortvorlage auch für Unterkategorien verwendet werden soll. Dies setzt allerdings voraus, dass die Vorlage nicht durch Einstellungen in den Unterkategorien außer Kraft gesetzt wird.

1. In der Registerkarte **Mitglieder** können Sie Benutzer zur Kategorie hinzufügen. Wählen Sie einen Benutzer aus der Liste und klicken Sie auf **Hinzufügen**.

    > [!TIP]
    > Wenn als Zuordnungsmethode für die Anfragen in dieser Kategorie **Gewichtete Zuordnung** ausgewählt ist, können Sie die Gewichtung für jeden einzelnen Benutzer verwenden, um die Zuordnung neuer Anfragen zu bestimmen. Den Benutzern mit der höchsten Gewichtung werden mehr Anfragen zugeordnet. Sie können die gewichtete Zuordnung für Mitglieder von Kategorien aus Benutzergruppen nicht verwenden.

1. In der Registerkarte **Zuordnungsmethode** geben Sie folgende Informationen ein:

    * Wählen Sie eine Zuordnungsmethode:

        * **Gleichmäßig**: Anfragen werden gleichmäßig verteilt.
        * **Gewichtet**: Anfragen werden basierend auf festgelegten Gewichtungen verteilt.

            Beispiel: Wenn Person A die Gewichtung 1, Person B die Gewichtung 2 und Person C die Gewichtung 5 hat, werden diesen drei Personen bei acht Anfragen jeweils die durch die Gewichtung angegebene Anzahl von Anfragen zugeordnet.

        * **An Benutzer mit den wenigsten unbearbeiteten Anfragen**: Neue Anfragen werden dem Benutzer mit den wenigsten offenen Anfragen zugewiesen.
        * **Keine Zuordnung**: Die Anfragen werden keinen bestimmten Benutzern zugeordnet, sondern standardmäßig in eine Warteschlange gestellt. Sie können dies unter **Anfragen** > **Nicht zugeordnete Anfragen** (Standard) oder im Warteschlangensystem **Nächste Anfrage in der Warteschlange** anzeigen.

    * **Zuordnung nur an angemeldete Benutzer**: Anfragen werden nur angemeldeten Benutzern zugewiesen.

    * **Bei Bedarf an Kategorienadministrator zuordnen**: Falls aktiviert, werden Anfragen dem Kategorienadministrator zugewiesen, wenn keine anderen Mitglieder verfügbar sind.

    * **Neuzuordnung von Anfragen bei neuen Nachrichten in Abwesenheit des Benutzers**: Falls aktiviert, werden Anfragen neu zugewiesen, wenn der zuständige Benutzer nicht verfügbar ist.

    * **Unserem Service-Verantwortlichem zuweisen, falls vorhanden**: Falls ein Ansprechpartner für eine Firma oder Person definiert ist, wird die Anfrage diesem Benutzer zugewiesen, falls dieser verfügbar ist.

    * **Zuordnung aussetzen**: Geben Sie eine Zeitspanne in Minuten an, in der alle Anfragen eines Kunden demselben Bearbeiter zugewiesen werden sollen. Dies stellt sicher, dass aufeinanderfolgende Anfragen an dieselbe Person gehen. Geben Sie **-1** ein, um diese Funktion zu deaktivieren.

1. Klicken Sie auf **Speichern**. Die Kategorie wird erstellt.

## Verwandte Inhalte

* [Wie man "Nächste Anfrage in der Warteschlange" einrichtet][3]

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/index.md
[3]: ../next-in-queue.md

<!-- Referenced images -->
