---
uid: help-de-form-field-options
title: Feldoptionen
description: Feldoptionen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulare
so.topic: reference
language: de
---

# Feldoptionen

Im Folgenden finden Sie eine Übersicht über spezielle Optionen in einigen verfügbaren Feldern.

## SuperOffice-Elemente

* **Ersetzen**: Wählen Sie diese Option, um einen in SuperOffice vorhandenen Wert durch den Wert im Formular zu ersetzen. Dies ist für Angaben wie Land, Titel und Anrede (Herr/Frau) relevant.

* **Person - Einwilligung**

  * **Zweck**: Wählen Sie aus, warum die Person ihre Zustimmung geben muss. Genehmigungstext und Beschreibung sind in Einstellungen und Verwaltung definiert.

  * **Link zu Datenschutzerklärung**: Wählen Sie diese Option aus, um den Link zur Datenschutzerklärung einzufügen,[!include[SM](../../../learn/includes/as-defined-sm.md)]

* **Person - Abonnement**: Wählen Sie die Abonnements, die im Formular zu sehen sein sollen.

* **Name der Firma: Vorhandene Firma verwenden, falls gefunden**.

  * Wenn diese Option auf EIN gesetzt ist: Wenn eine Person ein Formular übermittelt, bei dem der Firmennamen mit einer Firma in SuperOffice übereinstimmt, wird die Person automatisch als neue Person zu der Firma hinzugefügt.

  * Wenn diese Option auf AUS gesetzt ist: Die Person und die Firma werden zu SuperOffice hinzugefügt.

  > [!NOTE]
  > Normalerweise ist diese Option auf AUS gesetzt, damit Personen nicht zu Firmen hinzugefügt werden, zu denen sie nicht gehören.

## Formularelemente

* **Textfeld**: Ein einfaches, 1-zeiliges Textfeld.

* **Textbereich**: Ein großes, mehrzeiliges Textfeld.

* **Optionsfelder**: Ein Auswahlfeld, in dem einer von mehreren Werten ausgewählt werden kann.

  * **Vertikal**: Hiermit legen Sie fest, ob die Werte horizontal oder vertikal angezeigt werden.

  * **Daten**: Hier geben Sie die Werte für die einzelnen Optionsfelder ein. Geben Sie einen Wert in das Feld ein und klicken Sie auf die Plus-Schaltfläche ![Symbol][img1]. Wiederholen Sie diesen Schritt, um weitere Werte hinzuzufügen.

* **Kontrollkästchen**: Ein Auswahlfeld, in dem mehrere Werte ausgewählt werden können.

  * **Vertikal**: Hiermit legen Sie fest, ob die Werte horizontal oder vertikal angezeigt werden.

  * **Daten**: Hier geben Sie die Werte für die einzelnen Kontrollkästchen ein. Geben Sie einen Wert in das Feld ein und klicken Sie auf die Plus-Schaltfläche ![Symbol][img1]. Wiederholen Sie diesen Schritt, um weitere Werte hinzuzufügen.

* **Dropdown**: Ein Auswahlfeld, in dem ein Wert aus einer Liste ausgewählt werden kann.

  * **Daten**: Hier geben Sie die Listenwerte ein. Geben Sie einen Wert in das Feld ein und klicken Sie auf die Plus-Schaltfläche ![Symbol][img1]. Wiederholen Sie diesen Schritt, um weitere Werte hinzuzufügen.

* **Verborgen**: Ein Feld, das im veröffentlichten Formular nicht sichtbar ist. In das Feld **Standardwert** können Sie einen Code, einen Projektnamen bzw. eine Projektnummer oder andere Informationen eingeben, die diesem Formular zugeordnet werden sollen.

* **Datum**: Ein Datumsfeld.

* **Datei hochladen**: Ein Feld zum Hochladen von Dateien.

  * **Mehrere Dateien zulassen**: Wählen Sie diese Option, wenn es möglich sein soll, mehrere Dateien hochzuladen.

  * **Maximale Dateigröße (KB)**: Geben Sie die maximale Größe in KB ein, um die Größe der hochgeladenen Dateien zu begrenzen. Lassen Sie das Feld leer, wenn die Dateigröße nicht begrenzt sein soll.

  * **Genehmigte Dateitypen**: Geben Sie die Dateitypen ein, die hochgeladen werden dürfen. Verwenden Sie das Format *jpg,gif,png,bmp* (durch Komma getrennt, keine Leerzeichen). Lassen Sie das Feld leer, wenn alle Dateitypen zulässig sein sollen.

* **Bewertung**: Ein Feld, in dem Kunden beispielsweise den erhaltenen Service mit verschiedenen Bewertungstypen (Sterne, Würfel, Skala von 1 bis 10 usw.) bewerten können.

* **Google reCAPTCHA**: Die [reCAPTCHA-Funktion][1] (Kontrollkästchen "Ich bin kein Roboter") ist ein kostenloser Google-Dienst, der sicherstellt, dass nur echte Benutzer Web-Formulare übermitteln können. Dadurch wird verhindert, dass Spam und automatisierte Bots Ihre Datensammlung sabotieren können.

## Ansichtselemente

* **Textblock**: Geben Sie Text ein, der im Formular angezeigt werden soll, beispielsweise eine kurze Einführung oder eine ausführliche Beschreibung. Klicken Sie auf **Symbolleiste ein-/ausblenden** ![Symbol][img2], um Formatierungsoptionen für den Text anzuzeigen. Klicken Sie auf **Texteditor im Dialogfeld öffnen** ![Symbol][img3], um den Text in einem größeren Editor zu bearbeiten.

* **Bild**: Fügen Sie ein Bild zum Formular hinzu. Klicken Sie auf den Link, um ein Bild auszuwählen, oder ziehen Sie ein Bild auf das Feld **Bild** und legen Sie es dort ab. Mit den Optionsfeldern **Position** können Sie das Bild im Formular positionieren.

* **Bereich**: Fügen Sie einen Bereich zwischen den Feldern ein, damit Sie ein [mehrseitige Formular erstellen][2] können. Dies ist nützlich, wenn das Formular viele Felder enthält und Sie übermäßiges Scrollen vermeiden wollen.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/marketing/forms/recaptcha.html
[2]: create.md#multi-page

<!-- Referenced images -->
[img1]: ../../../../../common/icons/add-icon.png
[img2]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img3]: ../../../../../common/icons/pop-out-icon.png
