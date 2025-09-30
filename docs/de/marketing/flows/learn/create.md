---
uid: help-de-flow-create
title: Neuen Flow erstellen
description: Neuen Flow erstellen
keywords: Marketing, Flow
author: Bergfrid Dias
date: 09.26.2025
version: 11.3
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: de
---

# Neuen Flow erstellen

## Schritte

1. Wählen Sie **Marketing** im Navigator aus.
1. Gehen Sie zur Registerkarte **Flows**.
1. Klicken Sie ggf. auf **Ordner hinzufügen**, um [einen Ordner für den Flow zu erstellen][8].
1. Klicken Sie auf die Schaltfläche **Flow** unter **Neu erstellen** auf der rechten Seite des Bildschirms.
1. Geben Sie im Dialogfeld **Flow bearbeiten** einen aussagekräftigen **Namen** ein.
1. [Füllen Sie die Felder](#fields) wie unten beschrieben aus. Denken Sie daran, regelmäßig auf **Speichern** zu klicken, um Ihre Arbeit zu sichern. Der Flow wird nicht automatisch gespeichert.
1. [Definieren Sie den Flow-Trigger und Filter.](#trigger)
1. [Schritte hinzufügen.](#add-step)
1. Legen Sie fest, was passiert, wenn der Flow abgeschlossen ist.
1. Klicken Sie auf **Speichern**, wenn Sie fertig sind.

![Eigenschaften für neuen Flow festlegen -screenshot][img1]

## <a id="fields"></a>Flowfelder ausfüllen

### Einstellungen (für Flow)

| Einstellung | Beschreibung |
|---|---|
| Name | Eine beschreibende Bezeichnung. |
| Beschreibung | Erklärt den Zweck des Flows. Dieser Text ist nur intern sichtbar.|
| Zeitzone | Erforderlich, um den Sendezeitraum zu begrenzen. |
| Nach der Registrierung die Person aus diesen anderen Flows entfernen | Wenn aktiviert, ändert sich der Status des Teilnehmers zu *Abbruch*, und er verlässt die ausgewählten Flows. Beispiel: Entfernen aus Lead nurturing, wenn in den Onboarding-Flow aufgenommen. |
| Eigentumer | Mitarbeiter, der den Flow erstellt |
| Sichtbar für | Zugriff auf den Flow (Besitzer, Besitzergruppe, alle). Das Zugriffsniveau wird auch durch funktionale Rechte gesteuert. |
| Ordner | Der Speicherort des Flows. |

### E-Mail (Einstellungen)

Gemeinsame E-Mail-Einstellungen für alle E-Mails im Flow​. Wenn Sie nicht planen, E-Mails aus diesem Flow zu senden, können Sie die Einstellungen für das E-Mail-Abonnement überspringen.

| Einstellung | Beschreibung |
|---|---|
| Abonnementtyp | Auf Flussebene festlegen (anstatt individuell für jeden E-Mail-Schritt). Stellt sicher, dass alle E-Mails innerhalb einen Flow denselben Abonnementtyp haben. |
| Von, Absendername, Absenderadresse | Derselbe Absender auf allen E-Mail-Schritten im Flow. Wählen Sie im **Von**-Menü **Immer verwenden** aus und geben Sie die E-Mail-Adresse des Absenders im Feld unten ein, um denselben Absender für alle Sendungen zu verwenden. Sie können auch einen Vertriebskontakt oder Supportkontakt als Absender auswählen, sofern einer für diesen Empfänger definiert ist. Geben Sie eine E-Mail-Adresse ein, die verwendet werden soll, wenn kein Vertriebskontakt oder Supportkontakt verfügbar ist. Wenn Ihr Administrator die [globale E-Mail-Validierungseinstellung][12] aktiviert hat, wählen Sie die Domain aus, von der Sie senden möchten, aus der Dropdown-Liste aus. |
| Antwort an | Die gleichen Optionen wie oben. Darüber hinaus können Sie **"Von" als Antwortadresse verwenden** auswählen. Alle Antworten werden dann an den Absender gesendet. |
| E-Mails und SMS nür innerhalb eines bestimmten Zeitrahmens versenden | Begrenzt den Sendezeitraum. Teilnehmer warten in diesem Schritt, bis der erlaubte Zeitraum beginnt​. Wählen Sie zwischen Werktag (Mo-Fr) und Wochentag (Mo-So). Geben Sie die Uhrzeit an. Erfordert, dass die Zeitzone festgelegt ist.​|
| Google Analytics verwenden | Aktiviert das Google Analytics-Tracking für alle E-Mails in einem Flow. Wenn aktiviert, können Sie Quelle und Kampagne festlegen. |

> [!TIP]
> Die Zeit beeinflusst die E-Mail-Öffnungsrate und Interaktion. Verwenden Sie die Einstellung **Zeitrahmen**, um die Interaktion der Leser zu maximieren und Ihre Abonnenten während der Nacht nicht zu stören.

![Gemeinsame E-Mail-Einstellungen für neuen Flow festlegen -screenshot][img2]

### Erfolgskriterien (optional)

Erfolgskriterien definieren [was Erfolg für einen Flow bedeutet][7].

1. Wählen Sie **Erfolg** im linken Menü aus.
1. Klicken Sie auf **Erfolgskriterien hinzufügen** und wählen Sie eine Option aus.
1. Wählen Sie optional **Der Teilnehmer wird direkt zum Schritt Abgeschlossen weitergeleitet, sobald die Erfolgskriterien erfüllt sind.

    * Wenn aktiviert: Der Status des Teilnehmers ändert sich auf *Mit Erfolg abgeschlossen*, und er wird aus allen anderen Aktionen im Flow entfernt.

    * Wenn nicht aktiviert: Der Status des Teilnehmers bleibt *Aktiv*, und er setzt den Flow fort. Wenn er den **Abgeschlossen**-Schritt erreicht, ändert sich sein Status auf *Mit Erfolg abgeschlossen*. Verwenden Sie diese Option, wenn die Erfolgsquote hauptsächlich für Statistiken verwendet wird und Sie möchten, dass der Teilnehmer alle Schritte abschließt, auch wenn der Erfolg erreicht ist.

![Erfolgskriterien für neuen Flow festlegen -screenshot][img3]

## <a id="trigger"></a>Flow-Trigger und Filter definieren

Der **Trigger**-Schritt wird automatisch als Startpunkt für jeden Flow hinzugefügt. Er bestimmt, für wen der Flow relevant ist. Trigger werden nur für Flows in Bearbeitung oder pausiert aktiviert.

> [!NOTE]
> Es *ist* möglich, einen Flow ohne automatischen Trigger zu erstellen - durch Verwendung des Kontaktaufgabenmenüs oder einer Selektion Aufgabe.​ Wir werden diesen speziellen Fall in einem anderen Thema besprechen.

1. Wählen Sie **Schritte** im linken Menü aus.
1. Klicken Sie auf den **Trigger**-Schritt im Diagramm.
1. Klicken Sie in den Trigger-Einstellungen auf der rechten Seite auf **Trigger hinzufügen** und wählen Sie eine Option aus.
1. Geben Sie die erforderlichen Einstellungen für den ausgewählten Trigger ein.
1. Geben Sie optional zusätzliche Qualifizierungskriterien an.
1. Wählen Sie optional **Ein Person kann diesen Flow nur einmal starten**. Wenn ein Flow ein zweites Mal für denselben Person ausgelöst wird, wird sichergestellt, dass sie nicht erneut eingeschrieben werden.

![Trigger für neuen Flow hinzufügen -screenshot][img5]

| Trigger | Beschreibung |
|---|---|
| Kontakt erstellt | Wenn ein neuer Person registriert wird, unabhängig von der Quelle (außer Import). |
| Kontakt aktualisiert | Wenn ein Person aktualisiert wird, unabhängig davon, was aktualisiert wird (außer Import und Massenupdate). |
| Verkauf erstellt | Wenn ein Verkauf beim Person registriert wird. |
| Durchgeführter Verkauf | Wenn ein Verkauf beim Person als verkauft markiert wird. |
| Verlorener Verkauf | Wenn ein Verkauf beim Person als verloren markiert wird. |
| Zu Projekt hinzugefügt | Wenn der Person als Projektmitglied hinzugefügt wird. |
| Anfrage erstellt | Wenn eine Anfrage beim Person erstellt wird (unabhängig von der Quelle). |
| Formular übermittelt | Wenn ein Formular (von einem Person eingereicht) **verarbeitet** wird (es könnte ein manueller Schritt erforderlich sein, bevor der Person im Flow landet​​). |
| Link angeklickt | Wenn ein Person auf einen verfolgten Link klickt. |

**Hinweis:**

* Wenn Sie *Formular übermittelt* oder *Link angeklickt* auswählen, beachten Sie eventuelle Warnsymbole. Formulare und verfolgte Links können auch zugehörige Aktionen haben.
* Um Persone einzuschließen, die über einen Import erstellt oder aktualisiert wurden, müssen Sie importierte Persone manuell aus der Selektion zu einem Flow hinzufügen.
* Beim Auslösen bei Kontaktaktualisierung haben wir Zugriff auf die aktuellen Werte der Kontaktfelder. Wir haben jedoch keine Informationen darüber, welches Feld aktualisiert wurde oder den vorherigen Wert eines Feldes vor die Aktualisierung.

### Personfilter hinzufügen (optional)

**Filter** sind zusätzliche Regeln, die auf alle vorgeschlagenen Teilnehmer angewendet werden (automatisch und manuell hinzugefügt).​ Verwenden Sie den Personfilter, um spezifische Persone für Ihren Flow auszuwählen. Legen Sie beispielsweise den Filter auf *Kontaktkategorie = Interessent* fest, um nur Interessenten in den Flow zu lassen, nicht jedoch bestehende Kunden, die ein Formular auf Ihrer Website ausfüllen. Dies ermöglicht es Ihnen, Inhalte an verschiedene Benutzergruppen anzupassen.

> [!NOTE]
> Filter werden nur beim **Identifizieren neuer Flow-Teilnehmer** angewendet. Änderungen am Filter nachträglich haben keine Auswirkungen auf bereits eingeschriebene Teilnehmer.

1. Wählen Sie das Kontaktfeld aus, nach dem Sie filtern möchten.
1. [Wählen Sie Werte für das Kriterium][13] in den verschiedenen Feldern in der Zeile aus (ähnlich wie im Finden-Bildschirm).
1. Klicken Sie auf **Hinzufügen**, um zusätzliche Kriterien festzulegen (fügt eine neue Zeile hinzu).

![Personfilter für Trigger des neuen Flow hinzufügen -screenshot][img6]

### Ausschlussliste (optional)

Die Ausschlussliste **verhindert, dass ausgewählte Persone dem Flow hinzugefügt werden**. Verwenden Sie eine [statische Selektion][14], um Ausnahmen zu behandeln, wie zum Beispiel:

* Verhindern, dass bestimmte Kunden allgemeine Massen-E-Mails erhalten.
* Erinnerungen senden, aber nicht an diejenigen, die bereits angemeldet sind.

## <a id="add-step"></a>Schritt hinzufügen

1. Wählen Sie **Schritte** im linken Menü aus.
1. Wählen Sie einen Schritt aus und ziehen Sie ihn an die gewünschte Stelle im Diagramm.
1. Das Schrittfeld ändert sich in **Schritteinstellungen**. [Verfügbare Einstellungen][9] hängen vom Typ des Schritts ab.

    * [Nachricht senden][3]
    * Ablaufsteuerung
    * [Teilnehmer aktualisieren][4]
    * [Aktivität erstellen][5]
    * [Interne Aktionen][10]

Klicken Sie auf das X im Kopfbereich der Schritteinstellungen, um zum Schrittfeld zurückzukehren.

### Der erste Schritt

Wenn Sie **Schritte** zum ersten Mal öffnen, sehen Sie etwas Ähnliches wie dies:

![Flow-Schritte -screenshot][img4]

* Ein Diagramm mit einem **Trigger**, einem **Platzhalter** zum Hinzufügen eines Schritts und einem **Abgeschlossen**-Schritt (in der Mitte).
* Eine Liste der verfügbaren Schritttypen (rechts).

## <a id="wait"></a>Ablaufsteuerung

Die meisten Schritte in einem Flow repräsentieren Aktionen, die sich auf den Teilnehmer beziehen, wie z.B. das Aktualisieren von Kontaktinteressen. Ablaufsteuerungsschritte sind jedoch anders; sie beinhalten **Timing** und **Segmentierung**.

Ohne Ablaufsteuerung würden Einzelpersonen von einer Aktion zur nächsten fortschreiten, bis sie entweder ausscheiden oder das Ende des Flow erreichen. Beispielsweise könnten sie das gesamte Onboarding-Programm an einem Tag erhalten oder alle Newsletter gleichzeitig erhalten.

Darüber hinaus würden ohne Ablaufsteuerung alle eingeschriebenen Personen dieselbe Abfolge von Schritten befolgen. Durch Festlegen von Bedingungen für nachfolgende Aktionen können Sie beispielsweise einen Newsletter in der bevorzugten Sprache des Persons senden oder eine Feedback-Umfrage nur an diejenigen senden, die am Webinar teilgenommen haben.

**Optionen:**

* Wartezeit
* Auf Aktion warten
* [Aufteilen][1]

> [!NOTE]
> Teilnehmer werden mit einem **Warten bis**-Zeitstempel markiert, wenn sie einen Warteschritt erreichen. Wenn der nächste Schritt eine E-Mail oder SMS ist und in den E-Mail-Einstellungen ein begrenzter Zeitrahmen festgelegt ist, kann die Gesamtwartezeit die im Schritt festgelegte überschreiten.

Here is the translated text in German with the appropriate formatting for Markdown:

### Wartezeit

Verwenden Sie einen zeitbasierten Warte-Schritt, um eine bestimmte Anzahl von Tagen zu warten, bevor Sie die nächste E-Mail/SMS senden, oder um bis zu einem bestimmten Datum für bestimmte Anlässe oder Aktionen zu warten. Zum Beispiel, um Erinnerungen 1 Woche, 1 Tag und 1 Stunde vor einem Webinar zu senden.

1. Ziehen Sie das **Wartezeit**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagramm fallen.
1. Stellen Sie die Bedingung ein. Wählen Sie eine der folgenden Optionen:

    * Wählen Sie **Anzahl der Tage/Stunden nach dem vorherigen Schritt** und wählen Sie dann die Anzahl und Einheit aus.
    * Oder wählen Sie **Bis zum bestimmten Datum/bestimmter Uhrzeit** und wählen Sie ein Datum aus dem Kalender.

Aktive Flowteilnehmer bleiben an diesem Schritt, bevor sie gemäß der definierten Regel zum nächsten Schritt übergehen.

![Flow-Schritt Wartezeit -screenshot][img7]

### Auf Aktion warten

Verwenden Sie einen aktionsbasierten Warte-Schritt, um darauf zu warten, dass der Teilnehmer etwas tut (ein Formular absendet oder einen Link angeklickt).

1. Ziehen Sie das **Auf Aktion warten**-Feld aus dem Schrittmenü und lassen Sie es in einem verfügbaren Slot im Diagramm fallen.

2. Klicken Sie auf **Aktion hinzufügen** und wählen Sie aus, auf welche Aktion gewartet werden soll.

3. Wählen Sie aus der Liste den Namen des Links oder Formulars, auf den gewartet werden soll.

4. Geben Sie an, wie lange Sie bereit sind, auf eine Aktion zu warten (ein Timeout). Die maximale Wartezeit beträgt standardmäßig 7 Tage. Wenn Sie diese Einstellung deaktivieren, bleiben Teilnehmer, die nicht antworten, unbegrenzt an diesem Schritt.

5. Optional wählen Sie **Flow beenden, wenn innerhalb der maximalen Wartezeit keine Aktionen ausgeführt werden**. Teilnehmer, die nicht antworten, verlassen den Flow mit dem Status *Abbruch*. Sie können diese Teilnehmer einem anderen Flow hinzufügen und/oder einer statischen Selektion hinzufügen.

![Flow-Schritt auf Aktion warten -screenshot][img8]

> [!TIP]
> Sie können innerhalb eines Schrittes auf mehr als eine Aktion warten. Die zuerst auftretende Aktion (Formularabsendung, Link-Klick oder Timeout) bewegt den Teilnehmer weiter im Flow. Wiederholen Sie einfach die Schritte 2 und 3 oben.

## Was passiert jetzt?

Nach dem Entwerfen eines Flows und dem Speichern schließt sich der **Flow-Editor**, und das Diagramm wird im Bildschirm **Flow anzeigen** angezeigt. Der neue Flow hat den Status **Wird nicht ausgeführt**, bis ein Flow-Administrator ihn manuell startet, indem er ausgeführt = true umschaltet.

## Verwandte Inhalte

* [Schritt verschieben, duplizieren oder entfernen][2]
* [Flow-Aktionen definieren][3]
* [Flow aufteilen][1]
* [Flow starten][6]

<!-- Referenced links -->
[1]: split.md
[2]: update.md
[3]: define-flow-actions.md
[4]: define-flow-actions.md#update
[5]: define-flow-actions.md#create
[10]: define-flow-actions.md#internal
[6]: run-pause-end.md
[7]: index.md#success
[9]: step-settings.md
[8]: ../../learn/create-folder.md
[12]: ../../../admin/lists/learn/add-items-to-mailing-domain.md
[13]: ../../../search-options/learn/search-criteria.md
[14]: ../../../search-options/selection/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-settings.png
[img2]: ../../../../media/loc/en/marketing/flow-email-settings.png
[img3]: ../../../../media/loc/en/marketing/flow-success-form-submission.png
[img4]: ../../../../media/loc/en/marketing/flow-steps-initial.png
[img5]: ../../../../media/loc/en/marketing/trigger-form-submitted.png
[img6]: ../../../../media/loc/en/marketing/flow-trigger-filter-contact.png
[img7]: ../../../../media/loc/en/marketing/flow-wait-time.png
[img8]: ../../../../media/loc/en/marketing/flow-wait-action.png
