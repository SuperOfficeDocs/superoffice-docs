---
uid: help-de-request-category-create
title: Anfragekategorie erstellen
description: Anfragekategorie erstellen
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: Anfrage, Kategorie
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: de
---

# Anfragekategorie erstellen

1. Klicken Sie unter Einstellungen und Verwaltung im Navigator auf die Schaltfläche **Anfragen** und wählen Sie die Registerkarte **Kategorien** aus.

1. Klicken Sie auf die Schaltfläche **Hinzufügen**.

1. Geben Sie einen beschreibenden Namen für die Kategorie im Feld **Neue Kategorie** über den Registerkarten ein.

1. Geben Sie auf der Registerkarte **Eigenschaften** folgende Informationen ein:

    * **Intern oder extern**: Wenn Sie **Intern** aktivieren, ist die Kategorie im SuperOffice Kundenzentrum nicht sichtbar.

    * **Externer Name**: Geben Sie hier den Kategorienamen ein, der dem Kunden angezeigt wird. Dies ist ein Pflichtfeld, es sei denn, es handelt sich um eine interne Kategorie.

    * **Unterkategorie von**: Wenn dies eine Unterkategorie einer anderen Kategorie sein sollte, wählen Sie die gewünschte übergeordnete Kategorie aus.

    * **Kategorienadministrator**: Wählen Sie die Person aus, die für die zu verarbeitenden Anfragen in dieser Kategorie verantwortlich sein soll. Auf der Registerkarte **Zuordnungsmethode** können Sie festlegen, dass Anfragen dem Kategorienadministrator zugeordnet werden, wenn keine anderen Mitglieder der Kategorie verfügbar sind. Im Normalfall sollte die Rolle des Kategorienadministrators von einem Abteilungsleiter übernommen werden.

        * **Kategorie in Statusübersicht anzeigen**: Wenn Sie diese Option aktivieren, wird diese Kategorie unter **Status** im **Dashboard** angezeigt.
        * **Nur Mitglieder haben Zugriff**: Wenn diese Option aktiviert ist, ist die Kategorie nur für Mitglieder der Kategorie zugänglich.
        * **Benachrichtigung über neue Anfrage an Mitglieder senden**: Wenn diese Option aktiviert ist, werden alle Mitglieder der Kategorie eine Benachrichtigung über neue Anfragen in dieser Kategorie erhalten.

    * **Benachrichtigung über neue Anfrage an E-Mail-Adresse senden**: Geben Sie eine E-Mail-Adresse ein.

    * **Beim Antworten die Zuständigkeit übernehmen**: Wenn diese Option aktiviert ist, wird der Benutzer, der auf eine Anfrage antwortet, als Eigentümer der Anfrage eingestellt.

    * **Standardstatus für neue Anfragen**: Hier wählen Sie den Standardstatus, der in der Ansicht **Anfrage** erscheinen soll. Diese Einstellung setzt [Benutzereinstellungen][1] außer Kraft, es sei denn, Sie wählen **Benutzerdefiniert**.

    * **Standardstatus für neue Nachrichten**: Wählen Sie hier den Standardstatus aus, der in neuen Nachrichten angezeigt werden soll. Diese Einstellung setzt [Benutzereinstellungen][1] außer Kraft, es sei denn, Sie wählen **Benutzerdefiniert**.

    * **Ausgehende E-Mails für diese Kategorie mit Antwortvorlage zusammenführen**: Wählen Sie die Antwortvorlage für Nachrichten an Kunden und andere Empfänger aus, die bei Anfragen, die dieser Kategorie angehören, verwendet werden soll. Dies kann eine speziell für diese Kategorie erstellte Antwortvorlage sein, um allen Antworten einer Kategorie (wie Support oder Buchhaltung) ein einheitliches Erscheinungsbild zu verleihen.

        * Aktivieren Sie die Option **Auf Unterkategorien anwenden**, wenn die ausgewählte Antwortvorlage auch für Unterkategorien verwendet werden soll. Dies setzt allerdings voraus, dass die Vorlage nicht durch Einstellungen in den Unterkategorien außer Kraft gesetzt wird.

1. Auf der Registerkarte **Mitglieder** legen Sie die Benutzer fest, die Mitglieder der Kategorie sein sollen. Wählen Sie in der Liste **Benutzer** unten einen Benutzer aus und klicken Sie auf **Hinzufügen**.

    > [!TIP]
    > Wenn als Zuordnungsmethode für die Anfragen in dieser Kategorie **Gewichtete Zuordnung** ausgewählt ist, können Sie die Gewichtung für jeden einzelnen Benutzer verwenden, um die Zuordnung neuer Anfragen zu bestimmen. Den Benutzern mit der höchsten Gewichtung werden mehr Anfragen zugeordnet. Sie können die gewichtete Zuordnung für Mitglieder von Kategorien aus Benutzergruppen nicht verwenden.

1. Geben Sie auf der Registerkarte **Zuordnungsmethode** folgende Informationen ein:

    * Wählen Sie einen Zuordnungstyp:

        * **Gleichmäßig**: Die Anfragen werden den Mitgliedern der Kategorie gleichmäßig zugeordnet.
        * **Gewichtet**: Die Anfragen werden auf Basis der für die Mitglieder der Kategorie festgelegten Gewichtung zugeordnet.

           Beispiel: Wenn Person A die Gewichtung 1, Person B die Gewichtung 2 und Person C die Gewichtung 5 hat, werden diesen drei Personen bei acht Anfragen jeweils die durch die Gewichtung angegebene Anzahl von Anfragen zugeordnet.

        * **An Benutzer mit den wenigsten unbearbeiteten Anfragen**: Neue Anfragen werden dem Mitglied der Kategorie zugeteilt, das die wenigsten unbearbeiteten Anfragen hat.
        * **Keine Zuordnung**: Die Anfragen werden keinen bestimmten Benutzern zugeordnet, sondern standardmäßig in eine Warteschlange gestellt. Sie können dies unter **Anfragen** &gt; **Nicht zugeordnete Anfragen** (Standard) oder im Warteschlangensystem **Nächste Anfrage in der Warteschlange** anzeigen (siehe [Wie man Nächste Anfrage in der Warteschlange anzeigen einrichtet][3]).

    * **Zuordnung nur an angemeldete Benutzer**: Anfragen werden nur Benutzern zugewiesen, die in SuperOffice Service eingeloggt sind.

    * **Bei Bedarf an Kategorienadministrator zuordnen**: Die Anfragen werden dem Kategorienadministrator zugeordnet, wenn keine anderen Benutzer verfügbar sind.

    * **Neuzuordnung von Anfragen bei neuen Nachrichten in Abwesenheit des Benutzers**: Die Anfragen werden neu zugeordnet, wenn eine neue Nachricht zu einer Anfrage eingeht und der Benutzer nicht verfügbar ist.

    * **Unserem Service-Verantwortlichem zuweisen, falls vorhanden**: Wenn für die entsprechende Firma oder Person ein Bearbeiter als **Unser Kontakt** angegeben, und diese Person verfügbar ist, wird ihr die Anfrage zugewiesen. Ist unter **Verantwortlich** keine Person angegeben oder ist diese nicht verfügbar, wird die Anfrage entsprechend den üblichen Regeln zugewiesen.

    * **Zuordnung aussetzen**: Geben Sie die Dauer in Minuten ein, in der die normale Zuordnung ausgesetzt wird und alle Anfragen desselben Kunden einem bestimmten Benutzer zugeteilt werden. So können Sie sicherstellen, dass zwei Anfragen, die von einem Kunden nacheinander an dieselbe E-Mail-Adresse gesendet wurden, dem gleichen Bearbeiter zugewiesen werden. Bei Eingabe von -1 wird diese Funktion deaktiviert und alle Anfragen werden entsprechend den üblichen Regeln zugewiesen.

1. Klicken Sie auf **Speichern**. Die Kategorie wird erstellt.

<!-- Referenced links -->
[1]: ../../../admin/preferences/learn/index.md
[3]: ../next-in-queue.md

<!-- Referenced images -->
