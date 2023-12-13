---
uid: help-de-define-link-actions
title: Verknüpfungsaktionen definieren
description: "In dieser Anleitung lernen Sie, wie Sie Links in Kampagnen verwenden, um Aktionen zu automatisieren."
author: SuperOffice RnD
so.date: 02.20.2023
keywords: Marketing
so.topic: howto
language: de
---

# Verwenden Sie Links, um verschiedene Aktionen zu automatisieren

[!include[Requirement](includes/req-marketing.md)]

Sie können Ihre Arbeit beschleunigen, indem Sie die Antworten, die Sie von einer Kampagne erhalten, mit automatisierten Link-Aktionen verarbeiten.

Stellen Sie sich vor, dass Ihre Kampagne ein großer Erfolg wird. Über 500 Personen haben Ihre Mitteilung geöffnet und auf die von Ihnen einbezogenen Links geklickt. Sie müssen jetzt noch all diese Antworten Ihrer Empfänger verarbeiten. Denken Sie darüber nach, wie viel Zeit dies in Anspruch nehmen würde, wenn Sie es manuell tun müssten.

In SuperOffice Marketing können Sie Aktionen zu Ihren Links hinzufügen. Diese Aktionen werden ausgelöst, wenn Empfänger auf einen Link klicken.

![Links-Aktionen festlegen -screenshot][img3]

| Registerkarte | Aktion |
|---|---|
| Antwort | Zielseite oder benutzerdefinierten Text hinzufügen. |
| Feld festlegen | Einem Zusatzfeld einen Wert für die Personen des Kunden hinzufügen |
| Interessen | Interessen aktualisieren. |
| Selektion/Projekt | Ansprechpartner zu Selektion/Projekt hinzufügen bzw. daraus entfernen. |
| Folgeaufgabe | Erstellt eine Folgeaufgabe (Aufgabe oder Besprechung) in SuperOffice CRM. |
| Anfrage | Eine neue Anfrage erstellen. |
| Skript | Ein Skript ausführen. |

## Antwort

* **Auf neue Webseite umleiten**: Wählen Sie diese Option aus, um Empfänger beim Klicken auf den Link an eine Webseite weiterzuleiten. Gibt die URL im Feld **URL der neuen Webseite** ein.

* **Benutzerdefinierten Text anzeigen**: Wählen Sie diese Option aus, wenn benutzerdefinierter Text angezeigt werden soll, wenn der Empfänger auf den Link klickt. Geben Sie den Text in das Feld unten ein.

## Aktualisierung Ihrer Datenbank

Je nach dem Ziel und den Handlungsanreizen, die Sie in Ihrer Kampagne verwenden, können Sie Informationen in Ihrer Datenbank aktualisieren. Wenn eine Person auf den Link in Ihrer Kampagne klickt, führt SuperOffice CRM einen der folgenden Schritte aus:

* Geben Sie eine benutzerdefinierte Antwort oder leiten Sie auf eine Webseite um,
* Fügen Sie eine Person zu einem bestimmten Projekt oder einer Selektion hinzu,
* Aktualisieren Sie das Interesse einer Person,
* Fügen Sie Informationen zu einem Feld auf der Personenkarte hinzu,
* Erstellen Sie eine Folgeaktivität für eine Person,
* Erstellen Sie eine Kundendienstanfrage für eine Person,
* Ein Skript ausführen.

Einige dieser Informationen helfen Ihnen, Ihre Datenbank noch besser zu segmentieren, während andere Informationen Sei bei der Überwachung von Personen unterstützen, die Interesse an Ihrer Mitteilung gezeigt haben.

## Feld festlegen

Auf der Registerkarte **Feld festlegen** können Sie festlegen, dass einem Zusatzfeld ein Wert hinzugefügt werden soll, wenn der Empfänger auf den Link klickt. Dies kann nützlich sein, wenn Sie Zusatzinformationen über Kunden, die auf den Link klicken, erfassen möchten.

Wählen Sie im Listenfeld **Zusatzfeld festlegen** ein Feld aus und geben im Feld **Wert** einen Wert ein.

## <a id="interests" />Interessen

Hier können Sie festlegen, dass beim Klicken auf den Link Interessen für eine Person hinzugefügt oder entfernt werden sollen. Sie könnten beispielsweise das Interesse "Neuigkeiten zu Produkten" hinzufügen, wenn der Empfänger auf den Link "Ja, ich möchte über neue Produkte informiert werden" klickt. Alternativ könnten Sie das Interesse "Neuigkeiten zu Produkten" entfernen, wenn der Benutzer in einem Newsletter auf den Link "Abmelden" klickt.

* Im Listenfeld **Interessen festlegen** können Sie auswählen, ob bestimmte Interessen beim Klicken auf den Link zu den Personen hinzugefügt werden sollen.
* Im Listenfeld **Interesse löschen** können Sie auswählen, ob bestimmte Interessen beim Klicken auf den Link von den Personen entfernt werden sollen.

Siehe auch [Interessen in SuperOffice CRM löschen][1].

## Selektion/Projekt

Hier können Sie festlegen, dass Empfänger, die auf den Link klicken, zu Selektionen in SuperOffice Service oder zu Selektionen bzw. Projekten in SuperOffice CRM hinzugefügt bzw. daraus entfernt werden sollen. Geben Sie den Anfang eines Namens ein, um die Schnellsuche zu starten.

## Folgeaufgabe (Aufgabe/Besprechung)

Auf der Registerkarte **Folgeaufgabe** können Sie festlegen, dass beim Klicken auf den Link Aufgaben bzw. Besprechungen in SuperOffice CRM erstellt werden sollen.

1. Mit dem Kontrollkästchen für **Folgeaufgabe** aktivieren Sie diese Funktion.

2. **Aufgabe/Termin**: Wählen Sie aus, welcher Folgeaufgabentyp erstellt werden soll.

3. **Beschreibung**: Geben Sie eine Beschreibung der Folgeaufgabe bzw. des Termins ein. Zum Beispiel, welche Kampagne dazu gehört, auf welchen Link der Empfänger geklickt hat und möglicherweise wie im Anschluss an die Aufgabe bzw. die Besprechung vorgegangen werden soll.

4. **Projekt**: Hier wählen Sie ein Projekt aus, mit dem die Folgeaufgabe bzw. der Termin verknüpft werden soll. Geben Sie den Anfang eines Namens ein, um die Schnellsuche zu starten.

5. **Aufgabe**: Wählen Sie den erforderlichen Folgeaufgaben- bzw. Termintyp aus.

6. **Erstellt von**: Wählen Sie die für die Folgeaufgabe bzw. den Termin verantwortliche Person oder klicken Sie auf die Schaltfläche **Aktiven Benutzer auswählen** ![Symbol][img1], um sich selbst auszuwählen.

7. **Verantwortlichen Benutzer zuordnen, falls vorhanden**: Klicken Sie hier, wenn die Folgeaufgabe bzw. der Termin dem verantwortlichen Benutzer des Empfängers zugewiesen werden soll (der Person, die sich um diesen Kunden kümmert).

8. **Standardempfänger**: Wählen Sie einen Standardempfänger aus, dem Sie die Folgeaufgabe bzw. den Termin zuweisen möchten, oder klicken Sie auf die Schaltfläche **Aktiven Benutzer auswählen** ![Symbol][img1], um sich selbst auszuwählen.

9. **Dauer**: Klicken Sie auf die Schaltfläche **Zeitraum auswählen** ![Symbol][img2] neben diesem Feld, um die Dauer der Folgeaufgabe bzw. des Termins festzulegen.

## Anfrage

Auf der Registerkarte **Anfrage** können Sie festlegen, dass eine SuperOffice Service-Anfrage für die Personen erstellt werden soll, die auf eine Link klicken.

1. **Neue Anfrage erstellen**: Aktivieren Sie dieses Kontrollkästchen, um eine neue Anfrage zu erfassen, wenn der Kunden auf den Link klickt.
2. **Titel**: Geben Sie hier den Titel für die neue Anfrage ein.
3. **Priorität**: Wählen Sie die Priorität für die Anfrage aus.
4. **Kategorie**: Wählen Sie die gewünschte Kategorie aus.
5. **Eigentümer**: Wählen Sie den Eigentümer für die neue Anfrage aus. Sie können auch die Option **Automatisch zugeordnet** oder **Nicht zugeordnet** auswählen.

## Skript

Auf der Registerkarte **Skript** können Sie ein Skript oder Makro auswählen, das ausgeführt werden soll, wenn der Empfänger auf den Link klickt.

1. Wählen Sie **Skript ausführen**, um diese Funktion auszuführen.
2. Zum Auswählen eines Skripts klicken Sie auf die Liste **Skript** und wählen Sie das erforderliche Skript in der angezeigten Liste aus. Im Skript sind folgende Variablen verfügbar: custId, linkId, shipmentId, linkUrl und linkHits. Sie können auch die Variable returnUrl verwenden, um die angegebene Link-URL zu überschreiben.

## Beispiel

Die manuelle Aktualisierung von 500 Personenkarten nimmt Zeit in Anspruch und ist wirklich unnötig. Wir möchten stattdessen diesen Prozess automatisieren, indem wir automatisierte Link-Aktionen verwenden.

Beispiele für angewendete automatisierte Link-Aktionen:

* Wenn ein Empfänger auf Ihre Handlungsanreize klickt, fügt SuperOffice CRM ihn automatisch zu einer Selektion oder einem Projekt hinzu.

* Anderenfalls aktualisiert SuperOffice CRM automatisch relevante Informationen, wie zum Beispiel Interessen, auf der Personenkarte.

Durch die Automatisierung dieser Aufgaben sparen Sie viel Zeit, die Sie sonst für die Bearbeitung von Antworten aufwenden würden. Wenn der Leser auf einen Link in Ihrer Kampagne klickt, führt das System die Link-Aktionen für Sie aus!

Sie können die Informationen, die Sie in dieser Kampagne gesammelt haben, auf verschiedene Weise verwenden:

* Generieren Sie automatisch eine Selektion anhand der Personen, die auf einen bestimmten Link geklickt haben. Senden Sie dann ein gezieltes Folgekampagne mit einer maßgeschneiderten Mitteilung an diese bestimmte Gruppe.

* Fügen Sie zu den Kalender Ihrer Teammitglieder Folgeaktivitäten hinzu, damit Sie persönlich Personen nachverfolgen können, die geantwortet haben.

* Erstellen Sie Serviceanfragen, damit Ihr Kundendienst-Team die Angelegenheit aufgreift und untersucht.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/add-unsubscribe-link.md#clear-interests

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-contact.png
[img2]: ../../../../../common/icons/pref-diary.png
[img3]: ../../../../media/loc/en/marketing/link-properties-follow-up.png
