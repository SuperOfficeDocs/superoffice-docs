---
uid: help-de-service-settings-system-settings
title: Benutzereinstellungen für SuperOffice Service
description: Globale Einstellungen für Benutzereinstellungen für SuperOffice Service
author: SuperOffice RnD
date: 03.27.2023
keywords: Service, Einstellungen
topic: help
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Globale Einstellungen für Benutzereinstellungen für SuperOffice Service

Gehen Sie im Navigator zum <i class="ph ph-gear" aria-hidden="true"></i> **Einstellungen** und wählen Sie die Registerkarte **Globale Einstellungen** aus. Der Bereich für **Benutzereinstellungen für SuperOffice Service** enthält folgende Optionen:

* **Standardschriftart im Editor**: Wählen Sie aus, welche Schrift, Schriftgröße und Formatierung als Standard für die Registrierungsmitteilung verwendet werden.

* **Standardgröße der Schriftart**: Größe der Standardschrift im Anfrage-Editor.

* **Standardstärke der Schriftart**: Gewichtung (Stärke) der Standardschrift im Anfrage-Editor.

* **E-Mail-Benachrichtigung für offene Anfragen senden**: Gibt an, ob E-Mails über offene Anfragen an die Benutzer gesendet werden. Wenn Sie **Benutzer kann wählen** auswählen, können die Benutzer die E-Mail-Benachrichtigung von <i class="ph ph-user-circle" aria-hidden="true"></i> **Persönliche Einstellungen** > **Einstellungen** > **Benachrichtigung mittels E-Mail und SMS** aktivieren oder deaktivieren.

* **Neuer Status bei Akzeptieren einer Anfrage**: Wählen Sie den zu verwendenden Status aus, wenn ein Benutzer eine Anfrage akzeptiert.

* **Anzahl der Tage bis zur Benachrichtigung**: Hier legen Sie fest, wie viele Tage verstreichen müssen, bevor eine E-Mail-Benachrichtigung über ältere Anfragen an die Benutzer gesendet wird. Sie können auch festlegen, zu welcher Uhrzeit die Benachrichtigung gesendet wird.

* **Tageszeit**: Die Tageszeit für das Senden von Benachrichtigungen.

* **Systemadministrator**: Dieses Feld enthält die E-Mail-Adresse der Person, die für den Betrieb von SuperOffice Service verantwortlich ist. Hierbei muss es sich um eine E-Mail-Adresse handeln, die nicht in SuperOffice Service importiert/verarbeitet wurde.

* **Standardabsender**: Die Absenderadresse der Standard-E-Mail des Systems. Diese Adresse wird normalerweise durch die Adressen ersetzt, die für die Postfächer eingegeben wurden. Hierbei muss es sich um eine E-Mail-Adresse handeln, die in SuperOffice Service importiert wurde. Zum Beispiel, `<support@company.com>`.

* **E-Mail-Tag**: Aus diesem E-Mail-Tag und der Anfragenummer wird eine eindeutige Kennung in der Betreffzeile von E-Mails erzeugt, die mit SuperOffice Service gesendet werden. Ändern Sie diesen Wert nur, wenn Sie mit den Auswirkungen vertraut sind. Eine Änderung kann zur Folge haben, dass erhaltene E-Mails vorhandenen Anfragen nicht richtig verknüpft werden.

* **Systemzeit**: Wählen Sie, ob ein 24-Stunden-Format und ein 12-Stunden-Format (am/pm) verwendet werden soll. Benutzerspezifische Zeitangaben (zum Beispiel die Anzeige von Anfragen) werden durch die Einstellungen des jeweiligen Benutzers und nicht durch diesen Wert gesteuert.

* **Standardstil für abgehende E-Mails**: Hier können Sie einen Standardstil definieren, das für E-Mails im HTML-Format verwendet wird. Beispiel: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Mindestwert für FAQ-Suchergebnisse (in Prozent)**: Bei Antwortvorlagen, die an Kunden gesendet werden, können Sie [automatische Vorschläge für FAQ-Einträge][1] hinzufügen, mit denen der Kunde seine Anfrage eventuell selbst lösen kann. In diesem Feld können Sie angeben, wie hoch ein Korrelationsgrad zwischen der Kundenanfrage und einem FAQ-Eintrag sein muss, damit ein FAQ-Eintrag zur Antwort an einen Kunden hinzugefügt wird. Wenn Sie hier einen zu niedrigen Wert festlegen, ist es möglich, dass der Kunde viele FAQs erhält, die für die Anfrage nicht relevant sind. Wenn eine Kundenanfrage mit einem Schlüsselwort in einem FAQ-Eintrag korreliert, wird der FAQ-Eintrag immer hinzugefügt.

* **Zeitrahmen in Minuten für zugehörige Nachrichten**: Hier geben Sie eine Anzahl von Minuten ein. Wenn innerhalb dieses Zeitraums zwei oder mehr E-Mails von derselben Person eingehen, werden die Anfragen nach Möglichkeit an denselben Bearbeiter gesendet.

* **Grenzwert für Benutzerinaktivität (in Stunden)**: Nach der festgelegten Anzahl von Stunden ohne Benutzeraktivität gilt der Benutzer als inaktiv (standardmäßig 2 Stunden). Dies wird beispielsweise bei der Aufteilung von Anfragen genutzt.

* **Zugriffsstufe 'Extern' ist voreingestellt**: Wenn diese Option aktiviert ist, wird neuen Anfragen und Nachrichten standardmäßig die Zugriffsstufe Extern zugewiesen. Andernfalls wird die Zugriffsstufe Intern als Standard verwendet.

* **Keine E-Mail an neue Personen senden**: Wenn Sie diese Option aktivieren, werden keine E-Mails an neu erfasste Personen gesendet.

* **Person für neue eingehende Anfrage automatisch erstellen**: Wenn Sie diese Option aktivieren, erstellt SuperOffice automatisch eine neue Person, wenn eine E-Mail-Adresse in einer eingehenden Anfrage nicht erkannt wird. Diese Option kann für die Einhaltung der DSGVO deaktiviert werden.

* **Bearbeitung von Nachrichten zulassen**: Wenn diese Option aktiviert ist, kann der Benutzer Nachrichten bearbeiten.

* **Alle Links überwachen**: Schauen Sie hier, um alle Links in Kampagnen zu überwachen.

* **Interne URL**: Die Basisadresse für den Zugriff auf das SuperOffice Service-System. (nur VOR ORT)

* **Externe URL**: Die Basisadresse für den externen Zugriff auf das SuperOffice Service-System. (nur VOR ORT)

* **Cgi-Bin-Pfad**: Der Pfad des Ordners, in dem sich die Cgi-Bin-Anwendungsdateien von SuperOffice Service befinden. Der Pfad muss mit einem Trennzeichen (Schrägstrich) eingeleitet werden, darf aber nicht mit einem Trennzeichen enden. Zum Beispiel: */bin* oder */Scripts*. (nur VOR ORT)

* **Benutzerauthentifizierung über Webserver**: Wenn diese Option aktiviert ist, gestattet SuperOffice Service die Benutzerauthentifizierung vom Web-Server (Microsoft IIS). (nur VOR ORT)

* **Kundenauthentifizierung über Webserver**: Wenn diese Option aktiviert ist, gestattet SuperOffice Service die Benutzerauthentifizierung vom Web-Server des Kundenzentrums (Microsoft IIS). (nur VOR ORT)

* **Online im Internet**: Aktivieren Sie diese Option, wenn SuperOffice Service im Internet verfügbar ist. Damit steuern Sie Teile der in SuperOffice Service verfügbaren Funktionen, weil für einige Funktionen das System online sein muss. (nur VOR ORT)

<!-- Referenced links -->
[1]: ../../../../request/reply-templates/learn/create.md#faq
